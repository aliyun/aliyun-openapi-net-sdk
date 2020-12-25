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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeFlowNodeInstanceLauncherLogResponseUnmarshaller
    {
        public static DescribeFlowNodeInstanceLauncherLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFlowNodeInstanceLauncherLogResponse describeFlowNodeInstanceLauncherLogResponse = new DescribeFlowNodeInstanceLauncherLogResponse();

			describeFlowNodeInstanceLauncherLogResponse.HttpResponse = _ctx.HttpResponse;
			describeFlowNodeInstanceLauncherLogResponse.RequestId = _ctx.StringValue("DescribeFlowNodeInstanceLauncherLog.RequestId");
			describeFlowNodeInstanceLauncherLogResponse.LogEnd = _ctx.BooleanValue("DescribeFlowNodeInstanceLauncherLog.LogEnd");

			List<DescribeFlowNodeInstanceLauncherLogResponse.DescribeFlowNodeInstanceLauncherLog_LogEntry> describeFlowNodeInstanceLauncherLogResponse_logEntrys = new List<DescribeFlowNodeInstanceLauncherLogResponse.DescribeFlowNodeInstanceLauncherLog_LogEntry>();
			for (int i = 0; i < _ctx.Length("DescribeFlowNodeInstanceLauncherLog.LogEntrys.Length"); i++) {
				DescribeFlowNodeInstanceLauncherLogResponse.DescribeFlowNodeInstanceLauncherLog_LogEntry logEntry = new DescribeFlowNodeInstanceLauncherLogResponse.DescribeFlowNodeInstanceLauncherLog_LogEntry();
				logEntry.Content = _ctx.StringValue("DescribeFlowNodeInstanceLauncherLog.LogEntrys["+ i +"].Content");

				describeFlowNodeInstanceLauncherLogResponse_logEntrys.Add(logEntry);
			}
			describeFlowNodeInstanceLauncherLogResponse.LogEntrys = describeFlowNodeInstanceLauncherLogResponse_logEntrys;
        
			return describeFlowNodeInstanceLauncherLogResponse;
        }
    }
}
