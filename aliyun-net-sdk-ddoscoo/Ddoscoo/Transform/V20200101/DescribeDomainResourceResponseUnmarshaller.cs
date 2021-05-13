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
    public class DescribeDomainResourceResponseUnmarshaller
    {
        public static DescribeDomainResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainResourceResponse describeDomainResourceResponse = new DescribeDomainResourceResponse();

			describeDomainResourceResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainResourceResponse.RequestId = _ctx.StringValue("DescribeDomainResource.RequestId");
			describeDomainResourceResponse.TotalCount = _ctx.LongValue("DescribeDomainResource.TotalCount");

			List<DescribeDomainResourceResponse.DescribeDomainResource_WebRule> describeDomainResourceResponse_webRules = new List<DescribeDomainResourceResponse.DescribeDomainResource_WebRule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainResource.WebRules.Length"); i++) {
				DescribeDomainResourceResponse.DescribeDomainResource_WebRule webRule = new DescribeDomainResourceResponse.DescribeDomainResource_WebRule();
				webRule.Domain = _ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].Domain");
				webRule.RsType = _ctx.IntegerValue("DescribeDomainResource.WebRules["+ i +"].RsType");
				webRule.CcEnabled = _ctx.BooleanValue("DescribeDomainResource.WebRules["+ i +"].CcEnabled");
				webRule.CcRuleEnabled = _ctx.BooleanValue("DescribeDomainResource.WebRules["+ i +"].CcRuleEnabled");
				webRule.CcTemplate = _ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].CcTemplate");
				webRule.SslProtocols = _ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].SslProtocols");
				webRule.SslCiphers = _ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].SslCiphers");
				webRule.Http2Enable = _ctx.BooleanValue("DescribeDomainResource.WebRules["+ i +"].Http2Enable");
				webRule.Http2HttpsEnable = _ctx.BooleanValue("DescribeDomainResource.WebRules["+ i +"].Http2HttpsEnable");
				webRule.Https2HttpEnable = _ctx.BooleanValue("DescribeDomainResource.WebRules["+ i +"].Https2HttpEnable");
				webRule.PolicyMode = _ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].PolicyMode");
				webRule.ProxyEnabled = _ctx.BooleanValue("DescribeDomainResource.WebRules["+ i +"].ProxyEnabled");
				webRule.Ssl13Enabled = _ctx.BooleanValue("DescribeDomainResource.WebRules["+ i +"].Ssl13Enabled");
				webRule.PunishStatus = _ctx.BooleanValue("DescribeDomainResource.WebRules["+ i +"].PunishStatus");
				webRule.PunishReason = _ctx.IntegerValue("DescribeDomainResource.WebRules["+ i +"].PunishReason");
				webRule.Cname = _ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].Cname");
				webRule.CertName = _ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].CertName");
				webRule.HttpsExt = _ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].HttpsExt");

				List<string> webRule_realServers = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDomainResource.WebRules["+ i +"].RealServers.Length"); j++) {
					webRule_realServers.Add(_ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].RealServers["+ j +"]"));
				}
				webRule.RealServers = webRule_realServers;

				List<string> webRule_whiteList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDomainResource.WebRules["+ i +"].WhiteList.Length"); j++) {
					webRule_whiteList.Add(_ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].WhiteList["+ j +"]"));
				}
				webRule.WhiteList = webRule_whiteList;

				List<string> webRule_blackList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDomainResource.WebRules["+ i +"].BlackList.Length"); j++) {
					webRule_blackList.Add(_ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].BlackList["+ j +"]"));
				}
				webRule.BlackList = webRule_blackList;

				List<string> webRule_customCiphers = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDomainResource.WebRules["+ i +"].CustomCiphers.Length"); j++) {
					webRule_customCiphers.Add(_ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].CustomCiphers["+ j +"]"));
				}
				webRule.CustomCiphers = webRule_customCiphers;

				List<string> webRule_instanceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDomainResource.WebRules["+ i +"].InstanceIds.Length"); j++) {
					webRule_instanceIds.Add(_ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].InstanceIds["+ j +"]"));
				}
				webRule.InstanceIds = webRule_instanceIds;

				List<DescribeDomainResourceResponse.DescribeDomainResource_WebRule.DescribeDomainResource_ProxyConfig> webRule_proxyTypes = new List<DescribeDomainResourceResponse.DescribeDomainResource_WebRule.DescribeDomainResource_ProxyConfig>();
				for (int j = 0; j < _ctx.Length("DescribeDomainResource.WebRules["+ i +"].ProxyTypes.Length"); j++) {
					DescribeDomainResourceResponse.DescribeDomainResource_WebRule.DescribeDomainResource_ProxyConfig proxyConfig = new DescribeDomainResourceResponse.DescribeDomainResource_WebRule.DescribeDomainResource_ProxyConfig();
					proxyConfig.ProxyType = _ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].ProxyTypes["+ j +"].ProxyType");

					List<string> proxyConfig_proxyPorts = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeDomainResource.WebRules["+ i +"].ProxyTypes["+ j +"].ProxyPorts.Length"); k++) {
						proxyConfig_proxyPorts.Add(_ctx.StringValue("DescribeDomainResource.WebRules["+ i +"].ProxyTypes["+ j +"].ProxyPorts["+ k +"]"));
					}
					proxyConfig.ProxyPorts = proxyConfig_proxyPorts;

					webRule_proxyTypes.Add(proxyConfig);
				}
				webRule.ProxyTypes = webRule_proxyTypes;

				describeDomainResourceResponse_webRules.Add(webRule);
			}
			describeDomainResourceResponse.WebRules = describeDomainResourceResponse_webRules;
        
			return describeDomainResourceResponse;
        }
    }
}
