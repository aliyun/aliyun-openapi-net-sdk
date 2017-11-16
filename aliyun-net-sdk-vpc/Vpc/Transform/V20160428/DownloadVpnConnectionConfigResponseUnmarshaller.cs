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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DownloadVpnConnectionConfigResponseUnmarshaller
    {
        public static DownloadVpnConnectionConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DownloadVpnConnectionConfigResponse downloadVpnConnectionConfigResponse = new DownloadVpnConnectionConfigResponse();

			downloadVpnConnectionConfigResponse.HttpResponse = context.HttpResponse;
			downloadVpnConnectionConfigResponse.RequestId = context.StringValue("DownloadVpnConnectionConfig.RequestId");

			DownloadVpnConnectionConfigResponse.DownloadVpnConnectionConfig_VpnConnectionConfig vpnConnectionConfig = new DownloadVpnConnectionConfigResponse.DownloadVpnConnectionConfig_VpnConnectionConfig();
			vpnConnectionConfig.LocalSubnet = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.LocalSubnet");
			vpnConnectionConfig.RemoteSubnet = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.RemoteSubnet");
			vpnConnectionConfig.Local = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.Local");
			vpnConnectionConfig.Remote = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.Remote");

			DownloadVpnConnectionConfigResponse.DownloadVpnConnectionConfig_VpnConnectionConfig.DownloadVpnConnectionConfig_IkeConfig ikeConfig = new DownloadVpnConnectionConfigResponse.DownloadVpnConnectionConfig_VpnConnectionConfig.DownloadVpnConnectionConfig_IkeConfig();
			ikeConfig.Psk = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.Psk");
			ikeConfig.IkeVersion = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.IkeVersion");
			ikeConfig.IkeMode = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.IkeMode");
			ikeConfig.IkeEncAlg = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.IkeEncAlg");
			ikeConfig.IkeAuthAlg = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.IkeAuthAlg");
			ikeConfig.IkePfs = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.IkePfs");
			ikeConfig.IkeLifetime = context.LongValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.IkeLifetime");
			ikeConfig.LocalId = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.LocalId");
			ikeConfig.RemoteId = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IkeConfig.RemoteId");
			vpnConnectionConfig.IkeConfig = ikeConfig;

			DownloadVpnConnectionConfigResponse.DownloadVpnConnectionConfig_VpnConnectionConfig.DownloadVpnConnectionConfig_IpsecConfig ipsecConfig = new DownloadVpnConnectionConfigResponse.DownloadVpnConnectionConfig_VpnConnectionConfig.DownloadVpnConnectionConfig_IpsecConfig();
			ipsecConfig.IpsecEncAlg = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IpsecConfig.IpsecEncAlg");
			ipsecConfig.IpsecAuthAlg = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IpsecConfig.IpsecAuthAlg");
			ipsecConfig.IpsecPfs = context.StringValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IpsecConfig.IpsecPfs");
			ipsecConfig.IpsecLifetime = context.LongValue("DownloadVpnConnectionConfig.VpnConnectionConfig.IpsecConfig.IpsecLifetime");
			vpnConnectionConfig.IpsecConfig = ipsecConfig;
			downloadVpnConnectionConfigResponse.VpnConnectionConfig = vpnConnectionConfig;
        
			return downloadVpnConnectionConfigResponse;
        }
    }
}