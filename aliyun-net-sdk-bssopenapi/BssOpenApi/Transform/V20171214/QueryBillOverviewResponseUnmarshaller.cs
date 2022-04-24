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
    public class QueryBillOverviewResponseUnmarshaller
    {
        public static QueryBillOverviewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryBillOverviewResponse queryBillOverviewResponse = new QueryBillOverviewResponse();

			queryBillOverviewResponse.HttpResponse = _ctx.HttpResponse;
			queryBillOverviewResponse.Code = _ctx.StringValue("QueryBillOverview.Code");
			queryBillOverviewResponse.Message = _ctx.StringValue("QueryBillOverview.Message");
			queryBillOverviewResponse.RequestId = _ctx.StringValue("QueryBillOverview.RequestId");
			queryBillOverviewResponse.Success = _ctx.BooleanValue("QueryBillOverview.Success");

			QueryBillOverviewResponse.QueryBillOverview_Data data = new QueryBillOverviewResponse.QueryBillOverview_Data();
			data.BillingCycle = _ctx.StringValue("QueryBillOverview.Data.BillingCycle");
			data.AccountID = _ctx.StringValue("QueryBillOverview.Data.AccountID");
			data.AccountName = _ctx.StringValue("QueryBillOverview.Data.AccountName");

			List<QueryBillOverviewResponse.QueryBillOverview_Data.QueryBillOverview_Item> data_items = new List<QueryBillOverviewResponse.QueryBillOverview_Data.QueryBillOverview_Item>();
			for (int i = 0; i < _ctx.Length("QueryBillOverview.Data.Items.Length"); i++) {
				QueryBillOverviewResponse.QueryBillOverview_Data.QueryBillOverview_Item item = new QueryBillOverviewResponse.QueryBillOverview_Data.QueryBillOverview_Item();
				item.RoundDownDiscount = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].RoundDownDiscount");
				item.Item = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].Item");
				item.Currency = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].Currency");
				item.SubscriptionType = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].SubscriptionType");
				item.DeductedByCashCoupons = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].DeductedByCashCoupons");
				item.BillAccountName = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].BillAccountName");
				item.BizType = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].BizType");
				item.DeductedByCoupons = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].DeductedByCoupons");
				item.OutstandingAmount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].OutstandingAmount");
				item.AfterTaxAmount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].AfterTaxAmount");
				item.PretaxAmountLocal = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].PretaxAmountLocal");
				item.Tax = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].Tax");
				item.PipCode = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].PipCode");
				item.PretaxAmount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].PretaxAmount");
				item.ProductName = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].ProductName");
				item.CommodityCode = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].CommodityCode");
				item.AdjustAmount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].AdjustAmount");
				item.ProductDetail = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].ProductDetail");
				item.PaymentCurrency = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].PaymentCurrency");
				item.OwnerID = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].OwnerID");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.ProductType = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].ProductType");
				item.InvoiceDiscount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].InvoiceDiscount");
				item.PaymentAmount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].PaymentAmount");
				item.BillAccountID = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].BillAccountID");
				item.PretaxGrossAmount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].PretaxGrossAmount");
				item.CashAmount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].CashAmount");
				item.ProductCode = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].ProductCode");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryBillOverviewResponse.Data = data;
        
			return queryBillOverviewResponse;
        }
    }
}
