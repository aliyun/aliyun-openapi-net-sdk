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
        public static UpdateRepositoryMemberResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateRepositoryMemberResponse updateRepositoryMemberResponse = new UpdateRepositoryMemberResponse();

			updateRepositoryMemberResponse.HttpResponse = context.HttpResponse;
			updateRepositoryMemberResponse.RequestId = context.StringValue("UpdateRepositoryMember.RequestId");
			updateRepositoryMemberResponse.ErrorCode = context.StringValue("UpdateRepositoryMember.ErrorCode");
			updateRepositoryMemberResponse.Success = context.BooleanValue("UpdateRepositoryMember.Success");
			updateRepositoryMemberResponse.ErrorMessage = context.StringValue("UpdateRepositoryMember.ErrorMessage");

			UpdateRepositoryMemberResponse.UpdateRepositoryMember_Result result = new UpdateRepositoryMemberResponse.UpdateRepositoryMember_Result();
			result.AccessLevel = context.IntegerValue("UpdateRepositoryMember.Result.AccessLevel");
			result.ExternUserId = context.StringValue("UpdateRepositoryMember.Result.ExternUserId");
			result.Id = context.LongValue("UpdateRepositoryMember.Result.Id");
			result.State = context.StringValue("UpdateRepositoryMember.Result.State");
			result.AvatarUrl = context.StringValue("UpdateRepositoryMember.Result.AvatarUrl");
			result.Email = context.StringValue("UpdateRepositoryMember.Result.Email");
			updateRepositoryMemberResponse.Result = result;
        
			return updateRepositoryMemberResponse;
        }
    }
}
