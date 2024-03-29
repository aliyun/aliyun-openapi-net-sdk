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
			modifySslVpnServerResponse.InternetIp = _ctx.StringValue("ModifySslVpnServer.InternetIp");
			modifySslVpnServerResponse.IDaaSInstanceId = _ctx.StringValue("ModifySslVpnServer.IDaaSInstanceId");
			modifySslVpnServerResponse.CreateTime = _ctx.LongValue("ModifySslVpnServer.CreateTime");
			modifySslVpnServerResponse.VpnGatewayId = _ctx.StringValue("ModifySslVpnServer.VpnGatewayId");
			modifySslVpnServerResponse.Compress = _ctx.BooleanValue("ModifySslVpnServer.Compress");
			modifySslVpnServerResponse.Port = _ctx.IntegerValue("ModifySslVpnServer.Port");
			modifySslVpnServerResponse.LocalSubnet = _ctx.StringValue("ModifySslVpnServer.LocalSubnet");
			modifySslVpnServerResponse.RegionId = _ctx.StringValue("ModifySslVpnServer.RegionId");
			modifySslVpnServerResponse.Cipher = _ctx.StringValue("ModifySslVpnServer.Cipher");
			modifySslVpnServerResponse.RequestId = _ctx.StringValue("ModifySslVpnServer.RequestId");
			modifySslVpnServerResponse.Connections = _ctx.IntegerValue("ModifySslVpnServer.Connections");
			modifySslVpnServerResponse.SslVpnServerId = _ctx.StringValue("ModifySslVpnServer.SslVpnServerId");
			modifySslVpnServerResponse.MaxConnections = _ctx.IntegerValue("ModifySslVpnServer.MaxConnections");
			modifySslVpnServerResponse.Name = _ctx.StringValue("ModifySslVpnServer.Name");
			modifySslVpnServerResponse.EnableMultiFactorAuth = _ctx.BooleanValue("ModifySslVpnServer.EnableMultiFactorAuth");
			modifySslVpnServerResponse.ClientIpPool = _ctx.StringValue("ModifySslVpnServer.ClientIpPool");
			modifySslVpnServerResponse.Proto = _ctx.StringValue("ModifySslVpnServer.Proto");
        
			return modifySslVpnServerResponse;
        }
    }
}
