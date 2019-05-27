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
    public class ListVideoFramesResponseUnmarshaller
    {
        public static ListVideoFramesResponse Unmarshall(UnmarshallerContext context)
        {
			ListVideoFramesResponse listVideoFramesResponse = new ListVideoFramesResponse();

			listVideoFramesResponse.HttpResponse = context.HttpResponse;
			listVideoFramesResponse.SetId = context.StringValue("ListVideoFrames.SetId");
			listVideoFramesResponse.VideoUri = context.StringValue("ListVideoFrames.VideoUri");
			listVideoFramesResponse.NextMarker = context.StringValue("ListVideoFrames.NextMarker");
			listVideoFramesResponse.RequestId = context.StringValue("ListVideoFrames.RequestId");

			List<ListVideoFramesResponse.ListVideoFrames_FramesItem> listVideoFramesResponse_frames = new List<ListVideoFramesResponse.ListVideoFrames_FramesItem>();
			for (int i = 0; i < context.Length("ListVideoFrames.Frames.Length"); i++) {
				ListVideoFramesResponse.ListVideoFrames_FramesItem framesItem = new ListVideoFramesResponse.ListVideoFrames_FramesItem();
				framesItem.FacesModifyTime = context.StringValue("ListVideoFrames.Frames["+ i +"].FacesModifyTime");
				framesItem.OCRModifyTime = context.StringValue("ListVideoFrames.Frames["+ i +"].OCRModifyTime");
				framesItem.OCRStatus = context.StringValue("ListVideoFrames.Frames["+ i +"].OCRStatus");
				framesItem.SourcePosition = context.StringValue("ListVideoFrames.Frames["+ i +"].SourcePosition");
				framesItem.Exif = context.StringValue("ListVideoFrames.Frames["+ i +"].Exif");
				framesItem.ImageUri = context.StringValue("ListVideoFrames.Frames["+ i +"].ImageUri");
				framesItem.ImageWidth = context.IntegerValue("ListVideoFrames.Frames["+ i +"].ImageWidth");
				framesItem.ImageFormat = context.StringValue("ListVideoFrames.Frames["+ i +"].ImageFormat");
				framesItem.SourceType = context.StringValue("ListVideoFrames.Frames["+ i +"].SourceType");
				framesItem.ModifyTime = context.StringValue("ListVideoFrames.Frames["+ i +"].ModifyTime");
				framesItem.FileSize = context.IntegerValue("ListVideoFrames.Frames["+ i +"].FileSize");
				framesItem.SourceUri = context.StringValue("ListVideoFrames.Frames["+ i +"].SourceUri");
				framesItem.CreateTime = context.StringValue("ListVideoFrames.Frames["+ i +"].CreateTime");
				framesItem.FacesStatus = context.StringValue("ListVideoFrames.Frames["+ i +"].FacesStatus");
				framesItem.RemarksA = context.StringValue("ListVideoFrames.Frames["+ i +"].RemarksA");
				framesItem.ImageHeight = context.IntegerValue("ListVideoFrames.Frames["+ i +"].ImageHeight");
				framesItem.RemarksB = context.StringValue("ListVideoFrames.Frames["+ i +"].RemarksB");
				framesItem.ImageTime = context.StringValue("ListVideoFrames.Frames["+ i +"].ImageTime");
				framesItem.Orientation = context.StringValue("ListVideoFrames.Frames["+ i +"].Orientation");
				framesItem.Location = context.StringValue("ListVideoFrames.Frames["+ i +"].Location");
				framesItem.OCRFailReason = context.StringValue("ListVideoFrames.Frames["+ i +"].OCRFailReason");
				framesItem.FacesFailReason = context.StringValue("ListVideoFrames.Frames["+ i +"].FacesFailReason");
				framesItem.TagsFailReason = context.StringValue("ListVideoFrames.Frames["+ i +"].TagsFailReason");
				framesItem.TagsModifyTime = context.StringValue("ListVideoFrames.Frames["+ i +"].TagsModifyTime");
				framesItem.CelebrityStatus = context.StringValue("ListVideoFrames.Frames["+ i +"].CelebrityStatus");
				framesItem.CelebrityModifyTime = context.StringValue("ListVideoFrames.Frames["+ i +"].CelebrityModifyTime");
				framesItem.CelebrityFailReason = context.StringValue("ListVideoFrames.Frames["+ i +"].CelebrityFailReason");
				framesItem.TagsStatus = context.StringValue("ListVideoFrames.Frames["+ i +"].TagsStatus");
				framesItem.RemarksC = context.StringValue("ListVideoFrames.Frames["+ i +"].RemarksC");
				framesItem.RemarksD = context.StringValue("ListVideoFrames.Frames["+ i +"].RemarksD");
				framesItem.ExternalId = context.StringValue("ListVideoFrames.Frames["+ i +"].ExternalId");

				List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem> framesItem_faces = new List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem>();
				for (int j = 0; j < context.Length("ListVideoFrames.Frames["+ i +"].Faces.Length"); j++) {
					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem facesItem = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem();
					facesItem.Age = context.IntegerValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].Age");
					facesItem.GenderConfidence = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].GenderConfidence");
					facesItem.Attractive = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].Attractive");
					facesItem.Gender = context.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].Gender");
					facesItem.FaceConfidence = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceConfidence");
					facesItem.Emotion = context.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].Emotion");
					facesItem.FaceId = context.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceId");
					facesItem.EmotionConfidence = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionConfidence");
					facesItem.GroupId = context.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].GroupId");
					facesItem.FaceQuality = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceQuality");

					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_EmotionDetails emotionDetails = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_EmotionDetails();
					emotionDetails.SAD = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.SAD");
					emotionDetails.CALM = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.CALM");
					emotionDetails.ANGRY = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.ANGRY");
					emotionDetails.HAPPY = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.HAPPY");
					emotionDetails.SCARED = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.SCARED");
					emotionDetails.DISGUSTED = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.DISGUSTED");
					emotionDetails.SURPRISED = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.SURPRISED");
					facesItem.EmotionDetails = emotionDetails;

					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_FaceAttributes faceAttributes = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_FaceAttributes();
					faceAttributes.GlassesConfidence = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.GlassesConfidence");
					faceAttributes.Glasses = context.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.Glasses");
					faceAttributes.RaceConfidence = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.RaceConfidence");
					faceAttributes.Beard = context.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.Beard");
					faceAttributes.MaskConfidence = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.MaskConfidence");
					faceAttributes.Race = context.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.Race");
					faceAttributes.BeardConfidence = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.BeardConfidence");
					faceAttributes.Mask = context.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.Mask");

					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_FaceAttributes.ListVideoFrames_FaceBoundary faceBoundary = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_FaceAttributes.ListVideoFrames_FaceBoundary();
					faceBoundary.Top = context.IntegerValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Top");
					faceBoundary.Height = context.IntegerValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Height");
					faceBoundary.Width = context.IntegerValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Width");
					faceBoundary.Left = context.IntegerValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Left");
					faceAttributes.FaceBoundary = faceBoundary;

					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_FaceAttributes.ListVideoFrames_HeadPose headPose = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_FaceAttributes.ListVideoFrames_HeadPose();
					headPose.Pitch = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Pitch");
					headPose.Roll = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Roll");
					headPose.Yaw = context.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Yaw");
					faceAttributes.HeadPose = headPose;
					facesItem.FaceAttributes = faceAttributes;

					framesItem_faces.Add(facesItem);
				}
				framesItem.Faces = framesItem_faces;

				List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_TagsItem> framesItem_tags = new List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_TagsItem>();
				for (int j = 0; j < context.Length("ListVideoFrames.Frames["+ i +"].Tags.Length"); j++) {
					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_TagsItem tagsItem = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_TagsItem();
					tagsItem.TagConfidence = context.FloatValue("ListVideoFrames.Frames["+ i +"].Tags["+ j +"].TagConfidence");
					tagsItem.TagLevel = context.IntegerValue("ListVideoFrames.Frames["+ i +"].Tags["+ j +"].TagLevel");
					tagsItem.TagName = context.StringValue("ListVideoFrames.Frames["+ i +"].Tags["+ j +"].TagName");
					tagsItem.ParentTagName = context.StringValue("ListVideoFrames.Frames["+ i +"].Tags["+ j +"].ParentTagName");

					framesItem_tags.Add(tagsItem);
				}
				framesItem.Tags = framesItem_tags;

				List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_OCRItem> framesItem_oCR = new List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_OCRItem>();
				for (int j = 0; j < context.Length("ListVideoFrames.Frames["+ i +"].OCR.Length"); j++) {
					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_OCRItem oCRItem = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_OCRItem();
					oCRItem.OCRContents = context.StringValue("ListVideoFrames.Frames["+ i +"].OCR["+ j +"].OCRContents");
					oCRItem.OCRConfidence = context.FloatValue("ListVideoFrames.Frames["+ i +"].OCR["+ j +"].OCRConfidence");

					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_OCRItem.ListVideoFrames_OCRBoundary oCRBoundary = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_OCRItem.ListVideoFrames_OCRBoundary();
					oCRBoundary.Left = context.IntegerValue("ListVideoFrames.Frames["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Left1 = context.IntegerValue("ListVideoFrames.Frames["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Width = context.IntegerValue("ListVideoFrames.Frames["+ i +"].OCR["+ j +"].OCRBoundary.Width");
					oCRBoundary.Height = context.IntegerValue("ListVideoFrames.Frames["+ i +"].OCR["+ j +"].OCRBoundary.Height");
					oCRItem.OCRBoundary = oCRBoundary;

					framesItem_oCR.Add(oCRItem);
				}
				framesItem.OCR = framesItem_oCR;

				List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_CelebrityItem> framesItem_celebrity = new List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_CelebrityItem>();
				for (int j = 0; j < context.Length("ListVideoFrames.Frames["+ i +"].Celebrity.Length"); j++) {
					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_CelebrityItem celebrityItem = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_CelebrityItem();
					celebrityItem.CelebrityName = context.StringValue("ListVideoFrames.Frames["+ i +"].Celebrity["+ j +"].CelebrityName");
					celebrityItem.CelebrityGender = context.StringValue("ListVideoFrames.Frames["+ i +"].Celebrity["+ j +"].CelebrityGender");
					celebrityItem.CelebrityConfidence = context.FloatValue("ListVideoFrames.Frames["+ i +"].Celebrity["+ j +"].CelebrityConfidence");
					celebrityItem.CelebrityLibraryName = context.StringValue("ListVideoFrames.Frames["+ i +"].Celebrity["+ j +"].CelebrityLibraryName");

					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_CelebrityItem.ListVideoFrames_CelebrityBoundary celebrityBoundary = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_CelebrityItem.ListVideoFrames_CelebrityBoundary();
					celebrityBoundary.Left = context.IntegerValue("ListVideoFrames.Frames["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Left");
					celebrityBoundary.Top = context.IntegerValue("ListVideoFrames.Frames["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Top");
					celebrityBoundary.Width = context.IntegerValue("ListVideoFrames.Frames["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Width");
					celebrityBoundary.Height = context.IntegerValue("ListVideoFrames.Frames["+ i +"].Celebrity["+ j +"].CelebrityBoundary.Height");
					celebrityItem.CelebrityBoundary = celebrityBoundary;

					framesItem_celebrity.Add(celebrityItem);
				}
				framesItem.Celebrity = framesItem_celebrity;

				listVideoFramesResponse_frames.Add(framesItem);
			}
			listVideoFramesResponse.Frames = listVideoFramesResponse_frames;
        
			return listVideoFramesResponse;
        }
    }
}
