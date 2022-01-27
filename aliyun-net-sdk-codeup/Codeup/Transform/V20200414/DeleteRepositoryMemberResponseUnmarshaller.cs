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
    public class DeleteRepositoryMemberResponseUnmarshaller
    {
        public static DeleteRepositoryMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteRepositoryMemberResponse deleteRepositoryMemberResponse = new DeleteRepositoryMemberResponse();

			deleteRepositoryMemberResponse.HttpResponse = _ctx.HttpResponse;
			deleteRepositoryMemberResponse.RequestId = _ctx.StringValue("DeleteRepositoryMember.RequestId");
			deleteRepositoryMemberResponse.ErrorCode = _ctx.StringValue("DeleteRepositoryMember.ErrorCode");
			deleteRepositoryMemberResponse.Success = _ctx.BooleanValue("DeleteRepositoryMember.Success");
			deleteRepositoryMemberResponse.ErrorMessage = _ctx.StringValue("DeleteRepositoryMember.ErrorMessage");

			DeleteRepositoryMemberResponse.DeleteRepositoryMember_Result result = new DeleteRepositoryMemberResponse.DeleteRepositoryMember_Result();
			result.AccessLevel = _ctx.IntegerValue("DeleteRepositoryMember.Result.AccessLevel");
			result.Id = _ctx.LongValue("DeleteRepositoryMember.Result.Id");
			result.CreatedAt = _ctx.StringValue("DeleteRepositoryMember.Result.CreatedAt");
			result.UpdatedAt = _ctx.StringValue("DeleteRepositoryMember.Result.UpdatedAt");
			result.SourceId = _ctx.LongValue("DeleteRepositoryMember.Result.SourceId");
			result.SourceType = _ctx.StringValue("DeleteRepositoryMember.Result.SourceType");
			result.UserId = _ctx.LongValue("DeleteRepositoryMember.Result.UserId");
			result.NotificationLevel = _ctx.IntegerValue("DeleteRepositoryMember.Result.NotificationLevel");
			result.Message = _ctx.StringValue("DeleteRepositoryMember.Result.Message");
			deleteRepositoryMemberResponse.Result = result;
        
			return deleteRepositoryMemberResponse;
        }
    }
}
