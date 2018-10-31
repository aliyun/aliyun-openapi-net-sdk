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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeUserDomainsResponseUnmarshaller
    {
        public static DescribeUserDomainsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserDomainsResponse describeUserDomainsResponse = new DescribeUserDomainsResponse();

			describeUserDomainsResponse.HttpResponse = context.HttpResponse;
			describeUserDomainsResponse.RequestId = context.StringValue("DescribeUserDomains.RequestId");
			describeUserDomainsResponse.PageNumber = context.LongValue("DescribeUserDomains.PageNumber");
			describeUserDomainsResponse.PageSize = context.LongValue("DescribeUserDomains.PageSize");
			describeUserDomainsResponse.TotalCount = context.LongValue("DescribeUserDomains.TotalCount");

			List<DescribeUserDomainsResponse.DescribeUserDomains_PageData> describeUserDomainsResponse_domains = new List<DescribeUserDomainsResponse.DescribeUserDomains_PageData>();
			for (int i = 0; i < context.Length("DescribeUserDomains.Domains.Length"); i++) {
				DescribeUserDomainsResponse.DescribeUserDomains_PageData pageData = new DescribeUserDomainsResponse.DescribeUserDomains_PageData();
				pageData.DomainName = context.StringValue("DescribeUserDomains.Domains["+ i +"].DomainName");
				pageData.Cname = context.StringValue("DescribeUserDomains.Domains["+ i +"].Cname");
				pageData.CdnType = context.StringValue("DescribeUserDomains.Domains["+ i +"].CdnType");
				pageData.DomainStatus = context.StringValue("DescribeUserDomains.Domains["+ i +"].DomainStatus");
				pageData.GmtCreated = context.StringValue("DescribeUserDomains.Domains["+ i +"].GmtCreated");
				pageData.GmtModified = context.StringValue("DescribeUserDomains.Domains["+ i +"].GmtModified");
				pageData.Description = context.StringValue("DescribeUserDomains.Domains["+ i +"].Description");
				pageData.SourceType = context.StringValue("DescribeUserDomains.Domains["+ i +"].SourceType");
				pageData.SslProtocol = context.StringValue("DescribeUserDomains.Domains["+ i +"].SslProtocol");
				pageData.ResourceGroupId = context.StringValue("DescribeUserDomains.Domains["+ i +"].ResourceGroupId");
				pageData.Sandbox = context.StringValue("DescribeUserDomains.Domains["+ i +"].Sandbox");

				List<string> pageData_sources = new List<string>();
				for (int j = 0; j < context.Length("DescribeUserDomains.Domains["+ i +"].Sources.Length"); j++) {
					pageData_sources.Add(context.StringValue("DescribeUserDomains.Domains["+ i +"].Sources["+ j +"]"));
				}
				pageData.Sources = pageData_sources;

				describeUserDomainsResponse_domains.Add(pageData);
			}
			describeUserDomainsResponse.Domains = describeUserDomainsResponse_domains;
        
			return describeUserDomainsResponse;
        }
    }
}