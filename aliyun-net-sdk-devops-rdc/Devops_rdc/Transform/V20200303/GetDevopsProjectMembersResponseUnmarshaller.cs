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
        public static GetDevopsProjectMembersResponse Unmarshall(UnmarshallerContext context)
        {
			GetDevopsProjectMembersResponse getDevopsProjectMembersResponse = new GetDevopsProjectMembersResponse();

			getDevopsProjectMembersResponse.HttpResponse = context.HttpResponse;
			getDevopsProjectMembersResponse.Successful = context.BooleanValue("GetDevopsProjectMembers.Successful");
			getDevopsProjectMembersResponse.ErrorCode = context.StringValue("GetDevopsProjectMembers.ErrorCode");
			getDevopsProjectMembersResponse.ErrorMsg = context.StringValue("GetDevopsProjectMembers.ErrorMsg");
			getDevopsProjectMembersResponse.RequestId = context.StringValue("GetDevopsProjectMembers.RequestId");

			List<GetDevopsProjectMembersResponse.GetDevopsProjectMembers_Member> getDevopsProjectMembersResponse_object = new List<GetDevopsProjectMembersResponse.GetDevopsProjectMembers_Member>();
			for (int i = 0; i < context.Length("GetDevopsProjectMembers.Object.Length"); i++) {
				GetDevopsProjectMembersResponse.GetDevopsProjectMembers_Member member = new GetDevopsProjectMembersResponse.GetDevopsProjectMembers_Member();
				member.MemberId = context.StringValue("GetDevopsProjectMembers.Object["+ i +"].MemberId");
				member.UserId = context.StringValue("GetDevopsProjectMembers.Object["+ i +"].UserId");
				member.Role = context.IntegerValue("GetDevopsProjectMembers.Object["+ i +"].Role");
				member.Name = context.StringValue("GetDevopsProjectMembers.Object["+ i +"].Name");
				member.AvatarUrl = context.StringValue("GetDevopsProjectMembers.Object["+ i +"].AvatarUrl");
				member.Email = context.StringValue("GetDevopsProjectMembers.Object["+ i +"].Email");
				member.Phone = context.StringValue("GetDevopsProjectMembers.Object["+ i +"].Phone");

				getDevopsProjectMembersResponse_object.Add(member);
			}
			getDevopsProjectMembersResponse._Object = getDevopsProjectMembersResponse_object;
        
			return getDevopsProjectMembersResponse;
        }
    }
}
