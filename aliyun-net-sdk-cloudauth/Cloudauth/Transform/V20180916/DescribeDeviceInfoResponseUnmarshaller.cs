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
using Aliyun.Acs.Cloudauth.Model.V20180916;

namespace Aliyun.Acs.Cloudauth.Transform.V20180916
{
    public class DescribeDeviceInfoResponseUnmarshaller
    {
        public static DescribeDeviceInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDeviceInfoResponse describeDeviceInfoResponse = new DescribeDeviceInfoResponse();

			describeDeviceInfoResponse.HttpResponse = context.HttpResponse;
			describeDeviceInfoResponse.RequestId = context.StringValue("DescribeDeviceInfo.RequestId");
			describeDeviceInfoResponse.PageSize = context.IntegerValue("DescribeDeviceInfo.PageSize");
			describeDeviceInfoResponse.CurrentPage = context.IntegerValue("DescribeDeviceInfo.CurrentPage");
			describeDeviceInfoResponse.TotalCount = context.IntegerValue("DescribeDeviceInfo.TotalCount");

			List<DescribeDeviceInfoResponse.DescribeDeviceInfo_DeviceInfo> describeDeviceInfoResponse_deviceInfoList = new List<DescribeDeviceInfoResponse.DescribeDeviceInfo_DeviceInfo>();
			for (int i = 0; i < context.Length("DescribeDeviceInfo.DeviceInfoList.Length"); i++) {
				DescribeDeviceInfoResponse.DescribeDeviceInfo_DeviceInfo deviceInfo = new DescribeDeviceInfoResponse.DescribeDeviceInfo_DeviceInfo();
				deviceInfo.DeviceId = context.StringValue("DescribeDeviceInfo.DeviceInfoList["+ i +"].DeviceId");
				deviceInfo.UserDeviceId = context.StringValue("DescribeDeviceInfo.DeviceInfoList["+ i +"].UserDeviceId");
				deviceInfo.BizType = context.StringValue("DescribeDeviceInfo.DeviceInfoList["+ i +"].BizType");
				deviceInfo.BeginDay = context.StringValue("DescribeDeviceInfo.DeviceInfoList["+ i +"].BeginDay");
				deviceInfo.ExpiredDay = context.StringValue("DescribeDeviceInfo.DeviceInfoList["+ i +"].ExpiredDay");

				describeDeviceInfoResponse_deviceInfoList.Add(deviceInfo);
			}
			describeDeviceInfoResponse.DeviceInfoList = describeDeviceInfoResponse_deviceInfoList;
        
			return describeDeviceInfoResponse;
        }
    }
}
