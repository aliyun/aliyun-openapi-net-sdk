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
    public class DeleteGroupMemberResponseUnmarshaller
    {
        public static DeleteGroupMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteGroupMemberResponse deleteGroupMemberResponse = new DeleteGroupMemberResponse();

			deleteGroupMemberResponse.HttpResponse = _ctx.HttpResponse;
			deleteGroupMemberResponse.RequestId = _ctx.StringValue("DeleteGroupMember.RequestId");
			deleteGroupMemberResponse.ErrorCode = _ctx.StringValue("DeleteGroupMember.ErrorCode");
			deleteGroupMemberResponse.Success = _ctx.BooleanValue("DeleteGroupMember.Success");
			deleteGroupMemberResponse.ErrorMessage = _ctx.StringValue("DeleteGroupMember.ErrorMessage");

			DeleteGroupMemberResponse.DeleteGroupMember_Result result = new DeleteGroupMemberResponse.DeleteGroupMember_Result();
			result.AccessLevel = _ctx.IntegerValue("DeleteGroupMember.Result.AccessLevel");
			result.Id = _ctx.LongValue("DeleteGroupMember.Result.Id");
			result.ExternUserId = _ctx.StringValue("DeleteGroupMember.Result.ExternUserId");
			result.State = _ctx.StringValue("DeleteGroupMember.Result.State");
			result.AvatarUrl = _ctx.StringValue("DeleteGroupMember.Result.AvatarUrl");
			result.Email = _ctx.StringValue("DeleteGroupMember.Result.Email");
			deleteGroupMemberResponse.Result = result;
        
			return deleteGroupMemberResponse;
        }
    }
}
