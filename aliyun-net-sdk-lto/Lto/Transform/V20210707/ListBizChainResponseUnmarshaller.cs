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
    public class ListBizChainResponseUnmarshaller
    {
        public static ListBizChainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBizChainResponse listBizChainResponse = new ListBizChainResponse();

			listBizChainResponse.HttpResponse = _ctx.HttpResponse;
			listBizChainResponse.Code = _ctx.StringValue("ListBizChain.Code");
			listBizChainResponse.HttpStatusCode = _ctx.IntegerValue("ListBizChain.HttpStatusCode");
			listBizChainResponse.Message = _ctx.StringValue("ListBizChain.Message");
			listBizChainResponse.RequestId = _ctx.StringValue("ListBizChain.RequestId");
			listBizChainResponse.Success = _ctx.BooleanValue("ListBizChain.Success");

			ListBizChainResponse.ListBizChain_Data data = new ListBizChainResponse.ListBizChain_Data();
			data.Num = _ctx.IntegerValue("ListBizChain.Data.Num");
			data.Total = _ctx.IntegerValue("ListBizChain.Data.Total");
			data.Size = _ctx.IntegerValue("ListBizChain.Data.Size");

			List<ListBizChainResponse.ListBizChain_Data.ListBizChain_BizChainInfo> data_pageData = new List<ListBizChainResponse.ListBizChain_Data.ListBizChain_BizChainInfo>();
			for (int i = 0; i < _ctx.Length("ListBizChain.Data.PageData.Length"); i++) {
				ListBizChainResponse.ListBizChain_Data.ListBizChain_BizChainInfo bizChainInfo = new ListBizChainResponse.ListBizChain_Data.ListBizChain_BizChainInfo();
				bizChainInfo.Type = _ctx.StringValue("ListBizChain.Data.PageData["+ i +"].Type");
				bizChainInfo.Remark = _ctx.StringValue("ListBizChain.Data.PageData["+ i +"].Remark");
				bizChainInfo.Name = _ctx.StringValue("ListBizChain.Data.PageData["+ i +"].Name");
				bizChainInfo.BizChainId = _ctx.StringValue("ListBizChain.Data.PageData["+ i +"].BizChainId");

				data_pageData.Add(bizChainInfo);
			}
			data.PageData = data_pageData;
			listBizChainResponse.Data = data;
        
			return listBizChainResponse;
        }
    }
}
