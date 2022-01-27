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
    public class ListImagesResponseUnmarshaller
    {
        public static ListImagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListImagesResponse listImagesResponse = new ListImagesResponse();

			listImagesResponse.HttpResponse = _ctx.HttpResponse;
			listImagesResponse.SetId = _ctx.StringValue("ListImages.SetId");
			listImagesResponse.NextMarker = _ctx.StringValue("ListImages.NextMarker");
			listImagesResponse.RequestId = _ctx.StringValue("ListImages.RequestId");

			List<ListImagesResponse.ListImages_ImagesItem> listImagesResponse_images = new List<ListImagesResponse.ListImages_ImagesItem>();
			for (int i = 0; i < _ctx.Length("ListImages.Images.Length"); i++) {
				ListImagesResponse.ListImages_ImagesItem imagesItem = new ListImagesResponse.ListImages_ImagesItem();
				imagesItem.FacesModifyTime = _ctx.StringValue("ListImages.Images["+ i +"].FacesModifyTime");
				imagesItem.OCRModifyTime = _ctx.StringValue("ListImages.Images["+ i +"].OCRModifyTime");
				imagesItem.OCRStatus = _ctx.StringValue("ListImages.Images["+ i +"].OCRStatus");
				imagesItem.SourcePosition = _ctx.StringValue("ListImages.Images["+ i +"].SourcePosition");
				imagesItem.Exif = _ctx.StringValue("ListImages.Images["+ i +"].Exif");
				imagesItem.ImageUri = _ctx.StringValue("ListImages.Images["+ i +"].ImageUri");
				imagesItem.ImageWidth = _ctx.IntegerValue("ListImages.Images["+ i +"].ImageWidth");
				imagesItem.ImageFormat = _ctx.StringValue("ListImages.Images["+ i +"].ImageFormat");
				imagesItem.SourceType = _ctx.StringValue("ListImages.Images["+ i +"].SourceType");
				imagesItem.ModifyTime = _ctx.StringValue("ListImages.Images["+ i +"].ModifyTime");
				imagesItem.FileSize = _ctx.IntegerValue("ListImages.Images["+ i +"].FileSize");
				imagesItem.SourceUri = _ctx.StringValue("ListImages.Images["+ i +"].SourceUri");
				imagesItem.CreateTime = _ctx.StringValue("ListImages.Images["+ i +"].CreateTime");
				imagesItem.FacesStatus = _ctx.StringValue("ListImages.Images["+ i +"].FacesStatus");
				imagesItem.RemarksA = _ctx.StringValue("ListImages.Images["+ i +"].RemarksA");
				imagesItem.ImageHeight = _ctx.IntegerValue("ListImages.Images["+ i +"].ImageHeight");
				imagesItem.RemarksB = _ctx.StringValue("ListImages.Images["+ i +"].RemarksB");
				imagesItem.ImageTime = _ctx.StringValue("ListImages.Images["+ i +"].ImageTime");
				imagesItem.Orientation = _ctx.StringValue("ListImages.Images["+ i +"].Orientation");
				imagesItem.Location = _ctx.StringValue("ListImages.Images["+ i +"].Location");
				imagesItem.OCRFailReason = _ctx.StringValue("ListImages.Images["+ i +"].OCRFailReason");
				imagesItem.FacesFailReason = _ctx.StringValue("ListImages.Images["+ i +"].FacesFailReason");
				imagesItem.TagsFailReason = _ctx.StringValue("ListImages.Images["+ i +"].TagsFailReason");
				imagesItem.TagsModifyTime = _ctx.StringValue("ListImages.Images["+ i +"].TagsModifyTime");
				imagesItem.TagsStatus = _ctx.StringValue("ListImages.Images["+ i +"].TagsStatus");
				imagesItem.RemarksC = _ctx.StringValue("ListImages.Images["+ i +"].RemarksC");
				imagesItem.RemarksD = _ctx.StringValue("ListImages.Images["+ i +"].RemarksD");
				imagesItem.ExternalId = _ctx.StringValue("ListImages.Images["+ i +"].ExternalId");
				imagesItem.AddressModifyTime = _ctx.StringValue("ListImages.Images["+ i +"].AddressModifyTime");
				imagesItem.AddressStatus = _ctx.StringValue("ListImages.Images["+ i +"].AddressStatus");
				imagesItem.AddressFailReason = _ctx.StringValue("ListImages.Images["+ i +"].AddressFailReason");
				imagesItem.RemarksArrayA = _ctx.StringValue("ListImages.Images["+ i +"].RemarksArrayA");
				imagesItem.RemarksArrayB = _ctx.StringValue("ListImages.Images["+ i +"].RemarksArrayB");
				imagesItem.ImageQualityStatus = _ctx.StringValue("ListImages.Images["+ i +"].ImageQualityStatus");
				imagesItem.ImageQualityFailReason = _ctx.StringValue("ListImages.Images["+ i +"].ImageQualityFailReason");
				imagesItem.ImageQualityModifyTime = _ctx.StringValue("ListImages.Images["+ i +"].ImageQualityModifyTime");
				imagesItem.CroppingSuggestionStatus = _ctx.StringValue("ListImages.Images["+ i +"].CroppingSuggestionStatus");
				imagesItem.CroppingSuggestionFailReason = _ctx.StringValue("ListImages.Images["+ i +"].CroppingSuggestionFailReason");
				imagesItem.CroppingSuggestionModifyTime = _ctx.StringValue("ListImages.Images["+ i +"].CroppingSuggestionModifyTime");

				ListImagesResponse.ListImages_ImagesItem.ListImages_ImageQuality imageQuality = new ListImagesResponse.ListImages_ImagesItem.ListImages_ImageQuality();
				imageQuality.OverallScore = _ctx.FloatValue("ListImages.Images["+ i +"].ImageQuality.OverallScore");
				imageQuality.ClarityScore = _ctx.FloatValue("ListImages.Images["+ i +"].ImageQuality.ClarityScore");
				imageQuality.Clarity = _ctx.FloatValue("ListImages.Images["+ i +"].ImageQuality.Clarity");
				imageQuality.ExposureScore = _ctx.FloatValue("ListImages.Images["+ i +"].ImageQuality.ExposureScore");
				imageQuality.Exposure = _ctx.FloatValue("ListImages.Images["+ i +"].ImageQuality.Exposure");
				imageQuality.ContrastScore = _ctx.FloatValue("ListImages.Images["+ i +"].ImageQuality.ContrastScore");
				imageQuality.Contrast = _ctx.FloatValue("ListImages.Images["+ i +"].ImageQuality.Contrast");
				imageQuality.ColorScore = _ctx.FloatValue("ListImages.Images["+ i +"].ImageQuality.ColorScore");
				imageQuality.Color = _ctx.FloatValue("ListImages.Images["+ i +"].ImageQuality.Color");
				imageQuality.CompositionScore = _ctx.FloatValue("ListImages.Images["+ i +"].ImageQuality.CompositionScore");
				imagesItem.ImageQuality = imageQuality;

				ListImagesResponse.ListImages_ImagesItem.ListImages_Address address = new ListImagesResponse.ListImages_ImagesItem.ListImages_Address();
				address.AddressLine = _ctx.StringValue("ListImages.Images["+ i +"].Address.AddressLine");
				address.Country = _ctx.StringValue("ListImages.Images["+ i +"].Address.Country");
				address.Province = _ctx.StringValue("ListImages.Images["+ i +"].Address.Province");
				address.City = _ctx.StringValue("ListImages.Images["+ i +"].Address.City");
				address.District = _ctx.StringValue("ListImages.Images["+ i +"].Address.District");
				address.Township = _ctx.StringValue("ListImages.Images["+ i +"].Address.Township");
				imagesItem.Address = address;

				List<ListImagesResponse.ListImages_ImagesItem.ListImages_CroppingSuggestionItem> imagesItem_croppingSuggestion = new List<ListImagesResponse.ListImages_ImagesItem.ListImages_CroppingSuggestionItem>();
				for (int j = 0; j < _ctx.Length("ListImages.Images["+ i +"].CroppingSuggestion.Length"); j++) {
					ListImagesResponse.ListImages_ImagesItem.ListImages_CroppingSuggestionItem croppingSuggestionItem = new ListImagesResponse.ListImages_ImagesItem.ListImages_CroppingSuggestionItem();
					croppingSuggestionItem.AspectRatio = _ctx.StringValue("ListImages.Images["+ i +"].CroppingSuggestion["+ j +"].AspectRatio");
					croppingSuggestionItem.Score = _ctx.FloatValue("ListImages.Images["+ i +"].CroppingSuggestion["+ j +"].Score");

					ListImagesResponse.ListImages_ImagesItem.ListImages_CroppingSuggestionItem.ListImages_CroppingBoundary croppingBoundary = new ListImagesResponse.ListImages_ImagesItem.ListImages_CroppingSuggestionItem.ListImages_CroppingBoundary();
					croppingBoundary.Width = _ctx.IntegerValue("ListImages.Images["+ i +"].CroppingSuggestion["+ j +"].CroppingBoundary.Width");
					croppingBoundary.Height = _ctx.IntegerValue("ListImages.Images["+ i +"].CroppingSuggestion["+ j +"].CroppingBoundary.Height");
					croppingBoundary.Left = _ctx.IntegerValue("ListImages.Images["+ i +"].CroppingSuggestion["+ j +"].CroppingBoundary.Left");
					croppingBoundary.Top = _ctx.IntegerValue("ListImages.Images["+ i +"].CroppingSuggestion["+ j +"].CroppingBoundary.Top");
					croppingSuggestionItem.CroppingBoundary = croppingBoundary;

					imagesItem_croppingSuggestion.Add(croppingSuggestionItem);
				}
				imagesItem.CroppingSuggestion = imagesItem_croppingSuggestion;

				List<ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem> imagesItem_faces = new List<ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem>();
				for (int j = 0; j < _ctx.Length("ListImages.Images["+ i +"].Faces.Length"); j++) {
					ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem facesItem = new ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem();
					facesItem.Age = _ctx.IntegerValue("ListImages.Images["+ i +"].Faces["+ j +"].Age");
					facesItem.GenderConfidence = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].GenderConfidence");
					facesItem.Attractive = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].Attractive");
					facesItem.Gender = _ctx.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].Gender");
					facesItem.FaceConfidence = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceConfidence");
					facesItem.Emotion = _ctx.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].Emotion");
					facesItem.FaceId = _ctx.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceId");
					facesItem.EmotionConfidence = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionConfidence");
					facesItem.GroupId = _ctx.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].GroupId");
					facesItem.FaceQuality = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceQuality");

					ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_EmotionDetails emotionDetails = new ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_EmotionDetails();
					emotionDetails.SAD = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SAD");
					emotionDetails.CALM = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.CALM");
					emotionDetails.ANGRY = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.ANGRY");
					emotionDetails.HAPPY = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.HAPPY");
					emotionDetails.SCARED = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SCARED");
					emotionDetails.DISGUSTED = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.DISGUSTED");
					emotionDetails.SURPRISED = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SURPRISED");
					facesItem.EmotionDetails = emotionDetails;

					ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_FaceAttributes faceAttributes = new ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_FaceAttributes();
					faceAttributes.GlassesConfidence = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.GlassesConfidence");
					faceAttributes.Glasses = _ctx.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Glasses");
					faceAttributes.Beard = _ctx.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Beard");
					faceAttributes.MaskConfidence = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.MaskConfidence");
					faceAttributes.BeardConfidence = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.BeardConfidence");
					faceAttributes.Mask = _ctx.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Mask");

					ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_FaceAttributes.ListImages_FaceBoundary faceBoundary = new ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_FaceAttributes.ListImages_FaceBoundary();
					faceBoundary.Top = _ctx.IntegerValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Top");
					faceBoundary.Height = _ctx.IntegerValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Height");
					faceBoundary.Width = _ctx.IntegerValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Width");
					faceBoundary.Left = _ctx.IntegerValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Left");
					faceAttributes.FaceBoundary = faceBoundary;

					ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_FaceAttributes.ListImages_HeadPose headPose = new ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_FaceAttributes.ListImages_HeadPose();
					headPose.Pitch = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Pitch");
					headPose.Roll = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Roll");
					headPose.Yaw = _ctx.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Yaw");
					faceAttributes.HeadPose = headPose;
					facesItem.FaceAttributes = faceAttributes;

					imagesItem_faces.Add(facesItem);
				}
				imagesItem.Faces = imagesItem_faces;

				List<ListImagesResponse.ListImages_ImagesItem.ListImages_TagsItem> imagesItem_tags = new List<ListImagesResponse.ListImages_ImagesItem.ListImages_TagsItem>();
				for (int j = 0; j < _ctx.Length("ListImages.Images["+ i +"].Tags.Length"); j++) {
					ListImagesResponse.ListImages_ImagesItem.ListImages_TagsItem tagsItem = new ListImagesResponse.ListImages_ImagesItem.ListImages_TagsItem();
					tagsItem.TagConfidence = _ctx.FloatValue("ListImages.Images["+ i +"].Tags["+ j +"].TagConfidence");
					tagsItem.TagLevel = _ctx.IntegerValue("ListImages.Images["+ i +"].Tags["+ j +"].TagLevel");
					tagsItem.TagName = _ctx.StringValue("ListImages.Images["+ i +"].Tags["+ j +"].TagName");
					tagsItem.ParentTagName = _ctx.StringValue("ListImages.Images["+ i +"].Tags["+ j +"].ParentTagName");

					imagesItem_tags.Add(tagsItem);
				}
				imagesItem.Tags = imagesItem_tags;

				List<ListImagesResponse.ListImages_ImagesItem.ListImages_OCRItem> imagesItem_oCR = new List<ListImagesResponse.ListImages_ImagesItem.ListImages_OCRItem>();
				for (int j = 0; j < _ctx.Length("ListImages.Images["+ i +"].OCR.Length"); j++) {
					ListImagesResponse.ListImages_ImagesItem.ListImages_OCRItem oCRItem = new ListImagesResponse.ListImages_ImagesItem.ListImages_OCRItem();
					oCRItem.OCRContents = _ctx.StringValue("ListImages.Images["+ i +"].OCR["+ j +"].OCRContents");
					oCRItem.OCRConfidence = _ctx.FloatValue("ListImages.Images["+ i +"].OCR["+ j +"].OCRConfidence");

					ListImagesResponse.ListImages_ImagesItem.ListImages_OCRItem.ListImages_OCRBoundary oCRBoundary = new ListImagesResponse.ListImages_ImagesItem.ListImages_OCRItem.ListImages_OCRBoundary();
					oCRBoundary.Left = _ctx.IntegerValue("ListImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Top = _ctx.IntegerValue("ListImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Top");
					oCRBoundary.Width = _ctx.IntegerValue("ListImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Width");
					oCRBoundary.Height = _ctx.IntegerValue("ListImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Height");
					oCRItem.OCRBoundary = oCRBoundary;

					imagesItem_oCR.Add(oCRItem);
				}
				imagesItem.OCR = imagesItem_oCR;

				listImagesResponse_images.Add(imagesItem);
			}
			listImagesResponse.Images = listImagesResponse_images;
        
			return listImagesResponse;
        }
    }
}
