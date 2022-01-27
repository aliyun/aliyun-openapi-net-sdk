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
    public class DescribeSslVpnServersResponseUnmarshaller
    {
        public static DescribeSslVpnServersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSslVpnServersResponse describeSslVpnServersResponse = new DescribeSslVpnServersResponse();

			describeSslVpnServersResponse.HttpResponse = _ctx.HttpResponse;
			describeSslVpnServersResponse.RequestId = _ctx.StringValue("DescribeSslVpnServers.RequestId");
			describeSslVpnServersResponse.TotalCount = _ctx.IntegerValue("DescribeSslVpnServers.TotalCount");
			describeSslVpnServersResponse.PageNumber = _ctx.IntegerValue("DescribeSslVpnServers.PageNumber");
			describeSslVpnServersResponse.PageSize = _ctx.IntegerValue("DescribeSslVpnServers.PageSize");

			List<DescribeSslVpnServersResponse.DescribeSslVpnServers_SslVpnServer> describeSslVpnServersResponse_sslVpnServers = new List<DescribeSslVpnServersResponse.DescribeSslVpnServers_SslVpnServer>();
			for (int i = 0; i < _ctx.Length("DescribeSslVpnServers.SslVpnServers.Length"); i++) {
				DescribeSslVpnServersResponse.DescribeSslVpnServers_SslVpnServer sslVpnServer = new DescribeSslVpnServersResponse.DescribeSslVpnServers_SslVpnServer();
				sslVpnServer.RegionId = _ctx.StringValue("DescribeSslVpnServers.SslVpnServers["+ i +"].RegionId");
				sslVpnServer.SslVpnServerId = _ctx.StringValue("DescribeSslVpnServers.SslVpnServers["+ i +"].SslVpnServerId");
				sslVpnServer.VpnGatewayId = _ctx.StringValue("DescribeSslVpnServers.SslVpnServers["+ i +"].VpnGatewayId");
				sslVpnServer.Name = _ctx.StringValue("DescribeSslVpnServers.SslVpnServers["+ i +"].Name");
				sslVpnServer.LocalSubnet = _ctx.StringValue("DescribeSslVpnServers.SslVpnServers["+ i +"].LocalSubnet");
				sslVpnServer.ClientIpPool = _ctx.StringValue("DescribeSslVpnServers.SslVpnServers["+ i +"].ClientIpPool");
				sslVpnServer.CreateTime = _ctx.LongValue("DescribeSslVpnServers.SslVpnServers["+ i +"].CreateTime");
				sslVpnServer.Cipher = _ctx.StringValue("DescribeSslVpnServers.SslVpnServers["+ i +"].Cipher");
				sslVpnServer.Proto = _ctx.StringValue("DescribeSslVpnServers.SslVpnServers["+ i +"].Proto");
				sslVpnServer.Port = _ctx.IntegerValue("DescribeSslVpnServers.SslVpnServers["+ i +"].Port");
				sslVpnServer.Compress = _ctx.BooleanValue("DescribeSslVpnServers.SslVpnServers["+ i +"].Compress");
				sslVpnServer.Connections = _ctx.IntegerValue("DescribeSslVpnServers.SslVpnServers["+ i +"].Connections");
				sslVpnServer.MaxConnections = _ctx.IntegerValue("DescribeSslVpnServers.SslVpnServers["+ i +"].MaxConnections");
				sslVpnServer.InternetIp = _ctx.StringValue("DescribeSslVpnServers.SslVpnServers["+ i +"].InternetIp");
				sslVpnServer.EnableMultiFactorAuth = _ctx.BooleanValue("DescribeSslVpnServers.SslVpnServers["+ i +"].EnableMultiFactorAuth");
				sslVpnServer.IDaaSInstanceId = _ctx.StringValue("DescribeSslVpnServers.SslVpnServers["+ i +"].IDaaSInstanceId");
				sslVpnServer.IDaaSRegionId = _ctx.StringValue("DescribeSslVpnServers.SslVpnServers["+ i +"].IDaaSRegionId");

				describeSslVpnServersResponse_sslVpnServers.Add(sslVpnServer);
			}
			describeSslVpnServersResponse.SslVpnServers = describeSslVpnServersResponse_sslVpnServers;
        
			return describeSslVpnServersResponse;
        }
    }
}
