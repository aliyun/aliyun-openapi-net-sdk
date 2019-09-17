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
        public static GetGatewayBySubDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			GetGatewayBySubDeviceResponse getGatewayBySubDeviceResponse = new GetGatewayBySubDeviceResponse();

			getGatewayBySubDeviceResponse.HttpResponse = context.HttpResponse;
			getGatewayBySubDeviceResponse.RequestId = context.StringValue("GetGatewayBySubDevice.RequestId");
			getGatewayBySubDeviceResponse.Success = context.BooleanValue("GetGatewayBySubDevice.Success");
			getGatewayBySubDeviceResponse.Code = context.StringValue("GetGatewayBySubDevice.Code");
			getGatewayBySubDeviceResponse.ErrorMessage = context.StringValue("GetGatewayBySubDevice.ErrorMessage");

			GetGatewayBySubDeviceResponse.GetGatewayBySubDevice_Data data = new GetGatewayBySubDeviceResponse.GetGatewayBySubDevice_Data();
			data.ProductKey = context.StringValue("GetGatewayBySubDevice.Data.ProductKey");
			data.ProductName = context.StringValue("GetGatewayBySubDevice.Data.ProductName");
			data.DeviceSecret = context.StringValue("GetGatewayBySubDevice.Data.DeviceSecret");
			data.DeviceName = context.StringValue("GetGatewayBySubDevice.Data.DeviceName");
			data.FirmwareVersion = context.StringValue("GetGatewayBySubDevice.Data.FirmwareVersion");
			data.GmtCreate = context.StringValue("GetGatewayBySubDevice.Data.GmtCreate");
			data.UtcCreate = context.StringValue("GetGatewayBySubDevice.Data.UtcCreate");
			data.GmtActive = context.StringValue("GetGatewayBySubDevice.Data.GmtActive");
			data.UtcActive = context.StringValue("GetGatewayBySubDevice.Data.UtcActive");
			data.GmtOnline = context.StringValue("GetGatewayBySubDevice.Data.GmtOnline");
			data.UtcOnline = context.StringValue("GetGatewayBySubDevice.Data.UtcOnline");
			data.Status = context.StringValue("GetGatewayBySubDevice.Data.Status");
			data.IpAddress = context.StringValue("GetGatewayBySubDevice.Data.IpAddress");
			data.NodeType = context.StringValue("GetGatewayBySubDevice.Data.NodeType");
			data.Region = context.StringValue("GetGatewayBySubDevice.Data.region");
			data.IotId = context.StringValue("GetGatewayBySubDevice.Data.iotId");
			getGatewayBySubDeviceResponse.Data = data;
        
			return getGatewayBySubDeviceResponse;
        }
    }
}
