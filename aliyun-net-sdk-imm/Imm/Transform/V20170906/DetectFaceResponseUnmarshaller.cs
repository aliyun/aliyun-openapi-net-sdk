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
    public class DetectFaceResponseUnmarshaller
    {
        public static DetectFaceResponse Unmarshall(UnmarshallerContext context)
        {
			DetectFaceResponse detectFaceResponse = new DetectFaceResponse();

			detectFaceResponse.HttpResponse = context.HttpResponse;
			detectFaceResponse.RequestId = context.StringValue("DetectFace.RequestId");

			List<string> detectFaceResponse_srcUris = new List<string>();
			for (int i = 0; i < context.Length("DetectFace.SrcUris.Length"); i++) {
				detectFaceResponse_srcUris.Add(context.StringValue("DetectFace.SrcUris["+ i +"]"));
			}
			detectFaceResponse.SrcUris = detectFaceResponse_srcUris;

			List<DetectFaceResponse.DetectFace_SuccessDetailsItem> detectFaceResponse_successDetails = new List<DetectFaceResponse.DetectFace_SuccessDetailsItem>();
			for (int i = 0; i < context.Length("DetectFace.SuccessDetails.Length"); i++) {
				DetectFaceResponse.DetectFace_SuccessDetailsItem successDetailsItem = new DetectFaceResponse.DetectFace_SuccessDetailsItem();
				successDetailsItem.SrcUri = context.StringValue("DetectFace.SuccessDetails["+ i +"].SrcUri");
				successDetailsItem.PhotoId = context.StringValue("DetectFace.SuccessDetails["+ i +"].PhotoId");

				List<DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem> successDetailsItem_faces = new List<DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem>();
				for (int j = 0; j < context.Length("DetectFace.SuccessDetails["+ i +"].Faces.Length"); j++) {
					DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem facesItem = new DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem();
					facesItem.FaceId = context.StringValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceId");

					DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceRectangle faceRectangle = new DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceRectangle();
					faceRectangle.Top = context.StringValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceRectangle.Top");
					faceRectangle.Left = context.StringValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceRectangle.Left");
					faceRectangle.Width = context.StringValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceRectangle.Width");
					faceRectangle.Height = context.StringValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceRectangle.Height");
					facesItem.FaceRectangle = faceRectangle;

					DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute faceAttribute = new DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute();

					DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_Gender gender = new DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_Gender();
					gender._Value = context.StringValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.Gender.Value");
					faceAttribute.Gender = gender;

					DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_Age age = new DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_Age();
					age._Value = context.IntegerValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.Age.Value");
					faceAttribute.Age = age;

					DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_HeadPose headPose = new DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_HeadPose();
					headPose.PitchAngle = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.HeadPose.PitchAngle");
					headPose.RollAngle = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.HeadPose.RollAngle");
					headPose.YawAngle = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.HeadPose.YawAngle");
					faceAttribute.HeadPose = headPose;

					DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_EyeStatus eyeStatus = new DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_EyeStatus();

					DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_EyeStatus.DetectFace_LeftEyeStatus leftEyeStatus = new DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_EyeStatus.DetectFace_LeftEyeStatus();
					leftEyeStatus.NormalGlassEyeOpen = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.LeftEyeStatus.NormalGlassEyeOpen");
					leftEyeStatus.NoGlassEyeClose = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.LeftEyeStatus.NoGlassEyeClose");
					leftEyeStatus.Occlusion = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.LeftEyeStatus.Occlusion");
					leftEyeStatus.NoGlassEyeOpen = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.LeftEyeStatus.NoGlassEyeOpen");
					leftEyeStatus.NormalGlassEyeClose = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.LeftEyeStatus.NormalGlassEyeClose");
					leftEyeStatus.DarkGlasses = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.LeftEyeStatus.DarkGlasses");
					eyeStatus.LeftEyeStatus = leftEyeStatus;

					DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_EyeStatus.DetectFace_RightEyeStatus rightEyeStatus = new DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_EyeStatus.DetectFace_RightEyeStatus();
					rightEyeStatus.NormalGlassEyeOpen = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.RightEyeStatus.NormalGlassEyeOpen");
					rightEyeStatus.NoGlassEyeClose = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.RightEyeStatus.NoGlassEyeClose");
					rightEyeStatus.Occlusion = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.RightEyeStatus.Occlusion");
					rightEyeStatus.NoGlassEyeOpen = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.RightEyeStatus.NoGlassEyeOpen");
					rightEyeStatus.NormalGlassEyeClose = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.RightEyeStatus.NormalGlassEyeClose");
					rightEyeStatus.DarkGlasses = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.RightEyeStatus.DarkGlasses");
					eyeStatus.RightEyeStatus = rightEyeStatus;
					faceAttribute.EyeStatus = eyeStatus;

					DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_Blur blur = new DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_Blur();

					DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_Blur.DetectFace_Blurness blurness = new DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_Blur.DetectFace_Blurness();
					blurness._Value = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.Blur.Blurness.Value");
					blurness.Threshold = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.Blur.Blurness.Threshold");
					blur.Blurness = blurness;
					faceAttribute.Blur = blur;

					DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_FaceQuality faceQuality = new DetectFaceResponse.DetectFace_SuccessDetailsItem.DetectFace_FacesItem.DetectFace_FaceAttribute.DetectFace_FaceQuality();
					faceQuality._Value = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.FaceQuality.Value");
					faceQuality.Threshold = context.FloatValue("DetectFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.FaceQuality.Threshold");
					faceAttribute.FaceQuality = faceQuality;
					facesItem.FaceAttribute = faceAttribute;

					successDetailsItem_faces.Add(facesItem);
				}
				successDetailsItem.Faces = successDetailsItem_faces;

				detectFaceResponse_successDetails.Add(successDetailsItem);
			}
			detectFaceResponse.SuccessDetails = detectFaceResponse_successDetails;

			List<DetectFaceResponse.DetectFace_FailDetailsItem> detectFaceResponse_failDetails = new List<DetectFaceResponse.DetectFace_FailDetailsItem>();
			for (int i = 0; i < context.Length("DetectFace.FailDetails.Length"); i++) {
				DetectFaceResponse.DetectFace_FailDetailsItem failDetailsItem = new DetectFaceResponse.DetectFace_FailDetailsItem();
				failDetailsItem.SrcUri = context.StringValue("DetectFace.FailDetails["+ i +"].SrcUri");
				failDetailsItem.Reason = context.StringValue("DetectFace.FailDetails["+ i +"].Reason");

				detectFaceResponse_failDetails.Add(failDetailsItem);
			}
			detectFaceResponse.FailDetails = detectFaceResponse_failDetails;
        
			return detectFaceResponse;
        }
    }
}