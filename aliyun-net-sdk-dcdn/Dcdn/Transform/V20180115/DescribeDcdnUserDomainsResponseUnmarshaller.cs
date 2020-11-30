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
    public class DescribeDcdnUserDomainsResponseUnmarshaller
    {
        public static DescribeDcdnUserDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnUserDomainsResponse describeDcdnUserDomainsResponse = new DescribeDcdnUserDomainsResponse();

			describeDcdnUserDomainsResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnUserDomainsResponse.RequestId = _ctx.StringValue("DescribeDcdnUserDomains.RequestId");
			describeDcdnUserDomainsResponse.PageNumber = _ctx.LongValue("DescribeDcdnUserDomains.PageNumber");
			describeDcdnUserDomainsResponse.PageSize = _ctx.LongValue("DescribeDcdnUserDomains.PageSize");
			describeDcdnUserDomainsResponse.TotalCount = _ctx.LongValue("DescribeDcdnUserDomains.TotalCount");

			List<DescribeDcdnUserDomainsResponse.DescribeDcdnUserDomains_PageData> describeDcdnUserDomainsResponse_domains = new List<DescribeDcdnUserDomainsResponse.DescribeDcdnUserDomains_PageData>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnUserDomains.Domains.Length"); i++) {
				DescribeDcdnUserDomainsResponse.DescribeDcdnUserDomains_PageData pageData = new DescribeDcdnUserDomainsResponse.DescribeDcdnUserDomains_PageData();
				pageData.DomainName = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].DomainName");
				pageData.Cname = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].Cname");
				pageData.DomainStatus = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].DomainStatus");
				pageData.GmtCreated = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].GmtCreated");
				pageData.GmtModified = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].GmtModified");
				pageData.Description = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].Description");
				pageData.SSLProtocol = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].SSLProtocol");
				pageData.ResourceGroupId = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].ResourceGroupId");
				pageData.Sandbox = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].Sandbox");

				List<DescribeDcdnUserDomainsResponse.DescribeDcdnUserDomains_PageData.DescribeDcdnUserDomains_Source> pageData_sources = new List<DescribeDcdnUserDomainsResponse.DescribeDcdnUserDomains_PageData.DescribeDcdnUserDomains_Source>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnUserDomains.Domains["+ i +"].Sources.Length"); j++) {
					DescribeDcdnUserDomainsResponse.DescribeDcdnUserDomains_PageData.DescribeDcdnUserDomains_Source source = new DescribeDcdnUserDomainsResponse.DescribeDcdnUserDomains_PageData.DescribeDcdnUserDomains_Source();
					source.Type = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].Sources["+ j +"].Type");
					source.Content = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].Sources["+ j +"].Content");
					source.Port = _ctx.IntegerValue("DescribeDcdnUserDomains.Domains["+ i +"].Sources["+ j +"].Port");
					source.Priority = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].Sources["+ j +"].Priority");
					source.Weight = _ctx.StringValue("DescribeDcdnUserDomains.Domains["+ i +"].Sources["+ j +"].Weight");

					pageData_sources.Add(source);
				}
				pageData.Sources = pageData_sources;

				describeDcdnUserDomainsResponse_domains.Add(pageData);
			}
			describeDcdnUserDomainsResponse.Domains = describeDcdnUserDomainsResponse_domains;
        
			return describeDcdnUserDomainsResponse;
        }
    }
}
