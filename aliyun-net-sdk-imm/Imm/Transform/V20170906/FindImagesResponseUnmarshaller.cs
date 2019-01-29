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
    public class FindImagesResponseUnmarshaller
    {
        public static FindImagesResponse Unmarshall(UnmarshallerContext context)
        {
			FindImagesResponse findImagesResponse = new FindImagesResponse();

			findImagesResponse.HttpResponse = context.HttpResponse;
			findImagesResponse.SetId = context.StringValue("FindImages.SetId");
			findImagesResponse.NextMarker = context.StringValue("FindImages.NextMarker");
			findImagesResponse.RequestId = context.StringValue("FindImages.RequestId");

			List<FindImagesResponse.FindImages_ImagesItem> findImagesResponse_images = new List<FindImagesResponse.FindImages_ImagesItem>();
			for (int i = 0; i < context.Length("FindImages.Images.Length"); i++) {
				FindImagesResponse.FindImages_ImagesItem imagesItem = new FindImagesResponse.FindImages_ImagesItem();
				imagesItem.FacesModifyTime = context.StringValue("FindImages.Images["+ i +"].FacesModifyTime");
				imagesItem.OCRModifyTime = context.StringValue("FindImages.Images["+ i +"].OCRModifyTime");
				imagesItem.OCRStatus = context.StringValue("FindImages.Images["+ i +"].OCRStatus");
				imagesItem.SourcePosition = context.StringValue("FindImages.Images["+ i +"].SourcePosition");
				imagesItem.Exif = context.StringValue("FindImages.Images["+ i +"].Exif");
				imagesItem.ImageUri = context.StringValue("FindImages.Images["+ i +"].ImageUri");
				imagesItem.ImageWidth = context.IntegerValue("FindImages.Images["+ i +"].ImageWidth");
				imagesItem.ImageFormat = context.StringValue("FindImages.Images["+ i +"].ImageFormat");
				imagesItem.SourceType = context.StringValue("FindImages.Images["+ i +"].SourceType");
				imagesItem.ModifyTime = context.StringValue("FindImages.Images["+ i +"].ModifyTime");
				imagesItem.FileSize = context.IntegerValue("FindImages.Images["+ i +"].FileSize");
				imagesItem.SourceUri = context.StringValue("FindImages.Images["+ i +"].SourceUri");
				imagesItem.CreateTime = context.StringValue("FindImages.Images["+ i +"].CreateTime");
				imagesItem.FacesStatus = context.StringValue("FindImages.Images["+ i +"].FacesStatus");
				imagesItem.RemarksA = context.StringValue("FindImages.Images["+ i +"].RemarksA");
				imagesItem.ImageHeight = context.IntegerValue("FindImages.Images["+ i +"].ImageHeight");
				imagesItem.RemarksB = context.StringValue("FindImages.Images["+ i +"].RemarksB");
				imagesItem.ImageTime = context.StringValue("FindImages.Images["+ i +"].ImageTime");
				imagesItem.Orientation = context.StringValue("FindImages.Images["+ i +"].Orientation");
				imagesItem.Location = context.StringValue("FindImages.Images["+ i +"].Location");
				imagesItem.OCRFailReason = context.StringValue("FindImages.Images["+ i +"].OCRFailReason");
				imagesItem.FacesFailReason = context.StringValue("FindImages.Images["+ i +"].FacesFailReason");
				imagesItem.TagsFailReason = context.StringValue("FindImages.Images["+ i +"].TagsFailReason");
				imagesItem.TagsModifyTime = context.StringValue("FindImages.Images["+ i +"].TagsModifyTime");
				imagesItem.CelebrityStatus = context.StringValue("FindImages.Images["+ i +"].CelebrityStatus");
				imagesItem.CelebrityModifyTime = context.StringValue("FindImages.Images["+ i +"].CelebrityModifyTime");
				imagesItem.CelebrityFailReason = context.StringValue("FindImages.Images["+ i +"].CelebrityFailReason");
				imagesItem.TagsStatus = context.StringValue("FindImages.Images["+ i +"].TagsStatus");
				imagesItem.RemarksC = context.StringValue("FindImages.Images["+ i +"].RemarksC");
				imagesItem.RemarksD = context.StringValue("FindImages.Images["+ i +"].RemarksD");
				imagesItem.ExternalId = context.StringValue("FindImages.Images["+ i +"].ExternalId");

				List<FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem> imagesItem_faces = new List<FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem>();
				for (int j = 0; j < context.Length("FindImages.Images["+ i +"].Faces.Length"); j++) {
					FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem facesItem = new FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem();
					facesItem.Age = context.IntegerValue("FindImages.Images["+ i +"].Faces["+ j +"].Age");
					facesItem.GenderConfidence = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].GenderConfidence");
					facesItem.Attractive = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].Attractive");
					facesItem.Gender = context.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].Gender");
					facesItem.FaceConfidence = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceConfidence");
					facesItem.Emotion = context.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].Emotion");
					facesItem.FaceId = context.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceId");
					facesItem.EmotionConfidence = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionConfidence");

					FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_EmotionDetails emotionDetails = new FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_EmotionDetails();
					emotionDetails.SAD = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SAD");
					emotionDetails.CALM = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.CALM");
					emotionDetails.ANGRY = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.ANGRY");
					emotionDetails.HAPPY = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.HAPPY");
					emotionDetails.SCARED = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SCARED");
					emotionDetails.DISGUSTED = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.DISGUSTED");
					emotionDetails.SURPRISED = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].EmotionDetails.SURPRISED");
					facesItem.EmotionDetails = emotionDetails;

					FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_FaceAttributes faceAttributes = new FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_FaceAttributes();
					faceAttributes.GlassesConfidence = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.GlassesConfidence");
					faceAttributes.Glasses = context.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Glasses");
					faceAttributes.RaceConfidence = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.RaceConfidence");
					faceAttributes.Beard = context.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Beard");
					faceAttributes.MaskConfidence = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.MaskConfidence");
					faceAttributes.Race = context.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Race");
					faceAttributes.BeardConfidence = context.FloatValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.BeardConfidence");
					faceAttributes.Mask = context.StringValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.Mask");

					FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_FaceAttributes.FindImages_FaceBoundary faceBoundary = new FindImagesResponse.FindImages_ImagesItem.FindImages_FacesItem.FindImages_FaceAttributes.FindImages_FaceBoundary();
					faceBoundary.Top = context.IntegerValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Top");
					faceBoundary.Height = context.IntegerValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Height");
					faceBoundary.Width = context.IntegerValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Width");
					faceBoundary.Left = context.IntegerValue("FindImages.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Left");
					faceAttributes.FaceBoundary = faceBoundary;
					facesItem.FaceAttributes = faceAttributes;

					imagesItem_faces.Add(facesItem);
				}
				imagesItem.Faces = imagesItem_faces;

				List<FindImagesResponse.FindImages_ImagesItem.FindImages_TagsItem> imagesItem_tags = new List<FindImagesResponse.FindImages_ImagesItem.FindImages_TagsItem>();
				for (int j = 0; j < context.Length("FindImages.Images["+ i +"].Tags.Length"); j++) {
					FindImagesResponse.FindImages_ImagesItem.FindImages_TagsItem tagsItem = new FindImagesResponse.FindImages_ImagesItem.FindImages_TagsItem();
					tagsItem.TagConfidence = context.FloatValue("FindImages.Images["+ i +"].Tags["+ j +"].TagConfidence");
					tagsItem.TagLevel = context.IntegerValue("FindImages.Images["+ i +"].Tags["+ j +"].TagLevel");
					tagsItem.TagName = context.StringValue("FindImages.Images["+ i +"].Tags["+ j +"].TagName");
					tagsItem.ParentTagName = context.StringValue("FindImages.Images["+ i +"].Tags["+ j +"].ParentTagName");

					imagesItem_tags.Add(tagsItem);
				}
				imagesItem.Tags = imagesItem_tags;

				List<FindImagesResponse.FindImages_ImagesItem.FindImages_OCRItem> imagesItem_oCR = new List<FindImagesResponse.FindImages_ImagesItem.FindImages_OCRItem>();
				for (int j = 0; j < context.Length("FindImages.Images["+ i +"].OCR.Length"); j++) {
					FindImagesResponse.FindImages_ImagesItem.FindImages_OCRItem oCRItem = new FindImagesResponse.FindImages_ImagesItem.FindImages_OCRItem();
					oCRItem.OCRContents = context.StringValue("FindImages.Images["+ i +"].OCR["+ j +"].OCRContents");
					oCRItem.OCRConfidence = context.FloatValue("FindImages.Images["+ i +"].OCR["+ j +"].OCRConfidence");

					FindImagesResponse.FindImages_ImagesItem.FindImages_OCRItem.FindImages_OCRBoundary oCRBoundary = new FindImagesResponse.FindImages_ImagesItem.FindImages_OCRItem.FindImages_OCRBoundary();
					oCRBoundary.Left = context.IntegerValue("FindImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Left1 = context.IntegerValue("FindImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Width = context.IntegerValue("FindImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Width");
					oCRBoundary.Height = context.IntegerValue("FindImages.Images["+ i +"].OCR["+ j +"].OCRBoundary.Height");
					oCRItem.OCRBoundary = oCRBoundary;

					imagesItem_oCR.Add(oCRItem);
				}
				imagesItem.OCR = imagesItem_oCR;

				List<FindImagesResponse.FindImages_ImagesItem.FindImages_CelebrityItem> imagesItem_celebrity = new List<FindImagesResponse.FindImages_ImagesItem.FindImages_CelebrityItem>();
				for (int j = 0; j < context.Length("FindImages.Images["+ i +"].Celebrity.Length"); j++) {
					FindImagesResponse.FindImages_ImagesItem.FindImages_CelebrityItem celebrityItem = new FindImagesResponse.FindImages_ImagesItem.FindImages_CelebrityItem();
					celebrityItem.CelebrityName = context.StringValue("FindImages.Images["+ i +"].Celebrity["+ j +"].CelebrityName");
					celebrityItem.CelebrityGender = context.StringValue("FindImages.Images["+ i +"].Celebrity["+ j +"].CelebrityGender");
					celebrityItem.CelebrityConfidence = context.FloatValue("FindImages.Images["+ i +"].Celebrity["+ j +"].CelebrityConfidence");
					celebrityItem.CelebrityLibraryName = context.StringValue("FindImages.Images["+ i +"].Celebrity["+ j +"].CelebrityLibraryName");

					FindImagesResponse.FindImages_ImagesItem.FindImages_CelebrityItem.FindImages_CelebrityBoundary celebrityBoundary = new FindImagesResponse.FindImages_ImagesItem.FindImages_CelebrityItem.FindImages_CelebrityBoundary();
					celebrityBoundary.Left = context.IntegerValue("FindImages.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Left");
					celebrityBoundary.Top = context.IntegerValue("FindImages.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Top");
					celebrityBoundary.Width = context.IntegerValue("FindImages.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Width");
					celebrityBoundary.Height = context.IntegerValue("FindImages.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Height");
					celebrityItem.CelebrityBoundary = celebrityBoundary;

					imagesItem_celebrity.Add(celebrityItem);
				}
				imagesItem.Celebrity = imagesItem_celebrity;

				findImagesResponse_images.Add(imagesItem);
			}
			findImagesResponse.Images = findImagesResponse_images;
        
			return findImagesResponse;
        }
    }
}