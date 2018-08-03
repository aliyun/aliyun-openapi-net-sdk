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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetFaceDetailResponseUnmarshaller
    {
        public static GetFaceDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetFaceDetailResponse getFaceDetailResponse = new GetFaceDetailResponse();

			getFaceDetailResponse.HttpResponse = context.HttpResponse;
			getFaceDetailResponse.SetId = context.StringValue("GetFaceDetail.SetId");
			getFaceDetailResponse.FaceId = context.StringValue("GetFaceDetail.FaceId");
			getFaceDetailResponse.PhotoId = context.StringValue("GetFaceDetail.PhotoId");
			getFaceDetailResponse.PhotoUrl = context.StringValue("GetFaceDetail.PhotoUrl");
			getFaceDetailResponse.GroupId = context.StringValue("GetFaceDetail.GroupId");
			getFaceDetailResponse.RequestId = context.StringValue("GetFaceDetail.RequestId");

			GetFaceDetailResponse.GetFaceDetail_FaceRectangle faceRectangle = new GetFaceDetailResponse.GetFaceDetail_FaceRectangle();
			faceRectangle.Top = context.IntegerValue("GetFaceDetail.FaceRectangle.Top");
			faceRectangle.Left = context.IntegerValue("GetFaceDetail.FaceRectangle.Left");
			faceRectangle.Width = context.IntegerValue("GetFaceDetail.FaceRectangle.Width");
			faceRectangle.Height = context.IntegerValue("GetFaceDetail.FaceRectangle.Height");
			getFaceDetailResponse.FaceRectangle = faceRectangle;

			GetFaceDetailResponse.GetFaceDetail_FaceAttribute faceAttribute = new GetFaceDetailResponse.GetFaceDetail_FaceAttribute();

			GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_Gender gender = new GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_Gender();
			gender._Value = context.StringValue("GetFaceDetail.FaceAttribute.Gender.Value");
			faceAttribute.Gender = gender;

			GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_Age age = new GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_Age();
			age._Value = context.StringValue("GetFaceDetail.FaceAttribute.Age.Value");
			faceAttribute.Age = age;

			GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_HeadPose headPose = new GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_HeadPose();
			headPose.PitchAngle = context.FloatValue("GetFaceDetail.FaceAttribute.HeadPose.PitchAngle");
			headPose.RollAngle = context.FloatValue("GetFaceDetail.FaceAttribute.HeadPose.RollAngle");
			headPose.YawAngle = context.FloatValue("GetFaceDetail.FaceAttribute.HeadPose.YawAngle");
			faceAttribute.HeadPose = headPose;

			GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_EyeStatus eyeStatus = new GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_EyeStatus();

			GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_EyeStatus.GetFaceDetail_LeftEyeStatus leftEyeStatus = new GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_EyeStatus.GetFaceDetail_LeftEyeStatus();
			leftEyeStatus.NormalGlassEyeOpen = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.LeftEyeStatus.NormalGlassEyeOpen");
			leftEyeStatus.NoGlassEyeClose = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.LeftEyeStatus.NoGlassEyeClose");
			leftEyeStatus.Occlusion = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.LeftEyeStatus.Occlusion");
			leftEyeStatus.NoGlassEyeOpen = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.LeftEyeStatus.NoGlassEyeOpen");
			leftEyeStatus.NormalGlassEyeClose = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.LeftEyeStatus.NormalGlassEyeClose");
			leftEyeStatus.DarkGlasses = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.LeftEyeStatus.DarkGlasses");
			eyeStatus.LeftEyeStatus = leftEyeStatus;

			GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_EyeStatus.GetFaceDetail_RightEyeStatus rightEyeStatus = new GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_EyeStatus.GetFaceDetail_RightEyeStatus();
			rightEyeStatus.NormalGlassEyeOpen = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.RightEyeStatus.NormalGlassEyeOpen");
			rightEyeStatus.NoGlassEyeClose = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.RightEyeStatus.NoGlassEyeClose");
			rightEyeStatus.NormalGlassEyeClose = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.RightEyeStatus.NormalGlassEyeClose");
			rightEyeStatus.Occlusion = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.RightEyeStatus.Occlusion");
			rightEyeStatus.NoGlassEyeOpen = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.RightEyeStatus.NoGlassEyeOpen");
			rightEyeStatus.NormalGlassEyeClose1 = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.RightEyeStatus.NormalGlassEyeClose");
			rightEyeStatus.DarkGlasses = context.FloatValue("GetFaceDetail.FaceAttribute.EyeStatus.RightEyeStatus.DarkGlasses");
			eyeStatus.RightEyeStatus = rightEyeStatus;
			faceAttribute.EyeStatus = eyeStatus;

			GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_Blur blur = new GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_Blur();

			GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_Blur.GetFaceDetail_Blurness blurness = new GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_Blur.GetFaceDetail_Blurness();
			blurness._Value = context.FloatValue("GetFaceDetail.FaceAttribute.Blur.Blurness.Value");
			blurness.Threshold = context.FloatValue("GetFaceDetail.FaceAttribute.Blur.Blurness.Threshold");
			blur.Blurness = blurness;
			faceAttribute.Blur = blur;

			GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_FaceQuality faceQuality = new GetFaceDetailResponse.GetFaceDetail_FaceAttribute.GetFaceDetail_FaceQuality();
			faceQuality._Value = context.FloatValue("GetFaceDetail.FaceAttribute.FaceQuality.Value");
			faceQuality.Threshold = context.FloatValue("GetFaceDetail.FaceAttribute.FaceQuality.Threshold");
			faceAttribute.FaceQuality = faceQuality;
			getFaceDetailResponse.FaceAttribute = faceAttribute;
        
			return getFaceDetailResponse;
        }
    }
}