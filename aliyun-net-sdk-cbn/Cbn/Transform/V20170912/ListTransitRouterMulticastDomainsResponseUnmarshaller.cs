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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class ListTransitRouterMulticastDomainsResponseUnmarshaller
    {
        public static ListTransitRouterMulticastDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterMulticastDomainsResponse listTransitRouterMulticastDomainsResponse = new ListTransitRouterMulticastDomainsResponse();

			listTransitRouterMulticastDomainsResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterMulticastDomainsResponse.RequestId = _ctx.StringValue("ListTransitRouterMulticastDomains.RequestId");
			listTransitRouterMulticastDomainsResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterMulticastDomains.TotalCount");
			listTransitRouterMulticastDomainsResponse.MaxResults = _ctx.IntegerValue("ListTransitRouterMulticastDomains.MaxResults");
			listTransitRouterMulticastDomainsResponse.NextToken = _ctx.StringValue("ListTransitRouterMulticastDomains.NextToken");

			List<ListTransitRouterMulticastDomainsResponse.ListTransitRouterMulticastDomains_TransitRouterMulticastDomain> listTransitRouterMulticastDomainsResponse_transitRouterMulticastDomains = new List<ListTransitRouterMulticastDomainsResponse.ListTransitRouterMulticastDomains_TransitRouterMulticastDomain>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterMulticastDomains.TransitRouterMulticastDomains.Length"); i++) {
				ListTransitRouterMulticastDomainsResponse.ListTransitRouterMulticastDomains_TransitRouterMulticastDomain transitRouterMulticastDomain = new ListTransitRouterMulticastDomainsResponse.ListTransitRouterMulticastDomains_TransitRouterMulticastDomain();
				transitRouterMulticastDomain.TransitRouterMulticastDomainId = _ctx.StringValue("ListTransitRouterMulticastDomains.TransitRouterMulticastDomains["+ i +"].TransitRouterMulticastDomainId");
				transitRouterMulticastDomain.TransitRouterMulticastDomainName = _ctx.StringValue("ListTransitRouterMulticastDomains.TransitRouterMulticastDomains["+ i +"].TransitRouterMulticastDomainName");
				transitRouterMulticastDomain.TransitRouterMulticastDomainDescription = _ctx.StringValue("ListTransitRouterMulticastDomains.TransitRouterMulticastDomains["+ i +"].TransitRouterMulticastDomainDescription");
				transitRouterMulticastDomain.Status = _ctx.StringValue("ListTransitRouterMulticastDomains.TransitRouterMulticastDomains["+ i +"].Status");

				listTransitRouterMulticastDomainsResponse_transitRouterMulticastDomains.Add(transitRouterMulticastDomain);
			}
			listTransitRouterMulticastDomainsResponse.TransitRouterMulticastDomains = listTransitRouterMulticastDomainsResponse_transitRouterMulticastDomains;
        
			return listTransitRouterMulticastDomainsResponse;
        }
    }
}
