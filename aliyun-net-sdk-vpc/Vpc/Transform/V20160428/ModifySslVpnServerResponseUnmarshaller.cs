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
        public static ModifySslVpnServerResponse Unmarshall(UnmarshallerContext context)
        {
			ModifySslVpnServerResponse modifySslVpnServerResponse = new ModifySslVpnServerResponse();

			modifySslVpnServerResponse.HttpResponse = context.HttpResponse;
			modifySslVpnServerResponse.RequestId = context.StringValue("ModifySslVpnServer.RequestId");
			modifySslVpnServerResponse.RegionId = context.StringValue("ModifySslVpnServer.RegionId");
			modifySslVpnServerResponse.SslVpnServerId = context.StringValue("ModifySslVpnServer.SslVpnServerId");
			modifySslVpnServerResponse.VpnGatewayId = context.StringValue("ModifySslVpnServer.VpnGatewayId");
			modifySslVpnServerResponse.Name = context.StringValue("ModifySslVpnServer.Name");
			modifySslVpnServerResponse.LocalSubnet = context.StringValue("ModifySslVpnServer.LocalSubnet");
			modifySslVpnServerResponse.ClientIpPool = context.StringValue("ModifySslVpnServer.ClientIpPool");
			modifySslVpnServerResponse.CreateTime = context.LongValue("ModifySslVpnServer.CreateTime");
			modifySslVpnServerResponse.Cipher = context.StringValue("ModifySslVpnServer.Cipher");
			modifySslVpnServerResponse.Proto = context.StringValue("ModifySslVpnServer.Proto");
			modifySslVpnServerResponse.Port = context.IntegerValue("ModifySslVpnServer.Port");
			modifySslVpnServerResponse.Compress = context.BooleanValue("ModifySslVpnServer.Compress");
			modifySslVpnServerResponse.Connections = context.IntegerValue("ModifySslVpnServer.Connections");
			modifySslVpnServerResponse.MaxConnections = context.IntegerValue("ModifySslVpnServer.MaxConnections");
			modifySslVpnServerResponse.InternetIp = context.StringValue("ModifySslVpnServer.InternetIp");
        
			return modifySslVpnServerResponse;
        }
    }
}
