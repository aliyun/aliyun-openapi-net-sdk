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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ListStacksResponseUnmarshaller
    {
        public static ListStacksResponse Unmarshall(UnmarshallerContext context)
        {
			ListStacksResponse listStacksResponse = new ListStacksResponse();

			listStacksResponse.HttpResponse = context.HttpResponse;
			listStacksResponse.PageNumber = context.IntegerValue("ListStacks.PageNumber");
			listStacksResponse.PageSize = context.IntegerValue("ListStacks.PageSize");
			listStacksResponse.RequestId = context.StringValue("ListStacks.RequestId");
			listStacksResponse.TotalCount = context.IntegerValue("ListStacks.TotalCount");

			List<ListStacksResponse.ListStacks_Stack> listStacksResponse_stacks = new List<ListStacksResponse.ListStacks_Stack>();
			for (int i = 0; i < context.Length("ListStacks.Stacks.Length"); i++) {
				ListStacksResponse.ListStacks_Stack stack = new ListStacksResponse.ListStacks_Stack();
				stack.CreateTime = context.StringValue("ListStacks.Stacks["+ i +"].CreateTime");
				stack.DisableRollback = context.BooleanValue("ListStacks.Stacks["+ i +"].DisableRollback");
				stack.RegionId = context.StringValue("ListStacks.Stacks["+ i +"].RegionId");
				stack.StackId = context.StringValue("ListStacks.Stacks["+ i +"].StackId");
				stack.StackName = context.StringValue("ListStacks.Stacks["+ i +"].StackName");
				stack.Status = context.StringValue("ListStacks.Stacks["+ i +"].Status");
				stack.StatusReason = context.StringValue("ListStacks.Stacks["+ i +"].StatusReason");
				stack.TimeoutInMinutes = context.IntegerValue("ListStacks.Stacks["+ i +"].TimeoutInMinutes");
				stack.ParentStackId = context.StringValue("ListStacks.Stacks["+ i +"].ParentStackId");
				stack.UpdateTime = context.StringValue("ListStacks.Stacks["+ i +"].UpdateTime");
				stack.StackDriftStatus = context.StringValue("ListStacks.Stacks["+ i +"].StackDriftStatus");
				stack.DriftDetectionTime = context.StringValue("ListStacks.Stacks["+ i +"].DriftDetectionTime");

				listStacksResponse_stacks.Add(stack);
			}
			listStacksResponse.Stacks = listStacksResponse_stacks;
        
			return listStacksResponse;
        }
    }
}
