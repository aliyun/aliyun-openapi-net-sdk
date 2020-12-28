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
			querySettlementBillResponse.RequestId = _ctx.StringValue("QuerySettlementBill.RequestId");
			querySettlementBillResponse.Success = _ctx.BooleanValue("QuerySettlementBill.Success");
			querySettlementBillResponse.Code = _ctx.StringValue("QuerySettlementBill.Code");
			querySettlementBillResponse.Message = _ctx.StringValue("QuerySettlementBill.Message");

			QuerySettlementBillResponse.QuerySettlementBill_Data data = new QuerySettlementBillResponse.QuerySettlementBill_Data();
			data.PageNum = _ctx.IntegerValue("QuerySettlementBill.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QuerySettlementBill.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QuerySettlementBill.Data.TotalCount");
			data.BillingCycle = _ctx.StringValue("QuerySettlementBill.Data.BillingCycle");

			List<QuerySettlementBillResponse.QuerySettlementBill_Data.QuerySettlementBill_Item> data_items = new List<QuerySettlementBillResponse.QuerySettlementBill_Data.QuerySettlementBill_Item>();
			for (int i = 0; i < _ctx.Length("QuerySettlementBill.Data.Items.Length"); i++) {
				QuerySettlementBillResponse.QuerySettlementBill_Data.QuerySettlementBill_Item item = new QuerySettlementBillResponse.QuerySettlementBill_Data.QuerySettlementBill_Item();
				item.RecordID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].RecordID");
				item.Item = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Item");
				item.PayerAccount = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].PayerAccount");
				item.OwnerID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].OwnerID");
				item.CreateTime = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].CreateTime");
				item.UsageStartTime = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].UsageStartTime");
				item.UsageEndTime = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].UsageEndTime");
				item.SuborderID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].SuborderID");
				item.OrderID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].OrderID");
				item.OrderType = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].OrderType");
				item.LinkedCustomerOrderID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].LinkedCustomerOrderID");
				item.OriginalOrderID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].OriginalOrderID");
				item.PaymentTime = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].PaymentTime");
				item.SolutionID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].SolutionID");
				item.SolutionName = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].SolutionName");
				item.BillID = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].BillID");
				item.ProductCode = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].ProductCode");
				item.ProductType = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].SubscriptionType");
				item.Region = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Region");
				item.Config = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Config");
				item.Quantity = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Quantity");
				item.PretaxGrossAmount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.ChargeDiscount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].ChargeDiscount");
				item.DeductedByCoupons = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].DeductedByCoupons");
				item.AccountDiscount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].AccountDiscount");
				item.Promotion = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Promotion");
				item.PretaxAmount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PretaxAmount");
				item.Currency = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Currency");
				item.PretaxAmountLocal = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PretaxAmountLocal");
				item.PreviousBillingCycleBalance = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PreviousBillingCycleBalance");
				item.Tax = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].Tax");
				item.AfterTaxAmount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].AfterTaxAmount");
				item.Status = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Status");
				item.ClearedTime = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].ClearedTime");
				item.OutstandingAmount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].OutstandingAmount");
				item.DeductedByCashCoupons = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.MybankPaymentAmount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].MybankPaymentAmount");
				item.PaymentAmount = _ctx.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PaymentAmount");
				item.PaymentCurrency = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].PaymentCurrency");
				item.Seller = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].Seller");
				item.InvoiceNo = _ctx.StringValue("QuerySettlementBill.Data.Items["+ i +"].InvoiceNo");

				data_items.Add(item);
			}
			data.Items = data_items;
			querySettlementBillResponse.Data = data;
        
			return querySettlementBillResponse;
        }
    }
}
