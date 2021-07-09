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
    public class GetPipleineLatestInstanceStatusResponseUnmarshaller
    {
        public static GetPipleineLatestInstanceStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPipleineLatestInstanceStatusResponse getPipleineLatestInstanceStatusResponse = new GetPipleineLatestInstanceStatusResponse();

			getPipleineLatestInstanceStatusResponse.HttpResponse = _ctx.HttpResponse;
			getPipleineLatestInstanceStatusResponse.RequestId = _ctx.StringValue("GetPipleineLatestInstanceStatus.RequestId");
			getPipleineLatestInstanceStatusResponse.ErrorMessage = _ctx.StringValue("GetPipleineLatestInstanceStatus.ErrorMessage");
			getPipleineLatestInstanceStatusResponse.Success = _ctx.BooleanValue("GetPipleineLatestInstanceStatus.Success");
			getPipleineLatestInstanceStatusResponse.ErrorCode = _ctx.StringValue("GetPipleineLatestInstanceStatus.ErrorCode");

			GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object _object = new GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object();
			_object.Status = _ctx.StringValue("GetPipleineLatestInstanceStatus.Object.Status");

			List<GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object.GetPipleineLatestInstanceStatus_Group> _object_groups = new List<GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object.GetPipleineLatestInstanceStatus_Group>();
			for (int i = 0; i < _ctx.Length("GetPipleineLatestInstanceStatus.Object.Groups.Length"); i++) {
				GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object.GetPipleineLatestInstanceStatus_Group group = new GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object.GetPipleineLatestInstanceStatus_Group();
				group.Status = _ctx.StringValue("GetPipleineLatestInstanceStatus.Object.Groups["+ i +"].Status");
				group.Name = _ctx.StringValue("GetPipleineLatestInstanceStatus.Object.Groups["+ i +"].Name");

				List<GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object.GetPipleineLatestInstanceStatus_Group.GetPipleineLatestInstanceStatus_Stage> group_stages = new List<GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object.GetPipleineLatestInstanceStatus_Group.GetPipleineLatestInstanceStatus_Stage>();
				for (int j = 0; j < _ctx.Length("GetPipleineLatestInstanceStatus.Object.Groups["+ i +"].Stages.Length"); j++) {
					GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object.GetPipleineLatestInstanceStatus_Group.GetPipleineLatestInstanceStatus_Stage stage = new GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object.GetPipleineLatestInstanceStatus_Group.GetPipleineLatestInstanceStatus_Stage();
					stage.Status = _ctx.StringValue("GetPipleineLatestInstanceStatus.Object.Groups["+ i +"].Stages["+ j +"].Status");
					stage.Sign = _ctx.StringValue("GetPipleineLatestInstanceStatus.Object.Groups["+ i +"].Stages["+ j +"].Sign");

					List<GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object.GetPipleineLatestInstanceStatus_Group.GetPipleineLatestInstanceStatus_Stage.GetPipleineLatestInstanceStatus_Component> stage_components = new List<GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object.GetPipleineLatestInstanceStatus_Group.GetPipleineLatestInstanceStatus_Stage.GetPipleineLatestInstanceStatus_Component>();
					for (int k = 0; k < _ctx.Length("GetPipleineLatestInstanceStatus.Object.Groups["+ i +"].Stages["+ j +"].Components.Length"); k++) {
						GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object.GetPipleineLatestInstanceStatus_Group.GetPipleineLatestInstanceStatus_Stage.GetPipleineLatestInstanceStatus_Component component = new GetPipleineLatestInstanceStatusResponse.GetPipleineLatestInstanceStatus__Object.GetPipleineLatestInstanceStatus_Group.GetPipleineLatestInstanceStatus_Stage.GetPipleineLatestInstanceStatus_Component();
						component.Status = _ctx.StringValue("GetPipleineLatestInstanceStatus.Object.Groups["+ i +"].Stages["+ j +"].Components["+ k +"].Status");
						component.Name = _ctx.StringValue("GetPipleineLatestInstanceStatus.Object.Groups["+ i +"].Stages["+ j +"].Components["+ k +"].Name");
						component.JobId = _ctx.LongValue("GetPipleineLatestInstanceStatus.Object.Groups["+ i +"].Stages["+ j +"].Components["+ k +"].JobId");

						stage_components.Add(component);
					}
					stage.Components = stage_components;

					group_stages.Add(stage);
				}
				group.Stages = group_stages;

				_object_groups.Add(group);
			}
			_object.Groups = _object_groups;
			getPipleineLatestInstanceStatusResponse._Object = _object;
        
			return getPipleineLatestInstanceStatusResponse;
        }
    }
}
