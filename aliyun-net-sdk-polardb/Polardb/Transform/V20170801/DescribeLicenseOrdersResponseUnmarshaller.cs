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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeLicenseOrdersResponseUnmarshaller
    {
        public static DescribeLicenseOrdersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLicenseOrdersResponse describeLicenseOrdersResponse = new DescribeLicenseOrdersResponse();

			describeLicenseOrdersResponse.HttpResponse = _ctx.HttpResponse;
			describeLicenseOrdersResponse.PageNumber = _ctx.IntegerValue("DescribeLicenseOrders.PageNumber");
			describeLicenseOrdersResponse.PageRecordCount = _ctx.IntegerValue("DescribeLicenseOrders.PageRecordCount");
			describeLicenseOrdersResponse.RequestId = _ctx.StringValue("DescribeLicenseOrders.RequestId");
			describeLicenseOrdersResponse.TotalRecordCount = _ctx.IntegerValue("DescribeLicenseOrders.TotalRecordCount");

			List<DescribeLicenseOrdersResponse.DescribeLicenseOrders_LicenseOrder> describeLicenseOrdersResponse_items = new List<DescribeLicenseOrdersResponse.DescribeLicenseOrders_LicenseOrder>();
			for (int i = 0; i < _ctx.Length("DescribeLicenseOrders.Items.Length"); i++) {
				DescribeLicenseOrdersResponse.DescribeLicenseOrders_LicenseOrder licenseOrder = new DescribeLicenseOrdersResponse.DescribeLicenseOrders_LicenseOrder();
				licenseOrder.ActivatedCodeCount = _ctx.IntegerValue("DescribeLicenseOrders.Items["+ i +"].ActivatedCodeCount");
				licenseOrder.ActivationCodeQuota = _ctx.IntegerValue("DescribeLicenseOrders.Items["+ i +"].ActivationCodeQuota");
				licenseOrder.AliyunOrderId = _ctx.StringValue("DescribeLicenseOrders.Items["+ i +"].AliyunOrderId");
				licenseOrder.AllowEmptySystemIdentifier = _ctx.BooleanValue("DescribeLicenseOrders.Items["+ i +"].AllowEmptySystemIdentifier");
				licenseOrder.Engine = _ctx.StringValue("DescribeLicenseOrders.Items["+ i +"].Engine");
				licenseOrder.GmtCreated = _ctx.StringValue("DescribeLicenseOrders.Items["+ i +"].GmtCreated");
				licenseOrder.GmtModified = _ctx.StringValue("DescribeLicenseOrders.Items["+ i +"].GmtModified");
				licenseOrder.IsVirtualOrder = _ctx.BooleanValue("DescribeLicenseOrders.Items["+ i +"].IsVirtualOrder");
				licenseOrder.IsVirtualOrderFrozen = _ctx.BooleanValue("DescribeLicenseOrders.Items["+ i +"].IsVirtualOrderFrozen");
				licenseOrder.PackageType = _ctx.StringValue("DescribeLicenseOrders.Items["+ i +"].PackageType");
				licenseOrder.PackageValidity = _ctx.StringValue("DescribeLicenseOrders.Items["+ i +"].PackageValidity");
				licenseOrder.PurchaseChannel = _ctx.StringValue("DescribeLicenseOrders.Items["+ i +"].PurchaseChannel");
				licenseOrder.VirtualAliyunOrderId = _ctx.StringValue("DescribeLicenseOrders.Items["+ i +"].VirtualAliyunOrderId");

				describeLicenseOrdersResponse_items.Add(licenseOrder);
			}
			describeLicenseOrdersResponse.Items = describeLicenseOrdersResponse_items;
        
			return describeLicenseOrdersResponse;
        }
    }
}
