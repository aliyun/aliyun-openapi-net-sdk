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
    public class AddGroupMemberResponseUnmarshaller
    {
        public static AddGroupMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddGroupMemberResponse addGroupMemberResponse = new AddGroupMemberResponse();

			addGroupMemberResponse.HttpResponse = _ctx.HttpResponse;
			addGroupMemberResponse.RequestId = _ctx.StringValue("AddGroupMember.RequestId");
			addGroupMemberResponse.ErrorCode = _ctx.StringValue("AddGroupMember.ErrorCode");
			addGroupMemberResponse.Success = _ctx.BooleanValue("AddGroupMember.Success");
			addGroupMemberResponse.ErrorMessage = _ctx.StringValue("AddGroupMember.ErrorMessage");

			List<AddGroupMemberResponse.AddGroupMember_ResultItem> addGroupMemberResponse_result = new List<AddGroupMemberResponse.AddGroupMember_ResultItem>();
			for (int i = 0; i < _ctx.Length("AddGroupMember.Result.Length"); i++) {
				AddGroupMemberResponse.AddGroupMember_ResultItem resultItem = new AddGroupMemberResponse.AddGroupMember_ResultItem();
				resultItem.AccessLevel = _ctx.IntegerValue("AddGroupMember.Result["+ i +"].AccessLevel");
				resultItem.ExternUserId = _ctx.StringValue("AddGroupMember.Result["+ i +"].ExternUserId");
				resultItem.Id = _ctx.LongValue("AddGroupMember.Result["+ i +"].Id");
				resultItem.State = _ctx.StringValue("AddGroupMember.Result["+ i +"].State");
				resultItem.AvatarUrl = _ctx.StringValue("AddGroupMember.Result["+ i +"].AvatarUrl");
				resultItem.Email = _ctx.StringValue("AddGroupMember.Result["+ i +"].Email");

				addGroupMemberResponse_result.Add(resultItem);
			}
			addGroupMemberResponse.Result = addGroupMemberResponse_result;
        
			return addGroupMemberResponse;
        }
    }
}
