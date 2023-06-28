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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class DetectUserFaceByUrlResponseUnmarshaller
    {
        public static DetectUserFaceByUrlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectUserFaceByUrlResponse detectUserFaceByUrlResponse = new DetectUserFaceByUrlResponse();

			detectUserFaceByUrlResponse.HttpResponse = _ctx.HttpResponse;
			detectUserFaceByUrlResponse.Code = _ctx.StringValue("DetectUserFaceByUrl.Code");
			detectUserFaceByUrlResponse.ErrorMessage = _ctx.StringValue("DetectUserFaceByUrl.ErrorMessage");
			detectUserFaceByUrlResponse.RequestId = _ctx.StringValue("DetectUserFaceByUrl.RequestId");
			detectUserFaceByUrlResponse.Success = _ctx.BooleanValue("DetectUserFaceByUrl.Success");

			List<DetectUserFaceByUrlResponse.DetectUserFaceByUrl_DataItem> detectUserFaceByUrlResponse_data = new List<DetectUserFaceByUrlResponse.DetectUserFaceByUrl_DataItem>();
			for (int i = 0; i < _ctx.Length("DetectUserFaceByUrl.Data.Length"); i++) {
				DetectUserFaceByUrlResponse.DetectUserFaceByUrl_DataItem dataItem = new DetectUserFaceByUrlResponse.DetectUserFaceByUrl_DataItem();
				dataItem.BlurScore = _ctx.FloatValue("DetectUserFaceByUrl.Data["+ i +"].BlurScore");
				dataItem.Gender = _ctx.IntegerValue("DetectUserFaceByUrl.Data["+ i +"].Gender");
				dataItem.OcclusionScore = _ctx.FloatValue("DetectUserFaceByUrl.Data["+ i +"].OcclusionScore");
				dataItem.GoodForLibrary = _ctx.BooleanValue("DetectUserFaceByUrl.Data["+ i +"].GoodForLibrary");
				dataItem.GoodForRecognition = _ctx.BooleanValue("DetectUserFaceByUrl.Data["+ i +"].GoodForRecognition");
				dataItem.Age = _ctx.IntegerValue("DetectUserFaceByUrl.Data["+ i +"].Age");
				dataItem.FaceProbability = _ctx.FloatValue("DetectUserFaceByUrl.Data["+ i +"].FaceProbability");
				dataItem.PoseScore = _ctx.FloatValue("DetectUserFaceByUrl.Data["+ i +"].PoseScore");

				List<string> dataItem_faceRects = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectUserFaceByUrl.Data["+ i +"].FaceRects.Length"); j++) {
					dataItem_faceRects.Add(_ctx.StringValue("DetectUserFaceByUrl.Data["+ i +"].FaceRects["+ j +"]"));
				}
				dataItem.FaceRects = dataItem_faceRects;

				List<string> dataItem_landmarks = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectUserFaceByUrl.Data["+ i +"].Landmarks.Length"); j++) {
					dataItem_landmarks.Add(_ctx.StringValue("DetectUserFaceByUrl.Data["+ i +"].Landmarks["+ j +"]"));
				}
				dataItem.Landmarks = dataItem_landmarks;

				detectUserFaceByUrlResponse_data.Add(dataItem);
			}
			detectUserFaceByUrlResponse.Data = detectUserFaceByUrlResponse_data;
        
			return detectUserFaceByUrlResponse;
        }
    }
}
