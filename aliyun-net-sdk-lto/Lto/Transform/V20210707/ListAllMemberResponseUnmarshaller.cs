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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class ListAllMemberResponseUnmarshaller
    {
        public static ListAllMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAllMemberResponse listAllMemberResponse = new ListAllMemberResponse();

			listAllMemberResponse.HttpResponse = _ctx.HttpResponse;
			listAllMemberResponse.Code = _ctx.StringValue("ListAllMember.Code");
			listAllMemberResponse.HttpStatusCode = _ctx.IntegerValue("ListAllMember.HttpStatusCode");
			listAllMemberResponse.Message = _ctx.StringValue("ListAllMember.Message");
			listAllMemberResponse.RequestId = _ctx.StringValue("ListAllMember.RequestId");
			listAllMemberResponse.Success = _ctx.BooleanValue("ListAllMember.Success");

			List<ListAllMemberResponse.ListAllMember_MemberInfo> listAllMemberResponse_data = new List<ListAllMemberResponse.ListAllMember_MemberInfo>();
			for (int i = 0; i < _ctx.Length("ListAllMember.Data.Length"); i++) {
				ListAllMemberResponse.ListAllMember_MemberInfo memberInfo = new ListAllMemberResponse.ListAllMember_MemberInfo();
				memberInfo.Name = _ctx.StringValue("ListAllMember.Data["+ i +"].Name");
				memberInfo.MemberId = _ctx.StringValue("ListAllMember.Data["+ i +"].MemberId");

				listAllMemberResponse_data.Add(memberInfo);
			}
			listAllMemberResponse.Data = listAllMemberResponse_data;
        
			return listAllMemberResponse;
        }
    }
}
