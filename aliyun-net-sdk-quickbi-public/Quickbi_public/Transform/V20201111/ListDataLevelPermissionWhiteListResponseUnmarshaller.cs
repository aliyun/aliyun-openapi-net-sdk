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
using Aliyun.Acs.quickbi_public.Model.V20201111;

namespace Aliyun.Acs.quickbi_public.Transform.V20201111
{
    public class ListDataLevelPermissionWhiteListResponseUnmarshaller
    {
        public static ListDataLevelPermissionWhiteListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataLevelPermissionWhiteListResponse listDataLevelPermissionWhiteListResponse = new ListDataLevelPermissionWhiteListResponse();

			listDataLevelPermissionWhiteListResponse.HttpResponse = _ctx.HttpResponse;
			listDataLevelPermissionWhiteListResponse.Success = _ctx.BooleanValue("ListDataLevelPermissionWhiteList.Success");
			listDataLevelPermissionWhiteListResponse.RequestId = _ctx.StringValue("ListDataLevelPermissionWhiteList.RequestId");

			ListDataLevelPermissionWhiteListResponse.ListDataLevelPermissionWhiteList_Result result = new ListDataLevelPermissionWhiteListResponse.ListDataLevelPermissionWhiteList_Result();
			result.CubeId = _ctx.StringValue("ListDataLevelPermissionWhiteList.Result.CubeId");
			result.RuleType = _ctx.StringValue("ListDataLevelPermissionWhiteList.Result.RuleType");

			ListDataLevelPermissionWhiteListResponse.ListDataLevelPermissionWhiteList_Result.ListDataLevelPermissionWhiteList_UsersModel usersModel = new ListDataLevelPermissionWhiteListResponse.ListDataLevelPermissionWhiteList_Result.ListDataLevelPermissionWhiteList_UsersModel();

			List<string> usersModel_userGroups = new List<string>();
			for (int i = 0; i < _ctx.Length("ListDataLevelPermissionWhiteList.Result.UsersModel.UserGroups.Length"); i++) {
				usersModel_userGroups.Add(_ctx.StringValue("ListDataLevelPermissionWhiteList.Result.UsersModel.UserGroups["+ i +"]"));
			}
			usersModel.UserGroups = usersModel_userGroups;

			List<string> usersModel_users = new List<string>();
			for (int i = 0; i < _ctx.Length("ListDataLevelPermissionWhiteList.Result.UsersModel.Users.Length"); i++) {
				usersModel_users.Add(_ctx.StringValue("ListDataLevelPermissionWhiteList.Result.UsersModel.Users["+ i +"]"));
			}
			usersModel.Users = usersModel_users;
			result.UsersModel = usersModel;
			listDataLevelPermissionWhiteListResponse.Result = result;
        
			return listDataLevelPermissionWhiteListResponse;
        }
    }
}
