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
    public class CreateDeviceTunnelResponseUnmarshaller
    {
        public static CreateDeviceTunnelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateDeviceTunnelResponse createDeviceTunnelResponse = new CreateDeviceTunnelResponse();

			createDeviceTunnelResponse.HttpResponse = _ctx.HttpResponse;
			createDeviceTunnelResponse.RequestId = _ctx.StringValue("CreateDeviceTunnel.RequestId");
			createDeviceTunnelResponse.Success = _ctx.BooleanValue("CreateDeviceTunnel.Success");
			createDeviceTunnelResponse.Code = _ctx.StringValue("CreateDeviceTunnel.Code");
			createDeviceTunnelResponse.ErrorMessage = _ctx.StringValue("CreateDeviceTunnel.ErrorMessage");

			CreateDeviceTunnelResponse.CreateDeviceTunnel_Data data = new CreateDeviceTunnelResponse.CreateDeviceTunnel_Data();
			data.TunnelId = _ctx.StringValue("CreateDeviceTunnel.Data.TunnelId");
			data.SourceAccessToken = _ctx.StringValue("CreateDeviceTunnel.Data.SourceAccessToken");
			data.SourceURI = _ctx.StringValue("CreateDeviceTunnel.Data.SourceURI");
			createDeviceTunnelResponse.Data = data;
        
			return createDeviceTunnelResponse;
        }
    }
}
