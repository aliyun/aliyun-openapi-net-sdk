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
    public class ListWorkspaceRoleUsersResponseUnmarshaller
    {
        public static ListWorkspaceRoleUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListWorkspaceRoleUsersResponse listWorkspaceRoleUsersResponse = new ListWorkspaceRoleUsersResponse();

			listWorkspaceRoleUsersResponse.HttpResponse = _ctx.HttpResponse;
			listWorkspaceRoleUsersResponse.RequestId = _ctx.StringValue("ListWorkspaceRoleUsers.RequestId");
			listWorkspaceRoleUsersResponse.Success = _ctx.BooleanValue("ListWorkspaceRoleUsers.Success");

			ListWorkspaceRoleUsersResponse.ListWorkspaceRoleUsers_Result result = new ListWorkspaceRoleUsersResponse.ListWorkspaceRoleUsers_Result();
			result.PageNum = _ctx.IntegerValue("ListWorkspaceRoleUsers.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("ListWorkspaceRoleUsers.Result.PageSize");
			result.TotalNum = _ctx.IntegerValue("ListWorkspaceRoleUsers.Result.TotalNum");
			result.TotalPages = _ctx.IntegerValue("ListWorkspaceRoleUsers.Result.TotalPages");

			List<ListWorkspaceRoleUsersResponse.ListWorkspaceRoleUsers_Result.ListWorkspaceRoleUsers_DataItem> result_data = new List<ListWorkspaceRoleUsersResponse.ListWorkspaceRoleUsers_Result.ListWorkspaceRoleUsers_DataItem>();
			for (int i = 0; i < _ctx.Length("ListWorkspaceRoleUsers.Result.Data.Length"); i++) {
				ListWorkspaceRoleUsersResponse.ListWorkspaceRoleUsers_Result.ListWorkspaceRoleUsers_DataItem dataItem = new ListWorkspaceRoleUsersResponse.ListWorkspaceRoleUsers_Result.ListWorkspaceRoleUsers_DataItem();
				dataItem.NickName = _ctx.StringValue("ListWorkspaceRoleUsers.Result.Data["+ i +"].NickName");
				dataItem.UserId = _ctx.StringValue("ListWorkspaceRoleUsers.Result.Data["+ i +"].UserId");
				dataItem.WorkspaceId = _ctx.StringValue("ListWorkspaceRoleUsers.Result.Data["+ i +"].WorkspaceId");
				dataItem.WorkspaceName = _ctx.StringValue("ListWorkspaceRoleUsers.Result.Data["+ i +"].WorkspaceName");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			listWorkspaceRoleUsersResponse.Result = result;
        
			return listWorkspaceRoleUsersResponse;
        }
    }
}
