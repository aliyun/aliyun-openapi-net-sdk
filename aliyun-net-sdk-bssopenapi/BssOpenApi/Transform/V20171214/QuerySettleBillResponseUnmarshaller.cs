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
        public static QuerySettleBillResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySettleBillResponse querySettleBillResponse = new QuerySettleBillResponse();

			querySettleBillResponse.HttpResponse = _ctx.HttpResponse;
			querySettleBillResponse.Code = _ctx.StringValue("QuerySettleBill.Code");
			querySettleBillResponse.Message = _ctx.StringValue("QuerySettleBill.Message");
			querySettleBillResponse.RequestId = _ctx.StringValue("QuerySettleBill.RequestId");
			querySettleBillResponse.Success = _ctx.BooleanValue("QuerySettleBill.Success");

			QuerySettleBillResponse.QuerySettleBill_Data data = new QuerySettleBillResponse.QuerySettleBill_Data();
			data.NextToken = _ctx.StringValue("QuerySettleBill.Data.NextToken");
			data.BillingCycle = _ctx.StringValue("QuerySettleBill.Data.BillingCycle");
			data.MaxResults = _ctx.IntegerValue("QuerySettleBill.Data.MaxResults");
			data.AccountID = _ctx.StringValue("QuerySettleBill.Data.AccountID");
			data.TotalCount = _ctx.IntegerValue("QuerySettleBill.Data.TotalCount");
			data.AccountName = _ctx.StringValue("QuerySettleBill.Data.AccountName");

			List<QuerySettleBillResponse.QuerySettleBill_Data.QuerySettleBill_Item> data_items = new List<QuerySettleBillResponse.QuerySettleBill_Data.QuerySettleBill_Item>();
			for (int i = 0; i < _ctx.Length("QuerySettleBill.Data.Items.Length"); i++) {
				QuerySettleBillResponse.QuerySettleBill_Data.QuerySettleBill_Item item = new QuerySettleBillResponse.QuerySettleBill_Data.QuerySettleBill_Item();
				item.Status = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].Status");
				item.RoundDownDiscount = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].RoundDownDiscount");
				item.Item = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].Item");
				item.Currency = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].Currency");
				item.BillAccountName = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].BillAccountName");
				item.DeductedByCashCoupons = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.SubscriptionType = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].SubscriptionType");
				item.UsageStartTime = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].UsageStartTime");
				item.BizType = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].BizType");
				item.UsageEndTime = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].UsageEndTime");
				item.DeductedByCoupons = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].DeductedByCoupons");
				item.SubOrderId = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].SubOrderId");
				item.AfterTaxAmount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].AfterTaxAmount");
				item.OutstandingAmount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].OutstandingAmount");
				item.PaymentTime = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].PaymentTime");
				item.Tax = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].Tax");
				item.PretaxAmountLocal = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].PretaxAmountLocal");
				item.PipCode = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].PipCode");
				item.PaymentTransactionID = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].PaymentTransactionID");
				item.PretaxAmount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].PretaxAmount");
				item.CommodityCode = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].CommodityCode");
				item.ProductName = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].ProductName");
				item.RecordID = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].RecordID");
				item.AdjustAmount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].AdjustAmount");
				item.ProductDetail = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].ProductDetail");
				item.PaymentCurrency = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].PaymentCurrency");
				item.OwnerID = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].OwnerID");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.BillAccountID = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].BillAccountID");
				item.PaymentAmount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].PaymentAmount");
				item.InvoiceDiscount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].InvoiceDiscount");
				item.ProductType = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].ProductType");
				item.PretaxGrossAmount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.CashAmount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].CashAmount");
				item.ProductCode = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].ProductCode");

				data_items.Add(item);
			}
			data.Items = data_items;
			querySettleBillResponse.Data = data;
        
			return querySettleBillResponse;
        }
    }
}
