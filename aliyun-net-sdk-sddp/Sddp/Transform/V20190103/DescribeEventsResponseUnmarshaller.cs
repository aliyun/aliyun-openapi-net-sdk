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
        public static DescribeEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEventsResponse describeEventsResponse = new DescribeEventsResponse();

			describeEventsResponse.HttpResponse = _ctx.HttpResponse;
			describeEventsResponse.CurrentPage = _ctx.IntegerValue("DescribeEvents.CurrentPage");
			describeEventsResponse.RequestId = _ctx.StringValue("DescribeEvents.RequestId");
			describeEventsResponse.PageSize = _ctx.IntegerValue("DescribeEvents.PageSize");
			describeEventsResponse.TotalCount = _ctx.IntegerValue("DescribeEvents.TotalCount");

			List<DescribeEventsResponse.DescribeEvents__Event> describeEventsResponse_items = new List<DescribeEventsResponse.DescribeEvents__Event>();
			for (int i = 0; i < _ctx.Length("DescribeEvents.Items.Length"); i++) {
				DescribeEventsResponse.DescribeEvents__Event _event = new DescribeEventsResponse.DescribeEvents__Event();
				_event.DisplayName = _ctx.StringValue("DescribeEvents.Items["+ i +"].DisplayName");
				_event.Status = _ctx.IntegerValue("DescribeEvents.Items["+ i +"].Status");
				_event.WarnLevel = _ctx.IntegerValue("DescribeEvents.Items["+ i +"].WarnLevel");
				_event.UserId = _ctx.LongValue("DescribeEvents.Items["+ i +"].UserId");
				_event.StatusName = _ctx.StringValue("DescribeEvents.Items["+ i +"].StatusName");
				_event.DepartName = _ctx.StringValue("DescribeEvents.Items["+ i +"].DepartName");
				_event.DealUserIdValue = _ctx.StringValue("DescribeEvents.Items["+ i +"].DealUserIdValue");
				_event.DealTime = _ctx.LongValue("DescribeEvents.Items["+ i +"].DealTime");
				_event.DealLoginName = _ctx.StringValue("DescribeEvents.Items["+ i +"].DealLoginName");
				_event.SubTypeName = _ctx.StringValue("DescribeEvents.Items["+ i +"].SubTypeName");
				_event.Backed = _ctx.BooleanValue("DescribeEvents.Items["+ i +"].Backed");
				_event.InstanceName = _ctx.StringValue("DescribeEvents.Items["+ i +"].InstanceName");
				_event.EventTime = _ctx.LongValue("DescribeEvents.Items["+ i +"].EventTime");
				_event.LoginName = _ctx.StringValue("DescribeEvents.Items["+ i +"].LoginName");
				_event.UserIdValue = _ctx.StringValue("DescribeEvents.Items["+ i +"].UserIdValue");
				_event.SubTypeCode = _ctx.StringValue("DescribeEvents.Items["+ i +"].SubTypeCode");
				_event.TargetProductCode = _ctx.StringValue("DescribeEvents.Items["+ i +"].TargetProductCode");
				_event.TypeCode = _ctx.StringValue("DescribeEvents.Items["+ i +"].TypeCode");
				_event.AlertTime = _ctx.LongValue("DescribeEvents.Items["+ i +"].AlertTime");
				_event.DealUserId = _ctx.LongValue("DescribeEvents.Items["+ i +"].DealUserId");
				_event.TypeName = _ctx.StringValue("DescribeEvents.Items["+ i +"].TypeName");
				_event.DealDisplayName = _ctx.StringValue("DescribeEvents.Items["+ i +"].DealDisplayName");
				_event.Id = _ctx.LongValue("DescribeEvents.Items["+ i +"].Id");
				_event.ProductCode = _ctx.StringValue("DescribeEvents.Items["+ i +"].ProductCode");

				describeEventsResponse_items.Add(_event);
			}
			describeEventsResponse.Items = describeEventsResponse_items;
        
			return describeEventsResponse;
        }
    }
}
