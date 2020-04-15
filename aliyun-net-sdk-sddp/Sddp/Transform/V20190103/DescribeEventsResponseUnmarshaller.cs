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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeEventsResponseUnmarshaller
    {
        public static DescribeEventsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEventsResponse describeEventsResponse = new DescribeEventsResponse();

			describeEventsResponse.HttpResponse = context.HttpResponse;
			describeEventsResponse.RequestId = context.StringValue("DescribeEvents.RequestId");
			describeEventsResponse.PageSize = context.IntegerValue("DescribeEvents.PageSize");
			describeEventsResponse.CurrentPage = context.IntegerValue("DescribeEvents.CurrentPage");
			describeEventsResponse.TotalCount = context.IntegerValue("DescribeEvents.TotalCount");

			List<DescribeEventsResponse.DescribeEvents__Event> describeEventsResponse_items = new List<DescribeEventsResponse.DescribeEvents__Event>();
			for (int i = 0; i < context.Length("DescribeEvents.Items.Length"); i++) {
				DescribeEventsResponse.DescribeEvents__Event _event = new DescribeEventsResponse.DescribeEvents__Event();
				_event.Id = context.LongValue("DescribeEvents.Items["+ i +"].Id");
				_event.UserId = context.LongValue("DescribeEvents.Items["+ i +"].UserId");
				_event.LoginName = context.StringValue("DescribeEvents.Items["+ i +"].LoginName");
				_event.DisplayName = context.StringValue("DescribeEvents.Items["+ i +"].DisplayName");
				_event.ProductCode = context.StringValue("DescribeEvents.Items["+ i +"].ProductCode");
				_event.TargetProductCode = context.StringValue("DescribeEvents.Items["+ i +"].TargetProductCode");
				_event.TypeCode = context.StringValue("DescribeEvents.Items["+ i +"].TypeCode");
				_event.TypeName = context.StringValue("DescribeEvents.Items["+ i +"].TypeName");
				_event.SubTypeCode = context.StringValue("DescribeEvents.Items["+ i +"].SubTypeCode");
				_event.SubTypeName = context.StringValue("DescribeEvents.Items["+ i +"].SubTypeName");
				_event.AlertTime = context.LongValue("DescribeEvents.Items["+ i +"].AlertTime");
				_event.EventTime = context.LongValue("DescribeEvents.Items["+ i +"].EventTime");
				_event.Status = context.IntegerValue("DescribeEvents.Items["+ i +"].Status");
				_event.StatusName = context.StringValue("DescribeEvents.Items["+ i +"].StatusName");
				_event.DealUserId = context.LongValue("DescribeEvents.Items["+ i +"].DealUserId");
				_event.DealLoginName = context.StringValue("DescribeEvents.Items["+ i +"].DealLoginName");
				_event.DealDisplayName = context.StringValue("DescribeEvents.Items["+ i +"].DealDisplayName");
				_event.DealTime = context.LongValue("DescribeEvents.Items["+ i +"].DealTime");
				_event.DepartName = context.StringValue("DescribeEvents.Items["+ i +"].DepartName");
				_event.Backed = context.BooleanValue("DescribeEvents.Items["+ i +"].Backed");

				describeEventsResponse_items.Add(_event);
			}
			describeEventsResponse.Items = describeEventsResponse_items;
        
			return describeEventsResponse;
        }
    }
}
