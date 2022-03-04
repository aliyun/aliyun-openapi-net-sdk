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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class ListUserGroupsByUserIdResponseUnmarshaller
    {
        public static ListUserGroupsByUserIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserGroupsByUserIdResponse listUserGroupsByUserIdResponse = new ListUserGroupsByUserIdResponse();

			listUserGroupsByUserIdResponse.HttpResponse = _ctx.HttpResponse;
			listUserGroupsByUserIdResponse.Success = _ctx.BooleanValue("ListUserGroupsByUserId.Success");
			listUserGroupsByUserIdResponse.RequestId = _ctx.StringValue("ListUserGroupsByUserId.RequestId");

			List<ListUserGroupsByUserIdResponse.ListUserGroupsByUserId_Data> listUserGroupsByUserIdResponse_result = new List<ListUserGroupsByUserIdResponse.ListUserGroupsByUserId_Data>();
			for (int i = 0; i < _ctx.Length("ListUserGroupsByUserId.Result.Length"); i++) {
				ListUserGroupsByUserIdResponse.ListUserGroupsByUserId_Data data = new ListUserGroupsByUserIdResponse.ListUserGroupsByUserId_Data();
				data.IdentifiedPath = _ctx.StringValue("ListUserGroupsByUserId.Result["+ i +"].IdentifiedPath");
				data.ParentUsergroupId = _ctx.StringValue("ListUserGroupsByUserId.Result["+ i +"].ParentUsergroupId");
				data.ModifiedTime = _ctx.StringValue("ListUserGroupsByUserId.Result["+ i +"].ModifiedTime");
				data.CreateUser = _ctx.StringValue("ListUserGroupsByUserId.Result["+ i +"].CreateUser");
				data.UsergroupName = _ctx.StringValue("ListUserGroupsByUserId.Result["+ i +"].UsergroupName");
				data.CreateTime = _ctx.StringValue("ListUserGroupsByUserId.Result["+ i +"].CreateTime");
				data.UsergroupDesc = _ctx.StringValue("ListUserGroupsByUserId.Result["+ i +"].UsergroupDesc");
				data.UsergroupId = _ctx.StringValue("ListUserGroupsByUserId.Result["+ i +"].UsergroupId");
				data.ModifyUser = _ctx.StringValue("ListUserGroupsByUserId.Result["+ i +"].ModifyUser");

				listUserGroupsByUserIdResponse_result.Add(data);
			}
			listUserGroupsByUserIdResponse.Result = listUserGroupsByUserIdResponse_result;
        
			return listUserGroupsByUserIdResponse;
        }
    }
}
