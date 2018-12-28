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
    public class SearchImagesByTagNamesResponseUnmarshaller
    {
        public static SearchImagesByTagNamesResponse Unmarshall(UnmarshallerContext context)
        {
			SearchImagesByTagNamesResponse searchImagesByTagNamesResponse = new SearchImagesByTagNamesResponse();

			searchImagesByTagNamesResponse.HttpResponse = context.HttpResponse;
			searchImagesByTagNamesResponse.SetId = context.StringValue("SearchImagesByTagNames.SetId");
			searchImagesByTagNamesResponse.NextMarker = context.StringValue("SearchImagesByTagNames.NextMarker");
			searchImagesByTagNamesResponse.RequestId = context.StringValue("SearchImagesByTagNames.RequestId");

			List<SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames> searchImagesByTagNamesResponse_images = new List<SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames>();
			for (int i = 0; i < context.Length("SearchImagesByTagNames.Images.Length"); i++) {
				SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames frames = new SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames();
				frames.FacesModifyTime = context.StringValue("SearchImagesByTagNames.Images["+ i +"].FacesModifyTime");
				frames.OCRModifyTime = context.StringValue("SearchImagesByTagNames.Images["+ i +"].OCRModifyTime");
				frames.OCRStatus = context.StringValue("SearchImagesByTagNames.Images["+ i +"].OCRStatus");
				frames.SourcePosition = context.StringValue("SearchImagesByTagNames.Images["+ i +"].SourcePosition");
				frames.Exif = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Exif");
				frames.ImageUri = context.StringValue("SearchImagesByTagNames.Images["+ i +"].ImageUri");
				frames.ImageWidth = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].ImageWidth");
				frames.ImageFormat = context.StringValue("SearchImagesByTagNames.Images["+ i +"].ImageFormat");
				frames.SourceType = context.StringValue("SearchImagesByTagNames.Images["+ i +"].SourceType");
				frames.ModifyTime = context.StringValue("SearchImagesByTagNames.Images["+ i +"].ModifyTime");
				frames.FileSize = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].FileSize");
				frames.SourceUri = context.StringValue("SearchImagesByTagNames.Images["+ i +"].SourceUri");
				frames.CreateTime = context.StringValue("SearchImagesByTagNames.Images["+ i +"].CreateTime");
				frames.FacesStatus = context.StringValue("SearchImagesByTagNames.Images["+ i +"].FacesStatus");
				frames.RemarksA = context.StringValue("SearchImagesByTagNames.Images["+ i +"].RemarksA");
				frames.ImageHeight = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].ImageHeight");
				frames.RemarksB = context.StringValue("SearchImagesByTagNames.Images["+ i +"].RemarksB");
				frames.ImageTime = context.StringValue("SearchImagesByTagNames.Images["+ i +"].ImageTime");
				frames.Orientation = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Orientation");
				frames.Location = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Location");
				frames.OCRFailReason = context.StringValue("SearchImagesByTagNames.Images["+ i +"].OCRFailReason");
				frames.FacesFailReason = context.StringValue("SearchImagesByTagNames.Images["+ i +"].FacesFailReason");
				frames.TagsFailReason = context.StringValue("SearchImagesByTagNames.Images["+ i +"].TagsFailReason");
				frames.TagsModifyTime = context.StringValue("SearchImagesByTagNames.Images["+ i +"].TagsModifyTime");
				frames.CelebrityStatus = context.StringValue("SearchImagesByTagNames.Images["+ i +"].CelebrityStatus");
				frames.CelebrityModifyTime = context.StringValue("SearchImagesByTagNames.Images["+ i +"].CelebrityModifyTime");
				frames.CelebrityFailReason = context.StringValue("SearchImagesByTagNames.Images["+ i +"].CelebrityFailReason");
				frames.TagsStatus = context.StringValue("SearchImagesByTagNames.Images["+ i +"].TagsStatus");

				List<SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_FacesItem> frames_faces = new List<SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_FacesItem>();
				for (int j = 0; j < context.Length("SearchImagesByTagNames.Images["+ i +"].Faces.Length"); j++) {
					SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_FacesItem facesItem = new SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_FacesItem();
					facesItem.Age = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].Age");
					facesItem.GenderConfidence = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].GenderConfidence");
					facesItem.Attractive = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].Attractive");
					facesItem.Gender = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].Gender");
					facesItem.FaceConfidence = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceConfidence");
					facesItem.Emotion = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].Emotion");
					facesItem.FaceId = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceId");
					facesItem.EmotionConfidence = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionConfidence");

					SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_FacesItem.SearchImagesByTagNames_EmotionDetails emotionDetails = new SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_FacesItem.SearchImagesByTagNames_EmotionDetails();
					emotionDetails.SAD = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.SAD");
					emotionDetails.CALM = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.CALM");
					emotionDetails.ANGRY = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.ANGRY");
					emotionDetails.HAPPY = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.HAPPY");
					emotionDetails.SCARED = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.SCARED");
					emotionDetails.DISGUSTED = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.DISGUSTED");
					emotionDetails.SURPRISED = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.SURPRISED");
					facesItem.EmotionDetails = emotionDetails;

					SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_FacesItem.SearchImagesByTagNames_FaceAttributes faceAttributes = new SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_FacesItem.SearchImagesByTagNames_FaceAttributes();
					faceAttributes.GlassesConfidence = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.GlassesConfidence");
					faceAttributes.Glasses = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.Glasses");
					faceAttributes.RaceConfidence = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.RaceConfidence");
					faceAttributes.Beard = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.Beard");
					faceAttributes.MaskConfidence = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.MaskConfidence");
					faceAttributes.Race = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.Race");
					faceAttributes.BeardConfidence = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.BeardConfidence");
					faceAttributes.Mask = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.Mask");

					SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_FacesItem.SearchImagesByTagNames_FaceAttributes.SearchImagesByTagNames_FaceBoundary faceBoundary = new SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_FacesItem.SearchImagesByTagNames_FaceAttributes.SearchImagesByTagNames_FaceBoundary();
					faceBoundary.Top = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Top");
					faceBoundary.Height = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Height");
					faceBoundary.Width = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Width");
					faceBoundary.Left = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Left");
					faceAttributes.FaceBoundary = faceBoundary;
					facesItem.FaceAttributes = faceAttributes;

					frames_faces.Add(facesItem);
				}
				frames.Faces = frames_faces;

				List<SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_TagsItem> frames_tags = new List<SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_TagsItem>();
				for (int j = 0; j < context.Length("SearchImagesByTagNames.Images["+ i +"].Tags.Length"); j++) {
					SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_TagsItem tagsItem = new SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_TagsItem();
					tagsItem.TagConfidence = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Tags["+ j +"].TagConfidence");
					tagsItem.TagLevel = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].Tags["+ j +"].TagLevel");
					tagsItem.TagName = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Tags["+ j +"].TagName");
					tagsItem.ParentTagName = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Tags["+ j +"].ParentTagName");

					frames_tags.Add(tagsItem);
				}
				frames.Tags = frames_tags;

				List<SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_OCRItem> frames_oCR = new List<SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_OCRItem>();
				for (int j = 0; j < context.Length("SearchImagesByTagNames.Images["+ i +"].OCR.Length"); j++) {
					SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_OCRItem oCRItem = new SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_OCRItem();
					oCRItem.OCRContents = context.StringValue("SearchImagesByTagNames.Images["+ i +"].OCR["+ j +"].OCRContents");
					oCRItem.OCRConfidence = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].OCR["+ j +"].OCRConfidence");

					SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_OCRItem.SearchImagesByTagNames_OCRBoundary oCRBoundary = new SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_OCRItem.SearchImagesByTagNames_OCRBoundary();
					oCRBoundary.Left = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Left1 = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Width = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].OCR["+ j +"].OCRBoundary.Width");
					oCRBoundary.Height = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].OCR["+ j +"].OCRBoundary.Height");
					oCRItem.OCRBoundary = oCRBoundary;

					frames_oCR.Add(oCRItem);
				}
				frames.OCR = frames_oCR;

				List<SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_CelebrityItem> frames_celebrity = new List<SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_CelebrityItem>();
				for (int j = 0; j < context.Length("SearchImagesByTagNames.Images["+ i +"].Celebrity.Length"); j++) {
					SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_CelebrityItem celebrityItem = new SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_CelebrityItem();
					celebrityItem.CelebrityName = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityName");
					celebrityItem.CelebrityGender = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityGender");
					celebrityItem.CelebrityConfidence = context.FloatValue("SearchImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityConfidence");
					celebrityItem.CelebrityLibraryName = context.StringValue("SearchImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityLibraryName");

					SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_CelebrityItem.SearchImagesByTagNames_CelebrityBoundary celebrityBoundary = new SearchImagesByTagNamesResponse.SearchImagesByTagNames_Frames.SearchImagesByTagNames_CelebrityItem.SearchImagesByTagNames_CelebrityBoundary();
					celebrityBoundary.Left = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Left");
					celebrityBoundary.Top = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Top");
					celebrityBoundary.Width = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Width");
					celebrityBoundary.Height = context.IntegerValue("SearchImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Height");
					celebrityItem.CelebrityBoundary = celebrityBoundary;

					frames_celebrity.Add(celebrityItem);
				}
				frames.Celebrity = frames_celebrity;

				searchImagesByTagNamesResponse_images.Add(frames);
			}
			searchImagesByTagNamesResponse.Images = searchImagesByTagNamesResponse_images;
        
			return searchImagesByTagNamesResponse;
        }
    }
}