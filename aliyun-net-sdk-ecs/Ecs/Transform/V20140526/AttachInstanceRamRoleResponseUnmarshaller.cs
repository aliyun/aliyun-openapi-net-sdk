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
    public class AttachInstanceRamRoleResponseUnmarshaller
    {
        public static AttachInstanceRamRoleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AttachInstanceRamRoleResponse attachInstanceRamRoleResponse = new AttachInstanceRamRoleResponse();

			attachInstanceRamRoleResponse.HttpResponse = _ctx.HttpResponse;
			attachInstanceRamRoleResponse.RequestId = _ctx.StringValue("AttachInstanceRamRole.RequestId");
			attachInstanceRamRoleResponse.TotalCount = _ctx.IntegerValue("AttachInstanceRamRole.TotalCount");
			attachInstanceRamRoleResponse.FailCount = _ctx.IntegerValue("AttachInstanceRamRole.FailCount");
			attachInstanceRamRoleResponse.RamRoleName = _ctx.StringValue("AttachInstanceRamRole.RamRoleName");

			List<AttachInstanceRamRoleResponse.AttachInstanceRamRole_AttachInstanceRamRoleResult> attachInstanceRamRoleResponse_attachInstanceRamRoleResults = new List<AttachInstanceRamRoleResponse.AttachInstanceRamRole_AttachInstanceRamRoleResult>();
			for (int i = 0; i < _ctx.Length("AttachInstanceRamRole.AttachInstanceRamRoleResults.Length"); i++) {
				AttachInstanceRamRoleResponse.AttachInstanceRamRole_AttachInstanceRamRoleResult attachInstanceRamRoleResult = new AttachInstanceRamRoleResponse.AttachInstanceRamRole_AttachInstanceRamRoleResult();
				attachInstanceRamRoleResult.InstanceId = _ctx.StringValue("AttachInstanceRamRole.AttachInstanceRamRoleResults["+ i +"].InstanceId");
				attachInstanceRamRoleResult.Success = _ctx.BooleanValue("AttachInstanceRamRole.AttachInstanceRamRoleResults["+ i +"].Success");
				attachInstanceRamRoleResult.Code = _ctx.StringValue("AttachInstanceRamRole.AttachInstanceRamRoleResults["+ i +"].Code");
				attachInstanceRamRoleResult.Message = _ctx.StringValue("AttachInstanceRamRole.AttachInstanceRamRoleResults["+ i +"].Message");

				attachInstanceRamRoleResponse_attachInstanceRamRoleResults.Add(attachInstanceRamRoleResult);
			}
			attachInstanceRamRoleResponse.AttachInstanceRamRoleResults = attachInstanceRamRoleResponse_attachInstanceRamRoleResults;
        
			return attachInstanceRamRoleResponse;
        }
    }
}
