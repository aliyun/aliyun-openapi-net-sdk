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
    public class ListLiveRealtimeLogDeliveryInfosResponseUnmarshaller
    {
        public static ListLiveRealtimeLogDeliveryInfosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLiveRealtimeLogDeliveryInfosResponse listLiveRealtimeLogDeliveryInfosResponse = new ListLiveRealtimeLogDeliveryInfosResponse();

			listLiveRealtimeLogDeliveryInfosResponse.HttpResponse = _ctx.HttpResponse;
			listLiveRealtimeLogDeliveryInfosResponse.RequestId = _ctx.StringValue("ListLiveRealtimeLogDeliveryInfos.RequestId");

			List<ListLiveRealtimeLogDeliveryInfosResponse.ListLiveRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos> listLiveRealtimeLogDeliveryInfosResponse_content = new List<ListLiveRealtimeLogDeliveryInfosResponse.ListLiveRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos>();
			for (int i = 0; i < _ctx.Length("ListLiveRealtimeLogDeliveryInfos.Content.Length"); i++) {
				ListLiveRealtimeLogDeliveryInfosResponse.ListLiveRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos realtimeLogDeliveryInfos = new ListLiveRealtimeLogDeliveryInfosResponse.ListLiveRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos();
				realtimeLogDeliveryInfos.Project = _ctx.StringValue("ListLiveRealtimeLogDeliveryInfos.Content["+ i +"].Project");
				realtimeLogDeliveryInfos.Logstore = _ctx.StringValue("ListLiveRealtimeLogDeliveryInfos.Content["+ i +"].Logstore");
				realtimeLogDeliveryInfos.Region = _ctx.StringValue("ListLiveRealtimeLogDeliveryInfos.Content["+ i +"].Region");

				listLiveRealtimeLogDeliveryInfosResponse_content.Add(realtimeLogDeliveryInfos);
			}
			listLiveRealtimeLogDeliveryInfosResponse.Content = listLiveRealtimeLogDeliveryInfosResponse_content;
        
			return listLiveRealtimeLogDeliveryInfosResponse;
        }
    }
}
