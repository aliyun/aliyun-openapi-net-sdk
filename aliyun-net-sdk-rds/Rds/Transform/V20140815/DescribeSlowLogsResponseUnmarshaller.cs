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
        public static DescribeSlowLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlowLogsResponse describeSlowLogsResponse = new DescribeSlowLogsResponse();

			describeSlowLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeSlowLogsResponse.EndTime = _ctx.StringValue("DescribeSlowLogs.EndTime");
			describeSlowLogsResponse.StartTime = _ctx.StringValue("DescribeSlowLogs.StartTime");
			describeSlowLogsResponse.RequestId = _ctx.StringValue("DescribeSlowLogs.RequestId");
			describeSlowLogsResponse.PageRecordCount = _ctx.IntegerValue("DescribeSlowLogs.PageRecordCount");
			describeSlowLogsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeSlowLogs.TotalRecordCount");
			describeSlowLogsResponse.DBInstanceId = _ctx.StringValue("DescribeSlowLogs.DBInstanceId");
			describeSlowLogsResponse.PageNumber = _ctx.IntegerValue("DescribeSlowLogs.PageNumber");
			describeSlowLogsResponse.Engine = _ctx.StringValue("DescribeSlowLogs.Engine");

			List<DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog> describeSlowLogsResponse_items = new List<DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog>();
			for (int i = 0; i < _ctx.Length("DescribeSlowLogs.Items.Length"); i++) {
				DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog sQLSlowLog = new DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog();
				sQLSlowLog.MaxLastRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxLastRowsAffectedCounts");
				sQLSlowLog.ReturnMaxRowCount = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].ReturnMaxRowCount");
				sQLSlowLog.SQLText = _ctx.StringValue("DescribeSlowLogs.Items["+ i +"].SQLText");
				sQLSlowLog.SQLServerMaxCpuTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerMaxCpuTime");
				sQLSlowLog.CreateTime = _ctx.StringValue("DescribeSlowLogs.Items["+ i +"].CreateTime");
				sQLSlowLog.AvgLastRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].AvgLastRowsAffectedCounts");
				sQLSlowLog.MinLastRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MinLastRowsAffectedCounts");
				sQLSlowLog.ParseTotalRowCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].ParseTotalRowCounts");
				sQLSlowLog.TotalLockTimes = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalLockTimes");
				sQLSlowLog.MySQLTotalExecutionCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MySQLTotalExecutionCounts");
				sQLSlowLog.SQLServerMinCpuTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerMinCpuTime");
				sQLSlowLog.SQLHASH = _ctx.StringValue("DescribeSlowLogs.Items["+ i +"].SQLHASH");
				sQLSlowLog.MinIOWriteCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MinIOWriteCounts");
				sQLSlowLog.ParseMaxRowCount = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].ParseMaxRowCount");
				sQLSlowLog.MaxLogicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxLogicalReadCounts");
				sQLSlowLog.MySQLTotalExecutionTimes = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MySQLTotalExecutionTimes");
				sQLSlowLog.SQLServerTotalExecutionCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerTotalExecutionCounts");
				sQLSlowLog.ReturnTotalRowCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].ReturnTotalRowCounts");
				sQLSlowLog.MaxLockTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxLockTime");
				sQLSlowLog.DBName = _ctx.StringValue("DescribeSlowLogs.Items["+ i +"].DBName");
				sQLSlowLog.MinRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MinRowsAffectedCounts");
				sQLSlowLog.TotalLogicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalLogicalReadCounts");
				sQLSlowLog.TotalPhysicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalPhysicalReadCounts");
				sQLSlowLog.ReportTime = _ctx.StringValue("DescribeSlowLogs.Items["+ i +"].ReportTime");
				sQLSlowLog.MaxPhysicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxPhysicalReadCounts");
				sQLSlowLog.SQLServerTotalCpuTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerTotalCpuTime");
				sQLSlowLog.TotalIOWriteCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalIOWriteCounts");
				sQLSlowLog.MaxRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxRowsAffectedCounts");
				sQLSlowLog.AvgIOWriteCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].AvgIOWriteCounts");
				sQLSlowLog.MinPhysicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MinPhysicalReadCounts");
				sQLSlowLog.SlowLogId = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SlowLogId");
				sQLSlowLog.MaxExecutionTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxExecutionTime");
				sQLSlowLog.AvgExecutionTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].AvgExecutionTime");
				sQLSlowLog.SQLServerAvgExecutionTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerAvgExecutionTime");
				sQLSlowLog.MaxIOWriteCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxIOWriteCounts");
				sQLSlowLog.SQLServerAvgCpuTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerAvgCpuTime");
				sQLSlowLog.TotalLastRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalLastRowsAffectedCounts");
				sQLSlowLog.AvgLogicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].AvgLogicalReadCounts");
				sQLSlowLog.SQLServerMinExecutionTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerMinExecutionTime");
				sQLSlowLog.SQLIdStr = _ctx.StringValue("DescribeSlowLogs.Items["+ i +"].SQLIdStr");
				sQLSlowLog.SQLServerTotalExecutionTimes = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerTotalExecutionTimes");
				sQLSlowLog.AvgRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].AvgRowsAffectedCounts");
				sQLSlowLog.TotalRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalRowsAffectedCounts");
				sQLSlowLog.AvgPhysicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].AvgPhysicalReadCounts");
				sQLSlowLog.MinLogicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MinLogicalReadCounts");

				describeSlowLogsResponse_items.Add(sQLSlowLog);
			}
			describeSlowLogsResponse.Items = describeSlowLogsResponse_items;
        
			return describeSlowLogsResponse;
        }
    }
}
