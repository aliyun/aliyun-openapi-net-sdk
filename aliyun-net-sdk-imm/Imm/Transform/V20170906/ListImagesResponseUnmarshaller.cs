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
        public static ListImagesResponse Unmarshall(UnmarshallerContext context)
        {
			ListImagesResponse listImagesResponse = new ListImagesResponse();

			listImagesResponse.HttpResponse = context.HttpResponse;
			listImagesResponse.SetId = context.StringValue("ListImages.SetId");
			listImagesResponse.NextMarker = context.StringValue("ListImages.NextMarker");
			listImagesResponse.RequestId = context.StringValue("ListImages.RequestId");

			List<ListImagesResponse.ListImages_ImagesItem> listImagesResponse_images = new List<ListImagesResponse.ListImages_ImagesItem>();
			for (int i = 0; i < context.Length("ListImages.Images.Length"); i++) {
				ListImagesResponse.ListImages_ImagesItem imagesItem = new ListImagesResponse.ListImages_ImagesItem();
				imagesItem.FacesModifyTime = context.StringValue("ListImages.Images["+ i +"].FacesModifyTime");
				imagesItem.OCRModifyTime = context.StringValue("ListImages.Images["+ i +"].OCRModifyTime");
				imagesItem.OCRStatus = context.StringValue("ListImages.Images["+ i +"].OCRStatus");
				imagesItem.SourcePosition = context.StringValue("ListImages.Images["+ i +"].SourcePosition");
				imagesItem.Exif = context.StringValue("ListImages.Images["+ i +"].Exif");
				imagesItem.ImageUri = context.StringValue("ListImages.Images["+ i +"].ImageUri");
				imagesItem.ImageWidth = context.IntegerValue("ListImages.Images["+ i +"].ImageWidth");
				imagesItem.ImageFormat = context.StringValue("ListImages.Images["+ i +"].ImageFormat");
				imagesItem.SourceType = context.StringValue("ListImages.Images["+ i +"].SourceType");
				imagesItem.ModifyTime = context.StringValue("ListImages.Images["+ i +"].ModifyTime");
				imagesItem.FileSize = context.IntegerValue("ListImages.Images["+ i +"].FileSize");
				imagesItem.SourceUri = context.StringValue("ListImages.Images["+ i +"].SourceUri");
				imagesItem.CreateTime = context.StringValue("ListImages.Images["+ i +"].CreateTime");
				imagesItem.FacesStatus = context.StringValue("ListImages.Images["+ i +"].FacesStatus");
				imagesItem.RemarksA = context.StringValue("ListImages.Images["+ i +"].RemarksA");
				imagesItem.ImageHeight = context.IntegerValue("ListImages.Images["+ i +"].ImageHeight");
				imagesItem.RemarksB = context.StringValue("ListImages.Images["+ i +"].RemarksB");
				imagesItem.ImageTime = context.StringValue("ListImages.Images["+ i +"].ImageTime");
				imagesItem.Orientation = context.StringValue("ListImages.Images["+ i +"].Orientation");
				imagesItem.Location = context.StringValue("ListImages.Images["+ i +"].Location");
				imagesItem.OCRFailReason = context.StringValue("ListImages.Images["+ i +"].OCRFailReason");
				imagesItem.FacesFailReason = context.StringValue("ListImages.Images["+ i +"].FacesFailReason");
				imagesItem.TagsFailReason = context.StringValue("ListImages.Images["+ i +"].TagsFailReason");
				imagesItem.TagsModifyTime = context.StringValue("ListImages.Images["+ i +"].TagsModifyTime");
				imagesItem.CelebrityStatus = context.StringValue("ListImages.Images["+ i +"].CelebrityStatus");
				imagesItem.CelebrityModifyTime = context.StringValue("ListImages.Images["+ i +"].CelebrityModifyTime");
				imagesItem.CelebrityFailReason = context.StringValue("ListImages.Images["+ i +"].CelebrityFailReason");
				imagesItem.TagsStatus = context.StringValue("ListImages.Images["+ i +"].TagsStatus");
				imagesItem.RemarksC = context.StringValue("ListImages.Images["+ i +"].RemarksC");
				imagesItem.RemarksD = context.StringValue("ListImages.Images["+ i +"].RemarksD");
				imagesItem.ExternalId = context.StringValue("ListImages.Images["+ i +"].ExternalId");

				List<ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem> imagesItem_faces = new List<ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem>();
				for (int j = 0; j < context.Length("ListImages.Images["+ i +"].Faces.Length"); j++) {
					ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem facesItem = new ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem();
					facesItem.Age = context.IntegerValue("ListImages.Images["+ i +"].Faces["+ j +"].Age");
					facesItem.GenderConfidence = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].GenderConfidence");
					facesItem.Attractive = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].Attractive");
					facesItem.Gender = context.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].Gender");
					facesItem.FaceConfidence = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceConfidence");
					facesItem.Emotion = context.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].Emotion");
					facesItem.FaceId = context.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceId");
					facesItem.EmotionConfidence = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionConfidence");
					facesItem.GroupId = context.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].GroupId");
					facesItem.FaceQuality = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceQuality");

					ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_EmotionDetails emotionDetails = new ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_EmotionDetails();
					emotionDetails.SAD = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SAD");
					emotionDetails.CALM = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.CALM");
					emotionDetails.ANGRY = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.ANGRY");
					emotionDetails.HAPPY = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.HAPPY");
					emotionDetails.SCARED = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SCARED");
					emotionDetails.DISGUSTED = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.DISGUSTED");
					emotionDetails.SURPRISED = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SURPRISED");
					facesItem.EmotionDetails = emotionDetails;

					ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_FaceAttributes faceAttributes = new ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_FaceAttributes();
					faceAttributes.GlassesConfidence = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.GlassesConfidence");
					faceAttributes.Glasses = context.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Glasses");
					faceAttributes.RaceConfidence = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.RaceConfidence");
					faceAttributes.Beard = context.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Beard");
					faceAttributes.MaskConfidence = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.MaskConfidence");
					faceAttributes.Race = context.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Race");
					faceAttributes.BeardConfidence = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.BeardConfidence");
					faceAttributes.Mask = context.StringValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Mask");

					ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_FaceAttributes.ListImages_FaceBoundary faceBoundary = new ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_FaceAttributes.ListImages_FaceBoundary();
					faceBoundary.Top = context.IntegerValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Top");
					faceBoundary.Height = context.IntegerValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Height");
					faceBoundary.Width = context.IntegerValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Width");
					faceBoundary.Left = context.IntegerValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Left");
					faceAttributes.FaceBoundary = faceBoundary;

					ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_FaceAttributes.ListImages_HeadPose headPose = new ListImagesResponse.ListImages_ImagesItem.ListImages_FacesItem.ListImages_FaceAttributes.ListImages_HeadPose();
					headPose.Pitch = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Pitch");
					headPose.Roll = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Roll");
					headPose.Yaw = context.FloatValue("ListImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Yaw");
					faceAttributes.HeadPose = headPose;
					facesItem.FaceAttributes = faceAttributes;

					imagesItem_faces.Add(facesItem);
				}
				imagesItem.Faces = imagesItem_faces;

				List<ListImagesResponse.ListImages_ImagesItem.ListImages_TagsItem> imagesItem_tags = new List<ListImagesResponse.ListImages_ImagesItem.ListImages_TagsItem>();
				for (int j = 0; j < context.Length("ListImages.Images["+ i +"].Tags.Length"); j++) {
					ListImagesResponse.ListImages_ImagesItem.ListImages_TagsItem tagsItem = new ListImagesResponse.ListImages_ImagesItem.ListImages_TagsItem();
					tagsItem.TagConfidence = context.FloatValue("ListImages.Images["+ i +"].Tags["+ j +"].TagConfidence");
					tagsItem.TagLevel = context.IntegerValue("ListImages.Images["+ i +"].Tags["+ j +"].TagLevel");
					tagsItem.TagName = context.StringValue("ListImages.Images["+ i +"].Tags["+ j +"].TagName");
					tagsItem.ParentTagName = context.StringValue("ListImages.Images["+ i +"].Tags["+ j +"].ParentTagName");

					imagesItem_tags.Add(tagsItem);
				}
				imagesItem.Tags = imagesItem_tags;

				List<ListImagesResponse.ListImages_ImagesItem.ListImages_OCRItem> imagesItem_oCR = new List<ListImagesResponse.ListImages_ImagesItem.ListImages_OCRItem>();
				for (int j = 0; j < context.Length("ListImages.Images["+ i +"].OCR.Length"); j++) {
					ListImagesResponse.ListImages_ImagesItem.ListImages_OCRItem oCRItem = new ListImagesResponse.ListImages_ImagesItem.ListImages_OCRItem();
					oCRItem.OCRContents = context.StringValue("ListImages.Images["+ i +"].OCR["+ j +"].OCRContents");
					oCRItem.OCRConfidence = context.FloatValue("ListImages.Images["+ i +"].OCR["+ j +"].OCRConfidence");

					ListImagesResponse.ListImages_ImagesItem.ListImages_OCRItem.ListImages_OCRBoundary oCRBoundary = new ListImagesResponse.ListImages_ImagesItem.ListImages_OCRItem.ListImages_OCRBoundary();
					oCRBoundary.Left = context.IntegerValue("ListImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Left1 = context.IntegerValue("ListImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Left1");
					oCRBoundary.Width = context.IntegerValue("ListImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Width");
					oCRBoundary.Height = context.IntegerValue("ListImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Height");
					oCRItem.OCRBoundary = oCRBoundary;

					imagesItem_oCR.Add(oCRItem);
				}
				imagesItem.OCR = imagesItem_oCR;

				List<ListImagesResponse.ListImages_ImagesItem.ListImages_CelebrityItem> imagesItem_celebrity = new List<ListImagesResponse.ListImages_ImagesItem.ListImages_CelebrityItem>();
				for (int j = 0; j < context.Length("ListImages.Images["+ i +"].Celebrity.Length"); j++) {
					ListImagesResponse.ListImages_ImagesItem.ListImages_CelebrityItem celebrityItem = new ListImagesResponse.ListImages_ImagesItem.ListImages_CelebrityItem();
					celebrityItem.CelebrityName = context.StringValue("ListImages.Images["+ i +"].Celebrity["+ j +"].CelebrityName");
					celebrityItem.CelebrityGender = context.StringValue("ListImages.Images["+ i +"].Celebrity["+ j +"].CelebrityGender");
					celebrityItem.CelebrityConfidence = context.FloatValue("ListImages.Images["+ i +"].Celebrity["+ j +"].CelebrityConfidence");
					celebrityItem.CelebrityLibraryName = context.StringValue("ListImages.Images["+ i +"].Celebrity["+ j +"].CelebrityLibraryName");

					ListImagesResponse.ListImages_ImagesItem.ListImages_CelebrityItem.ListImages_CelebrityBoundary celebrityBoundary = new ListImagesResponse.ListImages_ImagesItem.ListImages_CelebrityItem.ListImages_CelebrityBoundary();
					celebrityBoundary.Left = context.IntegerValue("ListImages.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Left");
					celebrityBoundary.Top = context.IntegerValue("ListImages.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Top");
					celebrityBoundary.Width = context.IntegerValue("ListImages.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Width");
					celebrityBoundary.Height = context.IntegerValue("ListImages.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Height");
					celebrityItem.CelebrityBoundary = celebrityBoundary;

					imagesItem_celebrity.Add(celebrityItem);
				}
				imagesItem.Celebrity = imagesItem_celebrity;

				listImagesResponse_images.Add(imagesItem);
			}
			listImagesResponse.Images = listImagesResponse_images;
        
			return listImagesResponse;
        }
    }
}
