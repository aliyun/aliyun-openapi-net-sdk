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
    public class ListEventSubEventResponseUnmarshaller
    {
        public static ListEventSubEventResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEventSubEventResponse listEventSubEventResponse = new ListEventSubEventResponse();

			listEventSubEventResponse.HttpResponse = _ctx.HttpResponse;
			listEventSubEventResponse.RequestId = _ctx.StringValue("ListEventSubEvent.RequestId");
			listEventSubEventResponse.Count = _ctx.LongValue("ListEventSubEvent.Count");
			listEventSubEventResponse.HasMore = _ctx.BooleanValue("ListEventSubEvent.HasMore");

			List<ListEventSubEventResponse.ListEventSubEvent_LogsItem> listEventSubEventResponse_logs = new List<ListEventSubEventResponse.ListEventSubEvent_LogsItem>();
			for (int i = 0; i < _ctx.Length("ListEventSubEvent.Logs.Length"); i++) {
				ListEventSubEventResponse.ListEventSubEvent_LogsItem logsItem = new ListEventSubEventResponse.ListEventSubEvent_LogsItem();
				logsItem.AppId = _ctx.StringValue("ListEventSubEvent.Logs["+ i +"].AppId");
				logsItem.SubId = _ctx.StringValue("ListEventSubEvent.Logs["+ i +"].SubId");
				logsItem.MessageId = _ctx.StringValue("ListEventSubEvent.Logs["+ i +"].MessageId");
				logsItem.Data = _ctx.StringValue("ListEventSubEvent.Logs["+ i +"].Data");
				logsItem.Cost = _ctx.IntegerValue("ListEventSubEvent.Logs["+ i +"].Cost");
				logsItem.Time = _ctx.StringValue("ListEventSubEvent.Logs["+ i +"].Time");
				logsItem.Url = _ctx.StringValue("ListEventSubEvent.Logs["+ i +"].Url");
				logsItem.Code = _ctx.IntegerValue("ListEventSubEvent.Logs["+ i +"].Code");

				listEventSubEventResponse_logs.Add(logsItem);
			}
			listEventSubEventResponse.Logs = listEventSubEventResponse_logs;
        
			return listEventSubEventResponse;
        }
    }
}
