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
    public class DescribeAlarmEventListResponseUnmarshaller
    {
        public static DescribeAlarmEventListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAlarmEventListResponse describeAlarmEventListResponse = new DescribeAlarmEventListResponse();

			describeAlarmEventListResponse.HttpResponse = context.HttpResponse;
			describeAlarmEventListResponse.RequestId = context.StringValue("DescribeAlarmEventList.RequestId");

			DescribeAlarmEventListResponse.DescribeAlarmEventList_PageInfo pageInfo = new DescribeAlarmEventListResponse.DescribeAlarmEventList_PageInfo();
			pageInfo.Count = context.IntegerValue("DescribeAlarmEventList.PageInfo.Count");
			pageInfo.PageSize = context.IntegerValue("DescribeAlarmEventList.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("DescribeAlarmEventList.PageInfo.TotalCount");
			pageInfo.CurrentPage = context.IntegerValue("DescribeAlarmEventList.PageInfo.CurrentPage");
			describeAlarmEventListResponse.PageInfo = pageInfo;

			List<DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem> describeAlarmEventListResponse_suspEvents = new List<DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem>();
			for (int i = 0; i < context.Length("DescribeAlarmEventList.SuspEvents.Length"); i++) {
				DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem suspEventsItem = new DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem();
				suspEventsItem.AlarmUniqueInfo = context.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AlarmUniqueInfo");
				suspEventsItem.Solution = context.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Solution");
				suspEventsItem.Level = context.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Level");
				suspEventsItem.CanBeDealOnLine = context.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].CanBeDealOnLine");
				suspEventsItem.Description = context.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Description");
				suspEventsItem.StartTime = context.LongValue("DescribeAlarmEventList.SuspEvents["+ i +"].StartTime");
				suspEventsItem.EndTime = context.LongValue("DescribeAlarmEventList.SuspEvents["+ i +"].EndTime");
				suspEventsItem.AlarmEventType = context.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AlarmEventType");
				suspEventsItem.SuspiciousEventCount = context.IntegerValue("DescribeAlarmEventList.SuspEvents["+ i +"].SuspiciousEventCount");
				suspEventsItem.Uuid = context.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Uuid");
				suspEventsItem.InstanceName = context.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].InstanceName");
				suspEventsItem.InternetIp = context.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].InternetIp");
				suspEventsItem.IntranetIp = context.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].IntranetIp");
				suspEventsItem.AlarmEventName = context.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AlarmEventName");
				suspEventsItem.SaleVersion = context.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].SaleVersion");
				suspEventsItem.DataSource = context.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].DataSource");
				suspEventsItem.CanCancelFault = context.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].CanCancelFault");
				suspEventsItem.Dealed = context.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].Dealed");
				suspEventsItem.GmtModified = context.LongValue("DescribeAlarmEventList.SuspEvents["+ i +"].GmtModified");
				suspEventsItem.HasTraceInfo = context.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].HasTraceInfo");

				describeAlarmEventListResponse_suspEvents.Add(suspEventsItem);
			}
			describeAlarmEventListResponse.SuspEvents = describeAlarmEventListResponse_suspEvents;
        
			return describeAlarmEventListResponse;
        }
    }
}
