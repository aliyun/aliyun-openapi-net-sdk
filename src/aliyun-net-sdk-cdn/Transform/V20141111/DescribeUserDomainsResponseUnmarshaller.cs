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
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeUserDomainsResponseUnmarshaller
    {
        public static DescribeUserDomainsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeUserDomainsResponse describeUserDomainsResponse = new DescribeUserDomainsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeUserDomains.RequestId"),
                PageNumber = context.LongValue("DescribeUserDomains.PageNumber"),
                PageSize = context.LongValue("DescribeUserDomains.PageSize"),
                TotalCount = context.LongValue("DescribeUserDomains.TotalCount")
            };
            List<DescribeUserDomainsResponse.PageData> domains = new List<DescribeUserDomainsResponse.PageData>();
			for (int i = 0; i < context.Length("DescribeUserDomains.Domains.Length"); i++) {
                DescribeUserDomainsResponse.PageData pageData = new DescribeUserDomainsResponse.PageData()
                {
                    DomainName = context.StringValue($"DescribeUserDomains.Domains[{i}].DomainName"),
                    Cname = context.StringValue($"DescribeUserDomains.Domains[{i}].Cname"),
                    CdnType = context.StringValue($"DescribeUserDomains.Domains[{i}].CdnType"),
                    DomainStatus = context.StringValue($"DescribeUserDomains.Domains[{i}].DomainStatus"),
                    GmtCreated = context.StringValue($"DescribeUserDomains.Domains[{i}].GmtCreated"),
                    GmtModified = context.StringValue($"DescribeUserDomains.Domains[{i}].GmtModified"),
                    Description = context.StringValue($"DescribeUserDomains.Domains[{i}].Description"),
                    SourceType = context.StringValue($"DescribeUserDomains.Domains[{i}].SourceType"),
                    SslProtocol = context.StringValue($"DescribeUserDomains.Domains[{i}].SslProtocol")
                };
                List<string> sources = new List<string>();
				for (int j = 0; j < context.Length($"DescribeUserDomains.Domains[{i}].Sources.Length"); j++) {
					sources.Add(context.StringValue($"DescribeUserDomains.Domains[{i}].Sources[{j}]"));
				}
				pageData.Sources = sources;

				domains.Add(pageData);
			}
			describeUserDomainsResponse.Domains = domains;
        
			return describeUserDomainsResponse;
        }
    }
}