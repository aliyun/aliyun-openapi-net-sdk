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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeEslDevicesResponseUnmarshaller
    {
        public static DescribeEslDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEslDevicesResponse describeEslDevicesResponse = new DescribeEslDevicesResponse();

			describeEslDevicesResponse.HttpResponse = context.HttpResponse;
			describeEslDevicesResponse.ErrorMessage = context.StringValue("DescribeEslDevices.ErrorMessage");
			describeEslDevicesResponse.ErrorCode = context.StringValue("DescribeEslDevices.ErrorCode");
			describeEslDevicesResponse.PageSize = context.IntegerValue("DescribeEslDevices.PageSize");
			describeEslDevicesResponse.Message = context.StringValue("DescribeEslDevices.Message");
			describeEslDevicesResponse.TotalCount = context.IntegerValue("DescribeEslDevices.TotalCount");
			describeEslDevicesResponse.DynamicCode = context.StringValue("DescribeEslDevices.DynamicCode");
			describeEslDevicesResponse.Code = context.StringValue("DescribeEslDevices.Code");
			describeEslDevicesResponse.PageNumber = context.IntegerValue("DescribeEslDevices.PageNumber");
			describeEslDevicesResponse.DynamicMessage = context.StringValue("DescribeEslDevices.DynamicMessage");
			describeEslDevicesResponse.RequestId = context.StringValue("DescribeEslDevices.RequestId");
			describeEslDevicesResponse.Success = context.BooleanValue("DescribeEslDevices.Success");

			List<DescribeEslDevicesResponse.DescribeEslDevices_EslDeviceInfo> describeEslDevicesResponse_eslDevices = new List<DescribeEslDevicesResponse.DescribeEslDevices_EslDeviceInfo>();
			for (int i = 0; i < context.Length("DescribeEslDevices.EslDevices.Length"); i++) {
				DescribeEslDevicesResponse.DescribeEslDevices_EslDeviceInfo eslDeviceInfo = new DescribeEslDevicesResponse.DescribeEslDevices_EslDeviceInfo();
				eslDeviceInfo.LastCommunicateTime = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].LastCommunicateTime");
				eslDeviceInfo.Model = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].Model");
				eslDeviceInfo.EslStatus = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].EslStatus");
				eslDeviceInfo.StoreId = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].StoreId");
				eslDeviceInfo.EslBarCode = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].EslBarCode");
				eslDeviceInfo.Type = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].Type");
				eslDeviceInfo.Mac = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].Mac");
				eslDeviceInfo.BatteryLevel = context.IntegerValue("DescribeEslDevices.EslDevices["+ i +"].BatteryLevel");
				eslDeviceInfo.ScreenWidth = context.IntegerValue("DescribeEslDevices.EslDevices["+ i +"].ScreenWidth");
				eslDeviceInfo.ScreenHeight = context.IntegerValue("DescribeEslDevices.EslDevices["+ i +"].ScreenHeight");

				describeEslDevicesResponse_eslDevices.Add(eslDeviceInfo);
			}
			describeEslDevicesResponse.EslDevices = describeEslDevicesResponse_eslDevices;
        
			return describeEslDevicesResponse;
        }
    }
}
