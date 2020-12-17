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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeInvocationResultsResponseUnmarshaller
    {
        public static DescribeInvocationResultsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInvocationResultsResponse describeInvocationResultsResponse = new DescribeInvocationResultsResponse();

			describeInvocationResultsResponse.HttpResponse = _ctx.HttpResponse;
			describeInvocationResultsResponse.RequestId = _ctx.StringValue("DescribeInvocationResults.RequestId");

			DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation invocation = new DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation();
			invocation.PageSize = _ctx.LongValue("DescribeInvocationResults.Invocation.PageSize");
			invocation.PageNumber = _ctx.LongValue("DescribeInvocationResults.Invocation.PageNumber");
			invocation.TotalCount = _ctx.LongValue("DescribeInvocationResults.Invocation.TotalCount");

			List<DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation.DescribeInvocationResults_InvocationResult> invocation_invocationResults = new List<DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation.DescribeInvocationResults_InvocationResult>();
			for (int i = 0; i < _ctx.Length("DescribeInvocationResults.Invocation.InvocationResults.Length"); i++) {
				DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation.DescribeInvocationResults_InvocationResult invocationResult = new DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation.DescribeInvocationResults_InvocationResult();
				invocationResult.CommandId = _ctx.StringValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].CommandId");
				invocationResult.InvokeId = _ctx.StringValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].InvokeId");
				invocationResult.InstanceId = _ctx.StringValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].InstanceId");
				invocationResult.StartTime = _ctx.StringValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].StartTime");
				invocationResult.StopTime = _ctx.StringValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].StopTime");
				invocationResult.FinishedTime = _ctx.StringValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].FinishedTime");
				invocationResult.Repeats = _ctx.IntegerValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].Repeats");
				invocationResult.Output = _ctx.StringValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].Output");
				invocationResult.Dropped = _ctx.IntegerValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].Dropped");
				invocationResult.InvokeRecordStatus = _ctx.StringValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].InvokeRecordStatus");
				invocationResult.InvocationStatus = _ctx.StringValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].InvocationStatus");
				invocationResult.ExitCode = _ctx.LongValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].ExitCode");
				invocationResult.ErrorCode = _ctx.StringValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].ErrorCode");
				invocationResult.ErrorInfo = _ctx.StringValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].ErrorInfo");
				invocationResult.Username = _ctx.StringValue("DescribeInvocationResults.Invocation.InvocationResults["+ i +"].Username");

				invocation_invocationResults.Add(invocationResult);
			}
			invocation.InvocationResults = invocation_invocationResults;
			describeInvocationResultsResponse.Invocation = invocation;
        
			return describeInvocationResultsResponse;
        }
    }
}
