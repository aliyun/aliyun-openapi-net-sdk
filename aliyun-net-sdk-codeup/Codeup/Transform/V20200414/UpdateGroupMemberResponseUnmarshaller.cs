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
    public class UpdateGroupMemberResponseUnmarshaller
    {
        public static UpdateGroupMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateGroupMemberResponse updateGroupMemberResponse = new UpdateGroupMemberResponse();

			updateGroupMemberResponse.HttpResponse = _ctx.HttpResponse;
			updateGroupMemberResponse.RequestId = _ctx.StringValue("UpdateGroupMember.RequestId");
			updateGroupMemberResponse.ErrorCode = _ctx.StringValue("UpdateGroupMember.ErrorCode");
			updateGroupMemberResponse.Success = _ctx.BooleanValue("UpdateGroupMember.Success");
			updateGroupMemberResponse.ErrorMessage = _ctx.StringValue("UpdateGroupMember.ErrorMessage");

			UpdateGroupMemberResponse.UpdateGroupMember_Result result = new UpdateGroupMemberResponse.UpdateGroupMember_Result();
			result.AccessLevel = _ctx.IntegerValue("UpdateGroupMember.Result.AccessLevel");
			result.ExternUserId = _ctx.StringValue("UpdateGroupMember.Result.ExternUserId");
			result.Id = _ctx.LongValue("UpdateGroupMember.Result.Id");
			result.State = _ctx.StringValue("UpdateGroupMember.Result.State");
			result.AvatarUrl = _ctx.StringValue("UpdateGroupMember.Result.AvatarUrl");
			result.Email = _ctx.StringValue("UpdateGroupMember.Result.Email");
			updateGroupMemberResponse.Result = result;
        
			return updateGroupMemberResponse;
        }
    }
}
