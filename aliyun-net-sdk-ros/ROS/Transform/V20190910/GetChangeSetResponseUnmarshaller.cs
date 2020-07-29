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
    public class GetChangeSetResponseUnmarshaller
    {
        public static GetChangeSetResponse Unmarshall(UnmarshallerContext context)
        {
			GetChangeSetResponse getChangeSetResponse = new GetChangeSetResponse();

			getChangeSetResponse.HttpResponse = context.HttpResponse;
			getChangeSetResponse.ChangeSetId = context.StringValue("GetChangeSet.ChangeSetId");
			getChangeSetResponse.ChangeSetName = context.StringValue("GetChangeSet.ChangeSetName");
			getChangeSetResponse.ChangeSetType = context.StringValue("GetChangeSet.ChangeSetType");
			getChangeSetResponse.CreateTime = context.StringValue("GetChangeSet.CreateTime");
			getChangeSetResponse.Description = context.StringValue("GetChangeSet.Description");
			getChangeSetResponse.DisableRollback = context.BooleanValue("GetChangeSet.DisableRollback");
			getChangeSetResponse.ExecutionStatus = context.StringValue("GetChangeSet.ExecutionStatus");
			getChangeSetResponse.RegionId = context.StringValue("GetChangeSet.RegionId");
			getChangeSetResponse.RequestId = context.StringValue("GetChangeSet.RequestId");
			getChangeSetResponse.StackId = context.StringValue("GetChangeSet.StackId");
			getChangeSetResponse.StackName = context.StringValue("GetChangeSet.StackName");
			getChangeSetResponse.Status = context.StringValue("GetChangeSet.Status");
			getChangeSetResponse.TemplateBody = context.StringValue("GetChangeSet.TemplateBody");
			getChangeSetResponse.TimeoutInMinutes = context.IntegerValue("GetChangeSet.TimeoutInMinutes");
			getChangeSetResponse.StatusReason = context.StringValue("GetChangeSet.StatusReason");

			List<Dictionary<string, string>> getChangeSetResponse_changes = new List<Dictionary<string, string>>();
			for (int i = 0; i < context.Length("GetChangeSet.Changes.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in context.ResponseDictionary){
					string prefix = "GetChangeSet.Changes["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					getChangeSetResponse_changes.Add(tmp);
				}
			}
			getChangeSetResponse.Changes = getChangeSetResponse_changes;

			List<GetChangeSetResponse.GetChangeSet_Parameter> getChangeSetResponse_parameters = new List<GetChangeSetResponse.GetChangeSet_Parameter>();
			for (int i = 0; i < context.Length("GetChangeSet.Parameters.Length"); i++) {
				GetChangeSetResponse.GetChangeSet_Parameter parameter = new GetChangeSetResponse.GetChangeSet_Parameter();
				parameter.ParameterKey = context.StringValue("GetChangeSet.Parameters["+ i +"].ParameterKey");
				parameter.ParameterValue = context.StringValue("GetChangeSet.Parameters["+ i +"].ParameterValue");

				getChangeSetResponse_parameters.Add(parameter);
			}
			getChangeSetResponse.Parameters = getChangeSetResponse_parameters;
        
			return getChangeSetResponse;
        }
    }
}
