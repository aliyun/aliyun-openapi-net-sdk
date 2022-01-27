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
        public static AddRepositoryMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddRepositoryMemberResponse addRepositoryMemberResponse = new AddRepositoryMemberResponse();

			addRepositoryMemberResponse.HttpResponse = _ctx.HttpResponse;
			addRepositoryMemberResponse.RequestId = _ctx.StringValue("AddRepositoryMember.RequestId");
			addRepositoryMemberResponse.ErrorCode = _ctx.StringValue("AddRepositoryMember.ErrorCode");
			addRepositoryMemberResponse.Success = _ctx.BooleanValue("AddRepositoryMember.Success");
			addRepositoryMemberResponse.ErrorMessage = _ctx.StringValue("AddRepositoryMember.ErrorMessage");

			List<AddRepositoryMemberResponse.AddRepositoryMember_ResultItem> addRepositoryMemberResponse_result = new List<AddRepositoryMemberResponse.AddRepositoryMember_ResultItem>();
			for (int i = 0; i < _ctx.Length("AddRepositoryMember.Result.Length"); i++) {
				AddRepositoryMemberResponse.AddRepositoryMember_ResultItem resultItem = new AddRepositoryMemberResponse.AddRepositoryMember_ResultItem();
				resultItem.AccessLevel = _ctx.IntegerValue("AddRepositoryMember.Result["+ i +"].AccessLevel");
				resultItem.ExternUserId = _ctx.StringValue("AddRepositoryMember.Result["+ i +"].ExternUserId");
				resultItem.Id = _ctx.LongValue("AddRepositoryMember.Result["+ i +"].Id");
				resultItem.State = _ctx.StringValue("AddRepositoryMember.Result["+ i +"].State");
				resultItem.AvatarUrl = _ctx.StringValue("AddRepositoryMember.Result["+ i +"].AvatarUrl");
				resultItem.Email = _ctx.StringValue("AddRepositoryMember.Result["+ i +"].Email");

				addRepositoryMemberResponse_result.Add(resultItem);
			}
			addRepositoryMemberResponse.Result = addRepositoryMemberResponse_result;
        
			return addRepositoryMemberResponse;
        }
    }
}
