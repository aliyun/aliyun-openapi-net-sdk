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
using Aliyun.Acs.Alidns.Model.V20150109;
using System;
using System.Collections.Generic;

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

			List<DescribeDomainsResponse.Domain> domains = new List<DescribeDomainsResponse.Domain>();
			for (int i = 0; i < context.Length("DescribeDomains.Domains.Length"); i++) {
				DescribeDomainsResponse.Domain domain = new DescribeDomainsResponse.Domain();
				domain.DomainId = context.StringValue("DescribeDomains.Domains["+ i +"].DomainId");
				domain.DomainName = context.StringValue("DescribeDomains.Domains["+ i +"].DomainName");
				domain.PunyCode = context.StringValue("DescribeDomains.Domains["+ i +"].PunyCode");
				domain.AliDomain = context.BooleanValue("DescribeDomains.Domains["+ i +"].AliDomain");
				domain.RegistrantEmail = context.StringValue("DescribeDomains.Domains["+ i +"].RegistrantEmail");
				domain.GroupId = context.StringValue("DescribeDomains.Domains["+ i +"].GroupId");
				domain.GroupName = context.StringValue("DescribeDomains.Domains["+ i +"].GroupName");
				domain.InstanceId = context.StringValue("DescribeDomains.Domains["+ i +"].InstanceId");
				domain.VersionCode = context.StringValue("DescribeDomains.Domains["+ i +"].VersionCode");
				domain.VersionName = context.StringValue("DescribeDomains.Domains["+ i +"].VersionName");

				List<string> dnsServers = new List<string>();
				for (int j = 0; j < context.Length("DescribeDomains.Domains["+ i +"].DnsServers.Length"); j++) {
					dnsServers.Add(context.StringValue("DescribeDomains.Domains["+ i +"].DnsServers["+ j +"]"));
				}
				domain.DnsServers = dnsServers;

				domains.Add(domain);
			}
			describeDomainsResponse.Domains = domains;
        
			return describeDomainsResponse;
        }
    }
}