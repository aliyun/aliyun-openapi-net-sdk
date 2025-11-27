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
    public class DescribeLicenseOrderDetailsResponseUnmarshaller
    {
        public static DescribeLicenseOrderDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLicenseOrderDetailsResponse describeLicenseOrderDetailsResponse = new DescribeLicenseOrderDetailsResponse();

			describeLicenseOrderDetailsResponse.HttpResponse = _ctx.HttpResponse;
			describeLicenseOrderDetailsResponse.ActivatedCodeCount = _ctx.IntegerValue("DescribeLicenseOrderDetails.ActivatedCodeCount");
			describeLicenseOrderDetailsResponse.ActivationCodeQuota = _ctx.IntegerValue("DescribeLicenseOrderDetails.ActivationCodeQuota");
			describeLicenseOrderDetailsResponse.AliyunOrderId = _ctx.StringValue("DescribeLicenseOrderDetails.AliyunOrderId");
			describeLicenseOrderDetailsResponse.AllowEmptySystemIdentifier = _ctx.BooleanValue("DescribeLicenseOrderDetails.AllowEmptySystemIdentifier");
			describeLicenseOrderDetailsResponse.Engine = _ctx.StringValue("DescribeLicenseOrderDetails.Engine");
			describeLicenseOrderDetailsResponse.GmtCreated = _ctx.StringValue("DescribeLicenseOrderDetails.GmtCreated");
			describeLicenseOrderDetailsResponse.GmtModified = _ctx.StringValue("DescribeLicenseOrderDetails.GmtModified");
			describeLicenseOrderDetailsResponse.IsVirtualOrder = _ctx.BooleanValue("DescribeLicenseOrderDetails.IsVirtualOrder");
			describeLicenseOrderDetailsResponse.IsVirtualOrderFrozen = _ctx.BooleanValue("DescribeLicenseOrderDetails.IsVirtualOrderFrozen");
			describeLicenseOrderDetailsResponse.PackageType = _ctx.StringValue("DescribeLicenseOrderDetails.PackageType");
			describeLicenseOrderDetailsResponse.PackageValidity = _ctx.StringValue("DescribeLicenseOrderDetails.PackageValidity");
			describeLicenseOrderDetailsResponse.PurchaseChannel = _ctx.StringValue("DescribeLicenseOrderDetails.PurchaseChannel");
			describeLicenseOrderDetailsResponse.RequestId = _ctx.StringValue("DescribeLicenseOrderDetails.RequestId");
			describeLicenseOrderDetailsResponse.VirtualOrderId = _ctx.StringValue("DescribeLicenseOrderDetails.VirtualOrderId");
        
			return describeLicenseOrderDetailsResponse;
        }
    }
}
