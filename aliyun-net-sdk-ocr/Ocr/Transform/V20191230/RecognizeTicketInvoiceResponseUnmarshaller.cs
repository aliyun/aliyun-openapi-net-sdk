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
    public class RecognizeTicketInvoiceResponseUnmarshaller
    {
        public static RecognizeTicketInvoiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeTicketInvoiceResponse recognizeTicketInvoiceResponse = new RecognizeTicketInvoiceResponse();

			recognizeTicketInvoiceResponse.HttpResponse = _ctx.HttpResponse;
			recognizeTicketInvoiceResponse.RequestId = _ctx.StringValue("RecognizeTicketInvoice.RequestId");
			recognizeTicketInvoiceResponse.Code = _ctx.StringValue("RecognizeTicketInvoice.Code");
			recognizeTicketInvoiceResponse.Message = _ctx.StringValue("RecognizeTicketInvoice.Message");

			RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data data = new RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data();
			data.Count = _ctx.LongValue("RecognizeTicketInvoice.Data.Count");
			data.Height = _ctx.LongValue("RecognizeTicketInvoice.Data.Height");
			data.Width = _ctx.LongValue("RecognizeTicketInvoice.Data.Width");
			data.OrgHeight = _ctx.LongValue("RecognizeTicketInvoice.Data.OrgHeight");
			data.OrgWidth = _ctx.LongValue("RecognizeTicketInvoice.Data.OrgWidth");

			List<RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem> data_results = new List<RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem>();
			for (int i = 0; i < _ctx.Length("RecognizeTicketInvoice.Data.Results.Length"); i++) {
				RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem resultsItem = new RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem();
				resultsItem.Index = _ctx.LongValue("RecognizeTicketInvoice.Data.Results["+ i +"].Index");
				resultsItem.Type = _ctx.StringValue("RecognizeTicketInvoice.Data.Results["+ i +"].Type");

				RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_Content content = new RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_Content();
				content.InvoiceCode = _ctx.StringValue("RecognizeTicketInvoice.Data.Results["+ i +"].Content.InvoiceCode");
				content.InvoiceNumber = _ctx.StringValue("RecognizeTicketInvoice.Data.Results["+ i +"].Content.InvoiceNumber");
				content.InvoiceDate = _ctx.StringValue("RecognizeTicketInvoice.Data.Results["+ i +"].Content.InvoiceDate");
				content.AntiFakeCode = _ctx.StringValue("RecognizeTicketInvoice.Data.Results["+ i +"].Content.AntiFakeCode");
				content.PayeeName = _ctx.StringValue("RecognizeTicketInvoice.Data.Results["+ i +"].Content.PayeeName");
				content.PayeeRegisterNo = _ctx.StringValue("RecognizeTicketInvoice.Data.Results["+ i +"].Content.PayeeRegisterNo");
				content.PayerName = _ctx.StringValue("RecognizeTicketInvoice.Data.Results["+ i +"].Content.PayerName");
				content.PayerRegisterNo = _ctx.StringValue("RecognizeTicketInvoice.Data.Results["+ i +"].Content.PayerRegisterNo");
				content.SumAmount = _ctx.StringValue("RecognizeTicketInvoice.Data.Results["+ i +"].Content.SumAmount");
				resultsItem.Content = content;

				List<RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_KeyValueInfosItem> resultsItem_keyValueInfos = new List<RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_KeyValueInfosItem>();
				for (int j = 0; j < _ctx.Length("RecognizeTicketInvoice.Data.Results["+ i +"].KeyValueInfos.Length"); j++) {
					RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_KeyValueInfosItem keyValueInfosItem = new RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_KeyValueInfosItem();
					keyValueInfosItem.Key = _ctx.StringValue("RecognizeTicketInvoice.Data.Results["+ i +"].KeyValueInfos["+ j +"].Key");
					keyValueInfosItem._Value = _ctx.StringValue("RecognizeTicketInvoice.Data.Results["+ i +"].KeyValueInfos["+ j +"].Value");
					keyValueInfosItem.ValueScore = _ctx.FloatValue("RecognizeTicketInvoice.Data.Results["+ i +"].KeyValueInfos["+ j +"].ValueScore");

					List<RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_KeyValueInfosItem.RecognizeTicketInvoice_ValuePositionsItem> keyValueInfosItem_valuePositions = new List<RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_KeyValueInfosItem.RecognizeTicketInvoice_ValuePositionsItem>();
					for (int k = 0; k < _ctx.Length("RecognizeTicketInvoice.Data.Results["+ i +"].KeyValueInfos["+ j +"].ValuePositions.Length"); k++) {
						RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_KeyValueInfosItem.RecognizeTicketInvoice_ValuePositionsItem valuePositionsItem = new RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_KeyValueInfosItem.RecognizeTicketInvoice_ValuePositionsItem();
						valuePositionsItem.X = _ctx.LongValue("RecognizeTicketInvoice.Data.Results["+ i +"].KeyValueInfos["+ j +"].ValuePositions["+ k +"].X");
						valuePositionsItem.Y = _ctx.LongValue("RecognizeTicketInvoice.Data.Results["+ i +"].KeyValueInfos["+ j +"].ValuePositions["+ k +"].Y");

						keyValueInfosItem_valuePositions.Add(valuePositionsItem);
					}
					keyValueInfosItem.ValuePositions = keyValueInfosItem_valuePositions;

					resultsItem_keyValueInfos.Add(keyValueInfosItem);
				}
				resultsItem.KeyValueInfos = resultsItem_keyValueInfos;

				List<RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_SliceRectangleItem> resultsItem_sliceRectangle = new List<RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_SliceRectangleItem>();
				for (int j = 0; j < _ctx.Length("RecognizeTicketInvoice.Data.Results["+ i +"].SliceRectangle.Length"); j++) {
					RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_SliceRectangleItem sliceRectangleItem = new RecognizeTicketInvoiceResponse.RecognizeTicketInvoice_Data.RecognizeTicketInvoice_ResultsItem.RecognizeTicketInvoice_SliceRectangleItem();
					sliceRectangleItem.X = _ctx.LongValue("RecognizeTicketInvoice.Data.Results["+ i +"].SliceRectangle["+ j +"].X");
					sliceRectangleItem.Y = _ctx.LongValue("RecognizeTicketInvoice.Data.Results["+ i +"].SliceRectangle["+ j +"].Y");

					resultsItem_sliceRectangle.Add(sliceRectangleItem);
				}
				resultsItem.SliceRectangle = resultsItem_sliceRectangle;

				data_results.Add(resultsItem);
			}
			data.Results = data_results;
			recognizeTicketInvoiceResponse.Data = data;
        
			return recognizeTicketInvoiceResponse;
        }
    }
}
