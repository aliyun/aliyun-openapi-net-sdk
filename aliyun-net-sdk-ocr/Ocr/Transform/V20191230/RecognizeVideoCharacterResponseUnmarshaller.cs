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
    public class RecognizeVideoCharacterResponseUnmarshaller
    {
        public static RecognizeVideoCharacterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeVideoCharacterResponse recognizeVideoCharacterResponse = new RecognizeVideoCharacterResponse();

			recognizeVideoCharacterResponse.HttpResponse = _ctx.HttpResponse;
			recognizeVideoCharacterResponse.RequestId = _ctx.StringValue("RecognizeVideoCharacter.RequestId");

			RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data data = new RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data();
			data.Width = _ctx.LongValue("RecognizeVideoCharacter.Data.Width");
			data.Height = _ctx.LongValue("RecognizeVideoCharacter.Data.Height");

			List<RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data.RecognizeVideoCharacter_Frame> data_frames = new List<RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data.RecognizeVideoCharacter_Frame>();
			for (int i = 0; i < _ctx.Length("RecognizeVideoCharacter.Data.Frames.Length"); i++) {
				RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data.RecognizeVideoCharacter_Frame frame = new RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data.RecognizeVideoCharacter_Frame();
				frame.Timestamp = _ctx.LongValue("RecognizeVideoCharacter.Data.Frames["+ i +"].Timestamp");

				List<RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data.RecognizeVideoCharacter_Frame.RecognizeVideoCharacter_Element> frame_elements = new List<RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data.RecognizeVideoCharacter_Frame.RecognizeVideoCharacter_Element>();
				for (int j = 0; j < _ctx.Length("RecognizeVideoCharacter.Data.Frames["+ i +"].Elements.Length"); j++) {
					RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data.RecognizeVideoCharacter_Frame.RecognizeVideoCharacter_Element element = new RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data.RecognizeVideoCharacter_Frame.RecognizeVideoCharacter_Element();
					element.Score = _ctx.FloatValue("RecognizeVideoCharacter.Data.Frames["+ i +"].Elements["+ j +"].Score");
					element.Text = _ctx.StringValue("RecognizeVideoCharacter.Data.Frames["+ i +"].Elements["+ j +"].Text");

					List<RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data.RecognizeVideoCharacter_Frame.RecognizeVideoCharacter_Element.RecognizeVideoCharacter_TextRectangle> element_textRectangles = new List<RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data.RecognizeVideoCharacter_Frame.RecognizeVideoCharacter_Element.RecognizeVideoCharacter_TextRectangle>();
					for (int k = 0; k < _ctx.Length("RecognizeVideoCharacter.Data.Frames["+ i +"].Elements["+ j +"].TextRectangles.Length"); k++) {
						RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data.RecognizeVideoCharacter_Frame.RecognizeVideoCharacter_Element.RecognizeVideoCharacter_TextRectangle textRectangle = new RecognizeVideoCharacterResponse.RecognizeVideoCharacter_Data.RecognizeVideoCharacter_Frame.RecognizeVideoCharacter_Element.RecognizeVideoCharacter_TextRectangle();
						textRectangle.Angle = _ctx.LongValue("RecognizeVideoCharacter.Data.Frames["+ i +"].Elements["+ j +"].TextRectangles["+ k +"].Angle");
						textRectangle.Left = _ctx.LongValue("RecognizeVideoCharacter.Data.Frames["+ i +"].Elements["+ j +"].TextRectangles["+ k +"].Left");
						textRectangle.Top = _ctx.LongValue("RecognizeVideoCharacter.Data.Frames["+ i +"].Elements["+ j +"].TextRectangles["+ k +"].Top");
						textRectangle.Width = _ctx.LongValue("RecognizeVideoCharacter.Data.Frames["+ i +"].Elements["+ j +"].TextRectangles["+ k +"].Width");
						textRectangle.Height = _ctx.LongValue("RecognizeVideoCharacter.Data.Frames["+ i +"].Elements["+ j +"].TextRectangles["+ k +"].Height");

						element_textRectangles.Add(textRectangle);
					}
					element.TextRectangles = element_textRectangles;

					frame_elements.Add(element);
				}
				frame.Elements = frame_elements;

				data_frames.Add(frame);
			}
			data.Frames = data_frames;
			recognizeVideoCharacterResponse.Data = data;
        
			return recognizeVideoCharacterResponse;
        }
    }
}
