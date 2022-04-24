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
    public class QueryInstanceBillResponseUnmarshaller
    {
        public static QueryInstanceBillResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryInstanceBillResponse queryInstanceBillResponse = new QueryInstanceBillResponse();

			queryInstanceBillResponse.HttpResponse = _ctx.HttpResponse;
			queryInstanceBillResponse.Code = _ctx.StringValue("QueryInstanceBill.Code");
			queryInstanceBillResponse.Message = _ctx.StringValue("QueryInstanceBill.Message");
			queryInstanceBillResponse.RequestId = _ctx.StringValue("QueryInstanceBill.RequestId");
			queryInstanceBillResponse.Success = _ctx.BooleanValue("QueryInstanceBill.Success");

			QueryInstanceBillResponse.QueryInstanceBill_Data data = new QueryInstanceBillResponse.QueryInstanceBill_Data();
			data.PageNum = _ctx.IntegerValue("QueryInstanceBill.Data.PageNum");
			data.BillingCycle = _ctx.StringValue("QueryInstanceBill.Data.BillingCycle");
			data.AccountID = _ctx.StringValue("QueryInstanceBill.Data.AccountID");
			data.PageSize = _ctx.IntegerValue("QueryInstanceBill.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QueryInstanceBill.Data.TotalCount");
			data.AccountName = _ctx.StringValue("QueryInstanceBill.Data.AccountName");

			List<QueryInstanceBillResponse.QueryInstanceBill_Data.QueryInstanceBill_Item> data_items = new List<QueryInstanceBillResponse.QueryInstanceBill_Data.QueryInstanceBill_Item>();
			for (int i = 0; i < _ctx.Length("QueryInstanceBill.Data.Items.Length"); i++) {
				QueryInstanceBillResponse.QueryInstanceBill_Data.QueryInstanceBill_Item item = new QueryInstanceBillResponse.QueryInstanceBill_Data.QueryInstanceBill_Item();
				item.BillingDate = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].BillingDate");
				item.InstanceConfig = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].InstanceConfig");
				item.InternetIP = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].InternetIP");
				item.Item = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].Item");
				item.Tag = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].Tag");
				item.InstanceID = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].InstanceID");
				item.Currency = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].Currency");
				item.DeductedByCashCoupons = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.SubscriptionType = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].SubscriptionType");
				item.InstanceSpec = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].InstanceSpec");
				item.DeductedByCoupons = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].DeductedByCoupons");
				item.BillingItem = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].BillingItem");
				item.Region = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].Region");
				item.OutstandingAmount = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].OutstandingAmount");
				item.CostUnit = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].CostUnit");
				item.ListPriceUnit = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ListPriceUnit");
				item.ResourceGroup = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ResourceGroup");
				item.PipCode = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].PipCode");
				item.ServicePeriodUnit = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ServicePeriodUnit");
				item.PretaxAmount = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].PretaxAmount");
				item.CommodityCode = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].CommodityCode");
				item.ProductName = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ProductName");
				item.AdjustAmount = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].AdjustAmount");
				item.NickName = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].NickName");
				item.ProductDetail = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ProductDetail");
				item.Usage = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].Usage");
				item.IntranetIP = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].IntranetIP");
				item.OwnerID = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].OwnerID");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.UsageUnit = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].UsageUnit");
				item.PaymentAmount = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].PaymentAmount");
				item.InvoiceDiscount = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].InvoiceDiscount");
				item.DeductedByResourcePackage = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].DeductedByResourcePackage");
				item.ProductType = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ProductType");
				item.ServicePeriod = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ServicePeriod");
				item.Zone = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].Zone");
				item.ListPrice = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ListPrice");
				item.PretaxGrossAmount = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.CashAmount = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].CashAmount");
				item.ProductCode = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ProductCode");
				item.BillingType = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].BillingType");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryInstanceBillResponse.Data = data;
        
			return queryInstanceBillResponse;
        }
    }
}
