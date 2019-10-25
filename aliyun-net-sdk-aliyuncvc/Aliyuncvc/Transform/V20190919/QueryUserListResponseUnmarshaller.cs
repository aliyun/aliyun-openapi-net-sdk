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
using Aliyun.Acs.aliyuncvc.Model.V20190919;

namespace Aliyun.Acs.aliyuncvc.Transform.V20190919
{
    public class QueryUserListResponseUnmarshaller
    {
        public static QueryUserListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryUserListResponse queryUserListResponse = new QueryUserListResponse();

			queryUserListResponse.HttpResponse = context.HttpResponse;
			queryUserListResponse.ErrorCode = context.IntegerValue("QueryUserList.ErrorCode");
			queryUserListResponse.Message = context.StringValue("QueryUserList.Message");
			queryUserListResponse.Success = context.BooleanValue("QueryUserList.Success");
			queryUserListResponse.RequestId = context.StringValue("QueryUserList.RequestId");

			QueryUserListResponse.QueryUserList_Data data = new QueryUserListResponse.QueryUserList_Data();
			data.TotalCount = context.IntegerValue("QueryUserList.Data.TotalCount");
			data.PageSize = context.IntegerValue("QueryUserList.Data.PageSize");
			data.PageNumber = context.IntegerValue("QueryUserList.Data.PageNumber");

			List<QueryUserListResponse.QueryUserList_Data.QueryUserList_UserInfo> data_userInfos = new List<QueryUserListResponse.QueryUserList_Data.QueryUserList_UserInfo>();
			for (int i = 0; i < context.Length("QueryUserList.Data.UserInfos.Length"); i++) {
				QueryUserListResponse.QueryUserList_Data.QueryUserList_UserInfo userInfo = new QueryUserListResponse.QueryUserList_Data.QueryUserList_UserInfo();
				userInfo.CreateTime = context.LongValue("QueryUserList.Data.UserInfos["+ i +"].CreateTime");
				userInfo.GroupName = context.StringValue("QueryUserList.Data.UserInfos["+ i +"].GroupName");
				userInfo.UserName = context.StringValue("QueryUserList.Data.UserInfos["+ i +"].UserName");
				userInfo.GroupId = context.StringValue("QueryUserList.Data.UserInfos["+ i +"].GroupId");
				userInfo.GroupName1 = context.StringValue("QueryUserList.Data.UserInfos["+ i +"].GroupName");
				userInfo.DepartName = context.StringValue("QueryUserList.Data.UserInfos["+ i +"].DepartName");
				userInfo.DepartId = context.StringValue("QueryUserList.Data.UserInfos["+ i +"].DepartId");
				userInfo.UserEmail = context.StringValue("QueryUserList.Data.UserInfos["+ i +"].UserEmail");
				userInfo.UserTel = context.StringValue("QueryUserList.Data.UserInfos["+ i +"].UserTel");
				userInfo.UserMobile = context.StringValue("QueryUserList.Data.UserInfos["+ i +"].UserMobile");
				userInfo.UserAvatarUrl = context.StringValue("QueryUserList.Data.UserInfos["+ i +"].UserAvatarUrl");

				data_userInfos.Add(userInfo);
			}
			data.UserInfos = data_userInfos;
			queryUserListResponse.Data = data;
        
			return queryUserListResponse;
        }
    }
}
