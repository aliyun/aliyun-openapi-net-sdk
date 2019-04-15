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
    public class DescribeWebLockEventsResponseUnmarshaller
    {
        public static DescribeWebLockEventsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWebLockEventsResponse describeWebLockEventsResponse = new DescribeWebLockEventsResponse();

			describeWebLockEventsResponse.HttpResponse = context.HttpResponse;
			describeWebLockEventsResponse.RequestId = context.StringValue("DescribeWebLockEvents.RequestId");
			describeWebLockEventsResponse.CurrentPage = context.IntegerValue("DescribeWebLockEvents.CurrentPage");
			describeWebLockEventsResponse.PageSize = context.IntegerValue("DescribeWebLockEvents.PageSize");
			describeWebLockEventsResponse.TotalCount = context.IntegerValue("DescribeWebLockEvents.TotalCount");

			List<DescribeWebLockEventsResponse.DescribeWebLockEvents_EventInfo> describeWebLockEventsResponse_eventList = new List<DescribeWebLockEventsResponse.DescribeWebLockEvents_EventInfo>();
			for (int i = 0; i < context.Length("DescribeWebLockEvents.EventList.Length"); i++) {
				DescribeWebLockEventsResponse.DescribeWebLockEvents_EventInfo eventInfo = new DescribeWebLockEventsResponse.DescribeWebLockEvents_EventInfo();
				eventInfo.Uuid = context.StringValue("DescribeWebLockEvents.EventList["+ i +"].Uuid");
				eventInfo.Ip = context.StringValue("DescribeWebLockEvents.EventList["+ i +"].Ip");
				eventInfo.InternetIp = context.StringValue("DescribeWebLockEvents.EventList["+ i +"].InternetIp");
				eventInfo.IntranetIp = context.StringValue("DescribeWebLockEvents.EventList["+ i +"].IntranetIp");
				eventInfo.InstanceName = context.StringValue("DescribeWebLockEvents.EventList["+ i +"].InstanceName");
				eventInfo.EventType = context.StringValue("DescribeWebLockEvents.EventList["+ i +"].EventType");
				eventInfo.EventName = context.StringValue("DescribeWebLockEvents.EventList["+ i +"].EventName");
				eventInfo.Level = context.StringValue("DescribeWebLockEvents.EventList["+ i +"].Level");
				eventInfo.Status = context.StringValue("DescribeWebLockEvents.EventList["+ i +"].Status");
				eventInfo.GmtEvent = context.LongValue("DescribeWebLockEvents.EventList["+ i +"].GmtEvent");
				eventInfo.Path = context.StringValue("DescribeWebLockEvents.EventList["+ i +"].Path");
				eventInfo.Solution = context.StringValue("DescribeWebLockEvents.EventList["+ i +"].Solution");

				describeWebLockEventsResponse_eventList.Add(eventInfo);
			}
			describeWebLockEventsResponse.EventList = describeWebLockEventsResponse_eventList;
        
			return describeWebLockEventsResponse;
        }
    }
}
