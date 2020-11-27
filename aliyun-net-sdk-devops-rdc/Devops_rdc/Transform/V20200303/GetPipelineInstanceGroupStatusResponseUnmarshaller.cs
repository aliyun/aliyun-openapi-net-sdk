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
        public static GetPipelineInstanceGroupStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPipelineInstanceGroupStatusResponse getPipelineInstanceGroupStatusResponse = new GetPipelineInstanceGroupStatusResponse();

			getPipelineInstanceGroupStatusResponse.HttpResponse = _ctx.HttpResponse;
			getPipelineInstanceGroupStatusResponse.Success = _ctx.BooleanValue("GetPipelineInstanceGroupStatus.Success");
			getPipelineInstanceGroupStatusResponse.ErrorCode = _ctx.StringValue("GetPipelineInstanceGroupStatus.ErrorCode");
			getPipelineInstanceGroupStatusResponse.ErrorMessage = _ctx.StringValue("GetPipelineInstanceGroupStatus.ErrorMessage");
			getPipelineInstanceGroupStatusResponse.RequestId = _ctx.StringValue("GetPipelineInstanceGroupStatus.RequestId");

			GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object _object = new GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object();
			_object.Status = _ctx.StringValue("GetPipelineInstanceGroupStatus.Object.Status");

			List<GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group> _object_groups = new List<GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group>();
			for (int i = 0; i < _ctx.Length("GetPipelineInstanceGroupStatus.Object.Groups.Length"); i++) {
				GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group group = new GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group();
				group.Name = _ctx.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Name");
				group.Status = _ctx.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Status");

				List<GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage> group_stages = new List<GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage>();
				for (int j = 0; j < _ctx.Length("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages.Length"); j++) {
					GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage stage = new GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage();
					stage.Status = _ctx.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages["+ j +"].Status");
					stage.Sign = _ctx.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages["+ j +"].Sign");

					List<GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage.GetPipelineInstanceGroupStatus_Component> stage_components = new List<GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage.GetPipelineInstanceGroupStatus_Component>();
					for (int k = 0; k < _ctx.Length("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages["+ j +"].Components.Length"); k++) {
						GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage.GetPipelineInstanceGroupStatus_Component component = new GetPipelineInstanceGroupStatusResponse.GetPipelineInstanceGroupStatus__Object.GetPipelineInstanceGroupStatus_Group.GetPipelineInstanceGroupStatus_Stage.GetPipelineInstanceGroupStatus_Component();
						component.Name = _ctx.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages["+ j +"].Components["+ k +"].Name");
						component.Status = _ctx.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages["+ j +"].Components["+ k +"].Status");
						component.JobId = _ctx.StringValue("GetPipelineInstanceGroupStatus.Object.Groups["+ i +"].Stages["+ j +"].Components["+ k +"].JobId");

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
