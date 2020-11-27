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
    public class GetPipelineInstanceBuildNumberStatusResponseUnmarshaller
    {
        public static GetPipelineInstanceBuildNumberStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPipelineInstanceBuildNumberStatusResponse getPipelineInstanceBuildNumberStatusResponse = new GetPipelineInstanceBuildNumberStatusResponse();

			getPipelineInstanceBuildNumberStatusResponse.HttpResponse = _ctx.HttpResponse;
			getPipelineInstanceBuildNumberStatusResponse.Success = _ctx.BooleanValue("GetPipelineInstanceBuildNumberStatus.Success");
			getPipelineInstanceBuildNumberStatusResponse.ErrorCode = _ctx.StringValue("GetPipelineInstanceBuildNumberStatus.ErrorCode");
			getPipelineInstanceBuildNumberStatusResponse.ErrorMessage = _ctx.StringValue("GetPipelineInstanceBuildNumberStatus.ErrorMessage");
			getPipelineInstanceBuildNumberStatusResponse.RequestId = _ctx.StringValue("GetPipelineInstanceBuildNumberStatus.RequestId");

			GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object _object = new GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object();
			_object.Status = _ctx.StringValue("GetPipelineInstanceBuildNumberStatus.Object.Status");

			List<GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object.GetPipelineInstanceBuildNumberStatus_Group> _object_groups = new List<GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object.GetPipelineInstanceBuildNumberStatus_Group>();
			for (int i = 0; i < _ctx.Length("GetPipelineInstanceBuildNumberStatus.Object.Groups.Length"); i++) {
				GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object.GetPipelineInstanceBuildNumberStatus_Group group = new GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object.GetPipelineInstanceBuildNumberStatus_Group();
				group.Name = _ctx.StringValue("GetPipelineInstanceBuildNumberStatus.Object.Groups["+ i +"].Name");
				group.Status = _ctx.StringValue("GetPipelineInstanceBuildNumberStatus.Object.Groups["+ i +"].Status");

				List<GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object.GetPipelineInstanceBuildNumberStatus_Group.GetPipelineInstanceBuildNumberStatus_Stage> group_stages = new List<GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object.GetPipelineInstanceBuildNumberStatus_Group.GetPipelineInstanceBuildNumberStatus_Stage>();
				for (int j = 0; j < _ctx.Length("GetPipelineInstanceBuildNumberStatus.Object.Groups["+ i +"].Stages.Length"); j++) {
					GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object.GetPipelineInstanceBuildNumberStatus_Group.GetPipelineInstanceBuildNumberStatus_Stage stage = new GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object.GetPipelineInstanceBuildNumberStatus_Group.GetPipelineInstanceBuildNumberStatus_Stage();
					stage.Status = _ctx.StringValue("GetPipelineInstanceBuildNumberStatus.Object.Groups["+ i +"].Stages["+ j +"].Status");
					stage.Sign = _ctx.StringValue("GetPipelineInstanceBuildNumberStatus.Object.Groups["+ i +"].Stages["+ j +"].Sign");

					List<GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object.GetPipelineInstanceBuildNumberStatus_Group.GetPipelineInstanceBuildNumberStatus_Stage.GetPipelineInstanceBuildNumberStatus_Component> stage_components = new List<GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object.GetPipelineInstanceBuildNumberStatus_Group.GetPipelineInstanceBuildNumberStatus_Stage.GetPipelineInstanceBuildNumberStatus_Component>();
					for (int k = 0; k < _ctx.Length("GetPipelineInstanceBuildNumberStatus.Object.Groups["+ i +"].Stages["+ j +"].Components.Length"); k++) {
						GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object.GetPipelineInstanceBuildNumberStatus_Group.GetPipelineInstanceBuildNumberStatus_Stage.GetPipelineInstanceBuildNumberStatus_Component component = new GetPipelineInstanceBuildNumberStatusResponse.GetPipelineInstanceBuildNumberStatus__Object.GetPipelineInstanceBuildNumberStatus_Group.GetPipelineInstanceBuildNumberStatus_Stage.GetPipelineInstanceBuildNumberStatus_Component();
						component.Name = _ctx.StringValue("GetPipelineInstanceBuildNumberStatus.Object.Groups["+ i +"].Stages["+ j +"].Components["+ k +"].Name");
						component.Status = _ctx.StringValue("GetPipelineInstanceBuildNumberStatus.Object.Groups["+ i +"].Stages["+ j +"].Components["+ k +"].Status");
						component.JobId = _ctx.LongValue("GetPipelineInstanceBuildNumberStatus.Object.Groups["+ i +"].Stages["+ j +"].Components["+ k +"].JobId");

						stage_components.Add(component);
					}
					stage.Components = stage_components;

					group_stages.Add(stage);
				}
				group.Stages = group_stages;

				_object_groups.Add(group);
			}
			_object.Groups = _object_groups;
			getPipelineInstanceBuildNumberStatusResponse._Object = _object;
        
			return getPipelineInstanceBuildNumberStatusResponse;
        }
    }
}
