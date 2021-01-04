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
    public class DescribeDomainsResponseUnmarshaller
    {
        public static DescribeDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainsResponse describeDomainsResponse = new DescribeDomainsResponse();

			describeDomainsResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainsResponse.RequestId = _ctx.StringValue("DescribeDomains.RequestId");
			describeDomainsResponse.TotalCount = _ctx.LongValue("DescribeDomains.TotalCount");
			describeDomainsResponse.PageNumber = _ctx.LongValue("DescribeDomains.PageNumber");
			describeDomainsResponse.PageSize = _ctx.LongValue("DescribeDomains.PageSize");

			List<DescribeDomainsResponse.DescribeDomains_Domain> describeDomainsResponse_domains = new List<DescribeDomainsResponse.DescribeDomains_Domain>();
			for (int i = 0; i < _ctx.Length("DescribeDomains.Domains.Length"); i++) {
				DescribeDomainsResponse.DescribeDomains_Domain domain = new DescribeDomainsResponse.DescribeDomains_Domain();
				domain.DomainId = _ctx.StringValue("DescribeDomains.Domains["+ i +"].DomainId");
				domain.DomainName = _ctx.StringValue("DescribeDomains.Domains["+ i +"].DomainName");
				domain.PunyCode = _ctx.StringValue("DescribeDomains.Domains["+ i +"].PunyCode");
				domain.AliDomain = _ctx.BooleanValue("DescribeDomains.Domains["+ i +"].AliDomain");
				domain.RecordCount = _ctx.LongValue("DescribeDomains.Domains["+ i +"].RecordCount");
				domain.RegistrantEmail = _ctx.StringValue("DescribeDomains.Domains["+ i +"].RegistrantEmail");
				domain.Remark = _ctx.StringValue("DescribeDomains.Domains["+ i +"].Remark");
				domain.GroupId = _ctx.StringValue("DescribeDomains.Domains["+ i +"].GroupId");
				domain.GroupName = _ctx.StringValue("DescribeDomains.Domains["+ i +"].GroupName");
				domain.InstanceId = _ctx.StringValue("DescribeDomains.Domains["+ i +"].InstanceId");
				domain.VersionCode = _ctx.StringValue("DescribeDomains.Domains["+ i +"].VersionCode");
				domain.VersionName = _ctx.StringValue("DescribeDomains.Domains["+ i +"].VersionName");
				domain.InstanceEndTime = _ctx.StringValue("DescribeDomains.Domains["+ i +"].InstanceEndTime");
				domain.InstanceExpired = _ctx.BooleanValue("DescribeDomains.Domains["+ i +"].InstanceExpired");
				domain.Starmark = _ctx.BooleanValue("DescribeDomains.Domains["+ i +"].Starmark");
				domain.CreateTime = _ctx.StringValue("DescribeDomains.Domains["+ i +"].CreateTime");
				domain.CreateTimestamp = _ctx.LongValue("DescribeDomains.Domains["+ i +"].CreateTimestamp");
				domain.ResourceGroupId = _ctx.StringValue("DescribeDomains.Domains["+ i +"].ResourceGroupId");

				List<string> domain_dnsServers = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDomains.Domains["+ i +"].DnsServers.Length"); j++) {
					domain_dnsServers.Add(_ctx.StringValue("DescribeDomains.Domains["+ i +"].DnsServers["+ j +"]"));
				}
				domain.DnsServers = domain_dnsServers;

				List<DescribeDomainsResponse.DescribeDomains_Domain.DescribeDomains_Tag> domain_tags = new List<DescribeDomainsResponse.DescribeDomains_Domain.DescribeDomains_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDomains.Domains["+ i +"].Tags.Length"); j++) {
					DescribeDomainsResponse.DescribeDomains_Domain.DescribeDomains_Tag tag = new DescribeDomainsResponse.DescribeDomains_Domain.DescribeDomains_Tag();
					tag.Key = _ctx.StringValue("DescribeDomains.Domains["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeDomains.Domains["+ i +"].Tags["+ j +"].Value");

					domain_tags.Add(tag);
				}
				domain.Tags = domain_tags;

				describeDomainsResponse_domains.Add(domain);
			}
			describeDomainsResponse.Domains = describeDomainsResponse_domains;
        
			return describeDomainsResponse;
        }
    }
}
