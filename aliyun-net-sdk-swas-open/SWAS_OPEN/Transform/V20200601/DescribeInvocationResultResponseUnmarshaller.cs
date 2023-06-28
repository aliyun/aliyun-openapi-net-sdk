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
using Aliyun.Acs.SWAS_OPEN.Model.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Transform.V20200601
{
    public class DescribeInvocationResultResponseUnmarshaller
    {
        public static DescribeInvocationResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInvocationResultResponse describeInvocationResultResponse = new DescribeInvocationResultResponse();

			describeInvocationResultResponse.HttpResponse = _ctx.HttpResponse;
			describeInvocationResultResponse.RequestId = _ctx.StringValue("DescribeInvocationResult.RequestId");

			DescribeInvocationResultResponse.DescribeInvocationResult_InvocationResult invocationResult = new DescribeInvocationResultResponse.DescribeInvocationResult_InvocationResult();
			invocationResult.StartTime = _ctx.StringValue("DescribeInvocationResult.InvocationResult.StartTime");
			invocationResult.FinishedTime = _ctx.StringValue("DescribeInvocationResult.InvocationResult.FinishedTime");
			invocationResult.InvocationStatus = _ctx.StringValue("DescribeInvocationResult.InvocationResult.InvocationStatus");
			invocationResult.ExitCode = _ctx.LongValue("DescribeInvocationResult.InvocationResult.ExitCode");
			invocationResult.ErrorInfo = _ctx.StringValue("DescribeInvocationResult.InvocationResult.ErrorInfo");
			invocationResult.ErrorCode = _ctx.StringValue("DescribeInvocationResult.InvocationResult.ErrorCode");
			invocationResult.InvokeId = _ctx.StringValue("DescribeInvocationResult.InvocationResult.InvokeId");
			invocationResult.InvokeRecordStatus = _ctx.StringValue("DescribeInvocationResult.InvocationResult.InvokeRecordStatus");
			invocationResult.InvokeUser = _ctx.StringValue("DescribeInvocationResult.InvocationResult.InvokeUser");
			invocationResult.Output = _ctx.StringValue("DescribeInvocationResult.InvocationResult.Output");
			invocationResult.InstanceId = _ctx.StringValue("DescribeInvocationResult.InvocationResult.InstanceId");
			describeInvocationResultResponse.InvocationResult = invocationResult;
        
			return describeInvocationResultResponse;
        }
    }
}
