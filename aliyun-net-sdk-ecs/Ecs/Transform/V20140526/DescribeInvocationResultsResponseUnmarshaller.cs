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
			invocation.InvokeId = context.StringValue("DescribeInvocationResults.Invocation.InvokeId");
			invocation.PageSize = context.LongValue("DescribeInvocationResults.Invocation.PageSize");
			invocation.PageNumber = context.LongValue("DescribeInvocationResults.Invocation.PageNumber");
			invocation.TotalCount = context.LongValue("DescribeInvocationResults.Invocation.TotalCount");
			invocation.Status = context.StringValue("DescribeInvocationResults.Invocation.Status");

			List<DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation.DescribeInvocationResults_ResultItem> invocation_resultLists = new List<DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation.DescribeInvocationResults_ResultItem>();
			for (int i = 0; i < context.Length("DescribeInvocationResults.Invocation.ResultLists.Length"); i++) {
				DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation.DescribeInvocationResults_ResultItem resultItem = new DescribeInvocationResultsResponse.DescribeInvocationResults_Invocation.DescribeInvocationResults_ResultItem();
				resultItem.InstanceId = context.StringValue("DescribeInvocationResults.Invocation.ResultLists["+ i +"].InstanceId");
				resultItem.FinishedTime = context.StringValue("DescribeInvocationResults.Invocation.ResultLists["+ i +"].FinishedTime");
				resultItem.Output = context.StringValue("DescribeInvocationResults.Invocation.ResultLists["+ i +"].Output");
				resultItem.ExitCode = context.LongValue("DescribeInvocationResults.Invocation.ResultLists["+ i +"].ExitCode");

				invocation_resultLists.Add(resultItem);
			}
			invocation.ResultLists = invocation_resultLists;
			describeInvocationResultsResponse.Invocation = invocation;
        
			return describeInvocationResultsResponse;
        }
    }
}