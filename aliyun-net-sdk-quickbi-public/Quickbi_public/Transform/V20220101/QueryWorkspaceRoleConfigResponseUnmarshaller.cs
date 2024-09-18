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
    public class QueryWorkspaceRoleConfigResponseUnmarshaller
    {
        public static QueryWorkspaceRoleConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryWorkspaceRoleConfigResponse queryWorkspaceRoleConfigResponse = new QueryWorkspaceRoleConfigResponse();

			queryWorkspaceRoleConfigResponse.HttpResponse = _ctx.HttpResponse;
			queryWorkspaceRoleConfigResponse.RequestId = _ctx.StringValue("QueryWorkspaceRoleConfig.RequestId");
			queryWorkspaceRoleConfigResponse.Success = _ctx.BooleanValue("QueryWorkspaceRoleConfig.Success");

			QueryWorkspaceRoleConfigResponse.QueryWorkspaceRoleConfig_Result result = new QueryWorkspaceRoleConfigResponse.QueryWorkspaceRoleConfig_Result();
			result.IsSystemRole = _ctx.BooleanValue("QueryWorkspaceRoleConfig.Result.IsSystemRole");
			result.RoleId = _ctx.LongValue("QueryWorkspaceRoleConfig.Result.RoleId");
			result.RoleName = _ctx.StringValue("QueryWorkspaceRoleConfig.Result.RoleName");

			List<QueryWorkspaceRoleConfigResponse.QueryWorkspaceRoleConfig_Result.QueryWorkspaceRoleConfig_AuthConfigListItem> result_authConfigList = new List<QueryWorkspaceRoleConfigResponse.QueryWorkspaceRoleConfig_Result.QueryWorkspaceRoleConfig_AuthConfigListItem>();
			for (int i = 0; i < _ctx.Length("QueryWorkspaceRoleConfig.Result.AuthConfigList.Length"); i++) {
				QueryWorkspaceRoleConfigResponse.QueryWorkspaceRoleConfig_Result.QueryWorkspaceRoleConfig_AuthConfigListItem authConfigListItem = new QueryWorkspaceRoleConfigResponse.QueryWorkspaceRoleConfig_Result.QueryWorkspaceRoleConfig_AuthConfigListItem();
				authConfigListItem.AuthKey = _ctx.StringValue("QueryWorkspaceRoleConfig.Result.AuthConfigList["+ i +"].AuthKey");

				List<string> authConfigListItem_actionAuthKeys = new List<string>();
				for (int j = 0; j < _ctx.Length("QueryWorkspaceRoleConfig.Result.AuthConfigList["+ i +"].ActionAuthKeys.Length"); j++) {
					authConfigListItem_actionAuthKeys.Add(_ctx.StringValue("QueryWorkspaceRoleConfig.Result.AuthConfigList["+ i +"].ActionAuthKeys["+ j +"]"));
				}
				authConfigListItem.ActionAuthKeys = authConfigListItem_actionAuthKeys;

				result_authConfigList.Add(authConfigListItem);
			}
			result.AuthConfigList = result_authConfigList;
			queryWorkspaceRoleConfigResponse.Result = result;
        
			return queryWorkspaceRoleConfigResponse;
        }
    }
}
