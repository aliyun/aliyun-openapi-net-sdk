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
        public static ListRepositoryMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRepositoryMemberResponse listRepositoryMemberResponse = new ListRepositoryMemberResponse();

			listRepositoryMemberResponse.HttpResponse = _ctx.HttpResponse;
			listRepositoryMemberResponse.RequestId = _ctx.StringValue("ListRepositoryMember.RequestId");
			listRepositoryMemberResponse.ErrorCode = _ctx.StringValue("ListRepositoryMember.ErrorCode");
			listRepositoryMemberResponse.Success = _ctx.BooleanValue("ListRepositoryMember.Success");
			listRepositoryMemberResponse.ErrorMessage = _ctx.StringValue("ListRepositoryMember.ErrorMessage");
			listRepositoryMemberResponse.Total = _ctx.LongValue("ListRepositoryMember.Total");

			List<ListRepositoryMemberResponse.ListRepositoryMember_ResultItem> listRepositoryMemberResponse_result = new List<ListRepositoryMemberResponse.ListRepositoryMember_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRepositoryMember.Result.Length"); i++) {
				ListRepositoryMemberResponse.ListRepositoryMember_ResultItem resultItem = new ListRepositoryMemberResponse.ListRepositoryMember_ResultItem();
				resultItem.AccessLevel = _ctx.IntegerValue("ListRepositoryMember.Result["+ i +"].AccessLevel");
				resultItem.ExternUserId = _ctx.StringValue("ListRepositoryMember.Result["+ i +"].ExternUserId");
				resultItem.Id = _ctx.LongValue("ListRepositoryMember.Result["+ i +"].Id");
				resultItem.State = _ctx.StringValue("ListRepositoryMember.Result["+ i +"].State");
				resultItem.AvatarUrl = _ctx.StringValue("ListRepositoryMember.Result["+ i +"].AvatarUrl");
				resultItem.Email = _ctx.StringValue("ListRepositoryMember.Result["+ i +"].Email");
				resultItem.Name = _ctx.StringValue("ListRepositoryMember.Result["+ i +"].Name");
				resultItem.Username = _ctx.StringValue("ListRepositoryMember.Result["+ i +"].Username");

				listRepositoryMemberResponse_result.Add(resultItem);
			}
			listRepositoryMemberResponse.Result = listRepositoryMemberResponse_result;
        
			return listRepositoryMemberResponse;
        }
    }
}
