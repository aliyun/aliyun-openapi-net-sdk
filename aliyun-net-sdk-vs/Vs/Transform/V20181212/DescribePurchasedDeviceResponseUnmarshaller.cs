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
        public static DescribePurchasedDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePurchasedDeviceResponse describePurchasedDeviceResponse = new DescribePurchasedDeviceResponse();

			describePurchasedDeviceResponse.HttpResponse = context.HttpResponse;
			describePurchasedDeviceResponse.RequestId = context.StringValue("DescribePurchasedDevice.RequestId");
			describePurchasedDeviceResponse.Id = context.StringValue("DescribePurchasedDevice.Id");
			describePurchasedDeviceResponse.Name = context.StringValue("DescribePurchasedDevice.Name");
			describePurchasedDeviceResponse.Description = context.StringValue("DescribePurchasedDevice.Description");
			describePurchasedDeviceResponse.Type = context.StringValue("DescribePurchasedDevice.Type");
			describePurchasedDeviceResponse.SubType = context.StringValue("DescribePurchasedDevice.SubType");
			describePurchasedDeviceResponse.RegisterCode = context.StringValue("DescribePurchasedDevice.RegisterCode");
			describePurchasedDeviceResponse.Vendor = context.StringValue("DescribePurchasedDevice.Vendor");
			describePurchasedDeviceResponse.OrderId = context.StringValue("DescribePurchasedDevice.OrderId");
			describePurchasedDeviceResponse.Region = context.StringValue("DescribePurchasedDevice.Region");
			describePurchasedDeviceResponse.GroupId = context.StringValue("DescribePurchasedDevice.GroupId");
			describePurchasedDeviceResponse.GroupName = context.StringValue("DescribePurchasedDevice.GroupName");
			describePurchasedDeviceResponse.CreatedTime = context.StringValue("DescribePurchasedDevice.CreatedTime");
        
			return describePurchasedDeviceResponse;
        }
    }
}
