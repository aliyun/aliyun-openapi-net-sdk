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
        public static DescribeScdnUserDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnUserDomainsResponse describeScdnUserDomainsResponse = new DescribeScdnUserDomainsResponse();

			describeScdnUserDomainsResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnUserDomainsResponse.RequestId = _ctx.StringValue("DescribeScdnUserDomains.RequestId");
			describeScdnUserDomainsResponse.PageNumber = _ctx.LongValue("DescribeScdnUserDomains.PageNumber");
			describeScdnUserDomainsResponse.PageSize = _ctx.LongValue("DescribeScdnUserDomains.PageSize");
			describeScdnUserDomainsResponse.TotalCount = _ctx.LongValue("DescribeScdnUserDomains.TotalCount");

			List<DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData> describeScdnUserDomainsResponse_domains = new List<DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData>();
			for (int i = 0; i < _ctx.Length("DescribeScdnUserDomains.Domains.Length"); i++) {
				DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData pageData = new DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData();
				pageData.DomainName = _ctx.StringValue("DescribeScdnUserDomains.Domains["+ i +"].DomainName");
				pageData.Cname = _ctx.StringValue("DescribeScdnUserDomains.Domains["+ i +"].Cname");
				pageData.DomainStatus = _ctx.StringValue("DescribeScdnUserDomains.Domains["+ i +"].DomainStatus");
				pageData.GmtCreated = _ctx.StringValue("DescribeScdnUserDomains.Domains["+ i +"].GmtCreated");
				pageData.GmtModified = _ctx.StringValue("DescribeScdnUserDomains.Domains["+ i +"].GmtModified");
				pageData.Description = _ctx.StringValue("DescribeScdnUserDomains.Domains["+ i +"].Description");
				pageData.SSLProtocol = _ctx.StringValue("DescribeScdnUserDomains.Domains["+ i +"].SSLProtocol");
				pageData.ResourceGroupId = _ctx.StringValue("DescribeScdnUserDomains.Domains["+ i +"].ResourceGroupId");
				pageData.Sandbox = _ctx.StringValue("DescribeScdnUserDomains.Domains["+ i +"].Sandbox");

				List<DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData.DescribeScdnUserDomains_Source> pageData_sources = new List<DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData.DescribeScdnUserDomains_Source>();
				for (int j = 0; j < _ctx.Length("DescribeScdnUserDomains.Domains["+ i +"].Sources.Length"); j++) {
					DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData.DescribeScdnUserDomains_Source source = new DescribeScdnUserDomainsResponse.DescribeScdnUserDomains_PageData.DescribeScdnUserDomains_Source();
					source.Type = _ctx.StringValue("DescribeScdnUserDomains.Domains["+ i +"].Sources["+ j +"].Type");
					source.Content = _ctx.StringValue("DescribeScdnUserDomains.Domains["+ i +"].Sources["+ j +"].Content");
					source.Port = _ctx.IntegerValue("DescribeScdnUserDomains.Domains["+ i +"].Sources["+ j +"].Port");
					source.Priority = _ctx.StringValue("DescribeScdnUserDomains.Domains["+ i +"].Sources["+ j +"].Priority");

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
