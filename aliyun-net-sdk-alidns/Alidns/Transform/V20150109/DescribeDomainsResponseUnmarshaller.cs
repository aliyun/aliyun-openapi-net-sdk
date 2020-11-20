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
        public static DescribeDomainsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainsResponse describeDomainsResponse = new DescribeDomainsResponse();

			describeDomainsResponse.HttpResponse = context.HttpResponse;
			describeDomainsResponse.RequestId = context.StringValue("DescribeDomains.RequestId");
			describeDomainsResponse.TotalCount = context.LongValue("DescribeDomains.TotalCount");
			describeDomainsResponse.PageNumber = context.LongValue("DescribeDomains.PageNumber");
			describeDomainsResponse.PageSize = context.LongValue("DescribeDomains.PageSize");

			List<DescribeDomainsResponse.DescribeDomains_Domain> describeDomainsResponse_domains = new List<DescribeDomainsResponse.DescribeDomains_Domain>();
			for (int i = 0; i < context.Length("DescribeDomains.Domains.Length"); i++) {
				DescribeDomainsResponse.DescribeDomains_Domain domain = new DescribeDomainsResponse.DescribeDomains_Domain();
				domain.DomainId = context.StringValue("DescribeDomains.Domains["+ i +"].DomainId");
				domain.DomainName = context.StringValue("DescribeDomains.Domains["+ i +"].DomainName");
				domain.PunyCode = context.StringValue("DescribeDomains.Domains["+ i +"].PunyCode");
				domain.AliDomain = context.BooleanValue("DescribeDomains.Domains["+ i +"].AliDomain");
				domain.RecordCount = context.LongValue("DescribeDomains.Domains["+ i +"].RecordCount");
				domain.RegistrantEmail = context.StringValue("DescribeDomains.Domains["+ i +"].RegistrantEmail");
				domain.Remark = context.StringValue("DescribeDomains.Domains["+ i +"].Remark");
				domain.GroupId = context.StringValue("DescribeDomains.Domains["+ i +"].GroupId");
				domain.GroupName = context.StringValue("DescribeDomains.Domains["+ i +"].GroupName");
				domain.InstanceId = context.StringValue("DescribeDomains.Domains["+ i +"].InstanceId");
				domain.VersionCode = context.StringValue("DescribeDomains.Domains["+ i +"].VersionCode");
				domain.VersionName = context.StringValue("DescribeDomains.Domains["+ i +"].VersionName");
				domain.InstanceEndTime = context.StringValue("DescribeDomains.Domains["+ i +"].InstanceEndTime");
				domain.InstanceExpired = context.BooleanValue("DescribeDomains.Domains["+ i +"].InstanceExpired");
				domain.Starmark = context.BooleanValue("DescribeDomains.Domains["+ i +"].Starmark");
				domain.CreateTime = context.StringValue("DescribeDomains.Domains["+ i +"].CreateTime");
				domain.CreateTimestamp = context.LongValue("DescribeDomains.Domains["+ i +"].CreateTimestamp");
				domain.ResourceGroupId = context.StringValue("DescribeDomains.Domains["+ i +"].ResourceGroupId");

				List<string> domain_dnsServers = new List<string>();
				for (int j = 0; j < context.Length("DescribeDomains.Domains["+ i +"].DnsServers.Length"); j++) {
					domain_dnsServers.Add(context.StringValue("DescribeDomains.Domains["+ i +"].DnsServers["+ j +"]"));
				}
				domain.DnsServers = domain_dnsServers;

				List<DescribeDomainsResponse.DescribeDomains_Domain.DescribeDomains_Tag> domain_tags = new List<DescribeDomainsResponse.DescribeDomains_Domain.DescribeDomains_Tag>();
				for (int j = 0; j < context.Length("DescribeDomains.Domains["+ i +"].Tags.Length"); j++) {
					DescribeDomainsResponse.DescribeDomains_Domain.DescribeDomains_Tag tag = new DescribeDomainsResponse.DescribeDomains_Domain.DescribeDomains_Tag();
					tag.Key = context.StringValue("DescribeDomains.Domains["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeDomains.Domains["+ i +"].Tags["+ j +"].Value");

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
