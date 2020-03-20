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
    public class GetStackResponseUnmarshaller
    {
        public static GetStackResponse Unmarshall(UnmarshallerContext context)
        {
			GetStackResponse getStackResponse = new GetStackResponse();

			getStackResponse.HttpResponse = context.HttpResponse;
			getStackResponse.CreateTime = context.StringValue("GetStack.CreateTime");
			getStackResponse.Description = context.StringValue("GetStack.Description");
			getStackResponse.DisableRollback = context.BooleanValue("GetStack.DisableRollback");
			getStackResponse.RegionId = context.StringValue("GetStack.RegionId");
			getStackResponse.RequestId = context.StringValue("GetStack.RequestId");
			getStackResponse.StackId = context.StringValue("GetStack.StackId");
			getStackResponse.StackName = context.StringValue("GetStack.StackName");
			getStackResponse.Status = context.StringValue("GetStack.Status");
			getStackResponse.StatusReason = context.StringValue("GetStack.StatusReason");
			getStackResponse.TemplateDescription = context.StringValue("GetStack.TemplateDescription");
			getStackResponse.TimeoutInMinutes = context.IntegerValue("GetStack.TimeoutInMinutes");
			getStackResponse.UpdateTime = context.StringValue("GetStack.UpdateTime");
			getStackResponse.ParentStackId = context.StringValue("GetStack.ParentStackId");
			getStackResponse.StackDriftStatus = context.StringValue("GetStack.StackDriftStatus");
			getStackResponse.DriftDetectionTime = context.StringValue("GetStack.DriftDetectionTime");
			getStackResponse.RamRoleName = context.StringValue("GetStack.RamRoleName");

			List<Dictionary<string, string>> getStackResponse_outputs = new List<Dictionary<string, string>>();
			for (int i = 0; i < context.Length("GetStack.Outputs.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var item in context.ResponseDictionary){
					string prefix = "GetStack.Outputs["+ i +"].";
					if (item.Key.IndexOf(prefix) == 0){
						tmp.Add(item.Key.Substring(prefix.Length), item.Value);
					}
				}
				if (tmp.Count > 0){
					getStackResponse_outputs.Add(tmp);
				}
			}
			getStackResponse.Outputs = getStackResponse_outputs;

			List<string> getStackResponse_notificationURLs = new List<string>();
			for (int i = 0; i < context.Length("GetStack.NotificationURLs.Length"); i++) {
				getStackResponse_notificationURLs.Add(context.StringValue("GetStack.NotificationURLs["+ i +"]"));
			}
			getStackResponse.NotificationURLs = getStackResponse_notificationURLs;

			List<GetStackResponse.GetStack_Parameter> getStackResponse_parameters = new List<GetStackResponse.GetStack_Parameter>();
			for (int i = 0; i < context.Length("GetStack.Parameters.Length"); i++) {
				GetStackResponse.GetStack_Parameter parameter = new GetStackResponse.GetStack_Parameter();
				parameter.ParameterKey = context.StringValue("GetStack.Parameters["+ i +"].ParameterKey");
				parameter.ParameterValue = context.StringValue("GetStack.Parameters["+ i +"].ParameterValue");

				getStackResponse_parameters.Add(parameter);
			}
			getStackResponse.Parameters = getStackResponse_parameters;
        
			return getStackResponse;
        }
    }
}
