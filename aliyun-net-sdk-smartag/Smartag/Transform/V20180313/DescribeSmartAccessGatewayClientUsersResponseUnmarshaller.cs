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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeSmartAccessGatewayClientUsersResponseUnmarshaller
    {
        public static DescribeSmartAccessGatewayClientUsersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSmartAccessGatewayClientUsersResponse describeSmartAccessGatewayClientUsersResponse = new DescribeSmartAccessGatewayClientUsersResponse();

			describeSmartAccessGatewayClientUsersResponse.HttpResponse = context.HttpResponse;
			describeSmartAccessGatewayClientUsersResponse.RequestId = context.StringValue("DescribeSmartAccessGatewayClientUsers.RequestId");
			describeSmartAccessGatewayClientUsersResponse.TotalCount = context.IntegerValue("DescribeSmartAccessGatewayClientUsers.TotalCount");
			describeSmartAccessGatewayClientUsersResponse.PageNumber = context.IntegerValue("DescribeSmartAccessGatewayClientUsers.PageNumber");
			describeSmartAccessGatewayClientUsersResponse.PageSize = context.IntegerValue("DescribeSmartAccessGatewayClientUsers.PageSize");

			List<DescribeSmartAccessGatewayClientUsersResponse.DescribeSmartAccessGatewayClientUsers_User> describeSmartAccessGatewayClientUsersResponse_users = new List<DescribeSmartAccessGatewayClientUsersResponse.DescribeSmartAccessGatewayClientUsers_User>();
			for (int i = 0; i < context.Length("DescribeSmartAccessGatewayClientUsers.Users.Length"); i++) {
				DescribeSmartAccessGatewayClientUsersResponse.DescribeSmartAccessGatewayClientUsers_User user = new DescribeSmartAccessGatewayClientUsersResponse.DescribeSmartAccessGatewayClientUsers_User();
				user.ClientIp = context.StringValue("DescribeSmartAccessGatewayClientUsers.Users["+ i +"].ClientIp");
				user.UserMail = context.StringValue("DescribeSmartAccessGatewayClientUsers.Users["+ i +"].UserMail");
				user.UserName = context.StringValue("DescribeSmartAccessGatewayClientUsers.Users["+ i +"].UserName");
				user.Bandwidth = context.IntegerValue("DescribeSmartAccessGatewayClientUsers.Users["+ i +"].Bandwidth");
				user.State = context.IntegerValue("DescribeSmartAccessGatewayClientUsers.Users["+ i +"].State");

				describeSmartAccessGatewayClientUsersResponse_users.Add(user);
			}
			describeSmartAccessGatewayClientUsersResponse.Users = describeSmartAccessGatewayClientUsersResponse_users;
        
			return describeSmartAccessGatewayClientUsersResponse;
        }
    }
}
