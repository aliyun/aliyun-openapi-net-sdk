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
using Aliyun.Acs.ledgerdb.Model.V20191122;

namespace Aliyun.Acs.ledgerdb.Transform.V20191122
{
    public class ListMembersResponseUnmarshaller
    {
        public static ListMembersResponse Unmarshall(UnmarshallerContext context)
        {
			ListMembersResponse listMembersResponse = new ListMembersResponse();

			listMembersResponse.HttpResponse = context.HttpResponse;
			listMembersResponse.RequestId = context.StringValue("ListMembers.RequestId");
			listMembersResponse.NextToken = context.StringValue("ListMembers.NextToken");
			listMembersResponse.MaxResults = context.IntegerValue("ListMembers.MaxResults");

			List<ListMembersResponse.ListMembers_Member> listMembersResponse_members = new List<ListMembersResponse.ListMembers_Member>();
			for (int i = 0; i < context.Length("ListMembers.Members.Length"); i++) {
				ListMembersResponse.ListMembers_Member member = new ListMembersResponse.ListMembers_Member();
				member.LedgerId = context.StringValue("ListMembers.Members["+ i +"].LedgerId");
				member.MemberId = context.StringValue("ListMembers.Members["+ i +"].MemberId");
				member.AliUid = context.StringValue("ListMembers.Members["+ i +"].AliUid");
				member.KeyType = context.StringValue("ListMembers.Members["+ i +"].KeyType");
				member.PublicKey = context.StringValue("ListMembers.Members["+ i +"].PublicKey");
				member.Role = context.StringValue("ListMembers.Members["+ i +"].Role");
				member.State = context.StringValue("ListMembers.Members["+ i +"].State");
				member.CreateTime = context.LongValue("ListMembers.Members["+ i +"].CreateTime");
				member.UpdateTime = context.LongValue("ListMembers.Members["+ i +"].UpdateTime");

				listMembersResponse_members.Add(member);
			}
			listMembersResponse.Members = listMembersResponse_members;
        
			return listMembersResponse;
        }
    }
}
