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
    public class ListIpsecServersResponseUnmarshaller
    {
        public static ListIpsecServersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIpsecServersResponse listIpsecServersResponse = new ListIpsecServersResponse();

			listIpsecServersResponse.HttpResponse = _ctx.HttpResponse;
			listIpsecServersResponse.RequestId = _ctx.StringValue("ListIpsecServers.RequestId");
			listIpsecServersResponse.NextToken = _ctx.StringValue("ListIpsecServers.NextToken");
			listIpsecServersResponse.MaxResults = _ctx.IntegerValue("ListIpsecServers.MaxResults");
			listIpsecServersResponse.TotalCount = _ctx.IntegerValue("ListIpsecServers.TotalCount");

			List<ListIpsecServersResponse.ListIpsecServers_IpsecServer> listIpsecServersResponse_ipsecServers = new List<ListIpsecServersResponse.ListIpsecServers_IpsecServer>();
			for (int i = 0; i < _ctx.Length("ListIpsecServers.IpsecServers.Length"); i++) {
				ListIpsecServersResponse.ListIpsecServers_IpsecServer ipsecServer = new ListIpsecServersResponse.ListIpsecServers_IpsecServer();
				ipsecServer.RegionId = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].RegionId");
				ipsecServer.IpsecServerId = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IpsecServerId");
				ipsecServer.IpsecServerName = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IpsecServerName");
				ipsecServer.VpnGatewayId = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].VpnGatewayId");
				ipsecServer.LocalSubnet = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].LocalSubnet");
				ipsecServer.ClientIpPool = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].ClientIpPool");
				ipsecServer.EffectImmediately = _ctx.BooleanValue("ListIpsecServers.IpsecServers["+ i +"].EffectImmediately");
				ipsecServer.PskEnabled = _ctx.BooleanValue("ListIpsecServers.IpsecServers["+ i +"].PskEnabled");
				ipsecServer.MultiFactorAuthEnabled = _ctx.BooleanValue("ListIpsecServers.IpsecServers["+ i +"].MultiFactorAuthEnabled");
				ipsecServer.Psk = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].Psk");
				ipsecServer.IDaaSInstanceId = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IDaaSInstanceId");
				ipsecServer.OnlineClientCount = _ctx.IntegerValue("ListIpsecServers.IpsecServers["+ i +"].OnlineClientCount");
				ipsecServer.MaxConnections = _ctx.IntegerValue("ListIpsecServers.IpsecServers["+ i +"].MaxConnections");
				ipsecServer.CreationTime = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].CreationTime");
				ipsecServer.InternetIp = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].InternetIp");

				ListIpsecServersResponse.ListIpsecServers_IpsecServer.ListIpsecServers_IkeConfig ikeConfig = new ListIpsecServersResponse.ListIpsecServers_IpsecServer.ListIpsecServers_IkeConfig();
				ikeConfig.IkeVersion = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.IkeVersion");
				ikeConfig.IkeMode = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.IkeMode");
				ikeConfig.IkeEncAlg = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.IkeEncAlg");
				ikeConfig.IkeAuthAlg = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.IkeAuthAlg");
				ikeConfig.IkePfs = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.IkePfs");
				ikeConfig.IkeLifetime = _ctx.LongValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.IkeLifetime");
				ikeConfig.LocalId = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.LocalId");
				ikeConfig.RemoteId = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.RemoteId");
				ipsecServer.IkeConfig = ikeConfig;

				ListIpsecServersResponse.ListIpsecServers_IpsecServer.ListIpsecServers_IpsecConfig ipsecConfig = new ListIpsecServersResponse.ListIpsecServers_IpsecServer.ListIpsecServers_IpsecConfig();
				ipsecConfig.IpsecEncAlg = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IpsecConfig.IpsecEncAlg");
				ipsecConfig.IpsecAuthAlg = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IpsecConfig.IpsecAuthAlg");
				ipsecConfig.IpsecPfs = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IpsecConfig.IpsecPfs");
				ipsecConfig.IpsecLifetime = _ctx.LongValue("ListIpsecServers.IpsecServers["+ i +"].IpsecConfig.IpsecLifetime");
				ipsecServer.IpsecConfig = ipsecConfig;

				listIpsecServersResponse_ipsecServers.Add(ipsecServer);
			}
			listIpsecServersResponse.IpsecServers = listIpsecServersResponse_ipsecServers;
        
			return listIpsecServersResponse;
        }
    }
}
