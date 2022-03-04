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
    public class QueryUserGroupListByParentIdResponseUnmarshaller
    {
        public static QueryUserGroupListByParentIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryUserGroupListByParentIdResponse queryUserGroupListByParentIdResponse = new QueryUserGroupListByParentIdResponse();

			queryUserGroupListByParentIdResponse.HttpResponse = _ctx.HttpResponse;
			queryUserGroupListByParentIdResponse.Success = _ctx.BooleanValue("QueryUserGroupListByParentId.Success");
			queryUserGroupListByParentIdResponse.RequestId = _ctx.StringValue("QueryUserGroupListByParentId.RequestId");

			List<QueryUserGroupListByParentIdResponse.QueryUserGroupListByParentId_Data> queryUserGroupListByParentIdResponse_result = new List<QueryUserGroupListByParentIdResponse.QueryUserGroupListByParentId_Data>();
			for (int i = 0; i < _ctx.Length("QueryUserGroupListByParentId.Result.Length"); i++) {
				QueryUserGroupListByParentIdResponse.QueryUserGroupListByParentId_Data data = new QueryUserGroupListByParentIdResponse.QueryUserGroupListByParentId_Data();
				data.IdentifiedPath = _ctx.StringValue("QueryUserGroupListByParentId.Result["+ i +"].IdentifiedPath");
				data.ModifiedTime = _ctx.StringValue("QueryUserGroupListByParentId.Result["+ i +"].ModifiedTime");
				data.CreateUser = _ctx.StringValue("QueryUserGroupListByParentId.Result["+ i +"].CreateUser");
				data.CreateTime = _ctx.StringValue("QueryUserGroupListByParentId.Result["+ i +"].CreateTime");
				data.UserGroupId = _ctx.StringValue("QueryUserGroupListByParentId.Result["+ i +"].UserGroupId");
				data.UserGroupName = _ctx.StringValue("QueryUserGroupListByParentId.Result["+ i +"].UserGroupName");
				data.ModifyUser = _ctx.StringValue("QueryUserGroupListByParentId.Result["+ i +"].ModifyUser");
				data.ParentUserGroupId = _ctx.StringValue("QueryUserGroupListByParentId.Result["+ i +"].ParentUserGroupId");
				data.UserGroupDescription = _ctx.StringValue("QueryUserGroupListByParentId.Result["+ i +"].UserGroupDescription");

				queryUserGroupListByParentIdResponse_result.Add(data);
			}
			queryUserGroupListByParentIdResponse.Result = queryUserGroupListByParentIdResponse_result;
        
			return queryUserGroupListByParentIdResponse;
        }
    }
}
