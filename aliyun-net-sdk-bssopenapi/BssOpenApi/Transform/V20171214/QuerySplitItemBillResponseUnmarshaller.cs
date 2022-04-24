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
			querySplitItemBillResponse.Code = _ctx.StringValue("QuerySplitItemBill.Code");
			querySplitItemBillResponse.Message = _ctx.StringValue("QuerySplitItemBill.Message");
			querySplitItemBillResponse.RequestId = _ctx.StringValue("QuerySplitItemBill.RequestId");
			querySplitItemBillResponse.Success = _ctx.BooleanValue("QuerySplitItemBill.Success");

			QuerySplitItemBillResponse.QuerySplitItemBill_Data data = new QuerySplitItemBillResponse.QuerySplitItemBill_Data();
			data.PageNum = _ctx.IntegerValue("QuerySplitItemBill.Data.PageNum");
			data.BillingCycle = _ctx.StringValue("QuerySplitItemBill.Data.BillingCycle");
			data.AccountID = _ctx.StringValue("QuerySplitItemBill.Data.AccountID");
			data.PageSize = _ctx.IntegerValue("QuerySplitItemBill.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QuerySplitItemBill.Data.TotalCount");
			data.AccountName = _ctx.StringValue("QuerySplitItemBill.Data.AccountName");

			List<QuerySplitItemBillResponse.QuerySplitItemBill_Data.QuerySplitItemBill_Item> data_items = new List<QuerySplitItemBillResponse.QuerySplitItemBill_Data.QuerySplitItemBill_Item>();
			for (int i = 0; i < _ctx.Length("QuerySplitItemBill.Data.Items.Length"); i++) {
				QuerySplitItemBillResponse.QuerySplitItemBill_Data.QuerySplitItemBill_Item item = new QuerySplitItemBillResponse.QuerySplitItemBill_Data.QuerySplitItemBill_Item();
				item.SplitAccountID = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitAccountID");
				item.SubscriptionType = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SubscriptionType");
				item.InstanceSpec = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].InstanceSpec");
				item.DeductedByCoupons = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].DeductedByCoupons");
				item.Region = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Region");
				item.OutstandingAmount = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].OutstandingAmount");
				item.PipCode = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].PipCode");
				item.CommodityCode = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].CommodityCode");
				item.NickName = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].NickName");
				item.ProductDetail = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ProductDetail");
				item.Usage = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Usage");
				item.IntranetIP = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].IntranetIP");
				item.UsageUnit = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].UsageUnit");
				item.SplitCommodityCode = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitCommodityCode");
				item.ProductType = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ProductType");
				item.DeductedByResourcePackage = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].DeductedByResourcePackage");
				item.PaymentAmount = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].PaymentAmount");
				item.SplitBillingCycle = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitBillingCycle");
				item.ServicePeriod = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ServicePeriod");
				item.SplitItemName = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitItemName");
				item.ListPrice = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ListPrice");
				item.Zone = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Zone");
				item.PretaxGrossAmount = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.CashAmount = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].CashAmount");
				item.InstanceConfig = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].InstanceConfig");
				item.BillingDate = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].BillingDate");
				item.InternetIP = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].InternetIP");
				item.Item = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Item");
				item.SplitItemID = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitItemID");
				item.InstanceID = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].InstanceID");
				item.Tag = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Tag");
				item.Currency = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Currency");
				item.DeductedByCashCoupons = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.BillingItem = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].BillingItem");
				item.CostUnit = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].CostUnit");
				item.ListPriceUnit = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ListPriceUnit");
				item.ResourceGroup = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ResourceGroup");
				item.PretaxAmount = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].PretaxAmount");
				item.ServicePeriodUnit = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ServicePeriodUnit");
				item.ProductName = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ProductName");
				item.SplitProductDetail = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitProductDetail");
				item.AdjustAmount = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].AdjustAmount");
				item.OwnerID = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].OwnerID");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.InvoiceDiscount = _ctx.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].InvoiceDiscount");
				item.SplitAccountName = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitAccountName");
				item.BillingType = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].BillingType");
				item.ProductCode = _ctx.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ProductCode");

				data_items.Add(item);
			}
			data.Items = data_items;
			querySplitItemBillResponse.Data = data;
        
			return querySplitItemBillResponse;
        }
    }
}
