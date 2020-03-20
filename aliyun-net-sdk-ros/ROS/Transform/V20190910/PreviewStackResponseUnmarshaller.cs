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
        public static PreviewStackResponse Unmarshall(UnmarshallerContext context)
        {
			PreviewStackResponse previewStackResponse = new PreviewStackResponse();

			previewStackResponse.HttpResponse = context.HttpResponse;
			previewStackResponse.RequestId = context.StringValue("PreviewStack.RequestId");

			PreviewStackResponse.PreviewStack_Stack stack = new PreviewStackResponse.PreviewStack_Stack();
			stack.Description = context.StringValue("PreviewStack.Stack.Description");
			stack.DisableRollback = context.BooleanValue("PreviewStack.Stack.DisableRollback");
			stack.RegionId = context.StringValue("PreviewStack.Stack.RegionId");
			stack.StackName = context.StringValue("PreviewStack.Stack.StackName");
			stack.StackPolicyBody = context.StringValue("PreviewStack.Stack.StackPolicyBody");
			stack.TemplateDescription = context.StringValue("PreviewStack.Stack.TemplateDescription");
			stack.TimeoutInMinutes = context.IntegerValue("PreviewStack.Stack.TimeoutInMinutes");

			List<PreviewStackResponse.PreviewStack_Stack.PreviewStack_Parameter> stack_parameters = new List<PreviewStackResponse.PreviewStack_Stack.PreviewStack_Parameter>();
			for (int i = 0; i < context.Length("PreviewStack.Stack.Parameters.Length"); i++) {
				PreviewStackResponse.PreviewStack_Stack.PreviewStack_Parameter parameter = new PreviewStackResponse.PreviewStack_Stack.PreviewStack_Parameter();
				parameter.ParameterKey = context.StringValue("PreviewStack.Stack.Parameters["+ i +"].ParameterKey");
				parameter.ParameterValue = context.StringValue("PreviewStack.Stack.Parameters["+ i +"].ParameterValue");

				stack_parameters.Add(parameter);
			}
			stack.Parameters = stack_parameters;

			List<PreviewStackResponse.PreviewStack_Stack.PreviewStack_Resource> stack_resources = new List<PreviewStackResponse.PreviewStack_Stack.PreviewStack_Resource>();
			for (int i = 0; i < context.Length("PreviewStack.Stack.Resources.Length"); i++) {
				PreviewStackResponse.PreviewStack_Stack.PreviewStack_Resource resource = new PreviewStackResponse.PreviewStack_Stack.PreviewStack_Resource();
				resource.Description = context.StringValue("PreviewStack.Stack.Resources["+ i +"].Description");
				resource.LogicalResourceId = context.StringValue("PreviewStack.Stack.Resources["+ i +"].LogicalResourceId");
				resource.Properties = context.StringValue("PreviewStack.Stack.Resources["+ i +"].Properties");
				resource.ResourceType = context.StringValue("PreviewStack.Stack.Resources["+ i +"].ResourceType");
				resource.Stack = context.StringValue("PreviewStack.Stack.Resources["+ i +"].Stack");

				List<string> resource_requiredBy = new List<string>();
				for (int j = 0; j < context.Length("PreviewStack.Stack.Resources["+ i +"].RequiredBy.Length"); j++) {
					resource_requiredBy.Add(context.StringValue("PreviewStack.Stack.Resources["+ i +"].RequiredBy["+ j +"]"));
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
