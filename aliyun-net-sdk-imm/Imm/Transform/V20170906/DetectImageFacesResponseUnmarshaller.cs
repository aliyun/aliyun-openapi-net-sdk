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
    public class DetectImageFacesResponseUnmarshaller
    {
        public static DetectImageFacesResponse Unmarshall(UnmarshallerContext context)
        {
			DetectImageFacesResponse detectImageFacesResponse = new DetectImageFacesResponse();

			detectImageFacesResponse.HttpResponse = context.HttpResponse;
			detectImageFacesResponse.RequestId = context.StringValue("DetectImageFaces.RequestId");
			detectImageFacesResponse.ImageUri = context.StringValue("DetectImageFaces.ImageUri");

			List<DetectImageFacesResponse.DetectImageFaces_FacesItem> detectImageFacesResponse_faces = new List<DetectImageFacesResponse.DetectImageFaces_FacesItem>();
			for (int i = 0; i < context.Length("DetectImageFaces.Faces.Length"); i++) {
				DetectImageFacesResponse.DetectImageFaces_FacesItem facesItem = new DetectImageFacesResponse.DetectImageFaces_FacesItem();
				facesItem.FaceId = context.StringValue("DetectImageFaces.Faces["+ i +"].FaceId");
				facesItem.FaceConfidence = context.FloatValue("DetectImageFaces.Faces["+ i +"].FaceConfidence");
				facesItem.Age = context.IntegerValue("DetectImageFaces.Faces["+ i +"].Age");
				facesItem.Gender = context.StringValue("DetectImageFaces.Faces["+ i +"].Gender");
				facesItem.Emotion = context.StringValue("DetectImageFaces.Faces["+ i +"].Emotion");
				facesItem.Attractive = context.FloatValue("DetectImageFaces.Faces["+ i +"].Attractive");
				facesItem.GenderConfidence = context.FloatValue("DetectImageFaces.Faces["+ i +"].GenderConfidence");
				facesItem.AgeConfidence = context.FloatValue("DetectImageFaces.Faces["+ i +"].AgeConfidence");
				facesItem.AttractiveConfidence = context.FloatValue("DetectImageFaces.Faces["+ i +"].AttractiveConfidence");
				facesItem.EmotionConfidence = context.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionConfidence");
				facesItem.FaceQuality = context.FloatValue("DetectImageFaces.Faces["+ i +"].FaceQuality");

				DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_FaceAttributes faceAttributes = new DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_FaceAttributes();
				faceAttributes.Glasses = context.StringValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.Glasses");
				faceAttributes.Beard = context.StringValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.Beard");
				faceAttributes.Race = context.StringValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.Race");
				faceAttributes.Mask = context.StringValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.Mask");
				faceAttributes.GlassesConfidence = context.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.GlassesConfidence");
				faceAttributes.BeardConfidence = context.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.BeardConfidence");
				faceAttributes.RaceConfidence = context.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.RaceConfidence");
				faceAttributes.MaskConfidence = context.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.MaskConfidence");

				DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_FaceAttributes.DetectImageFaces_FaceBoundary faceBoundary = new DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_FaceAttributes.DetectImageFaces_FaceBoundary();
				faceBoundary.Left = context.IntegerValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.FaceBoundary.Left");
				faceBoundary.Top = context.IntegerValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.FaceBoundary.Top");
				faceBoundary.Width = context.IntegerValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.FaceBoundary.Width");
				faceBoundary.Height = context.IntegerValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.FaceBoundary.Height");
				faceAttributes.FaceBoundary = faceBoundary;

				DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_FaceAttributes.DetectImageFaces_HeadPose headPose = new DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_FaceAttributes.DetectImageFaces_HeadPose();
				headPose.Pitch = context.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.HeadPose.Pitch");
				headPose.Roll = context.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.HeadPose.Roll");
				headPose.Yaw = context.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.HeadPose.Yaw");
				faceAttributes.HeadPose = headPose;
				facesItem.FaceAttributes = faceAttributes;

				DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_EmotionDetails emotionDetails = new DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_EmotionDetails();
				emotionDetails.HAPPY = context.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.HAPPY");
				emotionDetails.SAD = context.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.SAD");
				emotionDetails.ANGRY = context.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.ANGRY");
				emotionDetails.SURPRISED = context.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.SURPRISED");
				emotionDetails.SCARED = context.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.SCARED");
				emotionDetails.DISGUSTED = context.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.DISGUSTED");
				emotionDetails.CALM = context.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.CALM");
				facesItem.EmotionDetails = emotionDetails;

				detectImageFacesResponse_faces.Add(facesItem);
			}
			detectImageFacesResponse.Faces = detectImageFacesResponse_faces;
        
			return detectImageFacesResponse;
        }
    }
}
