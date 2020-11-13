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
    public class ListRepositoryMemberResponseUnmarshaller
    {
        public static ListRepositoryMemberResponse Unmarshall(UnmarshallerContext context)
        {
			ListRepositoryMemberResponse listRepositoryMemberResponse = new ListRepositoryMemberResponse();

			listRepositoryMemberResponse.HttpResponse = context.HttpResponse;
			listRepositoryMemberResponse.RequestId = context.StringValue("ListRepositoryMember.RequestId");
			listRepositoryMemberResponse.ErrorCode = context.StringValue("ListRepositoryMember.ErrorCode");
			listRepositoryMemberResponse.Success = context.BooleanValue("ListRepositoryMember.Success");
			listRepositoryMemberResponse.ErrorMessage = context.StringValue("ListRepositoryMember.ErrorMessage");
			listRepositoryMemberResponse.Total = context.LongValue("ListRepositoryMember.Total");

			List<ListRepositoryMemberResponse.ListRepositoryMember_ResultItem> listRepositoryMemberResponse_result = new List<ListRepositoryMemberResponse.ListRepositoryMember_ResultItem>();
			for (int i = 0; i < context.Length("ListRepositoryMember.Result.Length"); i++) {
				ListRepositoryMemberResponse.ListRepositoryMember_ResultItem resultItem = new ListRepositoryMemberResponse.ListRepositoryMember_ResultItem();
				resultItem.AccessLevel = context.IntegerValue("ListRepositoryMember.Result["+ i +"].AccessLevel");
				resultItem.ExternUserId = context.StringValue("ListRepositoryMember.Result["+ i +"].ExternUserId");
				resultItem.Id = context.LongValue("ListRepositoryMember.Result["+ i +"].Id");
				resultItem.State = context.StringValue("ListRepositoryMember.Result["+ i +"].State");
				resultItem.AvatarUrl = context.StringValue("ListRepositoryMember.Result["+ i +"].AvatarUrl");
				resultItem.Email = context.StringValue("ListRepositoryMember.Result["+ i +"].Email");

				listRepositoryMemberResponse_result.Add(resultItem);
			}
			listRepositoryMemberResponse.Result = listRepositoryMemberResponse_result;
        
			return listRepositoryMemberResponse;
        }
    }
}
