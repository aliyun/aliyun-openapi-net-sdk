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
			getImageResponse.ModifyTime = _ctx.StringValue("GetImage.ModifyTime");
			getImageResponse.SourceUri = _ctx.StringValue("GetImage.SourceUri");
			getImageResponse.SourceType = _ctx.StringValue("GetImage.SourceType");
			getImageResponse.FacesFailReason = _ctx.StringValue("GetImage.FacesFailReason");
			getImageResponse.CroppingSuggestionStatus = _ctx.StringValue("GetImage.CroppingSuggestionStatus");
			getImageResponse.CroppingSuggestionFailReason = _ctx.StringValue("GetImage.CroppingSuggestionFailReason");
			getImageResponse.RemarksA = _ctx.StringValue("GetImage.RemarksA");
			getImageResponse.AddressFailReason = _ctx.StringValue("GetImage.AddressFailReason");
			getImageResponse.RemarksB = _ctx.StringValue("GetImage.RemarksB");
			getImageResponse.AddressModifyTime = _ctx.StringValue("GetImage.AddressModifyTime");
			getImageResponse.ImageFormat = _ctx.StringValue("GetImage.ImageFormat");
			getImageResponse.RemarksArrayB = _ctx.StringValue("GetImage.RemarksArrayB");
			getImageResponse.TagsFailReason = _ctx.StringValue("GetImage.TagsFailReason");
			getImageResponse.Exif = _ctx.StringValue("GetImage.Exif");
			getImageResponse.FacesModifyTime = _ctx.StringValue("GetImage.FacesModifyTime");
			getImageResponse.RemarksC = _ctx.StringValue("GetImage.RemarksC");
			getImageResponse.RemarksD = _ctx.StringValue("GetImage.RemarksD");
			getImageResponse.ImageWidth = _ctx.IntegerValue("GetImage.ImageWidth");
			getImageResponse.SourcePosition = _ctx.StringValue("GetImage.SourcePosition");
			getImageResponse.RemarksArrayA = _ctx.StringValue("GetImage.RemarksArrayA");
			getImageResponse.AddressStatus = _ctx.StringValue("GetImage.AddressStatus");
			getImageResponse.FacesStatus = _ctx.StringValue("GetImage.FacesStatus");
			getImageResponse.ImageQualityModifyTime = _ctx.StringValue("GetImage.ImageQualityModifyTime");
			getImageResponse.RequestId = _ctx.StringValue("GetImage.RequestId");
			getImageResponse.TagsModifyTime = _ctx.StringValue("GetImage.TagsModifyTime");
			getImageResponse.ExternalId = _ctx.StringValue("GetImage.ExternalId");
			getImageResponse.CreateTime = _ctx.StringValue("GetImage.CreateTime");
			getImageResponse.ImageQualityFailReason = _ctx.StringValue("GetImage.ImageQualityFailReason");
			getImageResponse.ImageUri = _ctx.StringValue("GetImage.ImageUri");
			getImageResponse.Orientation = _ctx.StringValue("GetImage.Orientation");
			getImageResponse.OCRStatus = _ctx.StringValue("GetImage.OCRStatus");
			getImageResponse.OCRModifyTime = _ctx.StringValue("GetImage.OCRModifyTime");
			getImageResponse.CroppingSuggestionModifyTime = _ctx.StringValue("GetImage.CroppingSuggestionModifyTime");
			getImageResponse.ImageTime = _ctx.StringValue("GetImage.ImageTime");
			getImageResponse.TagsStatus = _ctx.StringValue("GetImage.TagsStatus");
			getImageResponse.ImageQualityStatus = _ctx.StringValue("GetImage.ImageQualityStatus");
			getImageResponse.ImageHeight = _ctx.IntegerValue("GetImage.ImageHeight");
			getImageResponse.OCRFailReason = _ctx.StringValue("GetImage.OCRFailReason");
			getImageResponse.SetId = _ctx.StringValue("GetImage.SetId");
			getImageResponse.Location = _ctx.StringValue("GetImage.Location");
			getImageResponse.FileSize = _ctx.IntegerValue("GetImage.FileSize");

			GetImageResponse.GetImage_ImageQuality imageQuality = new GetImageResponse.GetImage_ImageQuality();
			imageQuality.ClarityScore = _ctx.FloatValue("GetImage.ImageQuality.ClarityScore");
			imageQuality.CompositionScore = _ctx.FloatValue("GetImage.ImageQuality.CompositionScore");
			imageQuality.ContrastScore = _ctx.FloatValue("GetImage.ImageQuality.ContrastScore");
			imageQuality.Color = _ctx.FloatValue("GetImage.ImageQuality.Color");
			imageQuality.Exposure = _ctx.FloatValue("GetImage.ImageQuality.Exposure");
			imageQuality.OverallScore = _ctx.FloatValue("GetImage.ImageQuality.OverallScore");
			imageQuality.Clarity = _ctx.FloatValue("GetImage.ImageQuality.Clarity");
			imageQuality.Contrast = _ctx.FloatValue("GetImage.ImageQuality.Contrast");
			imageQuality.ExposureScore = _ctx.FloatValue("GetImage.ImageQuality.ExposureScore");
			imageQuality.ColorScore = _ctx.FloatValue("GetImage.ImageQuality.ColorScore");
			getImageResponse.ImageQuality = imageQuality;

			GetImageResponse.GetImage_Address address = new GetImageResponse.GetImage_Address();
			address.Township = _ctx.StringValue("GetImage.Address.Township");
			address.AddressLine = _ctx.StringValue("GetImage.Address.AddressLine");
			address.Country = _ctx.StringValue("GetImage.Address.Country");
			address.City = _ctx.StringValue("GetImage.Address.City");
			address.District = _ctx.StringValue("GetImage.Address.District");
			address.Province = _ctx.StringValue("GetImage.Address.Province");
			getImageResponse.Address = address;

			List<GetImageResponse.GetImage_CroppingSuggestionItem> getImageResponse_croppingSuggestion = new List<GetImageResponse.GetImage_CroppingSuggestionItem>();
			for (int i = 0; i < _ctx.Length("GetImage.CroppingSuggestion.Length"); i++) {
				GetImageResponse.GetImage_CroppingSuggestionItem croppingSuggestionItem = new GetImageResponse.GetImage_CroppingSuggestionItem();
				croppingSuggestionItem.AspectRatio = _ctx.StringValue("GetImage.CroppingSuggestion["+ i +"].AspectRatio");
				croppingSuggestionItem.Score = _ctx.FloatValue("GetImage.CroppingSuggestion["+ i +"].Score");

				GetImageResponse.GetImage_CroppingSuggestionItem.GetImage_CroppingBoundary croppingBoundary = new GetImageResponse.GetImage_CroppingSuggestionItem.GetImage_CroppingBoundary();
				croppingBoundary.Left = _ctx.IntegerValue("GetImage.CroppingSuggestion["+ i +"].CroppingBoundary.Left");
				croppingBoundary.Top = _ctx.IntegerValue("GetImage.CroppingSuggestion["+ i +"].CroppingBoundary.Top");
				croppingBoundary.Height = _ctx.IntegerValue("GetImage.CroppingSuggestion["+ i +"].CroppingBoundary.Height");
				croppingBoundary.Width = _ctx.IntegerValue("GetImage.CroppingSuggestion["+ i +"].CroppingBoundary.Width");
				croppingSuggestionItem.CroppingBoundary = croppingBoundary;

				getImageResponse_croppingSuggestion.Add(croppingSuggestionItem);
			}
			getImageResponse.CroppingSuggestion = getImageResponse_croppingSuggestion;

			List<GetImageResponse.GetImage_FacesItem> getImageResponse_faces = new List<GetImageResponse.GetImage_FacesItem>();
			for (int i = 0; i < _ctx.Length("GetImage.Faces.Length"); i++) {
				GetImageResponse.GetImage_FacesItem facesItem = new GetImageResponse.GetImage_FacesItem();
				facesItem.FaceConfidence = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceConfidence");
				facesItem.FaceId = _ctx.StringValue("GetImage.Faces["+ i +"].FaceId");
				facesItem.Attractive = _ctx.FloatValue("GetImage.Faces["+ i +"].Attractive");
				facesItem.FaceQuality = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceQuality");
				facesItem.GenderConfidence = _ctx.FloatValue("GetImage.Faces["+ i +"].GenderConfidence");
				facesItem.EmotionConfidence = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionConfidence");
				facesItem.Emotion = _ctx.StringValue("GetImage.Faces["+ i +"].Emotion");
				facesItem.Gender = _ctx.StringValue("GetImage.Faces["+ i +"].Gender");
				facesItem.Age = _ctx.StringValue("GetImage.Faces["+ i +"].Age");
				facesItem.GroupId = _ctx.StringValue("GetImage.Faces["+ i +"].GroupId");

				GetImageResponse.GetImage_FacesItem.GetImage_EmotionDetails emotionDetails = new GetImageResponse.GetImage_FacesItem.GetImage_EmotionDetails();
				emotionDetails.CALM = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.CALM");
				emotionDetails.SCARED = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.SCARED");
				emotionDetails.HAPPY = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.HAPPY");
				emotionDetails.SAD = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.SAD");
				emotionDetails.SURPRISED = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.SURPRISED");
				emotionDetails.ANGRY = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.ANGRY");
				emotionDetails.DISGUSTED = _ctx.FloatValue("GetImage.Faces["+ i +"].EmotionDetails.DISGUSTED");
				facesItem.EmotionDetails = emotionDetails;

				GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes faceAttributes = new GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes();
				faceAttributes.Beard = _ctx.StringValue("GetImage.Faces["+ i +"].FaceAttributes.Beard");
				faceAttributes.BeardConfidence = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.BeardConfidence");
				faceAttributes.MaskConfidence = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.MaskConfidence");
				faceAttributes.Mask = _ctx.StringValue("GetImage.Faces["+ i +"].FaceAttributes.Mask");
				faceAttributes.Glasses = _ctx.StringValue("GetImage.Faces["+ i +"].FaceAttributes.Glasses");
				faceAttributes.GlassesConfidence = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.GlassesConfidence");

				GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes.GetImage_FaceBoundary faceBoundary = new GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes.GetImage_FaceBoundary();
				faceBoundary.Left = _ctx.IntegerValue("GetImage.Faces["+ i +"].FaceAttributes.FaceBoundary.Left");
				faceBoundary.Top = _ctx.IntegerValue("GetImage.Faces["+ i +"].FaceAttributes.FaceBoundary.Top");
				faceBoundary.Height = _ctx.IntegerValue("GetImage.Faces["+ i +"].FaceAttributes.FaceBoundary.Height");
				faceBoundary.Width = _ctx.IntegerValue("GetImage.Faces["+ i +"].FaceAttributes.FaceBoundary.Width");
				faceAttributes.FaceBoundary = faceBoundary;

				GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes.GetImage_HeadPose headPose = new GetImageResponse.GetImage_FacesItem.GetImage_FaceAttributes.GetImage_HeadPose();
				headPose.Pitch = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.HeadPose.Pitch");
				headPose.Roll = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.HeadPose.Roll");
				headPose.Yaw = _ctx.FloatValue("GetImage.Faces["+ i +"].FaceAttributes.HeadPose.Yaw");
				faceAttributes.HeadPose = headPose;
				facesItem.FaceAttributes = faceAttributes;

				getImageResponse_faces.Add(facesItem);
			}
			getImageResponse.Faces = getImageResponse_faces;

			List<GetImageResponse.GetImage_TagsItem> getImageResponse_tags = new List<GetImageResponse.GetImage_TagsItem>();
			for (int i = 0; i < _ctx.Length("GetImage.Tags.Length"); i++) {
				GetImageResponse.GetImage_TagsItem tagsItem = new GetImageResponse.GetImage_TagsItem();
				tagsItem.TagConfidence = _ctx.FloatValue("GetImage.Tags["+ i +"].TagConfidence");
				tagsItem.TagName = _ctx.StringValue("GetImage.Tags["+ i +"].TagName");
				tagsItem.TagLevel = _ctx.IntegerValue("GetImage.Tags["+ i +"].TagLevel");
				tagsItem.ParentTagName = _ctx.StringValue("GetImage.Tags["+ i +"].ParentTagName");

				getImageResponse_tags.Add(tagsItem);
			}
			getImageResponse.Tags = getImageResponse_tags;

			List<GetImageResponse.GetImage_OCRItem> getImageResponse_oCR = new List<GetImageResponse.GetImage_OCRItem>();
			for (int i = 0; i < _ctx.Length("GetImage.OCR.Length"); i++) {
				GetImageResponse.GetImage_OCRItem oCRItem = new GetImageResponse.GetImage_OCRItem();
				oCRItem.OCRConfidence = _ctx.FloatValue("GetImage.OCR["+ i +"].OCRConfidence");
				oCRItem.OCRContents = _ctx.StringValue("GetImage.OCR["+ i +"].OCRContents");

				GetImageResponse.GetImage_OCRItem.GetImage_OCRBoundary oCRBoundary = new GetImageResponse.GetImage_OCRItem.GetImage_OCRBoundary();
				oCRBoundary.Left = _ctx.IntegerValue("GetImage.OCR["+ i +"].OCRBoundary.Left");
				oCRBoundary.Top = _ctx.IntegerValue("GetImage.OCR["+ i +"].OCRBoundary.Top");
				oCRBoundary.Height = _ctx.IntegerValue("GetImage.OCR["+ i +"].OCRBoundary.Height");
				oCRBoundary.Width = _ctx.IntegerValue("GetImage.OCR["+ i +"].OCRBoundary.Width");
				oCRItem.OCRBoundary = oCRBoundary;

				getImageResponse_oCR.Add(oCRItem);
			}
			getImageResponse.OCR = getImageResponse_oCR;
        
			return getImageResponse;
        }
    }
}
