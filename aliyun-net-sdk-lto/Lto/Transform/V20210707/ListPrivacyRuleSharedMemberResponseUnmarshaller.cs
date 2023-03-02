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
    public class ListPrivacyRuleSharedMemberResponseUnmarshaller
    {
        public static ListPrivacyRuleSharedMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPrivacyRuleSharedMemberResponse listPrivacyRuleSharedMemberResponse = new ListPrivacyRuleSharedMemberResponse();

			listPrivacyRuleSharedMemberResponse.HttpResponse = _ctx.HttpResponse;
			listPrivacyRuleSharedMemberResponse.Code = _ctx.StringValue("ListPrivacyRuleSharedMember.Code");
			listPrivacyRuleSharedMemberResponse.HttpStatusCode = _ctx.IntegerValue("ListPrivacyRuleSharedMember.HttpStatusCode");
			listPrivacyRuleSharedMemberResponse.Message = _ctx.StringValue("ListPrivacyRuleSharedMember.Message");
			listPrivacyRuleSharedMemberResponse.RequestId = _ctx.StringValue("ListPrivacyRuleSharedMember.RequestId");
			listPrivacyRuleSharedMemberResponse.Success = _ctx.BooleanValue("ListPrivacyRuleSharedMember.Success");

			List<ListPrivacyRuleSharedMemberResponse.ListPrivacyRuleSharedMember_BizChainInfo> listPrivacyRuleSharedMemberResponse_data = new List<ListPrivacyRuleSharedMemberResponse.ListPrivacyRuleSharedMember_BizChainInfo>();
			for (int i = 0; i < _ctx.Length("ListPrivacyRuleSharedMember.Data.Length"); i++) {
				ListPrivacyRuleSharedMemberResponse.ListPrivacyRuleSharedMember_BizChainInfo bizChainInfo = new ListPrivacyRuleSharedMemberResponse.ListPrivacyRuleSharedMember_BizChainInfo();
				bizChainInfo.BizChainId = _ctx.StringValue("ListPrivacyRuleSharedMember.Data["+ i +"].BizChainId");
				bizChainInfo.BizChainName = _ctx.StringValue("ListPrivacyRuleSharedMember.Data["+ i +"].BizChainName");

				List<ListPrivacyRuleSharedMemberResponse.ListPrivacyRuleSharedMember_BizChainInfo.ListPrivacyRuleSharedMember_MemberInfo> bizChainInfo_memberList = new List<ListPrivacyRuleSharedMemberResponse.ListPrivacyRuleSharedMember_BizChainInfo.ListPrivacyRuleSharedMember_MemberInfo>();
				for (int j = 0; j < _ctx.Length("ListPrivacyRuleSharedMember.Data["+ i +"].MemberList.Length"); j++) {
					ListPrivacyRuleSharedMemberResponse.ListPrivacyRuleSharedMember_BizChainInfo.ListPrivacyRuleSharedMember_MemberInfo memberInfo = new ListPrivacyRuleSharedMemberResponse.ListPrivacyRuleSharedMember_BizChainInfo.ListPrivacyRuleSharedMember_MemberInfo();
					memberInfo.Shared = _ctx.StringValue("ListPrivacyRuleSharedMember.Data["+ i +"].MemberList["+ j +"].Shared");
					memberInfo.MemberId = _ctx.StringValue("ListPrivacyRuleSharedMember.Data["+ i +"].MemberList["+ j +"].MemberId");
					memberInfo.MemberName = _ctx.StringValue("ListPrivacyRuleSharedMember.Data["+ i +"].MemberList["+ j +"].MemberName");

					bizChainInfo_memberList.Add(memberInfo);
				}
				bizChainInfo.MemberList = bizChainInfo_memberList;

				listPrivacyRuleSharedMemberResponse_data.Add(bizChainInfo);
			}
			listPrivacyRuleSharedMemberResponse.Data = listPrivacyRuleSharedMemberResponse_data;
        
			return listPrivacyRuleSharedMemberResponse;
        }
    }
}
