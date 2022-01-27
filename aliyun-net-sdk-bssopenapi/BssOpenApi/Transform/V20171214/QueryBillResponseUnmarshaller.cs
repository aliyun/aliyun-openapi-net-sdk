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
        public static QueryBillResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryBillResponse queryBillResponse = new QueryBillResponse();

			queryBillResponse.HttpResponse = _ctx.HttpResponse;
			queryBillResponse.RequestId = _ctx.StringValue("QueryBill.RequestId");
			queryBillResponse.Success = _ctx.BooleanValue("QueryBill.Success");
			queryBillResponse.Code = _ctx.StringValue("QueryBill.Code");
			queryBillResponse.Message = _ctx.StringValue("QueryBill.Message");

			QueryBillResponse.QueryBill_Data data = new QueryBillResponse.QueryBill_Data();
			data.BillingCycle = _ctx.StringValue("QueryBill.Data.BillingCycle");
			data.AccountID = _ctx.StringValue("QueryBill.Data.AccountID");
			data.AccountName = _ctx.StringValue("QueryBill.Data.AccountName");
			data.PageNum = _ctx.IntegerValue("QueryBill.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QueryBill.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QueryBill.Data.TotalCount");

			List<QueryBillResponse.QueryBill_Data.QueryBill_Item> data_items = new List<QueryBillResponse.QueryBill_Data.QueryBill_Item>();
			for (int i = 0; i < _ctx.Length("QueryBill.Data.Items.Length"); i++) {
				QueryBillResponse.QueryBill_Data.QueryBill_Item item = new QueryBillResponse.QueryBill_Data.QueryBill_Item();
				item.RecordID = _ctx.StringValue("QueryBill.Data.Items["+ i +"].RecordID");
				item.Item = _ctx.StringValue("QueryBill.Data.Items["+ i +"].Item");
				item.OwnerID = _ctx.StringValue("QueryBill.Data.Items["+ i +"].OwnerID");
				item.UsageStartTime = _ctx.StringValue("QueryBill.Data.Items["+ i +"].UsageStartTime");
				item.UsageEndTime = _ctx.StringValue("QueryBill.Data.Items["+ i +"].UsageEndTime");
				item.PaymentTime = _ctx.StringValue("QueryBill.Data.Items["+ i +"].PaymentTime");
				item.ProductCode = _ctx.StringValue("QueryBill.Data.Items["+ i +"].ProductCode");
				item.ProductType = _ctx.StringValue("QueryBill.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = _ctx.StringValue("QueryBill.Data.Items["+ i +"].SubscriptionType");
				item.ProductName = _ctx.StringValue("QueryBill.Data.Items["+ i +"].ProductName");
				item.ProductDetail = _ctx.StringValue("QueryBill.Data.Items["+ i +"].ProductDetail");
				item.PretaxGrossAmount = _ctx.FloatValue("QueryBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.DeductedByCoupons = _ctx.FloatValue("QueryBill.Data.Items["+ i +"].DeductedByCoupons");
				item.InvoiceDiscount = _ctx.FloatValue("QueryBill.Data.Items["+ i +"].InvoiceDiscount");
				item.PretaxAmount = _ctx.FloatValue("QueryBill.Data.Items["+ i +"].PretaxAmount");
				item.Currency = _ctx.StringValue("QueryBill.Data.Items["+ i +"].Currency");
				item.PretaxAmountLocal = _ctx.FloatValue("QueryBill.Data.Items["+ i +"].PretaxAmountLocal");
				item.Tax = _ctx.FloatValue("QueryBill.Data.Items["+ i +"].Tax");
				item.PaymentAmount = _ctx.FloatValue("QueryBill.Data.Items["+ i +"].PaymentAmount");
				item.DeductedByCashCoupons = _ctx.FloatValue("QueryBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QueryBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.OutstandingAmount = _ctx.FloatValue("QueryBill.Data.Items["+ i +"].OutstandingAmount");
				item.AfterTaxAmount = _ctx.FloatValue("QueryBill.Data.Items["+ i +"].AfterTaxAmount");
				item.Status = _ctx.StringValue("QueryBill.Data.Items["+ i +"].Status");
				item.PaymentCurrency = _ctx.StringValue("QueryBill.Data.Items["+ i +"].PaymentCurrency");
				item.PaymentTransactionID = _ctx.StringValue("QueryBill.Data.Items["+ i +"].PaymentTransactionID");
				item.RoundDownDiscount = _ctx.StringValue("QueryBill.Data.Items["+ i +"].RoundDownDiscount");
				item.SubOrderId = _ctx.StringValue("QueryBill.Data.Items["+ i +"].SubOrderId");
				item.PipCode = _ctx.StringValue("QueryBill.Data.Items["+ i +"].PipCode");
				item.CommodityCode = _ctx.StringValue("QueryBill.Data.Items["+ i +"].CommodityCode");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryBillResponse.Data = data;
        
			return queryBillResponse;
        }
    }
}
