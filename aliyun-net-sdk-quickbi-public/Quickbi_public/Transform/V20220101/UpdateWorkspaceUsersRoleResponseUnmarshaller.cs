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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class UpdateWorkspaceUsersRoleResponseUnmarshaller
    {
        public static UpdateWorkspaceUsersRoleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateWorkspaceUsersRoleResponse updateWorkspaceUsersRoleResponse = new UpdateWorkspaceUsersRoleResponse();

			updateWorkspaceUsersRoleResponse.HttpResponse = _ctx.HttpResponse;
			updateWorkspaceUsersRoleResponse.RequestId = _ctx.StringValue("UpdateWorkspaceUsersRole.RequestId");
			updateWorkspaceUsersRoleResponse.Success = _ctx.BooleanValue("UpdateWorkspaceUsersRole.Success");

			UpdateWorkspaceUsersRoleResponse.UpdateWorkspaceUsersRole_Result result = new UpdateWorkspaceUsersRoleResponse.UpdateWorkspaceUsersRole_Result();
			result.Failure = _ctx.IntegerValue("UpdateWorkspaceUsersRole.Result.Failure");
			result.FailureDetail = _ctx.StringValue("UpdateWorkspaceUsersRole.Result.FailureDetail");
			result.Success = _ctx.IntegerValue("UpdateWorkspaceUsersRole.Result.Success");
			result.Total = _ctx.IntegerValue("UpdateWorkspaceUsersRole.Result.Total");
			updateWorkspaceUsersRoleResponse.Result = result;
        
			return updateWorkspaceUsersRoleResponse;
        }
    }
}
