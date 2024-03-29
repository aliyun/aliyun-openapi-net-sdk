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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class CreateIpsecServerResponseUnmarshaller
    {
        public static CreateIpsecServerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateIpsecServerResponse createIpsecServerResponse = new CreateIpsecServerResponse();

			createIpsecServerResponse.HttpResponse = _ctx.HttpResponse;
			createIpsecServerResponse.CreationTime = _ctx.StringValue("CreateIpsecServer.CreationTime");
			createIpsecServerResponse.IpsecServerId = _ctx.StringValue("CreateIpsecServer.IpsecServerId");
			createIpsecServerResponse.RequestId = _ctx.StringValue("CreateIpsecServer.RequestId");
			createIpsecServerResponse.IpsecServerName = _ctx.StringValue("CreateIpsecServer.IpsecServerName");
			createIpsecServerResponse.VpnGatewayId = _ctx.StringValue("CreateIpsecServer.VpnGatewayId");
			createIpsecServerResponse.RegionId = _ctx.StringValue("CreateIpsecServer.RegionId");
        
			return createIpsecServerResponse;
        }
    }
}
