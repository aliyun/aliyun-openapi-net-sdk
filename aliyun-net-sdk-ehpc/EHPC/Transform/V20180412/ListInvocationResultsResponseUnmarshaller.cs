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
using Aliyun.Acs.EHPC.Model.V20180412;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListInvocationResultsResponseUnmarshaller
    {
        public static ListInvocationResultsResponse Unmarshall(UnmarshallerContext context)
        {
			ListInvocationResultsResponse listInvocationResultsResponse = new ListInvocationResultsResponse();

			listInvocationResultsResponse.HttpResponse = context.HttpResponse;
			listInvocationResultsResponse.RequestId = context.StringValue("ListInvocationResults.RequestId");
			listInvocationResultsResponse.TotalCount = context.IntegerValue("ListInvocationResults.TotalCount");
			listInvocationResultsResponse.PageNumber = context.IntegerValue("ListInvocationResults.PageNumber");
			listInvocationResultsResponse.PageSize = context.IntegerValue("ListInvocationResults.PageSize");

			List<ListInvocationResultsResponse.ListInvocationResults_InvocationResult> listInvocationResultsResponse_invocationResults = new List<ListInvocationResultsResponse.ListInvocationResults_InvocationResult>();
			for (int i = 0; i < context.Length("ListInvocationResults.InvocationResults.Length"); i++) {
				ListInvocationResultsResponse.ListInvocationResults_InvocationResult invocationResult = new ListInvocationResultsResponse.ListInvocationResults_InvocationResult();
				invocationResult.Success = context.BooleanValue("ListInvocationResults.InvocationResults["+ i +"].Success");
				invocationResult.CommandId = context.StringValue("ListInvocationResults.InvocationResults["+ i +"].CommandId");
				invocationResult.InstanceId = context.StringValue("ListInvocationResults.InvocationResults["+ i +"].InstanceId");
				invocationResult.InvokeRecordStatus = context.StringValue("ListInvocationResults.InvocationResults["+ i +"].InvokeRecordStatus");
				invocationResult.FinishedTime = context.StringValue("ListInvocationResults.InvocationResults["+ i +"].FinishedTime");
				invocationResult.ExitCode = context.IntegerValue("ListInvocationResults.InvocationResults["+ i +"].ExitCode");
				invocationResult.Message = context.StringValue("ListInvocationResults.InvocationResults["+ i +"].Message");

				listInvocationResultsResponse_invocationResults.Add(invocationResult);
			}
			listInvocationResultsResponse.InvocationResults = listInvocationResultsResponse_invocationResults;
        
			return listInvocationResultsResponse;
        }
    }
}