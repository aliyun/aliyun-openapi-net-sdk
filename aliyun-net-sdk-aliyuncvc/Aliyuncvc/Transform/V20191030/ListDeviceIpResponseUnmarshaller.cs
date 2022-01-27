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
using Aliyun.Acs.aliyuncvc.Model.V20191030;

namespace Aliyun.Acs.aliyuncvc.Transform.V20191030
{
    public class ListDeviceIpResponseUnmarshaller
    {
        public static ListDeviceIpResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeviceIpResponse listDeviceIpResponse = new ListDeviceIpResponse();

			listDeviceIpResponse.HttpResponse = _ctx.HttpResponse;
			listDeviceIpResponse.ErrorCode = _ctx.IntegerValue("ListDeviceIp.ErrorCode");
			listDeviceIpResponse.Message = _ctx.StringValue("ListDeviceIp.Message");
			listDeviceIpResponse.Success = _ctx.BooleanValue("ListDeviceIp.Success");
			listDeviceIpResponse.RequestId = _ctx.StringValue("ListDeviceIp.RequestId");

			List<ListDeviceIpResponse.ListDeviceIp_DevicesItem> listDeviceIpResponse_devices = new List<ListDeviceIpResponse.ListDeviceIp_DevicesItem>();
			for (int i = 0; i < _ctx.Length("ListDeviceIp.Devices.Length"); i++) {
				ListDeviceIpResponse.ListDeviceIp_DevicesItem devicesItem = new ListDeviceIpResponse.ListDeviceIp_DevicesItem();
				devicesItem.ScreenCode = _ctx.StringValue("ListDeviceIp.Devices["+ i +"].ScreenCode");
				devicesItem.Ip = _ctx.StringValue("ListDeviceIp.Devices["+ i +"].Ip");
				devicesItem.Mac = _ctx.StringValue("ListDeviceIp.Devices["+ i +"].Mac");
				devicesItem.SsId = _ctx.StringValue("ListDeviceIp.Devices["+ i +"].SsId");

				listDeviceIpResponse_devices.Add(devicesItem);
			}
			listDeviceIpResponse.Devices = listDeviceIpResponse_devices;
        
			return listDeviceIpResponse;
        }
    }
}
