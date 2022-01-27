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
using Aliyun.Acs.Httpdns.Model.V20160201;

namespace Aliyun.Acs.Httpdns.Transform.V20160201
{
    public class ListDomainsResponseUnmarshaller
    {
        public static ListDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDomainsResponse listDomainsResponse = new ListDomainsResponse();

			listDomainsResponse.HttpResponse = _ctx.HttpResponse;
			listDomainsResponse.RequestId = _ctx.StringValue("ListDomains.RequestId");
			listDomainsResponse.TotalCount = _ctx.LongValue("ListDomains.TotalCount");
			listDomainsResponse.PageNumber = _ctx.LongValue("ListDomains.PageNumber");
			listDomainsResponse.PageSize = _ctx.LongValue("ListDomains.PageSize");

			List<ListDomainsResponse.ListDomains_DomainInfo> listDomainsResponse_domainInfos = new List<ListDomainsResponse.ListDomains_DomainInfo>();
			for (int i = 0; i < _ctx.Length("ListDomains.DomainInfos.Length"); i++) {
				ListDomainsResponse.ListDomains_DomainInfo domainInfo = new ListDomainsResponse.ListDomains_DomainInfo();
				domainInfo.DomainName = _ctx.StringValue("ListDomains.DomainInfos["+ i +"].DomainName");
				domainInfo.Resolved = _ctx.LongValue("ListDomains.DomainInfos["+ i +"].Resolved");
				domainInfo.ResolvedHttps = _ctx.LongValue("ListDomains.DomainInfos["+ i +"].ResolvedHttps");
				domainInfo.Resolved6 = _ctx.LongValue("ListDomains.DomainInfos["+ i +"].Resolved6");
				domainInfo.ResolvedHttps6 = _ctx.LongValue("ListDomains.DomainInfos["+ i +"].ResolvedHttps6");

				listDomainsResponse_domainInfos.Add(domainInfo);
			}
			listDomainsResponse.DomainInfos = listDomainsResponse_domainInfos;
        
			return listDomainsResponse;
        }
    }
}
