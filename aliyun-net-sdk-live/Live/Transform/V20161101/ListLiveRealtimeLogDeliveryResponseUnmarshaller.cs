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
    public class ListLiveRealtimeLogDeliveryResponseUnmarshaller
    {
        public static ListLiveRealtimeLogDeliveryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLiveRealtimeLogDeliveryResponse listLiveRealtimeLogDeliveryResponse = new ListLiveRealtimeLogDeliveryResponse();

			listLiveRealtimeLogDeliveryResponse.HttpResponse = _ctx.HttpResponse;
			listLiveRealtimeLogDeliveryResponse.RequestId = _ctx.StringValue("ListLiveRealtimeLogDelivery.RequestId");

			List<ListLiveRealtimeLogDeliveryResponse.ListLiveRealtimeLogDelivery_RealtimeLogDeliveryInfo> listLiveRealtimeLogDeliveryResponse_content = new List<ListLiveRealtimeLogDeliveryResponse.ListLiveRealtimeLogDelivery_RealtimeLogDeliveryInfo>();
			for (int i = 0; i < _ctx.Length("ListLiveRealtimeLogDelivery.Content.Length"); i++) {
				ListLiveRealtimeLogDeliveryResponse.ListLiveRealtimeLogDelivery_RealtimeLogDeliveryInfo realtimeLogDeliveryInfo = new ListLiveRealtimeLogDeliveryResponse.ListLiveRealtimeLogDelivery_RealtimeLogDeliveryInfo();
				realtimeLogDeliveryInfo.Project = _ctx.StringValue("ListLiveRealtimeLogDelivery.Content["+ i +"].Project");
				realtimeLogDeliveryInfo.Logstore = _ctx.StringValue("ListLiveRealtimeLogDelivery.Content["+ i +"].Logstore");
				realtimeLogDeliveryInfo.Region = _ctx.StringValue("ListLiveRealtimeLogDelivery.Content["+ i +"].Region");
				realtimeLogDeliveryInfo.DomainName = _ctx.StringValue("ListLiveRealtimeLogDelivery.Content["+ i +"].DomainName");
				realtimeLogDeliveryInfo.DmId = _ctx.IntegerValue("ListLiveRealtimeLogDelivery.Content["+ i +"].DmId");
				realtimeLogDeliveryInfo.Status = _ctx.StringValue("ListLiveRealtimeLogDelivery.Content["+ i +"].Status");

				listLiveRealtimeLogDeliveryResponse_content.Add(realtimeLogDeliveryInfo);
			}
			listLiveRealtimeLogDeliveryResponse.Content = listLiveRealtimeLogDeliveryResponse_content;
        
			return listLiveRealtimeLogDeliveryResponse;
        }
    }
}
