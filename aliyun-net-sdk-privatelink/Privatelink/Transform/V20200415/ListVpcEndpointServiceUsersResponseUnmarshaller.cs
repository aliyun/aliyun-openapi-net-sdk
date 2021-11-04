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
using Aliyun.Acs.Privatelink.Model.V20200415;

namespace Aliyun.Acs.Privatelink.Transform.V20200415
{
    public class ListVpcEndpointServiceUsersResponseUnmarshaller
    {
        public static ListVpcEndpointServiceUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpcEndpointServiceUsersResponse listVpcEndpointServiceUsersResponse = new ListVpcEndpointServiceUsersResponse();

			listVpcEndpointServiceUsersResponse.HttpResponse = _ctx.HttpResponse;
			listVpcEndpointServiceUsersResponse.NextToken = _ctx.StringValue("ListVpcEndpointServiceUsers.NextToken");
			listVpcEndpointServiceUsersResponse.RequestId = _ctx.StringValue("ListVpcEndpointServiceUsers.RequestId");
			listVpcEndpointServiceUsersResponse.MaxResults = _ctx.StringValue("ListVpcEndpointServiceUsers.MaxResults");

			List<ListVpcEndpointServiceUsersResponse.ListVpcEndpointServiceUsers_User> listVpcEndpointServiceUsersResponse_users = new List<ListVpcEndpointServiceUsersResponse.ListVpcEndpointServiceUsers_User>();
			for (int i = 0; i < _ctx.Length("ListVpcEndpointServiceUsers.Users.Length"); i++) {
				ListVpcEndpointServiceUsersResponse.ListVpcEndpointServiceUsers_User user = new ListVpcEndpointServiceUsersResponse.ListVpcEndpointServiceUsers_User();
				user.UserId = _ctx.LongValue("ListVpcEndpointServiceUsers.Users["+ i +"].UserId");

				listVpcEndpointServiceUsersResponse_users.Add(user);
			}
			listVpcEndpointServiceUsersResponse.Users = listVpcEndpointServiceUsersResponse_users;
        
			return listVpcEndpointServiceUsersResponse;
        }
    }
}
