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
    public class DescribeDnsCacheDomainsResponseUnmarshaller
    {
        public static DescribeDnsCacheDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsCacheDomainsResponse describeDnsCacheDomainsResponse = new DescribeDnsCacheDomainsResponse();

			describeDnsCacheDomainsResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsCacheDomainsResponse.RequestId = _ctx.StringValue("DescribeDnsCacheDomains.RequestId");
			describeDnsCacheDomainsResponse.TotalCount = _ctx.LongValue("DescribeDnsCacheDomains.TotalCount");
			describeDnsCacheDomainsResponse.PageNumber = _ctx.LongValue("DescribeDnsCacheDomains.PageNumber");
			describeDnsCacheDomainsResponse.PageSize = _ctx.LongValue("DescribeDnsCacheDomains.PageSize");

			List<DescribeDnsCacheDomainsResponse.DescribeDnsCacheDomains_Domain> describeDnsCacheDomainsResponse_domains = new List<DescribeDnsCacheDomainsResponse.DescribeDnsCacheDomains_Domain>();
			for (int i = 0; i < _ctx.Length("DescribeDnsCacheDomains.Domains.Length"); i++) {
				DescribeDnsCacheDomainsResponse.DescribeDnsCacheDomains_Domain domain = new DescribeDnsCacheDomainsResponse.DescribeDnsCacheDomains_Domain();
				domain.DomainId = _ctx.StringValue("DescribeDnsCacheDomains.Domains["+ i +"].DomainId");
				domain.DomainName = _ctx.StringValue("DescribeDnsCacheDomains.Domains["+ i +"].DomainName");
				domain.InstanceId = _ctx.StringValue("DescribeDnsCacheDomains.Domains["+ i +"].InstanceId");
				domain.VersionCode = _ctx.StringValue("DescribeDnsCacheDomains.Domains["+ i +"].VersionCode");
				domain.Remark = _ctx.StringValue("DescribeDnsCacheDomains.Domains["+ i +"].Remark");
				domain.UpdateTime = _ctx.StringValue("DescribeDnsCacheDomains.Domains["+ i +"].UpdateTime");
				domain.UpdateTimestamp = _ctx.LongValue("DescribeDnsCacheDomains.Domains["+ i +"].UpdateTimestamp");
				domain.CreateTime = _ctx.StringValue("DescribeDnsCacheDomains.Domains["+ i +"].CreateTime");
				domain.CreateTimestamp = _ctx.LongValue("DescribeDnsCacheDomains.Domains["+ i +"].CreateTimestamp");
				domain.CacheTtlMin = _ctx.IntegerValue("DescribeDnsCacheDomains.Domains["+ i +"].CacheTtlMin");
				domain.CacheTtlMax = _ctx.IntegerValue("DescribeDnsCacheDomains.Domains["+ i +"].CacheTtlMax");
				domain.SourceProtocol = _ctx.StringValue("DescribeDnsCacheDomains.Domains["+ i +"].SourceProtocol");
				domain.SourceEdns = _ctx.StringValue("DescribeDnsCacheDomains.Domains["+ i +"].SourceEdns");
				domain.ExpireTime = _ctx.StringValue("DescribeDnsCacheDomains.Domains["+ i +"].ExpireTime");
				domain.ExpireTimestamp = _ctx.LongValue("DescribeDnsCacheDomains.Domains["+ i +"].ExpireTimestamp");

				List<DescribeDnsCacheDomainsResponse.DescribeDnsCacheDomains_Domain.DescribeDnsCacheDomains_SourceDnsServer> domain_sourceDnsServers = new List<DescribeDnsCacheDomainsResponse.DescribeDnsCacheDomains_Domain.DescribeDnsCacheDomains_SourceDnsServer>();
				for (int j = 0; j < _ctx.Length("DescribeDnsCacheDomains.Domains["+ i +"].SourceDnsServers.Length"); j++) {
					DescribeDnsCacheDomainsResponse.DescribeDnsCacheDomains_Domain.DescribeDnsCacheDomains_SourceDnsServer sourceDnsServer = new DescribeDnsCacheDomainsResponse.DescribeDnsCacheDomains_Domain.DescribeDnsCacheDomains_SourceDnsServer();
					sourceDnsServer.Host = _ctx.StringValue("DescribeDnsCacheDomains.Domains["+ i +"].SourceDnsServers["+ j +"].Host");
					sourceDnsServer.Port = _ctx.StringValue("DescribeDnsCacheDomains.Domains["+ i +"].SourceDnsServers["+ j +"].Port");

					domain_sourceDnsServers.Add(sourceDnsServer);
				}
				domain.SourceDnsServers = domain_sourceDnsServers;

				describeDnsCacheDomainsResponse_domains.Add(domain);
			}
			describeDnsCacheDomainsResponse.Domains = describeDnsCacheDomainsResponse_domains;
        
			return describeDnsCacheDomainsResponse;
        }
    }
}
