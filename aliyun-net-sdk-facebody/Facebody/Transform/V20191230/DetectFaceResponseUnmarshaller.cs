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
			data.LandmarkCount = _ctx.IntegerValue("DetectFace.Data.LandmarkCount");
			data.FaceCount = _ctx.IntegerValue("DetectFace.Data.FaceCount");

			List<string> data_faceProbabilityList = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.FaceProbabilityList.Length"); i++) {
				data_faceProbabilityList.Add(_ctx.StringValue("DetectFace.Data.FaceProbabilityList["+ i +"]"));
			}
			data.FaceProbabilityList = data_faceProbabilityList;

			List<string> data_faceRectangles = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.FaceRectangles.Length"); i++) {
				data_faceRectangles.Add(_ctx.StringValue("DetectFace.Data.FaceRectangles["+ i +"]"));
			}
			data.FaceRectangles = data_faceRectangles;

			List<string> data_landmarks = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.Landmarks.Length"); i++) {
				data_landmarks.Add(_ctx.StringValue("DetectFace.Data.Landmarks["+ i +"]"));
			}
			data.Landmarks = data_landmarks;

			List<string> data_poseList = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.PoseList.Length"); i++) {
				data_poseList.Add(_ctx.StringValue("DetectFace.Data.PoseList["+ i +"]"));
			}
			data.PoseList = data_poseList;

			List<string> data_pupils = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.Pupils.Length"); i++) {
				data_pupils.Add(_ctx.StringValue("DetectFace.Data.Pupils["+ i +"]"));
			}
			data.Pupils = data_pupils;

			DetectFaceResponse.DetectFace_Data.DetectFace_Qualities qualities = new DetectFaceResponse.DetectFace_Data.DetectFace_Qualities();

			List<string> qualities_noiseList = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.Qualities.NoiseList.Length"); i++) {
				qualities_noiseList.Add(_ctx.StringValue("DetectFace.Data.Qualities.NoiseList["+ i +"]"));
			}
			qualities.NoiseList = qualities_noiseList;

			List<string> qualities_scoreList = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.Qualities.ScoreList.Length"); i++) {
				qualities_scoreList.Add(_ctx.StringValue("DetectFace.Data.Qualities.ScoreList["+ i +"]"));
			}
			qualities.ScoreList = qualities_scoreList;

			List<string> qualities_blurList = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.Qualities.BlurList.Length"); i++) {
				qualities_blurList.Add(_ctx.StringValue("DetectFace.Data.Qualities.BlurList["+ i +"]"));
			}
			qualities.BlurList = qualities_blurList;

			List<string> qualities_maskList = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.Qualities.MaskList.Length"); i++) {
				qualities_maskList.Add(_ctx.StringValue("DetectFace.Data.Qualities.MaskList["+ i +"]"));
			}
			qualities.MaskList = qualities_maskList;

			List<string> qualities_glassList = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.Qualities.GlassList.Length"); i++) {
				qualities_glassList.Add(_ctx.StringValue("DetectFace.Data.Qualities.GlassList["+ i +"]"));
			}
			qualities.GlassList = qualities_glassList;

			List<string> qualities_fnfList = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.Qualities.FnfList.Length"); i++) {
				qualities_fnfList.Add(_ctx.StringValue("DetectFace.Data.Qualities.FnfList["+ i +"]"));
			}
			qualities.FnfList = qualities_fnfList;

			List<string> qualities_poseList1 = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.Qualities.PoseList.Length"); i++) {
				qualities_poseList1.Add(_ctx.StringValue("DetectFace.Data.Qualities.PoseList["+ i +"]"));
			}
			qualities.PoseList1 = qualities_poseList1;

			List<string> qualities_illuList = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectFace.Data.Qualities.IlluList.Length"); i++) {
				qualities_illuList.Add(_ctx.StringValue("DetectFace.Data.Qualities.IlluList["+ i +"]"));
			}
			qualities.IlluList = qualities_illuList;
			data.Qualities = qualities;
			detectFaceResponse.Data = data;
        
			return detectFaceResponse;
        }
    }
}
