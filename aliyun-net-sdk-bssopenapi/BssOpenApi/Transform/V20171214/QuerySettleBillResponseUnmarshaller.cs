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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QuerySettleBillResponseUnmarshaller
    {
        public static QuerySettleBillResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySettleBillResponse querySettleBillResponse = new QuerySettleBillResponse();

			querySettleBillResponse.HttpResponse = context.HttpResponse;
			querySettleBillResponse.RequestId = context.StringValue("QuerySettleBill.RequestId");
			querySettleBillResponse.Success = context.BooleanValue("QuerySettleBill.Success");
			querySettleBillResponse.Code = context.StringValue("QuerySettleBill.Code");
			querySettleBillResponse.Message = context.StringValue("QuerySettleBill.Message");

			QuerySettleBillResponse.QuerySettleBill_Data data = new QuerySettleBillResponse.QuerySettleBill_Data();
			data.BillingCycle = context.StringValue("QuerySettleBill.Data.BillingCycle");
			data.AccountID = context.StringValue("QuerySettleBill.Data.AccountID");
			data.AccountName = context.StringValue("QuerySettleBill.Data.AccountName");
			data.NextToken = context.StringValue("QuerySettleBill.Data.NextToken");
			data.MaxResults = context.IntegerValue("QuerySettleBill.Data.MaxResults");
			data.TotalCount = context.IntegerValue("QuerySettleBill.Data.TotalCount");

			List<QuerySettleBillResponse.QuerySettleBill_Data.QuerySettleBill_Item> data_items = new List<QuerySettleBillResponse.QuerySettleBill_Data.QuerySettleBill_Item>();
			for (int i = 0; i < context.Length("QuerySettleBill.Data.Items.Length"); i++) {
				QuerySettleBillResponse.QuerySettleBill_Data.QuerySettleBill_Item item = new QuerySettleBillResponse.QuerySettleBill_Data.QuerySettleBill_Item();
				item.RecordID = context.StringValue("QuerySettleBill.Data.Items["+ i +"].RecordID");
				item.Item = context.StringValue("QuerySettleBill.Data.Items["+ i +"].Item");
				item.OwnerID = context.StringValue("QuerySettleBill.Data.Items["+ i +"].OwnerID");
				item.UsageStartTime = context.StringValue("QuerySettleBill.Data.Items["+ i +"].UsageStartTime");
				item.UsageEndTime = context.StringValue("QuerySettleBill.Data.Items["+ i +"].UsageEndTime");
				item.PaymentTime = context.StringValue("QuerySettleBill.Data.Items["+ i +"].PaymentTime");
				item.ProductCode = context.StringValue("QuerySettleBill.Data.Items["+ i +"].ProductCode");
				item.ProductType = context.StringValue("QuerySettleBill.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = context.StringValue("QuerySettleBill.Data.Items["+ i +"].SubscriptionType");
				item.ProductName = context.StringValue("QuerySettleBill.Data.Items["+ i +"].ProductName");
				item.ProductDetail = context.StringValue("QuerySettleBill.Data.Items["+ i +"].ProductDetail");
				item.PretaxGrossAmount = context.FloatValue("QuerySettleBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.DeductedByCoupons = context.FloatValue("QuerySettleBill.Data.Items["+ i +"].DeductedByCoupons");
				item.InvoiceDiscount = context.FloatValue("QuerySettleBill.Data.Items["+ i +"].InvoiceDiscount");
				item.PretaxAmount = context.FloatValue("QuerySettleBill.Data.Items["+ i +"].PretaxAmount");
				item.Currency = context.StringValue("QuerySettleBill.Data.Items["+ i +"].Currency");
				item.PretaxAmountLocal = context.FloatValue("QuerySettleBill.Data.Items["+ i +"].PretaxAmountLocal");
				item.Tax = context.FloatValue("QuerySettleBill.Data.Items["+ i +"].Tax");
				item.PaymentAmount = context.FloatValue("QuerySettleBill.Data.Items["+ i +"].PaymentAmount");
				item.DeductedByCashCoupons = context.FloatValue("QuerySettleBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = context.FloatValue("QuerySettleBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.OutstandingAmount = context.FloatValue("QuerySettleBill.Data.Items["+ i +"].OutstandingAmount");
				item.AfterTaxAmount = context.FloatValue("QuerySettleBill.Data.Items["+ i +"].AfterTaxAmount");
				item.Status = context.StringValue("QuerySettleBill.Data.Items["+ i +"].Status");
				item.PaymentCurrency = context.StringValue("QuerySettleBill.Data.Items["+ i +"].PaymentCurrency");
				item.PaymentTransactionID = context.StringValue("QuerySettleBill.Data.Items["+ i +"].PaymentTransactionID");
				item.RoundDownDiscount = context.StringValue("QuerySettleBill.Data.Items["+ i +"].RoundDownDiscount");
				item.SubOrderId = context.StringValue("QuerySettleBill.Data.Items["+ i +"].SubOrderId");
				item.PipCode = context.StringValue("QuerySettleBill.Data.Items["+ i +"].PipCode");
				item.CommodityCode = context.StringValue("QuerySettleBill.Data.Items["+ i +"].CommodityCode");

				data_items.Add(item);
			}
			data.Items = data_items;
			querySettleBillResponse.Data = data;
        
			return querySettleBillResponse;
        }
    }
}
