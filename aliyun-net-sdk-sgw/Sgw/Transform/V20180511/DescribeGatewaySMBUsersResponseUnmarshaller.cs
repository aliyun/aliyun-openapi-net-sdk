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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeGatewaySMBUsersResponseUnmarshaller
    {
        public static DescribeGatewaySMBUsersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGatewaySMBUsersResponse describeGatewaySMBUsersResponse = new DescribeGatewaySMBUsersResponse();

			describeGatewaySMBUsersResponse.HttpResponse = context.HttpResponse;
			describeGatewaySMBUsersResponse.RequestId = context.StringValue("DescribeGatewaySMBUsers.RequestId");
			describeGatewaySMBUsersResponse.Success = context.BooleanValue("DescribeGatewaySMBUsers.Success");
			describeGatewaySMBUsersResponse.Code = context.StringValue("DescribeGatewaySMBUsers.Code");
			describeGatewaySMBUsersResponse.Message = context.StringValue("DescribeGatewaySMBUsers.Message");
			describeGatewaySMBUsersResponse.TotalCount = context.IntegerValue("DescribeGatewaySMBUsers.TotalCount");
			describeGatewaySMBUsersResponse.PageNumber = context.IntegerValue("DescribeGatewaySMBUsers.PageNumber");
			describeGatewaySMBUsersResponse.PageSize = context.IntegerValue("DescribeGatewaySMBUsers.PageSize");

			List<DescribeGatewaySMBUsersResponse.DescribeGatewaySMBUsers_User> describeGatewaySMBUsersResponse_users = new List<DescribeGatewaySMBUsersResponse.DescribeGatewaySMBUsers_User>();
			for (int i = 0; i < context.Length("DescribeGatewaySMBUsers.Users.Length"); i++) {
				DescribeGatewaySMBUsersResponse.DescribeGatewaySMBUsers_User user = new DescribeGatewaySMBUsersResponse.DescribeGatewaySMBUsers_User();
				user.Username = context.StringValue("DescribeGatewaySMBUsers.Users["+ i +"].Username");

				describeGatewaySMBUsersResponse_users.Add(user);
			}
			describeGatewaySMBUsersResponse.Users = describeGatewaySMBUsersResponse_users;
        
			return describeGatewaySMBUsersResponse;
        }
    }
}
