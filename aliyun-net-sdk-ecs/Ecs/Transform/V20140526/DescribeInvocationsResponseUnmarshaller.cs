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
    public class DescribeInvocationsResponseUnmarshaller
    {
        public static DescribeInvocationsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInvocationsResponse describeInvocationsResponse = new DescribeInvocationsResponse();

			describeInvocationsResponse.HttpResponse = context.HttpResponse;
			describeInvocationsResponse.RequestId = context.StringValue("DescribeInvocations.RequestId");
			describeInvocationsResponse.TotalCount = context.LongValue("DescribeInvocations.TotalCount");
			describeInvocationsResponse.PageNumber = context.LongValue("DescribeInvocations.PageNumber");
			describeInvocationsResponse.PageSize = context.LongValue("DescribeInvocations.PageSize");

			List<DescribeInvocationsResponse.DescribeInvocations_InvocationItem> describeInvocationsResponse_invocation = new List<DescribeInvocationsResponse.DescribeInvocations_InvocationItem>();
			for (int i = 0; i < context.Length("DescribeInvocations.Invocation.Length"); i++) {
				DescribeInvocationsResponse.DescribeInvocations_InvocationItem invocationItem = new DescribeInvocationsResponse.DescribeInvocations_InvocationItem();
				invocationItem.InvokeId = context.StringValue("DescribeInvocations.Invocation["+ i +"].InvokeId");
				invocationItem.CommandId = context.StringValue("DescribeInvocations.Invocation["+ i +"].CommandId");
				invocationItem.CommandType = context.StringValue("DescribeInvocations.Invocation["+ i +"].CommandType");
				invocationItem.CommandName = context.StringValue("DescribeInvocations.Invocation["+ i +"].CommandName");
				invocationItem.Timed = context.BooleanValue("DescribeInvocations.Invocation["+ i +"].Timed");
				invocationItem.InvokeStatus = context.StringValue("DescribeInvocations.Invocation["+ i +"].InvokeStatus");

				List<DescribeInvocationsResponse.DescribeInvocations_InvocationItem.DescribeInvocations_InvokeItemItem> invocationItem_invokeItem = new List<DescribeInvocationsResponse.DescribeInvocations_InvocationItem.DescribeInvocations_InvokeItemItem>();
				for (int j = 0; j < context.Length("DescribeInvocations.Invocation["+ i +"].InvokeItem.Length"); j++) {
					DescribeInvocationsResponse.DescribeInvocations_InvocationItem.DescribeInvocations_InvokeItemItem invokeItemItem = new DescribeInvocationsResponse.DescribeInvocations_InvocationItem.DescribeInvocations_InvokeItemItem();
					invokeItemItem.InstanceId = context.StringValue("DescribeInvocations.Invocation["+ i +"].InvokeItem["+ j +"].InstanceId");
					invokeItemItem.Status = context.StringValue("DescribeInvocations.Invocation["+ i +"].InvokeItem["+ j +"].Status");

					invocationItem_invokeItem.Add(invokeItemItem);
				}
				invocationItem.InvokeItem = invocationItem_invokeItem;

				describeInvocationsResponse_invocation.Add(invocationItem);
			}
			describeInvocationsResponse.Invocation = describeInvocationsResponse_invocation;
        
			return describeInvocationsResponse;
        }
    }
}