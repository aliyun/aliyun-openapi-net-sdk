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
    public class ListWorkspaceUserRolesByUserIdResponseUnmarshaller
    {
        public static ListWorkspaceUserRolesByUserIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListWorkspaceUserRolesByUserIdResponse listWorkspaceUserRolesByUserIdResponse = new ListWorkspaceUserRolesByUserIdResponse();

			listWorkspaceUserRolesByUserIdResponse.HttpResponse = _ctx.HttpResponse;
			listWorkspaceUserRolesByUserIdResponse.RequestId = _ctx.StringValue("ListWorkspaceUserRolesByUserId.RequestId");
			listWorkspaceUserRolesByUserIdResponse.Success = _ctx.BooleanValue("ListWorkspaceUserRolesByUserId.Success");

			List<ListWorkspaceUserRolesByUserIdResponse.ListWorkspaceUserRolesByUserId_Data> listWorkspaceUserRolesByUserIdResponse_result = new List<ListWorkspaceUserRolesByUserIdResponse.ListWorkspaceUserRolesByUserId_Data>();
			for (int i = 0; i < _ctx.Length("ListWorkspaceUserRolesByUserId.Result.Length"); i++) {
				ListWorkspaceUserRolesByUserIdResponse.ListWorkspaceUserRolesByUserId_Data data = new ListWorkspaceUserRolesByUserIdResponse.ListWorkspaceUserRolesByUserId_Data();
				data.WorkspaceId = _ctx.StringValue("ListWorkspaceUserRolesByUserId.Result["+ i +"].WorkspaceId");
				data.WorkspaceName = _ctx.StringValue("ListWorkspaceUserRolesByUserId.Result["+ i +"].WorkspaceName");

				ListWorkspaceUserRolesByUserIdResponse.ListWorkspaceUserRolesByUserId_Data.ListWorkspaceUserRolesByUserId_RoleModel roleModel = new ListWorkspaceUserRolesByUserIdResponse.ListWorkspaceUserRolesByUserId_Data.ListWorkspaceUserRolesByUserId_RoleModel();
				roleModel.RoleId = _ctx.StringValue("ListWorkspaceUserRolesByUserId.Result["+ i +"].RoleModel.RoleId");
				roleModel.RoleCode = _ctx.StringValue("ListWorkspaceUserRolesByUserId.Result["+ i +"].RoleModel.RoleCode");
				roleModel.RoleName = _ctx.StringValue("ListWorkspaceUserRolesByUserId.Result["+ i +"].RoleModel.RoleName");
				data.RoleModel = roleModel;

				listWorkspaceUserRolesByUserIdResponse_result.Add(data);
			}
			listWorkspaceUserRolesByUserIdResponse.Result = listWorkspaceUserRolesByUserIdResponse_result;
        
			return listWorkspaceUserRolesByUserIdResponse;
        }
    }
}
