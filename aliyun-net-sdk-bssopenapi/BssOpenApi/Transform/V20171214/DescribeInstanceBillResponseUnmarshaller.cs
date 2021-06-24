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
    public class DescribeInstanceBillResponseUnmarshaller
    {
        public static DescribeInstanceBillResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceBillResponse describeInstanceBillResponse = new DescribeInstanceBillResponse();

			describeInstanceBillResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceBillResponse.RequestId = _ctx.StringValue("DescribeInstanceBill.RequestId");
			describeInstanceBillResponse.Success = _ctx.BooleanValue("DescribeInstanceBill.Success");
			describeInstanceBillResponse.Code = _ctx.StringValue("DescribeInstanceBill.Code");
			describeInstanceBillResponse.Message = _ctx.StringValue("DescribeInstanceBill.Message");

			DescribeInstanceBillResponse.DescribeInstanceBill_Data data = new DescribeInstanceBillResponse.DescribeInstanceBill_Data();
			data.BillingCycle = _ctx.StringValue("DescribeInstanceBill.Data.BillingCycle");
			data.AccountID = _ctx.StringValue("DescribeInstanceBill.Data.AccountID");
			data.AccountName = _ctx.StringValue("DescribeInstanceBill.Data.AccountName");
			data.TotalCount = _ctx.IntegerValue("DescribeInstanceBill.Data.TotalCount");
			data.NextToken = _ctx.StringValue("DescribeInstanceBill.Data.NextToken");
			data.MaxResults = _ctx.IntegerValue("DescribeInstanceBill.Data.MaxResults");

			List<DescribeInstanceBillResponse.DescribeInstanceBill_Data.DescribeInstanceBill_Item> data_items = new List<DescribeInstanceBillResponse.DescribeInstanceBill_Data.DescribeInstanceBill_Item>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceBill.Data.Items.Length"); i++) {
				DescribeInstanceBillResponse.DescribeInstanceBill_Data.DescribeInstanceBill_Item item = new DescribeInstanceBillResponse.DescribeInstanceBill_Data.DescribeInstanceBill_Item();
				item.InstanceID = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].InstanceID");
				item.BillingType = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BillingType");
				item.CostUnit = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].CostUnit");
				item.ProductCode = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ProductCode");
				item.ProductType = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].SubscriptionType");
				item.ProductName = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ProductName");
				item.ProductDetail = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ProductDetail");
				item.OwnerID = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].OwnerID");
				item.BillingItem = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BillingItem");
				item.ListPrice = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ListPrice");
				item.ListPriceUnit = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ListPriceUnit");
				item.Usage = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].Usage");
				item.UsageUnit = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].UsageUnit");
				item.DeductedByResourcePackage = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].DeductedByResourcePackage");
				item.PretaxGrossAmount = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].InvoiceDiscount");
				item.DeductedByCoupons = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].DeductedByCoupons");
				item.PretaxAmount = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].PretaxAmount");
				item.DeductedByCashCoupons = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByPrepaidCard = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.PaymentAmount = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].PaymentAmount");
				item.OutstandingAmount = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].OutstandingAmount");
				item.Currency = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].Currency");
				item.NickName = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].NickName");
				item.ResourceGroup = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ResourceGroup");
				item.Tag = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].Tag");
				item.InstanceConfig = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].InstanceConfig");
				item.InstanceSpec = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].InstanceSpec");
				item.InternetIP = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].InternetIP");
				item.IntranetIP = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].IntranetIP");
				item.Region = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].Region");
				item.Zone = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].Zone");
				item.Item = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].Item");
				item.ServicePeriod = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ServicePeriod");
				item.BillingDate = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BillingDate");
				item.ServicePeriodUnit = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ServicePeriodUnit");
				item.PipCode = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].PipCode");
				item.CommodityCode = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].CommodityCode");
				item.BillAccountID = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BillAccountID");
				item.BillAccountName = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BillAccountName");
				item.BizType = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BizType");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeInstanceBillResponse.Data = data;
        
			return describeInstanceBillResponse;
        }
    }
}
