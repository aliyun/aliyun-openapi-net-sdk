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
    public class DescribeScreenAlarmEventListResponseUnmarshaller
    {
        public static DescribeScreenAlarmEventListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScreenAlarmEventListResponse describeScreenAlarmEventListResponse = new DescribeScreenAlarmEventListResponse();

			describeScreenAlarmEventListResponse.HttpResponse = context.HttpResponse;
			describeScreenAlarmEventListResponse.RequestId = context.StringValue("DescribeScreenAlarmEventList.RequestId");

			DescribeScreenAlarmEventListResponse.DescribeScreenAlarmEventList_PageInfo pageInfo = new DescribeScreenAlarmEventListResponse.DescribeScreenAlarmEventList_PageInfo();
			pageInfo.Count = context.IntegerValue("DescribeScreenAlarmEventList.PageInfo.Count");
			pageInfo.PageSize = context.IntegerValue("DescribeScreenAlarmEventList.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("DescribeScreenAlarmEventList.PageInfo.TotalCount");
			pageInfo.CurrentPage = context.IntegerValue("DescribeScreenAlarmEventList.PageInfo.CurrentPage");
			describeScreenAlarmEventListResponse.PageInfo = pageInfo;

			List<DescribeScreenAlarmEventListResponse.DescribeScreenAlarmEventList_SuspEventsItem> describeScreenAlarmEventListResponse_suspEvents = new List<DescribeScreenAlarmEventListResponse.DescribeScreenAlarmEventList_SuspEventsItem>();
			for (int i = 0; i < context.Length("DescribeScreenAlarmEventList.SuspEvents.Length"); i++) {
				DescribeScreenAlarmEventListResponse.DescribeScreenAlarmEventList_SuspEventsItem suspEventsItem = new DescribeScreenAlarmEventListResponse.DescribeScreenAlarmEventList_SuspEventsItem();
				suspEventsItem.AlarmUniqueInfo = context.StringValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].AlarmUniqueInfo");
				suspEventsItem.Solution = context.StringValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].Solution");
				suspEventsItem.Level = context.StringValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].Level");
				suspEventsItem.CanBeDealOnLine = context.BooleanValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].CanBeDealOnLine");
				suspEventsItem.Description = context.StringValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].Description");
				suspEventsItem.StartTime = context.LongValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].StartTime");
				suspEventsItem.EndTime = context.LongValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].EndTime");
				suspEventsItem.AlarmEventType = context.StringValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].AlarmEventType");
				suspEventsItem.SuspiciousEventCount = context.IntegerValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].SuspiciousEventCount");
				suspEventsItem.Uuid = context.StringValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].Uuid");
				suspEventsItem.InstanceName = context.StringValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].InstanceName");
				suspEventsItem.InternetIp = context.StringValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].InternetIp");
				suspEventsItem.IntranetIp = context.StringValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].IntranetIp");
				suspEventsItem.AlarmEventName = context.StringValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].AlarmEventName");
				suspEventsItem.SaleVersion = context.StringValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].SaleVersion");
				suspEventsItem.DataSource = context.StringValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].DataSource");
				suspEventsItem.CanCancelFault = context.BooleanValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].CanCancelFault");
				suspEventsItem.Dealed = context.BooleanValue("DescribeScreenAlarmEventList.SuspEvents["+ i +"].Dealed");

				describeScreenAlarmEventListResponse_suspEvents.Add(suspEventsItem);
			}
			describeScreenAlarmEventListResponse.SuspEvents = describeScreenAlarmEventListResponse_suspEvents;
        
			return describeScreenAlarmEventListResponse;
        }
    }
}
