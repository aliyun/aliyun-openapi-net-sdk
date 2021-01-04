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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeRecordLogsResponseUnmarshaller
    {
        public static DescribeRecordLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRecordLogsResponse describeRecordLogsResponse = new DescribeRecordLogsResponse();

			describeRecordLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeRecordLogsResponse.RequestId = _ctx.StringValue("DescribeRecordLogs.RequestId");
			describeRecordLogsResponse.TotalCount = _ctx.LongValue("DescribeRecordLogs.TotalCount");
			describeRecordLogsResponse.PageNumber = _ctx.LongValue("DescribeRecordLogs.PageNumber");
			describeRecordLogsResponse.PageSize = _ctx.LongValue("DescribeRecordLogs.PageSize");

			List<DescribeRecordLogsResponse.DescribeRecordLogs_RecordLog> describeRecordLogsResponse_recordLogs = new List<DescribeRecordLogsResponse.DescribeRecordLogs_RecordLog>();
			for (int i = 0; i < _ctx.Length("DescribeRecordLogs.RecordLogs.Length"); i++) {
				DescribeRecordLogsResponse.DescribeRecordLogs_RecordLog recordLog = new DescribeRecordLogsResponse.DescribeRecordLogs_RecordLog();
				recordLog.ActionTime = _ctx.StringValue("DescribeRecordLogs.RecordLogs["+ i +"].ActionTime");
				recordLog.ActionTimestamp = _ctx.LongValue("DescribeRecordLogs.RecordLogs["+ i +"].ActionTimestamp");
				recordLog.Action = _ctx.StringValue("DescribeRecordLogs.RecordLogs["+ i +"].Action");
				recordLog.Message = _ctx.StringValue("DescribeRecordLogs.RecordLogs["+ i +"].Message");
				recordLog.ClientIp = _ctx.StringValue("DescribeRecordLogs.RecordLogs["+ i +"].ClientIp");

				describeRecordLogsResponse_recordLogs.Add(recordLog);
			}
			describeRecordLogsResponse.RecordLogs = describeRecordLogsResponse_recordLogs;
        
			return describeRecordLogsResponse;
        }
    }
}
