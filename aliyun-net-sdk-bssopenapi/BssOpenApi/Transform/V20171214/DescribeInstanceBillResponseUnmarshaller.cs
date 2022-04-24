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
			describeInstanceBillResponse.Code = _ctx.StringValue("DescribeInstanceBill.Code");
			describeInstanceBillResponse.Message = _ctx.StringValue("DescribeInstanceBill.Message");
			describeInstanceBillResponse.RequestId = _ctx.StringValue("DescribeInstanceBill.RequestId");
			describeInstanceBillResponse.Success = _ctx.BooleanValue("DescribeInstanceBill.Success");

			DescribeInstanceBillResponse.DescribeInstanceBill_Data data = new DescribeInstanceBillResponse.DescribeInstanceBill_Data();
			data.NextToken = _ctx.StringValue("DescribeInstanceBill.Data.NextToken");
			data.BillingCycle = _ctx.StringValue("DescribeInstanceBill.Data.BillingCycle");
			data.MaxResults = _ctx.IntegerValue("DescribeInstanceBill.Data.MaxResults");
			data.AccountID = _ctx.StringValue("DescribeInstanceBill.Data.AccountID");
			data.TotalCount = _ctx.IntegerValue("DescribeInstanceBill.Data.TotalCount");
			data.AccountName = _ctx.StringValue("DescribeInstanceBill.Data.AccountName");

			List<DescribeInstanceBillResponse.DescribeInstanceBill_Data.DescribeInstanceBill_Item> data_items = new List<DescribeInstanceBillResponse.DescribeInstanceBill_Data.DescribeInstanceBill_Item>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceBill.Data.Items.Length"); i++) {
				DescribeInstanceBillResponse.DescribeInstanceBill_Data.DescribeInstanceBill_Item item = new DescribeInstanceBillResponse.DescribeInstanceBill_Data.DescribeInstanceBill_Item();
				item.BillingDate = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BillingDate");
				item.InstanceConfig = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].InstanceConfig");
				item.InternetIP = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].InternetIP");
				item.Item = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].Item");
				item.Tag = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].Tag");
				item.InstanceID = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].InstanceID");
				item.Currency = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].Currency");
				item.BillAccountName = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BillAccountName");
				item.DeductedByCashCoupons = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.SubscriptionType = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].SubscriptionType");
				item.BizType = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BizType");
				item.InstanceSpec = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].InstanceSpec");
				item.DeductedByCoupons = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].DeductedByCoupons");
				item.BillingItem = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BillingItem");
				item.BillingItemCode = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BillingItemCode");
				item.Region = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].Region");
				item.OutstandingAmount = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].OutstandingAmount");
				item.CostUnit = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].CostUnit");
				item.ListPriceUnit = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ListPriceUnit");
				item.ResourceGroup = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ResourceGroup");
				item.PipCode = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].PipCode");
				item.ServicePeriodUnit = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ServicePeriodUnit");
				item.PretaxAmount = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].PretaxAmount");
				item.CommodityCode = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].CommodityCode");
				item.ProductName = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ProductName");
				item.AdjustAmount = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].AdjustAmount");
				item.NickName = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].NickName");
				item.ProductDetail = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ProductDetail");
				item.Usage = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].Usage");
				item.IntranetIP = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].IntranetIP");
				item.OwnerID = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].OwnerID");
				item.DeductedByPrepaidCard = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.UsageUnit = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].UsageUnit");
				item.BillAccountID = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BillAccountID");
				item.PaymentAmount = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].PaymentAmount");
				item.InvoiceDiscount = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].InvoiceDiscount");
				item.DeductedByResourcePackage = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].DeductedByResourcePackage");
				item.ProductType = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ProductType");
				item.ServicePeriod = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ServicePeriod");
				item.Zone = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].Zone");
				item.ListPrice = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ListPrice");
				item.PretaxGrossAmount = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.CashAmount = _ctx.FloatValue("DescribeInstanceBill.Data.Items["+ i +"].CashAmount");
				item.ProductCode = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ProductCode");
				item.BillingType = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].BillingType");
				item.ItemName = _ctx.StringValue("DescribeInstanceBill.Data.Items["+ i +"].ItemName");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeInstanceBillResponse.Data = data;
        
			return describeInstanceBillResponse;
        }
    }
}
