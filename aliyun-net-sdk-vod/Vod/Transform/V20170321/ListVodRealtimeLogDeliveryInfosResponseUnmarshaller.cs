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
    public class ListVodRealtimeLogDeliveryInfosResponseUnmarshaller
    {
        public static ListVodRealtimeLogDeliveryInfosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVodRealtimeLogDeliveryInfosResponse listVodRealtimeLogDeliveryInfosResponse = new ListVodRealtimeLogDeliveryInfosResponse();

			listVodRealtimeLogDeliveryInfosResponse.HttpResponse = _ctx.HttpResponse;
			listVodRealtimeLogDeliveryInfosResponse.RequestId = _ctx.StringValue("ListVodRealtimeLogDeliveryInfos.RequestId");

			List<ListVodRealtimeLogDeliveryInfosResponse.ListVodRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos> listVodRealtimeLogDeliveryInfosResponse_content = new List<ListVodRealtimeLogDeliveryInfosResponse.ListVodRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos>();
			for (int i = 0; i < _ctx.Length("ListVodRealtimeLogDeliveryInfos.Content.Length"); i++) {
				ListVodRealtimeLogDeliveryInfosResponse.ListVodRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos realtimeLogDeliveryInfos = new ListVodRealtimeLogDeliveryInfosResponse.ListVodRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos();
				realtimeLogDeliveryInfos.Project = _ctx.StringValue("ListVodRealtimeLogDeliveryInfos.Content["+ i +"].Project");
				realtimeLogDeliveryInfos.Logstore = _ctx.StringValue("ListVodRealtimeLogDeliveryInfos.Content["+ i +"].Logstore");
				realtimeLogDeliveryInfos.Region = _ctx.StringValue("ListVodRealtimeLogDeliveryInfos.Content["+ i +"].Region");

				listVodRealtimeLogDeliveryInfosResponse_content.Add(realtimeLogDeliveryInfos);
			}
			listVodRealtimeLogDeliveryInfosResponse.Content = listVodRealtimeLogDeliveryInfosResponse_content;
        
			return listVodRealtimeLogDeliveryInfosResponse;
        }
    }
}
