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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class ListLiveMessageGroupsResponseUnmarshaller
    {
        public static ListLiveMessageGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLiveMessageGroupsResponse listLiveMessageGroupsResponse = new ListLiveMessageGroupsResponse();

			listLiveMessageGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listLiveMessageGroupsResponse.RequestId = _ctx.StringValue("ListLiveMessageGroups.RequestId");
			listLiveMessageGroupsResponse.Hasmore = _ctx.BooleanValue("ListLiveMessageGroups.Hasmore");
			listLiveMessageGroupsResponse.NextpageToken = _ctx.StringValue("ListLiveMessageGroups.NextpageToken");

			List<ListLiveMessageGroupsResponse.ListLiveMessageGroups_Groups> listLiveMessageGroupsResponse_groupList = new List<ListLiveMessageGroupsResponse.ListLiveMessageGroups_Groups>();
			for (int i = 0; i < _ctx.Length("ListLiveMessageGroups.GroupList.Length"); i++) {
				ListLiveMessageGroupsResponse.ListLiveMessageGroups_Groups groups = new ListLiveMessageGroupsResponse.ListLiveMessageGroups_Groups();
				groups.GroupId = _ctx.StringValue("ListLiveMessageGroups.GroupList["+ i +"].GroupId");
				groups.CreatorId = _ctx.StringValue("ListLiveMessageGroups.GroupList["+ i +"].CreatorId");
				groups.Createtime = _ctx.LongValue("ListLiveMessageGroups.GroupList["+ i +"].Createtime");
				groups.GroupName = _ctx.StringValue("ListLiveMessageGroups.GroupList["+ i +"].GroupName");
				groups.GroupInfo = _ctx.StringValue("ListLiveMessageGroups.GroupList["+ i +"].GroupInfo");
				groups.Delete = _ctx.BooleanValue("ListLiveMessageGroups.GroupList["+ i +"].Delete");

				List<string> groups_adminList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListLiveMessageGroups.GroupList["+ i +"].AdminList.Length"); j++) {
					groups_adminList.Add(_ctx.StringValue("ListLiveMessageGroups.GroupList["+ i +"].AdminList["+ j +"]"));
				}
				groups.AdminList = groups_adminList;

				listLiveMessageGroupsResponse_groupList.Add(groups);
			}
			listLiveMessageGroupsResponse.GroupList = listLiveMessageGroupsResponse_groupList;
        
			return listLiveMessageGroupsResponse;
        }
    }
}
