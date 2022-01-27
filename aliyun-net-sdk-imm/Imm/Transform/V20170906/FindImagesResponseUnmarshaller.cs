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
    public class FindImagesResponseUnmarshaller
    {
        public static FindImagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			FindImagesResponse findImagesResponse = new FindImagesResponse();

			findImagesResponse.HttpResponse = _ctx.HttpResponse;
			findImagesResponse.SetId = _ctx.StringValue("FindImages.SetId");
			findImagesResponse.NextMarker = _ctx.StringValue("FindImages.NextMarker");
			findImagesResponse.RequestId = _ctx.StringValue("FindImages.RequestId");

			List<FindImagesResponse.FindImages_ImagesItem> findImagesResponse_images = new List<FindImagesResponse.FindImages_ImagesItem>();
			for (int i = 0; i < _ctx.Length("FindImages.Images.Length"); i++) {
				FindImagesResponse.FindImages_ImagesItem imagesItem = new FindImagesResponse.FindImages_ImagesItem();
				imagesItem.FacesModifyTime = _ctx.StringValue("FindImages.Images["+ i +"].FacesModifyTime");
				imagesItem.OCRModifyTime = _ctx.StringValue("FindImages.Images["+ i +"].OCRModifyTime");
				imagesItem.OCRStatus = _ctx.StringValue("FindImages.Images["+ i +"].OCRStatus");
				imagesItem.SourcePosition = _ctx.StringValue("FindImages.Images["+ i +"].SourcePosition");
				imagesItem.Exif = _ctx.StringValue("FindImages.Images["+ i +"].Exif");
				imagesItem.ImageUri = _ctx.StringValue("FindImages.Images["+ i +"].ImageUri");
				imagesItem.ImageWidth = _ctx.IntegerValue("FindImages.Images["+ i +"].ImageWidth");
				imagesItem.ImageFormat = _ctx.StringValue("FindImages.Images["+ i +"].ImageFormat");
				imagesItem.SourceType = _ctx.StringValue("FindImages.Images["+ i +"].SourceType");
				imagesItem.ModifyTime = _ctx.StringValue("FindImages.Images["+ i +"].ModifyTime");
				imagesItem.FileSize = _ctx.IntegerValue("FindImages.Images["+ i +"].FileSize");
				imagesItem.SourceUri = _ctx.StringValue("FindImages.Images["+ i +"].SourceUri");
				imagesItem.CreateTime = _ctx.StringValue("FindImages.Images["+ i +"].CreateTime");
				imagesItem.FacesStatus = _ctx.StringValue("FindImages.Images["+ i +"].FacesStatus");
				imagesItem.RemarksA = _ctx.StringValue("FindImages.Images["+ i +"].RemarksA");
				imagesItem.ImageHeight = _ctx.IntegerValue("FindImages.Images["+ i +"].ImageHeight");
				imagesItem.RemarksB = _ctx.StringValue("FindImages.Images["+ i +"].RemarksB");
				imagesItem.ImageTime = _ctx.StringValue("FindImages.Images["+ i +"].ImageTime");
				imagesItem.Orientation = _ctx.StringValue("FindImages.Images["+ i +"].Orientation");
				imagesItem.Location = _ctx.StringValue("FindImages.Images["+ i +"].Location");
				imagesItem.OCRFailReason = _ctx.StringValue("FindImages.Images["+ i +"].OCRFailReason");
				imagesItem.FacesFailReason = _ctx.StringValue("FindImages.Images["+ i +"].FacesFailReason");
				imagesItem.TagsFailReason = _ctx.StringValue("FindImages.Images["+ i +"].TagsFailReason");
				imagesItem.TagsModifyTime = _ctx.StringValue("FindImages.Images["+ i +"].TagsModifyTime");
				imagesItem.TagsStatus = _ctx.StringValue("FindImages.Images["+ i +"].TagsStatus");
				imagesItem.RemarksC = _ctx.StringValue("FindImages.Images["+ i +"].RemarksC");
				imagesItem.RemarksD = _ctx.StringValue("FindImages.Images["+ i +"].RemarksD");
				imagesItem.ExternalId = _ctx.StringValue("FindImages.Images["+ i +"].ExternalId");
				imagesItem.AddressModifyTime = _ctx.StringValue("FindImages.Images["+ i +"].AddressModifyTime");
				imagesItem.AddressStatus = _ctx.StringValue("FindImages.Images["+ i +"].AddressStatus");
				imagesItem.AddressFailReason = _ctx.StringValue("FindImages.Images["+ i +"].AddressFailReason");
				imagesItem.RemarksArrayB = _ctx.StringValue("FindImages.Images["+ i +"].RemarksArrayB");
				imagesItem.RemarksArrayA = _ctx.StringValue("FindImages.Images["+ i +"].RemarksArrayA");
				imagesItem.ImageQualityStatus = _ctx.StringValue("FindImages.Images["+ i +"].ImageQualityStatus");
				imagesItem.ImageQualityFailReason = _ctx.StringValue("FindImages.Images["+ i +"].ImageQualityFailReason");
				imagesItem.ImageQualityModifyTime = _ctx.StringValue("FindImages.Images["+ i +"].ImageQualityModifyTime");
				imagesItem.CroppingSuggestionStatus = _ctx.StringValue("FindImages.Images["+ i +"].CroppingSuggestionStatus");
				imagesItem.CroppingSuggestionFailReason = _ctx.StringValue("FindImages.Images["+ i +"].CroppingSuggestionFailReason");
				imagesItem.CroppingSuggestionModifyTime = _ctx.StringValue("FindImages.Images["+ i +"].CroppingSuggestionModifyTime");

				FindImagesResponse.FindImages_ImagesItem.FindImages_ImageQuality imageQuality = new FindImagesResponse.FindImages_ImagesItem.FindImages_ImageQuality();
				imageQuality.OverallScore = _ctx.FloatValue("FindImages.Images["+ i +"].ImageQuality.OverallScore");
				imageQuality.ClarityScore = _ctx.FloatValue("FindImages.Images["+ i +"].ImageQuality.ClarityScore");
				imageQuality.Clarity = _ctx.FloatValue("FindImages.Images["+ i +"].ImageQuality.Clarity");
				imageQuality.ExposureScore = _ctx.FloatValue("FindImages.Images["+ i +"].ImageQuality.ExposureScore");
				imageQuality.Exposure = _ctx.FloatValue("FindImages.Images["+ i +"].ImageQuality.Exposure");
				imageQuality.ContrastScore = _ctx.FloatValue("FindImages.Images["+ i +"].ImageQuality.ContrastScore");
				imageQuality.Contrast = _ctx.FloatValue("FindImages.Images["+ i +"].ImageQuality.Contrast");
				imageQuality.ColorScore = _ctx.FloatValue("FindImages.Images["+ i +"].ImageQuality.ColorScore");
				imageQuality.Color = _ctx.FloatValue("FindImages.Images["+ i +"].ImageQuality.Color");
				imageQuality.CompositionScore = _ctx.FloatValue("FindImages.Images["+ i +"].ImageQuality.CompositionScore");
				imagesItem.ImageQuality = imageQuality;

				FindImagesResponse.FindImages_ImagesItem.FindImages_Address address = new FindImagesResponse.FindImages_ImagesItem.FindImages_Address();
				address.AddressLine = _ctx.StringValue("FindImages.Images["+ i +"].Address.AddressLine");
				address.Country = _ctx.StringValue("FindImages.Images["+ i +"].Address.Country");
				address.Province = _ctx.StringValue("FindImages.Images["+ i +"].Address.Province");
				address.City = _ctx.StringValue("FindImages.Images["+ i +"].Address.City");
				address.District = _ctx.StringValue("FindImages.Images["+ i +"].Address.District");
				address.Township = _ctx.StringValue("FindImages.Images["+ i +"].Address.Township");
				imagesItem.Address = address;

				List<FindImagesResponse.FindImages_ImagesItem.FindImages_CroppingSuggestionItem> imagesItem_croppingSuggestion = new List<FindImagesResponse.FindImages_ImagesItem.FindImages_CroppingSuggestionItem>();
				for (int j = 0; j < _ctx.Length("FindImages.Images["+ i +"].CroppingSuggestion.Length"); j++) {
					FindImagesResponse.FindImages_ImagesItem.FindImages_CroppingSuggestionItem croppingSuggestionItem = new FindImagesResponse.FindImages_ImagesItem.FindImages_CroppingSuggestionItem();
					croppingSuggestionItem.AspectRatio = _ctx.StringValue("FindImages.Images["+ i +"].CroppingSuggestion["+ j +"].AspectRatio");
					croppingSuggestionItem.Score = _ctx.FloatValue("FindImages.Images["+ i +"].CroppingSuggestion["+ j +"].Score");

					FindImagesResponse.FindImages_ImagesItem.FindImages_CroppingSuggestionItem.FindImages_CroppingBoundary croppingBoundary = new FindImagesResponse.FindImages_ImagesItem.FindImages_CroppingSuggestionItem.FindImages_CroppingBoundary();
					croppingBoundary.Width = _ctx.IntegerValue("FindImages.Images["+ i +"].CroppingSuggestion["+ j +"].CroppingBoundary.Width");
					croppingBoundary.Height = _ctx.IntegerValue("FindImages.Images["+ i +"].CroppingSuggestion["+ j +"].CroppingBoundary.Height");
					croppingBoundary.Left = _ctx.IntegerValue("FindImages.Images["+ i +"].CroppingSuggestion["+ j +"].CroppingBoundary.Left");
					croppingBoundary.Top = _ctx.IntegerValue("FindImages.Images["+ i +"].CroppingSuggestion["+ j +"].CroppingBoundary.Top");
					croppingSuggestionItem.CroppingBoundary = croppingBoundary;

					imagesItem_croppingSuggestion.Add(croppingSuggestionItem);
				}
				imagesItem.CroppingSuggestion = imagesItem_croppingSuggestion;

				List<FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem> imagesItem_faces = new List<FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem>();
				for (int j = 0; j < _ctx.Length("FindImages.Images["+ i +"].Faces.Length"); j++) {
					FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem facesItem = new FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem();
					facesItem.Age = _ctx.IntegerValue("FindImages.Images["+ i +"].Faces["+ j +"].Age");
					facesItem.GenderConfidence = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].GenderConfidence");
					facesItem.Attractive = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].Attractive");
					facesItem.Gender = _ctx.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].Gender");
					facesItem.FaceConfidence = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceConfidence");
					facesItem.Emotion = _ctx.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].Emotion");
					facesItem.FaceId = _ctx.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceId");
					facesItem.EmotionConfidence = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionConfidence");
					facesItem.GroupId = _ctx.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].GroupId");
					facesItem.FaceQuality = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceQuality");

					FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_EmotionDetails emotionDetails = new FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_EmotionDetails();
					emotionDetails.SAD = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SAD");
					emotionDetails.CALM = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.CALM");
					emotionDetails.ANGRY = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.ANGRY");
					emotionDetails.HAPPY = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.HAPPY");
					emotionDetails.SCARED = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SCARED");
					emotionDetails.DISGUSTED = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.DISGUSTED");
					emotionDetails.SURPRISED = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SURPRISED");
					facesItem.EmotionDetails = emotionDetails;

					FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_FaceAttributes faceAttributes = new FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_FaceAttributes();
					faceAttributes.GlassesConfidence = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.GlassesConfidence");
					faceAttributes.Glasses = _ctx.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Glasses");
					faceAttributes.Beard = _ctx.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Beard");
					faceAttributes.MaskConfidence = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.MaskConfidence");
					faceAttributes.BeardConfidence = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.BeardConfidence");
					faceAttributes.Mask = _ctx.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Mask");

					FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_FaceAttributes.FindImages_FaceBoundary faceBoundary = new FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_FaceAttributes.FindImages_FaceBoundary();
					faceBoundary.Top = _ctx.IntegerValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Top");
					faceBoundary.Height = _ctx.IntegerValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Height");
					faceBoundary.Width = _ctx.IntegerValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Width");
					faceBoundary.Left = _ctx.IntegerValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Left");
					faceAttributes.FaceBoundary = faceBoundary;

					FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_FaceAttributes.FindImages_HeadPose headPose = new FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_FaceAttributes.FindImages_HeadPose();
					headPose.Pitch = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Pitch");
					headPose.Roll = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Roll");
					headPose.Yaw = _ctx.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Yaw");
					faceAttributes.HeadPose = headPose;
					facesItem.FaceAttributes = faceAttributes;

					imagesItem_faces.Add(facesItem);
				}
				imagesItem.Faces = imagesItem_faces;

				List<FindImagesResponse.FindImages_ImagesItem.FindImages_TagsItem> imagesItem_tags = new List<FindImagesResponse.FindImages_ImagesItem.FindImages_TagsItem>();
				for (int j = 0; j < _ctx.Length("FindImages.Images["+ i +"].Tags.Length"); j++) {
					FindImagesResponse.FindImages_ImagesItem.FindImages_TagsItem tagsItem = new FindImagesResponse.FindImages_ImagesItem.FindImages_TagsItem();
					tagsItem.TagConfidence = _ctx.FloatValue("FindImages.Images["+ i +"].Tags["+ j +"].TagConfidence");
					tagsItem.TagLevel = _ctx.IntegerValue("FindImages.Images["+ i +"].Tags["+ j +"].TagLevel");
					tagsItem.TagName = _ctx.StringValue("FindImages.Images["+ i +"].Tags["+ j +"].TagName");
					tagsItem.ParentTagName = _ctx.StringValue("FindImages.Images["+ i +"].Tags["+ j +"].ParentTagName");

					imagesItem_tags.Add(tagsItem);
				}
				imagesItem.Tags = imagesItem_tags;

				List<FindImagesResponse.FindImages_ImagesItem.FindImages_OCRItem> imagesItem_oCR = new List<FindImagesResponse.FindImages_ImagesItem.FindImages_OCRItem>();
				for (int j = 0; j < _ctx.Length("FindImages.Images["+ i +"].OCR.Length"); j++) {
					FindImagesResponse.FindImages_ImagesItem.FindImages_OCRItem oCRItem = new FindImagesResponse.FindImages_ImagesItem.FindImages_OCRItem();
					oCRItem.OCRContents = _ctx.StringValue("FindImages.Images["+ i +"].OCR["+ j +"].OCRContents");
					oCRItem.OCRConfidence = _ctx.FloatValue("FindImages.Images["+ i +"].OCR["+ j +"].OCRConfidence");

					FindImagesResponse.FindImages_ImagesItem.FindImages_OCRItem.FindImages_OCRBoundary oCRBoundary = new FindImagesResponse.FindImages_ImagesItem.FindImages_OCRItem.FindImages_OCRBoundary();
					oCRBoundary.Left = _ctx.IntegerValue("FindImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Top = _ctx.IntegerValue("FindImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Top");
					oCRBoundary.Width = _ctx.IntegerValue("FindImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Width");
					oCRBoundary.Height = _ctx.IntegerValue("FindImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Height");
					oCRItem.OCRBoundary = oCRBoundary;

					imagesItem_oCR.Add(oCRItem);
				}
				imagesItem.OCR = imagesItem_oCR;

				findImagesResponse_images.Add(imagesItem);
			}
			findImagesResponse.Images = findImagesResponse_images;
        
			return findImagesResponse;
        }
    }
}
