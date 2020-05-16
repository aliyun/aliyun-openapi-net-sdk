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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class RecognizeImageResponseUnmarshaller
    {
        public static RecognizeImageResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeImageResponse recognizeImageResponse = new RecognizeImageResponse();

			recognizeImageResponse.HttpResponse = context.HttpResponse;
			recognizeImageResponse.Code = context.StringValue("RecognizeImage.Code");
			recognizeImageResponse.Message = context.StringValue("RecognizeImage.Message");
			recognizeImageResponse.RequestId = context.StringValue("RecognizeImage.RequestId");

			RecognizeImageResponse.RecognizeImage_Data data = new RecognizeImageResponse.RecognizeImage_Data();

			List<RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_Body> data_bodyList = new List<RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_Body>();
			for (int i = 0; i < context.Length("RecognizeImage.Data.BodyList.Length"); i++) {
				RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_Body body = new RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_Body();
				body.Feature = context.StringValue("RecognizeImage.Data.BodyList["+ i +"].Feature");
				body.FileName = context.StringValue("RecognizeImage.Data.BodyList["+ i +"].FileName");
				body.ImageBaseSixFour = context.StringValue("RecognizeImage.Data.BodyList["+ i +"].ImageBaseSixFour");
				body.LeftTopX = context.StringValue("RecognizeImage.Data.BodyList["+ i +"].LeftTopX");
				body.LeftTopY = context.StringValue("RecognizeImage.Data.BodyList["+ i +"].LeftTopY");
				body.LocalFeature = context.StringValue("RecognizeImage.Data.BodyList["+ i +"].LocalFeature");
				body.RespiratorColor = context.StringValue("RecognizeImage.Data.BodyList["+ i +"].RespiratorColor");
				body.RightBottomX = context.StringValue("RecognizeImage.Data.BodyList["+ i +"].RightBottomX");
				body.RightBottomY = context.StringValue("RecognizeImage.Data.BodyList["+ i +"].RightBottomY");

				data_bodyList.Add(body);
			}
			data.BodyList = data_bodyList;

			List<RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_Face> data_faceList = new List<RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_Face>();
			for (int i = 0; i < context.Length("RecognizeImage.Data.FaceList.Length"); i++) {
				RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_Face face = new RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_Face();
				face.Feature = context.StringValue("RecognizeImage.Data.FaceList["+ i +"].Feature");
				face.FileName = context.StringValue("RecognizeImage.Data.FaceList["+ i +"].FileName");
				face.ImageBaseSixFour = context.StringValue("RecognizeImage.Data.FaceList["+ i +"].ImageBaseSixFour");
				face.LeftTopX = context.StringValue("RecognizeImage.Data.FaceList["+ i +"].LeftTopX");
				face.LeftTopY = context.StringValue("RecognizeImage.Data.FaceList["+ i +"].LeftTopY");
				face.LocalFeature = context.StringValue("RecognizeImage.Data.FaceList["+ i +"].LocalFeature");
				face.RespiratorColor = context.StringValue("RecognizeImage.Data.FaceList["+ i +"].RespiratorColor");
				face.RightBottomX = context.StringValue("RecognizeImage.Data.FaceList["+ i +"].RightBottomX");
				face.RightBottomY = context.StringValue("RecognizeImage.Data.FaceList["+ i +"].RightBottomY");

				data_faceList.Add(face);
			}
			data.FaceList = data_faceList;
			recognizeImageResponse.Data = data;
        
			return recognizeImageResponse;
        }
    }
}
