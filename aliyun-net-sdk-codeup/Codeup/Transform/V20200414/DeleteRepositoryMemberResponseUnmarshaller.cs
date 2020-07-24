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
        public static DeleteRepositoryMemberResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteRepositoryMemberResponse deleteRepositoryMemberResponse = new DeleteRepositoryMemberResponse();

			deleteRepositoryMemberResponse.HttpResponse = context.HttpResponse;
			deleteRepositoryMemberResponse.RequestId = context.StringValue("DeleteRepositoryMember.RequestId");
			deleteRepositoryMemberResponse.ErrorCode = context.StringValue("DeleteRepositoryMember.ErrorCode");
			deleteRepositoryMemberResponse.Success = context.BooleanValue("DeleteRepositoryMember.Success");
			deleteRepositoryMemberResponse.ErrorMessage = context.StringValue("DeleteRepositoryMember.ErrorMessage");

			DeleteRepositoryMemberResponse.DeleteRepositoryMember_Result result = new DeleteRepositoryMemberResponse.DeleteRepositoryMember_Result();
			result.AccessLevel = context.IntegerValue("DeleteRepositoryMember.Result.AccessLevel");
			result.Id = context.LongValue("DeleteRepositoryMember.Result.Id");
			result.CreatedAt = context.StringValue("DeleteRepositoryMember.Result.CreatedAt");
			result.UpdatedAt = context.StringValue("DeleteRepositoryMember.Result.UpdatedAt");
			result.SourceId = context.LongValue("DeleteRepositoryMember.Result.SourceId");
			result.SourceType = context.StringValue("DeleteRepositoryMember.Result.SourceType");
			result.UserId = context.LongValue("DeleteRepositoryMember.Result.UserId");
			result.NotificationLevel = context.IntegerValue("DeleteRepositoryMember.Result.NotificationLevel");
			result.Message = context.StringValue("DeleteRepositoryMember.Result.Message");
			deleteRepositoryMemberResponse.Result = result;
        
			return deleteRepositoryMemberResponse;
        }
    }
}
