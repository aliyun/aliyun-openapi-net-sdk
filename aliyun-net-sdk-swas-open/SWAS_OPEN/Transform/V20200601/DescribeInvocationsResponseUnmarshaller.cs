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
    public class DescribeInvocationsResponseUnmarshaller
    {
        public static DescribeInvocationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInvocationsResponse describeInvocationsResponse = new DescribeInvocationsResponse();

			describeInvocationsResponse.HttpResponse = _ctx.HttpResponse;
			describeInvocationsResponse.RequestId = _ctx.StringValue("DescribeInvocations.RequestId");
			describeInvocationsResponse.PageSize = _ctx.IntegerValue("DescribeInvocations.PageSize");
			describeInvocationsResponse.PageNumber = _ctx.IntegerValue("DescribeInvocations.PageNumber");
			describeInvocationsResponse.TotalCount = _ctx.IntegerValue("DescribeInvocations.TotalCount");

			List<DescribeInvocationsResponse.DescribeInvocations_Invocation> describeInvocationsResponse_invocations = new List<DescribeInvocationsResponse.DescribeInvocations_Invocation>();
			for (int i = 0; i < _ctx.Length("DescribeInvocations.Invocations.Length"); i++) {
				DescribeInvocationsResponse.DescribeInvocations_Invocation invocation = new DescribeInvocationsResponse.DescribeInvocations_Invocation();
				invocation.CreationTime = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].CreationTime");
				invocation.InvocationStatus = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvocationStatus");
				invocation.CommandType = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].CommandType");
				invocation.CommandContent = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].CommandContent");
				invocation.Parameters = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].Parameters");
				invocation.InvokeStatus = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeStatus");
				invocation.InvokeId = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].InvokeId");
				invocation.CommandName = _ctx.StringValue("DescribeInvocations.Invocations["+ i +"].CommandName");

				describeInvocationsResponse_invocations.Add(invocation);
			}
			describeInvocationsResponse.Invocations = describeInvocationsResponse_invocations;
        
			return describeInvocationsResponse;
        }
    }
}
