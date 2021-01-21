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
        public static ListStacksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStacksResponse listStacksResponse = new ListStacksResponse();

			listStacksResponse.HttpResponse = _ctx.HttpResponse;
			listStacksResponse.PageNumber = _ctx.IntegerValue("ListStacks.PageNumber");
			listStacksResponse.PageSize = _ctx.IntegerValue("ListStacks.PageSize");
			listStacksResponse.RequestId = _ctx.StringValue("ListStacks.RequestId");
			listStacksResponse.TotalCount = _ctx.IntegerValue("ListStacks.TotalCount");

			List<ListStacksResponse.ListStacks_Stack> listStacksResponse_stacks = new List<ListStacksResponse.ListStacks_Stack>();
			for (int i = 0; i < _ctx.Length("ListStacks.Stacks.Length"); i++) {
				ListStacksResponse.ListStacks_Stack stack = new ListStacksResponse.ListStacks_Stack();
				stack.CreateTime = _ctx.StringValue("ListStacks.Stacks["+ i +"].CreateTime");
				stack.DisableRollback = _ctx.BooleanValue("ListStacks.Stacks["+ i +"].DisableRollback");
				stack.RegionId = _ctx.StringValue("ListStacks.Stacks["+ i +"].RegionId");
				stack.StackId = _ctx.StringValue("ListStacks.Stacks["+ i +"].StackId");
				stack.StackName = _ctx.StringValue("ListStacks.Stacks["+ i +"].StackName");
				stack.Status = _ctx.StringValue("ListStacks.Stacks["+ i +"].Status");
				stack.StatusReason = _ctx.StringValue("ListStacks.Stacks["+ i +"].StatusReason");
				stack.TimeoutInMinutes = _ctx.IntegerValue("ListStacks.Stacks["+ i +"].TimeoutInMinutes");
				stack.ParentStackId = _ctx.StringValue("ListStacks.Stacks["+ i +"].ParentStackId");
				stack.UpdateTime = _ctx.StringValue("ListStacks.Stacks["+ i +"].UpdateTime");
				stack.StackDriftStatus = _ctx.StringValue("ListStacks.Stacks["+ i +"].StackDriftStatus");
				stack.DriftDetectionTime = _ctx.StringValue("ListStacks.Stacks["+ i +"].DriftDetectionTime");
				stack.StackType = _ctx.StringValue("ListStacks.Stacks["+ i +"].StackType");

				List<ListStacksResponse.ListStacks_Stack.ListStacks_Tag> stack_tags = new List<ListStacksResponse.ListStacks_Stack.ListStacks_Tag>();
				for (int j = 0; j < _ctx.Length("ListStacks.Stacks["+ i +"].Tags.Length"); j++) {
					ListStacksResponse.ListStacks_Stack.ListStacks_Tag tag = new ListStacksResponse.ListStacks_Stack.ListStacks_Tag();
					tag.Key = _ctx.StringValue("ListStacks.Stacks["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("ListStacks.Stacks["+ i +"].Tags["+ j +"].Value");

					stack_tags.Add(tag);
				}
				stack.Tags = stack_tags;

				listStacksResponse_stacks.Add(stack);
			}
			listStacksResponse.Stacks = listStacksResponse_stacks;
        
			return listStacksResponse;
        }
    }
}
