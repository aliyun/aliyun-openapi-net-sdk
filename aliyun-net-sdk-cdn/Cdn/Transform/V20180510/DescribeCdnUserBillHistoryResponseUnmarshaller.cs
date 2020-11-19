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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnUserBillHistoryResponseUnmarshaller
    {
        public static DescribeCdnUserBillHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnUserBillHistoryResponse describeCdnUserBillHistoryResponse = new DescribeCdnUserBillHistoryResponse();

			describeCdnUserBillHistoryResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnUserBillHistoryResponse.RequestId = _ctx.StringValue("DescribeCdnUserBillHistory.RequestId");

			List<DescribeCdnUserBillHistoryResponse.DescribeCdnUserBillHistory_BillHistoryDataItem> describeCdnUserBillHistoryResponse_billHistoryData = new List<DescribeCdnUserBillHistoryResponse.DescribeCdnUserBillHistory_BillHistoryDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeCdnUserBillHistory.BillHistoryData.Length"); i++) {
				DescribeCdnUserBillHistoryResponse.DescribeCdnUserBillHistory_BillHistoryDataItem billHistoryDataItem = new DescribeCdnUserBillHistoryResponse.DescribeCdnUserBillHistory_BillHistoryDataItem();
				billHistoryDataItem.Dimension = _ctx.StringValue("DescribeCdnUserBillHistory.BillHistoryData["+ i +"].Dimension");
				billHistoryDataItem.BillType = _ctx.StringValue("DescribeCdnUserBillHistory.BillHistoryData["+ i +"].BillType");
				billHistoryDataItem.BillTime = _ctx.StringValue("DescribeCdnUserBillHistory.BillHistoryData["+ i +"].BillTime");

				List<DescribeCdnUserBillHistoryResponse.DescribeCdnUserBillHistory_BillHistoryDataItem.DescribeCdnUserBillHistory_BillingDataItem> billHistoryDataItem_billingData = new List<DescribeCdnUserBillHistoryResponse.DescribeCdnUserBillHistory_BillHistoryDataItem.DescribeCdnUserBillHistory_BillingDataItem>();
				for (int j = 0; j < _ctx.Length("DescribeCdnUserBillHistory.BillHistoryData["+ i +"].BillingData.Length"); j++) {
					DescribeCdnUserBillHistoryResponse.DescribeCdnUserBillHistory_BillHistoryDataItem.DescribeCdnUserBillHistory_BillingDataItem billingDataItem = new DescribeCdnUserBillHistoryResponse.DescribeCdnUserBillHistory_BillHistoryDataItem.DescribeCdnUserBillHistory_BillingDataItem();
					billingDataItem.ChargeType = _ctx.StringValue("DescribeCdnUserBillHistory.BillHistoryData["+ i +"].BillingData["+ j +"].ChargeType");
					billingDataItem.CdnRegion = _ctx.StringValue("DescribeCdnUserBillHistory.BillHistoryData["+ i +"].BillingData["+ j +"].CdnRegion");
					billingDataItem.Bandwidth = _ctx.FloatValue("DescribeCdnUserBillHistory.BillHistoryData["+ i +"].BillingData["+ j +"].Bandwidth");
					billingDataItem.Flow = _ctx.FloatValue("DescribeCdnUserBillHistory.BillHistoryData["+ i +"].BillingData["+ j +"].Flow");
					billingDataItem.Count = _ctx.FloatValue("DescribeCdnUserBillHistory.BillHistoryData["+ i +"].BillingData["+ j +"].Count");

					billHistoryDataItem_billingData.Add(billingDataItem);
				}
				billHistoryDataItem.BillingData = billHistoryDataItem_billingData;

				describeCdnUserBillHistoryResponse_billHistoryData.Add(billHistoryDataItem);
			}
			describeCdnUserBillHistoryResponse.BillHistoryData = describeCdnUserBillHistoryResponse_billHistoryData;
        
			return describeCdnUserBillHistoryResponse;
        }
    }
}
