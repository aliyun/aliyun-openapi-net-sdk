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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cms.Model.V20170301;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Transform.V20170301
{
    public class DeleteMyGroupsResponseUnmarshaller
    {
        public static DeleteMyGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteMyGroupsResponse deleteMyGroupsResponse = new DeleteMyGroupsResponse();

			deleteMyGroupsResponse.HttpResponse = context.HttpResponse;
			deleteMyGroupsResponse.RequestId = context.StringValue("DeleteMyGroups.RequestId");
			deleteMyGroupsResponse.Success = context.BooleanValue("DeleteMyGroups.Success");
			deleteMyGroupsResponse.ErrorCode = context.IntegerValue("DeleteMyGroups.ErrorCode");
			deleteMyGroupsResponse.ErrorMessage = context.StringValue("DeleteMyGroups.ErrorMessage");

			DeleteMyGroupsResponse.DeleteMyGroups_Group group = new DeleteMyGroupsResponse.DeleteMyGroups_Group();
			group.GroupId = context.LongValue("DeleteMyGroups.Group.GroupId");
			group.GroupName = context.StringValue("DeleteMyGroups.Group.GroupName");
			group.ServiceId = context.StringValue("DeleteMyGroups.Group.ServiceId");
			group.BindUrls = context.StringValue("DeleteMyGroups.Group.BindUrls");
			group.Type = context.StringValue("DeleteMyGroups.Group.Type");

			List<DeleteMyGroupsResponse.DeleteMyGroups_Group.DeleteMyGroups_ContactGroup> group_contactGroups = new List<DeleteMyGroupsResponse.DeleteMyGroups_Group.DeleteMyGroups_ContactGroup>();
			for (int i = 0; i < context.Length("DeleteMyGroups.Group.ContactGroups.Length"); i++) {
				DeleteMyGroupsResponse.DeleteMyGroups_Group.DeleteMyGroups_ContactGroup contactGroup = new DeleteMyGroupsResponse.DeleteMyGroups_Group.DeleteMyGroups_ContactGroup();
				contactGroup.Name = context.StringValue("DeleteMyGroups.Group.ContactGroups["+ i +"].Name");

				group_contactGroups.Add(contactGroup);
			}
			group.ContactGroups = group_contactGroups;
			deleteMyGroupsResponse.Group = group;
        
			return deleteMyGroupsResponse;
        }
    }
}