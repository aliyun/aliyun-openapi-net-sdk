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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSlowLogsResponseUnmarshaller
    {
        public static DescribeSlowLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSlowLogsResponse describeSlowLogsResponse = new DescribeSlowLogsResponse();

			describeSlowLogsResponse.HttpResponse = context.HttpResponse;
			describeSlowLogsResponse.RequestId = context.StringValue("DescribeSlowLogs.RequestId");
			describeSlowLogsResponse.DBInstanceId = context.StringValue("DescribeSlowLogs.DBInstanceId");
			describeSlowLogsResponse.Engine = context.StringValue("DescribeSlowLogs.Engine");
			describeSlowLogsResponse.StartTime = context.StringValue("DescribeSlowLogs.StartTime");
			describeSlowLogsResponse.EndTime = context.StringValue("DescribeSlowLogs.EndTime");
			describeSlowLogsResponse.TotalRecordCount = context.IntegerValue("DescribeSlowLogs.TotalRecordCount");
			describeSlowLogsResponse.PageNumber = context.IntegerValue("DescribeSlowLogs.PageNumber");
			describeSlowLogsResponse.PageRecordCount = context.IntegerValue("DescribeSlowLogs.PageRecordCount");

			List<DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog> describeSlowLogsResponse_items = new List<DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog>();
			for (int i = 0; i < context.Length("DescribeSlowLogs.Items.Length"); i++) {
				DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog sQLSlowLog = new DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog();
				sQLSlowLog.SlowLogId = context.LongValue("DescribeSlowLogs.Items["+ i +"].SlowLogId");
				sQLSlowLog.SQLHASH = context.StringValue("DescribeSlowLogs.Items["+ i +"].SQLHASH");
				sQLSlowLog.SQLIdStr = context.StringValue("DescribeSlowLogs.Items["+ i +"].SQLIdStr");
				sQLSlowLog.DBName = context.StringValue("DescribeSlowLogs.Items["+ i +"].DBName");
				sQLSlowLog.SQLText = context.StringValue("DescribeSlowLogs.Items["+ i +"].SQLText");
				sQLSlowLog.MySQLTotalExecutionCounts = context.LongValue("DescribeSlowLogs.Items["+ i +"].MySQLTotalExecutionCounts");
				sQLSlowLog.MySQLTotalExecutionTimes = context.LongValue("DescribeSlowLogs.Items["+ i +"].MySQLTotalExecutionTimes");
				sQLSlowLog.TotalLockTimes = context.LongValue("DescribeSlowLogs.Items["+ i +"].TotalLockTimes");
				sQLSlowLog.MaxLockTime = context.LongValue("DescribeSlowLogs.Items["+ i +"].MaxLockTime");
				sQLSlowLog.ParseTotalRowCounts = context.LongValue("DescribeSlowLogs.Items["+ i +"].ParseTotalRowCounts");
				sQLSlowLog.ParseMaxRowCount = context.LongValue("DescribeSlowLogs.Items["+ i +"].ParseMaxRowCount");
				sQLSlowLog.ReturnTotalRowCounts = context.LongValue("DescribeSlowLogs.Items["+ i +"].ReturnTotalRowCounts");
				sQLSlowLog.ReturnMaxRowCount = context.LongValue("DescribeSlowLogs.Items["+ i +"].ReturnMaxRowCount");
				sQLSlowLog.CreateTime = context.StringValue("DescribeSlowLogs.Items["+ i +"].CreateTime");
				sQLSlowLog.SQLServerTotalExecutionCounts = context.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerTotalExecutionCounts");
				sQLSlowLog.SQLServerTotalExecutionTimes = context.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerTotalExecutionTimes");
				sQLSlowLog.TotalLogicalReadCounts = context.LongValue("DescribeSlowLogs.Items["+ i +"].TotalLogicalReadCounts");
				sQLSlowLog.TotalPhysicalReadCounts = context.LongValue("DescribeSlowLogs.Items["+ i +"].TotalPhysicalReadCounts");
				sQLSlowLog.ReportTime = context.StringValue("DescribeSlowLogs.Items["+ i +"].ReportTime");
				sQLSlowLog.MaxExecutionTime = context.LongValue("DescribeSlowLogs.Items["+ i +"].MaxExecutionTime");
				sQLSlowLog.AvgExecutionTime = context.LongValue("DescribeSlowLogs.Items["+ i +"].AvgExecutionTime");

				describeSlowLogsResponse_items.Add(sQLSlowLog);
			}
			describeSlowLogsResponse.Items = describeSlowLogsResponse_items;
        
			return describeSlowLogsResponse;
        }
    }
}
