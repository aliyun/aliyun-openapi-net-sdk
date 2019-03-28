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
        public static DetachInstanceRamRoleResponse Unmarshall(UnmarshallerContext context)
        {
			DetachInstanceRamRoleResponse detachInstanceRamRoleResponse = new DetachInstanceRamRoleResponse();

			detachInstanceRamRoleResponse.HttpResponse = context.HttpResponse;
			detachInstanceRamRoleResponse.RequestId = context.StringValue("DetachInstanceRamRole.RequestId");
			detachInstanceRamRoleResponse.TotalCount = context.IntegerValue("DetachInstanceRamRole.TotalCount");
			detachInstanceRamRoleResponse.FailCount = context.IntegerValue("DetachInstanceRamRole.FailCount");
			detachInstanceRamRoleResponse.RamRoleName = context.StringValue("DetachInstanceRamRole.RamRoleName");

			List<DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult> detachInstanceRamRoleResponse_detachInstanceRamRoleResults = new List<DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult>();
			for (int i = 0; i < context.Length("DetachInstanceRamRole.DetachInstanceRamRoleResults.Length"); i++) {
				DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult detachInstanceRamRoleResult = new DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult();
				detachInstanceRamRoleResult.InstanceId = context.StringValue("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].InstanceId");
				detachInstanceRamRoleResult.Success = context.BooleanValue("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].Success");
				detachInstanceRamRoleResult.Code = context.StringValue("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].Code");
				detachInstanceRamRoleResult.Message = context.StringValue("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].Message");

				List<DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult.DetachInstanceRamRole_InstanceRamRoleSet> detachInstanceRamRoleResult_instanceRamRoleSets = new List<DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult.DetachInstanceRamRole_InstanceRamRoleSet>();
				for (int j = 0; j < context.Length("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].InstanceRamRoleSets.Length"); j++) {
					DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult.DetachInstanceRamRole_InstanceRamRoleSet instanceRamRoleSet = new DetachInstanceRamRoleResponse.DetachInstanceRamRole_DetachInstanceRamRoleResult.DetachInstanceRamRole_InstanceRamRoleSet();
					instanceRamRoleSet.InstanceId = context.StringValue("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].InstanceRamRoleSets["+ j +"].InstanceId");
					instanceRamRoleSet.RamRoleName = context.StringValue("DetachInstanceRamRole.DetachInstanceRamRoleResults["+ i +"].InstanceRamRoleSets["+ j +"].RamRoleName");

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
