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

            List<DescribeInvocationsResponse.DescribeInvocations_Invocation> describeInvocationsResponse_invocations = new List<DescribeInvocationsResponse.DescribeInvocations_Invocation>();
            for (int i = 0; i < context.Length("DescribeInvocations.Invocations.Length"); i++)
            {
                DescribeInvocationsResponse.DescribeInvocations_Invocation invocation = new DescribeInvocationsResponse.DescribeInvocations_Invocation();
                invocation.InvokeId = context.StringValue("DescribeInvocations.Invocations[" + i + "].InvokeId");
                invocation.CommandId = context.StringValue("DescribeInvocations.Invocations[" + i + "].CommandId");
                invocation.CommandType = context.StringValue("DescribeInvocations.Invocations[" + i + "].CommandType");
                invocation.CommandName = context.StringValue("DescribeInvocations.Invocations[" + i + "].CommandName");
                invocation.Frequency = context.StringValue("DescribeInvocations.Invocations[" + i + "].Frequency");
                invocation.Timed = context.BooleanValue("DescribeInvocations.Invocations[" + i + "].Timed");
                invocation.InvokeStatus = context.StringValue("DescribeInvocations.Invocations[" + i + "].InvokeStatus");

                List<DescribeInvocationsResponse.DescribeInvocations_Invocation.DescribeInvocations_InvokeInstance> invocation_invokeInstances = new List<DescribeInvocationsResponse.DescribeInvocations_Invocation.DescribeInvocations_InvokeInstance>();
                for (int j = 0; j < context.Length("DescribeInvocations.Invocations[" + i + "].InvokeInstances.Length"); j++)
                {
                    DescribeInvocationsResponse.DescribeInvocations_Invocation.DescribeInvocations_InvokeInstance invokeInstance = new DescribeInvocationsResponse.DescribeInvocations_Invocation.DescribeInvocations_InvokeInstance();
                    invokeInstance.InstanceId = context.StringValue("DescribeInvocations.Invocations[" + i + "].InvokeInstances[" + j + "].InstanceId");
                    invokeInstance.InstanceInvokeStatus = context.StringValue("DescribeInvocations.Invocations[" + i + "].InvokeInstances[" + j + "].InstanceInvokeStatus");

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