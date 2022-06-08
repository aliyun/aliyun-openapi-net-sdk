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
        public static DescribeEslDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEslDevicesResponse describeEslDevicesResponse = new DescribeEslDevicesResponse();

			describeEslDevicesResponse.HttpResponse = _ctx.HttpResponse;
			describeEslDevicesResponse.RequestId = _ctx.StringValue("DescribeEslDevices.RequestId");
			describeEslDevicesResponse.ErrorMessage = _ctx.StringValue("DescribeEslDevices.ErrorMessage");
			describeEslDevicesResponse.Success = _ctx.BooleanValue("DescribeEslDevices.Success");
			describeEslDevicesResponse.ErrorCode = _ctx.StringValue("DescribeEslDevices.ErrorCode");
			describeEslDevicesResponse.Code = _ctx.StringValue("DescribeEslDevices.Code");
			describeEslDevicesResponse.Message = _ctx.StringValue("DescribeEslDevices.Message");
			describeEslDevicesResponse.DynamicMessage = _ctx.StringValue("DescribeEslDevices.DynamicMessage");
			describeEslDevicesResponse.PageNumber = _ctx.IntegerValue("DescribeEslDevices.PageNumber");
			describeEslDevicesResponse.PageSize = _ctx.IntegerValue("DescribeEslDevices.PageSize");
			describeEslDevicesResponse.TotalCount = _ctx.IntegerValue("DescribeEslDevices.TotalCount");
			describeEslDevicesResponse.DynamicCode = _ctx.StringValue("DescribeEslDevices.DynamicCode");

			List<DescribeEslDevicesResponse.DescribeEslDevices_EslDeviceInfo> describeEslDevicesResponse_eslDevices = new List<DescribeEslDevicesResponse.DescribeEslDevices_EslDeviceInfo>();
			for (int i = 0; i < _ctx.Length("DescribeEslDevices.EslDevices.Length"); i++) {
				DescribeEslDevicesResponse.DescribeEslDevices_EslDeviceInfo eslDeviceInfo = new DescribeEslDevicesResponse.DescribeEslDevices_EslDeviceInfo();
				eslDeviceInfo.Type = _ctx.StringValue("DescribeEslDevices.EslDevices["+ i +"].Type");
				eslDeviceInfo.StoreId = _ctx.StringValue("DescribeEslDevices.EslDevices["+ i +"].StoreId");
				eslDeviceInfo.EslBarCode = _ctx.StringValue("DescribeEslDevices.EslDevices["+ i +"].EslBarCode");
				eslDeviceInfo.Model = _ctx.StringValue("DescribeEslDevices.EslDevices["+ i +"].Model");
				eslDeviceInfo.LastCommunicateTime = _ctx.StringValue("DescribeEslDevices.EslDevices["+ i +"].LastCommunicateTime");
				eslDeviceInfo.ScreenHeight = _ctx.IntegerValue("DescribeEslDevices.EslDevices["+ i +"].ScreenHeight");
				eslDeviceInfo.ScreenWidth = _ctx.IntegerValue("DescribeEslDevices.EslDevices["+ i +"].ScreenWidth");
				eslDeviceInfo.EslSignal = _ctx.IntegerValue("DescribeEslDevices.EslDevices["+ i +"].EslSignal");
				eslDeviceInfo.BatteryLevel = _ctx.IntegerValue("DescribeEslDevices.EslDevices["+ i +"].BatteryLevel");
				eslDeviceInfo.EslStatus = _ctx.StringValue("DescribeEslDevices.EslDevices["+ i +"].EslStatus");
				eslDeviceInfo.Mac = _ctx.StringValue("DescribeEslDevices.EslDevices["+ i +"].Mac");
				eslDeviceInfo.TypeEncode = _ctx.StringValue("DescribeEslDevices.EslDevices["+ i +"].TypeEncode");

				describeEslDevicesResponse_eslDevices.Add(eslDeviceInfo);
			}
			describeEslDevicesResponse.EslDevices = describeEslDevicesResponse_eslDevices;
        
			return describeEslDevicesResponse;
        }
    }
}
