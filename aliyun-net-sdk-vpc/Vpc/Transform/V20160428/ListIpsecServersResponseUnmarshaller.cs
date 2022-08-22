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
			listIpsecServersResponse.NextToken = _ctx.StringValue("ListIpsecServers.NextToken");
			listIpsecServersResponse.RequestId = _ctx.StringValue("ListIpsecServers.RequestId");
			listIpsecServersResponse.TotalCount = _ctx.IntegerValue("ListIpsecServers.TotalCount");
			listIpsecServersResponse.MaxResults = _ctx.IntegerValue("ListIpsecServers.MaxResults");

			List<ListIpsecServersResponse.ListIpsecServers_IpsecServer> listIpsecServersResponse_ipsecServers = new List<ListIpsecServersResponse.ListIpsecServers_IpsecServer>();
			for (int i = 0; i < _ctx.Length("ListIpsecServers.IpsecServers.Length"); i++) {
				ListIpsecServersResponse.ListIpsecServers_IpsecServer ipsecServer = new ListIpsecServersResponse.ListIpsecServers_IpsecServer();
				ipsecServer.CreationTime = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].CreationTime");
				ipsecServer.OnlineClientCount = _ctx.IntegerValue("ListIpsecServers.IpsecServers["+ i +"].OnlineClientCount");
				ipsecServer.InternetIp = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].InternetIp");
				ipsecServer.IpsecServerName = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IpsecServerName");
				ipsecServer.IDaaSInstanceId = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IDaaSInstanceId");
				ipsecServer.EffectImmediately = _ctx.BooleanValue("ListIpsecServers.IpsecServers["+ i +"].EffectImmediately");
				ipsecServer.VpnGatewayId = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].VpnGatewayId");
				ipsecServer.LocalSubnet = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].LocalSubnet");
				ipsecServer.Psk = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].Psk");
				ipsecServer.RegionId = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].RegionId");
				ipsecServer.PskEnabled = _ctx.BooleanValue("ListIpsecServers.IpsecServers["+ i +"].PskEnabled");
				ipsecServer.IpsecServerId = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IpsecServerId");
				ipsecServer.MultiFactorAuthEnabled = _ctx.BooleanValue("ListIpsecServers.IpsecServers["+ i +"].MultiFactorAuthEnabled");
				ipsecServer.MaxConnections = _ctx.IntegerValue("ListIpsecServers.IpsecServers["+ i +"].MaxConnections");
				ipsecServer.ClientIpPool = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].ClientIpPool");

				ListIpsecServersResponse.ListIpsecServers_IpsecServer.ListIpsecServers_IkeConfig ikeConfig = new ListIpsecServersResponse.ListIpsecServers_IpsecServer.ListIpsecServers_IkeConfig();
				ikeConfig.RemoteId = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.RemoteId");
				ikeConfig.IkeLifetime = _ctx.LongValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.IkeLifetime");
				ikeConfig.IkeEncAlg = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.IkeEncAlg");
				ikeConfig.LocalId = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.LocalId");
				ikeConfig.IkeMode = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.IkeMode");
				ikeConfig.IkeVersion = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.IkeVersion");
				ikeConfig.IkePfs = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.IkePfs");
				ikeConfig.IkeAuthAlg = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IkeConfig.IkeAuthAlg");
				ipsecServer.IkeConfig = ikeConfig;

				ListIpsecServersResponse.ListIpsecServers_IpsecServer.ListIpsecServers_IpsecConfig ipsecConfig = new ListIpsecServersResponse.ListIpsecServers_IpsecServer.ListIpsecServers_IpsecConfig();
				ipsecConfig.IpsecAuthAlg = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IpsecConfig.IpsecAuthAlg");
				ipsecConfig.IpsecLifetime = _ctx.LongValue("ListIpsecServers.IpsecServers["+ i +"].IpsecConfig.IpsecLifetime");
				ipsecConfig.IpsecEncAlg = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IpsecConfig.IpsecEncAlg");
				ipsecConfig.IpsecPfs = _ctx.StringValue("ListIpsecServers.IpsecServers["+ i +"].IpsecConfig.IpsecPfs");
				ipsecServer.IpsecConfig = ipsecConfig;

				listIpsecServersResponse_ipsecServers.Add(ipsecServer);
			}
			listIpsecServersResponse.IpsecServers = listIpsecServersResponse_ipsecServers;
        
			return listIpsecServersResponse;
        }
    }
}
