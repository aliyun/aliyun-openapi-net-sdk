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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class ListMemberResponseUnmarshaller
    {
        public static ListMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMemberResponse listMemberResponse = new ListMemberResponse();

			listMemberResponse.HttpResponse = _ctx.HttpResponse;
			listMemberResponse.Code = _ctx.IntegerValue("ListMember.Code");
			listMemberResponse.Message = _ctx.StringValue("ListMember.Message");
			listMemberResponse.RequestId = _ctx.StringValue("ListMember.RequestId");
			listMemberResponse.Success = _ctx.BooleanValue("ListMember.Success");

			ListMemberResponse.ListMember_Data data = new ListMemberResponse.ListMember_Data();
			data.Num = _ctx.IntegerValue("ListMember.Data.Num");
			data.Total = _ctx.IntegerValue("ListMember.Data.Total");
			data.Size = _ctx.IntegerValue("ListMember.Data.Size");

			List<ListMemberResponse.ListMember_Data.ListMember_MemberInfo> data_pageData = new List<ListMemberResponse.ListMember_Data.ListMember_MemberInfo>();
			for (int i = 0; i < _ctx.Length("ListMember.Data.PageData.Length"); i++) {
				ListMemberResponse.ListMember_Data.ListMember_MemberInfo memberInfo = new ListMemberResponse.ListMember_Data.ListMember_MemberInfo();
				memberInfo.Status = _ctx.StringValue("ListMember.Data.PageData["+ i +"].Status");
				memberInfo.MemberName = _ctx.StringValue("ListMember.Data.PageData["+ i +"].MemberName");
				memberInfo.Remark = _ctx.StringValue("ListMember.Data.PageData["+ i +"].Remark");
				memberInfo.MemberUid = _ctx.StringValue("ListMember.Data.PageData["+ i +"].MemberUid");
				memberInfo.MemberPhone = _ctx.StringValue("ListMember.Data.PageData["+ i +"].MemberPhone");
				memberInfo.MemberId = _ctx.StringValue("ListMember.Data.PageData["+ i +"].MemberId");
				memberInfo.MemberContact = _ctx.StringValue("ListMember.Data.PageData["+ i +"].MemberContact");

				data_pageData.Add(memberInfo);
			}
			data.PageData = data_pageData;
			listMemberResponse.Data = data;
        
			return listMemberResponse;
        }
    }
}
