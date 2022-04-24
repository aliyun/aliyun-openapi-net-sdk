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
    public class QueryAccountBillResponseUnmarshaller
    {
        public static QueryAccountBillResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAccountBillResponse queryAccountBillResponse = new QueryAccountBillResponse();

			queryAccountBillResponse.HttpResponse = _ctx.HttpResponse;
			queryAccountBillResponse.Code = _ctx.StringValue("QueryAccountBill.Code");
			queryAccountBillResponse.Message = _ctx.StringValue("QueryAccountBill.Message");
			queryAccountBillResponse.RequestId = _ctx.StringValue("QueryAccountBill.RequestId");
			queryAccountBillResponse.Success = _ctx.BooleanValue("QueryAccountBill.Success");

			QueryAccountBillResponse.QueryAccountBill_Data data = new QueryAccountBillResponse.QueryAccountBill_Data();
			data.PageNum = _ctx.IntegerValue("QueryAccountBill.Data.PageNum");
			data.BillingCycle = _ctx.StringValue("QueryAccountBill.Data.BillingCycle");
			data.AccountID = _ctx.StringValue("QueryAccountBill.Data.AccountID");
			data.PageSize = _ctx.IntegerValue("QueryAccountBill.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QueryAccountBill.Data.TotalCount");
			data.AccountName = _ctx.StringValue("QueryAccountBill.Data.AccountName");

			List<QueryAccountBillResponse.QueryAccountBill_Data.QueryAccountBill_Item> data_items = new List<QueryAccountBillResponse.QueryAccountBill_Data.QueryAccountBill_Item>();
			for (int i = 0; i < _ctx.Length("QueryAccountBill.Data.Items.Length"); i++) {
				QueryAccountBillResponse.QueryAccountBill_Data.QueryAccountBill_Item item = new QueryAccountBillResponse.QueryAccountBill_Data.QueryAccountBill_Item();
				item.PipCode = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].PipCode");
				item.PretaxAmount = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].PretaxAmount");
				item.BillingDate = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].BillingDate");
				item.ProductName = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].ProductName");
				item.AdjustAmount = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].AdjustAmount");
				item.OwnerName = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].OwnerName");
				item.Currency = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].Currency");
				item.BillAccountName = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].BillAccountName");
				item.SubscriptionType = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].SubscriptionType");
				item.DeductedByCashCoupons = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.BizType = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].BizType");
				item.OwnerID = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].OwnerID");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.DeductedByCoupons = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].DeductedByCoupons");
				item.BillAccountID = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].BillAccountID");
				item.PaymentAmount = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].PaymentAmount");
				item.InvoiceDiscount = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].InvoiceDiscount");
				item.OutstandingAmount = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].OutstandingAmount");
				item.CostUnit = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].CostUnit");
				item.PretaxGrossAmount = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.CashAmount = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].CashAmount");
				item.ProductCode = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].ProductCode");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryAccountBillResponse.Data = data;
        
			return queryAccountBillResponse;
        }
    }
}
