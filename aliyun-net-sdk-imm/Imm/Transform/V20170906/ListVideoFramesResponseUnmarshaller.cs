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
        public static ListVideoFramesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVideoFramesResponse listVideoFramesResponse = new ListVideoFramesResponse();

			listVideoFramesResponse.HttpResponse = _ctx.HttpResponse;
			listVideoFramesResponse.SetId = _ctx.StringValue("ListVideoFrames.SetId");
			listVideoFramesResponse.VideoUri = _ctx.StringValue("ListVideoFrames.VideoUri");
			listVideoFramesResponse.NextMarker = _ctx.StringValue("ListVideoFrames.NextMarker");
			listVideoFramesResponse.RequestId = _ctx.StringValue("ListVideoFrames.RequestId");

			List<ListVideoFramesResponse.ListVideoFrames_FramesItem> listVideoFramesResponse_frames = new List<ListVideoFramesResponse.ListVideoFrames_FramesItem>();
			for (int i = 0; i < _ctx.Length("ListVideoFrames.Frames.Length"); i++) {
				ListVideoFramesResponse.ListVideoFrames_FramesItem framesItem = new ListVideoFramesResponse.ListVideoFrames_FramesItem();
				framesItem.FacesModifyTime = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].FacesModifyTime");
				framesItem.OCRModifyTime = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].OCRModifyTime");
				framesItem.OCRStatus = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].OCRStatus");
				framesItem.SourcePosition = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].SourcePosition");
				framesItem.Exif = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].Exif");
				framesItem.ImageUri = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].ImageUri");
				framesItem.ImageWidth = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].ImageWidth");
				framesItem.ImageFormat = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].ImageFormat");
				framesItem.SourceType = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].SourceType");
				framesItem.ModifyTime = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].ModifyTime");
				framesItem.FileSize = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].FileSize");
				framesItem.SourceUri = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].SourceUri");
				framesItem.CreateTime = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].CreateTime");
				framesItem.FacesStatus = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].FacesStatus");
				framesItem.RemarksA = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].RemarksA");
				framesItem.ImageHeight = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].ImageHeight");
				framesItem.RemarksB = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].RemarksB");
				framesItem.ImageTime = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].ImageTime");
				framesItem.Orientation = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].Orientation");
				framesItem.Location = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].Location");
				framesItem.OCRFailReason = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].OCRFailReason");
				framesItem.FacesFailReason = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].FacesFailReason");
				framesItem.TagsFailReason = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].TagsFailReason");
				framesItem.TagsModifyTime = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].TagsModifyTime");
				framesItem.TagsStatus = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].TagsStatus");
				framesItem.RemarksC = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].RemarksC");
				framesItem.RemarksD = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].RemarksD");
				framesItem.ExternalId = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].ExternalId");

				List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem> framesItem_faces = new List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem>();
				for (int j = 0; j < _ctx.Length("ListVideoFrames.Frames["+ i +"].Faces.Length"); j++) {
					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem facesItem = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem();
					facesItem.Age = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].Age");
					facesItem.GenderConfidence = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].GenderConfidence");
					facesItem.Attractive = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].Attractive");
					facesItem.Gender = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].Gender");
					facesItem.FaceConfidence = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceConfidence");
					facesItem.Emotion = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].Emotion");
					facesItem.FaceId = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceId");
					facesItem.EmotionConfidence = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionConfidence");
					facesItem.GroupId = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].GroupId");
					facesItem.FaceQuality = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceQuality");

					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_EmotionDetails emotionDetails = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_EmotionDetails();
					emotionDetails.SAD = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.SAD");
					emotionDetails.CALM = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.CALM");
					emotionDetails.ANGRY = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.ANGRY");
					emotionDetails.HAPPY = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.HAPPY");
					emotionDetails.SCARED = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.SCARED");
					emotionDetails.DISGUSTED = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.DISGUSTED");
					emotionDetails.SURPRISED = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].EmotionDetails.SURPRISED");
					facesItem.EmotionDetails = emotionDetails;

					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_FaceAttributes faceAttributes = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_FaceAttributes();
					faceAttributes.GlassesConfidence = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.GlassesConfidence");
					faceAttributes.Glasses = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.Glasses");
					faceAttributes.Beard = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.Beard");
					faceAttributes.MaskConfidence = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.MaskConfidence");
					faceAttributes.BeardConfidence = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.BeardConfidence");
					faceAttributes.Mask = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.Mask");

					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_FaceAttributes.ListVideoFrames_FaceBoundary faceBoundary = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_FaceAttributes.ListVideoFrames_FaceBoundary();
					faceBoundary.Top = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Top");
					faceBoundary.Height = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Height");
					faceBoundary.Width = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Width");
					faceBoundary.Left = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.FaceBoundary.Left");
					faceAttributes.FaceBoundary = faceBoundary;

					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_FaceAttributes.ListVideoFrames_HeadPose headPose = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_FacesItem.ListVideoFrames_FaceAttributes.ListVideoFrames_HeadPose();
					headPose.Pitch = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Pitch");
					headPose.Roll = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Roll");
					headPose.Yaw = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Faces["+ j +"].FaceAttributes.HeadPose.Yaw");
					faceAttributes.HeadPose = headPose;
					facesItem.FaceAttributes = faceAttributes;

					framesItem_faces.Add(facesItem);
				}
				framesItem.Faces = framesItem_faces;

				List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_TagsItem> framesItem_tags = new List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_TagsItem>();
				for (int j = 0; j < _ctx.Length("ListVideoFrames.Frames["+ i +"].Tags.Length"); j++) {
					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_TagsItem tagsItem = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_TagsItem();
					tagsItem.TagConfidence = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].Tags["+ j +"].TagConfidence");
					tagsItem.TagLevel = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].Tags["+ j +"].TagLevel");
					tagsItem.TagName = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].Tags["+ j +"].TagName");
					tagsItem.ParentTagName = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].Tags["+ j +"].ParentTagName");

					framesItem_tags.Add(tagsItem);
				}
				framesItem.Tags = framesItem_tags;

				List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_OCRItem> framesItem_oCR = new List<ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_OCRItem>();
				for (int j = 0; j < _ctx.Length("ListVideoFrames.Frames["+ i +"].OCR.Length"); j++) {
					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_OCRItem oCRItem = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_OCRItem();
					oCRItem.OCRContents = _ctx.StringValue("ListVideoFrames.Frames["+ i +"].OCR["+ j +"].OCRContents");
					oCRItem.OCRConfidence = _ctx.FloatValue("ListVideoFrames.Frames["+ i +"].OCR["+ j +"].OCRConfidence");

					ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_OCRItem.ListVideoFrames_OCRBoundary oCRBoundary = new ListVideoFramesResponse.ListVideoFrames_FramesItem.ListVideoFrames_OCRItem.ListVideoFrames_OCRBoundary();
					oCRBoundary.Left = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].OCR["+ j +"].OCRBoundary.Left");
					oCRBoundary.Top = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].OCR["+ j +"].OCRBoundary.Top");
					oCRBoundary.Width = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].OCR["+ j +"].OCRBoundary.Width");
					oCRBoundary.Height = _ctx.IntegerValue("ListVideoFrames.Frames["+ i +"].OCR["+ j +"].OCRBoundary.Height");
					oCRItem.OCRBoundary = oCRBoundary;

					framesItem_oCR.Add(oCRItem);
				}
				framesItem.OCR = framesItem_oCR;

				listVideoFramesResponse_frames.Add(framesItem);
			}
			listVideoFramesResponse.Frames = listVideoFramesResponse_frames;
        
			return listVideoFramesResponse;
        }
    }
}
