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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class GetGatewayBySubDeviceResponseUnmarshaller
    {
        public static GetGatewayBySubDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetGatewayBySubDeviceResponse getGatewayBySubDeviceResponse = new GetGatewayBySubDeviceResponse();

			getGatewayBySubDeviceResponse.HttpResponse = _ctx.HttpResponse;
			getGatewayBySubDeviceResponse.RequestId = _ctx.StringValue("GetGatewayBySubDevice.RequestId");
			getGatewayBySubDeviceResponse.Success = _ctx.BooleanValue("GetGatewayBySubDevice.Success");
			getGatewayBySubDeviceResponse.Code = _ctx.StringValue("GetGatewayBySubDevice.Code");
			getGatewayBySubDeviceResponse.ErrorMessage = _ctx.StringValue("GetGatewayBySubDevice.ErrorMessage");

			GetGatewayBySubDeviceResponse.GetGatewayBySubDevice_Data data = new GetGatewayBySubDeviceResponse.GetGatewayBySubDevice_Data();
			data.ProductKey = _ctx.StringValue("GetGatewayBySubDevice.Data.ProductKey");
			data.ProductName = _ctx.StringValue("GetGatewayBySubDevice.Data.ProductName");
			data.DeviceSecret = _ctx.StringValue("GetGatewayBySubDevice.Data.DeviceSecret");
			data.DeviceName = _ctx.StringValue("GetGatewayBySubDevice.Data.DeviceName");
			data.FirmwareVersion = _ctx.StringValue("GetGatewayBySubDevice.Data.FirmwareVersion");
			data.GmtCreate = _ctx.StringValue("GetGatewayBySubDevice.Data.GmtCreate");
			data.UtcCreate = _ctx.StringValue("GetGatewayBySubDevice.Data.UtcCreate");
			data.GmtActive = _ctx.StringValue("GetGatewayBySubDevice.Data.GmtActive");
			data.UtcActive = _ctx.StringValue("GetGatewayBySubDevice.Data.UtcActive");
			data.GmtOnline = _ctx.StringValue("GetGatewayBySubDevice.Data.GmtOnline");
			data.UtcOnline = _ctx.StringValue("GetGatewayBySubDevice.Data.UtcOnline");
			data.Status = _ctx.StringValue("GetGatewayBySubDevice.Data.Status");
			data.IpAddress = _ctx.StringValue("GetGatewayBySubDevice.Data.IpAddress");
			data.NodeType = _ctx.StringValue("GetGatewayBySubDevice.Data.NodeType");
			data.Region = _ctx.StringValue("GetGatewayBySubDevice.Data.region");
			data.IotId = _ctx.StringValue("GetGatewayBySubDevice.Data.iotId");
			getGatewayBySubDeviceResponse.Data = data;
        
			return getGatewayBySubDeviceResponse;
        }
    }
}
