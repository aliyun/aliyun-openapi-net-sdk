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
    public class RecognizeCharacterResponseUnmarshaller
    {
        public static RecognizeCharacterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeCharacterResponse recognizeCharacterResponse = new RecognizeCharacterResponse();

			recognizeCharacterResponse.HttpResponse = _ctx.HttpResponse;
			recognizeCharacterResponse.RequestId = _ctx.StringValue("RecognizeCharacter.RequestId");

			RecognizeCharacterResponse.RecognizeCharacter_Data data = new RecognizeCharacterResponse.RecognizeCharacter_Data();

			List<RecognizeCharacterResponse.RecognizeCharacter_Data.RecognizeCharacter_Result> data_results = new List<RecognizeCharacterResponse.RecognizeCharacter_Data.RecognizeCharacter_Result>();
			for (int i = 0; i < _ctx.Length("RecognizeCharacter.Data.Results.Length"); i++) {
				RecognizeCharacterResponse.RecognizeCharacter_Data.RecognizeCharacter_Result result = new RecognizeCharacterResponse.RecognizeCharacter_Data.RecognizeCharacter_Result();
				result.Probability = _ctx.FloatValue("RecognizeCharacter.Data.Results["+ i +"].Probability");
				result.Text = _ctx.StringValue("RecognizeCharacter.Data.Results["+ i +"].Text");

				RecognizeCharacterResponse.RecognizeCharacter_Data.RecognizeCharacter_Result.RecognizeCharacter_TextRectangles textRectangles = new RecognizeCharacterResponse.RecognizeCharacter_Data.RecognizeCharacter_Result.RecognizeCharacter_TextRectangles();
				textRectangles.Angle = _ctx.IntegerValue("RecognizeCharacter.Data.Results["+ i +"].TextRectangles.Angle");
				textRectangles.Left = _ctx.IntegerValue("RecognizeCharacter.Data.Results["+ i +"].TextRectangles.Left");
				textRectangles.Top = _ctx.IntegerValue("RecognizeCharacter.Data.Results["+ i +"].TextRectangles.Top");
				textRectangles.Width = _ctx.IntegerValue("RecognizeCharacter.Data.Results["+ i +"].TextRectangles.Width");
				textRectangles.Height = _ctx.IntegerValue("RecognizeCharacter.Data.Results["+ i +"].TextRectangles.Height");
				result.TextRectangles = textRectangles;

				data_results.Add(result);
			}
			data.Results = data_results;
			recognizeCharacterResponse.Data = data;
        
			return recognizeCharacterResponse;
        }
    }
}
