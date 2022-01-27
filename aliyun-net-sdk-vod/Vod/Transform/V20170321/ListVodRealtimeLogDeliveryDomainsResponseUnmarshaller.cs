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
    public class ListVodRealtimeLogDeliveryDomainsResponseUnmarshaller
    {
        public static ListVodRealtimeLogDeliveryDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVodRealtimeLogDeliveryDomainsResponse listVodRealtimeLogDeliveryDomainsResponse = new ListVodRealtimeLogDeliveryDomainsResponse();

			listVodRealtimeLogDeliveryDomainsResponse.HttpResponse = _ctx.HttpResponse;
			listVodRealtimeLogDeliveryDomainsResponse.RequestId = _ctx.StringValue("ListVodRealtimeLogDeliveryDomains.RequestId");

			List<ListVodRealtimeLogDeliveryDomainsResponse.ListVodRealtimeLogDeliveryDomains_Domains> listVodRealtimeLogDeliveryDomainsResponse_content = new List<ListVodRealtimeLogDeliveryDomainsResponse.ListVodRealtimeLogDeliveryDomains_Domains>();
			for (int i = 0; i < _ctx.Length("ListVodRealtimeLogDeliveryDomains.Content.Length"); i++) {
				ListVodRealtimeLogDeliveryDomainsResponse.ListVodRealtimeLogDeliveryDomains_Domains domains = new ListVodRealtimeLogDeliveryDomainsResponse.ListVodRealtimeLogDeliveryDomains_Domains();
				domains.DomainName = _ctx.StringValue("ListVodRealtimeLogDeliveryDomains.Content["+ i +"].DomainName");
				domains.Status = _ctx.StringValue("ListVodRealtimeLogDeliveryDomains.Content["+ i +"].Status");

				listVodRealtimeLogDeliveryDomainsResponse_content.Add(domains);
			}
			listVodRealtimeLogDeliveryDomainsResponse.Content = listVodRealtimeLogDeliveryDomainsResponse_content;
        
			return listVodRealtimeLogDeliveryDomainsResponse;
        }
    }
}
