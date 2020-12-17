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
    public class PreviewStackResponseUnmarshaller
    {
        public static PreviewStackResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PreviewStackResponse previewStackResponse = new PreviewStackResponse();

			previewStackResponse.HttpResponse = _ctx.HttpResponse;
			previewStackResponse.RequestId = _ctx.StringValue("PreviewStack.RequestId");

			PreviewStackResponse.PreviewStack_Stack stack = new PreviewStackResponse.PreviewStack_Stack();
			stack.Description = _ctx.StringValue("PreviewStack.Stack.Description");
			stack.DisableRollback = _ctx.BooleanValue("PreviewStack.Stack.DisableRollback");
			stack.RegionId = _ctx.StringValue("PreviewStack.Stack.RegionId");
			stack.StackName = _ctx.StringValue("PreviewStack.Stack.StackName");
			stack.StackPolicyBody = _ctx.StringValue("PreviewStack.Stack.StackPolicyBody");
			stack.TemplateDescription = _ctx.StringValue("PreviewStack.Stack.TemplateDescription");
			stack.TimeoutInMinutes = _ctx.IntegerValue("PreviewStack.Stack.TimeoutInMinutes");

			List<PreviewStackResponse.PreviewStack_Stack.PreviewStack_Parameter> stack_parameters = new List<PreviewStackResponse.PreviewStack_Stack.PreviewStack_Parameter>();
			for (int i = 0; i < _ctx.Length("PreviewStack.Stack.Parameters.Length"); i++) {
				PreviewStackResponse.PreviewStack_Stack.PreviewStack_Parameter parameter = new PreviewStackResponse.PreviewStack_Stack.PreviewStack_Parameter();
				parameter.ParameterKey = _ctx.StringValue("PreviewStack.Stack.Parameters["+ i +"].ParameterKey");
				parameter.ParameterValue = _ctx.StringValue("PreviewStack.Stack.Parameters["+ i +"].ParameterValue");

				stack_parameters.Add(parameter);
			}
			stack.Parameters = stack_parameters;

			List<PreviewStackResponse.PreviewStack_Stack.PreviewStack_Resource> stack_resources = new List<PreviewStackResponse.PreviewStack_Stack.PreviewStack_Resource>();
			for (int i = 0; i < _ctx.Length("PreviewStack.Stack.Resources.Length"); i++) {
				PreviewStackResponse.PreviewStack_Stack.PreviewStack_Resource resource = new PreviewStackResponse.PreviewStack_Stack.PreviewStack_Resource();
				resource.Description = _ctx.StringValue("PreviewStack.Stack.Resources["+ i +"].Description");
				resource.LogicalResourceId = _ctx.StringValue("PreviewStack.Stack.Resources["+ i +"].LogicalResourceId");
				resource.Properties = _ctx.StringValue("PreviewStack.Stack.Resources["+ i +"].Properties");
				resource.ResourceType = _ctx.StringValue("PreviewStack.Stack.Resources["+ i +"].ResourceType");
				resource.Stack = _ctx.StringValue("PreviewStack.Stack.Resources["+ i +"].Stack");

				List<string> resource_requiredBy = new List<string>();
				for (int j = 0; j < _ctx.Length("PreviewStack.Stack.Resources["+ i +"].RequiredBy.Length"); j++) {
					resource_requiredBy.Add(_ctx.StringValue("PreviewStack.Stack.Resources["+ i +"].RequiredBy["+ j +"]"));
				}
				resource.RequiredBy = resource_requiredBy;

				stack_resources.Add(resource);
			}
			stack.Resources = stack_resources;
			previewStackResponse.Stack = stack;
        
			return previewStackResponse;
        }
    }
}
