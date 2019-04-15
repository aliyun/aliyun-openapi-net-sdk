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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeSuspEventsResponseUnmarshaller
    {
        public static DescribeSuspEventsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSuspEventsResponse describeSuspEventsResponse = new DescribeSuspEventsResponse();

			describeSuspEventsResponse.HttpResponse = context.HttpResponse;
			describeSuspEventsResponse.RequestId = context.StringValue("DescribeSuspEvents.RequestId");
			describeSuspEventsResponse.Count = context.IntegerValue("DescribeSuspEvents.Count");
			describeSuspEventsResponse.PageSize = context.IntegerValue("DescribeSuspEvents.PageSize");
			describeSuspEventsResponse.TotalCount = context.IntegerValue("DescribeSuspEvents.TotalCount");
			describeSuspEventsResponse.CurrentPage = context.IntegerValue("DescribeSuspEvents.CurrentPage");

			List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary> describeSuspEventsResponse_suspEvents = new List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary>();
			for (int i = 0; i < context.Length("DescribeSuspEvents.SuspEvents.Length"); i++) {
				DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary warningSummary = new DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary();
				warningSummary.LastTime = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].LastTime");
				warningSummary.OccurrenceTime = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].OccurrenceTime");
				warningSummary.Id = context.LongValue("DescribeSuspEvents.SuspEvents["+ i +"].Id");
				warningSummary.InstanceName = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].InstanceName");
				warningSummary.InternetIp = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].InternetIp");
				warningSummary.IntranetIp = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].IntranetIp");
				warningSummary.Uuid = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Uuid");
				warningSummary.Name = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Name");
				warningSummary.EventSubType = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].EventSubType");
				warningSummary.Level = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Level");
				warningSummary.EventStatus = context.IntegerValue("DescribeSuspEvents.SuspEvents["+ i +"].EventStatus");
				warningSummary.Desc = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Desc");
				warningSummary.OperateMsg = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].OperateMsg");
				warningSummary.DataSource = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].DataSource");
				warningSummary.CanBeDealOnLine = context.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].CanBeDealOnLine");
				warningSummary.SaleVersion = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].SaleVersion");
				warningSummary.AlarmEventType = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmEventType");
				warningSummary.AlarmEventName = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmEventName");
				warningSummary.AlarmUniqueInfo = context.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmUniqueInfo");

				describeSuspEventsResponse_suspEvents.Add(warningSummary);
			}
			describeSuspEventsResponse.SuspEvents = describeSuspEventsResponse_suspEvents;
        
			return describeSuspEventsResponse;
        }
    }
}
