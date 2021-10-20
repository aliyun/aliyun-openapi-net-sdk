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
    public class QueryDeviceTunnelResponseUnmarshaller
    {
        public static QueryDeviceTunnelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceTunnelResponse queryDeviceTunnelResponse = new QueryDeviceTunnelResponse();

			queryDeviceTunnelResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceTunnelResponse.RequestId = _ctx.StringValue("QueryDeviceTunnel.RequestId");
			queryDeviceTunnelResponse.Success = _ctx.BooleanValue("QueryDeviceTunnel.Success");
			queryDeviceTunnelResponse.Code = _ctx.StringValue("QueryDeviceTunnel.Code");
			queryDeviceTunnelResponse.ErrorMessage = _ctx.StringValue("QueryDeviceTunnel.ErrorMessage");

			QueryDeviceTunnelResponse.QueryDeviceTunnel_Data data = new QueryDeviceTunnelResponse.QueryDeviceTunnel_Data();
			data.TunnelId = _ctx.StringValue("QueryDeviceTunnel.Data.TunnelId");
			data.TunnelState = _ctx.StringValue("QueryDeviceTunnel.Data.TunnelState");
			data.ProductKey = _ctx.StringValue("QueryDeviceTunnel.Data.ProductKey");
			data.DeviceName = _ctx.StringValue("QueryDeviceTunnel.Data.DeviceName");
			data.IotId = _ctx.StringValue("QueryDeviceTunnel.Data.IotId");
			data.DeviceConnState = _ctx.StringValue("QueryDeviceTunnel.Data.DeviceConnState");
			data.SourceConnState = _ctx.StringValue("QueryDeviceTunnel.Data.SourceConnState");
			data.Udi = _ctx.StringValue("QueryDeviceTunnel.Data.Udi");
			data.Description = _ctx.StringValue("QueryDeviceTunnel.Data.Description");
			data.UtcCreated = _ctx.StringValue("QueryDeviceTunnel.Data.UtcCreated");
			data.UtcClosed = _ctx.StringValue("QueryDeviceTunnel.Data.UtcClosed");
			data.ProductName = _ctx.StringValue("QueryDeviceTunnel.Data.ProductName");
			queryDeviceTunnelResponse.Data = data;
        
			return queryDeviceTunnelResponse;
        }
    }
}
