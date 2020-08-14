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
    public class GetProjectMembersResponseUnmarshaller
    {
        public static GetProjectMembersResponse Unmarshall(UnmarshallerContext context)
        {
			GetProjectMembersResponse getProjectMembersResponse = new GetProjectMembersResponse();

			getProjectMembersResponse.HttpResponse = context.HttpResponse;
			getProjectMembersResponse.Successful = context.BooleanValue("GetProjectMembers.Successful");
			getProjectMembersResponse.ErrorCode = context.StringValue("GetProjectMembers.ErrorCode");
			getProjectMembersResponse.ErrorMsg = context.StringValue("GetProjectMembers.ErrorMsg");
			getProjectMembersResponse.RequestId = context.StringValue("GetProjectMembers.RequestId");

			List<GetProjectMembersResponse.GetProjectMembers_Member> getProjectMembersResponse_object = new List<GetProjectMembersResponse.GetProjectMembers_Member>();
			for (int i = 0; i < context.Length("GetProjectMembers.Object.Length"); i++) {
				GetProjectMembersResponse.GetProjectMembers_Member member = new GetProjectMembersResponse.GetProjectMembers_Member();
				member.MemberId = context.StringValue("GetProjectMembers.Object["+ i +"].MemberId");
				member.UserId = context.StringValue("GetProjectMembers.Object["+ i +"].UserId");
				member.Role = context.IntegerValue("GetProjectMembers.Object["+ i +"].Role");
				member.Name = context.StringValue("GetProjectMembers.Object["+ i +"].Name");
				member.AvatarUrl = context.StringValue("GetProjectMembers.Object["+ i +"].AvatarUrl");
				member.Email = context.StringValue("GetProjectMembers.Object["+ i +"].Email");
				member.Phone = context.StringValue("GetProjectMembers.Object["+ i +"].Phone");

				getProjectMembersResponse_object.Add(member);
			}
			getProjectMembersResponse._Object = getProjectMembersResponse_object;
        
			return getProjectMembersResponse;
        }
    }
}
