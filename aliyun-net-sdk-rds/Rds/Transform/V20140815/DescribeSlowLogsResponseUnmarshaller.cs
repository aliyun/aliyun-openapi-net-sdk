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
			describeSlowLogsResponse.RequestId = _ctx.StringValue("DescribeSlowLogs.RequestId");
			describeSlowLogsResponse.DBInstanceId = _ctx.StringValue("DescribeSlowLogs.DBInstanceId");
			describeSlowLogsResponse.Engine = _ctx.StringValue("DescribeSlowLogs.Engine");
			describeSlowLogsResponse.StartTime = _ctx.StringValue("DescribeSlowLogs.StartTime");
			describeSlowLogsResponse.EndTime = _ctx.StringValue("DescribeSlowLogs.EndTime");
			describeSlowLogsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeSlowLogs.TotalRecordCount");
			describeSlowLogsResponse.PageNumber = _ctx.IntegerValue("DescribeSlowLogs.PageNumber");
			describeSlowLogsResponse.PageRecordCount = _ctx.IntegerValue("DescribeSlowLogs.PageRecordCount");

			List<DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog> describeSlowLogsResponse_items = new List<DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog>();
			for (int i = 0; i < _ctx.Length("DescribeSlowLogs.Items.Length"); i++) {
				DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog sQLSlowLog = new DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog();
				sQLSlowLog.SlowLogId = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SlowLogId");
				sQLSlowLog.SQLHASH = _ctx.StringValue("DescribeSlowLogs.Items["+ i +"].SQLHASH");
				sQLSlowLog.SQLIdStr = _ctx.StringValue("DescribeSlowLogs.Items["+ i +"].SQLIdStr");
				sQLSlowLog.DBName = _ctx.StringValue("DescribeSlowLogs.Items["+ i +"].DBName");
				sQLSlowLog.SQLText = _ctx.StringValue("DescribeSlowLogs.Items["+ i +"].SQLText");
				sQLSlowLog.MySQLTotalExecutionCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MySQLTotalExecutionCounts");
				sQLSlowLog.MySQLTotalExecutionTimes = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MySQLTotalExecutionTimes");
				sQLSlowLog.TotalLockTimes = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalLockTimes");
				sQLSlowLog.MaxLockTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxLockTime");
				sQLSlowLog.ParseTotalRowCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].ParseTotalRowCounts");
				sQLSlowLog.ParseMaxRowCount = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].ParseMaxRowCount");
				sQLSlowLog.ReturnTotalRowCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].ReturnTotalRowCounts");
				sQLSlowLog.ReturnMaxRowCount = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].ReturnMaxRowCount");
				sQLSlowLog.CreateTime = _ctx.StringValue("DescribeSlowLogs.Items["+ i +"].CreateTime");
				sQLSlowLog.SQLServerTotalExecutionCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerTotalExecutionCounts");
				sQLSlowLog.SQLServerTotalExecutionTimes = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerTotalExecutionTimes");
				sQLSlowLog.TotalLogicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalLogicalReadCounts");
				sQLSlowLog.TotalPhysicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalPhysicalReadCounts");
				sQLSlowLog.ReportTime = _ctx.StringValue("DescribeSlowLogs.Items["+ i +"].ReportTime");
				sQLSlowLog.MaxExecutionTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxExecutionTime");
				sQLSlowLog.AvgExecutionTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].AvgExecutionTime");
				sQLSlowLog.TotalPhysicalReadCounts1 = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalPhysicalReadCounts");
				sQLSlowLog.AvgPhysicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].AvgPhysicalReadCounts");
				sQLSlowLog.MaxPhysicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxPhysicalReadCounts");
				sQLSlowLog.MinPhysicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MinPhysicalReadCounts");
				sQLSlowLog.AvgLogicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].AvgLogicalReadCounts");
				sQLSlowLog.MaxLogicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxLogicalReadCounts");
				sQLSlowLog.MinLogicalReadCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MinLogicalReadCounts");
				sQLSlowLog.TotalIOWriteCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalIOWriteCounts");
				sQLSlowLog.AvgIOWriteCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].AvgIOWriteCounts");
				sQLSlowLog.MaxIOWriteCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxIOWriteCounts");
				sQLSlowLog.MinIOWriteCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MinIOWriteCounts");
				sQLSlowLog.TotalRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalRowsAffectedCounts");
				sQLSlowLog.AvgRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].AvgRowsAffectedCounts");
				sQLSlowLog.MaxRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxRowsAffectedCounts");
				sQLSlowLog.MinRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MinRowsAffectedCounts");
				sQLSlowLog.TotalLastRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].TotalLastRowsAffectedCounts");
				sQLSlowLog.AvgLastRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].AvgLastRowsAffectedCounts");
				sQLSlowLog.MaxLastRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MaxLastRowsAffectedCounts");
				sQLSlowLog.MinLastRowsAffectedCounts = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].MinLastRowsAffectedCounts");
				sQLSlowLog.SQLServerMinExecutionTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerMinExecutionTime");
				sQLSlowLog.SQLServerAvgExecutionTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerAvgExecutionTime");
				sQLSlowLog.SQLServerTotalCpuTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerTotalCpuTime");
				sQLSlowLog.SQLServerAvgCpuTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerAvgCpuTime");
				sQLSlowLog.SQLServerMaxCpuTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerMaxCpuTime");
				sQLSlowLog.SQLServerMinCpuTime = _ctx.LongValue("DescribeSlowLogs.Items["+ i +"].SQLServerMinCpuTime");

				describeSlowLogsResponse_items.Add(sQLSlowLog);
			}
			describeSlowLogsResponse.Items = describeSlowLogsResponse_items;
        
			return describeSlowLogsResponse;
        }
    }
}
