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
    public class QueryWorkspaceUserListResponseUnmarshaller
    {
        public static QueryWorkspaceUserListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryWorkspaceUserListResponse queryWorkspaceUserListResponse = new QueryWorkspaceUserListResponse();

			queryWorkspaceUserListResponse.HttpResponse = _ctx.HttpResponse;
			queryWorkspaceUserListResponse.RequestId = _ctx.StringValue("QueryWorkspaceUserList.RequestId");
			queryWorkspaceUserListResponse.Success = _ctx.BooleanValue("QueryWorkspaceUserList.Success");

			QueryWorkspaceUserListResponse.QueryWorkspaceUserList_Result result = new QueryWorkspaceUserListResponse.QueryWorkspaceUserList_Result();
			result.TotalNum = _ctx.IntegerValue("QueryWorkspaceUserList.Result.TotalNum");
			result.TotalPages = _ctx.IntegerValue("QueryWorkspaceUserList.Result.TotalPages");
			result.PageSize = _ctx.IntegerValue("QueryWorkspaceUserList.Result.PageSize");
			result.PageNum = _ctx.IntegerValue("QueryWorkspaceUserList.Result.PageNum");

			List<QueryWorkspaceUserListResponse.QueryWorkspaceUserList_Result.QueryWorkspaceUserList_DataItem> result_data = new List<QueryWorkspaceUserListResponse.QueryWorkspaceUserList_Result.QueryWorkspaceUserList_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryWorkspaceUserList.Result.Data.Length"); i++) {
				QueryWorkspaceUserListResponse.QueryWorkspaceUserList_Result.QueryWorkspaceUserList_DataItem dataItem = new QueryWorkspaceUserListResponse.QueryWorkspaceUserList_Result.QueryWorkspaceUserList_DataItem();
				dataItem.UserId = _ctx.StringValue("QueryWorkspaceUserList.Result.Data["+ i +"].UserId");
				dataItem.AccountName = _ctx.StringValue("QueryWorkspaceUserList.Result.Data["+ i +"].AccountName");
				dataItem.Phone = _ctx.StringValue("QueryWorkspaceUserList.Result.Data["+ i +"].Phone");
				dataItem.NickName = _ctx.StringValue("QueryWorkspaceUserList.Result.Data["+ i +"].NickName");
				dataItem.Email = _ctx.StringValue("QueryWorkspaceUserList.Result.Data["+ i +"].Email");
				dataItem.AccountId = _ctx.StringValue("QueryWorkspaceUserList.Result.Data["+ i +"].AccountId");

				QueryWorkspaceUserListResponse.QueryWorkspaceUserList_Result.QueryWorkspaceUserList_DataItem.QueryWorkspaceUserList_Role role = new QueryWorkspaceUserListResponse.QueryWorkspaceUserList_Result.QueryWorkspaceUserList_DataItem.QueryWorkspaceUserList_Role();
				role.RoleName = _ctx.StringValue("QueryWorkspaceUserList.Result.Data["+ i +"].Role.RoleName");
				role.RoleId = _ctx.LongValue("QueryWorkspaceUserList.Result.Data["+ i +"].Role.RoleId");
				role.RoleCode = _ctx.StringValue("QueryWorkspaceUserList.Result.Data["+ i +"].Role.RoleCode");
				dataItem.Role = role;

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			queryWorkspaceUserListResponse.Result = result;
        
			return queryWorkspaceUserListResponse;
        }
    }
}
