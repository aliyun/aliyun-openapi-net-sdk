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
using Aliyun.Acs.Cloudauth.Model.V20180916;

namespace Aliyun.Acs.Cloudauth.Transform.V20180916
{
    public class DetectFaceAttributesResponseUnmarshaller
    {
        public static DetectFaceAttributesResponse Unmarshall(UnmarshallerContext context)
        {
			DetectFaceAttributesResponse detectFaceAttributesResponse = new DetectFaceAttributesResponse();

			detectFaceAttributesResponse.HttpResponse = context.HttpResponse;
			detectFaceAttributesResponse.RequestId = context.StringValue("DetectFaceAttributes.RequestId");
			detectFaceAttributesResponse.Success = context.BooleanValue("DetectFaceAttributes.Success");
			detectFaceAttributesResponse.Code = context.StringValue("DetectFaceAttributes.Code");
			detectFaceAttributesResponse.Message = context.StringValue("DetectFaceAttributes.Message");

			DetectFaceAttributesResponse.DetectFaceAttributes_Data data = new DetectFaceAttributesResponse.DetectFaceAttributes_Data();
			data.ImgWidth = context.IntegerValue("DetectFaceAttributes.Data.ImgWidth");
			data.ImgHeight = context.IntegerValue("DetectFaceAttributes.Data.ImgHeight");

			List<DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo> data_faceInfos = new List<DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo>();
			for (int i = 0; i < context.Length("DetectFaceAttributes.Data.FaceInfos.Length"); i++) {
				DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo faceAttributesDetectInfo = new DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo();

				DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceRect faceRect = new DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceRect();
				faceRect.Top = context.IntegerValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceRect.Top");
				faceRect.Left = context.IntegerValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceRect.Left");
				faceRect.Width = context.IntegerValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceRect.Width");
				faceRect.Height = context.IntegerValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceRect.Height");
				faceAttributesDetectInfo.FaceRect = faceRect;

				DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes faceAttributes = new DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes();
				faceAttributes.Age = context.IntegerValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Age");
				faceAttributes.Glasses = context.StringValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Glasses");
				faceAttributes.Facetype = context.StringValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Facetype");
				faceAttributes.Blur = context.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Blur");
				faceAttributes.Ethnicity = context.StringValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Ethnicity");

				DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes.DetectFaceAttributes_Gender gender = new DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes.DetectFaceAttributes_Gender();
				gender.Score = context.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Gender.Score");
				gender._Value = context.StringValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Gender.Value");
				faceAttributes.Gender = gender;

				DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes.DetectFaceAttributes_Smiling smiling = new DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes.DetectFaceAttributes_Smiling();
				smiling._Value = context.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Smiling.Value");
				smiling.Threshold = context.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Smiling.Threshold");
				faceAttributes.Smiling = smiling;

				DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes.DetectFaceAttributes_Headpose headpose = new DetectFaceAttributesResponse.DetectFaceAttributes_Data.DetectFaceAttributes_FaceAttributesDetectInfo.DetectFaceAttributes_FaceAttributes.DetectFaceAttributes_Headpose();
				headpose.PitchAngle = context.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Headpose.PitchAngle");
				headpose.RollAngle = context.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Headpose.RollAngle");
				headpose.YawAngle = context.FloatValue("DetectFaceAttributes.Data.FaceInfos["+ i +"].FaceAttributes.Headpose.YawAngle");
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
