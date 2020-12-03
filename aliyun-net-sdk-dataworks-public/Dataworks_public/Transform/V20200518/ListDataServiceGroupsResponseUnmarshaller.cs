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
    public class ListDataServiceGroupsResponseUnmarshaller
    {
        public static ListDataServiceGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataServiceGroupsResponse listDataServiceGroupsResponse = new ListDataServiceGroupsResponse();

			listDataServiceGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listDataServiceGroupsResponse.RequestId = _ctx.StringValue("ListDataServiceGroups.RequestId");

			ListDataServiceGroupsResponse.ListDataServiceGroups_GroupPagingResult groupPagingResult = new ListDataServiceGroupsResponse.ListDataServiceGroups_GroupPagingResult();
			groupPagingResult.PageNumber = _ctx.IntegerValue("ListDataServiceGroups.GroupPagingResult.PageNumber");
			groupPagingResult.PageSize = _ctx.IntegerValue("ListDataServiceGroups.GroupPagingResult.PageSize");
			groupPagingResult.TotalCount = _ctx.IntegerValue("ListDataServiceGroups.GroupPagingResult.TotalCount");

			List<ListDataServiceGroupsResponse.ListDataServiceGroups_GroupPagingResult.ListDataServiceGroups_Group> groupPagingResult_groups = new List<ListDataServiceGroupsResponse.ListDataServiceGroups_GroupPagingResult.ListDataServiceGroups_Group>();
			for (int i = 0; i < _ctx.Length("ListDataServiceGroups.GroupPagingResult.Groups.Length"); i++) {
				ListDataServiceGroupsResponse.ListDataServiceGroups_GroupPagingResult.ListDataServiceGroups_Group group = new ListDataServiceGroupsResponse.ListDataServiceGroups_GroupPagingResult.ListDataServiceGroups_Group();
				group.TenantId = _ctx.LongValue("ListDataServiceGroups.GroupPagingResult.Groups["+ i +"].TenantId");
				group.GroupId = _ctx.StringValue("ListDataServiceGroups.GroupPagingResult.Groups["+ i +"].GroupId");
				group.ApiGatewayGroupId = _ctx.StringValue("ListDataServiceGroups.GroupPagingResult.Groups["+ i +"].ApiGatewayGroupId");
				group.GroupName = _ctx.StringValue("ListDataServiceGroups.GroupPagingResult.Groups["+ i +"].GroupName");
				group.Description = _ctx.StringValue("ListDataServiceGroups.GroupPagingResult.Groups["+ i +"].Description");
				group.CreatedTime = _ctx.StringValue("ListDataServiceGroups.GroupPagingResult.Groups["+ i +"].CreatedTime");
				group.ModifiedTime = _ctx.StringValue("ListDataServiceGroups.GroupPagingResult.Groups["+ i +"].ModifiedTime");
				group.CreatorId = _ctx.StringValue("ListDataServiceGroups.GroupPagingResult.Groups["+ i +"].CreatorId");
				group.ProjectId = _ctx.LongValue("ListDataServiceGroups.GroupPagingResult.Groups["+ i +"].ProjectId");

				groupPagingResult_groups.Add(group);
			}
			groupPagingResult.Groups = groupPagingResult_groups;
			listDataServiceGroupsResponse.GroupPagingResult = groupPagingResult;
        
			return listDataServiceGroupsResponse;
        }
    }
}
