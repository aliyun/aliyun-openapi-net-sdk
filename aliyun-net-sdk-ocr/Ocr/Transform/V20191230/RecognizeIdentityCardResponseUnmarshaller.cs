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
using Aliyun.Acs.ocr.Model.V20191230;

namespace Aliyun.Acs.ocr.Transform.V20191230
{
    public class RecognizeIdentityCardResponseUnmarshaller
    {
        public static RecognizeIdentityCardResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeIdentityCardResponse recognizeIdentityCardResponse = new RecognizeIdentityCardResponse();

			recognizeIdentityCardResponse.HttpResponse = _ctx.HttpResponse;
			recognizeIdentityCardResponse.RequestId = _ctx.StringValue("RecognizeIdentityCard.RequestId");

			RecognizeIdentityCardResponse.RecognizeIdentityCard_Data data = new RecognizeIdentityCardResponse.RecognizeIdentityCard_Data();

			RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult frontResult = new RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult();
			frontResult.Address = _ctx.StringValue("RecognizeIdentityCard.Data.FrontResult.Address");
			frontResult.Name = _ctx.StringValue("RecognizeIdentityCard.Data.FrontResult.Name");
			frontResult.Nationality = _ctx.StringValue("RecognizeIdentityCard.Data.FrontResult.Nationality");
			frontResult.IDNumber = _ctx.StringValue("RecognizeIdentityCard.Data.FrontResult.IDNumber");
			frontResult.Gender = _ctx.StringValue("RecognizeIdentityCard.Data.FrontResult.Gender");
			frontResult.BirthDate = _ctx.StringValue("RecognizeIdentityCard.Data.FrontResult.BirthDate");

			RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_FaceRectangle faceRectangle = new RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_FaceRectangle();
			faceRectangle.Angle = _ctx.FloatValue("RecognizeIdentityCard.Data.FrontResult.FaceRectangle.Angle");

			RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_FaceRectangle.RecognizeIdentityCard_Center center = new RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_FaceRectangle.RecognizeIdentityCard_Center();
			center.X = _ctx.FloatValue("RecognizeIdentityCard.Data.FrontResult.FaceRectangle.Center.X");
			center.Y = _ctx.FloatValue("RecognizeIdentityCard.Data.FrontResult.FaceRectangle.Center.Y");
			faceRectangle.Center = center;

			RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_FaceRectangle.RecognizeIdentityCard_Size size = new RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_FaceRectangle.RecognizeIdentityCard_Size();
			size.Height = _ctx.FloatValue("RecognizeIdentityCard.Data.FrontResult.FaceRectangle.Size.Height");
			size.Width = _ctx.FloatValue("RecognizeIdentityCard.Data.FrontResult.FaceRectangle.Size.Width");
			faceRectangle.Size = size;
			frontResult.FaceRectangle = faceRectangle;

			List<RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_CardArea> frontResult_cardAreas = new List<RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_CardArea>();
			for (int i = 0; i < _ctx.Length("RecognizeIdentityCard.Data.FrontResult.CardAreas.Length"); i++) {
				RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_CardArea cardArea = new RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_CardArea();
				cardArea.X = _ctx.FloatValue("RecognizeIdentityCard.Data.FrontResult.CardAreas["+ i +"].X");
				cardArea.Y = _ctx.FloatValue("RecognizeIdentityCard.Data.FrontResult.CardAreas["+ i +"].Y");

				frontResult_cardAreas.Add(cardArea);
			}
			frontResult.CardAreas = frontResult_cardAreas;

			List<RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_FaceRectVertice> frontResult_faceRectVertices = new List<RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_FaceRectVertice>();
			for (int i = 0; i < _ctx.Length("RecognizeIdentityCard.Data.FrontResult.FaceRectVertices.Length"); i++) {
				RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_FaceRectVertice faceRectVertice = new RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_FrontResult.RecognizeIdentityCard_FaceRectVertice();
				faceRectVertice.X = _ctx.FloatValue("RecognizeIdentityCard.Data.FrontResult.FaceRectVertices["+ i +"].X");
				faceRectVertice.Y = _ctx.FloatValue("RecognizeIdentityCard.Data.FrontResult.FaceRectVertices["+ i +"].Y");

				frontResult_faceRectVertices.Add(faceRectVertice);
			}
			frontResult.FaceRectVertices = frontResult_faceRectVertices;
			data.FrontResult = frontResult;

			RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_BackResult backResult = new RecognizeIdentityCardResponse.RecognizeIdentityCard_Data.RecognizeIdentityCard_BackResult();
			backResult.StartDate = _ctx.StringValue("RecognizeIdentityCard.Data.BackResult.StartDate");
			backResult.EndDate = _ctx.StringValue("RecognizeIdentityCard.Data.BackResult.EndDate");
			backResult.Issue = _ctx.StringValue("RecognizeIdentityCard.Data.BackResult.Issue");
			data.BackResult = backResult;
			recognizeIdentityCardResponse.Data = data;
        
			return recognizeIdentityCardResponse;
        }
    }
}
