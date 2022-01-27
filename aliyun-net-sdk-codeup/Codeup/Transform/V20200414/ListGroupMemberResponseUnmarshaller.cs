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
    public class ListGroupMemberResponseUnmarshaller
    {
        public static ListGroupMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGroupMemberResponse listGroupMemberResponse = new ListGroupMemberResponse();

			listGroupMemberResponse.HttpResponse = _ctx.HttpResponse;
			listGroupMemberResponse.RequestId = _ctx.StringValue("ListGroupMember.RequestId");
			listGroupMemberResponse.ErrorCode = _ctx.StringValue("ListGroupMember.ErrorCode");
			listGroupMemberResponse.Success = _ctx.BooleanValue("ListGroupMember.Success");
			listGroupMemberResponse.ErrorMessage = _ctx.StringValue("ListGroupMember.ErrorMessage");
			listGroupMemberResponse.Total = _ctx.LongValue("ListGroupMember.Total");

			List<ListGroupMemberResponse.ListGroupMember_ResultItem> listGroupMemberResponse_result = new List<ListGroupMemberResponse.ListGroupMember_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListGroupMember.Result.Length"); i++) {
				ListGroupMemberResponse.ListGroupMember_ResultItem resultItem = new ListGroupMemberResponse.ListGroupMember_ResultItem();
				resultItem.AccessLevel = _ctx.IntegerValue("ListGroupMember.Result["+ i +"].AccessLevel");
				resultItem.ExternUserId = _ctx.StringValue("ListGroupMember.Result["+ i +"].ExternUserId");
				resultItem.Id = _ctx.LongValue("ListGroupMember.Result["+ i +"].Id");
				resultItem.State = _ctx.StringValue("ListGroupMember.Result["+ i +"].State");
				resultItem.AvatarUrl = _ctx.StringValue("ListGroupMember.Result["+ i +"].AvatarUrl");
				resultItem.Email = _ctx.StringValue("ListGroupMember.Result["+ i +"].Email");

				listGroupMemberResponse_result.Add(resultItem);
			}
			listGroupMemberResponse.Result = listGroupMemberResponse_result;
        
			return listGroupMemberResponse;
        }
    }
}
