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
    public class ListRealtimeLogDeliveryInfosResponseUnmarshaller
    {
        public static ListRealtimeLogDeliveryInfosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRealtimeLogDeliveryInfosResponse listRealtimeLogDeliveryInfosResponse = new ListRealtimeLogDeliveryInfosResponse();

			listRealtimeLogDeliveryInfosResponse.HttpResponse = _ctx.HttpResponse;
			listRealtimeLogDeliveryInfosResponse.RequestId = _ctx.StringValue("ListRealtimeLogDeliveryInfos.RequestId");

			List<ListRealtimeLogDeliveryInfosResponse.ListRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos> listRealtimeLogDeliveryInfosResponse_content = new List<ListRealtimeLogDeliveryInfosResponse.ListRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos>();
			for (int i = 0; i < _ctx.Length("ListRealtimeLogDeliveryInfos.Content.Length"); i++) {
				ListRealtimeLogDeliveryInfosResponse.ListRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos realtimeLogDeliveryInfos = new ListRealtimeLogDeliveryInfosResponse.ListRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos();
				realtimeLogDeliveryInfos.Project = _ctx.StringValue("ListRealtimeLogDeliveryInfos.Content["+ i +"].Project");
				realtimeLogDeliveryInfos.Logstore = _ctx.StringValue("ListRealtimeLogDeliveryInfos.Content["+ i +"].Logstore");
				realtimeLogDeliveryInfos.Region = _ctx.StringValue("ListRealtimeLogDeliveryInfos.Content["+ i +"].Region");

				listRealtimeLogDeliveryInfosResponse_content.Add(realtimeLogDeliveryInfos);
			}
			listRealtimeLogDeliveryInfosResponse.Content = listRealtimeLogDeliveryInfosResponse_content;
        
			return listRealtimeLogDeliveryInfosResponse;
        }
    }
}
