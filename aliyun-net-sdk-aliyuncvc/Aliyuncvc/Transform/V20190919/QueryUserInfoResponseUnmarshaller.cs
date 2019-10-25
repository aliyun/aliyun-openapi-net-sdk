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
    public class QueryUserInfoResponseUnmarshaller
    {
        public static QueryUserInfoResponse Unmarshall(UnmarshallerContext context)
        {
			QueryUserInfoResponse queryUserInfoResponse = new QueryUserInfoResponse();

			queryUserInfoResponse.HttpResponse = context.HttpResponse;
			queryUserInfoResponse.ErrorCode = context.IntegerValue("QueryUserInfo.ErrorCode");
			queryUserInfoResponse.Message = context.StringValue("QueryUserInfo.Message");
			queryUserInfoResponse.Success = context.BooleanValue("QueryUserInfo.Success");
			queryUserInfoResponse.RequestId = context.StringValue("QueryUserInfo.RequestId");

			QueryUserInfoResponse.QueryUserInfo_UserInfo userInfo = new QueryUserInfoResponse.QueryUserInfo_UserInfo();
			userInfo.CurNum = context.IntegerValue("QueryUserInfo.UserInfo.CurNum");
			userInfo.MemberConcurrentMax = context.IntegerValue("QueryUserInfo.UserInfo.MemberConcurrentMax");
			userInfo.MaxNum = context.IntegerValue("QueryUserInfo.UserInfo.MaxNum");
			queryUserInfoResponse.UserInfo = userInfo;
        
			return queryUserInfoResponse;
        }
    }
}
