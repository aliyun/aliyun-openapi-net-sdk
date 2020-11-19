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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeUserDomainsResponseUnmarshaller
    {
        public static DescribeUserDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserDomainsResponse describeUserDomainsResponse = new DescribeUserDomainsResponse();

			describeUserDomainsResponse.HttpResponse = _ctx.HttpResponse;
			describeUserDomainsResponse.RequestId = _ctx.StringValue("DescribeUserDomains.RequestId");
			describeUserDomainsResponse.PageNumber = _ctx.LongValue("DescribeUserDomains.PageNumber");
			describeUserDomainsResponse.PageSize = _ctx.LongValue("DescribeUserDomains.PageSize");
			describeUserDomainsResponse.TotalCount = _ctx.LongValue("DescribeUserDomains.TotalCount");

			List<DescribeUserDomainsResponse.DescribeUserDomains_PageData> describeUserDomainsResponse_domains = new List<DescribeUserDomainsResponse.DescribeUserDomains_PageData>();
			for (int i = 0; i < _ctx.Length("DescribeUserDomains.Domains.Length"); i++) {
				DescribeUserDomainsResponse.DescribeUserDomains_PageData pageData = new DescribeUserDomainsResponse.DescribeUserDomains_PageData();
				pageData.DomainName = _ctx.StringValue("DescribeUserDomains.Domains["+ i +"].DomainName");
				pageData.Cname = _ctx.StringValue("DescribeUserDomains.Domains["+ i +"].Cname");
				pageData.CdnType = _ctx.StringValue("DescribeUserDomains.Domains["+ i +"].CdnType");
				pageData.DomainStatus = _ctx.StringValue("DescribeUserDomains.Domains["+ i +"].DomainStatus");
				pageData.GmtCreated = _ctx.StringValue("DescribeUserDomains.Domains["+ i +"].GmtCreated");
				pageData.GmtModified = _ctx.StringValue("DescribeUserDomains.Domains["+ i +"].GmtModified");
				pageData.Description = _ctx.StringValue("DescribeUserDomains.Domains["+ i +"].Description");
				pageData.SourceType = _ctx.StringValue("DescribeUserDomains.Domains["+ i +"].SourceType");
				pageData.SslProtocol = _ctx.StringValue("DescribeUserDomains.Domains["+ i +"].SslProtocol");
				pageData.ResourceGroupId = _ctx.StringValue("DescribeUserDomains.Domains["+ i +"].ResourceGroupId");
				pageData.Sandbox = _ctx.StringValue("DescribeUserDomains.Domains["+ i +"].Sandbox");

				List<string> pageData_sources = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeUserDomains.Domains["+ i +"].Sources.Length"); j++) {
					pageData_sources.Add(_ctx.StringValue("DescribeUserDomains.Domains["+ i +"].Sources["+ j +"]"));
				}
				pageData.Sources = pageData_sources;

				describeUserDomainsResponse_domains.Add(pageData);
			}
			describeUserDomainsResponse.Domains = describeUserDomainsResponse_domains;
        
			return describeUserDomainsResponse;
        }
    }
}
