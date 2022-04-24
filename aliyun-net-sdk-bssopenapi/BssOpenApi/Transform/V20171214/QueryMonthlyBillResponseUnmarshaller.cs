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
    public class QueryMonthlyBillResponseUnmarshaller
    {
        public static QueryMonthlyBillResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMonthlyBillResponse queryMonthlyBillResponse = new QueryMonthlyBillResponse();

			queryMonthlyBillResponse.HttpResponse = _ctx.HttpResponse;
			queryMonthlyBillResponse.Code = _ctx.StringValue("QueryMonthlyBill.Code");
			queryMonthlyBillResponse.Message = _ctx.StringValue("QueryMonthlyBill.Message");
			queryMonthlyBillResponse.RequestId = _ctx.StringValue("QueryMonthlyBill.RequestId");
			queryMonthlyBillResponse.Success = _ctx.BooleanValue("QueryMonthlyBill.Success");

			QueryMonthlyBillResponse.QueryMonthlyBill_Data data = new QueryMonthlyBillResponse.QueryMonthlyBill_Data();
			data.OutstandingAmount = _ctx.FloatValue("QueryMonthlyBill.Data.OutstandingAmount");
			data.BillingCycle = _ctx.StringValue("QueryMonthlyBill.Data.BillingCycle");
			data.TotalOutstandingAmount = _ctx.FloatValue("QueryMonthlyBill.Data.TotalOutstandingAmount");
			data.NewInvoiceAmount = _ctx.FloatValue("QueryMonthlyBill.Data.NewInvoiceAmount");

			List<QueryMonthlyBillResponse.QueryMonthlyBill_Data.QueryMonthlyBill_Item> data_items = new List<QueryMonthlyBillResponse.QueryMonthlyBill_Data.QueryMonthlyBill_Item>();
			for (int i = 0; i < _ctx.Length("QueryMonthlyBill.Data.Items.Length"); i++) {
				QueryMonthlyBillResponse.QueryMonthlyBill_Data.QueryMonthlyBill_Item item = new QueryMonthlyBillResponse.QueryMonthlyBill_Data.QueryMonthlyBill_Item();
				item.PretaxAmount = _ctx.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].PretaxAmount");
				item.SolutionCode = _ctx.StringValue("QueryMonthlyBill.Data.Items["+ i +"].SolutionCode");
				item.Item = _ctx.StringValue("QueryMonthlyBill.Data.Items["+ i +"].Item");
				item.Currency = _ctx.StringValue("QueryMonthlyBill.Data.Items["+ i +"].Currency");
				item.DeductedByCashCoupons = _ctx.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.SubscriptionType = _ctx.StringValue("QueryMonthlyBill.Data.Items["+ i +"].SubscriptionType");
				item.PaymentCurrency = _ctx.StringValue("QueryMonthlyBill.Data.Items["+ i +"].PaymentCurrency");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.DeductedByCoupons = _ctx.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].DeductedByCoupons");
				item.PaymentAmount = _ctx.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].PaymentAmount");
				item.InvoiceDiscount = _ctx.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].InvoiceDiscount");
				item.ProductType = _ctx.StringValue("QueryMonthlyBill.Data.Items["+ i +"].ProductType");
				item.OutstandingAmount = _ctx.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].OutstandingAmount");
				item.AfterTaxAmount = _ctx.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].AfterTaxAmount");
				item.PretaxGrossAmount = _ctx.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.SolutionName = _ctx.StringValue("QueryMonthlyBill.Data.Items["+ i +"].SolutionName");
				item.Tax = _ctx.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].Tax");
				item.PretaxAmountLocal = _ctx.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].PretaxAmountLocal");
				item.ProductCode = _ctx.StringValue("QueryMonthlyBill.Data.Items["+ i +"].ProductCode");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryMonthlyBillResponse.Data = data;
        
			return queryMonthlyBillResponse;
        }
    }
}
