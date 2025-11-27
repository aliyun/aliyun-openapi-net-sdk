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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListInstanceHistoryEventsResponseUnmarshaller
    {
        public static ListInstanceHistoryEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstanceHistoryEventsResponse listInstanceHistoryEventsResponse = new ListInstanceHistoryEventsResponse();

			listInstanceHistoryEventsResponse.HttpResponse = _ctx.HttpResponse;
			listInstanceHistoryEventsResponse.RequestId = _ctx.StringValue("ListInstanceHistoryEvents.RequestId");

			ListInstanceHistoryEventsResponse.ListInstanceHistoryEvents_Headers headers = new ListInstanceHistoryEventsResponse.ListInstanceHistoryEvents_Headers();
			headers.XTotalCount = _ctx.LongValue("ListInstanceHistoryEvents.Headers.X-Total-Count");
			headers.XTotalFailed = _ctx.LongValue("ListInstanceHistoryEvents.Headers.X-Total-Failed");
			headers.XTotalSuccess = _ctx.LongValue("ListInstanceHistoryEvents.Headers.X-Total-Success");
			listInstanceHistoryEventsResponse.Headers = headers;

			List<ListInstanceHistoryEventsResponse.ListInstanceHistoryEvents_ResultItem> listInstanceHistoryEventsResponse_result = new List<ListInstanceHistoryEventsResponse.ListInstanceHistoryEvents_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListInstanceHistoryEvents.Result.Length"); i++) {
				ListInstanceHistoryEventsResponse.ListInstanceHistoryEvents_ResultItem resultItem = new ListInstanceHistoryEventsResponse.ListInstanceHistoryEvents_ResultItem();
				resultItem.EventCreateTime = _ctx.StringValue("ListInstanceHistoryEvents.Result["+ i +"].eventCreateTime");
				resultItem.EventCycleStatus = _ctx.StringValue("ListInstanceHistoryEvents.Result["+ i +"].eventCycleStatus");
				resultItem.EventExecuteTime = _ctx.StringValue("ListInstanceHistoryEvents.Result["+ i +"].eventExecuteTime");
				resultItem.EventFinashTime = _ctx.StringValue("ListInstanceHistoryEvents.Result["+ i +"].eventFinashTime");
				resultItem.EventLevel = _ctx.StringValue("ListInstanceHistoryEvents.Result["+ i +"].eventLevel");
				resultItem.InstanceId = _ctx.StringValue("ListInstanceHistoryEvents.Result["+ i +"].instanceId");
				resultItem.NodeIP = _ctx.StringValue("ListInstanceHistoryEvents.Result["+ i +"].nodeIP");
				resultItem.EventType = _ctx.StringValue("ListInstanceHistoryEvents.Result["+ i +"].eventType");
				resultItem.RegionId = _ctx.StringValue("ListInstanceHistoryEvents.Result["+ i +"].regionId");
				resultItem.EcsId = _ctx.StringValue("ListInstanceHistoryEvents.Result["+ i +"].ecsId");

				listInstanceHistoryEventsResponse_result.Add(resultItem);
			}
			listInstanceHistoryEventsResponse.Result = listInstanceHistoryEventsResponse_result;
        
			return listInstanceHistoryEventsResponse;
        }
    }
}
