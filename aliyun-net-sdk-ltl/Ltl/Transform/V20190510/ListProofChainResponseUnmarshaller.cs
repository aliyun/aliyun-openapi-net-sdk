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
    public class ListProofChainResponseUnmarshaller
    {
        public static ListProofChainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProofChainResponse listProofChainResponse = new ListProofChainResponse();

			listProofChainResponse.HttpResponse = _ctx.HttpResponse;
			listProofChainResponse.Code = _ctx.IntegerValue("ListProofChain.Code");
			listProofChainResponse.Message = _ctx.StringValue("ListProofChain.Message");
			listProofChainResponse.RequestId = _ctx.StringValue("ListProofChain.RequestId");
			listProofChainResponse.Success = _ctx.BooleanValue("ListProofChain.Success");

			ListProofChainResponse.ListProofChain_Data data = new ListProofChainResponse.ListProofChain_Data();
			data.Num = _ctx.IntegerValue("ListProofChain.Data.Num");
			data.Total = _ctx.IntegerValue("ListProofChain.Data.Total");
			data.Size = _ctx.IntegerValue("ListProofChain.Data.Size");

			List<ListProofChainResponse.ListProofChain_Data.ListProofChain_ProofChainInfo> data_pageData = new List<ListProofChainResponse.ListProofChain_Data.ListProofChain_ProofChainInfo>();
			for (int i = 0; i < _ctx.Length("ListProofChain.Data.PageData.Length"); i++) {
				ListProofChainResponse.ListProofChain_Data.ListProofChain_ProofChainInfo proofChainInfo = new ListProofChainResponse.ListProofChain_Data.ListProofChain_ProofChainInfo();
				proofChainInfo.Remark = _ctx.StringValue("ListProofChain.Data.PageData["+ i +"].Remark");
				proofChainInfo.BizChainId = _ctx.StringValue("ListProofChain.Data.PageData["+ i +"].BizChainId");
				proofChainInfo.RoleType = _ctx.StringValue("ListProofChain.Data.PageData["+ i +"].RoleType");
				proofChainInfo.BizChainCode = _ctx.StringValue("ListProofChain.Data.PageData["+ i +"].BizChainCode");
				proofChainInfo.Name = _ctx.StringValue("ListProofChain.Data.PageData["+ i +"].Name");
				proofChainInfo.DataTypeCode = _ctx.StringValue("ListProofChain.Data.PageData["+ i +"].DataTypeCode");

				data_pageData.Add(proofChainInfo);
			}
			data.PageData = data_pageData;
			listProofChainResponse.Data = data;
        
			return listProofChainResponse;
        }
    }
}
