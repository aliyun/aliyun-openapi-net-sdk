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
    public class DescribeEventTotalCountResponseUnmarshaller
    {
        public static DescribeEventTotalCountResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEventTotalCountResponse describeEventTotalCountResponse = new DescribeEventTotalCountResponse();

			describeEventTotalCountResponse.HttpResponse = context.HttpResponse;
			describeEventTotalCountResponse.RequestId = context.StringValue("DescribeEventTotalCount.RequestId");

			DescribeEventTotalCountResponse.DescribeEventTotalCount_EventCount eventCount = new DescribeEventTotalCountResponse.DescribeEventTotalCount_EventCount();
			eventCount.TypeCode = context.StringValue("DescribeEventTotalCount.EventCount.TypeCode");
			eventCount.TypeName = context.StringValue("DescribeEventTotalCount.EventCount.TypeName");
			eventCount.Date = context.LongValue("DescribeEventTotalCount.EventCount.Date");

			DescribeEventTotalCountResponse.DescribeEventTotalCount_EventCount.DescribeEventTotalCount_Total total = new DescribeEventTotalCountResponse.DescribeEventTotalCount_EventCount.DescribeEventTotalCount_Total();
			total.TotalCount = context.LongValue("DescribeEventTotalCount.EventCount.Total.TotalCount");
			total.UndealCount = context.LongValue("DescribeEventTotalCount.EventCount.Total.UndealCount");
			total.ConfirmCount = context.LongValue("DescribeEventTotalCount.EventCount.Total.ConfirmCount");
			total.ExcludeCount = context.LongValue("DescribeEventTotalCount.EventCount.Total.ExcludeCount");
			eventCount.Total = total;

			DescribeEventTotalCountResponse.DescribeEventTotalCount_EventCount.DescribeEventTotalCount_LastDay lastDay = new DescribeEventTotalCountResponse.DescribeEventTotalCount_EventCount.DescribeEventTotalCount_LastDay();
			lastDay.TotalCount = context.LongValue("DescribeEventTotalCount.EventCount.LastDay.TotalCount");
			lastDay.UndealCount = context.LongValue("DescribeEventTotalCount.EventCount.LastDay.UndealCount");
			lastDay.ConfirmCount = context.LongValue("DescribeEventTotalCount.EventCount.LastDay.ConfirmCount");
			lastDay.ExcludeCount = context.LongValue("DescribeEventTotalCount.EventCount.LastDay.ExcludeCount");
			eventCount.LastDay = lastDay;

			DescribeEventTotalCountResponse.DescribeEventTotalCount_EventCount.DescribeEventTotalCount_LastWeek lastWeek = new DescribeEventTotalCountResponse.DescribeEventTotalCount_EventCount.DescribeEventTotalCount_LastWeek();
			lastWeek.TotalCount = context.LongValue("DescribeEventTotalCount.EventCount.LastWeek.TotalCount");
			lastWeek.UndealCount = context.LongValue("DescribeEventTotalCount.EventCount.LastWeek.UndealCount");
			lastWeek.ConfirmCount = context.LongValue("DescribeEventTotalCount.EventCount.LastWeek.ConfirmCount");
			lastWeek.ExcludeCount = context.LongValue("DescribeEventTotalCount.EventCount.LastWeek.ExcludeCount");
			eventCount.LastWeek = lastWeek;

			DescribeEventTotalCountResponse.DescribeEventTotalCount_EventCount.DescribeEventTotalCount_LastMonth lastMonth = new DescribeEventTotalCountResponse.DescribeEventTotalCount_EventCount.DescribeEventTotalCount_LastMonth();
			lastMonth.TotalCount = context.LongValue("DescribeEventTotalCount.EventCount.LastMonth.TotalCount");
			lastMonth.UndealCount = context.LongValue("DescribeEventTotalCount.EventCount.LastMonth.UndealCount");
			lastMonth.ConfirmCount = context.LongValue("DescribeEventTotalCount.EventCount.LastMonth.ConfirmCount");
			lastMonth.ExcludeCount = context.LongValue("DescribeEventTotalCount.EventCount.LastMonth.ExcludeCount");
			eventCount.LastMonth = lastMonth;
			describeEventTotalCountResponse.EventCount = eventCount;
        
			return describeEventTotalCountResponse;
        }
    }
}
