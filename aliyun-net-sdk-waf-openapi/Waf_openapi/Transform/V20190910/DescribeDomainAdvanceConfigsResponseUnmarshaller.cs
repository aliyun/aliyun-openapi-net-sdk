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
using Aliyun.Acs.waf_openapi.Model.V20190910;

namespace Aliyun.Acs.waf_openapi.Transform.V20190910
{
    public class DescribeDomainAdvanceConfigsResponseUnmarshaller
    {
        public static DescribeDomainAdvanceConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainAdvanceConfigsResponse describeDomainAdvanceConfigsResponse = new DescribeDomainAdvanceConfigsResponse();

			describeDomainAdvanceConfigsResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainAdvanceConfigsResponse.RequestId = _ctx.StringValue("DescribeDomainAdvanceConfigs.RequestId");

			List<DescribeDomainAdvanceConfigsResponse.DescribeDomainAdvanceConfigs_DomainConfig> describeDomainAdvanceConfigsResponse_domainConfigs = new List<DescribeDomainAdvanceConfigsResponse.DescribeDomainAdvanceConfigs_DomainConfig>();
			for (int i = 0; i < _ctx.Length("DescribeDomainAdvanceConfigs.DomainConfigs.Length"); i++) {
				DescribeDomainAdvanceConfigsResponse.DescribeDomainAdvanceConfigs_DomainConfig domainConfig = new DescribeDomainAdvanceConfigsResponse.DescribeDomainAdvanceConfigs_DomainConfig();
				domainConfig.Domain = _ctx.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Domain");

				DescribeDomainAdvanceConfigsResponse.DescribeDomainAdvanceConfigs_DomainConfig.DescribeDomainAdvanceConfigs_Profile profile = new DescribeDomainAdvanceConfigsResponse.DescribeDomainAdvanceConfigs_DomainConfig.DescribeDomainAdvanceConfigs_Profile();
				profile.Ipv6Status = _ctx.IntegerValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.Ipv6Status");
				profile.GSLBStatus = _ctx.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.GSLBStatus");
				profile.VipServiceStatus = _ctx.IntegerValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.VipServiceStatus");
				profile.ClusterType = _ctx.IntegerValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.ClusterType");
				profile.ExclusiveVipStatus = _ctx.IntegerValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.ExclusiveVipStatus");
				profile.Cname = _ctx.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.Cname");
				profile.CertStatus = _ctx.IntegerValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.CertStatus");
				profile.ResolvedType = _ctx.IntegerValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.ResolvedType");

				List<string> profile_http2Port = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.Http2Port.Length"); j++) {
					profile_http2Port.Add(_ctx.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.Http2Port["+ j +"]"));
				}
				profile.Http2Port = profile_http2Port;

				List<string> profile_httpPort = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.HttpPort.Length"); j++) {
					profile_httpPort.Add(_ctx.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.HttpPort["+ j +"]"));
				}
				profile.HttpPort = profile_httpPort;

				List<string> profile_rs = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.Rs.Length"); j++) {
					profile_rs.Add(_ctx.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.Rs["+ j +"]"));
				}
				profile.Rs = profile_rs;

				List<string> profile_httpsPort = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.HttpsPort.Length"); j++) {
					profile_httpsPort.Add(_ctx.StringValue("DescribeDomainAdvanceConfigs.DomainConfigs["+ i +"].Profile.HttpsPort["+ j +"]"));
				}
				profile.HttpsPort = profile_httpsPort;
				domainConfig.Profile = profile;

				describeDomainAdvanceConfigsResponse_domainConfigs.Add(domainConfig);
			}
			describeDomainAdvanceConfigsResponse.DomainConfigs = describeDomainAdvanceConfigsResponse_domainConfigs;
        
			return describeDomainAdvanceConfigsResponse;
        }
    }
}
