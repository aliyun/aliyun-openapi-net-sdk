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
    public class QuerySplitItemBillResponseUnmarshaller
    {
        public static QuerySplitItemBillResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySplitItemBillResponse querySplitItemBillResponse = new QuerySplitItemBillResponse();

			querySplitItemBillResponse.HttpResponse = _ctx.HttpResponse;
			querySplitItemBillResponse.RequestId = _ctx.StringValue("QuerySplitItemBill.RequestId");
			querySplitItemBillResponse.Success = _ctx.BooleanValue("QuerySplitItemBill.Success");
			querySplitItemBillResponse.Code = _ctx.StringValue("QuerySplitItemBill.Code");
			querySplitItemBillResponse.Message = _ctx.StringValue("QuerySplitItemBill.Message");

			QuerySplitItemBillResponse.QuerySplitItemBill_Data data = new QuerySplitItemBillResponse.QuerySplitItemBill_Data();
			data.BillingCycle = _ctx.StringValue("QuerySplitItemBill.Data.BillingCycle");
			data.AccountID = _ctx.StringValue("QuerySplitItemBill.Data.AccountID");
			data.AccountName = _ctx.StringValue("QuerySplitItemBill.Data.AccountName");
			data.TotalCount = _ctx.IntegerValue("QuerySplitItemBill.Data.TotalCount");
			data.PageNum = _ctx.IntegerValue("QuerySplitItemBill.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QuerySplitItemBill.Data.PageSize");

			List<QuerySplitItemBillResponse.QuerySplitItemBill_Data.QuerySplitItemBill_Item> data_items = new List<QuerySplitItemBillResponse.QuerySplitItemBill_Data.QuerySplitItemBill_Item>();
			for (int i = 0; i < _ctx.Length("QuerySplitItemBill.Data.Items.Length"); i++) {
				QuerySplitItemBillResponse.QuerySplitItemBill_Data.QuerySplitItemBill_Item item = new QuerySplitItemBillResponse.QuerySplitItemBill_Data.QuerySplitItemBill_Item();
				item.InstanceID = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].InstanceID");
				item.BillingType = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].BillingType");
				item.CostUnit = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].CostUnit");
				item.ProductCode = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ProductCode");
				item.ProductType = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SubscriptionType");
				item.ProductName = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ProductName");
				item.ProductDetail = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ProductDetail");
				item.OwnerID = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].OwnerID");
				item.BillingItem = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].BillingItem");
				item.ListPrice = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ListPrice");
				item.ListPriceUnit = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ListPriceUnit");
				item.Usage = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Usage");
				item.UsageUnit = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].UsageUnit");
				item.DeductedByResourcePackage = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].DeductedByResourcePackage");
				item.PretaxGrossAmount = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].InvoiceDiscount");
				item.DeductedByCoupons = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].DeductedByCoupons");
				item.PretaxAmount = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].PretaxAmount");
				item.DeductedByCashCoupons = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.PaymentAmount = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].PaymentAmount");
				item.OutstandingAmount = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].OutstandingAmount");
				item.Currency = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Currency");
				item.NickName = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].NickName");
				item.ResourceGroup = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ResourceGroup");
				item.Tag = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Tag");
				item.InstanceConfig = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].InstanceConfig");
				item.InstanceSpec = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].InstanceSpec");
				item.InternetIP = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].InternetIP");
				item.IntranetIP = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].IntranetIP");
				item.Region = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Region");
				item.Zone = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Zone");
				item.Item = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Item");
				item.ServicePeriod = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ServicePeriod");
				item.BillingDate = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].BillingDate");
				item.SplitItemID = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitItemID");
				item.SplitItemName = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitItemName");
				item.PipCode = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].PipCode");
				item.CommodityCode = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].CommodityCode");
				item.ServicePeriodUnit = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ServicePeriodUnit");
				item.SplitCommodityCode = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitCommodityCode");
				item.SplitProductDetail = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitProductDetail");
				item.SplitAccountID = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitAccountID");
				item.SplitAccountName = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitAccountName");
				item.SplitBillingCycle = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitBillingCycle");

				data_items.Add(item);
			}
			data.Items = data_items;
			querySplitItemBillResponse.Data = data;
        
			return querySplitItemBillResponse;
        }
    }
}
