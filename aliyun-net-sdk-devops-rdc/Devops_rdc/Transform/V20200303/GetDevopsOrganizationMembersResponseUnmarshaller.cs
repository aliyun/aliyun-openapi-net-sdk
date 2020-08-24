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
    public class GetDevopsOrganizationMembersResponseUnmarshaller
    {
        public static GetDevopsOrganizationMembersResponse Unmarshall(UnmarshallerContext context)
        {
			GetDevopsOrganizationMembersResponse getDevopsOrganizationMembersResponse = new GetDevopsOrganizationMembersResponse();

			getDevopsOrganizationMembersResponse.HttpResponse = context.HttpResponse;
			getDevopsOrganizationMembersResponse.Successful = context.BooleanValue("GetDevopsOrganizationMembers.Successful");
			getDevopsOrganizationMembersResponse.ErrorCode = context.StringValue("GetDevopsOrganizationMembers.ErrorCode");
			getDevopsOrganizationMembersResponse.ErrorMsg = context.StringValue("GetDevopsOrganizationMembers.ErrorMsg");
			getDevopsOrganizationMembersResponse.RequestId = context.StringValue("GetDevopsOrganizationMembers.RequestId");

			List<GetDevopsOrganizationMembersResponse.GetDevopsOrganizationMembers_Member> getDevopsOrganizationMembersResponse_object = new List<GetDevopsOrganizationMembersResponse.GetDevopsOrganizationMembers_Member>();
			for (int i = 0; i < context.Length("GetDevopsOrganizationMembers.Object.Length"); i++) {
				GetDevopsOrganizationMembersResponse.GetDevopsOrganizationMembers_Member member = new GetDevopsOrganizationMembersResponse.GetDevopsOrganizationMembers_Member();
				member.MemberId = context.StringValue("GetDevopsOrganizationMembers.Object["+ i +"].MemberId");
				member.UserId = context.StringValue("GetDevopsOrganizationMembers.Object["+ i +"].UserId");
				member.Role = context.IntegerValue("GetDevopsOrganizationMembers.Object["+ i +"].Role");
				member.Name = context.StringValue("GetDevopsOrganizationMembers.Object["+ i +"].Name");
				member.AvatarUrl = context.StringValue("GetDevopsOrganizationMembers.Object["+ i +"].AvatarUrl");
				member.Email = context.StringValue("GetDevopsOrganizationMembers.Object["+ i +"].Email");
				member.Phone = context.StringValue("GetDevopsOrganizationMembers.Object["+ i +"].Phone");

				getDevopsOrganizationMembersResponse_object.Add(member);
			}
			getDevopsOrganizationMembersResponse._Object = getDevopsOrganizationMembersResponse_object;
        
			return getDevopsOrganizationMembersResponse;
        }
    }
}
