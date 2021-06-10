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
    public class ModifySslVpnServerResponseUnmarshaller
    {
        public static ModifySslVpnServerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifySslVpnServerResponse modifySslVpnServerResponse = new ModifySslVpnServerResponse();

			modifySslVpnServerResponse.HttpResponse = _ctx.HttpResponse;
			modifySslVpnServerResponse.RequestId = _ctx.StringValue("ModifySslVpnServer.RequestId");
			modifySslVpnServerResponse.RegionId = _ctx.StringValue("ModifySslVpnServer.RegionId");
			modifySslVpnServerResponse.SslVpnServerId = _ctx.StringValue("ModifySslVpnServer.SslVpnServerId");
			modifySslVpnServerResponse.VpnGatewayId = _ctx.StringValue("ModifySslVpnServer.VpnGatewayId");
			modifySslVpnServerResponse.Name = _ctx.StringValue("ModifySslVpnServer.Name");
			modifySslVpnServerResponse.LocalSubnet = _ctx.StringValue("ModifySslVpnServer.LocalSubnet");
			modifySslVpnServerResponse.ClientIpPool = _ctx.StringValue("ModifySslVpnServer.ClientIpPool");
			modifySslVpnServerResponse.CreateTime = _ctx.LongValue("ModifySslVpnServer.CreateTime");
			modifySslVpnServerResponse.Cipher = _ctx.StringValue("ModifySslVpnServer.Cipher");
			modifySslVpnServerResponse.Proto = _ctx.StringValue("ModifySslVpnServer.Proto");
			modifySslVpnServerResponse.Port = _ctx.IntegerValue("ModifySslVpnServer.Port");
			modifySslVpnServerResponse.Compress = _ctx.BooleanValue("ModifySslVpnServer.Compress");
			modifySslVpnServerResponse.Connections = _ctx.IntegerValue("ModifySslVpnServer.Connections");
			modifySslVpnServerResponse.MaxConnections = _ctx.IntegerValue("ModifySslVpnServer.MaxConnections");
			modifySslVpnServerResponse.InternetIp = _ctx.StringValue("ModifySslVpnServer.InternetIp");
			modifySslVpnServerResponse.EnableMultiFactorAuth = _ctx.BooleanValue("ModifySslVpnServer.EnableMultiFactorAuth");
			modifySslVpnServerResponse.IDaaSInstanceId = _ctx.StringValue("ModifySslVpnServer.IDaaSInstanceId");
        
			return modifySslVpnServerResponse;
        }
    }
}
