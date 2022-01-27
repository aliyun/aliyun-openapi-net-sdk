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
        public static GetStackResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetStackResponse getStackResponse = new GetStackResponse();

			getStackResponse.HttpResponse = _ctx.HttpResponse;
			getStackResponse.CreateTime = _ctx.StringValue("GetStack.CreateTime");
			getStackResponse.Description = _ctx.StringValue("GetStack.Description");
			getStackResponse.DisableRollback = _ctx.BooleanValue("GetStack.DisableRollback");
			getStackResponse.RegionId = _ctx.StringValue("GetStack.RegionId");
			getStackResponse.RequestId = _ctx.StringValue("GetStack.RequestId");
			getStackResponse.StackId = _ctx.StringValue("GetStack.StackId");
			getStackResponse.StackName = _ctx.StringValue("GetStack.StackName");
			getStackResponse.Status = _ctx.StringValue("GetStack.Status");
			getStackResponse.StatusReason = _ctx.StringValue("GetStack.StatusReason");
			getStackResponse.TemplateDescription = _ctx.StringValue("GetStack.TemplateDescription");
			getStackResponse.TimeoutInMinutes = _ctx.IntegerValue("GetStack.TimeoutInMinutes");
			getStackResponse.UpdateTime = _ctx.StringValue("GetStack.UpdateTime");
			getStackResponse.ParentStackId = _ctx.StringValue("GetStack.ParentStackId");
			getStackResponse.StackDriftStatus = _ctx.StringValue("GetStack.StackDriftStatus");
			getStackResponse.DriftDetectionTime = _ctx.StringValue("GetStack.DriftDetectionTime");
			getStackResponse.RamRoleName = _ctx.StringValue("GetStack.RamRoleName");
			getStackResponse.DeletionProtection = _ctx.StringValue("GetStack.DeletionProtection");
			getStackResponse.RootStackId = _ctx.StringValue("GetStack.RootStackId");
			getStackResponse.StackType = _ctx.StringValue("GetStack.StackType");

			List<Dictionary<string, string>> getStackResponse_outputs = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("GetStack.Outputs.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "GetStack.Outputs["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					getStackResponse_outputs.Add(tmp);
				}
			}
			getStackResponse.Outputs = getStackResponse_outputs;

			List<string> getStackResponse_notificationURLs = new List<string>();
			for (int i = 0; i < _ctx.Length("GetStack.NotificationURLs.Length"); i++) {
				getStackResponse_notificationURLs.Add(_ctx.StringValue("GetStack.NotificationURLs["+ i +"]"));
			}
			getStackResponse.NotificationURLs = getStackResponse_notificationURLs;

			List<GetStackResponse.GetStack_Parameter> getStackResponse_parameters = new List<GetStackResponse.GetStack_Parameter>();
			for (int i = 0; i < _ctx.Length("GetStack.Parameters.Length"); i++) {
				GetStackResponse.GetStack_Parameter parameter = new GetStackResponse.GetStack_Parameter();
				parameter.ParameterKey = _ctx.StringValue("GetStack.Parameters["+ i +"].ParameterKey");
				parameter.ParameterValue = _ctx.StringValue("GetStack.Parameters["+ i +"].ParameterValue");

				getStackResponse_parameters.Add(parameter);
			}
			getStackResponse.Parameters = getStackResponse_parameters;

			List<GetStackResponse.GetStack_Tag> getStackResponse_tags = new List<GetStackResponse.GetStack_Tag>();
			for (int i = 0; i < _ctx.Length("GetStack.Tags.Length"); i++) {
				GetStackResponse.GetStack_Tag tag = new GetStackResponse.GetStack_Tag();
				tag.Key = _ctx.StringValue("GetStack.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("GetStack.Tags["+ i +"].Value");

				getStackResponse_tags.Add(tag);
			}
			getStackResponse.Tags = getStackResponse_tags;
        
			return getStackResponse;
        }
    }
}
