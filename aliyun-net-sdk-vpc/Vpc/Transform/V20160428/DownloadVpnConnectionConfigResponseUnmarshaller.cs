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
    public class DownloadVpnConnectionConfigResponseUnmarshaller
    {
        public static DownloadVpnConnectionConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DownloadVpnConnectionConfigResponse downloadVpnConnectionConfigResponse = new DownloadVpnConnectionConfigResponse();

			downloadVpnConnectionConfigResponse.HttpResponse = _ctx.HttpResponse;
			downloadVpnConnectionConfigResponse.RequestId = _ctx.StringValue("DownloadVpnConnectionConfig.RequestId");

			DownloadVpnConnectionConfigResponse.DownloadVpnConnectionConfig_VpnConnectionConfig vpnConnectionConfig = new DownloadVpnConnectionConfigResponse.DownloadVpnConnectionConfig_VpnConnectionConfig();
			vpnConnectionConfig.LocalSubnet = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.LocalSubnet");
			vpnConnectionConfig.RemoteSubnet = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.RemoteSubnet");
			vpnConnectionConfig.Local = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.Local");
			vpnConnectionConfig.Remote = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.Remote");

			DownloadVpnConnectionConfigResponse.DownloadVpnConnectionConfig_VpnConnectionConfig.DownloadVpnConnectionConfig_IkeConfig ikeConfig = new DownloadVpnConnectionConfigResponse.DownloadVpnConnectionConfig_VpnConnectionConfig.DownloadVpnConnectionConfig_IkeConfig();
			ikeConfig.Psk = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.Psk");
			ikeConfig.IkeVersion = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.IkeVersion");
			ikeConfig.IkeMode = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.IkeMode");
			ikeConfig.IkeEncAlg = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.IkeEncAlg");
			ikeConfig.IkeAuthAlg = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.IkeAuthAlg");
			ikeConfig.IkePfs = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.IkePfs");
			ikeConfig.IkeLifetime = _ctx.LongValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.IkeLifetime");
			ikeConfig.LocalId = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.LocalId");
			ikeConfig.RemoteId = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.RemoteId");
			vpnConnectionConfig.IkeConfig = ikeConfig;

			DownloadVpnConnectionConfigResponse.DownloadVpnConnectionConfig_VpnConnectionConfig.DownloadVpnConnectionConfig_IpsecConfig ipsecConfig = new DownloadVpnConnectionConfigResponse.DownloadVpnConnectionConfig_VpnConnectionConfig.DownloadVpnConnectionConfig_IpsecConfig();
			ipsecConfig.IpsecEncAlg = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IpsecConfig.IpsecEncAlg");
			ipsecConfig.IpsecAuthAlg = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IpsecConfig.IpsecAuthAlg");
			ipsecConfig.IpsecPfs = _ctx.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IpsecConfig.IpsecPfs");
			ipsecConfig.IpsecLifetime = _ctx.LongValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IpsecConfig.IpsecLifetime");
			vpnConnectionConfig.IpsecConfig = ipsecConfig;
			downloadVpnConnectionConfigResponse.VpnConnectionConfig = vpnConnectionConfig;
        
			return downloadVpnConnectionConfigResponse;
        }
    }
}
