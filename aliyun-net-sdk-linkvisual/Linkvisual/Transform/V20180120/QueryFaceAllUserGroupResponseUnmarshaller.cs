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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryFaceAllUserGroupResponseUnmarshaller
    {
        public static QueryFaceAllUserGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFaceAllUserGroupResponse queryFaceAllUserGroupResponse = new QueryFaceAllUserGroupResponse();

			queryFaceAllUserGroupResponse.HttpResponse = _ctx.HttpResponse;
			queryFaceAllUserGroupResponse.Code = _ctx.StringValue("QueryFaceAllUserGroup.Code");
			queryFaceAllUserGroupResponse.ErrorMessage = _ctx.StringValue("QueryFaceAllUserGroup.ErrorMessage");
			queryFaceAllUserGroupResponse.RequestId = _ctx.StringValue("QueryFaceAllUserGroup.RequestId");
			queryFaceAllUserGroupResponse.Success = _ctx.BooleanValue("QueryFaceAllUserGroup.Success");

			QueryFaceAllUserGroupResponse.QueryFaceAllUserGroup_Data data = new QueryFaceAllUserGroupResponse.QueryFaceAllUserGroup_Data();
			data.PageNo = _ctx.IntegerValue("QueryFaceAllUserGroup.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("QueryFaceAllUserGroup.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryFaceAllUserGroup.Data.Total");

			List<QueryFaceAllUserGroupResponse.QueryFaceAllUserGroup_Data.QueryFaceAllUserGroup_UserGroupListItem> data_userGroupList = new List<QueryFaceAllUserGroupResponse.QueryFaceAllUserGroup_Data.QueryFaceAllUserGroup_UserGroupListItem>();
			for (int i = 0; i < _ctx.Length("QueryFaceAllUserGroup.Data.UserGroupList.Length"); i++) {
				QueryFaceAllUserGroupResponse.QueryFaceAllUserGroup_Data.QueryFaceAllUserGroup_UserGroupListItem userGroupListItem = new QueryFaceAllUserGroupResponse.QueryFaceAllUserGroup_Data.QueryFaceAllUserGroup_UserGroupListItem();
				userGroupListItem.UserGroupName = _ctx.StringValue("QueryFaceAllUserGroup.Data.UserGroupList["+ i +"].UserGroupName");
				userGroupListItem.ModifiedTime = _ctx.StringValue("QueryFaceAllUserGroup.Data.UserGroupList["+ i +"].ModifiedTime");
				userGroupListItem.UserGroupId = _ctx.StringValue("QueryFaceAllUserGroup.Data.UserGroupList["+ i +"].UserGroupId");

				data_userGroupList.Add(userGroupListItem);
			}
			data.UserGroupList = data_userGroupList;
			queryFaceAllUserGroupResponse.Data = data;
        
			return queryFaceAllUserGroupResponse;
        }
    }
}
