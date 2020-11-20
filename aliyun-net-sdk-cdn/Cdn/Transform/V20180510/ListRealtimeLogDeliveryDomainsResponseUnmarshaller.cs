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
    public class ListRealtimeLogDeliveryDomainsResponseUnmarshaller
    {
        public static ListRealtimeLogDeliveryDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRealtimeLogDeliveryDomainsResponse listRealtimeLogDeliveryDomainsResponse = new ListRealtimeLogDeliveryDomainsResponse();

			listRealtimeLogDeliveryDomainsResponse.HttpResponse = _ctx.HttpResponse;
			listRealtimeLogDeliveryDomainsResponse.RequestId = _ctx.StringValue("ListRealtimeLogDeliveryDomains.RequestId");

			List<ListRealtimeLogDeliveryDomainsResponse.ListRealtimeLogDeliveryDomains_Domains> listRealtimeLogDeliveryDomainsResponse_content = new List<ListRealtimeLogDeliveryDomainsResponse.ListRealtimeLogDeliveryDomains_Domains>();
			for (int i = 0; i < _ctx.Length("ListRealtimeLogDeliveryDomains.Content.Length"); i++) {
				ListRealtimeLogDeliveryDomainsResponse.ListRealtimeLogDeliveryDomains_Domains domains = new ListRealtimeLogDeliveryDomainsResponse.ListRealtimeLogDeliveryDomains_Domains();
				domains.DomainName = _ctx.StringValue("ListRealtimeLogDeliveryDomains.Content["+ i +"].DomainName");
				domains.Status = _ctx.StringValue("ListRealtimeLogDeliveryDomains.Content["+ i +"].Status");

				listRealtimeLogDeliveryDomainsResponse_content.Add(domains);
			}
			listRealtimeLogDeliveryDomainsResponse.Content = listRealtimeLogDeliveryDomainsResponse_content;
        
			return listRealtimeLogDeliveryDomainsResponse;
        }
    }
}
