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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDomainNsResponseUnmarshaller
    {
        public static DescribeDomainNsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainNsResponse describeDomainNsResponse = new DescribeDomainNsResponse();

			describeDomainNsResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainNsResponse.RequestId = _ctx.StringValue("DescribeDomainNs.RequestId");
			describeDomainNsResponse.AllAliDns = _ctx.BooleanValue("DescribeDomainNs.AllAliDns");
			describeDomainNsResponse.IncludeAliDns = _ctx.BooleanValue("DescribeDomainNs.IncludeAliDns");

			List<string> describeDomainNsResponse_dnsServers = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainNs.DnsServers.Length"); i++) {
				describeDomainNsResponse_dnsServers.Add(_ctx.StringValue("DescribeDomainNs.DnsServers["+ i +"]"));
			}
			describeDomainNsResponse.DnsServers = describeDomainNsResponse_dnsServers;

			List<string> describeDomainNsResponse_expectDnsServers = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainNs.ExpectDnsServers.Length"); i++) {
				describeDomainNsResponse_expectDnsServers.Add(_ctx.StringValue("DescribeDomainNs.ExpectDnsServers["+ i +"]"));
			}
			describeDomainNsResponse.ExpectDnsServers = describeDomainNsResponse_expectDnsServers;
        
			return describeDomainNsResponse;
        }
    }
}
