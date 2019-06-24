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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodUserDomainsResponseUnmarshaller
    {
        public static DescribeVodUserDomainsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodUserDomainsResponse describeVodUserDomainsResponse = new DescribeVodUserDomainsResponse();

			describeVodUserDomainsResponse.HttpResponse = context.HttpResponse;
			describeVodUserDomainsResponse.RequestId = context.StringValue("DescribeVodUserDomains.RequestId");
			describeVodUserDomainsResponse.PageNumber = context.LongValue("DescribeVodUserDomains.PageNumber");
			describeVodUserDomainsResponse.PageSize = context.LongValue("DescribeVodUserDomains.PageSize");
			describeVodUserDomainsResponse.TotalCount = context.LongValue("DescribeVodUserDomains.TotalCount");

			List<DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData> describeVodUserDomainsResponse_domains = new List<DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData>();
			for (int i = 0; i < context.Length("DescribeVodUserDomains.Domains.Length"); i++) {
				DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData pageData = new DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData();
				pageData.DomainName = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].DomainName");
				pageData.Cname = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].Cname");
				pageData.CdnType = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].CdnType");
				pageData.DomainStatus = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].DomainStatus");
				pageData.GmtCreated = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].GmtCreated");
				pageData.GmtModified = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].GmtModified");
				pageData.Description = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].Description");
				pageData.SslProtocol = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].SslProtocol");
				pageData.Weight = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].Weight");
				pageData.Sandbox = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].Sandbox");

				List<DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData.DescribeVodUserDomains_Source> pageData_sources = new List<DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData.DescribeVodUserDomains_Source>();
				for (int j = 0; j < context.Length("DescribeVodUserDomains.Domains["+ i +"].Sources.Length"); j++) {
					DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData.DescribeVodUserDomains_Source source = new DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData.DescribeVodUserDomains_Source();
					source.Type = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].Sources["+ j +"].Type");
					source.Content = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].Sources["+ j +"].Content");
					source.Port = context.IntegerValue("DescribeVodUserDomains.Domains["+ i +"].Sources["+ j +"].Port");
					source.Priority = context.StringValue("DescribeVodUserDomains.Domains["+ i +"].Sources["+ j +"].Priority");

					pageData_sources.Add(source);
				}
				pageData.Sources = pageData_sources;

				describeVodUserDomainsResponse_domains.Add(pageData);
			}
			describeVodUserDomainsResponse.Domains = describeVodUserDomainsResponse_domains;
        
			return describeVodUserDomainsResponse;
        }
    }
}
