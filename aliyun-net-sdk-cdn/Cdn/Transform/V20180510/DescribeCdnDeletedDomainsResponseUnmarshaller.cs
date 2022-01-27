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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnDeletedDomainsResponseUnmarshaller
    {
        public static DescribeCdnDeletedDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnDeletedDomainsResponse describeCdnDeletedDomainsResponse = new DescribeCdnDeletedDomainsResponse();

			describeCdnDeletedDomainsResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnDeletedDomainsResponse.RequestId = _ctx.StringValue("DescribeCdnDeletedDomains.RequestId");
			describeCdnDeletedDomainsResponse.PageNumber = _ctx.LongValue("DescribeCdnDeletedDomains.PageNumber");
			describeCdnDeletedDomainsResponse.PageSize = _ctx.LongValue("DescribeCdnDeletedDomains.PageSize");
			describeCdnDeletedDomainsResponse.TotalCount = _ctx.LongValue("DescribeCdnDeletedDomains.TotalCount");

			List<DescribeCdnDeletedDomainsResponse.DescribeCdnDeletedDomains_PageData> describeCdnDeletedDomainsResponse_domains = new List<DescribeCdnDeletedDomainsResponse.DescribeCdnDeletedDomains_PageData>();
			for (int i = 0; i < _ctx.Length("DescribeCdnDeletedDomains.Domains.Length"); i++) {
				DescribeCdnDeletedDomainsResponse.DescribeCdnDeletedDomains_PageData pageData = new DescribeCdnDeletedDomainsResponse.DescribeCdnDeletedDomains_PageData();
				pageData.DomainName = _ctx.StringValue("DescribeCdnDeletedDomains.Domains["+ i +"].DomainName");
				pageData.GmtModified = _ctx.StringValue("DescribeCdnDeletedDomains.Domains["+ i +"].GmtModified");

				describeCdnDeletedDomainsResponse_domains.Add(pageData);
			}
			describeCdnDeletedDomainsResponse.Domains = describeCdnDeletedDomainsResponse_domains;
        
			return describeCdnDeletedDomainsResponse;
        }
    }
}
