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
using Aliyun.Acs.Slb.Model.V20140515;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeProtectedDomainsResponseUnmarshaller
    {
        public static DescribeProtectedDomainsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeProtectedDomainsResponse describeProtectedDomainsResponse = new DescribeProtectedDomainsResponse();

			describeProtectedDomainsResponse.HttpResponse = context.HttpResponse;
			describeProtectedDomainsResponse.RequestId = context.StringValue("DescribeProtectedDomains.RequestId");

			List<DescribeProtectedDomainsResponse.Domain> domains = new List<DescribeProtectedDomainsResponse.Domain>();
			for (int i = 0; i < context.Length("DescribeProtectedDomains.Domains.Length"); i++) {
				DescribeProtectedDomainsResponse.Domain domain = new DescribeProtectedDomainsResponse.Domain();
				domain.DomainName = context.StringValue("DescribeProtectedDomains.Domains["+ i +"].DomainName");
				domain.CcStatus = context.StringValue("DescribeProtectedDomains.Domains["+ i +"].CcStatus");
				domain.WafStatus = context.StringValue("DescribeProtectedDomains.Domains["+ i +"].WafStatus");
				domain.WafPolicyLevel = context.StringValue("DescribeProtectedDomains.Domains["+ i +"].WafPolicyLevel");

				List<DescribeProtectedDomainsResponse.Domain.IpItems> ccBlackList = new List<DescribeProtectedDomainsResponse.Domain.IpItems>();
				for (int j = 0; j < context.Length("DescribeProtectedDomains.Domains["+ i +"].CcBlackList.Length"); j++) {
					DescribeProtectedDomainsResponse.Domain.IpItems ipItems = new DescribeProtectedDomainsResponse.Domain.IpItems();
					ipItems.IpItem = context.StringValue("DescribeProtectedDomains.Domains["+ i +"].CcBlackList["+ j +"].IpItem");

					ccBlackList.Add(ipItems);
				}
				domain.CcBlackList = ccBlackList;

				List<DescribeProtectedDomainsResponse.Domain.IpItems> ccWhiteList = new List<DescribeProtectedDomainsResponse.Domain.IpItems>();
				for (int j = 0; j < context.Length("DescribeProtectedDomains.Domains["+ i +"].CcWhiteList.Length"); j++) {
					DescribeProtectedDomainsResponse.Domain.IpItems ipItems = new DescribeProtectedDomainsResponse.Domain.IpItems();
					ipItems.IpItem = context.StringValue("DescribeProtectedDomains.Domains["+ i +"].CcWhiteList["+ j +"].IpItem");

					ccWhiteList.Add(ipItems);
				}
				domain.CcWhiteList = ccWhiteList;

				List<DescribeProtectedDomainsResponse.Domain.IpItems> wafBlackList = new List<DescribeProtectedDomainsResponse.Domain.IpItems>();
				for (int j = 0; j < context.Length("DescribeProtectedDomains.Domains["+ i +"].WafBlackList.Length"); j++) {
					DescribeProtectedDomainsResponse.Domain.IpItems ipItems = new DescribeProtectedDomainsResponse.Domain.IpItems();
					ipItems.IpItem = context.StringValue("DescribeProtectedDomains.Domains["+ i +"].WafBlackList["+ j +"].IpItem");

					wafBlackList.Add(ipItems);
				}
				domain.WafBlackList = wafBlackList;

				List<DescribeProtectedDomainsResponse.Domain.IpItems> wafWhiteList = new List<DescribeProtectedDomainsResponse.Domain.IpItems>();
				for (int j = 0; j < context.Length("DescribeProtectedDomains.Domains["+ i +"].WafWhiteList.Length"); j++) {
					DescribeProtectedDomainsResponse.Domain.IpItems ipItems = new DescribeProtectedDomainsResponse.Domain.IpItems();
					ipItems.IpItem = context.StringValue("DescribeProtectedDomains.Domains["+ i +"].WafWhiteList["+ j +"].IpItem");

					wafWhiteList.Add(ipItems);
				}
				domain.WafWhiteList = wafWhiteList;

				domains.Add(domain);
			}
			describeProtectedDomainsResponse.Domains = domains;
        
			return describeProtectedDomainsResponse;
        }
    }
}