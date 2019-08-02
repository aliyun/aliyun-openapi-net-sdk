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
        public static QueryMonthlyBillResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMonthlyBillResponse queryMonthlyBillResponse = new QueryMonthlyBillResponse();

			queryMonthlyBillResponse.HttpResponse = context.HttpResponse;
			queryMonthlyBillResponse.RequestId = context.StringValue("QueryMonthlyBill.RequestId");
			queryMonthlyBillResponse.Success = context.BooleanValue("QueryMonthlyBill.Success");
			queryMonthlyBillResponse.Code = context.StringValue("QueryMonthlyBill.Code");
			queryMonthlyBillResponse.Message = context.StringValue("QueryMonthlyBill.Message");

			QueryMonthlyBillResponse.QueryMonthlyBill_Data data = new QueryMonthlyBillResponse.QueryMonthlyBill_Data();
			data.OutstandingAmount = context.FloatValue("QueryMonthlyBill.Data.OutstandingAmount");
			data.TotalOutstandingAmount = context.FloatValue("QueryMonthlyBill.Data.TotalOutstandingAmount");
			data.NewInvoiceAmount = context.FloatValue("QueryMonthlyBill.Data.NewInvoiceAmount");
			data.BillingCycle = context.StringValue("QueryMonthlyBill.Data.BillingCycle");

			List<QueryMonthlyBillResponse.QueryMonthlyBill_Data.QueryMonthlyBill_Item> data_items = new List<QueryMonthlyBillResponse.QueryMonthlyBill_Data.QueryMonthlyBill_Item>();
			for (int i = 0; i < context.Length("QueryMonthlyBill.Data.Items.Length"); i++) {
				QueryMonthlyBillResponse.QueryMonthlyBill_Data.QueryMonthlyBill_Item item = new QueryMonthlyBillResponse.QueryMonthlyBill_Data.QueryMonthlyBill_Item();
				item.Item = context.StringValue("QueryMonthlyBill.Data.Items["+ i +"].Item");
				item.ProductCode = context.StringValue("QueryMonthlyBill.Data.Items["+ i +"].ProductCode");
				item.ProductType = context.StringValue("QueryMonthlyBill.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = context.StringValue("QueryMonthlyBill.Data.Items["+ i +"].SubscriptionType");
				item.SolutionCode = context.StringValue("QueryMonthlyBill.Data.Items["+ i +"].SolutionCode");
				item.SolutionName = context.StringValue("QueryMonthlyBill.Data.Items["+ i +"].SolutionName");
				item.PretaxGrossAmount = context.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = context.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].InvoiceDiscount");
				item.DeductedByCoupons = context.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].DeductedByCoupons");
				item.PretaxAmount = context.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].PretaxAmount");
				item.Currency = context.StringValue("QueryMonthlyBill.Data.Items["+ i +"].Currency");
				item.PretaxAmountLocal = context.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].PretaxAmountLocal");
				item.Tax = context.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].Tax");
				item.AfterTaxAmount = context.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].AfterTaxAmount");
				item.OutstandingAmount = context.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].OutstandingAmount");
				item.DeductedByCashCoupons = context.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = context.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.PaymentAmount = context.FloatValue("QueryMonthlyBill.Data.Items["+ i +"].PaymentAmount");
				item.PaymentCurrency = context.StringValue("QueryMonthlyBill.Data.Items["+ i +"].PaymentCurrency");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryMonthlyBillResponse.Data = data;
        
			return queryMonthlyBillResponse;
        }
    }
}
