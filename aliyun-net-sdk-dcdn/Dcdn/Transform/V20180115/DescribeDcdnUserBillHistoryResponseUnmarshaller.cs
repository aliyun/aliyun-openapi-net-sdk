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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnUserBillHistoryResponseUnmarshaller
    {
        public static DescribeDcdnUserBillHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnUserBillHistoryResponse describeDcdnUserBillHistoryResponse = new DescribeDcdnUserBillHistoryResponse();

			describeDcdnUserBillHistoryResponse.HttpResponse = context.HttpResponse;
			describeDcdnUserBillHistoryResponse.RequestId = context.StringValue("DescribeDcdnUserBillHistory.RequestId");

			List<DescribeDcdnUserBillHistoryResponse.DescribeDcdnUserBillHistory_BillHistoryDataItem> describeDcdnUserBillHistoryResponse_billHistoryData = new List<DescribeDcdnUserBillHistoryResponse.DescribeDcdnUserBillHistory_BillHistoryDataItem>();
			for (int i = 0; i < context.Length("DescribeDcdnUserBillHistory.BillHistoryData.Length"); i++) {
				DescribeDcdnUserBillHistoryResponse.DescribeDcdnUserBillHistory_BillHistoryDataItem billHistoryDataItem = new DescribeDcdnUserBillHistoryResponse.DescribeDcdnUserBillHistory_BillHistoryDataItem();
				billHistoryDataItem.Dimension = context.StringValue("DescribeDcdnUserBillHistory.BillHistoryData["+ i +"].Dimension");
				billHistoryDataItem.BillType = context.StringValue("DescribeDcdnUserBillHistory.BillHistoryData["+ i +"].BillType");
				billHistoryDataItem.BillTime = context.StringValue("DescribeDcdnUserBillHistory.BillHistoryData["+ i +"].BillTime");

				List<DescribeDcdnUserBillHistoryResponse.DescribeDcdnUserBillHistory_BillHistoryDataItem.DescribeDcdnUserBillHistory_BillingDataItem> billHistoryDataItem_billingData = new List<DescribeDcdnUserBillHistoryResponse.DescribeDcdnUserBillHistory_BillHistoryDataItem.DescribeDcdnUserBillHistory_BillingDataItem>();
				for (int j = 0; j < context.Length("DescribeDcdnUserBillHistory.BillHistoryData["+ i +"].BillingData.Length"); j++) {
					DescribeDcdnUserBillHistoryResponse.DescribeDcdnUserBillHistory_BillHistoryDataItem.DescribeDcdnUserBillHistory_BillingDataItem billingDataItem = new DescribeDcdnUserBillHistoryResponse.DescribeDcdnUserBillHistory_BillHistoryDataItem.DescribeDcdnUserBillHistory_BillingDataItem();
					billingDataItem.ChargeType = context.StringValue("DescribeDcdnUserBillHistory.BillHistoryData["+ i +"].BillingData["+ j +"].ChargeType");
					billingDataItem.CdnRegion = context.StringValue("DescribeDcdnUserBillHistory.BillHistoryData["+ i +"].BillingData["+ j +"].CdnRegion");
					billingDataItem.Bandwidth = context.FloatValue("DescribeDcdnUserBillHistory.BillHistoryData["+ i +"].BillingData["+ j +"].Bandwidth");
					billingDataItem.Flow = context.FloatValue("DescribeDcdnUserBillHistory.BillHistoryData["+ i +"].BillingData["+ j +"].Flow");
					billingDataItem.Count = context.FloatValue("DescribeDcdnUserBillHistory.BillHistoryData["+ i +"].BillingData["+ j +"].Count");

					billHistoryDataItem_billingData.Add(billingDataItem);
				}
				billHistoryDataItem.BillingData = billHistoryDataItem_billingData;

				describeDcdnUserBillHistoryResponse_billHistoryData.Add(billHistoryDataItem);
			}
			describeDcdnUserBillHistoryResponse.BillHistoryData = describeDcdnUserBillHistoryResponse_billHistoryData;
        
			return describeDcdnUserBillHistoryResponse;
        }
    }
}
