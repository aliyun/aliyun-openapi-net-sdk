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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class ListUserGroupsResponseUnmarshaller
    {
        public static ListUserGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			ListUserGroupsResponse listUserGroupsResponse = new ListUserGroupsResponse();

			listUserGroupsResponse.HttpResponse = context.HttpResponse;
			listUserGroupsResponse.Code = context.StringValue("ListUserGroups.Code");
			listUserGroupsResponse.Message = context.StringValue("ListUserGroups.Message");
			listUserGroupsResponse.RequestId = context.StringValue("ListUserGroups.RequestId");

			List<ListUserGroupsResponse.ListUserGroups_DataItem> listUserGroupsResponse_data = new List<ListUserGroupsResponse.ListUserGroups_DataItem>();
			for (int i = 0; i < context.Length("ListUserGroups.Data.Length"); i++) {
				ListUserGroupsResponse.ListUserGroups_DataItem dataItem = new ListUserGroupsResponse.ListUserGroups_DataItem();
				dataItem.Creator = context.StringValue("ListUserGroups.Data["+ i +"].Creator");
				dataItem.UserGroupName = context.StringValue("ListUserGroups.Data["+ i +"].UserGroupName");
				dataItem.IsvSubId = context.StringValue("ListUserGroups.Data["+ i +"].IsvSubId");
				dataItem.UserGroupId = context.LongValue("ListUserGroups.Data["+ i +"].UserGroupId");
				dataItem.UserCount = context.LongValue("ListUserGroups.Data["+ i +"].UserCount");
				dataItem.CreateTime = context.StringValue("ListUserGroups.Data["+ i +"].CreateTime");
				dataItem.UpdateTime = context.StringValue("ListUserGroups.Data["+ i +"].UpdateTime");
				dataItem.ParentUserGroupId = context.LongValue("ListUserGroups.Data["+ i +"].ParentUserGroupId");

				listUserGroupsResponse_data.Add(dataItem);
			}
			listUserGroupsResponse.Data = listUserGroupsResponse_data;
        
			return listUserGroupsResponse;
        }
    }
}
