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
    public class QueryFaceUserGroupResponseUnmarshaller
    {
        public static QueryFaceUserGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFaceUserGroupResponse queryFaceUserGroupResponse = new QueryFaceUserGroupResponse();

			queryFaceUserGroupResponse.HttpResponse = _ctx.HttpResponse;
			queryFaceUserGroupResponse.Code = _ctx.StringValue("QueryFaceUserGroup.Code");
			queryFaceUserGroupResponse.ErrorMessage = _ctx.StringValue("QueryFaceUserGroup.ErrorMessage");
			queryFaceUserGroupResponse.RequestId = _ctx.StringValue("QueryFaceUserGroup.RequestId");
			queryFaceUserGroupResponse.Success = _ctx.BooleanValue("QueryFaceUserGroup.Success");

			QueryFaceUserGroupResponse.QueryFaceUserGroup_Data data = new QueryFaceUserGroupResponse.QueryFaceUserGroup_Data();
			data.PageNo = _ctx.IntegerValue("QueryFaceUserGroup.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("QueryFaceUserGroup.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryFaceUserGroup.Data.Total");

			List<QueryFaceUserGroupResponse.QueryFaceUserGroup_Data.QueryFaceUserGroup_UserGroupInfos> data_userGroupList = new List<QueryFaceUserGroupResponse.QueryFaceUserGroup_Data.QueryFaceUserGroup_UserGroupInfos>();
			for (int i = 0; i < _ctx.Length("QueryFaceUserGroup.Data.UserGroupList.Length"); i++) {
				QueryFaceUserGroupResponse.QueryFaceUserGroup_Data.QueryFaceUserGroup_UserGroupInfos userGroupInfos = new QueryFaceUserGroupResponse.QueryFaceUserGroup_Data.QueryFaceUserGroup_UserGroupInfos();
				userGroupInfos.UserGroupName = _ctx.StringValue("QueryFaceUserGroup.Data.UserGroupList["+ i +"].UserGroupName");
				userGroupInfos.ModifiedTime = _ctx.StringValue("QueryFaceUserGroup.Data.UserGroupList["+ i +"].ModifiedTime");
				userGroupInfos.UserGroupId = _ctx.StringValue("QueryFaceUserGroup.Data.UserGroupList["+ i +"].UserGroupId");

				data_userGroupList.Add(userGroupInfos);
			}
			data.UserGroupList = data_userGroupList;
			queryFaceUserGroupResponse.Data = data;
        
			return queryFaceUserGroupResponse;
        }
    }
}
