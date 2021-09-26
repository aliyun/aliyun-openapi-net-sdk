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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribePurchasedDeviceResponseUnmarshaller
    {
        public static DescribePurchasedDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePurchasedDeviceResponse describePurchasedDeviceResponse = new DescribePurchasedDeviceResponse();

			describePurchasedDeviceResponse.HttpResponse = _ctx.HttpResponse;
			describePurchasedDeviceResponse.RequestId = _ctx.StringValue("DescribePurchasedDevice.RequestId");
			describePurchasedDeviceResponse.Id = _ctx.StringValue("DescribePurchasedDevice.Id");
			describePurchasedDeviceResponse.Name = _ctx.StringValue("DescribePurchasedDevice.Name");
			describePurchasedDeviceResponse.Description = _ctx.StringValue("DescribePurchasedDevice.Description");
			describePurchasedDeviceResponse.Type = _ctx.StringValue("DescribePurchasedDevice.Type");
			describePurchasedDeviceResponse.SubType = _ctx.StringValue("DescribePurchasedDevice.SubType");
			describePurchasedDeviceResponse.RegisterCode = _ctx.StringValue("DescribePurchasedDevice.RegisterCode");
			describePurchasedDeviceResponse.Vendor = _ctx.StringValue("DescribePurchasedDevice.Vendor");
			describePurchasedDeviceResponse.OrderId = _ctx.StringValue("DescribePurchasedDevice.OrderId");
			describePurchasedDeviceResponse.Region = _ctx.StringValue("DescribePurchasedDevice.Region");
			describePurchasedDeviceResponse.GroupId = _ctx.StringValue("DescribePurchasedDevice.GroupId");
			describePurchasedDeviceResponse.GroupName = _ctx.StringValue("DescribePurchasedDevice.GroupName");
			describePurchasedDeviceResponse.CreatedTime = _ctx.StringValue("DescribePurchasedDevice.CreatedTime");
        
			return describePurchasedDeviceResponse;
        }
    }
}
