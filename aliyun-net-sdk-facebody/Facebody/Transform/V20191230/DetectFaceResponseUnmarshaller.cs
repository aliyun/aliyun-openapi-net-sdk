/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class DetectFaceResponseUnmarshaller
    {
        public static DetectFaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectFaceResponse detectFaceResponse = new DetectFaceResponse();

			detectFaceResponse.HttpResponse = _ctx.HttpResponse;
			detectFaceResponse.RequestId = _ctx.StringValue("DetectFace.RequestId");

			DetectFaceResponse.DetectFace_Data data = new DetectFaceResponse.DetectFace_Data();
			data.FaceCount = _ctx.IntegerValue("DetectFace.Data.FaceCount");
			data.LandmarkCount = _ctx.IntegerValue("DetectFace.Data.LandmarkCount");

			List<string> data_faceRectangles = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.FaceRectangles.Length"); i++) {
				data_faceRectangles.Add(_ctx.StringValue("DetectFace.Data.FaceRectangles["+ i +"]"));
			}
			data.FaceRectangles = data_faceRectangles;

			List<string> data_faceProbabilityList = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.FaceProbabilityList.Length"); i++) {
				data_faceProbabilityList.Add(_ctx.StringValue("DetectFace.Data.FaceProbabilityList["+ i +"]"));
			}
			data.FaceProbabilityList = data_faceProbabilityList;

			List<string> data_poseList = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.PoseList.Length"); i++) {
				data_poseList.Add(_ctx.StringValue("DetectFace.Data.PoseList["+ i +"]"));
			}
			data.PoseList = data_poseList;

			List<string> data_landmarks = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.Landmarks.Length"); i++) {
				data_landmarks.Add(_ctx.StringValue("DetectFace.Data.Landmarks["+ i +"]"));
			}
			data.Landmarks = data_landmarks;

			List<string> data_pupils = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.Pupils.Length"); i++) {
				data_pupils.Add(_ctx.StringValue("DetectFace.Data.Pupils["+ i +"]"));
			}
			data.Pupils = data_pupils;
			detectFaceResponse.Data = data;
        
			return detectFaceResponse;
        }
    }
}
