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
        public static QuerySplitItemBillResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySplitItemBillResponse querySplitItemBillResponse = new QuerySplitItemBillResponse();

			querySplitItemBillResponse.HttpResponse = context.HttpResponse;
			querySplitItemBillResponse.RequestId = context.StringValue("QuerySplitItemBill.RequestId");
			querySplitItemBillResponse.Success = context.BooleanValue("QuerySplitItemBill.Success");
			querySplitItemBillResponse.Code = context.StringValue("QuerySplitItemBill.Code");
			querySplitItemBillResponse.Message = context.StringValue("QuerySplitItemBill.Message");

			QuerySplitItemBillResponse.QuerySplitItemBill_Data data = new QuerySplitItemBillResponse.QuerySplitItemBill_Data();
			data.BillingCycle = context.StringValue("QuerySplitItemBill.Data.BillingCycle");
			data.AccountID = context.StringValue("QuerySplitItemBill.Data.AccountID");
			data.AccountName = context.StringValue("QuerySplitItemBill.Data.AccountName");
			data.TotalCount = context.IntegerValue("QuerySplitItemBill.Data.TotalCount");
			data.PageNum = context.IntegerValue("QuerySplitItemBill.Data.PageNum");
			data.PageSize = context.IntegerValue("QuerySplitItemBill.Data.PageSize");

			List<QuerySplitItemBillResponse.QuerySplitItemBill_Data.QuerySplitItemBill_Item> data_items = new List<QuerySplitItemBillResponse.QuerySplitItemBill_Data.QuerySplitItemBill_Item>();
			for (int i = 0; i < context.Length("QuerySplitItemBill.Data.Items.Length"); i++) {
				QuerySplitItemBillResponse.QuerySplitItemBill_Data.QuerySplitItemBill_Item item = new QuerySplitItemBillResponse.QuerySplitItemBill_Data.QuerySplitItemBill_Item();
				item.InstanceID = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].InstanceID");
				item.BillingType = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].BillingType");
				item.CostUnit = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].CostUnit");
				item.ProductCode = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ProductCode");
				item.ProductType = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SubscriptionType");
				item.ProductName = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ProductName");
				item.ProductDetail = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ProductDetail");
				item.OwnerID = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].OwnerID");
				item.BillingItem = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].BillingItem");
				item.ListPrice = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ListPrice");
				item.ListPriceUnit = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ListPriceUnit");
				item.Usage = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Usage");
				item.UsageUnit = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].UsageUnit");
				item.DeductedByResourcePackage = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].DeductedByResourcePackage");
				item.PretaxGrossAmount = context.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = context.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].InvoiceDiscount");
				item.DeductedByCoupons = context.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].DeductedByCoupons");
				item.PretaxAmount = context.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].PretaxAmount");
				item.DeductedByCashCoupons = context.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = context.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.PaymentAmount = context.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].PaymentAmount");
				item.OutstandingAmount = context.FloatValue("QuerySplitItemBill.Data.Items["+ i +"].OutstandingAmount");
				item.Currency = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Currency");
				item.NickName = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].NickName");
				item.ResourceGroup = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ResourceGroup");
				item.Tag = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Tag");
				item.InstanceConfig = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].InstanceConfig");
				item.InstanceSpec = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].InstanceSpec");
				item.InternetIP = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].InternetIP");
				item.IntranetIP = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].IntranetIP");
				item.Region = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Region");
				item.Zone = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Zone");
				item.Item = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].Item");
				item.ServicePeriod = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].ServicePeriod");
				item.BillingDate = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].BillingDate");
				item.SplitItemID = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitItemID");
				item.SplitItemName = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].SplitItemName");
				item.PipCode = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].PipCode");
				item.CommodityCode = context.StringValue("QuerySplitItemBill.Data.Items["+ i +"].CommodityCode");

				data_items.Add(item);
			}
			data.Items = data_items;
			querySplitItemBillResponse.Data = data;
        
			return querySplitItemBillResponse;
        }
    }
}
