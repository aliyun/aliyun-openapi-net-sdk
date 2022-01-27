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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class GetProjectMemberResponseUnmarshaller
    {
        public static GetProjectMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetProjectMemberResponse getProjectMemberResponse = new GetProjectMemberResponse();

			getProjectMemberResponse.HttpResponse = _ctx.HttpResponse;
			getProjectMemberResponse.RequestId = _ctx.StringValue("GetProjectMember.RequestId");
			getProjectMemberResponse.ErrorCode = _ctx.StringValue("GetProjectMember.ErrorCode");
			getProjectMemberResponse.Success = _ctx.BooleanValue("GetProjectMember.Success");
			getProjectMemberResponse.ErrorMessage = _ctx.StringValue("GetProjectMember.ErrorMessage");

			GetProjectMemberResponse.GetProjectMember_Result result = new GetProjectMemberResponse.GetProjectMember_Result();
			result.Id = _ctx.LongValue("GetProjectMember.Result.Id");
			result.ExternUserId = _ctx.StringValue("GetProjectMember.Result.ExternUserId");
			result.AvatarUrl = _ctx.StringValue("GetProjectMember.Result.AvatarUrl");
			result.Name = _ctx.StringValue("GetProjectMember.Result.Name");
			result.AccessLevel = _ctx.IntegerValue("GetProjectMember.Result.AccessLevel");
			getProjectMemberResponse.Result = result;
        
			return getProjectMemberResponse;
        }
    }
}
