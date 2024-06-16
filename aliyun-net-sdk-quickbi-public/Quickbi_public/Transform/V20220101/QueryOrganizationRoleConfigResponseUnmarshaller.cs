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
    public class QueryOrganizationRoleConfigResponseUnmarshaller
    {
        public static QueryOrganizationRoleConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryOrganizationRoleConfigResponse queryOrganizationRoleConfigResponse = new QueryOrganizationRoleConfigResponse();

			queryOrganizationRoleConfigResponse.HttpResponse = _ctx.HttpResponse;
			queryOrganizationRoleConfigResponse.RequestId = _ctx.StringValue("QueryOrganizationRoleConfig.RequestId");
			queryOrganizationRoleConfigResponse.Success = _ctx.BooleanValue("QueryOrganizationRoleConfig.Success");

			QueryOrganizationRoleConfigResponse.QueryOrganizationRoleConfig_Result result = new QueryOrganizationRoleConfigResponse.QueryOrganizationRoleConfig_Result();
			result.RoleId = _ctx.LongValue("QueryOrganizationRoleConfig.Result.RoleId");
			result.RoleName = _ctx.StringValue("QueryOrganizationRoleConfig.Result.RoleName");
			result.IsSystemRole = _ctx.BooleanValue("QueryOrganizationRoleConfig.Result.IsSystemRole");

			List<QueryOrganizationRoleConfigResponse.QueryOrganizationRoleConfig_Result.QueryOrganizationRoleConfig_AuthConfigListItem> result_authConfigList = new List<QueryOrganizationRoleConfigResponse.QueryOrganizationRoleConfig_Result.QueryOrganizationRoleConfig_AuthConfigListItem>();
			for (int i = 0; i < _ctx.Length("QueryOrganizationRoleConfig.Result.AuthConfigList.Length"); i++) {
				QueryOrganizationRoleConfigResponse.QueryOrganizationRoleConfig_Result.QueryOrganizationRoleConfig_AuthConfigListItem authConfigListItem = new QueryOrganizationRoleConfigResponse.QueryOrganizationRoleConfig_Result.QueryOrganizationRoleConfig_AuthConfigListItem();
				authConfigListItem.AuthKey = _ctx.StringValue("QueryOrganizationRoleConfig.Result.AuthConfigList["+ i +"].AuthKey");

				result_authConfigList.Add(authConfigListItem);
			}
			result.AuthConfigList = result_authConfigList;
			queryOrganizationRoleConfigResponse.Result = result;
        
			return queryOrganizationRoleConfigResponse;
        }
    }
}
