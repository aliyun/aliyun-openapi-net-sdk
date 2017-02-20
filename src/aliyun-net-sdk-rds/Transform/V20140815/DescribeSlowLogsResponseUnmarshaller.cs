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
using Aliyun.Acs.Rds.Model.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSlowLogsResponseUnmarshaller
    {
        public static DescribeSlowLogsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeSlowLogsResponse describeSlowLogsResponse = new DescribeSlowLogsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeSlowLogs.RequestId"),
                Engine = context.StringValue("DescribeSlowLogs.Engine"),
                StartTime = context.StringValue("DescribeSlowLogs.StartTime"),
                EndTime = context.StringValue("DescribeSlowLogs.EndTime"),
                TotalRecordCount = context.IntegerValue("DescribeSlowLogs.TotalRecordCount"),
                PageNumber = context.IntegerValue("DescribeSlowLogs.PageNumber"),
                PageRecordCount = context.IntegerValue("DescribeSlowLogs.PageRecordCount")
            };
            List<DescribeSlowLogsResponse.SQLSlowLog> items = new List<DescribeSlowLogsResponse.SQLSlowLog>();
			for (int i = 0; i < context.Length("DescribeSlowLogs.Items.Length"); i++) {
                DescribeSlowLogsResponse.SQLSlowLog sQlSlowLog = new DescribeSlowLogsResponse.SQLSlowLog()
                {
                    SlowLogId = context.LongValue($"DescribeSlowLogs.Items[{i}].SlowLogId"),
                    SQLId = context.LongValue($"DescribeSlowLogs.Items[{i}].SQLId"),
                    DBName = context.StringValue($"DescribeSlowLogs.Items[{i}].DBName"),
                    SQLText = context.StringValue($"DescribeSlowLogs.Items[{i}].SQLText"),
                    MySQLTotalExecutionCounts = context.LongValue($"DescribeSlowLogs.Items[{i}].MySQLTotalExecutionCounts"),
                    MySQLTotalExecutionTimes = context.LongValue($"DescribeSlowLogs.Items[{i}].MySQLTotalExecutionTimes"),
                    TotalLockTimes = context.LongValue($"DescribeSlowLogs.Items[{i}].TotalLockTimes"),
                    MaxLockTime = context.LongValue($"DescribeSlowLogs.Items[{i}].MaxLockTime"),
                    ParseTotalRowCounts = context.LongValue($"DescribeSlowLogs.Items[{i}].ParseTotalRowCounts"),
                    ParseMaxRowCount = context.LongValue($"DescribeSlowLogs.Items[{i}].ParseMaxRowCount"),
                    ReturnTotalRowCounts = context.LongValue($"DescribeSlowLogs.Items[{i}].ReturnTotalRowCounts"),
                    ReturnMaxRowCount = context.LongValue($"DescribeSlowLogs.Items[{i}].ReturnMaxRowCount"),
                    CreateTime = context.StringValue($"DescribeSlowLogs.Items[{i}].CreateTime"),
                    SQLServerTotalExecutionCounts = context.LongValue($"DescribeSlowLogs.Items[{i}].SQLServerTotalExecutionCounts"),
                    SQLServerTotalExecutionTimes = context.LongValue($"DescribeSlowLogs.Items[{i}].SQLServerTotalExecutionTimes"),
                    TotalLogicalReadCounts = context.LongValue($"DescribeSlowLogs.Items[{i}].TotalLogicalReadCounts"),
                    TotalPhysicalReadCounts = context.LongValue($"DescribeSlowLogs.Items[{i}].TotalPhysicalReadCounts"),
                    ReportTime = context.StringValue($"DescribeSlowLogs.Items[{i}].ReportTime"),
                    MaxExecutionTime = context.LongValue($"DescribeSlowLogs.Items[{i}].MaxExecutionTime"),
                    AvgExecutionTime = context.LongValue($"DescribeSlowLogs.Items[{i}].AvgExecutionTime")
                };
                items.Add(sQlSlowLog);
			}
			describeSlowLogsResponse.Items = items;
        
			return describeSlowLogsResponse;
        }
    }
}