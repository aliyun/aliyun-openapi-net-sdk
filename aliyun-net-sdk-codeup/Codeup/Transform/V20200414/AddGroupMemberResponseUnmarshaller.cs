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
        public static AddGroupMemberResponse Unmarshall(UnmarshallerContext context)
        {
			AddGroupMemberResponse addGroupMemberResponse = new AddGroupMemberResponse();

			addGroupMemberResponse.HttpResponse = context.HttpResponse;
			addGroupMemberResponse.RequestId = context.StringValue("AddGroupMember.RequestId");
			addGroupMemberResponse.ErrorCode = context.StringValue("AddGroupMember.ErrorCode");
			addGroupMemberResponse.Success = context.BooleanValue("AddGroupMember.Success");
			addGroupMemberResponse.ErrorMessage = context.StringValue("AddGroupMember.ErrorMessage");

			List<AddGroupMemberResponse.AddGroupMember_ResultItem> addGroupMemberResponse_result = new List<AddGroupMemberResponse.AddGroupMember_ResultItem>();
			for (int i = 0; i < context.Length("AddGroupMember.Result.Length"); i++) {
				AddGroupMemberResponse.AddGroupMember_ResultItem resultItem = new AddGroupMemberResponse.AddGroupMember_ResultItem();
				resultItem.AccessLevel = context.IntegerValue("AddGroupMember.Result["+ i +"].AccessLevel");
				resultItem.ExternUserId = context.StringValue("AddGroupMember.Result["+ i +"].ExternUserId");
				resultItem.Id = context.LongValue("AddGroupMember.Result["+ i +"].Id");
				resultItem.State = context.StringValue("AddGroupMember.Result["+ i +"].State");
				resultItem.AvatarUrl = context.StringValue("AddGroupMember.Result["+ i +"].AvatarUrl");
				resultItem.Email = context.StringValue("AddGroupMember.Result["+ i +"].Email");

				addGroupMemberResponse_result.Add(resultItem);
			}
			addGroupMemberResponse.Result = addGroupMemberResponse_result;
        
			return addGroupMemberResponse;
        }
    }
}
