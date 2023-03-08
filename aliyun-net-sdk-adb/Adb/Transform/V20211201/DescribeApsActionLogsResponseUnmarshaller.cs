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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class DescribeApsActionLogsResponseUnmarshaller
    {
        public static DescribeApsActionLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApsActionLogsResponse describeApsActionLogsResponse = new DescribeApsActionLogsResponse();

			describeApsActionLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeApsActionLogsResponse.RequestId = _ctx.StringValue("DescribeApsActionLogs.RequestId");
			describeApsActionLogsResponse.DBClusterId = _ctx.StringValue("DescribeApsActionLogs.DBClusterId");
			describeApsActionLogsResponse.WorkloadId = _ctx.StringValue("DescribeApsActionLogs.WorkloadId");
			describeApsActionLogsResponse.TotalCount = _ctx.StringValue("DescribeApsActionLogs.TotalCount");
			describeApsActionLogsResponse.PageSize = _ctx.StringValue("DescribeApsActionLogs.PageSize");
			describeApsActionLogsResponse.PageNumber = _ctx.StringValue("DescribeApsActionLogs.PageNumber");

			List<DescribeApsActionLogsResponse.DescribeApsActionLogs_SlowLogRecord> describeApsActionLogsResponse_actionLogs = new List<DescribeApsActionLogsResponse.DescribeApsActionLogs_SlowLogRecord>();
			for (int i = 0; i < _ctx.Length("DescribeApsActionLogs.ActionLogs.Length"); i++) {
				DescribeApsActionLogsResponse.DescribeApsActionLogs_SlowLogRecord slowLogRecord = new DescribeApsActionLogsResponse.DescribeApsActionLogs_SlowLogRecord();
				slowLogRecord.Time = _ctx.StringValue("DescribeApsActionLogs.ActionLogs["+ i +"].Time");
				slowLogRecord.Stage = _ctx.StringValue("DescribeApsActionLogs.ActionLogs["+ i +"].Stage");
				slowLogRecord.State = _ctx.StringValue("DescribeApsActionLogs.ActionLogs["+ i +"].State");
				slowLogRecord.Context = _ctx.StringValue("DescribeApsActionLogs.ActionLogs["+ i +"].Context");

				describeApsActionLogsResponse_actionLogs.Add(slowLogRecord);
			}
			describeApsActionLogsResponse.ActionLogs = describeApsActionLogsResponse_actionLogs;
        
			return describeApsActionLogsResponse;
        }
    }
}
