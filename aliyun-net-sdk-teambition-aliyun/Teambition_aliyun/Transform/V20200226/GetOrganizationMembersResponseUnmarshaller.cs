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
using Aliyun.Acs.teambition_aliyun.Model.V20200226;

namespace Aliyun.Acs.teambition_aliyun.Transform.V20200226
{
    public class GetOrganizationMembersResponseUnmarshaller
    {
        public static GetOrganizationMembersResponse Unmarshall(UnmarshallerContext context)
        {
			GetOrganizationMembersResponse getOrganizationMembersResponse = new GetOrganizationMembersResponse();

			getOrganizationMembersResponse.HttpResponse = context.HttpResponse;
			getOrganizationMembersResponse.Successful = context.BooleanValue("GetOrganizationMembers.Successful");
			getOrganizationMembersResponse.ErrorCode = context.StringValue("GetOrganizationMembers.ErrorCode");
			getOrganizationMembersResponse.ErrorMsg = context.StringValue("GetOrganizationMembers.ErrorMsg");
			getOrganizationMembersResponse.RequestId = context.StringValue("GetOrganizationMembers.RequestId");

			List<GetOrganizationMembersResponse.GetOrganizationMembers_Member> getOrganizationMembersResponse_object = new List<GetOrganizationMembersResponse.GetOrganizationMembers_Member>();
			for (int i = 0; i < context.Length("GetOrganizationMembers.Object.Length"); i++) {
				GetOrganizationMembersResponse.GetOrganizationMembers_Member member = new GetOrganizationMembersResponse.GetOrganizationMembers_Member();
				member.MemberId = context.StringValue("GetOrganizationMembers.Object["+ i +"].MemberId");
				member.UserId = context.StringValue("GetOrganizationMembers.Object["+ i +"].UserId");
				member.Role = context.IntegerValue("GetOrganizationMembers.Object["+ i +"].Role");
				member.Name = context.StringValue("GetOrganizationMembers.Object["+ i +"].Name");
				member.AvatarUrl = context.StringValue("GetOrganizationMembers.Object["+ i +"].AvatarUrl");
				member.Email = context.StringValue("GetOrganizationMembers.Object["+ i +"].Email");
				member.Phone = context.StringValue("GetOrganizationMembers.Object["+ i +"].Phone");

				getOrganizationMembersResponse_object.Add(member);
			}
			getOrganizationMembersResponse._Object = getOrganizationMembersResponse_object;
        
			return getOrganizationMembersResponse;
        }
    }
}
