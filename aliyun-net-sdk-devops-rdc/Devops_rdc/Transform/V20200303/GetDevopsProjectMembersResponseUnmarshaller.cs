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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class GetDevopsProjectMembersResponseUnmarshaller
    {
        public static GetDevopsProjectMembersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDevopsProjectMembersResponse getDevopsProjectMembersResponse = new GetDevopsProjectMembersResponse();

			getDevopsProjectMembersResponse.HttpResponse = _ctx.HttpResponse;
			getDevopsProjectMembersResponse.Successful = _ctx.BooleanValue("GetDevopsProjectMembers.Successful");
			getDevopsProjectMembersResponse.ErrorCode = _ctx.StringValue("GetDevopsProjectMembers.ErrorCode");
			getDevopsProjectMembersResponse.ErrorMsg = _ctx.StringValue("GetDevopsProjectMembers.ErrorMsg");
			getDevopsProjectMembersResponse.RequestId = _ctx.StringValue("GetDevopsProjectMembers.RequestId");
			getDevopsProjectMembersResponse.Total = _ctx.IntegerValue("GetDevopsProjectMembers.Total");
			getDevopsProjectMembersResponse.NextPageToken = _ctx.StringValue("GetDevopsProjectMembers.NextPageToken");

			List<GetDevopsProjectMembersResponse.GetDevopsProjectMembers_Member> getDevopsProjectMembersResponse_object = new List<GetDevopsProjectMembersResponse.GetDevopsProjectMembers_Member>();
			for (int i = 0; i < _ctx.Length("GetDevopsProjectMembers.Object.Length"); i++) {
				GetDevopsProjectMembersResponse.GetDevopsProjectMembers_Member member = new GetDevopsProjectMembersResponse.GetDevopsProjectMembers_Member();
				member.MemberId = _ctx.StringValue("GetDevopsProjectMembers.Object["+ i +"].MemberId");
				member.UserId = _ctx.StringValue("GetDevopsProjectMembers.Object["+ i +"].UserId");
				member.Role = _ctx.IntegerValue("GetDevopsProjectMembers.Object["+ i +"].Role");
				member.Name = _ctx.StringValue("GetDevopsProjectMembers.Object["+ i +"].Name");
				member.AvatarUrl = _ctx.StringValue("GetDevopsProjectMembers.Object["+ i +"].AvatarUrl");
				member.Email = _ctx.StringValue("GetDevopsProjectMembers.Object["+ i +"].Email");
				member.Phone = _ctx.StringValue("GetDevopsProjectMembers.Object["+ i +"].Phone");

				getDevopsProjectMembersResponse_object.Add(member);
			}
			getDevopsProjectMembersResponse._Object = getDevopsProjectMembersResponse_object;
        
			return getDevopsProjectMembersResponse;
        }
    }
}
