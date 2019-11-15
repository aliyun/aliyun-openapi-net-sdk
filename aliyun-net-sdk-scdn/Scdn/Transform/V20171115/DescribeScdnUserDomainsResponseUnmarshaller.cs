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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnUserDomainsResponseUnmarshaller
    {
        public static DescribeScdnUserDomainsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnUserDomainsResponse describeScdnUserDomainsResponse = new DescribeScdnUserDomainsResponse();

			describeScdnUserDomainsResponse.HttpResponse = context.HttpResponse;
			describeScdnUserDomainsResponse.RequestId = context.StringValue("DescribeScdnUserDomains.RequestId");
			describeScdnUserDomainsResponse.PageNumber = context.LongValue("DescribeScdnUserDomains.PageNumber");
			describeScdnUserDomainsResponse.PageSize = context.LongValue("DescribeScdnUserDomains.PageSize");
			describeScdnUserDomainsResponse.TotalCount = context.LongValue("DescribeScdnUserDomains.TotalCount");

			List<DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData> describeScdnUserDomainsResponse_domains = new List<DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData>();
			for (int i = 0; i < context.Length("DescribeScdnUserDomains.Domains.Length"); i++) {
				DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData pageData = new DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData();
				pageData.DomainName = context.StringValue("DescribeScdnUserDomains.Domains["+ i +"].DomainName");
				pageData.Cname = context.StringValue("DescribeScdnUserDomains.Domains["+ i +"].Cname");
				pageData.DomainStatus = context.StringValue("DescribeScdnUserDomains.Domains["+ i +"].DomainStatus");
				pageData.GmtCreated = context.StringValue("DescribeScdnUserDomains.Domains["+ i +"].GmtCreated");
				pageData.GmtModified = context.StringValue("DescribeScdnUserDomains.Domains["+ i +"].GmtModified");
				pageData.Description = context.StringValue("DescribeScdnUserDomains.Domains["+ i +"].Description");
				pageData.SSLProtocol = context.StringValue("DescribeScdnUserDomains.Domains["+ i +"].SSLProtocol");
				pageData.ResourceGroupId = context.StringValue("DescribeScdnUserDomains.Domains["+ i +"].ResourceGroupId");
				pageData.Sandbox = context.StringValue("DescribeScdnUserDomains.Domains["+ i +"].Sandbox");

				List<DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData.DescribeScdnUserDomains_Source> pageData_sources = new List<DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData.DescribeScdnUserDomains_Source>();
				for (int j = 0; j < context.Length("DescribeScdnUserDomains.Domains["+ i +"].Sources.Length"); j++) {
					DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData.DescribeScdnUserDomains_Source source = new DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData.DescribeScdnUserDomains_Source();
					source.Type = context.StringValue("DescribeScdnUserDomains.Domains["+ i +"].Sources["+ j +"].Type");
					source.Content = context.StringValue("DescribeScdnUserDomains.Domains["+ i +"].Sources["+ j +"].Content");
					source.Port = context.IntegerValue("DescribeScdnUserDomains.Domains["+ i +"].Sources["+ j +"].Port");
					source.Priority = context.StringValue("DescribeScdnUserDomains.Domains["+ i +"].Sources["+ j +"].Priority");

					pageData_sources.Add(source);
				}
				pageData.Sources = pageData_sources;

				describeScdnUserDomainsResponse_domains.Add(pageData);
			}
			describeScdnUserDomainsResponse.Domains = describeScdnUserDomainsResponse_domains;
        
			return describeScdnUserDomainsResponse;
        }
    }
}
