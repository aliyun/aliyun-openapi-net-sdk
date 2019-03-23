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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeInvocationResultsResponseUnmarshaller
    {
        public static DescribeInvocationResultsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeInvocationResultsResponse describeInvocationResultsResponse = new DescribeInvocationResultsResponse();

            describeInvocationResultsResponse.HttpResponse = context.HttpResponse;
            describeInvocationResultsResponse.RequestId = context.StringValue("DescribeInvocationResults.RequestId");

            DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation invocation = new DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation();
            invocation.PageSize = context.LongValue("DescribeInvocationResults.Invocation.PageSize");
            invocation.PageNumber = context.LongValue("DescribeInvocationResults.Invocation.PageNumber");
            invocation.TotalCount = context.LongValue("DescribeInvocationResults.Invocation.TotalCount");

            List<DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation.DescribeInvocationResults_InvocationResult> invocation_invocationResults = new List<DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation.DescribeInvocationResults_InvocationResult>();
            for (int i = 0; i < context.Length("DescribeInvocationResults.Invocation.InvocationResults.Length"); i++)
            {
                DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation.DescribeInvocationResults_InvocationResult invocationResult = new DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation.DescribeInvocationResults_InvocationResult();
                invocationResult.CommandId = context.StringValue("DescribeInvocationResults.Invocation.InvocationResults[" + i + "].CommandId");
                invocationResult.InvokeId = context.StringValue("DescribeInvocationResults.Invocation.InvocationResults[" + i + "].InvokeId");
                invocationResult.InstanceId = context.StringValue("DescribeInvocationResults.Invocation.InvocationResults[" + i + "].InstanceId");
                invocationResult.FinishedTime = context.StringValue("DescribeInvocationResults.Invocation.InvocationResults[" + i + "].FinishedTime");
                invocationResult.Output = context.StringValue("DescribeInvocationResults.Invocation.InvocationResults[" + i + "].Output");
                invocationResult.InvokeRecordStatus = context.StringValue("DescribeInvocationResults.Invocation.InvocationResults[" + i + "].InvokeRecordStatus");
                invocationResult.ExitCode = context.LongValue("DescribeInvocationResults.Invocation.InvocationResults[" + i + "].ExitCode");

                invocation_invocationResults.Add(invocationResult);
            }
            invocation.InvocationResults = invocation_invocationResults;
            describeInvocationResultsResponse.Invocation = invocation;

            return describeInvocationResultsResponse;
        }
    }
}