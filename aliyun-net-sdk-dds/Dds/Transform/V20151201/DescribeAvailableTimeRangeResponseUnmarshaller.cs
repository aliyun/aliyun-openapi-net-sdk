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
using Aliyun.Acs.Dds.Model.V20151201;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeAvailableTimeRangeResponseUnmarshaller
    {
        public static DescribeAvailableTimeRangeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAvailableTimeRangeResponse describeAvailableTimeRangeResponse = new DescribeAvailableTimeRangeResponse();

			describeAvailableTimeRangeResponse.HttpResponse = context.HttpResponse;
			describeAvailableTimeRangeResponse.RequestId = context.StringValue("DescribeAvailableTimeRange.RequestId");

			List<DescribeAvailableTimeRangeResponse.DescribeAvailableTimeRange_TimeRangeItem> describeAvailableTimeRangeResponse_timeRange = new List<DescribeAvailableTimeRangeResponse.DescribeAvailableTimeRange_TimeRangeItem>();
			for (int i = 0; i < context.Length("DescribeAvailableTimeRange.TimeRange.Length"); i++) {
				DescribeAvailableTimeRangeResponse.DescribeAvailableTimeRange_TimeRangeItem timeRangeItem = new DescribeAvailableTimeRangeResponse.DescribeAvailableTimeRange_TimeRangeItem();
				timeRangeItem.StartTime = context.StringValue("DescribeAvailableTimeRange.TimeRange["+ i +"].StartTime");
				timeRangeItem.EndTime = context.StringValue("DescribeAvailableTimeRange.TimeRange["+ i +"].EndTime");
				timeRangeItem.Status = context.StringValue("DescribeAvailableTimeRange.TimeRange["+ i +"].Status");
				timeRangeItem.NodeId = context.StringValue("DescribeAvailableTimeRange.TimeRange["+ i +"].NodeId");
				timeRangeItem.TaskId = context.StringValue("DescribeAvailableTimeRange.TimeRange["+ i +"].TaskId");

				describeAvailableTimeRangeResponse_timeRange.Add(timeRangeItem);
			}
			describeAvailableTimeRangeResponse.TimeRange = describeAvailableTimeRangeResponse_timeRange;
        
			return describeAvailableTimeRangeResponse;
        }
    }
}