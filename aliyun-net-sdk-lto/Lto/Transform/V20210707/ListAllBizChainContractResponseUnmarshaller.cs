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
    public class ListAllBizChainContractResponseUnmarshaller
    {
        public static ListAllBizChainContractResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAllBizChainContractResponse listAllBizChainContractResponse = new ListAllBizChainContractResponse();

			listAllBizChainContractResponse.HttpResponse = _ctx.HttpResponse;
			listAllBizChainContractResponse.Code = _ctx.StringValue("ListAllBizChainContract.Code");
			listAllBizChainContractResponse.HttpStatusCode = _ctx.IntegerValue("ListAllBizChainContract.HttpStatusCode");
			listAllBizChainContractResponse.Message = _ctx.StringValue("ListAllBizChainContract.Message");
			listAllBizChainContractResponse.RequestId = _ctx.StringValue("ListAllBizChainContract.RequestId");
			listAllBizChainContractResponse.Success = _ctx.BooleanValue("ListAllBizChainContract.Success");

			List<ListAllBizChainContractResponse.ListAllBizChainContract_ContractInfo> listAllBizChainContractResponse_data = new List<ListAllBizChainContractResponse.ListAllBizChainContract_ContractInfo>();
			for (int i = 0; i < _ctx.Length("ListAllBizChainContract.Data.Length"); i++) {
				ListAllBizChainContractResponse.ListAllBizChainContract_ContractInfo contractInfo = new ListAllBizChainContractResponse.ListAllBizChainContract_ContractInfo();
				contractInfo.ContractName = _ctx.StringValue("ListAllBizChainContract.Data["+ i +"].ContractName");
				contractInfo.InvokeType = _ctx.StringValue("ListAllBizChainContract.Data["+ i +"].InvokeType");
				contractInfo.ContractTemplateId = _ctx.StringValue("ListAllBizChainContract.Data["+ i +"].ContractTemplateId");

				listAllBizChainContractResponse_data.Add(contractInfo);
			}
			listAllBizChainContractResponse.Data = listAllBizChainContractResponse_data;
        
			return listAllBizChainContractResponse;
        }
    }
}
