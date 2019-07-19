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
        public static QueryInstanceBillResponse Unmarshall(UnmarshallerContext context)
        {
			QueryInstanceBillResponse queryInstanceBillResponse = new QueryInstanceBillResponse();

			queryInstanceBillResponse.HttpResponse = context.HttpResponse;
			queryInstanceBillResponse.RequestId = context.StringValue("QueryInstanceBill.RequestId");
			queryInstanceBillResponse.Success = context.BooleanValue("QueryInstanceBill.Success");
			queryInstanceBillResponse.Code = context.StringValue("QueryInstanceBill.Code");
			queryInstanceBillResponse.Message = context.StringValue("QueryInstanceBill.Message");

			QueryInstanceBillResponse.QueryInstanceBill_Data data = new QueryInstanceBillResponse.QueryInstanceBill_Data();
			data.BillingCycle = context.StringValue("QueryInstanceBill.Data.BillingCycle");
			data.AccountID = context.StringValue("QueryInstanceBill.Data.AccountID");
			data.AccountName = context.StringValue("QueryInstanceBill.Data.AccountName");
			data.TotalCount = context.IntegerValue("QueryInstanceBill.Data.TotalCount");
			data.PageNum = context.IntegerValue("QueryInstanceBill.Data.PageNum");
			data.PageSize = context.IntegerValue("QueryInstanceBill.Data.PageSize");

			List<QueryInstanceBillResponse.QueryInstanceBill_Data.QueryInstanceBill_Item> data_items = new List<QueryInstanceBillResponse.QueryInstanceBill_Data.QueryInstanceBill_Item>();
			for (int i = 0; i < context.Length("QueryInstanceBill.Data.Items.Length"); i++) {
				QueryInstanceBillResponse.QueryInstanceBill_Data.QueryInstanceBill_Item item = new QueryInstanceBillResponse.QueryInstanceBill_Data.QueryInstanceBill_Item();
				item.InstanceID = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].InstanceID");
				item.BillingType = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].BillingType");
				item.CostUnit = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].CostUnit");
				item.ProductCode = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].ProductCode");
				item.ProductType = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].SubscriptionType");
				item.ProductName = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].ProductName");
				item.ProductDetail = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].ProductDetail");
				item.OwnerID = context.LongValue("QueryInstanceBill.Data.Items["+ i +"].OwnerID");
				item.BillingItem = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].BillingItem");
				item.ListPrice = context.FloatValue("QueryInstanceBill.Data.Items["+ i +"].ListPrice");
				item.ListPriceUnit = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].ListPriceUnit");
				item.Usage = context.FloatValue("QueryInstanceBill.Data.Items["+ i +"].Usage");
				item.UsageUnit = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].UsageUnit");
				item.DeductedByResourcePackage = context.FloatValue("QueryInstanceBill.Data.Items["+ i +"].DeductedByResourcePackage");
				item.PretaxGrossAmount = context.FloatValue("QueryInstanceBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = context.FloatValue("QueryInstanceBill.Data.Items["+ i +"].InvoiceDiscount");
				item.DeductedByCoupons = context.FloatValue("QueryInstanceBill.Data.Items["+ i +"].DeductedByCoupons");
				item.PretaxAmount = context.FloatValue("QueryInstanceBill.Data.Items["+ i +"].PretaxAmount");
				item.DeductedByCashCoupons = context.FloatValue("QueryInstanceBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = context.FloatValue("QueryInstanceBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.PaymentAmount = context.FloatValue("QueryInstanceBill.Data.Items["+ i +"].PaymentAmount");
				item.OutstandingAmount = context.FloatValue("QueryInstanceBill.Data.Items["+ i +"].OutstandingAmount");
				item.Currency = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].Currency");
				item.NickName = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].NickName");
				item.ResourceGroup = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].ResourceGroup");
				item.Tag = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].Tag");
				item.InstanceConfig = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].InstanceConfig");
				item.InstanceSpec = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].InstanceSpec");
				item.InternetIP = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].InternetIP");
				item.IntranetIP = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].IntranetIP");
				item.Region = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].Region");
				item.Zone = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].Zone");
				item.Item = context.StringValue("QueryInstanceBill.Data.Items["+ i +"].Item");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryInstanceBillResponse.Data = data;
        
			return queryInstanceBillResponse;
        }
    }
}
