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
    public class GetImageResponseUnmarshaller
    {
        public static GetImageResponse Unmarshall(UnmarshallerContext context)
        {
			GetImageResponse getImageResponse = new GetImageResponse();

			getImageResponse.HttpResponse = context.HttpResponse;
			getImageResponse.RequestId = context.StringValue("GetImage.RequestId");
			getImageResponse.SetId = context.StringValue("GetImage.SetId");
			getImageResponse.ImageUri = context.StringValue("GetImage.ImageUri");
			getImageResponse.RemarksA = context.StringValue("GetImage.RemarksA");
			getImageResponse.RemarksB = context.StringValue("GetImage.RemarksB");
			getImageResponse.CreateTime = context.StringValue("GetImage.CreateTime");
			getImageResponse.ModifyTime = context.StringValue("GetImage.ModifyTime");
			getImageResponse.ImageWidth = context.IntegerValue("GetImage.ImageWidth");
			getImageResponse.ImageHeight = context.IntegerValue("GetImage.ImageHeight");
			getImageResponse.ImageFormat = context.StringValue("GetImage.ImageFormat");
			getImageResponse.Exif = context.StringValue("GetImage.Exif");
			getImageResponse.FileSize = context.IntegerValue("GetImage.FileSize");
			getImageResponse.ImageTime = context.StringValue("GetImage.ImageTime");
			getImageResponse.Orientation = context.StringValue("GetImage.Orientation");
			getImageResponse.SourceType = context.StringValue("GetImage.SourceType");
			getImageResponse.SourceUri = context.StringValue("GetImage.SourceUri");
			getImageResponse.SourcePosition = context.StringValue("GetImage.SourcePosition");
			getImageResponse.FacesStatus = context.StringValue("GetImage.FacesStatus");
			getImageResponse.FacesModifyTime = context.StringValue("GetImage.FacesModifyTime");
			getImageResponse.Location = context.StringValue("GetImage.Location");
			getImageResponse.OCRStatus = context.StringValue("GetImage.OCRStatus");
			getImageResponse.OCRModifyTime = context.StringValue("GetImage.OCRModifyTime");
			getImageResponse.OCRFailReason = context.StringValue("GetImage.OCRFailReason");
			getImageResponse.FacesFailReason = context.StringValue("GetImage.FacesFailReason");
			getImageResponse.TagsFailReason = context.StringValue("GetImage.TagsFailReason");
			getImageResponse.TagsModifyTime = context.StringValue("GetImage.TagsModifyTime");
			getImageResponse.CelebrityStatus = context.StringValue("GetImage.CelebrityStatus");
			getImageResponse.CelebrityModifyTime = context.StringValue("GetImage.CelebrityModifyTime");
			getImageResponse.CelebrityFailReason = context.StringValue("GetImage.CelebrityFailReason");
			getImageResponse.TagsStatus = context.StringValue("GetImage.TagsStatus");
			getImageResponse.RemarksC = context.StringValue("GetImage.RemarksC");
			getImageResponse.RemarksD = context.StringValue("GetImage.RemarksD");
			getImageResponse.ExternalId = context.StringValue("GetImage.ExternalId");

			List<GetImageResponse.GetImage_FacesItem> getImageResponse_faces = new List<GetImageResponse.GetImage_FacesItem>();
			for (int i = 0; i < context.Length("GetImage.Faces.Length"); i++) {
				GetImageResponse.GetImage_FacesItem facesItem = new GetImageResponse.GetImage_FacesItem();
				facesItem.FaceId = context.StringValue("GetImage.Faces["+ i +"].FaceId");
				facesItem.FaceConfidence = context.FloatValue("GetImage.Faces["+ i +"].FaceConfidence");
				facesItem.Age = context.StringValue("GetImage.Faces["+ i +"].Age");
				facesItem.Gender = context.StringValue("GetImage.Faces["+ i +"].Gender");
				facesItem.Emotion = context.StringValue("GetImage.Faces["+ i +"].Emotion");
				facesItem.Attractive = context.FloatValue("GetImage.Faces["+ i +"].Attractive");
				facesItem.GenderConfidence = context.FloatValue("GetImage.Faces["+ i +"].GenderConfidence");
				facesItem.GroupId = context.StringValue("GetImage.Faces["+ i +"].GroupId");
				facesItem.FaceQuality = context.FloatValue("GetImage.Faces["+ i +"].FaceQuality");

				GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes faceAttributes = new GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes();
				faceAttributes.Glasses = context.StringValue("GetImage.Faces["+ i +"].FaceAttributes.Glasses");
				faceAttributes.Beard = context.StringValue("GetImage.Faces["+ i +"].FaceAttributes.Beard");
				faceAttributes.Race = context.StringValue("GetImage.Faces["+ i +"].FaceAttributes.Race");
				faceAttributes.Mask = context.StringValue("GetImage.Faces["+ i +"].FaceAttributes.Mask");
				faceAttributes.GlassesConfidence = context.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.GlassesConfidence");
				faceAttributes.BeardConfidence = context.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.BeardConfidence");
				faceAttributes.RaceConfidence = context.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.RaceConfidence");
				faceAttributes.MaskConfidence = context.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.MaskConfidence");

				GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes.GetImage_FaceBoundary faceBoundary = new GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes.GetImage_FaceBoundary();
				faceBoundary.Left = context.IntegerValue("GetImage.Faces["+ i +"].FaceAttributes.FaceBoundary.Left");
				faceBoundary.Top = context.IntegerValue("GetImage.Faces["+ i +"].FaceAttributes.FaceBoundary.Top");
				faceBoundary.Width = context.IntegerValue("GetImage.Faces["+ i +"].FaceAttributes.FaceBoundary.Width");
				faceBoundary.Height = context.IntegerValue("GetImage.Faces["+ i +"].FaceAttributes.FaceBoundary.Height");
				faceAttributes.FaceBoundary = faceBoundary;

				GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes.GetImage_HeadPose headPose = new GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes.GetImage_HeadPose();
				headPose.Pitch = context.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.HeadPose.Pitch");
				headPose.Roll = context.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.HeadPose.Roll");
				headPose.Yaw = context.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.HeadPose.Yaw");
				faceAttributes.HeadPose = headPose;
				facesItem.FaceAttributes = faceAttributes;

				GetImageResponse.GetImage_FacesItem.GetImage_EmotionDetails emotionDetails = new GetImageResponse.GetImage_FacesItem.GetImage_EmotionDetails();
				emotionDetails.HAPPY = context.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.HAPPY");
				emotionDetails.SAD = context.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.SAD");
				emotionDetails.ANGRY = context.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.ANGRY");
				emotionDetails.SURPRISED = context.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.SURPRISED");
				emotionDetails.SCARED = context.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.SCARED");
				emotionDetails.DISGUSTED = context.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.DISGUSTED");
				emotionDetails.CALM = context.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.CALM");
				facesItem.EmotionDetails = emotionDetails;

				getImageResponse_faces.Add(facesItem);
			}
			getImageResponse.Faces = getImageResponse_faces;

			List<GetImageResponse.GetImage_OCRItem> getImageResponse_oCR = new List<GetImageResponse.GetImage_OCRItem>();
			for (int i = 0; i < context.Length("GetImage.OCR.Length"); i++) {
				GetImageResponse.GetImage_OCRItem oCRItem = new GetImageResponse.GetImage_OCRItem();
				oCRItem.OCRContents = context.StringValue("GetImage.OCR["+ i +"].OCRContents");
				oCRItem.OCRConfidence = context.FloatValue("GetImage.OCR["+ i +"].OCRConfidence");

				GetImageResponse.GetImage_OCRItem.GetImage_OCRBoundary oCRBoundary = new GetImageResponse.GetImage_OCRItem.GetImage_OCRBoundary();
				oCRBoundary.Left = context.IntegerValue("GetImage.OCR["+ i +"].OCRBoundary.Left");
				oCRBoundary.Top = context.IntegerValue("GetImage.OCR["+ i +"].OCRBoundary.Top");
				oCRBoundary.Width = context.IntegerValue("GetImage.OCR["+ i +"].OCRBoundary.Width");
				oCRBoundary.Height = context.IntegerValue("GetImage.OCR["+ i +"].OCRBoundary.Height");
				oCRItem.OCRBoundary = oCRBoundary;

				getImageResponse_oCR.Add(oCRItem);
			}
			getImageResponse.OCR = getImageResponse_oCR;

			List<GetImageResponse.GetImage_TagsItem> getImageResponse_tags = new List<GetImageResponse.GetImage_TagsItem>();
			for (int i = 0; i < context.Length("GetImage.Tags.Length"); i++) {
				GetImageResponse.GetImage_TagsItem tagsItem = new GetImageResponse.GetImage_TagsItem();
				tagsItem.TagName = context.StringValue("GetImage.Tags["+ i +"].TagName");
				tagsItem.TagConfidence = context.FloatValue("GetImage.Tags["+ i +"].TagConfidence");
				tagsItem.TagLevel = context.IntegerValue("GetImage.Tags["+ i +"].TagLevel");
				tagsItem.ParentTagName = context.StringValue("GetImage.Tags["+ i +"].ParentTagName");

				getImageResponse_tags.Add(tagsItem);
			}
			getImageResponse.Tags = getImageResponse_tags;

			List<GetImageResponse.GetImage_CelebrityItem> getImageResponse_celebrity = new List<GetImageResponse.GetImage_CelebrityItem>();
			for (int i = 0; i < context.Length("GetImage.Celebrity.Length"); i++) {
				GetImageResponse.GetImage_CelebrityItem celebrityItem = new GetImageResponse.GetImage_CelebrityItem();
				celebrityItem.CelebrityName = context.StringValue("GetImage.Celebrity["+ i +"].CelebrityName");
				celebrityItem.CelebrityGender = context.StringValue("GetImage.Celebrity["+ i +"].CelebrityGender");
				celebrityItem.CelebrityConfidence = context.FloatValue("GetImage.Celebrity["+ i +"].CelebrityConfidence");
				celebrityItem.CelebrityLibraryName = context.StringValue("GetImage.Celebrity["+ i +"].CelebrityLibraryName");

				GetImageResponse.GetImage_CelebrityItem.GetImage_CelebrityBoundary celebrityBoundary = new GetImageResponse.GetImage_CelebrityItem.GetImage_CelebrityBoundary();
				celebrityBoundary.Left = context.IntegerValue("GetImage.Celebrity["+ i +"].CelebrityBoundary.Left");
				celebrityBoundary.Top = context.IntegerValue("GetImage.Celebrity["+ i +"].CelebrityBoundary.Top");
				celebrityBoundary.Width = context.IntegerValue("GetImage.Celebrity["+ i +"].CelebrityBoundary.Width");
				celebrityBoundary.Height = context.IntegerValue("GetImage.Celebrity["+ i +"].CelebrityBoundary.Height");
				celebrityItem.CelebrityBoundary = celebrityBoundary;

				getImageResponse_celebrity.Add(celebrityItem);
			}
			getImageResponse.Celebrity = getImageResponse_celebrity;
        
			return getImageResponse;
        }
    }
}