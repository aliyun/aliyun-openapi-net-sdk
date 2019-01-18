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
using Aliyun.Acs.Cdn.Model.V20180510;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20180510
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
				pageData.SslProtocol = context.StringValue("DescribeUserDomains.Domains["+ i +"].SslProtocol");
				pageData.ResourceGroupId = context.StringValue("DescribeUserDomains.Domains["+ i +"].ResourceGroupId");
				pageData.Sandbox = context.StringValue("DescribeUserDomains.Domains["+ i +"].Sandbox");

				List<DescribeUserDomainsResponse.DescribeUserDomains_PageData.DescribeUserDomains_Source> pageData_sources = new List<DescribeUserDomainsResponse.DescribeUserDomains_PageData.DescribeUserDomains_Source>();
				for (int j = 0; j < context.Length("DescribeUserDomains.Domains["+ i +"].Sources.Length"); j++) {
					DescribeUserDomainsResponse.DescribeUserDomains_PageData.DescribeUserDomains_Source source = new DescribeUserDomainsResponse.DescribeUserDomains_PageData.DescribeUserDomains_Source();
					source.Type = context.StringValue("DescribeUserDomains.Domains["+ i +"].Sources["+ j +"].Type");
					source.Content = context.StringValue("DescribeUserDomains.Domains["+ i +"].Sources["+ j +"].Content");
					source.Port = context.IntegerValue("DescribeUserDomains.Domains["+ i +"].Sources["+ j +"].Port");
					source.Priority = context.StringValue("DescribeUserDomains.Domains["+ i +"].Sources["+ j +"].Priority");
					source.Weight = context.StringValue("DescribeUserDomains.Domains["+ i +"].Sources["+ j +"].Weight");

					pageData_sources.Add(source);
				}
				pageData.Sources = pageData_sources;

				describeUserDomainsResponse_domains.Add(pageData);
			}
			describeUserDomainsResponse.Domains = describeUserDomainsResponse_domains;
        
			return describeUserDomainsResponse;
        }
    }
}