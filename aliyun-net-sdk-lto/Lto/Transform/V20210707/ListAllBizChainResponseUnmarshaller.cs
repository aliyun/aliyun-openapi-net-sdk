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
    public class ListAllBizChainResponseUnmarshaller
    {
        public static ListAllBizChainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAllBizChainResponse listAllBizChainResponse = new ListAllBizChainResponse();

			listAllBizChainResponse.HttpResponse = _ctx.HttpResponse;
			listAllBizChainResponse.Code = _ctx.StringValue("ListAllBizChain.Code");
			listAllBizChainResponse.HttpStatusCode = _ctx.IntegerValue("ListAllBizChain.HttpStatusCode");
			listAllBizChainResponse.Message = _ctx.StringValue("ListAllBizChain.Message");
			listAllBizChainResponse.RequestId = _ctx.StringValue("ListAllBizChain.RequestId");
			listAllBizChainResponse.Success = _ctx.BooleanValue("ListAllBizChain.Success");

			List<ListAllBizChainResponse.ListAllBizChain_BizChainInfo> listAllBizChainResponse_data = new List<ListAllBizChainResponse.ListAllBizChain_BizChainInfo>();
			for (int i = 0; i < _ctx.Length("ListAllBizChain.Data.Length"); i++) {
				ListAllBizChainResponse.ListAllBizChain_BizChainInfo bizChainInfo = new ListAllBizChainResponse.ListAllBizChain_BizChainInfo();
				bizChainInfo.UsedOnchainCount = _ctx.LongValue("ListAllBizChain.Data["+ i +"].UsedOnchainCount");
				bizChainInfo.Name = _ctx.StringValue("ListAllBizChain.Data["+ i +"].Name");
				bizChainInfo.BizChainId = _ctx.StringValue("ListAllBizChain.Data["+ i +"].BizChainId");

				listAllBizChainResponse_data.Add(bizChainInfo);
			}
			listAllBizChainResponse.Data = listAllBizChainResponse_data;
        
			return listAllBizChainResponse;
        }
    }
}
