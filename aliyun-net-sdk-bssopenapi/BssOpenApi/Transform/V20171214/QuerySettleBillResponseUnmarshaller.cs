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
			querySettleBillResponse.RequestId = _ctx.StringValue("QuerySettleBill.RequestId");
			querySettleBillResponse.Success = _ctx.BooleanValue("QuerySettleBill.Success");
			querySettleBillResponse.Code = _ctx.StringValue("QuerySettleBill.Code");
			querySettleBillResponse.Message = _ctx.StringValue("QuerySettleBill.Message");

			QuerySettleBillResponse.QuerySettleBill_Data data = new QuerySettleBillResponse.QuerySettleBill_Data();
			data.BillingCycle = _ctx.StringValue("QuerySettleBill.Data.BillingCycle");
			data.AccountID = _ctx.StringValue("QuerySettleBill.Data.AccountID");
			data.AccountName = _ctx.StringValue("QuerySettleBill.Data.AccountName");
			data.NextToken = _ctx.StringValue("QuerySettleBill.Data.NextToken");
			data.MaxResults = _ctx.IntegerValue("QuerySettleBill.Data.MaxResults");
			data.TotalCount = _ctx.IntegerValue("QuerySettleBill.Data.TotalCount");

			List<QuerySettleBillResponse.QuerySettleBill_Data.QuerySettleBill_Item> data_items = new List<QuerySettleBillResponse.QuerySettleBill_Data.QuerySettleBill_Item>();
			for (int i = 0; i < _ctx.Length("QuerySettleBill.Data.Items.Length"); i++) {
				QuerySettleBillResponse.QuerySettleBill_Data.QuerySettleBill_Item item = new QuerySettleBillResponse.QuerySettleBill_Data.QuerySettleBill_Item();
				item.RecordID = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].RecordID");
				item.Item = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].Item");
				item.OwnerID = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].OwnerID");
				item.UsageStartTime = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].UsageStartTime");
				item.UsageEndTime = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].UsageEndTime");
				item.PaymentTime = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].PaymentTime");
				item.ProductCode = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].ProductCode");
				item.ProductType = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].SubscriptionType");
				item.ProductName = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].ProductName");
				item.ProductDetail = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].ProductDetail");
				item.PretaxGrossAmount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.DeductedByCoupons = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].DeductedByCoupons");
				item.InvoiceDiscount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].InvoiceDiscount");
				item.PretaxAmount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].PretaxAmount");
				item.Currency = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].Currency");
				item.PretaxAmountLocal = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].PretaxAmountLocal");
				item.Tax = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].Tax");
				item.PaymentAmount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].PaymentAmount");
				item.DeductedByCashCoupons = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.OutstandingAmount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].OutstandingAmount");
				item.AfterTaxAmount = _ctx.FloatValue("QuerySettleBill.Data.Items["+ i +"].AfterTaxAmount");
				item.Status = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].Status");
				item.PaymentCurrency = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].PaymentCurrency");
				item.PaymentTransactionID = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].PaymentTransactionID");
				item.RoundDownDiscount = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].RoundDownDiscount");
				item.SubOrderId = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].SubOrderId");
				item.PipCode = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].PipCode");
				item.CommodityCode = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].CommodityCode");
				item.BillAccountID = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].BillAccountID");
				item.BillAccountName = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].BillAccountName");
				item.BizType = _ctx.StringValue("QuerySettleBill.Data.Items["+ i +"].BizType");

				data_items.Add(item);
			}
			data.Items = data_items;
			querySettleBillResponse.Data = data;
        
			return querySettleBillResponse;
        }
    }
}
