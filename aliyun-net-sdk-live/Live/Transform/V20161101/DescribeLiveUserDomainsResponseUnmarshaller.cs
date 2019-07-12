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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveUserDomainsResponseUnmarshaller
    {
        public static DescribeLiveUserDomainsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveUserDomainsResponse describeLiveUserDomainsResponse = new DescribeLiveUserDomainsResponse();

			describeLiveUserDomainsResponse.HttpResponse = context.HttpResponse;
			describeLiveUserDomainsResponse.RequestId = context.StringValue("DescribeLiveUserDomains.RequestId");
			describeLiveUserDomainsResponse.PageNumber = context.LongValue("DescribeLiveUserDomains.PageNumber");
			describeLiveUserDomainsResponse.PageSize = context.LongValue("DescribeLiveUserDomains.PageSize");
			describeLiveUserDomainsResponse.TotalCount = context.LongValue("DescribeLiveUserDomains.TotalCount");

			List<DescribeLiveUserDomainsResponse.DescribeLiveUserDomains_PageData> describeLiveUserDomainsResponse_domains = new List<DescribeLiveUserDomainsResponse.DescribeLiveUserDomains_PageData>();
			for (int i = 0; i < context.Length("DescribeLiveUserDomains.Domains.Length"); i++) {
				DescribeLiveUserDomainsResponse.DescribeLiveUserDomains_PageData pageData = new DescribeLiveUserDomainsResponse.DescribeLiveUserDomains_PageData();
				pageData.DomainName = context.StringValue("DescribeLiveUserDomains.Domains["+ i +"].DomainName");
				pageData.Cname = context.StringValue("DescribeLiveUserDomains.Domains["+ i +"].Cname");
				pageData.LiveDomainType = context.StringValue("DescribeLiveUserDomains.Domains["+ i +"].LiveDomainType");
				pageData.GmtCreated = context.StringValue("DescribeLiveUserDomains.Domains["+ i +"].GmtCreated");
				pageData.GmtModified = context.StringValue("DescribeLiveUserDomains.Domains["+ i +"].GmtModified");
				pageData.Description = context.StringValue("DescribeLiveUserDomains.Domains["+ i +"].Description");
				pageData.LiveDomainStatus = context.StringValue("DescribeLiveUserDomains.Domains["+ i +"].LiveDomainStatus");
				pageData.RegionName = context.StringValue("DescribeLiveUserDomains.Domains["+ i +"].RegionName");

				describeLiveUserDomainsResponse_domains.Add(pageData);
			}
			describeLiveUserDomainsResponse.Domains = describeLiveUserDomainsResponse_domains;
        
			return describeLiveUserDomainsResponse;
        }
    }
}
