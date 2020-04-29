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
    public class FindImagesByTagNamesResponseUnmarshaller
    {
        public static FindImagesByTagNamesResponse Unmarshall(UnmarshallerContext context)
        {
			FindImagesByTagNamesResponse findImagesByTagNamesResponse = new FindImagesByTagNamesResponse();

			findImagesByTagNamesResponse.HttpResponse = context.HttpResponse;
			findImagesByTagNamesResponse.SetId = context.StringValue("FindImagesByTagNames.SetId");
			findImagesByTagNamesResponse.NextMarker = context.StringValue("FindImagesByTagNames.NextMarker");
			findImagesByTagNamesResponse.RequestId = context.StringValue("FindImagesByTagNames.RequestId");

			List<FindImagesByTagNamesResponse.FindImagesByTagNames_Frames> findImagesByTagNamesResponse_images = new List<FindImagesByTagNamesResponse.FindImagesByTagNames_Frames>();
			for (int i = 0; i < context.Length("FindImagesByTagNames.Images.Length"); i++) {
				FindImagesByTagNamesResponse.FindImagesByTagNames_Frames frames = new FindImagesByTagNamesResponse.FindImagesByTagNames_Frames();
				frames.FacesModifyTime = context.StringValue("FindImagesByTagNames.Images["+ i +"].FacesModifyTime");
				frames.OCRModifyTime = context.StringValue("FindImagesByTagNames.Images["+ i +"].OCRModifyTime");
				frames.OCRStatus = context.StringValue("FindImagesByTagNames.Images["+ i +"].OCRStatus");
				frames.SourcePosition = context.StringValue("FindImagesByTagNames.Images["+ i +"].SourcePosition");
				frames.Exif = context.StringValue("FindImagesByTagNames.Images["+ i +"].Exif");
				frames.ImageUri = context.StringValue("FindImagesByTagNames.Images["+ i +"].ImageUri");
				frames.ImageWidth = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].ImageWidth");
				frames.ImageFormat = context.StringValue("FindImagesByTagNames.Images["+ i +"].ImageFormat");
				frames.SourceType = context.StringValue("FindImagesByTagNames.Images["+ i +"].SourceType");
				frames.ModifyTime = context.StringValue("FindImagesByTagNames.Images["+ i +"].ModifyTime");
				frames.FileSize = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].FileSize");
				frames.SourceUri = context.StringValue("FindImagesByTagNames.Images["+ i +"].SourceUri");
				frames.CreateTime = context.StringValue("FindImagesByTagNames.Images["+ i +"].CreateTime");
				frames.FacesStatus = context.StringValue("FindImagesByTagNames.Images["+ i +"].FacesStatus");
				frames.RemarksA = context.StringValue("FindImagesByTagNames.Images["+ i +"].RemarksA");
				frames.ImageHeight = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].ImageHeight");
				frames.RemarksB = context.StringValue("FindImagesByTagNames.Images["+ i +"].RemarksB");
				frames.ImageTime = context.StringValue("FindImagesByTagNames.Images["+ i +"].ImageTime");
				frames.Orientation = context.StringValue("FindImagesByTagNames.Images["+ i +"].Orientation");
				frames.Location = context.StringValue("FindImagesByTagNames.Images["+ i +"].Location");
				frames.OCRFailReason = context.StringValue("FindImagesByTagNames.Images["+ i +"].OCRFailReason");
				frames.FacesFailReason = context.StringValue("FindImagesByTagNames.Images["+ i +"].FacesFailReason");
				frames.TagsFailReason = context.StringValue("FindImagesByTagNames.Images["+ i +"].TagsFailReason");
				frames.TagsModifyTime = context.StringValue("FindImagesByTagNames.Images["+ i +"].TagsModifyTime");
				frames.CelebrityStatus = context.StringValue("FindImagesByTagNames.Images["+ i +"].CelebrityStatus");
				frames.CelebrityModifyTime = context.StringValue("FindImagesByTagNames.Images["+ i +"].CelebrityModifyTime");
				frames.CelebrityFailReason = context.StringValue("FindImagesByTagNames.Images["+ i +"].CelebrityFailReason");
				frames.TagsStatus = context.StringValue("FindImagesByTagNames.Images["+ i +"].TagsStatus");
				frames.ExternalId = context.StringValue("FindImagesByTagNames.Images["+ i +"].ExternalId");
				frames.RemarksC = context.StringValue("FindImagesByTagNames.Images["+ i +"].RemarksC");
				frames.RemarksD = context.StringValue("FindImagesByTagNames.Images["+ i +"].RemarksD");
				frames.AddressModifyTime = context.StringValue("FindImagesByTagNames.Images["+ i +"].AddressModifyTime");
				frames.AddressStatus = context.StringValue("FindImagesByTagNames.Images["+ i +"].AddressStatus");
				frames.AddressFailReason = context.StringValue("FindImagesByTagNames.Images["+ i +"].AddressFailReason");
				frames.RemarksArrayA = context.StringValue("FindImagesByTagNames.Images["+ i +"].RemarksArrayA");
				frames.RemarksArrayB = context.StringValue("FindImagesByTagNames.Images["+ i +"].RemarksArrayB");

				FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_Address address = new FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_Address();
				address.AddressLine = context.StringValue("FindImagesByTagNames.Images["+ i +"].Address.AddressLine");
				address.Country = context.StringValue("FindImagesByTagNames.Images["+ i +"].Address.Country");
				address.Province = context.StringValue("FindImagesByTagNames.Images["+ i +"].Address.Province");
				address.City = context.StringValue("FindImagesByTagNames.Images["+ i +"].Address.City");
				address.District = context.StringValue("FindImagesByTagNames.Images["+ i +"].Address.District");
				address.Township = context.StringValue("FindImagesByTagNames.Images["+ i +"].Address.Township");
				frames.Address = address;

				List<FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_FacesItem> frames_faces = new List<FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_FacesItem>();
				for (int j = 0; j < context.Length("FindImagesByTagNames.Images["+ i +"].Faces.Length"); j++) {
					FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_FacesItem facesItem = new FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_FacesItem();
					facesItem.Age = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].Age");
					facesItem.GenderConfidence = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].GenderConfidence");
					facesItem.Attractive = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].Attractive");
					facesItem.Gender = context.StringValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].Gender");
					facesItem.FaceConfidence = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceConfidence");
					facesItem.Emotion = context.StringValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].Emotion");
					facesItem.FaceId = context.StringValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceId");
					facesItem.EmotionConfidence = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionConfidence");
					facesItem.GroupId = context.StringValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].GroupId");
					facesItem.FaceQuality = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceQuality");

					FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_FacesItem.FindImagesByTagNames_EmotionDetails emotionDetails = new FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_FacesItem.FindImagesByTagNames_EmotionDetails();
					emotionDetails.SAD = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.SAD");
					emotionDetails.CALM = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.CALM");
					emotionDetails.ANGRY = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.ANGRY");
					emotionDetails.HAPPY = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.HAPPY");
					emotionDetails.SCARED = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.SCARED");
					emotionDetails.DISGUSTED = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.DISGUSTED");
					emotionDetails.SURPRISED = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].EmotionDetails.SURPRISED");
					facesItem.EmotionDetails = emotionDetails;

					FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_FacesItem.FindImagesByTagNames_FaceAttributes faceAttributes = new FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_FacesItem.FindImagesByTagNames_FaceAttributes();
					faceAttributes.GlassesConfidence = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.GlassesConfidence");
					faceAttributes.Glasses = context.StringValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.Glasses");
					faceAttributes.RaceConfidence = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.RaceConfidence");
					faceAttributes.Beard = context.StringValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.Beard");
					faceAttributes.MaskConfidence = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.MaskConfidence");
					faceAttributes.Race = context.StringValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.Race");
					faceAttributes.BeardConfidence = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.BeardConfidence");
					faceAttributes.Mask = context.StringValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.Mask");

					FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_FacesItem.FindImagesByTagNames_FaceAttributes.FindImagesByTagNames_FaceBoundary faceBoundary = new FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_FacesItem.FindImagesByTagNames_FaceAttributes.FindImagesByTagNames_FaceBoundary();
					faceBoundary.Top = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Top");
					faceBoundary.Height = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Height");
					faceBoundary.Width = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Width");
					faceBoundary.Left = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Left");
					faceAttributes.FaceBoundary = faceBoundary;

					FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_FacesItem.FindImagesByTagNames_FaceAttributes.FindImagesByTagNames_HeadPose headPose = new FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_FacesItem.FindImagesByTagNames_FaceAttributes.FindImagesByTagNames_HeadPose();
					headPose.Pitch = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Pitch");
					headPose.Roll = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Roll");
					headPose.Yaw = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Yaw");
					faceAttributes.HeadPose = headPose;
					facesItem.FaceAttributes = faceAttributes;

					frames_faces.Add(facesItem);
				}
				frames.Faces = frames_faces;

				List<FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_TagsItem> frames_tags = new List<FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_TagsItem>();
				for (int j = 0; j < context.Length("FindImagesByTagNames.Images["+ i +"].Tags.Length"); j++) {
					FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_TagsItem tagsItem = new FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_TagsItem();
					tagsItem.TagConfidence = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Tags["+ j +"].TagConfidence");
					tagsItem.TagLevel = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].Tags["+ j +"].TagLevel");
					tagsItem.TagName = context.StringValue("FindImagesByTagNames.Images["+ i +"].Tags["+ j +"].TagName");
					tagsItem.ParentTagName = context.StringValue("FindImagesByTagNames.Images["+ i +"].Tags["+ j +"].ParentTagName");

					frames_tags.Add(tagsItem);
				}
				frames.Tags = frames_tags;

				List<FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_OCRItem> frames_oCR = new List<FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_OCRItem>();
				for (int j = 0; j < context.Length("FindImagesByTagNames.Images["+ i +"].OCR.Length"); j++) {
					FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_OCRItem oCRItem = new FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_OCRItem();
					oCRItem.OCRContents = context.StringValue("FindImagesByTagNames.Images["+ i +"].OCR["+ j +"].OCRContents");
					oCRItem.OCRConfidence = context.FloatValue("FindImagesByTagNames.Images["+ i +"].OCR["+ j +"].OCRConfidence");

					FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_OCRItem.FindImagesByTagNames_OCRBoundary oCRBoundary = new FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_OCRItem.FindImagesByTagNames_OCRBoundary();
					oCRBoundary.Left = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Left1 = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Width = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].OCR["+ j +"].OCRBoundary.Width");
					oCRBoundary.Height = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].OCR["+ j +"].OCRBoundary.Height");
					oCRItem.OCRBoundary = oCRBoundary;

					frames_oCR.Add(oCRItem);
				}
				frames.OCR = frames_oCR;

				List<FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_CelebrityItem> frames_celebrity = new List<FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_CelebrityItem>();
				for (int j = 0; j < context.Length("FindImagesByTagNames.Images["+ i +"].Celebrity.Length"); j++) {
					FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_CelebrityItem celebrityItem = new FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_CelebrityItem();
					celebrityItem.CelebrityName = context.StringValue("FindImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityName");
					celebrityItem.CelebrityGender = context.StringValue("FindImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityGender");
					celebrityItem.CelebrityConfidence = context.FloatValue("FindImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityConfidence");
					celebrityItem.CelebrityLibraryName = context.StringValue("FindImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityLibraryName");

					FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_CelebrityItem.FindImagesByTagNames_CelebrityBoundary celebrityBoundary = new FindImagesByTagNamesResponse.FindImagesByTagNames_Frames.FindImagesByTagNames_CelebrityItem.FindImagesByTagNames_CelebrityBoundary();
					celebrityBoundary.Left = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Left");
					celebrityBoundary.Top = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Top");
					celebrityBoundary.Width = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Width");
					celebrityBoundary.Height = context.IntegerValue("FindImagesByTagNames.Images["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Height");
					celebrityItem.CelebrityBoundary = celebrityBoundary;

					frames_celebrity.Add(celebrityItem);
				}
				frames.Celebrity = frames_celebrity;

				findImagesByTagNamesResponse_images.Add(frames);
			}
			findImagesByTagNamesResponse.Images = findImagesByTagNamesResponse_images;
        
			return findImagesByTagNamesResponse;
        }
    }
}
