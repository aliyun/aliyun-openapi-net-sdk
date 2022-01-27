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
using Aliyun.Acs.quickbi_public.Model.V20200803;

namespace Aliyun.Acs.quickbi_public.Transform.V20200803
{
    public class QueryUserRoleInfoInWorkspaceResponseUnmarshaller
    {
        public static QueryUserRoleInfoInWorkspaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryUserRoleInfoInWorkspaceResponse queryUserRoleInfoInWorkspaceResponse = new QueryUserRoleInfoInWorkspaceResponse();

			queryUserRoleInfoInWorkspaceResponse.HttpResponse = _ctx.HttpResponse;
			queryUserRoleInfoInWorkspaceResponse.RequestId = _ctx.StringValue("QueryUserRoleInfoInWorkspace.RequestId");
			queryUserRoleInfoInWorkspaceResponse.Success = _ctx.BooleanValue("QueryUserRoleInfoInWorkspace.Success");

			QueryUserRoleInfoInWorkspaceResponse.QueryUserRoleInfoInWorkspace_Result result = new QueryUserRoleInfoInWorkspaceResponse.QueryUserRoleInfoInWorkspace_Result();
			result.RoleId = _ctx.LongValue("QueryUserRoleInfoInWorkspace.Result.RoleId");
			result.RoleCode = _ctx.StringValue("QueryUserRoleInfoInWorkspace.Result.RoleCode");
			result.RoleName = _ctx.StringValue("QueryUserRoleInfoInWorkspace.Result.RoleName");
			queryUserRoleInfoInWorkspaceResponse.Result = result;
        
			return queryUserRoleInfoInWorkspaceResponse;
        }
    }
}
