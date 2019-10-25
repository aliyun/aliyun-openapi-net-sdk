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
    public class QueryIsvUserInfoResponseUnmarshaller
    {
        public static QueryIsvUserInfoResponse Unmarshall(UnmarshallerContext context)
        {
			QueryIsvUserInfoResponse queryIsvUserInfoResponse = new QueryIsvUserInfoResponse();

			queryIsvUserInfoResponse.HttpResponse = context.HttpResponse;
			queryIsvUserInfoResponse.ErrorCode = context.IntegerValue("QueryIsvUserInfo.ErrorCode");
			queryIsvUserInfoResponse.Message = context.StringValue("QueryIsvUserInfo.Message");
			queryIsvUserInfoResponse.Success = context.BooleanValue("QueryIsvUserInfo.Success");
			queryIsvUserInfoResponse.RequestId = context.StringValue("QueryIsvUserInfo.RequestId");

			QueryIsvUserInfoResponse.QueryIsvUserInfo_UserInfo userInfo = new QueryIsvUserInfoResponse.QueryIsvUserInfo_UserInfo();
			userInfo.UserName = context.StringValue("QueryIsvUserInfo.UserInfo.UserName");
			userInfo.CreateTime = context.LongValue("QueryIsvUserInfo.UserInfo.CreateTime");
			userInfo.GroupId = context.StringValue("QueryIsvUserInfo.UserInfo.GroupId");
			userInfo.GroupName = context.StringValue("QueryIsvUserInfo.UserInfo.GroupName");
			userInfo.UserId = context.StringValue("QueryIsvUserInfo.UserInfo.UserId");
			userInfo.UserTel = context.StringValue("QueryIsvUserInfo.UserInfo.UserTel");
			userInfo.UserEmail = context.StringValue("QueryIsvUserInfo.UserInfo.UserEmail");
			userInfo.UserMobile = context.StringValue("QueryIsvUserInfo.UserInfo.UserMobile");
			userInfo.UserAvatarUrl = context.StringValue("QueryIsvUserInfo.UserInfo.UserAvatarUrl");
			userInfo.DepartId = context.StringValue("QueryIsvUserInfo.UserInfo.DepartId");
			userInfo.DepartName = context.StringValue("QueryIsvUserInfo.UserInfo.DepartName");
			queryIsvUserInfoResponse.UserInfo = userInfo;
        
			return queryIsvUserInfoResponse;
        }
    }
}
