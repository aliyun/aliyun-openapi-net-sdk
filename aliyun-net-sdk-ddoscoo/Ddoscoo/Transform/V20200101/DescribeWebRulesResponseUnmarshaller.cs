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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeWebRulesResponseUnmarshaller
    {
        public static DescribeWebRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebRulesResponse describeWebRulesResponse = new DescribeWebRulesResponse();

			describeWebRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeWebRulesResponse.RequestId = _ctx.StringValue("DescribeWebRules.RequestId");
			describeWebRulesResponse.TotalCount = _ctx.LongValue("DescribeWebRules.TotalCount");

			List<DescribeWebRulesResponse.DescribeWebRules_WebRule> describeWebRulesResponse_webRules = new List<DescribeWebRulesResponse.DescribeWebRules_WebRule>();
			for (int i = 0; i < _ctx.Length("DescribeWebRules.WebRules.Length"); i++) {
				DescribeWebRulesResponse.DescribeWebRules_WebRule webRule = new DescribeWebRulesResponse.DescribeWebRules_WebRule();
				webRule.Domain = _ctx.StringValue("DescribeWebRules.WebRules["+ i +"].Domain");
				webRule.CcEnabled = _ctx.BooleanValue("DescribeWebRules.WebRules["+ i +"].CcEnabled");
				webRule.CcRuleEnabled = _ctx.BooleanValue("DescribeWebRules.WebRules["+ i +"].CcRuleEnabled");
				webRule.CcTemplate = _ctx.StringValue("DescribeWebRules.WebRules["+ i +"].CcTemplate");
				webRule.SslProtocols = _ctx.StringValue("DescribeWebRules.WebRules["+ i +"].SslProtocols");
				webRule.SslCiphers = _ctx.StringValue("DescribeWebRules.WebRules["+ i +"].SslCiphers");
				webRule.Http2Enable = _ctx.BooleanValue("DescribeWebRules.WebRules["+ i +"].Http2Enable");
				webRule.Http2HttpsEnable = _ctx.BooleanValue("DescribeWebRules.WebRules["+ i +"].Http2HttpsEnable");
				webRule.Https2HttpEnable = _ctx.BooleanValue("DescribeWebRules.WebRules["+ i +"].Https2HttpEnable");
				webRule.PolicyMode = _ctx.StringValue("DescribeWebRules.WebRules["+ i +"].PolicyMode");
				webRule.ProxyEnabled = _ctx.BooleanValue("DescribeWebRules.WebRules["+ i +"].ProxyEnabled");
				webRule.Ssl13Enabled = _ctx.BooleanValue("DescribeWebRules.WebRules["+ i +"].Ssl13Enabled");
				webRule.PunishStatus = _ctx.BooleanValue("DescribeWebRules.WebRules["+ i +"].PunishStatus");
				webRule.PunishReason = _ctx.IntegerValue("DescribeWebRules.WebRules["+ i +"].PunishReason");
				webRule.Cname = _ctx.StringValue("DescribeWebRules.WebRules["+ i +"].Cname");
				webRule.CertName = _ctx.StringValue("DescribeWebRules.WebRules["+ i +"].CertName");

				List<string> webRule_whiteList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeWebRules.WebRules["+ i +"].WhiteList.Length"); j++) {
					webRule_whiteList.Add(_ctx.StringValue("DescribeWebRules.WebRules["+ i +"].WhiteList["+ j +"]"));
				}
				webRule.WhiteList = webRule_whiteList;

				List<string> webRule_blackList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeWebRules.WebRules["+ i +"].BlackList.Length"); j++) {
					webRule_blackList.Add(_ctx.StringValue("DescribeWebRules.WebRules["+ i +"].BlackList["+ j +"]"));
				}
				webRule.BlackList = webRule_blackList;

				List<string> webRule_customCiphers = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeWebRules.WebRules["+ i +"].CustomCiphers.Length"); j++) {
					webRule_customCiphers.Add(_ctx.StringValue("DescribeWebRules.WebRules["+ i +"].CustomCiphers["+ j +"]"));
				}
				webRule.CustomCiphers = webRule_customCiphers;

				List<DescribeWebRulesResponse.DescribeWebRules_WebRule.DescribeWebRules_ProxyConfig> webRule_proxyTypes = new List<DescribeWebRulesResponse.DescribeWebRules_WebRule.DescribeWebRules_ProxyConfig>();
				for (int j = 0; j < _ctx.Length("DescribeWebRules.WebRules["+ i +"].ProxyTypes.Length"); j++) {
					DescribeWebRulesResponse.DescribeWebRules_WebRule.DescribeWebRules_ProxyConfig proxyConfig = new DescribeWebRulesResponse.DescribeWebRules_WebRule.DescribeWebRules_ProxyConfig();
					proxyConfig.ProxyType = _ctx.StringValue("DescribeWebRules.WebRules["+ i +"].ProxyTypes["+ j +"].ProxyType");

					List<string> proxyConfig_proxyPorts = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeWebRules.WebRules["+ i +"].ProxyTypes["+ j +"].ProxyPorts.Length"); k++) {
						proxyConfig_proxyPorts.Add(_ctx.StringValue("DescribeWebRules.WebRules["+ i +"].ProxyTypes["+ j +"].ProxyPorts["+ k +"]"));
					}
					proxyConfig.ProxyPorts = proxyConfig_proxyPorts;

					webRule_proxyTypes.Add(proxyConfig);
				}
				webRule.ProxyTypes = webRule_proxyTypes;

				List<DescribeWebRulesResponse.DescribeWebRules_WebRule.DescribeWebRules_RealServer> webRule_realServers = new List<DescribeWebRulesResponse.DescribeWebRules_WebRule.DescribeWebRules_RealServer>();
				for (int j = 0; j < _ctx.Length("DescribeWebRules.WebRules["+ i +"].RealServers.Length"); j++) {
					DescribeWebRulesResponse.DescribeWebRules_WebRule.DescribeWebRules_RealServer realServer = new DescribeWebRulesResponse.DescribeWebRules_WebRule.DescribeWebRules_RealServer();
					realServer.RsType = _ctx.IntegerValue("DescribeWebRules.WebRules["+ i +"].RealServers["+ j +"].RsType");
					realServer.RealServer = _ctx.StringValue("DescribeWebRules.WebRules["+ i +"].RealServers["+ j +"].RealServer");

					webRule_realServers.Add(realServer);
				}
				webRule.RealServers = webRule_realServers;

				describeWebRulesResponse_webRules.Add(webRule);
			}
			describeWebRulesResponse.WebRules = describeWebRulesResponse_webRules;
        
			return describeWebRulesResponse;
        }
    }
}
