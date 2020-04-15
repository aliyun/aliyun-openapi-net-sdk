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
    public class DescribeUserOnlineClientsResponseUnmarshaller
    {
        public static DescribeUserOnlineClientsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserOnlineClientsResponse describeUserOnlineClientsResponse = new DescribeUserOnlineClientsResponse();

			describeUserOnlineClientsResponse.HttpResponse = context.HttpResponse;
			describeUserOnlineClientsResponse.RequestId = context.StringValue("DescribeUserOnlineClients.RequestId");

			List<DescribeUserOnlineClientsResponse.DescribeUserOnlineClients_User> describeUserOnlineClientsResponse_users = new List<DescribeUserOnlineClientsResponse.DescribeUserOnlineClients_User>();
			for (int i = 0; i < context.Length("DescribeUserOnlineClients.Users.Length"); i++) {
				DescribeUserOnlineClientsResponse.DescribeUserOnlineClients_User user = new DescribeUserOnlineClientsResponse.DescribeUserOnlineClients_User();
				user.ClientIp = context.StringValue("DescribeUserOnlineClients.Users["+ i +"].ClientIp");
				user.OnlineTime = context.StringValue("DescribeUserOnlineClients.Users["+ i +"].OnlineTime");

				describeUserOnlineClientsResponse_users.Add(user);
			}
			describeUserOnlineClientsResponse.Users = describeUserOnlineClientsResponse_users;
        
			return describeUserOnlineClientsResponse;
        }
    }
}
