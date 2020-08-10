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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListProjectMembersResponseUnmarshaller
    {
        public static ListProjectMembersResponse Unmarshall(UnmarshallerContext context)
        {
			ListProjectMembersResponse listProjectMembersResponse = new ListProjectMembersResponse();

			listProjectMembersResponse.HttpResponse = context.HttpResponse;
			listProjectMembersResponse.RequestId = context.StringValue("ListProjectMembers.RequestId");

			ListProjectMembersResponse.ListProjectMembers_Data data = new ListProjectMembersResponse.ListProjectMembers_Data();
			data.PageNumber = context.IntegerValue("ListProjectMembers.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListProjectMembers.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListProjectMembers.Data.TotalCount");

			List<ListProjectMembersResponse.ListProjectMembers_Data.ListProjectMembers_ProjectMember> data_projectMemberList = new List<ListProjectMembersResponse.ListProjectMembers_Data.ListProjectMembers_ProjectMember>();
			for (int i = 0; i < context.Length("ListProjectMembers.Data.ProjectMemberList.Length"); i++) {
				ListProjectMembersResponse.ListProjectMembers_Data.ListProjectMembers_ProjectMember projectMember = new ListProjectMembersResponse.ListProjectMembers_Data.ListProjectMembers_ProjectMember();
				projectMember.Nick = context.StringValue("ListProjectMembers.Data.ProjectMemberList["+ i +"].Nick");
				projectMember.ProjectMemberId = context.StringValue("ListProjectMembers.Data.ProjectMemberList["+ i +"].ProjectMemberId");
				projectMember.ProjectMemberName = context.StringValue("ListProjectMembers.Data.ProjectMemberList["+ i +"].ProjectMemberName");
				projectMember.ProjectMemberType = context.StringValue("ListProjectMembers.Data.ProjectMemberList["+ i +"].ProjectMemberType");
				projectMember.Status = context.StringValue("ListProjectMembers.Data.ProjectMemberList["+ i +"].Status");

				List<ListProjectMembersResponse.ListProjectMembers_Data.ListProjectMembers_ProjectMember.ListProjectMembers_Role> projectMember_projectRoleList = new List<ListProjectMembersResponse.ListProjectMembers_Data.ListProjectMembers_ProjectMember.ListProjectMembers_Role>();
				for (int j = 0; j < context.Length("ListProjectMembers.Data.ProjectMemberList["+ i +"].ProjectRoleList.Length"); j++) {
					ListProjectMembersResponse.ListProjectMembers_Data.ListProjectMembers_ProjectMember.ListProjectMembers_Role role = new ListProjectMembersResponse.ListProjectMembers_Data.ListProjectMembers_ProjectMember.ListProjectMembers_Role();
					role.ProjectRoleCode = context.StringValue("ListProjectMembers.Data.ProjectMemberList["+ i +"].ProjectRoleList["+ j +"].ProjectRoleCode");
					role.ProjectRoleId = context.IntegerValue("ListProjectMembers.Data.ProjectMemberList["+ i +"].ProjectRoleList["+ j +"].ProjectRoleId");
					role.ProjectRoleName = context.StringValue("ListProjectMembers.Data.ProjectMemberList["+ i +"].ProjectRoleList["+ j +"].ProjectRoleName");
					role.ProjectRoleType = context.StringValue("ListProjectMembers.Data.ProjectMemberList["+ i +"].ProjectRoleList["+ j +"].ProjectRoleType");

					projectMember_projectRoleList.Add(role);
				}
				projectMember.ProjectRoleList = projectMember_projectRoleList;

				data_projectMemberList.Add(projectMember);
			}
			data.ProjectMemberList = data_projectMemberList;
			listProjectMembersResponse.Data = data;
        
			return listProjectMembersResponse;
        }
    }
}
