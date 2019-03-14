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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListAlertUserGroupResponseUnmarshaller
    {
        public static ListAlertUserGroupResponse Unmarshall(UnmarshallerContext context)
        {
			ListAlertUserGroupResponse listAlertUserGroupResponse = new ListAlertUserGroupResponse();

			listAlertUserGroupResponse.HttpResponse = context.HttpResponse;

			List<ListAlertUserGroupResponse.ListAlertUserGroup_Group> listAlertUserGroupResponse_alertUserGroupList = new List<ListAlertUserGroupResponse.ListAlertUserGroup_Group>();
			for (int i = 0; i < context.Length("ListAlertUserGroup.AlertUserGroupList.Length"); i++) {
				ListAlertUserGroupResponse.ListAlertUserGroup_Group group = new ListAlertUserGroupResponse.ListAlertUserGroup_Group();
				group.Id = context.LongValue("ListAlertUserGroup.AlertUserGroupList["+ i +"].Id");
				group.GmtCreate = context.StringValue("ListAlertUserGroup.AlertUserGroupList["+ i +"].GmtCreate");
				group.GmtModified = context.StringValue("ListAlertUserGroup.AlertUserGroupList["+ i +"].GmtModified");
				group.BizId = context.StringValue("ListAlertUserGroup.AlertUserGroupList["+ i +"].BizId");
				group.Name = context.StringValue("ListAlertUserGroup.AlertUserGroupList["+ i +"].Name");
				group.Description = context.StringValue("ListAlertUserGroup.AlertUserGroupList["+ i +"].Description");

				List<ListAlertUserGroupResponse.ListAlertUserGroup_Group.ListAlertUserGroup_UserInfo> group_userList = new List<ListAlertUserGroupResponse.ListAlertUserGroup_Group.ListAlertUserGroup_UserInfo>();
				for (int j = 0; j < context.Length("ListAlertUserGroup.AlertUserGroupList["+ i +"].UserList.Length"); j++) {
					ListAlertUserGroupResponse.ListAlertUserGroup_Group.ListAlertUserGroup_UserInfo userInfo = new ListAlertUserGroupResponse.ListAlertUserGroup_Group.ListAlertUserGroup_UserInfo();
					userInfo.UserId = context.StringValue("ListAlertUserGroup.AlertUserGroupList["+ i +"].UserList["+ j +"].UserId");
					userInfo.UserName = context.StringValue("ListAlertUserGroup.AlertUserGroupList["+ i +"].UserList["+ j +"].UserName");
					userInfo.EnableSMS = context.BooleanValue("ListAlertUserGroup.AlertUserGroupList["+ i +"].UserList["+ j +"].EnableSMS");
					userInfo.EnableEmail = context.BooleanValue("ListAlertUserGroup.AlertUserGroupList["+ i +"].UserList["+ j +"].EnableEmail");

					group_userList.Add(userInfo);
				}
				group.UserList = group_userList;

				listAlertUserGroupResponse_alertUserGroupList.Add(group);
			}
			listAlertUserGroupResponse.AlertUserGroupList = listAlertUserGroupResponse_alertUserGroupList;
        
			return listAlertUserGroupResponse;
        }
    }
}
