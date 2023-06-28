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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeProjectOperateLogsResponseUnmarshaller
    {
        public static DescribeProjectOperateLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProjectOperateLogsResponse describeProjectOperateLogsResponse = new DescribeProjectOperateLogsResponse();

			describeProjectOperateLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeProjectOperateLogsResponse.Success = _ctx.BooleanValue("DescribeProjectOperateLogs.Success");
			describeProjectOperateLogsResponse.RequestId = _ctx.StringValue("DescribeProjectOperateLogs.RequestId");

			List<DescribeProjectOperateLogsResponse.DescribeProjectOperateLogs_ProjectMessage> describeProjectOperateLogsResponse_result = new List<DescribeProjectOperateLogsResponse.DescribeProjectOperateLogs_ProjectMessage>();
			for (int i = 0; i < _ctx.Length("DescribeProjectOperateLogs.Result.Length"); i++) {
				DescribeProjectOperateLogsResponse.DescribeProjectOperateLogs_ProjectMessage projectMessage = new DescribeProjectOperateLogsResponse.DescribeProjectOperateLogs_ProjectMessage();
				projectMessage.GmtCreate = _ctx.LongValue("DescribeProjectOperateLogs.Result["+ i +"].GmtCreate");
				projectMessage._Operator = _ctx.LongValue("DescribeProjectOperateLogs.Result["+ i +"].Operator");
				projectMessage.OperatorRole = _ctx.StringValue("DescribeProjectOperateLogs.Result["+ i +"].OperatorRole");
				projectMessage.Description = _ctx.StringValue("DescribeProjectOperateLogs.Result["+ i +"].Description");
				projectMessage.OperatorName = _ctx.StringValue("DescribeProjectOperateLogs.Result["+ i +"].OperatorName");

				describeProjectOperateLogsResponse_result.Add(projectMessage);
			}
			describeProjectOperateLogsResponse.Result = describeProjectOperateLogsResponse_result;
        
			return describeProjectOperateLogsResponse;
        }
    }
}
