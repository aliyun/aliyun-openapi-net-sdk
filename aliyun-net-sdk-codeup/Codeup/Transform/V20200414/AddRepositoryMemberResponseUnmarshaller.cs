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
    public class AddRepositoryMemberResponseUnmarshaller
    {
        public static AddRepositoryMemberResponse Unmarshall(UnmarshallerContext context)
        {
			AddRepositoryMemberResponse addRepositoryMemberResponse = new AddRepositoryMemberResponse();

			addRepositoryMemberResponse.HttpResponse = context.HttpResponse;
			addRepositoryMemberResponse.RequestId = context.StringValue("AddRepositoryMember.RequestId");
			addRepositoryMemberResponse.ErrorCode = context.StringValue("AddRepositoryMember.ErrorCode");
			addRepositoryMemberResponse.Success = context.BooleanValue("AddRepositoryMember.Success");
			addRepositoryMemberResponse.ErrorMessage = context.StringValue("AddRepositoryMember.ErrorMessage");

			List<AddRepositoryMemberResponse.AddRepositoryMember_ResultItem> addRepositoryMemberResponse_result = new List<AddRepositoryMemberResponse.AddRepositoryMember_ResultItem>();
			for (int i = 0; i < context.Length("AddRepositoryMember.Result.Length"); i++) {
				AddRepositoryMemberResponse.AddRepositoryMember_ResultItem resultItem = new AddRepositoryMemberResponse.AddRepositoryMember_ResultItem();
				resultItem.AccessLevel = context.IntegerValue("AddRepositoryMember.Result["+ i +"].AccessLevel");
				resultItem.ExternUserId = context.StringValue("AddRepositoryMember.Result["+ i +"].ExternUserId");
				resultItem.Id = context.LongValue("AddRepositoryMember.Result["+ i +"].Id");
				resultItem.State = context.StringValue("AddRepositoryMember.Result["+ i +"].State");
				resultItem.AvatarUrl = context.StringValue("AddRepositoryMember.Result["+ i +"].AvatarUrl");
				resultItem.Email = context.StringValue("AddRepositoryMember.Result["+ i +"].Email");

				addRepositoryMemberResponse_result.Add(resultItem);
			}
			addRepositoryMemberResponse.Result = addRepositoryMemberResponse_result;
        
			return addRepositoryMemberResponse;
        }
    }
}
