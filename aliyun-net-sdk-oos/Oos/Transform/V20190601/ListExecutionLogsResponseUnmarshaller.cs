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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListExecutionLogsResponseUnmarshaller
    {
        public static ListExecutionLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListExecutionLogsResponse listExecutionLogsResponse = new ListExecutionLogsResponse();

			listExecutionLogsResponse.HttpResponse = _ctx.HttpResponse;
			listExecutionLogsResponse.RequestId = _ctx.StringValue("ListExecutionLogs.RequestId");
			listExecutionLogsResponse.MaxResults = _ctx.IntegerValue("ListExecutionLogs.MaxResults");
			listExecutionLogsResponse.NextToken = _ctx.StringValue("ListExecutionLogs.NextToken");
			listExecutionLogsResponse.IsTruncated = _ctx.BooleanValue("ListExecutionLogs.IsTruncated");

			List<ListExecutionLogsResponse.ListExecutionLogs_ExecutionLog> listExecutionLogsResponse_executionLogs = new List<ListExecutionLogsResponse.ListExecutionLogs_ExecutionLog>();
			for (int i = 0; i < _ctx.Length("ListExecutionLogs.ExecutionLogs.Length"); i++) {
				ListExecutionLogsResponse.ListExecutionLogs_ExecutionLog executionLog = new ListExecutionLogsResponse.ListExecutionLogs_ExecutionLog();
				executionLog.Timestamp = _ctx.StringValue("ListExecutionLogs.ExecutionLogs["+ i +"].Timestamp");
				executionLog.Message = _ctx.StringValue("ListExecutionLogs.ExecutionLogs["+ i +"].Message");
				executionLog.TaskExecutionId = _ctx.StringValue("ListExecutionLogs.ExecutionLogs["+ i +"].TaskExecutionId");
				executionLog.LogType = _ctx.StringValue("ListExecutionLogs.ExecutionLogs["+ i +"].LogType");

				listExecutionLogsResponse_executionLogs.Add(executionLog);
			}
			listExecutionLogsResponse.ExecutionLogs = listExecutionLogsResponse_executionLogs;
        
			return listExecutionLogsResponse;
        }
    }
}
