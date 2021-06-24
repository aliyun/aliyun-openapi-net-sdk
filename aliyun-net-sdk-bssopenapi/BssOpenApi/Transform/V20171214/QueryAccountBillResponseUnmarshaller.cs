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
			queryAccountBillResponse.RequestId = _ctx.StringValue("QueryAccountBill.RequestId");
			queryAccountBillResponse.Success = _ctx.BooleanValue("QueryAccountBill.Success");
			queryAccountBillResponse.Code = _ctx.StringValue("QueryAccountBill.Code");
			queryAccountBillResponse.Message = _ctx.StringValue("QueryAccountBill.Message");

			QueryAccountBillResponse.QueryAccountBill_Data data = new QueryAccountBillResponse.QueryAccountBill_Data();
			data.BillingCycle = _ctx.StringValue("QueryAccountBill.Data.BillingCycle");
			data.AccountID = _ctx.StringValue("QueryAccountBill.Data.AccountID");
			data.AccountName = _ctx.StringValue("QueryAccountBill.Data.AccountName");
			data.TotalCount = _ctx.IntegerValue("QueryAccountBill.Data.TotalCount");
			data.PageNum = _ctx.IntegerValue("QueryAccountBill.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QueryAccountBill.Data.PageSize");

			List<QueryAccountBillResponse.QueryAccountBill_Data.QueryAccountBill_Item> data_items = new List<QueryAccountBillResponse.QueryAccountBill_Data.QueryAccountBill_Item>();
			for (int i = 0; i < _ctx.Length("QueryAccountBill.Data.Items.Length"); i++) {
				QueryAccountBillResponse.QueryAccountBill_Data.QueryAccountBill_Item item = new QueryAccountBillResponse.QueryAccountBill_Data.QueryAccountBill_Item();
				item.CostUnit = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].CostUnit");
				item.OwnerID = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].OwnerID");
				item.PretaxGrossAmount = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].InvoiceDiscount");
				item.DeductedByCoupons = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].DeductedByCoupons");
				item.PretaxAmount = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].PretaxAmount");
				item.DeductedByCashCoupons = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.PaymentAmount = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].PaymentAmount");
				item.OutstandingAmount = _ctx.FloatValue("QueryAccountBill.Data.Items["+ i +"].OutstandingAmount");
				item.Currency = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].Currency");
				item.OwnerName = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].OwnerName");
				item.ProductCode = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].ProductCode");
				item.ProductName = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].ProductName");
				item.SubscriptionType = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].SubscriptionType");
				item.PipCode = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].PipCode");
				item.BillingDate = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].BillingDate");
				item.BillAccountID = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].BillAccountID");
				item.BillAccountName = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].BillAccountName");
				item.BizType = _ctx.StringValue("QueryAccountBill.Data.Items["+ i +"].BizType");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryAccountBillResponse.Data = data;
        
			return queryAccountBillResponse;
        }
    }
}
