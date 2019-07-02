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
using Aliyun.Acs.fnf.Model.V20190315;

namespace Aliyun.Acs.fnf.Transform.V20190315
{
    public class GetExecutionHistoryResponseUnmarshaller
    {
        public static GetExecutionHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			GetExecutionHistoryResponse getExecutionHistoryResponse = new GetExecutionHistoryResponse();

			getExecutionHistoryResponse.HttpResponse = context.HttpResponse;
			getExecutionHistoryResponse.RequestId = context.StringValue("GetExecutionHistory.RequestId");
			getExecutionHistoryResponse.NextToken = context.StringValue("GetExecutionHistory.NextToken");

			List<GetExecutionHistoryResponse.GetExecutionHistory_EventsItem> getExecutionHistoryResponse_events = new List<GetExecutionHistoryResponse.GetExecutionHistory_EventsItem>();
			for (int i = 0; i < context.Length("GetExecutionHistory.Events.Length"); i++) {
				GetExecutionHistoryResponse.GetExecutionHistory_EventsItem eventsItem = new GetExecutionHistoryResponse.GetExecutionHistory_EventsItem();
				eventsItem.StepName = context.StringValue("GetExecutionHistory.Events["+ i +"].StepName");
				eventsItem.Type = context.StringValue("GetExecutionHistory.Events["+ i +"].Type");
				eventsItem.EventId = context.LongValue("GetExecutionHistory.Events["+ i +"].EventId");
				eventsItem.ScheduleEventId = context.LongValue("GetExecutionHistory.Events["+ i +"].ScheduleEventId");
				eventsItem.EventDetail = context.StringValue("GetExecutionHistory.Events["+ i +"].EventDetail");
				eventsItem.Time = context.StringValue("GetExecutionHistory.Events["+ i +"].Time");

				getExecutionHistoryResponse_events.Add(eventsItem);
			}
			getExecutionHistoryResponse.Events = getExecutionHistoryResponse_events;
        
			return getExecutionHistoryResponse;
        }
    }
}
