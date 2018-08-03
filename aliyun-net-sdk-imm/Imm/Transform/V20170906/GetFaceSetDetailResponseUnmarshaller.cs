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
    public class GetFaceSetDetailResponseUnmarshaller
    {
        public static GetFaceSetDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetFaceSetDetailResponse getFaceSetDetailResponse = new GetFaceSetDetailResponse();

			getFaceSetDetailResponse.HttpResponse = context.HttpResponse;
			getFaceSetDetailResponse.RequestId = context.StringValue("GetFaceSetDetail.RequestId");
			getFaceSetDetailResponse.SetId = context.StringValue("GetFaceSetDetail.SetId");
			getFaceSetDetailResponse.NextMarker = context.StringValue("GetFaceSetDetail.NextMarker");

			List<GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem> getFaceSetDetailResponse_faceDetails = new List<GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem>();
			for (int i = 0; i < context.Length("GetFaceSetDetail.FaceDetails.Length"); i++) {
				GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem faceDetailsItem = new GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem();
				faceDetailsItem.FaceId = context.StringValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceId");
				faceDetailsItem.SrcUri = context.StringValue("GetFaceSetDetail.FaceDetails["+ i +"].SrcUri");
				faceDetailsItem.PhotoId = context.StringValue("GetFaceSetDetail.FaceDetails["+ i +"].PhotoId");
				faceDetailsItem.GroupId = context.StringValue("GetFaceSetDetail.FaceDetails["+ i +"].GroupId");
				faceDetailsItem.UnGroupReason = context.StringValue("GetFaceSetDetail.FaceDetails["+ i +"].UnGroupReason");

				GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceRectangle faceRectangle = new GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceRectangle();
				faceRectangle.Top = context.IntegerValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceRectangle.Top");
				faceRectangle.Left = context.IntegerValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceRectangle.Left");
				faceRectangle.Width = context.IntegerValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceRectangle.Width");
				faceRectangle.Height = context.IntegerValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceRectangle.Height");
				faceDetailsItem.FaceRectangle = faceRectangle;

				GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute faceAttribute = new GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute();

				GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_Gender gender = new GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_Gender();
				gender._Value = context.StringValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.Gender.Value");
				faceAttribute.Gender = gender;

				GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_Age age = new GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_Age();
				age._Value = context.StringValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.Age.Value");
				faceAttribute.Age = age;

				GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_HeadPose headPose = new GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_HeadPose();
				headPose.PitchAngle = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.HeadPose.PitchAngle");
				headPose.RollAngle = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.HeadPose.RollAngle");
				headPose.YawAngle = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.HeadPose.YawAngle");
				faceAttribute.HeadPose = headPose;

				GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_EyeStatus eyeStatus = new GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_EyeStatus();

				GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_EyeStatus.GetFaceSetDetail_LeftEyeStatus leftEyeStatus = new GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_EyeStatus.GetFaceSetDetail_LeftEyeStatus();
				leftEyeStatus.NormalGlassEyeOpen = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.EyeStatus.LeftEyeStatus.NormalGlassEyeOpen");
				leftEyeStatus.NoGlassEyeClose = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.EyeStatus.LeftEyeStatus.NoGlassEyeClose");
				leftEyeStatus.Occlusion = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.EyeStatus.LeftEyeStatus.Occlusion");
				leftEyeStatus.NoGlassEyeOpen = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.EyeStatus.LeftEyeStatus.NoGlassEyeOpen");
				leftEyeStatus.NormalGlassEyeClose = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.EyeStatus.LeftEyeStatus.NormalGlassEyeClose");
				leftEyeStatus.DarkGlasses = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.EyeStatus.LeftEyeStatus.DarkGlasses");
				eyeStatus.LeftEyeStatus = leftEyeStatus;

				GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_EyeStatus.GetFaceSetDetail_RightEyeStatus rightEyeStatus = new GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_EyeStatus.GetFaceSetDetail_RightEyeStatus();
				rightEyeStatus.NormalGlassEyeOpen = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.EyeStatus.RightEyeStatus.NormalGlassEyeOpen");
				rightEyeStatus.NoGlassEyeClose = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.EyeStatus.RightEyeStatus.NoGlassEyeClose");
				rightEyeStatus.Occlusion = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.EyeStatus.RightEyeStatus.Occlusion");
				rightEyeStatus.NoGlassEyeOpen = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.EyeStatus.RightEyeStatus.NoGlassEyeOpen");
				rightEyeStatus.NormalGlassEyeClose = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.EyeStatus.RightEyeStatus.NormalGlassEyeClose");
				rightEyeStatus.DarkGlasses = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.EyeStatus.RightEyeStatus.DarkGlasses");
				eyeStatus.RightEyeStatus = rightEyeStatus;
				faceAttribute.EyeStatus = eyeStatus;

				GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_Blur blur = new GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_Blur();

				GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_Blur.GetFaceSetDetail_Blurness blurness = new GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_Blur.GetFaceSetDetail_Blurness();
				blurness._Value = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.Blur.Blurness.Value");
				blurness.Threshold = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.Blur.Blurness.Threshold");
				blur.Blurness = blurness;
				faceAttribute.Blur = blur;

				GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_FaceQuality faceQuality = new GetFaceSetDetailResponse.GetFaceSetDetail_FaceDetailsItem.GetFaceSetDetail_FaceAttribute.GetFaceSetDetail_FaceQuality();
				faceQuality._Value = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.FaceQuality.Value");
				faceQuality.Threshold = context.FloatValue("GetFaceSetDetail.FaceDetails["+ i +"].FaceAttribute.FaceQuality.Threshold");
				faceAttribute.FaceQuality = faceQuality;
				faceDetailsItem.FaceAttribute = faceAttribute;

				getFaceSetDetailResponse_faceDetails.Add(faceDetailsItem);
			}
			getFaceSetDetailResponse.FaceDetails = getFaceSetDetailResponse_faceDetails;
        
			return getFaceSetDetailResponse;
        }
    }
}