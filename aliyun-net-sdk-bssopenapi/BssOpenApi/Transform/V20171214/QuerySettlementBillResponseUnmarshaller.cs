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
    public class QuerySettlementBillResponseUnmarshaller
    {
        public static QuerySettlementBillResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySettlementBillResponse querySettlementBillResponse = new QuerySettlementBillResponse();

			querySettlementBillResponse.HttpResponse = _ctx.HttpResponse;
			querySettlementBillResponse.Code = _ctx.StringValue("QuerySettlementBill.Code");
			querySettlementBillResponse.Message = _ctx.StringValue("QuerySettlementBill.Message");
			querySettlementBillResponse.RequestId = _ctx.StringValue("QuerySettlementBill.RequestId");
			querySettlementBillResponse.Success = _ctx.BooleanValue("QuerySettlementBill.Success");

			QuerySettlementBillResponse.QuerySettlementBill_Data data = new QuerySettlementBillResponse.QuerySettlementBill_Data();
			data.PageNum = _ctx.IntegerValue("QuerySettlementBill.Data.PageNum");
			data.BillingCycle = _ctx.StringValue("QuerySettlementBill.Data.BillingCycle");
			data.PageSize = _ctx.IntegerValue("QuerySettlementBill.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QuerySettlementBill.Data.TotalCount");

			List<QuerySettlementBillResponse.QuerySettlementBill_Data.QuerySettlementBill_Item> data_items = new List<QuerySettlementBillResponse.QuerySettlementBill_Data.QuerySettlementBill_Item>();
			for (int i = 0; i < _ctx.Length("QuerySettlementBill.Data.Items.Length"); i++) {
				QuerySettlementBillResponse.QuerySettlementBill_Data.QuerySettlementBill_Item item = new QuerySettlementBillResponse.QuerySettlementBill_Data.QuerySettlementBill_Item();
				item.Status = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Status");
				item.InvoiceNo = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].InvoiceNo");
				item.BillID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].BillID");
				item.CreateTime = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].CreateTime");
				item.Item = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Item");
				item.Seller = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Seller");
				item.Currency = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Currency");
				item.ChargeDiscount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].ChargeDiscount");
				item.DeductedByCashCoupons = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.Config = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Config");
				item.SubscriptionType = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].SubscriptionType");
				item.UsageStartTime = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].UsageStartTime");
				item.UsageEndTime = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].UsageEndTime");
				item.DeductedByCoupons = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].DeductedByCoupons");
				item.Region = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Region");
				item.OutstandingAmount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].OutstandingAmount");
				item.AfterTaxAmount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].AfterTaxAmount");
				item.PaymentTime = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].PaymentTime");
				item.SolutionID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].SolutionID");
				item.OrderType = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].OrderType");
				item.ClearedTime = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].ClearedTime");
				item.Quantity = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Quantity");
				item.Tax = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].Tax");
				item.PretaxAmountLocal = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PretaxAmountLocal");
				item.PretaxAmount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PretaxAmount");
				item.LinkedCustomerOrderID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].LinkedCustomerOrderID");
				item.AccountDiscount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].AccountDiscount");
				item.RecordID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].RecordID");
				item.PayerAccount = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].PayerAccount");
				item.Promotion = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Promotion");
				item.OriginalOrderID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].OriginalOrderID");
				item.PreviousBillingCycleBalance = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PreviousBillingCycleBalance");
				item.MybankPaymentAmount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].MybankPaymentAmount");
				item.PaymentCurrency = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].PaymentCurrency");
				item.OrderID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].OrderID");
				item.OwnerID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].OwnerID");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.PaymentAmount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PaymentAmount");
				item.ProductType = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].ProductType");
				item.PretaxGrossAmount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.SuborderID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].SuborderID");
				item.SolutionName = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].SolutionName");
				item.ProductCode = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].ProductCode");

				data_items.Add(item);
			}
			data.Items = data_items;
			querySettlementBillResponse.Data = data;
        
			return querySettlementBillResponse;
        }
    }
}
