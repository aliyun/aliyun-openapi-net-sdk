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
    public class GetDeviceTunnelShareStatusResponseUnmarshaller
    {
        public static GetDeviceTunnelShareStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDeviceTunnelShareStatusResponse getDeviceTunnelShareStatusResponse = new GetDeviceTunnelShareStatusResponse();

			getDeviceTunnelShareStatusResponse.HttpResponse = _ctx.HttpResponse;
			getDeviceTunnelShareStatusResponse.RequestId = _ctx.StringValue("GetDeviceTunnelShareStatus.RequestId");
			getDeviceTunnelShareStatusResponse.Success = _ctx.BooleanValue("GetDeviceTunnelShareStatus.Success");
			getDeviceTunnelShareStatusResponse.ErrorMessage = _ctx.StringValue("GetDeviceTunnelShareStatus.ErrorMessage");
			getDeviceTunnelShareStatusResponse.Code = _ctx.StringValue("GetDeviceTunnelShareStatus.Code");

			GetDeviceTunnelShareStatusResponse.GetDeviceTunnelShareStatus_Data data = new GetDeviceTunnelShareStatusResponse.GetDeviceTunnelShareStatus_Data();
			data.ShareId = _ctx.StringValue("GetDeviceTunnelShareStatus.Data.ShareId");
			data.Password = _ctx.StringValue("GetDeviceTunnelShareStatus.Data.Password");
			data.IsOpen = _ctx.BooleanValue("GetDeviceTunnelShareStatus.Data.IsOpen");
			data.GmtOpened = _ctx.LongValue("GetDeviceTunnelShareStatus.Data.GmtOpened");
			getDeviceTunnelShareStatusResponse.Data = data;
        
			return getDeviceTunnelShareStatusResponse;
        }
    }
}
