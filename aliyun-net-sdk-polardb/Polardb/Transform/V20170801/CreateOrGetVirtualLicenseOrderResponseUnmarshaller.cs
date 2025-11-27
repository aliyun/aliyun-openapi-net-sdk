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
    public class CreateOrGetVirtualLicenseOrderResponseUnmarshaller
    {
        public static CreateOrGetVirtualLicenseOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateOrGetVirtualLicenseOrderResponse createOrGetVirtualLicenseOrderResponse = new CreateOrGetVirtualLicenseOrderResponse();

			createOrGetVirtualLicenseOrderResponse.HttpResponse = _ctx.HttpResponse;
			createOrGetVirtualLicenseOrderResponse.ActivatedCodeCount = _ctx.IntegerValue("CreateOrGetVirtualLicenseOrder.ActivatedCodeCount");
			createOrGetVirtualLicenseOrderResponse.ActivationCodeQuota = _ctx.IntegerValue("CreateOrGetVirtualLicenseOrder.ActivationCodeQuota");
			createOrGetVirtualLicenseOrderResponse.AliyunOrderId = _ctx.StringValue("CreateOrGetVirtualLicenseOrder.AliyunOrderId");
			createOrGetVirtualLicenseOrderResponse.AllowEmptySystemIdentifier = _ctx.BooleanValue("CreateOrGetVirtualLicenseOrder.AllowEmptySystemIdentifier");
			createOrGetVirtualLicenseOrderResponse.GmtCreated = _ctx.StringValue("CreateOrGetVirtualLicenseOrder.GmtCreated");
			createOrGetVirtualLicenseOrderResponse.GmtModified = _ctx.StringValue("CreateOrGetVirtualLicenseOrder.GmtModified");
			createOrGetVirtualLicenseOrderResponse.IsVirtualOrder = _ctx.BooleanValue("CreateOrGetVirtualLicenseOrder.IsVirtualOrder");
			createOrGetVirtualLicenseOrderResponse.IsVirtualOrderFrozen = _ctx.BooleanValue("CreateOrGetVirtualLicenseOrder.IsVirtualOrderFrozen");
			createOrGetVirtualLicenseOrderResponse.PackageType = _ctx.StringValue("CreateOrGetVirtualLicenseOrder.PackageType");
			createOrGetVirtualLicenseOrderResponse.PackageValidity = _ctx.StringValue("CreateOrGetVirtualLicenseOrder.PackageValidity");
			createOrGetVirtualLicenseOrderResponse.PurchaseChannel = _ctx.StringValue("CreateOrGetVirtualLicenseOrder.PurchaseChannel");
			createOrGetVirtualLicenseOrderResponse.RequestId = _ctx.StringValue("CreateOrGetVirtualLicenseOrder.RequestId");
			createOrGetVirtualLicenseOrderResponse.VirtualOrderId = _ctx.StringValue("CreateOrGetVirtualLicenseOrder.VirtualOrderId");
        
			return createOrGetVirtualLicenseOrderResponse;
        }
    }
}
