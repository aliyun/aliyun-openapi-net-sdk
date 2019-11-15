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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnIpaUserDomainsResponseUnmarshaller
    {
        public static DescribeDcdnIpaUserDomainsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnIpaUserDomainsResponse describeDcdnIpaUserDomainsResponse = new DescribeDcdnIpaUserDomainsResponse();

			describeDcdnIpaUserDomainsResponse.HttpResponse = context.HttpResponse;
			describeDcdnIpaUserDomainsResponse.RequestId = context.StringValue("DescribeDcdnIpaUserDomains.RequestId");
			describeDcdnIpaUserDomainsResponse.PageNumber = context.LongValue("DescribeDcdnIpaUserDomains.PageNumber");
			describeDcdnIpaUserDomainsResponse.PageSize = context.LongValue("DescribeDcdnIpaUserDomains.PageSize");
			describeDcdnIpaUserDomainsResponse.TotalCount = context.LongValue("DescribeDcdnIpaUserDomains.TotalCount");

			List<DescribeDcdnIpaUserDomainsResponse.DescribeDcdnIpaUserDomains_PageData> describeDcdnIpaUserDomainsResponse_domains = new List<DescribeDcdnIpaUserDomainsResponse.DescribeDcdnIpaUserDomains_PageData>();
			for (int i = 0; i < context.Length("DescribeDcdnIpaUserDomains.Domains.Length"); i++) {
				DescribeDcdnIpaUserDomainsResponse.DescribeDcdnIpaUserDomains_PageData pageData = new DescribeDcdnIpaUserDomainsResponse.DescribeDcdnIpaUserDomains_PageData();
				pageData.DomainName = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].DomainName");
				pageData.Cname = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].Cname");
				pageData.DomainStatus = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].DomainStatus");
				pageData.GmtCreated = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].GmtCreated");
				pageData.GmtModified = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].GmtModified");
				pageData.Description = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].Description");
				pageData.SSLProtocol = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].SSLProtocol");
				pageData.ResourceGroupId = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].ResourceGroupId");
				pageData.Sandbox = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].Sandbox");

				List<DescribeDcdnIpaUserDomainsResponse.DescribeDcdnIpaUserDomains_PageData.DescribeDcdnIpaUserDomains_Source> pageData_sources = new List<DescribeDcdnIpaUserDomainsResponse.DescribeDcdnIpaUserDomains_PageData.DescribeDcdnIpaUserDomains_Source>();
				for (int j = 0; j < context.Length("DescribeDcdnIpaUserDomains.Domains["+ i +"].Sources.Length"); j++) {
					DescribeDcdnIpaUserDomainsResponse.DescribeDcdnIpaUserDomains_PageData.DescribeDcdnIpaUserDomains_Source source = new DescribeDcdnIpaUserDomainsResponse.DescribeDcdnIpaUserDomains_PageData.DescribeDcdnIpaUserDomains_Source();
					source.Type = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].Sources["+ j +"].Type");
					source.Content = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].Sources["+ j +"].Content");
					source.Port = context.IntegerValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].Sources["+ j +"].Port");
					source.Priority = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].Sources["+ j +"].Priority");
					source.Weight = context.StringValue("DescribeDcdnIpaUserDomains.Domains["+ i +"].Sources["+ j +"].Weight");

					pageData_sources.Add(source);
				}
				pageData.Sources = pageData_sources;

				describeDcdnIpaUserDomainsResponse_domains.Add(pageData);
			}
			describeDcdnIpaUserDomainsResponse.Domains = describeDcdnIpaUserDomainsResponse_domains;
        
			return describeDcdnIpaUserDomainsResponse;
        }
    }
}
