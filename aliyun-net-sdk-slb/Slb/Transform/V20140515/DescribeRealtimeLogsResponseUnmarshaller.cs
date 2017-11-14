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
using Aliyun.Acs.Slb.Model.V20140515;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeRealtimeLogsResponseUnmarshaller
    {
        public static DescribeRealtimeLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRealtimeLogsResponse describeRealtimeLogsResponse = new DescribeRealtimeLogsResponse();

			describeRealtimeLogsResponse.HttpResponse = context.HttpResponse;
			describeRealtimeLogsResponse.RequestId = context.StringValue("DescribeRealtimeLogs.RequestId");
			describeRealtimeLogsResponse.PageNumber = context.IntegerValue("DescribeRealtimeLogs.PageNumber");
			describeRealtimeLogsResponse.PageSize = context.IntegerValue("DescribeRealtimeLogs.PageSize");
			describeRealtimeLogsResponse.TotalCount = context.LongValue("DescribeRealtimeLogs.TotalCount");
			describeRealtimeLogsResponse.Progress = context.StringValue("DescribeRealtimeLogs.Progress");

			List<DescribeRealtimeLogsResponse.DescribeRealtimeLogs_LBRealTimeLog> describeRealtimeLogsResponse_lBRealTimeLogsSet = new List<DescribeRealtimeLogsResponse.DescribeRealtimeLogs_LBRealTimeLog>();
			for (int i = 0; i < context.Length("DescribeRealtimeLogs.LBRealTimeLogsSet.Length"); i++) {
				DescribeRealtimeLogsResponse.DescribeRealtimeLogs_LBRealTimeLog lBRealTimeLog = new DescribeRealtimeLogsResponse.DescribeRealtimeLogs_LBRealTimeLog();
				lBRealTimeLog.LogDetail = context.StringValue("DescribeRealtimeLogs.LBRealTimeLogsSet["+ i +"].LogDetail");

				describeRealtimeLogsResponse_lBRealTimeLogsSet.Add(lBRealTimeLog);
			}
			describeRealtimeLogsResponse.LBRealTimeLogsSet = describeRealtimeLogsResponse_lBRealTimeLogsSet;
        
			return describeRealtimeLogsResponse;
        }
    }
}