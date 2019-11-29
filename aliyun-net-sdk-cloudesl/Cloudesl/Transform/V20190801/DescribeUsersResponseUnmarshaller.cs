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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class DescribeUsersResponseUnmarshaller
    {
        public static DescribeUsersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUsersResponse describeUsersResponse = new DescribeUsersResponse();

			describeUsersResponse.HttpResponse = context.HttpResponse;
			describeUsersResponse.ErrorMessage = context.StringValue("DescribeUsers.ErrorMessage");
			describeUsersResponse.ErrorCode = context.StringValue("DescribeUsers.ErrorCode");
			describeUsersResponse.Message = context.StringValue("DescribeUsers.Message");
			describeUsersResponse.PageNumber = context.IntegerValue("DescribeUsers.PageNumber");
			describeUsersResponse.DynamicCode = context.StringValue("DescribeUsers.DynamicCode");
			describeUsersResponse.Code = context.StringValue("DescribeUsers.Code");
			describeUsersResponse.TotalCount = context.IntegerValue("DescribeUsers.TotalCount");
			describeUsersResponse.DynamicMessage = context.StringValue("DescribeUsers.DynamicMessage");
			describeUsersResponse.RequestId = context.StringValue("DescribeUsers.RequestId");
			describeUsersResponse.Success = context.BooleanValue("DescribeUsers.Success");
			describeUsersResponse.PageSize = context.IntegerValue("DescribeUsers.PageSize");

			List<DescribeUsersResponse.DescribeUsers_UserInfo> describeUsersResponse_users = new List<DescribeUsersResponse.DescribeUsers_UserInfo>();
			for (int i = 0; i < context.Length("DescribeUsers.Users.Length"); i++) {
				DescribeUsersResponse.DescribeUsers_UserInfo userInfo = new DescribeUsersResponse.DescribeUsers_UserInfo();
				userInfo.Stores = context.StringValue("DescribeUsers.Users["+ i +"].Stores");
				userInfo.UserName = context.StringValue("DescribeUsers.Users["+ i +"].UserName");
				userInfo.UserId = context.StringValue("DescribeUsers.Users["+ i +"].UserId");
				userInfo.UserType = context.StringValue("DescribeUsers.Users["+ i +"].UserType");

				describeUsersResponse_users.Add(userInfo);
			}
			describeUsersResponse.Users = describeUsersResponse_users;
        
			return describeUsersResponse;
        }
    }
}
