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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class GetPipelineInstanceGroupStatusResponseUnmarshaller
    {
        public static GetPipelineInstanceGroupStatusResponse Unmarshall(UnmarshallerContext context)
        {
			GetPipelineInstanceGroupStatusResponse getPipelineInstanceGroupStatusResponse = new GetPipelineInstanceGroupStatusResponse();

			getPipelineInstanceGroupStatusResponse.HttpResponse = context.HttpResponse;
			getPipelineInstanceGroupStatusResponse.Success = context.BooleanValue("GetPipelineInstanceGroupStatus.Success");
			getPipelineInstanceGroupStatusResponse.ErrorCode = context.StringValue("GetPipelineInstanceGroupStatus.ErrorCode");
			getPipelineInstanceGroupStatusResponse.ErrorMessage = context.StringValue("GetPipelineInstanceGroupStatus.ErrorMessage");
			getPipelineInstanceGroupStatusResponse.RequestId = context.StringValue("GetPipelineInstanceGroupStatus.RequestId");

			GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object _object = new GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object();
			_object.Status = context.StringValue("GetPipelineInstanceGroupStatus.Object.Status");

			List<GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group> _object_groups = new List<GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group>();
			for (int i = 0; i < context.Length("GetPipelineInstanceGroupStatus.Object.Groups.Length"); i++) {
				GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group group = new GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group();
				group.Name = context.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Name");
				group.Status = context.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Status");

				List<GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage> group_stages = new List<GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage>();
				for (int j = 0; j < context.Length("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages.Length"); j++) {
					GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage stage = new GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage();
					stage.Status = context.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages["+ j +"].Status");
					stage.Sign = context.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages["+ j +"].Sign");

					List<GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage.GetPipelineInstanceGroupStatus_Component> stage_components = new List<GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage.GetPipelineInstanceGroupStatus_Component>();
					for (int k = 0; k < context.Length("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages["+ j +"].Components.Length"); k++) {
						GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage.GetPipelineInstanceGroupStatus_Component component = new GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage.GetPipelineInstanceGroupStatus_Component();
						component.Name = context.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages["+ j +"].Components["+ k +"].Name");
						component.Status = context.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages["+ j +"].Components["+ k +"].Status");
						component.JobId = context.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages["+ j +"].Components["+ k +"].JobId");

						stage_components.Add(component);
					}
					stage.Components = stage_components;

					group_stages.Add(stage);
				}
				group.Stages = group_stages;

				_object_groups.Add(group);
			}
			_object.Groups = _object_groups;
			getPipelineInstanceGroupStatusResponse._Object = _object;
        
			return getPipelineInstanceGroupStatusResponse;
        }
    }
}
