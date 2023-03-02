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
    public class ListBaaSAntChainResponseUnmarshaller
    {
        public static ListBaaSAntChainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBaaSAntChainResponse listBaaSAntChainResponse = new ListBaaSAntChainResponse();

			listBaaSAntChainResponse.HttpResponse = _ctx.HttpResponse;
			listBaaSAntChainResponse.Code = _ctx.StringValue("ListBaaSAntChain.Code");
			listBaaSAntChainResponse.HttpStatusCode = _ctx.IntegerValue("ListBaaSAntChain.HttpStatusCode");
			listBaaSAntChainResponse.Message = _ctx.StringValue("ListBaaSAntChain.Message");
			listBaaSAntChainResponse.RequestId = _ctx.StringValue("ListBaaSAntChain.RequestId");
			listBaaSAntChainResponse.Success = _ctx.BooleanValue("ListBaaSAntChain.Success");

			List<ListBaaSAntChainResponse.ListBaaSAntChain_BaaSAntChainChainInfo> listBaaSAntChainResponse_data = new List<ListBaaSAntChainResponse.ListBaaSAntChain_BaaSAntChainChainInfo>();
			for (int i = 0; i < _ctx.Length("ListBaaSAntChain.Data.Length"); i++) {
				ListBaaSAntChainResponse.ListBaaSAntChain_BaaSAntChainChainInfo baaSAntChainChainInfo = new ListBaaSAntChainResponse.ListBaaSAntChain_BaaSAntChainChainInfo();
				baaSAntChainChainInfo.BaaSAntChainChainName = _ctx.StringValue("ListBaaSAntChain.Data["+ i +"].BaaSAntChainChainName");
				baaSAntChainChainInfo.BaaSAntChainChainId = _ctx.StringValue("ListBaaSAntChain.Data["+ i +"].BaaSAntChainChainId");

				listBaaSAntChainResponse_data.Add(baaSAntChainChainInfo);
			}
			listBaaSAntChainResponse.Data = listBaaSAntChainResponse_data;
        
			return listBaaSAntChainResponse;
        }
    }
}
