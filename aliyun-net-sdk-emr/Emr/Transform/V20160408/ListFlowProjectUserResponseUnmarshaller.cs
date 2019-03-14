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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListFlowProjectUserResponseUnmarshaller
    {
        public static ListFlowProjectUserResponse Unmarshall(UnmarshallerContext context)
        {
			ListFlowProjectUserResponse listFlowProjectUserResponse = new ListFlowProjectUserResponse();

			listFlowProjectUserResponse.HttpResponse = context.HttpResponse;
			listFlowProjectUserResponse.RequestId = context.StringValue("ListFlowProjectUser.RequestId");
			listFlowProjectUserResponse.PageNumber = context.IntegerValue("ListFlowProjectUser.PageNumber");
			listFlowProjectUserResponse.PageSize = context.IntegerValue("ListFlowProjectUser.PageSize");
			listFlowProjectUserResponse.Total = context.IntegerValue("ListFlowProjectUser.Total");

			List<ListFlowProjectUserResponse.ListFlowProjectUser_User> listFlowProjectUserResponse_users = new List<ListFlowProjectUserResponse.ListFlowProjectUser_User>();
			for (int i = 0; i < context.Length("ListFlowProjectUser.Users.Length"); i++) {
				ListFlowProjectUserResponse.ListFlowProjectUser_User user = new ListFlowProjectUserResponse.ListFlowProjectUser_User();
				user.GmtCreate = context.LongValue("ListFlowProjectUser.Users["+ i +"].GmtCreate");
				user.GmtModified = context.LongValue("ListFlowProjectUser.Users["+ i +"].GmtModified");
				user.ProjectId = context.StringValue("ListFlowProjectUser.Users["+ i +"].ProjectId");
				user.OwnerId = context.StringValue("ListFlowProjectUser.Users["+ i +"].OwnerId");
				user.UserName = context.StringValue("ListFlowProjectUser.Users["+ i +"].UserName");

				listFlowProjectUserResponse_users.Add(user);
			}
			listFlowProjectUserResponse.Users = listFlowProjectUserResponse_users;
        
			return listFlowProjectUserResponse;
        }
    }
}
