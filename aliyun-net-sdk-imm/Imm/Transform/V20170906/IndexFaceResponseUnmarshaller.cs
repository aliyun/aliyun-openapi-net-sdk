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
    public class IndexFaceResponseUnmarshaller
    {
        public static IndexFaceResponse Unmarshall(UnmarshallerContext context)
        {
			IndexFaceResponse indexFaceResponse = new IndexFaceResponse();

			indexFaceResponse.HttpResponse = context.HttpResponse;
			indexFaceResponse.RequestId = context.StringValue("IndexFace.RequestId");
			indexFaceResponse.SetId = context.StringValue("IndexFace.SetId");

			List<string> indexFaceResponse_srcUris = new List<string>();
			for (int i = 0; i < context.Length("IndexFace.SrcUris.Length"); i++) {
				indexFaceResponse_srcUris.Add(context.StringValue("IndexFace.SrcUris["+ i +"]"));
			}
			indexFaceResponse.SrcUris = indexFaceResponse_srcUris;

			List<IndexFaceResponse.IndexFace_SuccessDetailsItem> indexFaceResponse_successDetails = new List<IndexFaceResponse.IndexFace_SuccessDetailsItem>();
			for (int i = 0; i < context.Length("IndexFace.SuccessDetails.Length"); i++) {
				IndexFaceResponse.IndexFace_SuccessDetailsItem successDetailsItem = new IndexFaceResponse.IndexFace_SuccessDetailsItem();
				successDetailsItem.SrcUri = context.StringValue("IndexFace.SuccessDetails["+ i +"].SrcUri");
				successDetailsItem.PhotoId = context.StringValue("IndexFace.SuccessDetails["+ i +"].PhotoId");

				List<IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem> successDetailsItem_faces = new List<IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem>();
				for (int j = 0; j < context.Length("IndexFace.SuccessDetails["+ i +"].Faces.Length"); j++) {
					IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem facesItem = new IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem();
					facesItem.FaceId = context.StringValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceId");

					IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceRectangle faceRectangle = new IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceRectangle();
					faceRectangle.Top = context.StringValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceRectangle.Top");
					faceRectangle.Left = context.StringValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceRectangle.Left");
					faceRectangle.Width = context.StringValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceRectangle.Width");
					faceRectangle.Height = context.StringValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceRectangle.Height");
					facesItem.FaceRectangle = faceRectangle;

					IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute faceAttribute = new IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute();

					IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_Gender gender = new IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_Gender();
					gender._Value = context.StringValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.Gender.Value");
					faceAttribute.Gender = gender;

					IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_Age age = new IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_Age();
					age._Value = context.IntegerValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.Age.Value");
					faceAttribute.Age = age;

					IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_HeadPose headPose = new IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_HeadPose();
					headPose.PitchAngle = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.HeadPose.PitchAngle");
					headPose.RollAngle = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.HeadPose.RollAngle");
					headPose.YawAngle = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.HeadPose.YawAngle");
					faceAttribute.HeadPose = headPose;

					IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_EyeStatus eyeStatus = new IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_EyeStatus();

					IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_EyeStatus.IndexFace_LeftEyeStatus leftEyeStatus = new IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_EyeStatus.IndexFace_LeftEyeStatus();
					leftEyeStatus.NormalGlassEyeOpen = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.LeftEyeStatus.NormalGlassEyeOpen");
					leftEyeStatus.NoGlassEyeClose = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.LeftEyeStatus.NoGlassEyeClose");
					leftEyeStatus.Occlusion = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.LeftEyeStatus.Occlusion");
					leftEyeStatus.NoGlassEyeOpen = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.LeftEyeStatus.NoGlassEyeOpen");
					leftEyeStatus.NormalGlassEyeClose = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.LeftEyeStatus.NormalGlassEyeClose");
					leftEyeStatus.DarkGlasses = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.LeftEyeStatus.DarkGlasses");
					eyeStatus.LeftEyeStatus = leftEyeStatus;

					IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_EyeStatus.IndexFace_RightEyeStatus rightEyeStatus = new IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_EyeStatus.IndexFace_RightEyeStatus();
					rightEyeStatus.NormalGlassEyeOpen = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.RightEyeStatus.NormalGlassEyeOpen");
					rightEyeStatus.NoGlassEyeClose = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.RightEyeStatus.NoGlassEyeClose");
					rightEyeStatus.Occlusion = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.RightEyeStatus.Occlusion");
					rightEyeStatus.NoGlassEyeOpen = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.RightEyeStatus.NoGlassEyeOpen");
					rightEyeStatus.NormalGlassEyeClose = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.RightEyeStatus.NormalGlassEyeClose");
					rightEyeStatus.DarkGlasses = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.EyeStatus.RightEyeStatus.DarkGlasses");
					eyeStatus.RightEyeStatus = rightEyeStatus;
					faceAttribute.EyeStatus = eyeStatus;

					IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_Blur blur = new IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_Blur();

					IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_Blur.IndexFace_Blurness blurness = new IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_Blur.IndexFace_Blurness();
					blurness._Value = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.Blur.Blurness.Value");
					blurness.Threshold = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.Blur.Blurness.Threshold");
					blur.Blurness = blurness;
					faceAttribute.Blur = blur;

					IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_FaceQuality faceQuality = new IndexFaceResponse.IndexFace_SuccessDetailsItem.IndexFace_FacesItem.IndexFace_FaceAttribute.IndexFace_FaceQuality();
					faceQuality._Value = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.FaceQuality.Value");
					faceQuality.Threshold = context.FloatValue("IndexFace.SuccessDetails["+ i +"].Faces["+ j +"].FaceAttribute.FaceQuality.Threshold");
					faceAttribute.FaceQuality = faceQuality;
					facesItem.FaceAttribute = faceAttribute;

					successDetailsItem_faces.Add(facesItem);
				}
				successDetailsItem.Faces = successDetailsItem_faces;

				indexFaceResponse_successDetails.Add(successDetailsItem);
			}
			indexFaceResponse.SuccessDetails = indexFaceResponse_successDetails;

			List<IndexFaceResponse.IndexFace_FailDetailsItem> indexFaceResponse_failDetails = new List<IndexFaceResponse.IndexFace_FailDetailsItem>();
			for (int i = 0; i < context.Length("IndexFace.FailDetails.Length"); i++) {
				IndexFaceResponse.IndexFace_FailDetailsItem failDetailsItem = new IndexFaceResponse.IndexFace_FailDetailsItem();
				failDetailsItem.SrcUri = context.StringValue("IndexFace.FailDetails["+ i +"].SrcUri");
				failDetailsItem.Reason = context.StringValue("IndexFace.FailDetails["+ i +"].Reason");

				indexFaceResponse_failDetails.Add(failDetailsItem);
			}
			indexFaceResponse.FailDetails = indexFaceResponse_failDetails;
        
			return indexFaceResponse;
        }
    }
}