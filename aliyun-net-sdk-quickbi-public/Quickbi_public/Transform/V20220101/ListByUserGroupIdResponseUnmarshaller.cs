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
    public class ListByUserGroupIdResponseUnmarshaller
    {
        public static ListByUserGroupIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListByUserGroupIdResponse listByUserGroupIdResponse = new ListByUserGroupIdResponse();

			listByUserGroupIdResponse.HttpResponse = _ctx.HttpResponse;
			listByUserGroupIdResponse.RequestId = _ctx.StringValue("ListByUserGroupId.RequestId");
			listByUserGroupIdResponse.Success = _ctx.BooleanValue("ListByUserGroupId.Success");

			ListByUserGroupIdResponse.ListByUserGroupId_Result result = new ListByUserGroupIdResponse.ListByUserGroupId_Result();

			List<string> result_failedUserGroupIds = new List<string>();
			for (int i = 0; i < _ctx.Length("ListByUserGroupId.Result.FailedUserGroupIds.Length"); i++) {
				result_failedUserGroupIds.Add(_ctx.StringValue("ListByUserGroupId.Result.FailedUserGroupIds["+ i +"]"));
			}
			result.FailedUserGroupIds = result_failedUserGroupIds;

			List<ListByUserGroupIdResponse.ListByUserGroupId_Result.ListByUserGroupId_UserGroupModelsItem> result_userGroupModels = new List<ListByUserGroupIdResponse.ListByUserGroupId_Result.ListByUserGroupId_UserGroupModelsItem>();
			for (int i = 0; i < _ctx.Length("ListByUserGroupId.Result.UserGroupModels.Length"); i++) {
				ListByUserGroupIdResponse.ListByUserGroupId_Result.ListByUserGroupId_UserGroupModelsItem userGroupModelsItem = new ListByUserGroupIdResponse.ListByUserGroupId_Result.ListByUserGroupId_UserGroupModelsItem();
				userGroupModelsItem.CreateTime = _ctx.StringValue("ListByUserGroupId.Result.UserGroupModels["+ i +"].CreateTime");
				userGroupModelsItem.CreateUser = _ctx.StringValue("ListByUserGroupId.Result.UserGroupModels["+ i +"].CreateUser");
				userGroupModelsItem.IdentifiedPath = _ctx.StringValue("ListByUserGroupId.Result.UserGroupModels["+ i +"].IdentifiedPath");
				userGroupModelsItem.ModifiedTime = _ctx.StringValue("ListByUserGroupId.Result.UserGroupModels["+ i +"].ModifiedTime");
				userGroupModelsItem.ModifyUser = _ctx.StringValue("ListByUserGroupId.Result.UserGroupModels["+ i +"].ModifyUser");
				userGroupModelsItem.ParentUsergroupId = _ctx.StringValue("ListByUserGroupId.Result.UserGroupModels["+ i +"].ParentUsergroupId");
				userGroupModelsItem.UsergroupDesc = _ctx.StringValue("ListByUserGroupId.Result.UserGroupModels["+ i +"].UsergroupDesc");
				userGroupModelsItem.UsergroupId = _ctx.StringValue("ListByUserGroupId.Result.UserGroupModels["+ i +"].UsergroupId");
				userGroupModelsItem.UsergroupName = _ctx.StringValue("ListByUserGroupId.Result.UserGroupModels["+ i +"].UsergroupName");

				result_userGroupModels.Add(userGroupModelsItem);
			}
			result.UserGroupModels = result_userGroupModels;
			listByUserGroupIdResponse.Result = result;
        
			return listByUserGroupIdResponse;
        }
    }
}
