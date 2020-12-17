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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = _ctx.HttpResponse;
			listUsersResponse.RequestId = _ctx.StringValue("ListUsers.RequestId");
			listUsersResponse.Success = _ctx.BooleanValue("ListUsers.Success");
			listUsersResponse.Code = _ctx.StringValue("ListUsers.Code");
			listUsersResponse.Message = _ctx.StringValue("ListUsers.Message");
			listUsersResponse.PageNumber = _ctx.IntegerValue("ListUsers.PageNumber");
			listUsersResponse.PageSize = _ctx.IntegerValue("ListUsers.PageSize");
			listUsersResponse.Count = _ctx.IntegerValue("ListUsers.Count");

			List<ListUsersResponse.ListUsers_User> listUsersResponse_data = new List<ListUsersResponse.ListUsers_User>();
			for (int i = 0; i < _ctx.Length("ListUsers.Data.Length"); i++) {
				ListUsersResponse.ListUsers_User user = new ListUsersResponse.ListUsers_User();
				user.Id = _ctx.LongValue("ListUsers.Data["+ i +"].Id");
				user.UserName = _ctx.StringValue("ListUsers.Data["+ i +"].UserName");
				user.DisplayName = _ctx.StringValue("ListUsers.Data["+ i +"].DisplayName");
				user.CreateTime = _ctx.StringValue("ListUsers.Data["+ i +"].CreateTime");
				user.UpdateTime = _ctx.StringValue("ListUsers.Data["+ i +"].UpdateTime");
				user.Description = _ctx.StringValue("ListUsers.Data["+ i +"].Description");
				user.AliUid = _ctx.StringValue("ListUsers.Data["+ i +"].AliUid");
				user.RoleName = _ctx.StringValue("ListUsers.Data["+ i +"].RoleName");
				user.LoginUserType = _ctx.IntegerValue("ListUsers.Data["+ i +"].LoginUserType");

				listUsersResponse_data.Add(user);
			}
			listUsersResponse.Data = listUsersResponse_data;
        
			return listUsersResponse;
        }
    }
}
