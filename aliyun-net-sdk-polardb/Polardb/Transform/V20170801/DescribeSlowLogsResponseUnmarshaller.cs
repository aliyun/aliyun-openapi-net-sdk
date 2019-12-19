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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeSlowLogsResponseUnmarshaller
    {
        public static DescribeSlowLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSlowLogsResponse describeSlowLogsResponse = new DescribeSlowLogsResponse();

			describeSlowLogsResponse.HttpResponse = context.HttpResponse;
			describeSlowLogsResponse.RequestId = context.StringValue("DescribeSlowLogs.RequestId");
			describeSlowLogsResponse.DBClusterId = context.StringValue("DescribeSlowLogs.DBClusterId");
			describeSlowLogsResponse.StartTime = context.StringValue("DescribeSlowLogs.StartTime");
			describeSlowLogsResponse.EndTime = context.StringValue("DescribeSlowLogs.EndTime");
			describeSlowLogsResponse.Engine = context.StringValue("DescribeSlowLogs.Engine");
			describeSlowLogsResponse.TotalRecordCount = context.IntegerValue("DescribeSlowLogs.TotalRecordCount");
			describeSlowLogsResponse.PageNumber = context.IntegerValue("DescribeSlowLogs.PageNumber");
			describeSlowLogsResponse.PageRecordCount = context.IntegerValue("DescribeSlowLogs.PageRecordCount");

			List<DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog> describeSlowLogsResponse_items = new List<DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog>();
			for (int i = 0; i < context.Length("DescribeSlowLogs.Items.Length"); i++) {
				DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog sQLSlowLog = new DescribeSlowLogsResponse.DescribeSlowLogs_SQLSlowLog();
				sQLSlowLog.DBNodeId = context.StringValue("DescribeSlowLogs.Items["+ i +"].DBNodeId");
				sQLSlowLog.ParseMaxRowCount = context.LongValue("DescribeSlowLogs.Items["+ i +"].ParseMaxRowCount");
				sQLSlowLog.TotalLockTimes = context.LongValue("DescribeSlowLogs.Items["+ i +"].TotalLockTimes");
				sQLSlowLog.DBName = context.StringValue("DescribeSlowLogs.Items["+ i +"].DBName");
				sQLSlowLog.MaxExecutionTime = context.LongValue("DescribeSlowLogs.Items["+ i +"].MaxExecutionTime");
				sQLSlowLog.SQLHASH = context.StringValue("DescribeSlowLogs.Items["+ i +"].SQLHASH");
				sQLSlowLog.SQLText = context.StringValue("DescribeSlowLogs.Items["+ i +"].SQLText");
				sQLSlowLog.CreateTime = context.StringValue("DescribeSlowLogs.Items["+ i +"].CreateTime");
				sQLSlowLog.TotalExecutionTimes = context.LongValue("DescribeSlowLogs.Items["+ i +"].TotalExecutionTimes");
				sQLSlowLog.ReturnTotalRowCounts = context.LongValue("DescribeSlowLogs.Items["+ i +"].ReturnTotalRowCounts");
				sQLSlowLog.TotalExecutionCounts = context.LongValue("DescribeSlowLogs.Items["+ i +"].TotalExecutionCounts");
				sQLSlowLog.MaxLockTime = context.LongValue("DescribeSlowLogs.Items["+ i +"].MaxLockTime");
				sQLSlowLog.ReturnMaxRowCount = context.LongValue("DescribeSlowLogs.Items["+ i +"].ReturnMaxRowCount");
				sQLSlowLog.ParseTotalRowCounts = context.LongValue("DescribeSlowLogs.Items["+ i +"].ParseTotalRowCounts");

				describeSlowLogsResponse_items.Add(sQLSlowLog);
			}
			describeSlowLogsResponse.Items = describeSlowLogsResponse_items;
        
			return describeSlowLogsResponse;
        }
    }
}
