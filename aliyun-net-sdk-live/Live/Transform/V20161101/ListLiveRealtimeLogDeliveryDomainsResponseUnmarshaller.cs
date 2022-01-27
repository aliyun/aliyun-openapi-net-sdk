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
    public class ListLiveRealtimeLogDeliveryDomainsResponseUnmarshaller
    {
        public static ListLiveRealtimeLogDeliveryDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLiveRealtimeLogDeliveryDomainsResponse listLiveRealtimeLogDeliveryDomainsResponse = new ListLiveRealtimeLogDeliveryDomainsResponse();

			listLiveRealtimeLogDeliveryDomainsResponse.HttpResponse = _ctx.HttpResponse;
			listLiveRealtimeLogDeliveryDomainsResponse.RequestId = _ctx.StringValue("ListLiveRealtimeLogDeliveryDomains.RequestId");

			List<ListLiveRealtimeLogDeliveryDomainsResponse.ListLiveRealtimeLogDeliveryDomains_Domains> listLiveRealtimeLogDeliveryDomainsResponse_content = new List<ListLiveRealtimeLogDeliveryDomainsResponse.ListLiveRealtimeLogDeliveryDomains_Domains>();
			for (int i = 0; i < _ctx.Length("ListLiveRealtimeLogDeliveryDomains.Content.Length"); i++) {
				ListLiveRealtimeLogDeliveryDomainsResponse.ListLiveRealtimeLogDeliveryDomains_Domains domains = new ListLiveRealtimeLogDeliveryDomainsResponse.ListLiveRealtimeLogDeliveryDomains_Domains();
				domains.DomainName = _ctx.StringValue("ListLiveRealtimeLogDeliveryDomains.Content["+ i +"].DomainName");
				domains.Status = _ctx.StringValue("ListLiveRealtimeLogDeliveryDomains.Content["+ i +"].Status");

				listLiveRealtimeLogDeliveryDomainsResponse_content.Add(domains);
			}
			listLiveRealtimeLogDeliveryDomainsResponse.Content = listLiveRealtimeLogDeliveryDomainsResponse_content;
        
			return listLiveRealtimeLogDeliveryDomainsResponse;
        }
    }
}
