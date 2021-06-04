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
    public class DescribeInvocationsResponseUnmarshaller
    {
        public static DescribeInvocationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInvocationsResponse describeInvocationsResponse = new DescribeInvocationsResponse();

			describeInvocationsResponse.HttpResponse = _ctx.HttpResponse;
			describeInvocationsResponse.PageSize = _ctx.LongValue("DescribeInvocations.PageSize");
			describeInvocationsResponse.RequestId = _ctx.StringValue("DescribeInvocations.RequestId");
			describeInvocationsResponse.PageNumber = _ctx.LongValue("DescribeInvocations.PageNumber");
			describeInvocationsResponse.TotalCount = _ctx.LongValue("DescribeInvocations.TotalCount");

			List<DescribeInvocationsResponse.DescribeInvocations_Invocation> describeInvocationsResponse_invocations = new List<DescribeInvocationsResponse.DescribeInvocations_Invocation>();
			for (int i = 0; i < _ctx.Length("DescribeInvocations.Invocations.Length"); i++) {
				DescribeInvocationsResponse.DescribeInvocations_Invocation invocation = new DescribeInvocationsResponse.DescribeInvocations_Invocation();
				invocation.CreationTime = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].CreationTime");
				invocation.Frequency = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].Frequency");
				invocation.InvocationStatus = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvocationStatus");
				invocation.RepeatMode = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].RepeatMode");
				invocation.CommandId = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].CommandId");
				invocation.CommandType = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].CommandType");
				invocation.InvokeStatus = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeStatus");
				invocation.Parameters = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].Parameters");
				invocation.Timed = _ctx.BooleanValue("DescribeInvocations.Invocations["+ i +"].Timed");
				invocation.CommandContent = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].CommandContent");
				invocation.CommandName = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].CommandName");
				invocation.InvokeId = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeId");
				invocation.Username = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].Username");

				List<DescribeInvocationsResponse.DescribeInvocations_Invocation.DescribeInvocations_InvokeInstance> invocation_invokeInstances = new List<DescribeInvocationsResponse.DescribeInvocations_Invocation.DescribeInvocations_InvokeInstance>();
				for (int j = 0; j < _ctx.Length("DescribeInvocations.Invocations["+ i +"].InvokeInstances.Length"); j++) {
					DescribeInvocationsResponse.DescribeInvocations_Invocation.DescribeInvocations_InvokeInstance invokeInstance = new DescribeInvocationsResponse.DescribeInvocations_Invocation.DescribeInvocations_InvokeInstance();
					invokeInstance.CreationTime = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].CreationTime");
					invokeInstance.UpdateTime = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].UpdateTime");
					invokeInstance.FinishTime = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].FinishTime");
					invokeInstance.InvocationStatus = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].InvocationStatus");
					invokeInstance.Repeats = _ctx.IntegerValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].Repeats");
					invokeInstance.InstanceId = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].InstanceId");
					invokeInstance.Output = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].Output");
					invokeInstance.Dropped = _ctx.IntegerValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].Dropped");
					invokeInstance.StopTime = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].StopTime");
					invokeInstance.ExitCode = _ctx.LongValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].ExitCode");
					invokeInstance.StartTime = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].StartTime");
					invokeInstance.ErrorInfo = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].ErrorInfo");
					invokeInstance.Timed = _ctx.BooleanValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].Timed");
					invokeInstance.ErrorCode = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].ErrorCode");
					invokeInstance.InstanceInvokeStatus = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeInstances["+ j +"].InstanceInvokeStatus");

					invocation_invokeInstances.Add(invokeInstance);
				}
				invocation.InvokeInstances = invocation_invokeInstances;

				describeInvocationsResponse_invocations.Add(invocation);
			}
			describeInvocationsResponse.Invocations = describeInvocationsResponse_invocations;
        
			return describeInvocationsResponse;
        }
    }
}
