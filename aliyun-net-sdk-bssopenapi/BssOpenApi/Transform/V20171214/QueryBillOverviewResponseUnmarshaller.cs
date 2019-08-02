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
        public static QueryBillOverviewResponse Unmarshall(UnmarshallerContext context)
        {
			QueryBillOverviewResponse queryBillOverviewResponse = new QueryBillOverviewResponse();

			queryBillOverviewResponse.HttpResponse = context.HttpResponse;
			queryBillOverviewResponse.RequestId = context.StringValue("QueryBillOverview.RequestId");
			queryBillOverviewResponse.Success = context.BooleanValue("QueryBillOverview.Success");
			queryBillOverviewResponse.Code = context.StringValue("QueryBillOverview.Code");
			queryBillOverviewResponse.Message = context.StringValue("QueryBillOverview.Message");

			QueryBillOverviewResponse.QueryBillOverview_Data data = new QueryBillOverviewResponse.QueryBillOverview_Data();
			data.BillingCycle = context.StringValue("QueryBillOverview.Data.BillingCycle");
			data.AccountID = context.StringValue("QueryBillOverview.Data.AccountID");
			data.AccountName = context.StringValue("QueryBillOverview.Data.AccountName");

			List<QueryBillOverviewResponse.QueryBillOverview_Data.QueryBillOverview_Item> data_items = new List<QueryBillOverviewResponse.QueryBillOverview_Data.QueryBillOverview_Item>();
			for (int i = 0; i < context.Length("QueryBillOverview.Data.Items.Length"); i++) {
				QueryBillOverviewResponse.QueryBillOverview_Data.QueryBillOverview_Item item = new QueryBillOverviewResponse.QueryBillOverview_Data.QueryBillOverview_Item();
				item.Item = context.StringValue("QueryBillOverview.Data.Items["+ i +"].Item");
				item.ProductCode = context.StringValue("QueryBillOverview.Data.Items["+ i +"].ProductCode");
				item.ProductType = context.StringValue("QueryBillOverview.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = context.StringValue("QueryBillOverview.Data.Items["+ i +"].SubscriptionType");
				item.ProductName = context.StringValue("QueryBillOverview.Data.Items["+ i +"].ProductName");
				item.ProductDetail = context.StringValue("QueryBillOverview.Data.Items["+ i +"].ProductDetail");
				item.PretaxGrossAmount = context.FloatValue("QueryBillOverview.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = context.FloatValue("QueryBillOverview.Data.Items["+ i +"].InvoiceDiscount");
				item.DeductedByCoupons = context.FloatValue("QueryBillOverview.Data.Items["+ i +"].DeductedByCoupons");
				item.PretaxAmount = context.FloatValue("QueryBillOverview.Data.Items["+ i +"].PretaxAmount");
				item.Currency = context.StringValue("QueryBillOverview.Data.Items["+ i +"].Currency");
				item.PaymentAmount = context.FloatValue("QueryBillOverview.Data.Items["+ i +"].PaymentAmount");
				item.OutstandingAmount = context.FloatValue("QueryBillOverview.Data.Items["+ i +"].OutstandingAmount");
				item.DeductedByCashCoupons = context.FloatValue("QueryBillOverview.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = context.FloatValue("QueryBillOverview.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.PretaxAmountLocal = context.FloatValue("QueryBillOverview.Data.Items["+ i +"].PretaxAmountLocal");
				item.Tax = context.FloatValue("QueryBillOverview.Data.Items["+ i +"].Tax");
				item.AfterTaxAmount = context.FloatValue("QueryBillOverview.Data.Items["+ i +"].AfterTaxAmount");
				item.PaymentCurrency = context.StringValue("QueryBillOverview.Data.Items["+ i +"].PaymentCurrency");
				item.RoundDownDiscount = context.StringValue("QueryBillOverview.Data.Items["+ i +"].RoundDownDiscount");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryBillOverviewResponse.Data = data;
        
			return queryBillOverviewResponse;
        }
    }
}
