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
    public class ListMemberAuthorizedBizChainResponseUnmarshaller
    {
        public static ListMemberAuthorizedBizChainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMemberAuthorizedBizChainResponse listMemberAuthorizedBizChainResponse = new ListMemberAuthorizedBizChainResponse();

			listMemberAuthorizedBizChainResponse.HttpResponse = _ctx.HttpResponse;
			listMemberAuthorizedBizChainResponse.Code = _ctx.StringValue("ListMemberAuthorizedBizChain.Code");
			listMemberAuthorizedBizChainResponse.HttpStatusCode = _ctx.IntegerValue("ListMemberAuthorizedBizChain.HttpStatusCode");
			listMemberAuthorizedBizChainResponse.Message = _ctx.StringValue("ListMemberAuthorizedBizChain.Message");
			listMemberAuthorizedBizChainResponse.RequestId = _ctx.StringValue("ListMemberAuthorizedBizChain.RequestId");
			listMemberAuthorizedBizChainResponse.Success = _ctx.BooleanValue("ListMemberAuthorizedBizChain.Success");

			List<ListMemberAuthorizedBizChainResponse.ListMemberAuthorizedBizChain_MemberAuthorizedBizChainInfo> listMemberAuthorizedBizChainResponse_data = new List<ListMemberAuthorizedBizChainResponse.ListMemberAuthorizedBizChain_MemberAuthorizedBizChainInfo>();
			for (int i = 0; i < _ctx.Length("ListMemberAuthorizedBizChain.Data.Length"); i++) {
				ListMemberAuthorizedBizChainResponse.ListMemberAuthorizedBizChain_MemberAuthorizedBizChainInfo memberAuthorizedBizChainInfo = new ListMemberAuthorizedBizChainResponse.ListMemberAuthorizedBizChain_MemberAuthorizedBizChainInfo();
				memberAuthorizedBizChainInfo.BizChainType = _ctx.StringValue("ListMemberAuthorizedBizChain.Data["+ i +"].BizChainType");
				memberAuthorizedBizChainInfo.BizChainName = _ctx.StringValue("ListMemberAuthorizedBizChain.Data["+ i +"].BizChainName");
				memberAuthorizedBizChainInfo.BizChainId = _ctx.StringValue("ListMemberAuthorizedBizChain.Data["+ i +"].BizChainId");
				memberAuthorizedBizChainInfo.Authorized = _ctx.BooleanValue("ListMemberAuthorizedBizChain.Data["+ i +"].Authorized");

				List<ListMemberAuthorizedBizChainResponse.ListMemberAuthorizedBizChain_MemberAuthorizedBizChainInfo.ListMemberAuthorizedBizChain_PeerInfo> memberAuthorizedBizChainInfo_peerList = new List<ListMemberAuthorizedBizChainResponse.ListMemberAuthorizedBizChain_MemberAuthorizedBizChainInfo.ListMemberAuthorizedBizChain_PeerInfo>();
				for (int j = 0; j < _ctx.Length("ListMemberAuthorizedBizChain.Data["+ i +"].PeerList.Length"); j++) {
					ListMemberAuthorizedBizChainResponse.ListMemberAuthorizedBizChain_MemberAuthorizedBizChainInfo.ListMemberAuthorizedBizChain_PeerInfo peerInfo = new ListMemberAuthorizedBizChainResponse.ListMemberAuthorizedBizChain_MemberAuthorizedBizChainInfo.ListMemberAuthorizedBizChain_PeerInfo();
					peerInfo.PeerName = _ctx.StringValue("ListMemberAuthorizedBizChain.Data["+ i +"].PeerList["+ j +"].PeerName");
					peerInfo.Authorized = _ctx.BooleanValue("ListMemberAuthorizedBizChain.Data["+ i +"].PeerList["+ j +"].Authorized");

					memberAuthorizedBizChainInfo_peerList.Add(peerInfo);
				}
				memberAuthorizedBizChainInfo.PeerList = memberAuthorizedBizChainInfo_peerList;

				listMemberAuthorizedBizChainResponse_data.Add(memberAuthorizedBizChainInfo);
			}
			listMemberAuthorizedBizChainResponse.Data = listMemberAuthorizedBizChainResponse_data;
        
			return listMemberAuthorizedBizChainResponse;
        }
    }
}
