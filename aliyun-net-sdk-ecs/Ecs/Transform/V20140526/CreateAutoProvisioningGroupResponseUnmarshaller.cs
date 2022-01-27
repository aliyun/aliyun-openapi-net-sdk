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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class CreateAutoProvisioningGroupResponseUnmarshaller
    {
        public static CreateAutoProvisioningGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateAutoProvisioningGroupResponse createAutoProvisioningGroupResponse = new CreateAutoProvisioningGroupResponse();

			createAutoProvisioningGroupResponse.HttpResponse = _ctx.HttpResponse;
			createAutoProvisioningGroupResponse.AutoProvisioningGroupId = _ctx.StringValue("CreateAutoProvisioningGroup.AutoProvisioningGroupId");
			createAutoProvisioningGroupResponse.RequestId = _ctx.StringValue("CreateAutoProvisioningGroup.RequestId");

			List<CreateAutoProvisioningGroupResponse.CreateAutoProvisioningGroup_LaunchResult> createAutoProvisioningGroupResponse_launchResults = new List<CreateAutoProvisioningGroupResponse.CreateAutoProvisioningGroup_LaunchResult>();
			for (int i = 0; i < _ctx.Length("CreateAutoProvisioningGroup.LaunchResults.Length"); i++) {
				CreateAutoProvisioningGroupResponse.CreateAutoProvisioningGroup_LaunchResult launchResult = new CreateAutoProvisioningGroupResponse.CreateAutoProvisioningGroup_LaunchResult();
				launchResult.ZoneId = _ctx.StringValue("CreateAutoProvisioningGroup.LaunchResults["+ i +"].ZoneId");
				launchResult.ErrorMsg = _ctx.StringValue("CreateAutoProvisioningGroup.LaunchResults["+ i +"].ErrorMsg");
				launchResult.InstanceType = _ctx.StringValue("CreateAutoProvisioningGroup.LaunchResults["+ i +"].InstanceType");
				launchResult.ErrorCode = _ctx.StringValue("CreateAutoProvisioningGroup.LaunchResults["+ i +"].ErrorCode");
				launchResult.SpotStrategy = _ctx.StringValue("CreateAutoProvisioningGroup.LaunchResults["+ i +"].SpotStrategy");

				List<string> launchResult_instanceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("CreateAutoProvisioningGroup.LaunchResults["+ i +"].InstanceIds.Length"); j++) {
					launchResult_instanceIds.Add(_ctx.StringValue("CreateAutoProvisioningGroup.LaunchResults["+ i +"].InstanceIds["+ j +"]"));
				}
				launchResult.InstanceIds = launchResult_instanceIds;

				createAutoProvisioningGroupResponse_launchResults.Add(launchResult);
			}
			createAutoProvisioningGroupResponse.LaunchResults = createAutoProvisioningGroupResponse_launchResults;
        
			return createAutoProvisioningGroupResponse;
        }
    }
}
