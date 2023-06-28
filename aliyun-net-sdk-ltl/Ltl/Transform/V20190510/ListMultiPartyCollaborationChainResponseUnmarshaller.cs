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
    public class ListMultiPartyCollaborationChainResponseUnmarshaller
    {
        public static ListMultiPartyCollaborationChainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMultiPartyCollaborationChainResponse listMultiPartyCollaborationChainResponse = new ListMultiPartyCollaborationChainResponse();

			listMultiPartyCollaborationChainResponse.HttpResponse = _ctx.HttpResponse;
			listMultiPartyCollaborationChainResponse.Code = _ctx.IntegerValue("ListMultiPartyCollaborationChain.Code");
			listMultiPartyCollaborationChainResponse.Message = _ctx.StringValue("ListMultiPartyCollaborationChain.Message");
			listMultiPartyCollaborationChainResponse.RequestId = _ctx.StringValue("ListMultiPartyCollaborationChain.RequestId");
			listMultiPartyCollaborationChainResponse.Success = _ctx.BooleanValue("ListMultiPartyCollaborationChain.Success");

			ListMultiPartyCollaborationChainResponse.ListMultiPartyCollaborationChain_Data data = new ListMultiPartyCollaborationChainResponse.ListMultiPartyCollaborationChain_Data();
			data.Num = _ctx.IntegerValue("ListMultiPartyCollaborationChain.Data.Num");
			data.Total = _ctx.IntegerValue("ListMultiPartyCollaborationChain.Data.Total");
			data.Size = _ctx.IntegerValue("ListMultiPartyCollaborationChain.Data.Size");

			List<ListMultiPartyCollaborationChainResponse.ListMultiPartyCollaborationChain_Data.ListMultiPartyCollaborationChain_MultiPartyCollaborationChainInfo> data_pageData = new List<ListMultiPartyCollaborationChainResponse.ListMultiPartyCollaborationChain_Data.ListMultiPartyCollaborationChain_MultiPartyCollaborationChainInfo>();
			for (int i = 0; i < _ctx.Length("ListMultiPartyCollaborationChain.Data.PageData.Length"); i++) {
				ListMultiPartyCollaborationChainResponse.ListMultiPartyCollaborationChain_Data.ListMultiPartyCollaborationChain_MultiPartyCollaborationChainInfo multiPartyCollaborationChainInfo = new ListMultiPartyCollaborationChainResponse.ListMultiPartyCollaborationChain_Data.ListMultiPartyCollaborationChain_MultiPartyCollaborationChainInfo();
				multiPartyCollaborationChainInfo.Name = _ctx.StringValue("ListMultiPartyCollaborationChain.Data.PageData["+ i +"].Name");
				multiPartyCollaborationChainInfo.Remark = _ctx.StringValue("ListMultiPartyCollaborationChain.Data.PageData["+ i +"].Remark");
				multiPartyCollaborationChainInfo.RoleType = _ctx.StringValue("ListMultiPartyCollaborationChain.Data.PageData["+ i +"].RoleType");
				multiPartyCollaborationChainInfo.BizChainId = _ctx.StringValue("ListMultiPartyCollaborationChain.Data.PageData["+ i +"].BizChainId");

				data_pageData.Add(multiPartyCollaborationChainInfo);
			}
			data.PageData = data_pageData;
			listMultiPartyCollaborationChainResponse.Data = data;
        
			return listMultiPartyCollaborationChainResponse;
        }
    }
}
