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
using Aliyun.Acs.cloudesl.Model.V20180801;

namespace Aliyun.Acs.cloudesl.Transform.V20180801
{
    public class DescribeEslDevicesResponseUnmarshaller
    {
        public static DescribeEslDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEslDevicesResponse describeEslDevicesResponse = new DescribeEslDevicesResponse();

			describeEslDevicesResponse.HttpResponse = context.HttpResponse;
			describeEslDevicesResponse.RequestId = context.StringValue("DescribeEslDevices.RequestId");
			describeEslDevicesResponse.Success = context.BooleanValue("DescribeEslDevices.Success");
			describeEslDevicesResponse.Message = context.StringValue("DescribeEslDevices.Message");
			describeEslDevicesResponse.ErrorCode = context.StringValue("DescribeEslDevices.ErrorCode");
			describeEslDevicesResponse.TotalCount = context.IntegerValue("DescribeEslDevices.TotalCount");
			describeEslDevicesResponse.PageNumber = context.IntegerValue("DescribeEslDevices.PageNumber");
			describeEslDevicesResponse.PageSize = context.IntegerValue("DescribeEslDevices.PageSize");

			List<DescribeEslDevicesResponse.DescribeEslDevices_EslDeviceInfo> describeEslDevicesResponse_eslDevices = new List<DescribeEslDevicesResponse.DescribeEslDevices_EslDeviceInfo>();
			for (int i = 0; i < context.Length("DescribeEslDevices.EslDevices.Length"); i++) {
				DescribeEslDevicesResponse.DescribeEslDevices_EslDeviceInfo eslDeviceInfo = new DescribeEslDevicesResponse.DescribeEslDevices_EslDeviceInfo();
				eslDeviceInfo.CompanyId = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].CompanyId");
				eslDeviceInfo.StoreId = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].StoreId");
				eslDeviceInfo.Mac = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].Mac");
				eslDeviceInfo.EslBarCode = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].EslBarCode");
				eslDeviceInfo.ItemBarCode = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].ItemBarCode");
				eslDeviceInfo.Vendor = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].Vendor");
				eslDeviceInfo.ConnectAp = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].ConnectAp");
				eslDeviceInfo.Type = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].Type");
				eslDeviceInfo.Model = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].Model");
				eslDeviceInfo.BeBind = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].BeBind");
				eslDeviceInfo.ScreenWidth = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].ScreenWidth");
				eslDeviceInfo.ScreenHeight = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].ScreenHeight");
				eslDeviceInfo.LastCommunicateTime = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].LastCommunicateTime");
				eslDeviceInfo.BatteryLevel = context.IntegerValue("DescribeEslDevices.EslDevices["+ i +"].BatteryLevel");
				eslDeviceInfo.EslStatus = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].EslStatus");
				eslDeviceInfo.ShelfCode = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].ShelfCode");
				eslDeviceInfo.PositionCode = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].PositionCode");
				eslDeviceInfo.ItemId = context.LongValue("DescribeEslDevices.EslDevices["+ i +"].ItemId");
				eslDeviceInfo.ItemTitle = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].ItemTitle");
				eslDeviceInfo.ItemActionPrice = context.IntegerValue("DescribeEslDevices.EslDevices["+ i +"].ItemActionPrice");
				eslDeviceInfo.ItemPriceUnit = context.StringValue("DescribeEslDevices.EslDevices["+ i +"].ItemPriceUnit");

				describeEslDevicesResponse_eslDevices.Add(eslDeviceInfo);
			}
			describeEslDevicesResponse.EslDevices = describeEslDevicesResponse_eslDevices;
        
			return describeEslDevicesResponse;
        }
    }
}
