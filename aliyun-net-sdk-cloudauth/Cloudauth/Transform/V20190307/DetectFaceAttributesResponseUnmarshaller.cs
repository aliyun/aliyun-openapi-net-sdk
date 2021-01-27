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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class DetectFaceAttributesResponseUnmarshaller
    {
        public static DetectFaceAttributesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectFaceAttributesResponse detectFaceAttributesResponse = new DetectFaceAttributesResponse();

			detectFaceAttributesResponse.HttpResponse = _ctx.HttpResponse;
			detectFaceAttributesResponse.RequestId = _ctx.StringValue("DetectFaceAttributes.RequestId");
			detectFaceAttributesResponse.Success = _ctx.BooleanValue("DetectFaceAttributes.Success");
			detectFaceAttributesResponse.Code = _ctx.StringValue("DetectFaceAttributes.Code");
			detectFaceAttributesResponse.Message = _ctx.StringValue("DetectFaceAttributes.Message");

			DetectFaceAttributesResponse.DetectFaceAttributes_Data data = new DetectFaceAttributesResponse.DetectFaceAttributes_Data();
			data.ImgWidth = _ctx.IntegerValue("DetectFaceAttributes.Data.ImgWidth");
			data.ImgHeight = _ctx.IntegerValue("DetectFaceAttributes.Data.ImgHeight");

			List<DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo> data_faceInfos = new List<DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo>();
			for (int i = 0; i < _ctx.Length("DetectFaceAttributes.Data.FaceInfos.Length"); i++) {
				DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo faceAttributesDetectInfo = new DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo();

				DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceRect faceRect = new DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceRect();
				faceRect.Top = _ctx.IntegerValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceRect.Top");
				faceRect.Left = _ctx.IntegerValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceRect.Left");
				faceRect.Width = _ctx.IntegerValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceRect.Width");
				faceRect.Height = _ctx.IntegerValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceRect.Height");
				faceAttributesDetectInfo.FaceRect = faceRect;

				DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes faceAttributes = new DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes();
				faceAttributes.Age = _ctx.IntegerValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Age");
				faceAttributes.Glasses = _ctx.StringValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Glasses");
				faceAttributes.Facetype = _ctx.StringValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Facetype");
				faceAttributes.Blur = _ctx.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Blur");
				faceAttributes.Facequal = _ctx.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Facequal");
				faceAttributes.Integrity = _ctx.IntegerValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Integrity");
				faceAttributes.Respirator = _ctx.StringValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Respirator");
				faceAttributes.AppearanceScore = _ctx.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.AppearanceScore");

				DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes.DetectFaceAttributes_Gender gender = new DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes.DetectFaceAttributes_Gender();
				gender.Score = _ctx.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Gender.Score");
				gender._Value = _ctx.StringValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Gender.Value");
				faceAttributes.Gender = gender;

				DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes.DetectFaceAttributes_Smiling smiling = new DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes.DetectFaceAttributes_Smiling();
				smiling._Value = _ctx.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Smiling.Value");
				smiling.Threshold = _ctx.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Smiling.Threshold");
				faceAttributes.Smiling = smiling;

				DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes.DetectFaceAttributes_Headpose headpose = new DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes.DetectFaceAttributes_Headpose();
				headpose.PitchAngle = _ctx.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Headpose.PitchAngle");
				headpose.RollAngle = _ctx.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Headpose.RollAngle");
				headpose.YawAngle = _ctx.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Headpose.YawAngle");
				faceAttributes.Headpose = headpose;
				faceAttributesDetectInfo.FaceAttributes = faceAttributes;

				data_faceInfos.Add(faceAttributesDetectInfo);
			}
			data.FaceInfos = data_faceInfos;
			detectFaceAttributesResponse.Data = data;
        
			return detectFaceAttributesResponse;
        }
    }
}
