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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListRoleResponseUnmarshaller
    {
        public static ListRoleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRoleResponse listRoleResponse = new ListRoleResponse();

			listRoleResponse.HttpResponse = _ctx.HttpResponse;
			listRoleResponse.Code = _ctx.IntegerValue("ListRole.Code");
			listRoleResponse.Message = _ctx.StringValue("ListRole.Message");
			listRoleResponse.RequestId = _ctx.StringValue("ListRole.RequestId");

			List<ListRoleResponse.ListRole_RoleItem> listRoleResponse_roleList = new List<ListRoleResponse.ListRole_RoleItem>();
			for (int i = 0; i < _ctx.Length("ListRole.RoleList.Length"); i++) {
				ListRoleResponse.ListRole_RoleItem roleItem = new ListRoleResponse.ListRole_RoleItem();

				ListRoleResponse.ListRole_RoleItem.ListRole_Role role = new ListRoleResponse.ListRole_RoleItem.ListRole_Role();
				role.Id = _ctx.IntegerValue("ListRole.RoleList["+ i +"].Role.Id");
				role.AdminUserId = _ctx.StringValue("ListRole.RoleList["+ i +"].Role.AdminUserId");
				role.Name = _ctx.StringValue("ListRole.RoleList["+ i +"].Role.Name");
				role.CreateTime = _ctx.LongValue("ListRole.RoleList["+ i +"].Role.CreateTime");
				role.UpdateTime = _ctx.LongValue("ListRole.RoleList["+ i +"].Role.UpdateTime");
				role.IsDefault = _ctx.BooleanValue("ListRole.RoleList["+ i +"].Role.IsDefault");
				roleItem.Role = role;

				List<ListRoleResponse.ListRole_RoleItem.ListRole_Action> roleItem_actionList = new List<ListRoleResponse.ListRole_RoleItem.ListRole_Action>();
				for (int j = 0; j < _ctx.Length("ListRole.RoleList["+ i +"].ActionList.Length"); j++) {
					ListRoleResponse.ListRole_RoleItem.ListRole_Action action = new ListRoleResponse.ListRole_RoleItem.ListRole_Action();
					action.GroupId = _ctx.StringValue("ListRole.RoleList["+ i +"].ActionList["+ j +"].GroupId");
					action.Code = _ctx.StringValue("ListRole.RoleList["+ i +"].ActionList["+ j +"].Code");
					action.Name = _ctx.StringValue("ListRole.RoleList["+ i +"].ActionList["+ j +"].Name");
					action.Description = _ctx.StringValue("ListRole.RoleList["+ i +"].ActionList["+ j +"].Description");

					roleItem_actionList.Add(action);
				}
				roleItem.ActionList = roleItem_actionList;

				listRoleResponse_roleList.Add(roleItem);
			}
			listRoleResponse.RoleList = listRoleResponse_roleList;
        
			return listRoleResponse;
        }
    }
}
