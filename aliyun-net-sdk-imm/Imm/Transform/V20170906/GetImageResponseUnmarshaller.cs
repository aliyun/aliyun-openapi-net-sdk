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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetImageResponseUnmarshaller
    {
        public static GetImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetImageResponse getImageResponse = new GetImageResponse();

			getImageResponse.HttpResponse = _ctx.HttpResponse;
			getImageResponse.RequestId = _ctx.StringValue("GetImage.RequestId");
			getImageResponse.SetId = _ctx.StringValue("GetImage.SetId");
			getImageResponse.ImageUri = _ctx.StringValue("GetImage.ImageUri");
			getImageResponse.RemarksA = _ctx.StringValue("GetImage.RemarksA");
			getImageResponse.RemarksB = _ctx.StringValue("GetImage.RemarksB");
			getImageResponse.CreateTime = _ctx.StringValue("GetImage.CreateTime");
			getImageResponse.ModifyTime = _ctx.StringValue("GetImage.ModifyTime");
			getImageResponse.ImageWidth = _ctx.IntegerValue("GetImage.ImageWidth");
			getImageResponse.ImageHeight = _ctx.IntegerValue("GetImage.ImageHeight");
			getImageResponse.ImageFormat = _ctx.StringValue("GetImage.ImageFormat");
			getImageResponse.Exif = _ctx.StringValue("GetImage.Exif");
			getImageResponse.FileSize = _ctx.IntegerValue("GetImage.FileSize");
			getImageResponse.ImageTime = _ctx.StringValue("GetImage.ImageTime");
			getImageResponse.Orientation = _ctx.StringValue("GetImage.Orientation");
			getImageResponse.SourceType = _ctx.StringValue("GetImage.SourceType");
			getImageResponse.SourceUri = _ctx.StringValue("GetImage.SourceUri");
			getImageResponse.SourcePosition = _ctx.StringValue("GetImage.SourcePosition");
			getImageResponse.FacesStatus = _ctx.StringValue("GetImage.FacesStatus");
			getImageResponse.FacesModifyTime = _ctx.StringValue("GetImage.FacesModifyTime");
			getImageResponse.Location = _ctx.StringValue("GetImage.Location");
			getImageResponse.OCRStatus = _ctx.StringValue("GetImage.OCRStatus");
			getImageResponse.OCRModifyTime = _ctx.StringValue("GetImage.OCRModifyTime");
			getImageResponse.OCRFailReason = _ctx.StringValue("GetImage.OCRFailReason");
			getImageResponse.FacesFailReason = _ctx.StringValue("GetImage.FacesFailReason");
			getImageResponse.TagsFailReason = _ctx.StringValue("GetImage.TagsFailReason");
			getImageResponse.TagsModifyTime = _ctx.StringValue("GetImage.TagsModifyTime");
			getImageResponse.CelebrityStatus = _ctx.StringValue("GetImage.CelebrityStatus");
			getImageResponse.CelebrityModifyTime = _ctx.StringValue("GetImage.CelebrityModifyTime");
			getImageResponse.CelebrityFailReason = _ctx.StringValue("GetImage.CelebrityFailReason");
			getImageResponse.TagsStatus = _ctx.StringValue("GetImage.TagsStatus");
			getImageResponse.RemarksC = _ctx.StringValue("GetImage.RemarksC");
			getImageResponse.RemarksD = _ctx.StringValue("GetImage.RemarksD");
			getImageResponse.ExternalId = _ctx.StringValue("GetImage.ExternalId");
			getImageResponse.AddressModifyTime = _ctx.StringValue("GetImage.AddressModifyTime");
			getImageResponse.AddressStatus = _ctx.StringValue("GetImage.AddressStatus");
			getImageResponse.AddressFailReason = _ctx.StringValue("GetImage.AddressFailReason");
			getImageResponse.RemarksArrayA = _ctx.StringValue("GetImage.RemarksArrayA");
			getImageResponse.RemarksArrayB = _ctx.StringValue("GetImage.RemarksArrayB");
			getImageResponse.ImageQualityModifyTime = _ctx.StringValue("GetImage.ImageQualityModifyTime");
			getImageResponse.ImageQualityFailReason = _ctx.StringValue("GetImage.ImageQualityFailReason");
			getImageResponse.ImageQualityStatus = _ctx.StringValue("GetImage.ImageQualityStatus");
			getImageResponse.CroppingSuggestionStatus = _ctx.StringValue("GetImage.CroppingSuggestionStatus");
			getImageResponse.CroppingSuggestionFailReason = _ctx.StringValue("GetImage.CroppingSuggestionFailReason");
			getImageResponse.CroppingSuggestionModifyTime = _ctx.StringValue("GetImage.CroppingSuggestionModifyTime");

			GetImageResponse.GetImage_ImageQuality imageQuality = new GetImageResponse.GetImage_ImageQuality();
			imageQuality.OverallScore = _ctx.FloatValue("GetImage.ImageQuality.OverallScore");
			imageQuality.ClarityScore = _ctx.FloatValue("GetImage.ImageQuality.ClarityScore");
			imageQuality.Clarity = _ctx.FloatValue("GetImage.ImageQuality.Clarity");
			imageQuality.ExposureScore = _ctx.FloatValue("GetImage.ImageQuality.ExposureScore");
			imageQuality.Exposure = _ctx.FloatValue("GetImage.ImageQuality.Exposure");
			imageQuality.ContrastScore = _ctx.FloatValue("GetImage.ImageQuality.ContrastScore");
			imageQuality.Contrast = _ctx.FloatValue("GetImage.ImageQuality.Contrast");
			imageQuality.ColorScore = _ctx.FloatValue("GetImage.ImageQuality.ColorScore");
			imageQuality.Color = _ctx.FloatValue("GetImage.ImageQuality.Color");
			imageQuality.CompositionScore = _ctx.FloatValue("GetImage.ImageQuality.CompositionScore");
			getImageResponse.ImageQuality = imageQuality;

			GetImageResponse.GetImage_Address address = new GetImageResponse.GetImage_Address();
			address.AddressLine = _ctx.StringValue("GetImage.Address.AddressLine");
			address.Country = _ctx.StringValue("GetImage.Address.Country");
			address.Province = _ctx.StringValue("GetImage.Address.Province");
			address.City = _ctx.StringValue("GetImage.Address.City");
			address.District = _ctx.StringValue("GetImage.Address.District");
			address.Township = _ctx.StringValue("GetImage.Address.Township");
			getImageResponse.Address = address;

			List<GetImageResponse.GetImage_CroppingSuggestionItem> getImageResponse_croppingSuggestion = new List<GetImageResponse.GetImage_CroppingSuggestionItem>();
			for (int i = 0; i < _ctx.Length("GetImage.CroppingSuggestion.Length"); i++) {
				GetImageResponse.GetImage_CroppingSuggestionItem croppingSuggestionItem = new GetImageResponse.GetImage_CroppingSuggestionItem();
				croppingSuggestionItem.AspectRatio = _ctx.StringValue("GetImage.CroppingSuggestion["+ i +"].AspectRatio");
				croppingSuggestionItem.Score = _ctx.FloatValue("GetImage.CroppingSuggestion["+ i +"].Score");

				GetImageResponse.GetImage_CroppingSuggestionItem.GetImage_CroppingBoundary croppingBoundary = new GetImageResponse.GetImage_CroppingSuggestionItem.GetImage_CroppingBoundary();
				croppingBoundary.Width = _ctx.IntegerValue("GetImage.CroppingSuggestion["+ i +"].CroppingBoundary.Width");
				croppingBoundary.Height = _ctx.IntegerValue("GetImage.CroppingSuggestion["+ i +"].CroppingBoundary.Height");
				croppingBoundary.Left = _ctx.IntegerValue("GetImage.CroppingSuggestion["+ i +"].CroppingBoundary.Left");
				croppingBoundary.Top = _ctx.IntegerValue("GetImage.CroppingSuggestion["+ i +"].CroppingBoundary.Top");
				croppingSuggestionItem.CroppingBoundary = croppingBoundary;

				getImageResponse_croppingSuggestion.Add(croppingSuggestionItem);
			}
			getImageResponse.CroppingSuggestion = getImageResponse_croppingSuggestion;

			List<GetImageResponse.GetImage_FacesItem> getImageResponse_faces = new List<GetImageResponse.GetImage_FacesItem>();
			for (int i = 0; i < _ctx.Length("GetImage.Faces.Length"); i++) {
				GetImageResponse.GetImage_FacesItem facesItem = new GetImageResponse.GetImage_FacesItem();
				facesItem.FaceId = _ctx.StringValue("GetImage.Faces["+ i +"].FaceId");
				facesItem.FaceConfidence = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceConfidence");
				facesItem.Age = _ctx.StringValue("GetImage.Faces["+ i +"].Age");
				facesItem.Gender = _ctx.StringValue("GetImage.Faces["+ i +"].Gender");
				facesItem.Emotion = _ctx.StringValue("GetImage.Faces["+ i +"].Emotion");
				facesItem.Attractive = _ctx.FloatValue("GetImage.Faces["+ i +"].Attractive");
				facesItem.GenderConfidence = _ctx.FloatValue("GetImage.Faces["+ i +"].GenderConfidence");
				facesItem.GroupId = _ctx.StringValue("GetImage.Faces["+ i +"].GroupId");
				facesItem.FaceQuality = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceQuality");
				facesItem.EmotionConfidence = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionConfidence");

				GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes faceAttributes = new GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes();
				faceAttributes.Glasses = _ctx.StringValue("GetImage.Faces["+ i +"].FaceAttributes.Glasses");
				faceAttributes.Beard = _ctx.StringValue("GetImage.Faces["+ i +"].FaceAttributes.Beard");
				faceAttributes.Mask = _ctx.StringValue("GetImage.Faces["+ i +"].FaceAttributes.Mask");
				faceAttributes.GlassesConfidence = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.GlassesConfidence");
				faceAttributes.BeardConfidence = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.BeardConfidence");
				faceAttributes.MaskConfidence = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.MaskConfidence");

				GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes.GetImage_FaceBoundary faceBoundary = new GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes.GetImage_FaceBoundary();
				faceBoundary.Left = _ctx.IntegerValue("GetImage.Faces["+ i +"].FaceAttributes.FaceBoundary.Left");
				faceBoundary.Top = _ctx.IntegerValue("GetImage.Faces["+ i +"].FaceAttributes.FaceBoundary.Top");
				faceBoundary.Width = _ctx.IntegerValue("GetImage.Faces["+ i +"].FaceAttributes.FaceBoundary.Width");
				faceBoundary.Height = _ctx.IntegerValue("GetImage.Faces["+ i +"].FaceAttributes.FaceBoundary.Height");
				faceAttributes.FaceBoundary = faceBoundary;

				GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes.GetImage_HeadPose headPose = new GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes.GetImage_HeadPose();
				headPose.Pitch = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.HeadPose.Pitch");
				headPose.Roll = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.HeadPose.Roll");
				headPose.Yaw = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.HeadPose.Yaw");
				faceAttributes.HeadPose = headPose;
				facesItem.FaceAttributes = faceAttributes;

				GetImageResponse.GetImage_FacesItem.GetImage_EmotionDetails emotionDetails = new GetImageResponse.GetImage_FacesItem.GetImage_EmotionDetails();
				emotionDetails.HAPPY = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.HAPPY");
				emotionDetails.SAD = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.SAD");
				emotionDetails.ANGRY = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.ANGRY");
				emotionDetails.SURPRISED = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.SURPRISED");
				emotionDetails.SCARED = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.SCARED");
				emotionDetails.DISGUSTED = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.DISGUSTED");
				emotionDetails.CALM = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.CALM");
				facesItem.EmotionDetails = emotionDetails;

				getImageResponse_faces.Add(facesItem);
			}
			getImageResponse.Faces = getImageResponse_faces;

			List<GetImageResponse.GetImage_OCRItem> getImageResponse_oCR = new List<GetImageResponse.GetImage_OCRItem>();
			for (int i = 0; i < _ctx.Length("GetImage.OCR.Length"); i++) {
				GetImageResponse.GetImage_OCRItem oCRItem = new GetImageResponse.GetImage_OCRItem();
				oCRItem.OCRContents = _ctx.StringValue("GetImage.OCR["+ i +"].OCRContents");
				oCRItem.OCRConfidence = _ctx.FloatValue("GetImage.OCR["+ i +"].OCRConfidence");

				GetImageResponse.GetImage_OCRItem.GetImage_OCRBoundary oCRBoundary = new GetImageResponse.GetImage_OCRItem.GetImage_OCRBoundary();
				oCRBoundary.Left = _ctx.IntegerValue("GetImage.OCR["+ i +"].OCRBoundary.Left");
				oCRBoundary.Top = _ctx.IntegerValue("GetImage.OCR["+ i +"].OCRBoundary.Top");
				oCRBoundary.Width = _ctx.IntegerValue("GetImage.OCR["+ i +"].OCRBoundary.Width");
				oCRBoundary.Height = _ctx.IntegerValue("GetImage.OCR["+ i +"].OCRBoundary.Height");
				oCRItem.OCRBoundary = oCRBoundary;

				getImageResponse_oCR.Add(oCRItem);
			}
			getImageResponse.OCR = getImageResponse_oCR;

			List<GetImageResponse.GetImage_TagsItem> getImageResponse_tags = new List<GetImageResponse.GetImage_TagsItem>();
			for (int i = 0; i < _ctx.Length("GetImage.Tags.Length"); i++) {
				GetImageResponse.GetImage_TagsItem tagsItem = new GetImageResponse.GetImage_TagsItem();
				tagsItem.TagName = _ctx.StringValue("GetImage.Tags["+ i +"].TagName");
				tagsItem.TagConfidence = _ctx.FloatValue("GetImage.Tags["+ i +"].TagConfidence");
				tagsItem.TagLevel = _ctx.IntegerValue("GetImage.Tags["+ i +"].TagLevel");
				tagsItem.ParentTagName = _ctx.StringValue("GetImage.Tags["+ i +"].ParentTagName");

				getImageResponse_tags.Add(tagsItem);
			}
			getImageResponse.Tags = getImageResponse_tags;

			List<GetImageResponse.GetImage_CelebrityItem> getImageResponse_celebrity = new List<GetImageResponse.GetImage_CelebrityItem>();
			for (int i = 0; i < _ctx.Length("GetImage.Celebrity.Length"); i++) {
				GetImageResponse.GetImage_CelebrityItem celebrityItem = new GetImageResponse.GetImage_CelebrityItem();
				celebrityItem.CelebrityName = _ctx.StringValue("GetImage.Celebrity["+ i +"].CelebrityName");
				celebrityItem.CelebrityGender = _ctx.StringValue("GetImage.Celebrity["+ i +"].CelebrityGender");
				celebrityItem.CelebrityConfidence = _ctx.FloatValue("GetImage.Celebrity["+ i +"].CelebrityConfidence");
				celebrityItem.CelebrityLibraryName = _ctx.StringValue("GetImage.Celebrity["+ i +"].CelebrityLibraryName");

				GetImageResponse.GetImage_CelebrityItem.GetImage_CelebrityBoundary celebrityBoundary = new GetImageResponse.GetImage_CelebrityItem.GetImage_CelebrityBoundary();
				celebrityBoundary.Left = _ctx.IntegerValue("GetImage.Celebrity["+ i +"].CelebrityBoundary.Left");
				celebrityBoundary.Top = _ctx.IntegerValue("GetImage.Celebrity["+ i +"].CelebrityBoundary.Top");
				celebrityBoundary.Width = _ctx.IntegerValue("GetImage.Celebrity["+ i +"].CelebrityBoundary.Width");
				celebrityBoundary.Height = _ctx.IntegerValue("GetImage.Celebrity["+ i +"].CelebrityBoundary.Height");
				celebrityItem.CelebrityBoundary = celebrityBoundary;

				getImageResponse_celebrity.Add(celebrityItem);
			}
			getImageResponse.Celebrity = getImageResponse_celebrity;
        
			return getImageResponse;
        }
    }
}
