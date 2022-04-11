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
        public static DescribeVodUserDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodUserDomainsResponse describeVodUserDomainsResponse = new DescribeVodUserDomainsResponse();

			describeVodUserDomainsResponse.HttpResponse = _ctx.HttpResponse;
			describeVodUserDomainsResponse.RequestId = _ctx.StringValue("DescribeVodUserDomains.RequestId");
			describeVodUserDomainsResponse.PageNumber = _ctx.LongValue("DescribeVodUserDomains.PageNumber");
			describeVodUserDomainsResponse.PageSize = _ctx.LongValue("DescribeVodUserDomains.PageSize");
			describeVodUserDomainsResponse.TotalCount = _ctx.LongValue("DescribeVodUserDomains.TotalCount");

			List<DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData> describeVodUserDomainsResponse_domains = new List<DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData>();
			for (int i = 0; i < _ctx.Length("DescribeVodUserDomains.Domains.Length"); i++) {
				DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData pageData = new DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData();
				pageData.GmtCreated = _ctx.StringValue("DescribeVodUserDomains.Domains["+ i +"].GmtCreated");
				pageData.SslProtocol = _ctx.StringValue("DescribeVodUserDomains.Domains["+ i +"].SslProtocol");
				pageData.Description = _ctx.StringValue("DescribeVodUserDomains.Domains["+ i +"].Description");
				pageData.Sandbox = _ctx.StringValue("DescribeVodUserDomains.Domains["+ i +"].Sandbox");
				pageData.Cname = _ctx.StringValue("DescribeVodUserDomains.Domains["+ i +"].Cname");
				pageData.DomainStatus = _ctx.StringValue("DescribeVodUserDomains.Domains["+ i +"].DomainStatus");
				pageData.GmtModified = _ctx.StringValue("DescribeVodUserDomains.Domains["+ i +"].GmtModified");
				pageData.DomainName = _ctx.StringValue("DescribeVodUserDomains.Domains["+ i +"].DomainName");

				List<DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData.DescribeVodUserDomains_Source> pageData_sources = new List<DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData.DescribeVodUserDomains_Source>();
				for (int j = 0; j < _ctx.Length("DescribeVodUserDomains.Domains["+ i +"].Sources.Length"); j++) {
					DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData.DescribeVodUserDomains_Source source = new DescribeVodUserDomainsResponse.DescribeVodUserDomains_PageData.DescribeVodUserDomains_Source();
					source.Type = _ctx.StringValue("DescribeVodUserDomains.Domains["+ i +"].Sources["+ j +"].Type");
					source.Priority = _ctx.StringValue("DescribeVodUserDomains.Domains["+ i +"].Sources["+ j +"].Priority");
					source.Port = _ctx.IntegerValue("DescribeVodUserDomains.Domains["+ i +"].Sources["+ j +"].Port");
					source.Content = _ctx.StringValue("DescribeVodUserDomains.Domains["+ i +"].Sources["+ j +"].Content");

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
