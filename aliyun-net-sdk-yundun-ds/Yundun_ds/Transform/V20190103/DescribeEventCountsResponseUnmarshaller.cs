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
using Aliyun.Acs.Yundun_ds.Model.V20190103;

namespace Aliyun.Acs.Yundun_ds.Transform.V20190103
{
    public class DescribeEventCountsResponseUnmarshaller
    {
        public static DescribeEventCountsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEventCountsResponse describeEventCountsResponse = new DescribeEventCountsResponse();

			describeEventCountsResponse.HttpResponse = context.HttpResponse;
			describeEventCountsResponse.RequestId = context.StringValue("DescribeEventCounts.RequestId");

			List<DescribeEventCountsResponse.DescribeEventCounts_EventCount> describeEventCountsResponse_eventCountList = new List<DescribeEventCountsResponse.DescribeEventCounts_EventCount>();
			for (int i = 0; i < context.Length("DescribeEventCounts.EventCountList.Length"); i++) {
				DescribeEventCountsResponse.DescribeEventCounts_EventCount eventCount = new DescribeEventCountsResponse.DescribeEventCounts_EventCount();
				eventCount.TypeCode = context.StringValue("DescribeEventCounts.EventCountList["+ i +"].TypeCode");
				eventCount.TypeName = context.StringValue("DescribeEventCounts.EventCountList["+ i +"].TypeName");
				eventCount.Date = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].Date");

				DescribeEventCountsResponse.DescribeEventCounts_EventCount.DescribeEventCounts_Total total = new DescribeEventCountsResponse.DescribeEventCounts_EventCount.DescribeEventCounts_Total();
				total.TotalCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].Total.TotalCount");
				total.UndealCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].Total.UndealCount");
				total.ConfirmCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].Total.ConfirmCount");
				total.ExcludeCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].Total.ExcludeCount");
				eventCount.Total = total;

				DescribeEventCountsResponse.DescribeEventCounts_EventCount.DescribeEventCounts_LastDay lastDay = new DescribeEventCountsResponse.DescribeEventCounts_EventCount.DescribeEventCounts_LastDay();
				lastDay.TotalCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].LastDay.TotalCount");
				lastDay.UndealCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].LastDay.UndealCount");
				lastDay.ConfirmCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].LastDay.ConfirmCount");
				lastDay.ExcludeCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].LastDay.ExcludeCount");
				eventCount.LastDay = lastDay;

				DescribeEventCountsResponse.DescribeEventCounts_EventCount.DescribeEventCounts_LastWeek lastWeek = new DescribeEventCountsResponse.DescribeEventCounts_EventCount.DescribeEventCounts_LastWeek();
				lastWeek.TotalCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].LastWeek.TotalCount");
				lastWeek.UndealCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].LastWeek.UndealCount");
				lastWeek.ConfirmCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].LastWeek.ConfirmCount");
				lastWeek.ExcludeCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].LastWeek.ExcludeCount");
				eventCount.LastWeek = lastWeek;

				DescribeEventCountsResponse.DescribeEventCounts_EventCount.DescribeEventCounts_LastMonth lastMonth = new DescribeEventCountsResponse.DescribeEventCounts_EventCount.DescribeEventCounts_LastMonth();
				lastMonth.TotalCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].LastMonth.TotalCount");
				lastMonth.UndealCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].LastMonth.UndealCount");
				lastMonth.ConfirmCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].LastMonth.ConfirmCount");
				lastMonth.ExcludeCount = context.LongValue("DescribeEventCounts.EventCountList["+ i +"].LastMonth.ExcludeCount");
				eventCount.LastMonth = lastMonth;

				describeEventCountsResponse_eventCountList.Add(eventCount);
			}
			describeEventCountsResponse.EventCountList = describeEventCountsResponse_eventCountList;
        
			return describeEventCountsResponse;
        }
    }
}
