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
    public class DescribeDcdnDeletedDomainsResponseUnmarshaller
    {
        public static DescribeDcdnDeletedDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDeletedDomainsResponse describeDcdnDeletedDomainsResponse = new DescribeDcdnDeletedDomainsResponse();

			describeDcdnDeletedDomainsResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDeletedDomainsResponse.RequestId = _ctx.StringValue("DescribeDcdnDeletedDomains.RequestId");
			describeDcdnDeletedDomainsResponse.PageNumber = _ctx.LongValue("DescribeDcdnDeletedDomains.PageNumber");
			describeDcdnDeletedDomainsResponse.PageSize = _ctx.LongValue("DescribeDcdnDeletedDomains.PageSize");
			describeDcdnDeletedDomainsResponse.TotalCount = _ctx.LongValue("DescribeDcdnDeletedDomains.TotalCount");

			List<DescribeDcdnDeletedDomainsResponse.DescribeDcdnDeletedDomains_PageData> describeDcdnDeletedDomainsResponse_domains = new List<DescribeDcdnDeletedDomainsResponse.DescribeDcdnDeletedDomains_PageData>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDeletedDomains.Domains.Length"); i++) {
				DescribeDcdnDeletedDomainsResponse.DescribeDcdnDeletedDomains_PageData pageData = new DescribeDcdnDeletedDomainsResponse.DescribeDcdnDeletedDomains_PageData();
				pageData.DomainName = _ctx.StringValue("DescribeDcdnDeletedDomains.Domains["+ i +"].DomainName");
				pageData.GmtModified = _ctx.StringValue("DescribeDcdnDeletedDomains.Domains["+ i +"].GmtModified");

				describeDcdnDeletedDomainsResponse_domains.Add(pageData);
			}
			describeDcdnDeletedDomainsResponse.Domains = describeDcdnDeletedDomainsResponse_domains;
        
			return describeDcdnDeletedDomainsResponse;
        }
    }
}
