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
using Aliyun.Acs.quickbi_public.Model.V20200731;

namespace Aliyun.Acs.quickbi_public.Transform.V20200731
{
    public class GetUserGroupInfoResponseUnmarshaller
    {
        public static GetUserGroupInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserGroupInfoResponse getUserGroupInfoResponse = new GetUserGroupInfoResponse();

			getUserGroupInfoResponse.HttpResponse = _ctx.HttpResponse;
			getUserGroupInfoResponse.RequestId = _ctx.StringValue("GetUserGroupInfo.RequestId");
			getUserGroupInfoResponse.Success = _ctx.BooleanValue("GetUserGroupInfo.Success");

			List<GetUserGroupInfoResponse.GetUserGroupInfo_Data> getUserGroupInfoResponse_result = new List<GetUserGroupInfoResponse.GetUserGroupInfo_Data>();
			for (int i = 0; i < _ctx.Length("GetUserGroupInfo.Result.Length"); i++) {
				GetUserGroupInfoResponse.GetUserGroupInfo_Data data = new GetUserGroupInfoResponse.GetUserGroupInfo_Data();
				data.UsergroupId = _ctx.StringValue("GetUserGroupInfo.Result["+ i +"].UsergroupId");
				data.UsergroupName = _ctx.StringValue("GetUserGroupInfo.Result["+ i +"].UsergroupName");
				data.UsergroupDesc = _ctx.StringValue("GetUserGroupInfo.Result["+ i +"].UsergroupDesc");
				data.ParentUsergroupId = _ctx.StringValue("GetUserGroupInfo.Result["+ i +"].ParentUsergroupId");
				data.IdentifiedPath = _ctx.StringValue("GetUserGroupInfo.Result["+ i +"].IdentifiedPath");
				data.CreateUser = _ctx.StringValue("GetUserGroupInfo.Result["+ i +"].CreateUser");
				data.ModifyUser = _ctx.StringValue("GetUserGroupInfo.Result["+ i +"].ModifyUser");
				data.CreateTime = _ctx.StringValue("GetUserGroupInfo.Result["+ i +"].CreateTime");
				data.ModifiedTime = _ctx.StringValue("GetUserGroupInfo.Result["+ i +"].ModifiedTime");

				getUserGroupInfoResponse_result.Add(data);
			}
			getUserGroupInfoResponse.Result = getUserGroupInfoResponse_result;
        
			return getUserGroupInfoResponse;
        }
    }
}
