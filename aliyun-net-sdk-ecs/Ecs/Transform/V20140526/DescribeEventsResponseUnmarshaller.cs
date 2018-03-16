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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeEventsResponseUnmarshaller
    {
        public static DescribeEventsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEventsResponse describeEventsResponse = new DescribeEventsResponse();

			describeEventsResponse.HttpResponse = context.HttpResponse;
			describeEventsResponse.RequestId = context.StringValue("DescribeEvents.RequestId");
			describeEventsResponse.PageNo = context.IntegerValue("DescribeEvents.PageNo");
			describeEventsResponse.PageSize = context.IntegerValue("DescribeEvents.PageSize");
			describeEventsResponse.Total = context.IntegerValue("DescribeEvents.Total");

			List<DescribeEventsResponse.DescribeEvents_Events> describeEventsResponse_data = new List<DescribeEventsResponse.DescribeEvents_Events>();
			for (int i = 0; i < context.Length("DescribeEvents.Data.Length"); i++) {
				DescribeEventsResponse.DescribeEvents_Events events = new DescribeEventsResponse.DescribeEvents_Events();
				events.ResourceId = context.StringValue("DescribeEvents.Data["+ i +"].ResourceId");
				events.EventType = context.StringValue("DescribeEvents.Data["+ i +"].EventType");
				events.EventCategory = context.StringValue("DescribeEvents.Data["+ i +"].EventCategory");
				events.Status = context.StringValue("DescribeEvents.Data["+ i +"].Status");
				events.SupportModify = context.StringValue("DescribeEvents.Data["+ i +"].SupportModify");
				events.PlanTime = context.StringValue("DescribeEvents.Data["+ i +"].PlanTime");
				events.ExpireTime = context.StringValue("DescribeEvents.Data["+ i +"].ExpireTime");
				events.EventId = context.StringValue("DescribeEvents.Data["+ i +"].EventId");

				describeEventsResponse_data.Add(events);
			}
			describeEventsResponse.Data = describeEventsResponse_data;
        
			return describeEventsResponse;
        }
    }
}