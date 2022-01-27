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
    public class RecognizePoiNameResponseUnmarshaller
    {
        public static RecognizePoiNameResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizePoiNameResponse recognizePoiNameResponse = new RecognizePoiNameResponse();

			recognizePoiNameResponse.HttpResponse = _ctx.HttpResponse;
			recognizePoiNameResponse.RequestId = _ctx.StringValue("RecognizePoiName.RequestId");

			RecognizePoiNameResponse.RecognizePoiName_Data data = new RecognizePoiNameResponse.RecognizePoiName_Data();

			RecognizePoiNameResponse.RecognizePoiName_Data.RecognizePoiName_Summary summary = new RecognizePoiNameResponse.RecognizePoiName_Data.RecognizePoiName_Summary();
			summary.Brand = _ctx.StringValue("RecognizePoiName.Data.Summary.Brand");
			summary.Score = _ctx.FloatValue("RecognizePoiName.Data.Summary.Score");
			data.Summary = summary;

			List<RecognizePoiNameResponse.RecognizePoiName_Data.RecognizePoiName_SignboardsItem> data_signboards = new List<RecognizePoiNameResponse.RecognizePoiName_Data.RecognizePoiName_SignboardsItem>();
			for (int i = 0; i < _ctx.Length("RecognizePoiName.Data.Signboards.Length"); i++) {
				RecognizePoiNameResponse.RecognizePoiName_Data.RecognizePoiName_SignboardsItem signboardsItem = new RecognizePoiNameResponse.RecognizePoiName_Data.RecognizePoiName_SignboardsItem();

				List<RecognizePoiNameResponse.RecognizePoiName_Data.RecognizePoiName_SignboardsItem.RecognizePoiName_TextsItem> signboardsItem_texts = new List<RecognizePoiNameResponse.RecognizePoiName_Data.RecognizePoiName_SignboardsItem.RecognizePoiName_TextsItem>();
				for (int j = 0; j < _ctx.Length("RecognizePoiName.Data.Signboards["+ i +"].Texts.Length"); j++) {
					RecognizePoiNameResponse.RecognizePoiName_Data.RecognizePoiName_SignboardsItem.RecognizePoiName_TextsItem textsItem = new RecognizePoiNameResponse.RecognizePoiName_Data.RecognizePoiName_SignboardsItem.RecognizePoiName_TextsItem();
					textsItem.Label = _ctx.StringValue("RecognizePoiName.Data.Signboards["+ i +"].Texts["+ j +"].Label");
					textsItem.Score = _ctx.FloatValue("RecognizePoiName.Data.Signboards["+ i +"].Texts["+ j +"].Score");
					textsItem.Tag = _ctx.StringValue("RecognizePoiName.Data.Signboards["+ i +"].Texts["+ j +"].Tag");
					textsItem.Type = _ctx.StringValue("RecognizePoiName.Data.Signboards["+ i +"].Texts["+ j +"].Type");

					List<string> textsItem_points = new List<string>();
					for (int k = 0; k < _ctx.Length("RecognizePoiName.Data.Signboards["+ i +"].Texts["+ j +"].Points.Length"); k++) {
						textsItem_points.Add(_ctx.StringValue("RecognizePoiName.Data.Signboards["+ i +"].Texts["+ j +"].Points["+ k +"]"));
					}
					textsItem.Points = textsItem_points;

					signboardsItem_texts.Add(textsItem);
				}
				signboardsItem.Texts = signboardsItem_texts;

				data_signboards.Add(signboardsItem);
			}
			data.Signboards = data_signboards;
			recognizePoiNameResponse.Data = data;
        
			return recognizePoiNameResponse;
        }
    }
}
