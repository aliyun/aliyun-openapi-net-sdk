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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeUsersResponseUnmarshaller
    {
        public static DescribeUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUsersResponse describeUsersResponse = new DescribeUsersResponse();

			describeUsersResponse.HttpResponse = _ctx.HttpResponse;
			describeUsersResponse.ErrorMessage = _ctx.StringValue("DescribeUsers.ErrorMessage");
			describeUsersResponse.ErrorCode = _ctx.StringValue("DescribeUsers.ErrorCode");
			describeUsersResponse.Message = _ctx.StringValue("DescribeUsers.Message");
			describeUsersResponse.PageNumber = _ctx.IntegerValue("DescribeUsers.PageNumber");
			describeUsersResponse.DynamicCode = _ctx.StringValue("DescribeUsers.DynamicCode");
			describeUsersResponse.Code = _ctx.StringValue("DescribeUsers.Code");
			describeUsersResponse.TotalCount = _ctx.IntegerValue("DescribeUsers.TotalCount");
			describeUsersResponse.DynamicMessage = _ctx.StringValue("DescribeUsers.DynamicMessage");
			describeUsersResponse.RequestId = _ctx.StringValue("DescribeUsers.RequestId");
			describeUsersResponse.Success = _ctx.BooleanValue("DescribeUsers.Success");
			describeUsersResponse.PageSize = _ctx.IntegerValue("DescribeUsers.PageSize");

			List<DescribeUsersResponse.DescribeUsers_UserInfo> describeUsersResponse_users = new List<DescribeUsersResponse.DescribeUsers_UserInfo>();
			for (int i = 0; i < _ctx.Length("DescribeUsers.Users.Length"); i++) {
				DescribeUsersResponse.DescribeUsers_UserInfo userInfo = new DescribeUsersResponse.DescribeUsers_UserInfo();
				userInfo.Stores = _ctx.StringValue("DescribeUsers.Users["+ i +"].Stores");
				userInfo.UserName = _ctx.StringValue("DescribeUsers.Users["+ i +"].UserName");
				userInfo.UserId = _ctx.StringValue("DescribeUsers.Users["+ i +"].UserId");
				userInfo.UserType = _ctx.StringValue("DescribeUsers.Users["+ i +"].UserType");
				userInfo.OwnerId = _ctx.StringValue("DescribeUsers.Users["+ i +"].OwnerId");
				userInfo.Bid = _ctx.StringValue("DescribeUsers.Users["+ i +"].Bid");

				List<DescribeUsersResponse.DescribeUsers_UserInfo.DescribeUsers_DingTalkInfo> userInfo_dingTalkInfos = new List<DescribeUsersResponse.DescribeUsers_UserInfo.DescribeUsers_DingTalkInfo>();
				for (int j = 0; j < _ctx.Length("DescribeUsers.Users["+ i +"].DingTalkInfos.Length"); j++) {
					DescribeUsersResponse.DescribeUsers_UserInfo.DescribeUsers_DingTalkInfo dingTalkInfo = new DescribeUsersResponse.DescribeUsers_UserInfo.DescribeUsers_DingTalkInfo();
					dingTalkInfo.DingTalkCompanyId = _ctx.StringValue("DescribeUsers.Users["+ i +"].DingTalkInfos["+ j +"].DingTalkCompanyId");
					dingTalkInfo.DingTalkUserId = _ctx.StringValue("DescribeUsers.Users["+ i +"].DingTalkInfos["+ j +"].DingTalkUserId");

					userInfo_dingTalkInfos.Add(dingTalkInfo);
				}
				userInfo.DingTalkInfos = userInfo_dingTalkInfos;

				describeUsersResponse_users.Add(userInfo);
			}
			describeUsersResponse.Users = describeUsersResponse_users;
        
			return describeUsersResponse;
        }
    }
}
