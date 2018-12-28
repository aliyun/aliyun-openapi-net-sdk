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
    public class SearchImagesResponseUnmarshaller
    {
        public static SearchImagesResponse Unmarshall(UnmarshallerContext context)
        {
			SearchImagesResponse searchImagesResponse = new SearchImagesResponse();

			searchImagesResponse.HttpResponse = context.HttpResponse;
			searchImagesResponse.SetId = context.StringValue("SearchImages.SetId");
			searchImagesResponse.NextMarker = context.StringValue("SearchImages.NextMarker");
			searchImagesResponse.RequestId = context.StringValue("SearchImages.RequestId");

			List<SearchImagesResponse.SearchImages_ImagesItem> searchImagesResponse_images = new List<SearchImagesResponse.SearchImages_ImagesItem>();
			for (int i = 0; i < context.Length("SearchImages.Images.Length"); i++) {
				SearchImagesResponse.SearchImages_ImagesItem imagesItem = new SearchImagesResponse.SearchImages_ImagesItem();
				imagesItem.FacesModifyTime = context.StringValue("SearchImages.Images["+ i +"].FacesModifyTime");
				imagesItem.OCRModifyTime = context.StringValue("SearchImages.Images["+ i +"].OCRModifyTime");
				imagesItem.OCRStatus = context.StringValue("SearchImages.Images["+ i +"].OCRStatus");
				imagesItem.SourcePosition = context.StringValue("SearchImages.Images["+ i +"].SourcePosition");
				imagesItem.Exif = context.StringValue("SearchImages.Images["+ i +"].Exif");
				imagesItem.ImageUri = context.StringValue("SearchImages.Images["+ i +"].ImageUri");
				imagesItem.ImageWidth = context.IntegerValue("SearchImages.Images["+ i +"].ImageWidth");
				imagesItem.ImageFormat = context.StringValue("SearchImages.Images["+ i +"].ImageFormat");
				imagesItem.SourceType = context.StringValue("SearchImages.Images["+ i +"].SourceType");
				imagesItem.ModifyTime = context.StringValue("SearchImages.Images["+ i +"].ModifyTime");
				imagesItem.FileSize = context.IntegerValue("SearchImages.Images["+ i +"].FileSize");
				imagesItem.SourceUri = context.StringValue("SearchImages.Images["+ i +"].SourceUri");
				imagesItem.CreateTime = context.StringValue("SearchImages.Images["+ i +"].CreateTime");
				imagesItem.FacesStatus = context.StringValue("SearchImages.Images["+ i +"].FacesStatus");
				imagesItem.RemarksA = context.StringValue("SearchImages.Images["+ i +"].RemarksA");
				imagesItem.ImageHeight = context.IntegerValue("SearchImages.Images["+ i +"].ImageHeight");
				imagesItem.RemarksB = context.StringValue("SearchImages.Images["+ i +"].RemarksB");
				imagesItem.ImageTime = context.StringValue("SearchImages.Images["+ i +"].ImageTime");
				imagesItem.Orientation = context.StringValue("SearchImages.Images["+ i +"].Orientation");
				imagesItem.Location = context.StringValue("SearchImages.Images["+ i +"].Location");
				imagesItem.OCRFailReason = context.StringValue("SearchImages.Images["+ i +"].OCRFailReason");
				imagesItem.FacesFailReason = context.StringValue("SearchImages.Images["+ i +"].FacesFailReason");
				imagesItem.TagsFailReason = context.StringValue("SearchImages.Images["+ i +"].TagsFailReason");
				imagesItem.TagsModifyTime = context.StringValue("SearchImages.Images["+ i +"].TagsModifyTime");
				imagesItem.CelebrityStatus = context.StringValue("SearchImages.Images["+ i +"].CelebrityStatus");
				imagesItem.CelebrityModifyTime = context.StringValue("SearchImages.Images["+ i +"].CelebrityModifyTime");
				imagesItem.CelebrityFailReason = context.StringValue("SearchImages.Images["+ i +"].CelebrityFailReason");
				imagesItem.TagsStatus = context.StringValue("SearchImages.Images["+ i +"].TagsStatus");

				List<SearchImagesResponse.SearchImages_ImagesItem.SearchImages_FacesItem> imagesItem_faces = new List<SearchImagesResponse.SearchImages_ImagesItem.SearchImages_FacesItem>();
				for (int j = 0; j < context.Length("SearchImages.Images["+ i +"].Faces.Length"); j++) {
					SearchImagesResponse.SearchImages_ImagesItem.SearchImages_FacesItem facesItem = new SearchImagesResponse.SearchImages_ImagesItem.SearchImages_FacesItem();
					facesItem.Age = context.IntegerValue("SearchImages.Images["+ i +"].Faces["+ j +"].Age");
					facesItem.GenderConfidence = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].GenderConfidence");
					facesItem.Attractive = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].Attractive");
					facesItem.Gender = context.StringValue("SearchImages.Images["+ i +"].Faces["+ j +"].Gender");
					facesItem.FaceConfidence = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceConfidence");
					facesItem.Emotion = context.StringValue("SearchImages.Images["+ i +"].Faces["+ j +"].Emotion");
					facesItem.FaceId = context.StringValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceId");
					facesItem.EmotionConfidence = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].EmotionConfidence");

					SearchImagesResponse.SearchImages_ImagesItem.SearchImages_FacesItem.SearchImages_EmotionDetails emotionDetails = new SearchImagesResponse.SearchImages_ImagesItem.SearchImages_FacesItem.SearchImages_EmotionDetails();
					emotionDetails.SAD = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SAD");
					emotionDetails.CALM = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.CALM");
					emotionDetails.ANGRY = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.ANGRY");
					emotionDetails.HAPPY = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.HAPPY");
					emotionDetails.SCARED = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SCARED");
					emotionDetails.DISGUSTED = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.DISGUSTED");
					emotionDetails.SURPRISED = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SURPRISED");
					facesItem.EmotionDetails = emotionDetails;

					SearchImagesResponse.SearchImages_ImagesItem.SearchImages_FacesItem.SearchImages_FaceAttributes faceAttributes = new SearchImagesResponse.SearchImages_ImagesItem.SearchImages_FacesItem.SearchImages_FaceAttributes();
					faceAttributes.GlassesConfidence = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.GlassesConfidence");
					faceAttributes.Glasses = context.StringValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Glasses");
					faceAttributes.RaceConfidence = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.RaceConfidence");
					faceAttributes.Beard = context.StringValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Beard");
					faceAttributes.MaskConfidence = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.MaskConfidence");
					faceAttributes.Race = context.StringValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Race");
					faceAttributes.BeardConfidence = context.FloatValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.BeardConfidence");
					faceAttributes.Mask = context.StringValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Mask");

					SearchImagesResponse.SearchImages_ImagesItem.SearchImages_FacesItem.SearchImages_FaceAttributes.SearchImages_FaceBoundary faceBoundary = new SearchImagesResponse.SearchImages_ImagesItem.SearchImages_FacesItem.SearchImages_FaceAttributes.SearchImages_FaceBoundary();
					faceBoundary.Top = context.IntegerValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Top");
					faceBoundary.Height = context.IntegerValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Height");
					faceBoundary.Width = context.IntegerValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Width");
					faceBoundary.Left = context.IntegerValue("SearchImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Left");
					faceAttributes.FaceBoundary = faceBoundary;
					facesItem.FaceAttributes = faceAttributes;

					imagesItem_faces.Add(facesItem);
				}
				imagesItem.Faces = imagesItem_faces;

				List<SearchImagesResponse.SearchImages_ImagesItem.SearchImages_TagsItem> imagesItem_tags = new List<SearchImagesResponse.SearchImages_ImagesItem.SearchImages_TagsItem>();
				for (int j = 0; j < context.Length("SearchImages.Images["+ i +"].Tags.Length"); j++) {
					SearchImagesResponse.SearchImages_ImagesItem.SearchImages_TagsItem tagsItem = new SearchImagesResponse.SearchImages_ImagesItem.SearchImages_TagsItem();
					tagsItem.TagConfidence = context.FloatValue("SearchImages.Images["+ i +"].Tags["+ j +"].TagConfidence");
					tagsItem.TagLevel = context.IntegerValue("SearchImages.Images["+ i +"].Tags["+ j +"].TagLevel");
					tagsItem.TagName = context.StringValue("SearchImages.Images["+ i +"].Tags["+ j +"].TagName");
					tagsItem.ParentTagName = context.StringValue("SearchImages.Images["+ i +"].Tags["+ j +"].ParentTagName");

					imagesItem_tags.Add(tagsItem);
				}
				imagesItem.Tags = imagesItem_tags;

				List<SearchImagesResponse.SearchImages_ImagesItem.SearchImages_OCRItem> imagesItem_oCR = new List<SearchImagesResponse.SearchImages_ImagesItem.SearchImages_OCRItem>();
				for (int j = 0; j < context.Length("SearchImages.Images["+ i +"].OCR.Length"); j++) {
					SearchImagesResponse.SearchImages_ImagesItem.SearchImages_OCRItem oCRItem = new SearchImagesResponse.SearchImages_ImagesItem.SearchImages_OCRItem();
					oCRItem.OCRContents = context.StringValue("SearchImages.Images["+ i +"].OCR["+ j +"].OCRContents");
					oCRItem.OCRConfidence = context.FloatValue("SearchImages.Images["+ i +"].OCR["+ j +"].OCRConfidence");

					SearchImagesResponse.SearchImages_ImagesItem.SearchImages_OCRItem.SearchImages_OCRBoundary oCRBoundary = new SearchImagesResponse.SearchImages_ImagesItem.SearchImages_OCRItem.SearchImages_OCRBoundary();
					oCRBoundary.Left = context.IntegerValue("SearchImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Left1 = context.IntegerValue("SearchImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Width = context.IntegerValue("SearchImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Width");
					oCRBoundary.Height = context.IntegerValue("SearchImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Height");
					oCRItem.OCRBoundary = oCRBoundary;

					imagesItem_oCR.Add(oCRItem);
				}
				imagesItem.OCR = imagesItem_oCR;

				List<SearchImagesResponse.SearchImages_ImagesItem.SearchImages_CelebrityItem> imagesItem_celebrity = new List<SearchImagesResponse.SearchImages_ImagesItem.SearchImages_CelebrityItem>();
				for (int j = 0; j < context.Length("SearchImages.Images["+ i +"].Celebrity.Length"); j++) {
					SearchImagesResponse.SearchImages_ImagesItem.SearchImages_CelebrityItem celebrityItem = new SearchImagesResponse.SearchImages_ImagesItem.SearchImages_CelebrityItem();
					celebrityItem.CelebrityName = context.StringValue("SearchImages.Images["+ i +"].Celebrity["+ j +"].CelebrityName");
					celebrityItem.CelebrityGender = context.StringValue("SearchImages.Images["+ i +"].Celebrity["+ j +"].CelebrityGender");
					celebrityItem.CelebrityConfidence = context.FloatValue("SearchImages.Images["+ i +"].Celebrity["+ j +"].CelebrityConfidence");
					celebrityItem.CelebrityLibraryName = context.StringValue("SearchImages.Images["+ i +"].Celebrity["+ j +"].CelebrityLibraryName");

					SearchImagesResponse.SearchImages_ImagesItem.SearchImages_CelebrityItem.SearchImages_CelebrityBoundary celebrityBoundary = new SearchImagesResponse.SearchImages_ImagesItem.SearchImages_CelebrityItem.SearchImages_CelebrityBoundary();
					celebrityBoundary.Left = context.IntegerValue("SearchImages.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Left");
					celebrityBoundary.Top = context.IntegerValue("SearchImages.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Top");
					celebrityBoundary.Width = context.IntegerValue("SearchImages.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Width");
					celebrityBoundary.Height = context.IntegerValue("SearchImages.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Height");
					celebrityItem.CelebrityBoundary = celebrityBoundary;

					imagesItem_celebrity.Add(celebrityItem);
				}
				imagesItem.Celebrity = imagesItem_celebrity;

				searchImagesResponse_images.Add(imagesItem);
			}
			searchImagesResponse.Images = searchImagesResponse_images;
        
			return searchImagesResponse;
        }
    }
}