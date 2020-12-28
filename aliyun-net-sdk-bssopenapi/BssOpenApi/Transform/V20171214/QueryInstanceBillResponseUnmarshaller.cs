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
			queryInstanceBillResponse.RequestId = _ctx.StringValue("QueryInstanceBill.RequestId");
			queryInstanceBillResponse.Success = _ctx.BooleanValue("QueryInstanceBill.Success");
			queryInstanceBillResponse.Code = _ctx.StringValue("QueryInstanceBill.Code");
			queryInstanceBillResponse.Message = _ctx.StringValue("QueryInstanceBill.Message");

			QueryInstanceBillResponse.QueryInstanceBill_Data data = new QueryInstanceBillResponse.QueryInstanceBill_Data();
			data.BillingCycle = _ctx.StringValue("QueryInstanceBill.Data.BillingCycle");
			data.AccountID = _ctx.StringValue("QueryInstanceBill.Data.AccountID");
			data.AccountName = _ctx.StringValue("QueryInstanceBill.Data.AccountName");
			data.TotalCount = _ctx.IntegerValue("QueryInstanceBill.Data.TotalCount");
			data.PageNum = _ctx.IntegerValue("QueryInstanceBill.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QueryInstanceBill.Data.PageSize");

			List<QueryInstanceBillResponse.QueryInstanceBill_Data.QueryInstanceBill_Item> data_items = new List<QueryInstanceBillResponse.QueryInstanceBill_Data.QueryInstanceBill_Item>();
			for (int i = 0; i < _ctx.Length("QueryInstanceBill.Data.Items.Length"); i++) {
				QueryInstanceBillResponse.QueryInstanceBill_Data.QueryInstanceBill_Item item = new QueryInstanceBillResponse.QueryInstanceBill_Data.QueryInstanceBill_Item();
				item.InstanceID = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].InstanceID");
				item.BillingType = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].BillingType");
				item.CostUnit = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].CostUnit");
				item.ProductCode = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ProductCode");
				item.ProductType = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].SubscriptionType");
				item.ProductName = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ProductName");
				item.ProductDetail = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ProductDetail");
				item.OwnerID = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].OwnerID");
				item.BillingItem = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].BillingItem");
				item.ListPrice = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ListPrice");
				item.ListPriceUnit = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ListPriceUnit");
				item.Usage = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].Usage");
				item.UsageUnit = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].UsageUnit");
				item.DeductedByResourcePackage = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].DeductedByResourcePackage");
				item.PretaxGrossAmount = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].InvoiceDiscount");
				item.DeductedByCoupons = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].DeductedByCoupons");
				item.PretaxAmount = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].PretaxAmount");
				item.DeductedByCashCoupons = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.PaymentAmount = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].PaymentAmount");
				item.OutstandingAmount = _ctx.FloatValue("QueryInstanceBill.Data.Items["+ i +"].OutstandingAmount");
				item.Currency = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].Currency");
				item.NickName = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].NickName");
				item.ResourceGroup = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ResourceGroup");
				item.Tag = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].Tag");
				item.InstanceConfig = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].InstanceConfig");
				item.InstanceSpec = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].InstanceSpec");
				item.InternetIP = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].InternetIP");
				item.IntranetIP = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].IntranetIP");
				item.Region = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].Region");
				item.Zone = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].Zone");
				item.Item = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].Item");
				item.ServicePeriod = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ServicePeriod");
				item.BillingDate = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].BillingDate");
				item.ServicePeriodUnit = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].ServicePeriodUnit");
				item.PipCode = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].PipCode");
				item.CommodityCode = _ctx.StringValue("QueryInstanceBill.Data.Items["+ i +"].CommodityCode");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryInstanceBillResponse.Data = data;
        
			return queryInstanceBillResponse;
        }
    }
}
