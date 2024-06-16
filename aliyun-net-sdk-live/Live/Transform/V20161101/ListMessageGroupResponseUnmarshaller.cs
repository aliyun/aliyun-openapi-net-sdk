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
    public class ListMessageGroupResponseUnmarshaller
    {
        public static ListMessageGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMessageGroupResponse listMessageGroupResponse = new ListMessageGroupResponse();

			listMessageGroupResponse.HttpResponse = _ctx.HttpResponse;
			listMessageGroupResponse.RequestId = _ctx.StringValue("ListMessageGroup.RequestId");

			ListMessageGroupResponse.ListMessageGroup_Result result = new ListMessageGroupResponse.ListMessageGroup_Result();
			result.HasMore = _ctx.BooleanValue("ListMessageGroup.Result.HasMore");
			result.Total = _ctx.IntegerValue("ListMessageGroup.Result.Total");

			List<ListMessageGroupResponse.ListMessageGroup_Result.ListMessageGroup_GroupListItem> result_groupList = new List<ListMessageGroupResponse.ListMessageGroup_Result.ListMessageGroup_GroupListItem>();
			for (int i = 0; i < _ctx.Length("ListMessageGroup.Result.GroupList.Length"); i++) {
				ListMessageGroupResponse.ListMessageGroup_Result.ListMessageGroup_GroupListItem groupListItem = new ListMessageGroupResponse.ListMessageGroup_Result.ListMessageGroup_GroupListItem();
				groupListItem.AppId = _ctx.StringValue("ListMessageGroup.Result.GroupList["+ i +"].AppId");
				groupListItem.CreateTime = _ctx.LongValue("ListMessageGroup.Result.GroupList["+ i +"].CreateTime");
				groupListItem.CreatorId = _ctx.StringValue("ListMessageGroup.Result.GroupList["+ i +"].CreatorId");
				groupListItem.Extension = _ctx.StringValue("ListMessageGroup.Result.GroupList["+ i +"].Extension");
				groupListItem.GroupId = _ctx.StringValue("ListMessageGroup.Result.GroupList["+ i +"].GroupId");
				groupListItem.Status = _ctx.IntegerValue("ListMessageGroup.Result.GroupList["+ i +"].Status");

				result_groupList.Add(groupListItem);
			}
			result.GroupList = result_groupList;
			listMessageGroupResponse.Result = result;
        
			return listMessageGroupResponse;
        }
    }
}
