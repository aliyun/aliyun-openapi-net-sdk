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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetSparkJobExecutorLogsResponseUnmarshaller
    {
        public static GetSparkJobExecutorLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSparkJobExecutorLogsResponse getSparkJobExecutorLogsResponse = new GetSparkJobExecutorLogsResponse();

			getSparkJobExecutorLogsResponse.HttpResponse = _ctx.HttpResponse;
			getSparkJobExecutorLogsResponse.RequestId = _ctx.StringValue("GetSparkJobExecutorLogs.RequestId");
			getSparkJobExecutorLogsResponse.Success = _ctx.BooleanValue("GetSparkJobExecutorLogs.Success");
			getSparkJobExecutorLogsResponse.ErrorMessage = _ctx.StringValue("GetSparkJobExecutorLogs.ErrorMessage");
			getSparkJobExecutorLogsResponse.ErrorCode = _ctx.StringValue("GetSparkJobExecutorLogs.ErrorCode");

			List<string> getSparkJobExecutorLogsResponse_executorLogs = new List<string>();
			for (int i = 0; i < _ctx.Length("GetSparkJobExecutorLogs.ExecutorLogs.Length"); i++) {
				getSparkJobExecutorLogsResponse_executorLogs.Add(_ctx.StringValue("GetSparkJobExecutorLogs.ExecutorLogs["+ i +"]"));
			}
			getSparkJobExecutorLogsResponse.ExecutorLogs = getSparkJobExecutorLogsResponse_executorLogs;
        
			return getSparkJobExecutorLogsResponse;
        }
    }
}
