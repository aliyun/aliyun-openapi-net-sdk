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
    public class GetDeviceInfoResponseUnmarshaller
    {
        public static GetDeviceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDeviceInfoResponse getDeviceInfoResponse = new GetDeviceInfoResponse();

			getDeviceInfoResponse.HttpResponse = _ctx.HttpResponse;
			getDeviceInfoResponse.ErrorCode = _ctx.IntegerValue("GetDeviceInfo.ErrorCode");
			getDeviceInfoResponse.Message = _ctx.StringValue("GetDeviceInfo.Message");
			getDeviceInfoResponse.Success = _ctx.BooleanValue("GetDeviceInfo.Success");
			getDeviceInfoResponse.RequestId = _ctx.StringValue("GetDeviceInfo.RequestId");

			GetDeviceInfoResponse.GetDeviceInfo_Device device = new GetDeviceInfoResponse.GetDeviceInfo_Device();
			device.ActivationCode = _ctx.StringValue("GetDeviceInfo.Device.ActivationCode");
			device.CastScreenCode = _ctx.StringValue("GetDeviceInfo.Device.CastScreenCode");
			device.Sn = _ctx.StringValue("GetDeviceInfo.Device.Sn");
			device.Status = _ctx.IntegerValue("GetDeviceInfo.Device.Status");
			device.IP = _ctx.StringValue("GetDeviceInfo.Device.IP");
			device.Mac = _ctx.StringValue("GetDeviceInfo.Device.Mac");
			device.Ssid = _ctx.StringValue("GetDeviceInfo.Device.Ssid");
			getDeviceInfoResponse.Device = device;
        
			return getDeviceInfoResponse;
        }
    }
}
