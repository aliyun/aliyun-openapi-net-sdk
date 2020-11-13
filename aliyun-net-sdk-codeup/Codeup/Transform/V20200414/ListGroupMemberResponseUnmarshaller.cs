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
        public static ListGroupMemberResponse Unmarshall(UnmarshallerContext context)
        {
			ListGroupMemberResponse listGroupMemberResponse = new ListGroupMemberResponse();

			listGroupMemberResponse.HttpResponse = context.HttpResponse;
			listGroupMemberResponse.RequestId = context.StringValue("ListGroupMember.RequestId");
			listGroupMemberResponse.ErrorCode = context.StringValue("ListGroupMember.ErrorCode");
			listGroupMemberResponse.Success = context.BooleanValue("ListGroupMember.Success");
			listGroupMemberResponse.ErrorMessage = context.StringValue("ListGroupMember.ErrorMessage");
			listGroupMemberResponse.Total = context.LongValue("ListGroupMember.Total");

			List<ListGroupMemberResponse.ListGroupMember_ResultItem> listGroupMemberResponse_result = new List<ListGroupMemberResponse.ListGroupMember_ResultItem>();
			for (int i = 0; i < context.Length("ListGroupMember.Result.Length"); i++) {
				ListGroupMemberResponse.ListGroupMember_ResultItem resultItem = new ListGroupMemberResponse.ListGroupMember_ResultItem();
				resultItem.AccessLevel = context.IntegerValue("ListGroupMember.Result["+ i +"].AccessLevel");
				resultItem.ExternUserId = context.StringValue("ListGroupMember.Result["+ i +"].ExternUserId");
				resultItem.Id = context.LongValue("ListGroupMember.Result["+ i +"].Id");
				resultItem.State = context.StringValue("ListGroupMember.Result["+ i +"].State");
				resultItem.AvatarUrl = context.StringValue("ListGroupMember.Result["+ i +"].AvatarUrl");
				resultItem.Email = context.StringValue("ListGroupMember.Result["+ i +"].Email");

				listGroupMemberResponse_result.Add(resultItem);
			}
			listGroupMemberResponse.Result = listGroupMemberResponse_result;
        
			return listGroupMemberResponse;
        }
    }
}
