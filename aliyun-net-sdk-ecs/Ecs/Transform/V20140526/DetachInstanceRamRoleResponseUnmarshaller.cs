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
    public class DetachInstanceRamRoleResponseUnmarshaller
    {
        public static DetachInstanceRamRoleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetachInstanceRamRoleResponse detachInstanceRamRoleResponse = new DetachInstanceRamRoleResponse();

			detachInstanceRamRoleResponse.HttpResponse = _ctx.HttpResponse;
			detachInstanceRamRoleResponse.RamRoleName = _ctx.StringValue("DetachInstanceRamRole.RamRoleName");
			detachInstanceRamRoleResponse.RequestId = _ctx.StringValue("DetachInstanceRamRole.RequestId");
			detachInstanceRamRoleResponse.TotalCount = _ctx.IntegerValue("DetachInstanceRamRole.TotalCount");
			detachInstanceRamRoleResponse.FailCount = _ctx.IntegerValue("DetachInstanceRamRole.FailCount");

			List<DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult> detachInstanceRamRoleResponse_detachInstanceRamRoleResults = new List<DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult>();
			for (int i = 0; i < _ctx.Length("DetachInstanceRamRole.DetachInstanceRamRoleResults.Length"); i++) {
				DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult detachInstanceRamRoleResult = new DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult();
				detachInstanceRamRoleResult.Code = _ctx.StringValue("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].Code");
				detachInstanceRamRoleResult.Message = _ctx.StringValue("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].Message");
				detachInstanceRamRoleResult.InstanceId = _ctx.StringValue("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].InstanceId");
				detachInstanceRamRoleResult.Success = _ctx.BooleanValue("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].Success");

				List<DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult.DetachInstanceRamRole_InstanceRamRoleSet> detachInstanceRamRoleResult_instanceRamRoleSets = new List<DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult.DetachInstanceRamRole_InstanceRamRoleSet>();
				for (int j = 0; j < _ctx.Length("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].InstanceRamRoleSets.Length"); j++) {
					DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult.DetachInstanceRamRole_InstanceRamRoleSet instanceRamRoleSet = new DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult.DetachInstanceRamRole_InstanceRamRoleSet();
					instanceRamRoleSet.RamRoleName = _ctx.StringValue("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].InstanceRamRoleSets["+ j +"].RamRoleName");
					instanceRamRoleSet.InstanceId = _ctx.StringValue("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].InstanceRamRoleSets["+ j +"].InstanceId");

					detachInstanceRamRoleResult_instanceRamRoleSets.Add(instanceRamRoleSet);
				}
				detachInstanceRamRoleResult.InstanceRamRoleSets = detachInstanceRamRoleResult_instanceRamRoleSets;

				detachInstanceRamRoleResponse_detachInstanceRamRoleResults.Add(detachInstanceRamRoleResult);
			}
			detachInstanceRamRoleResponse.DetachInstanceRamRoleResults = detachInstanceRamRoleResponse_detachInstanceRamRoleResults;
        
			return detachInstanceRamRoleResponse;
        }
    }
}
