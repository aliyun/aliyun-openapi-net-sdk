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
        public static DetectImageFacesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectImageFacesResponse detectImageFacesResponse = new DetectImageFacesResponse();

			detectImageFacesResponse.HttpResponse = _ctx.HttpResponse;
			detectImageFacesResponse.RequestId = _ctx.StringValue("DetectImageFaces.RequestId");
			detectImageFacesResponse.ImageUri = _ctx.StringValue("DetectImageFaces.ImageUri");

			List<DetectImageFacesResponse.DetectImageFaces_FacesItem> detectImageFacesResponse_faces = new List<DetectImageFacesResponse.DetectImageFaces_FacesItem>();
			for (int i = 0; i < _ctx.Length("DetectImageFaces.Faces.Length"); i++) {
				DetectImageFacesResponse.DetectImageFaces_FacesItem facesItem = new DetectImageFacesResponse.DetectImageFaces_FacesItem();
				facesItem.FaceId = _ctx.StringValue("DetectImageFaces.Faces["+ i +"].FaceId");
				facesItem.FaceConfidence = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].FaceConfidence");
				facesItem.Age = _ctx.IntegerValue("DetectImageFaces.Faces["+ i +"].Age");
				facesItem.Gender = _ctx.StringValue("DetectImageFaces.Faces["+ i +"].Gender");
				facesItem.Emotion = _ctx.StringValue("DetectImageFaces.Faces["+ i +"].Emotion");
				facesItem.Attractive = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].Attractive");
				facesItem.GenderConfidence = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].GenderConfidence");
				facesItem.AgeConfidence = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].AgeConfidence");
				facesItem.AttractiveConfidence = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].AttractiveConfidence");
				facesItem.EmotionConfidence = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionConfidence");
				facesItem.FaceQuality = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].FaceQuality");

				DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_FaceAttributes faceAttributes = new DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_FaceAttributes();
				faceAttributes.Glasses = _ctx.StringValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.Glasses");
				faceAttributes.Beard = _ctx.StringValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.Beard");
				faceAttributes.Mask = _ctx.StringValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.Mask");
				faceAttributes.GlassesConfidence = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.GlassesConfidence");
				faceAttributes.BeardConfidence = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.BeardConfidence");
				faceAttributes.MaskConfidence = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.MaskConfidence");

				DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_FaceAttributes.DetectImageFaces_FaceBoundary faceBoundary = new DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_FaceAttributes.DetectImageFaces_FaceBoundary();
				faceBoundary.Left = _ctx.IntegerValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.FaceBoundary.Left");
				faceBoundary.Top = _ctx.IntegerValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.FaceBoundary.Top");
				faceBoundary.Width = _ctx.IntegerValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.FaceBoundary.Width");
				faceBoundary.Height = _ctx.IntegerValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.FaceBoundary.Height");
				faceAttributes.FaceBoundary = faceBoundary;

				DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_FaceAttributes.DetectImageFaces_HeadPose headPose = new DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_FaceAttributes.DetectImageFaces_HeadPose();
				headPose.Pitch = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.HeadPose.Pitch");
				headPose.Roll = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.HeadPose.Roll");
				headPose.Yaw = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].FaceAttributes.HeadPose.Yaw");
				faceAttributes.HeadPose = headPose;
				facesItem.FaceAttributes = faceAttributes;

				DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_EmotionDetails emotionDetails = new DetectImageFacesResponse.DetectImageFaces_FacesItem.DetectImageFaces_EmotionDetails();
				emotionDetails.HAPPY = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.HAPPY");
				emotionDetails.SAD = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.SAD");
				emotionDetails.ANGRY = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.ANGRY");
				emotionDetails.SURPRISED = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.SURPRISED");
				emotionDetails.SCARED = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.SCARED");
				emotionDetails.DISGUSTED = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.DISGUSTED");
				emotionDetails.CALM = _ctx.FloatValue("DetectImageFaces.Faces["+ i +"].EmotionDetails.CALM");
				facesItem.EmotionDetails = emotionDetails;

				detectImageFacesResponse_faces.Add(facesItem);
			}
			detectImageFacesResponse.Faces = detectImageFacesResponse_faces;
        
			return detectImageFacesResponse;
        }
    }
}
