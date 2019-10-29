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
        public static QueryAccountBillResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAccountBillResponse queryAccountBillResponse = new QueryAccountBillResponse();

			queryAccountBillResponse.HttpResponse = context.HttpResponse;
			queryAccountBillResponse.RequestId = context.StringValue("QueryAccountBill.RequestId");
			queryAccountBillResponse.Success = context.BooleanValue("QueryAccountBill.Success");
			queryAccountBillResponse.Code = context.StringValue("QueryAccountBill.Code");
			queryAccountBillResponse.Message = context.StringValue("QueryAccountBill.Message");

			QueryAccountBillResponse.QueryAccountBill_Data data = new QueryAccountBillResponse.QueryAccountBill_Data();
			data.BillingCycle = context.StringValue("QueryAccountBill.Data.BillingCycle");
			data.AccountID = context.StringValue("QueryAccountBill.Data.AccountID");
			data.AccountName = context.StringValue("QueryAccountBill.Data.AccountName");
			data.TotalCount = context.IntegerValue("QueryAccountBill.Data.TotalCount");
			data.PageNum = context.IntegerValue("QueryAccountBill.Data.PageNum");
			data.PageSize = context.IntegerValue("QueryAccountBill.Data.PageSize");

			List<QueryAccountBillResponse.QueryAccountBill_Data.QueryAccountBill_Item> data_items = new List<QueryAccountBillResponse.QueryAccountBill_Data.QueryAccountBill_Item>();
			for (int i = 0; i < context.Length("QueryAccountBill.Data.Items.Length"); i++) {
				QueryAccountBillResponse.QueryAccountBill_Data.QueryAccountBill_Item item = new QueryAccountBillResponse.QueryAccountBill_Data.QueryAccountBill_Item();
				item.CostUnit = context.StringValue("QueryAccountBill.Data.Items["+ i +"].CostUnit");
				item.OwnerID = context.StringValue("QueryAccountBill.Data.Items["+ i +"].OwnerID");
				item.PretaxGrossAmount = context.FloatValue("QueryAccountBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = context.FloatValue("QueryAccountBill.Data.Items["+ i +"].InvoiceDiscount");
				item.DeductedByCoupons = context.FloatValue("QueryAccountBill.Data.Items["+ i +"].DeductedByCoupons");
				item.PretaxAmount = context.FloatValue("QueryAccountBill.Data.Items["+ i +"].PretaxAmount");
				item.DeductedByCashCoupons = context.FloatValue("QueryAccountBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = context.FloatValue("QueryAccountBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.PaymentAmount = context.FloatValue("QueryAccountBill.Data.Items["+ i +"].PaymentAmount");
				item.OutstandingAmount = context.FloatValue("QueryAccountBill.Data.Items["+ i +"].OutstandingAmount");
				item.Currency = context.StringValue("QueryAccountBill.Data.Items["+ i +"].Currency");
				item.OwnerName = context.StringValue("QueryAccountBill.Data.Items["+ i +"].OwnerName");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryAccountBillResponse.Data = data;
        
			return queryAccountBillResponse;
        }
    }
}
