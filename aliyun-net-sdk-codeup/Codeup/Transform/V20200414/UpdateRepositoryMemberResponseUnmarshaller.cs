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
    public class UpdateRepositoryMemberResponseUnmarshaller
    {
        public static UpdateRepositoryMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateRepositoryMemberResponse updateRepositoryMemberResponse = new UpdateRepositoryMemberResponse();

			updateRepositoryMemberResponse.HttpResponse = _ctx.HttpResponse;
			updateRepositoryMemberResponse.RequestId = _ctx.StringValue("UpdateRepositoryMember.RequestId");
			updateRepositoryMemberResponse.ErrorCode = _ctx.StringValue("UpdateRepositoryMember.ErrorCode");
			updateRepositoryMemberResponse.Success = _ctx.BooleanValue("UpdateRepositoryMember.Success");
			updateRepositoryMemberResponse.ErrorMessage = _ctx.StringValue("UpdateRepositoryMember.ErrorMessage");

			UpdateRepositoryMemberResponse.UpdateRepositoryMember_Result result = new UpdateRepositoryMemberResponse.UpdateRepositoryMember_Result();
			result.AccessLevel = _ctx.IntegerValue("UpdateRepositoryMember.Result.AccessLevel");
			result.ExternUserId = _ctx.StringValue("UpdateRepositoryMember.Result.ExternUserId");
			result.Id = _ctx.LongValue("UpdateRepositoryMember.Result.Id");
			result.State = _ctx.StringValue("UpdateRepositoryMember.Result.State");
			result.AvatarUrl = _ctx.StringValue("UpdateRepositoryMember.Result.AvatarUrl");
			result.Email = _ctx.StringValue("UpdateRepositoryMember.Result.Email");
			updateRepositoryMemberResponse.Result = result;
        
			return updateRepositoryMemberResponse;
        }
    }
}
