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
    public class RecognizeQuotaInvoiceResponseUnmarshaller
    {
        public static RecognizeQuotaInvoiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeQuotaInvoiceResponse recognizeQuotaInvoiceResponse = new RecognizeQuotaInvoiceResponse();

			recognizeQuotaInvoiceResponse.HttpResponse = _ctx.HttpResponse;
			recognizeQuotaInvoiceResponse.RequestId = _ctx.StringValue("RecognizeQuotaInvoice.RequestId");
			recognizeQuotaInvoiceResponse.Code = _ctx.StringValue("RecognizeQuotaInvoice.Code");
			recognizeQuotaInvoiceResponse.Message = _ctx.StringValue("RecognizeQuotaInvoice.Message");

			RecognizeQuotaInvoiceResponse.RecognizeQuotaInvoice_Data data = new RecognizeQuotaInvoiceResponse.RecognizeQuotaInvoice_Data();
			data.Angle = _ctx.LongValue("RecognizeQuotaInvoice.Data.Angle");
			data.Height = _ctx.LongValue("RecognizeQuotaInvoice.Data.Height");
			data.Width = _ctx.LongValue("RecognizeQuotaInvoice.Data.Width");
			data.OrgHeight = _ctx.LongValue("RecognizeQuotaInvoice.Data.OrgHeight");
			data.OrgWidth = _ctx.LongValue("RecognizeQuotaInvoice.Data.OrgWidth");

			RecognizeQuotaInvoiceResponse.RecognizeQuotaInvoice_Data.RecognizeQuotaInvoice_Content content = new RecognizeQuotaInvoiceResponse.RecognizeQuotaInvoice_Data.RecognizeQuotaInvoice_Content();
			content.SumAmount = _ctx.StringValue("RecognizeQuotaInvoice.Data.Content.SumAmount");
			content.InvoiceCode = _ctx.StringValue("RecognizeQuotaInvoice.Data.Content.InvoiceCode");
			content.InvoiceNo = _ctx.StringValue("RecognizeQuotaInvoice.Data.Content.InvoiceNo");
			content.InvoiceAmount = _ctx.StringValue("RecognizeQuotaInvoice.Data.Content.InvoiceAmount");
			content.InvoiceDetails = _ctx.StringValue("RecognizeQuotaInvoice.Data.Content.InvoiceDetails");
			data.Content = content;

			List<RecognizeQuotaInvoiceResponse.RecognizeQuotaInvoice_Data.RecognizeQuotaInvoice_KeyValueInfosItem> data_keyValueInfos = new List<RecognizeQuotaInvoiceResponse.RecognizeQuotaInvoice_Data.RecognizeQuotaInvoice_KeyValueInfosItem>();
			for (int i = 0; i < _ctx.Length("RecognizeQuotaInvoice.Data.KeyValueInfos.Length"); i++) {
				RecognizeQuotaInvoiceResponse.RecognizeQuotaInvoice_Data.RecognizeQuotaInvoice_KeyValueInfosItem keyValueInfosItem = new RecognizeQuotaInvoiceResponse.RecognizeQuotaInvoice_Data.RecognizeQuotaInvoice_KeyValueInfosItem();
				keyValueInfosItem.Key = _ctx.StringValue("RecognizeQuotaInvoice.Data.KeyValueInfos["+ i +"].Key");
				keyValueInfosItem._Value = _ctx.StringValue("RecognizeQuotaInvoice.Data.KeyValueInfos["+ i +"].Value");
				keyValueInfosItem.ValueScore = _ctx.FloatValue("RecognizeQuotaInvoice.Data.KeyValueInfos["+ i +"].ValueScore");

				List<RecognizeQuotaInvoiceResponse.RecognizeQuotaInvoice_Data.RecognizeQuotaInvoice_KeyValueInfosItem.RecognizeQuotaInvoice_ValuePositionsItem> keyValueInfosItem_valuePositions = new List<RecognizeQuotaInvoiceResponse.RecognizeQuotaInvoice_Data.RecognizeQuotaInvoice_KeyValueInfosItem.RecognizeQuotaInvoice_ValuePositionsItem>();
				for (int j = 0; j < _ctx.Length("RecognizeQuotaInvoice.Data.KeyValueInfos["+ i +"].ValuePositions.Length"); j++) {
					RecognizeQuotaInvoiceResponse.RecognizeQuotaInvoice_Data.RecognizeQuotaInvoice_KeyValueInfosItem.RecognizeQuotaInvoice_ValuePositionsItem valuePositionsItem = new RecognizeQuotaInvoiceResponse.RecognizeQuotaInvoice_Data.RecognizeQuotaInvoice_KeyValueInfosItem.RecognizeQuotaInvoice_ValuePositionsItem();
					valuePositionsItem.X = _ctx.LongValue("RecognizeQuotaInvoice.Data.KeyValueInfos["+ i +"].ValuePositions["+ j +"].X");
					valuePositionsItem.Y = _ctx.LongValue("RecognizeQuotaInvoice.Data.KeyValueInfos["+ i +"].ValuePositions["+ j +"].Y");

					keyValueInfosItem_valuePositions.Add(valuePositionsItem);
				}
				keyValueInfosItem.ValuePositions = keyValueInfosItem_valuePositions;

				data_keyValueInfos.Add(keyValueInfosItem);
			}
			data.KeyValueInfos = data_keyValueInfos;
			recognizeQuotaInvoiceResponse.Data = data;
        
			return recognizeQuotaInvoiceResponse;
        }
    }
}
