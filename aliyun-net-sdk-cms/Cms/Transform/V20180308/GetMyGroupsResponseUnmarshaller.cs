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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class GetMyGroupsResponseUnmarshaller
    {
        public static GetMyGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			GetMyGroupsResponse getMyGroupsResponse = new GetMyGroupsResponse();

			getMyGroupsResponse.HttpResponse = context.HttpResponse;
			getMyGroupsResponse.RequestId = context.StringValue("GetMyGroups.RequestId");
			getMyGroupsResponse.Success = context.BooleanValue("GetMyGroups.Success");
			getMyGroupsResponse.ErrorCode = context.IntegerValue("GetMyGroups.ErrorCode");
			getMyGroupsResponse.ErrorMessage = context.StringValue("GetMyGroups.ErrorMessage");

			GetMyGroupsResponse.GetMyGroups_Group group = new GetMyGroupsResponse.GetMyGroups_Group();
			group.GroupId = context.LongValue("GetMyGroups.Group.GroupId");
			group.GroupName = context.StringValue("GetMyGroups.Group.GroupName");
			group.ServiceId = context.LongValue("GetMyGroups.Group.ServiceId");
			group.BindUrl = context.StringValue("GetMyGroups.Group.BindUrl");
			group.Type = context.StringValue("GetMyGroups.Group.Type");

			List<GetMyGroupsResponse.GetMyGroups_Group.GetMyGroups_ContactGroup> group_contactGroups = new List<GetMyGroupsResponse.GetMyGroups_Group.GetMyGroups_ContactGroup>();
			for (int i = 0; i < context.Length("GetMyGroups.Group.ContactGroups.Length"); i++) {
				GetMyGroupsResponse.GetMyGroups_Group.GetMyGroups_ContactGroup contactGroup = new GetMyGroupsResponse.GetMyGroups_Group.GetMyGroups_ContactGroup();
				contactGroup.Name = context.StringValue("GetMyGroups.Group.ContactGroups["+ i +"].Name");

				group_contactGroups.Add(contactGroup);
			}
			group.ContactGroups = group_contactGroups;
			getMyGroupsResponse.Group = group;
        
			return getMyGroupsResponse;
        }
    }
}
