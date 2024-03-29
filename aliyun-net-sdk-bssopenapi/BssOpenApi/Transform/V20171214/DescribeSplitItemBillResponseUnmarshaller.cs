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
    public class DescribeSplitItemBillResponseUnmarshaller
    {
        public static DescribeSplitItemBillResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSplitItemBillResponse describeSplitItemBillResponse = new DescribeSplitItemBillResponse();

			describeSplitItemBillResponse.HttpResponse = _ctx.HttpResponse;
			describeSplitItemBillResponse.Code = _ctx.StringValue("DescribeSplitItemBill.Code");
			describeSplitItemBillResponse.Message = _ctx.StringValue("DescribeSplitItemBill.Message");
			describeSplitItemBillResponse.RequestId = _ctx.StringValue("DescribeSplitItemBill.RequestId");
			describeSplitItemBillResponse.Success = _ctx.BooleanValue("DescribeSplitItemBill.Success");

			DescribeSplitItemBillResponse.DescribeSplitItemBill_Data data = new DescribeSplitItemBillResponse.DescribeSplitItemBill_Data();
			data.NextToken = _ctx.StringValue("DescribeSplitItemBill.Data.NextToken");
			data.BillingCycle = _ctx.StringValue("DescribeSplitItemBill.Data.BillingCycle");
			data.MaxResults = _ctx.IntegerValue("DescribeSplitItemBill.Data.MaxResults");
			data.AccountID = _ctx.StringValue("DescribeSplitItemBill.Data.AccountID");
			data.TotalCount = _ctx.IntegerValue("DescribeSplitItemBill.Data.TotalCount");
			data.AccountName = _ctx.StringValue("DescribeSplitItemBill.Data.AccountName");

			List<DescribeSplitItemBillResponse.DescribeSplitItemBill_Data.DescribeSplitItemBill_Item> data_items = new List<DescribeSplitItemBillResponse.DescribeSplitItemBill_Data.DescribeSplitItemBill_Item>();
			for (int i = 0; i < _ctx.Length("DescribeSplitItemBill.Data.Items.Length"); i++) {
				DescribeSplitItemBillResponse.DescribeSplitItemBill_Data.DescribeSplitItemBill_Item item = new DescribeSplitItemBillResponse.DescribeSplitItemBill_Data.DescribeSplitItemBill_Item();
				item.SplitAccountID = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].SplitAccountID");
				item.BillAccountName = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].BillAccountName");
				item.SubscriptionType = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].SubscriptionType");
				item.InstanceSpec = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].InstanceSpec");
				item.DeductedByCoupons = _ctx.FloatValue("DescribeSplitItemBill.Data.Items["+ i +"].DeductedByCoupons");
				item.Region = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].Region");
				item.OutstandingAmount = _ctx.FloatValue("DescribeSplitItemBill.Data.Items["+ i +"].OutstandingAmount");
				item.PipCode = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].PipCode");
				item.CommodityCode = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].CommodityCode");
				item.NickName = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].NickName");
				item.ProductDetail = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].ProductDetail");
				item.Usage = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].Usage");
				item.IntranetIP = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].IntranetIP");
				item.UsageUnit = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].UsageUnit");
				item.SplitCommodityCode = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].SplitCommodityCode");
				item.BillAccountID = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].BillAccountID");
				item.ProductType = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].ProductType");
				item.DeductedByResourcePackage = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].DeductedByResourcePackage");
				item.PaymentAmount = _ctx.FloatValue("DescribeSplitItemBill.Data.Items["+ i +"].PaymentAmount");
				item.SplitBillingCycle = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].SplitBillingCycle");
				item.ServicePeriod = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].ServicePeriod");
				item.SplitItemName = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].SplitItemName");
				item.ListPrice = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].ListPrice");
				item.Zone = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].Zone");
				item.PretaxGrossAmount = _ctx.FloatValue("DescribeSplitItemBill.Data.Items["+ i +"].PretaxGrossAmount");
				item.CashAmount = _ctx.FloatValue("DescribeSplitItemBill.Data.Items["+ i +"].CashAmount");
				item.InstanceConfig = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].InstanceConfig");
				item.BillingDate = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].BillingDate");
				item.InternetIP = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].InternetIP");
				item.Item = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].Item");
				item.SplitItemID = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].SplitItemID");
				item.InstanceID = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].InstanceID");
				item.Tag = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].Tag");
				item.Currency = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].Currency");
				item.DeductedByCashCoupons = _ctx.FloatValue("DescribeSplitItemBill.Data.Items["+ i +"].DeductedByCashCoupons");
				item.BizType = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].BizType");
				item.BillingItem = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].BillingItem");
				item.BillingItemCode = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].BillingItemCode");
				item.CostUnit = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].CostUnit");
				item.ListPriceUnit = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].ListPriceUnit");
				item.ResourceGroup = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].ResourceGroup");
				item.PretaxAmount = _ctx.FloatValue("DescribeSplitItemBill.Data.Items["+ i +"].PretaxAmount");
				item.ServicePeriodUnit = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].ServicePeriodUnit");
				item.SplitBillingDate = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].SplitBillingDate");
				item.ProductName = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].ProductName");
				item.SplitProductDetail = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].SplitProductDetail");
				item.AdjustAmount = _ctx.FloatValue("DescribeSplitItemBill.Data.Items["+ i +"].AdjustAmount");
				item.OwnerID = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].OwnerID");
				item.DeductedByPrepaidCard = _ctx.FloatValue("DescribeSplitItemBill.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.InvoiceDiscount = _ctx.FloatValue("DescribeSplitItemBill.Data.Items["+ i +"].InvoiceDiscount");
				item.SplitAccountName = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].SplitAccountName");
				item.BillingType = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].BillingType");
				item.ProductCode = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].ProductCode");
				item.ItemName = _ctx.StringValue("DescribeSplitItemBill.Data.Items["+ i +"].ItemName");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeSplitItemBillResponse.Data = data;
        
			return describeSplitItemBillResponse;
        }
    }
}
