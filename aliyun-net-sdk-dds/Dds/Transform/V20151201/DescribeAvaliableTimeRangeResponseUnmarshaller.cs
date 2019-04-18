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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeAvaliableTimeRangeResponseUnmarshaller
    {
        public static DescribeAvaliableTimeRangeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAvaliableTimeRangeResponse describeAvaliableTimeRangeResponse = new DescribeAvaliableTimeRangeResponse();

			describeAvaliableTimeRangeResponse.HttpResponse = context.HttpResponse;
			describeAvaliableTimeRangeResponse.RequestId = context.StringValue("DescribeAvaliableTimeRange.RequestId");

			List<DescribeAvaliableTimeRangeResponse.DescribeAvaliableTimeRange_TimeRangeItem> describeAvaliableTimeRangeResponse_timeRange = new List<DescribeAvaliableTimeRangeResponse.DescribeAvaliableTimeRange_TimeRangeItem>();
			for (int i = 0; i < context.Length("DescribeAvaliableTimeRange.TimeRange.Length"); i++) {
				DescribeAvaliableTimeRangeResponse.DescribeAvaliableTimeRange_TimeRangeItem timeRangeItem = new DescribeAvaliableTimeRangeResponse.DescribeAvaliableTimeRange_TimeRangeItem();
				timeRangeItem.StartTime = context.StringValue("DescribeAvaliableTimeRange.TimeRange["+ i +"].StartTime");
				timeRangeItem.EndTime = context.StringValue("DescribeAvaliableTimeRange.TimeRange["+ i +"].EndTime");
				timeRangeItem.Status = context.StringValue("DescribeAvaliableTimeRange.TimeRange["+ i +"].Status");

				describeAvaliableTimeRangeResponse_timeRange.Add(timeRangeItem);
			}
			describeAvaliableTimeRangeResponse.TimeRange = describeAvaliableTimeRangeResponse_timeRange;
        
			return describeAvaliableTimeRangeResponse;
        }
    }
}
