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
    public class ListLiveMessageGroupByPageResponseUnmarshaller
    {
        public static ListLiveMessageGroupByPageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLiveMessageGroupByPageResponse listLiveMessageGroupByPageResponse = new ListLiveMessageGroupByPageResponse();

			listLiveMessageGroupByPageResponse.HttpResponse = _ctx.HttpResponse;
			listLiveMessageGroupByPageResponse.RequestId = _ctx.StringValue("ListLiveMessageGroupByPage.RequestId");
			listLiveMessageGroupByPageResponse.TotalCount = _ctx.IntegerValue("ListLiveMessageGroupByPage.TotalCount");
			listLiveMessageGroupByPageResponse.PageNumber = _ctx.IntegerValue("ListLiveMessageGroupByPage.PageNumber");
			listLiveMessageGroupByPageResponse.PageSize = _ctx.IntegerValue("ListLiveMessageGroupByPage.PageSize");

			List<ListLiveMessageGroupByPageResponse.ListLiveMessageGroupByPage_Groups> listLiveMessageGroupByPageResponse_groupList = new List<ListLiveMessageGroupByPageResponse.ListLiveMessageGroupByPage_Groups>();
			for (int i = 0; i < _ctx.Length("ListLiveMessageGroupByPage.GroupList.Length"); i++) {
				ListLiveMessageGroupByPageResponse.ListLiveMessageGroupByPage_Groups groups = new ListLiveMessageGroupByPageResponse.ListLiveMessageGroupByPage_Groups();
				groups.GroupId = _ctx.StringValue("ListLiveMessageGroupByPage.GroupList["+ i +"].GroupId");
				groups.CreatorId = _ctx.StringValue("ListLiveMessageGroupByPage.GroupList["+ i +"].CreatorId");
				groups.Createtime = _ctx.LongValue("ListLiveMessageGroupByPage.GroupList["+ i +"].Createtime");
				groups.GroupName = _ctx.StringValue("ListLiveMessageGroupByPage.GroupList["+ i +"].GroupName");
				groups.GroupInfo = _ctx.StringValue("ListLiveMessageGroupByPage.GroupList["+ i +"].GroupInfo");
				groups.Delete = _ctx.BooleanValue("ListLiveMessageGroupByPage.GroupList["+ i +"].Delete");

				List<string> groups_adminList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListLiveMessageGroupByPage.GroupList["+ i +"].AdminList.Length"); j++) {
					groups_adminList.Add(_ctx.StringValue("ListLiveMessageGroupByPage.GroupList["+ i +"].AdminList["+ j +"]"));
				}
				groups.AdminList = groups_adminList;

				listLiveMessageGroupByPageResponse_groupList.Add(groups);
			}
			listLiveMessageGroupByPageResponse.GroupList = listLiveMessageGroupByPageResponse_groupList;
        
			return listLiveMessageGroupByPageResponse;
        }
    }
}
