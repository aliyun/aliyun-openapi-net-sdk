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
			queryBillOverviewResponse.RequestId = _ctx.StringValue("QueryBillOverview.RequestId");
			queryBillOverviewResponse.Success = _ctx.BooleanValue("QueryBillOverview.Success");
			queryBillOverviewResponse.Code = _ctx.StringValue("QueryBillOverview.Code");
			queryBillOverviewResponse.Message = _ctx.StringValue("QueryBillOverview.Message");

			QueryBillOverviewResponse.QueryBillOverview_Data data = new QueryBillOverviewResponse.QueryBillOverview_Data();
			data.BillingCycle = _ctx.StringValue("QueryBillOverview.Data.BillingCycle");
			data.AccountID = _ctx.StringValue("QueryBillOverview.Data.AccountID");
			data.AccountName = _ctx.StringValue("QueryBillOverview.Data.AccountName");

			List<QueryBillOverviewResponse.QueryBillOverview_Data.QueryBillOverview_Item> data_items = new List<QueryBillOverviewResponse.QueryBillOverview_Data.QueryBillOverview_Item>();
			for (int i = 0; i < _ctx.Length("QueryBillOverview.Data.Items.Length"); i++) {
				QueryBillOverviewResponse.QueryBillOverview_Data.QueryBillOverview_Item item = new QueryBillOverviewResponse.QueryBillOverview_Data.QueryBillOverview_Item();
				item.Item = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].Item");
				item.ProductCode = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].ProductCode");
				item.ProductType = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].SubscriptionType");
				item.ProductName = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].ProductName");
				item.ProductDetail = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].ProductDetail");
				item.PretaxGrossAmount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].InvoiceDiscount");
				item.DeductedByCoupons = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].DeductedByCoupons");
				item.PretaxAmount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].PretaxAmount");
				item.Currency = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].Currency");
				item.PaymentAmount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].PaymentAmount");
				item.OutstandingAmount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].OutstandingAmount");
				item.DeductedByCashCoupons = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.PretaxAmountLocal = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].PretaxAmountLocal");
				item.Tax = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].Tax");
				item.AfterTaxAmount = _ctx.FloatValue("QueryBillOverview.Data.Items["+ i +"].AfterTaxAmount");
				item.PaymentCurrency = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].PaymentCurrency");
				item.RoundDownDiscount = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].RoundDownDiscount");
				item.PipCode = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].PipCode");
				item.CommodityCode = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].CommodityCode");
				item.BillAccountID = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].BillAccountID");
				item.BillAccountName = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].BillAccountName");
				item.BizType = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].BizType");
				item.OwnerID = _ctx.StringValue("QueryBillOverview.Data.Items["+ i +"].OwnerID");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryBillOverviewResponse.Data = data;
        
			return queryBillOverviewResponse;
        }
    }
}
