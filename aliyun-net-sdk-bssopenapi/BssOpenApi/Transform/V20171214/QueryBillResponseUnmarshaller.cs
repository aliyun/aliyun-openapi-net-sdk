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
    public class QueryBillResponseUnmarshaller
    {
        public static QueryBillResponse Unmarshall(UnmarshallerContext context)
        {
			QueryBillResponse queryBillResponse = new QueryBillResponse();

			queryBillResponse.HttpResponse = context.HttpResponse;
			queryBillResponse.RequestId = context.StringValue("QueryBill.RequestId");
			queryBillResponse.Success = context.BooleanValue("QueryBill.Success");
			queryBillResponse.Code = context.StringValue("QueryBill.Code");
			queryBillResponse.Message = context.StringValue("QueryBill.Message");

			QueryBillResponse.QueryBill_Data data = new QueryBillResponse.QueryBill_Data();
			data.BillingCycle = context.StringValue("QueryBill.Data.BillingCycle");
			data.AccountID = context.StringValue("QueryBill.Data.AccountID");
			data.AccountName = context.StringValue("QueryBill.Data.AccountName");
			data.PageNum = context.IntegerValue("QueryBill.Data.PageNum");
			data.PageSize = context.IntegerValue("QueryBill.Data.PageSize");
			data.TotalCount = context.IntegerValue("QueryBill.Data.TotalCount");

			List<QueryBillResponse.QueryBill_Data.QueryBill_Item> data_items = new List<QueryBillResponse.QueryBill_Data.QueryBill_Item>();
			for (int i = 0; i < context.Length("QueryBill.Data.Items.Length"); i++) {
				QueryBillResponse.QueryBill_Data.QueryBill_Item item = new QueryBillResponse.QueryBill_Data.QueryBill_Item();
				item.RecordID = context.StringValue("QueryBill.Data.Items["+ i +"].RecordID");
				item.Item = context.StringValue("QueryBill.Data.Items["+ i +"].Item");
				item.OwnerID = context.StringValue("QueryBill.Data.Items["+ i +"].OwnerID");
				item.UsageStartTime = context.StringValue("QueryBill.Data.Items["+ i +"].UsageStartTime");
				item.UsageEndTime = context.StringValue("QueryBill.Data.Items["+ i +"].UsageEndTime");
				item.PaymentTime = context.StringValue("QueryBill.Data.Items["+ i +"].PaymentTime");
				item.ProductCode = context.StringValue("QueryBill.Data.Items["+ i +"].ProductCode");
				item.ProductType = context.StringValue("QueryBill.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = context.StringValue("QueryBill.Data.Items["+ i +"].SubscriptionType");
				item.ProductName = context.StringValue("QueryBill.Data.Items["+ i +"].ProductName");
				item.ProductDetail = context.StringValue("QueryBill.Data.Items["+ i +"].ProductDetail");
				item.PretaxGrossAmount = context.FloatValue("QueryBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.DeductedByCoupons = context.FloatValue("QueryBill.Data.Items["+ i +"].DeductedByCoupons");
				item.InvoiceDiscount = context.FloatValue("QueryBill.Data.Items["+ i +"].InvoiceDiscount");
				item.PretaxAmount = context.FloatValue("QueryBill.Data.Items["+ i +"].PretaxAmount");
				item.Currency = context.StringValue("QueryBill.Data.Items["+ i +"].Currency");
				item.PretaxAmountLocal = context.FloatValue("QueryBill.Data.Items["+ i +"].PretaxAmountLocal");
				item.Tax = context.FloatValue("QueryBill.Data.Items["+ i +"].Tax");
				item.PaymentAmount = context.FloatValue("QueryBill.Data.Items["+ i +"].PaymentAmount");
				item.DeductedByCashCoupons = context.FloatValue("QueryBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = context.FloatValue("QueryBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.OutstandingAmount = context.FloatValue("QueryBill.Data.Items["+ i +"].OutstandingAmount");
				item.AfterTaxAmount = context.FloatValue("QueryBill.Data.Items["+ i +"].AfterTaxAmount");
				item.Status = context.StringValue("QueryBill.Data.Items["+ i +"].Status");
				item.PaymentCurrency = context.StringValue("QueryBill.Data.Items["+ i +"].PaymentCurrency");
				item.PaymentTransactionID = context.StringValue("QueryBill.Data.Items["+ i +"].PaymentTransactionID");
				item.RoundDownDiscount = context.StringValue("QueryBill.Data.Items["+ i +"].RoundDownDiscount");
				item.SubOrderId = context.StringValue("QueryBill.Data.Items["+ i +"].SubOrderId");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryBillResponse.Data = data;
        
			return queryBillResponse;
        }
    }
}
