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
        public static QuerySettlementBillResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySettlementBillResponse querySettlementBillResponse = new QuerySettlementBillResponse();

			querySettlementBillResponse.HttpResponse = context.HttpResponse;
			querySettlementBillResponse.RequestId = context.StringValue("QuerySettlementBill.RequestId");
			querySettlementBillResponse.Success = context.BooleanValue("QuerySettlementBill.Success");
			querySettlementBillResponse.Code = context.StringValue("QuerySettlementBill.Code");
			querySettlementBillResponse.Message = context.StringValue("QuerySettlementBill.Message");

			QuerySettlementBillResponse.QuerySettlementBill_Data data = new QuerySettlementBillResponse.QuerySettlementBill_Data();
			data.PageNum = context.IntegerValue("QuerySettlementBill.Data.PageNum");
			data.PageSize = context.IntegerValue("QuerySettlementBill.Data.PageSize");
			data.TotalCount = context.IntegerValue("QuerySettlementBill.Data.TotalCount");
			data.BillingCycle = context.StringValue("QuerySettlementBill.Data.BillingCycle");

			List<QuerySettlementBillResponse.QuerySettlementBill_Data.QuerySettlementBill_Item> data_items = new List<QuerySettlementBillResponse.QuerySettlementBill_Data.QuerySettlementBill_Item>();
			for (int i = 0; i < context.Length("QuerySettlementBill.Data.Items.Length"); i++) {
				QuerySettlementBillResponse.QuerySettlementBill_Data.QuerySettlementBill_Item item = new QuerySettlementBillResponse.QuerySettlementBill_Data.QuerySettlementBill_Item();
				item.RecordID = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].RecordID");
				item.Item = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].Item");
				item.PayerAccount = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].PayerAccount");
				item.OwnerID = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].OwnerID");
				item.CreateTime = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].CreateTime");
				item.UsageStartTime = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].UsageStartTime");
				item.UsageEndTime = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].UsageEndTime");
				item.SuborderID = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].SuborderID");
				item.OrderID = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].OrderID");
				item.OrderType = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].OrderType");
				item.LinkedCustomerOrderID = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].LinkedCustomerOrderID");
				item.OriginalOrderID = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].OriginalOrderID");
				item.PaymentTime = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].PaymentTime");
				item.SolutionID = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].SolutionID");
				item.SolutionName = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].SolutionName");
				item.BillID = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].BillID");
				item.ProductCode = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].ProductCode");
				item.ProductType = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].SubscriptionType");
				item.Region = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].Region");
				item.Config = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].Config");
				item.Quantity = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].Quantity");
				item.PretaxGrossAmount = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.ChargeDiscount = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].ChargeDiscount");
				item.DeductedByCoupons = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].DeductedByCoupons");
				item.AccountDiscount = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].AccountDiscount");
				item.Promotion = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].Promotion");
				item.PretaxAmount = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PretaxAmount");
				item.Currency = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].Currency");
				item.PretaxAmountLocal = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PretaxAmountLocal");
				item.PreviousBillingCycleBalance = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PreviousBillingCycleBalance");
				item.Tax = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].Tax");
				item.AfterTaxAmount = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].AfterTaxAmount");
				item.Status = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].Status");
				item.ClearedTime = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].ClearedTime");
				item.OutstandingAmount = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].OutstandingAmount");
				item.DeductedByCashCoupons = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.MybankPaymentAmount = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].MybankPaymentAmount");
				item.PaymentAmount = context.FloatValue("QuerySettlementBill.Data.Items["+ i +"].PaymentAmount");
				item.PaymentCurrency = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].PaymentCurrency");
				item.Seller = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].Seller");
				item.InvoiceNo = context.StringValue("QuerySettlementBill.Data.Items["+ i +"].InvoiceNo");

				data_items.Add(item);
			}
			data.Items = data_items;
			querySettlementBillResponse.Data = data;
        
			return querySettlementBillResponse;
        }
    }
}
