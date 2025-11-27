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
    public class QueryUserGroupMemberResponseUnmarshaller
    {
        public static QueryUserGroupMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryUserGroupMemberResponse queryUserGroupMemberResponse = new QueryUserGroupMemberResponse();

			queryUserGroupMemberResponse.HttpResponse = _ctx.HttpResponse;
			queryUserGroupMemberResponse.Success = _ctx.BooleanValue("QueryUserGroupMember.Success");
			queryUserGroupMemberResponse.RequestId = _ctx.StringValue("QueryUserGroupMember.RequestId");

			List<QueryUserGroupMemberResponse.QueryUserGroupMember_Data> queryUserGroupMemberResponse_result = new List<QueryUserGroupMemberResponse.QueryUserGroupMember_Data>();
			for (int i = 0; i < _ctx.Length("QueryUserGroupMember.Result.Length"); i++) {
				QueryUserGroupMemberResponse.QueryUserGroupMember_Data data = new QueryUserGroupMemberResponse.QueryUserGroupMember_Data();
				data.Id = _ctx.StringValue("QueryUserGroupMember.Result["+ i +"].Id");
				data.IsUserGroup = _ctx.BooleanValue("QueryUserGroupMember.Result["+ i +"].IsUserGroup");
				data.Name = _ctx.StringValue("QueryUserGroupMember.Result["+ i +"].Name");
				data.ParentUserGroupId = _ctx.StringValue("QueryUserGroupMember.Result["+ i +"].ParentUserGroupId");
				data.ParentUserGroupName = _ctx.StringValue("QueryUserGroupMember.Result["+ i +"].ParentUserGroupName");

				queryUserGroupMemberResponse_result.Add(data);
			}
			queryUserGroupMemberResponse.Result = queryUserGroupMemberResponse_result;
        
			return queryUserGroupMemberResponse;
        }
    }
}
