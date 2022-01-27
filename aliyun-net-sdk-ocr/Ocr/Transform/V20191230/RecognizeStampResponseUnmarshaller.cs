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
    public class RecognizeStampResponseUnmarshaller
    {
        public static RecognizeStampResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeStampResponse recognizeStampResponse = new RecognizeStampResponse();

			recognizeStampResponse.HttpResponse = _ctx.HttpResponse;
			recognizeStampResponse.RequestId = _ctx.StringValue("RecognizeStamp.RequestId");

			RecognizeStampResponse.RecognizeStamp_Data data = new RecognizeStampResponse.RecognizeStamp_Data();

			List<RecognizeStampResponse.RecognizeStamp_Data.RecognizeStamp_ResultsItem> data_results = new List<RecognizeStampResponse.RecognizeStamp_Data.RecognizeStamp_ResultsItem>();
			for (int i = 0; i < _ctx.Length("RecognizeStamp.Data.Results.Length"); i++) {
				RecognizeStampResponse.RecognizeStamp_Data.RecognizeStamp_ResultsItem resultsItem = new RecognizeStampResponse.RecognizeStamp_Data.RecognizeStamp_ResultsItem();

				RecognizeStampResponse.RecognizeStamp_Data.RecognizeStamp_ResultsItem.RecognizeStamp_Roi roi = new RecognizeStampResponse.RecognizeStamp_Data.RecognizeStamp_ResultsItem.RecognizeStamp_Roi();
				roi.Left = _ctx.IntegerValue("RecognizeStamp.Data.Results["+ i +"].Roi.Left");
				roi.Top = _ctx.IntegerValue("RecognizeStamp.Data.Results["+ i +"].Roi.Top");
				roi.Width = _ctx.IntegerValue("RecognizeStamp.Data.Results["+ i +"].Roi.Width");
				roi.Height = _ctx.IntegerValue("RecognizeStamp.Data.Results["+ i +"].Roi.Height");
				resultsItem.Roi = roi;

				RecognizeStampResponse.RecognizeStamp_Data.RecognizeStamp_ResultsItem.RecognizeStamp_Text text = new RecognizeStampResponse.RecognizeStamp_Data.RecognizeStamp_ResultsItem.RecognizeStamp_Text();
				text.Content = _ctx.StringValue("RecognizeStamp.Data.Results["+ i +"].Text.Content");
				text.Confidence = _ctx.FloatValue("RecognizeStamp.Data.Results["+ i +"].Text.Confidence");
				resultsItem.Text = text;

				List<RecognizeStampResponse.RecognizeStamp_Data.RecognizeStamp_ResultsItem.RecognizeStamp_GeneralTextItem> resultsItem_generalText = new List<RecognizeStampResponse.RecognizeStamp_Data.RecognizeStamp_ResultsItem.RecognizeStamp_GeneralTextItem>();
				for (int j = 0; j < _ctx.Length("RecognizeStamp.Data.Results["+ i +"].GeneralText.Length"); j++) {
					RecognizeStampResponse.RecognizeStamp_Data.RecognizeStamp_ResultsItem.RecognizeStamp_GeneralTextItem generalTextItem = new RecognizeStampResponse.RecognizeStamp_Data.RecognizeStamp_ResultsItem.RecognizeStamp_GeneralTextItem();
					generalTextItem.Content = _ctx.StringValue("RecognizeStamp.Data.Results["+ i +"].GeneralText["+ j +"].Content");
					generalTextItem.Confidence = _ctx.FloatValue("RecognizeStamp.Data.Results["+ i +"].GeneralText["+ j +"].Confidence");

					resultsItem_generalText.Add(generalTextItem);
				}
				resultsItem.GeneralText = resultsItem_generalText;

				data_results.Add(resultsItem);
			}
			data.Results = data_results;
			recognizeStampResponse.Data = data;
        
			return recognizeStampResponse;
        }
    }
}
