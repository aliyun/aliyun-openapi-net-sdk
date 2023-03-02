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
    public class ListAllSystemContractResponseUnmarshaller
    {
        public static ListAllSystemContractResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAllSystemContractResponse listAllSystemContractResponse = new ListAllSystemContractResponse();

			listAllSystemContractResponse.HttpResponse = _ctx.HttpResponse;
			listAllSystemContractResponse.Code = _ctx.StringValue("ListAllSystemContract.Code");
			listAllSystemContractResponse.HttpStatusCode = _ctx.IntegerValue("ListAllSystemContract.HttpStatusCode");
			listAllSystemContractResponse.Message = _ctx.StringValue("ListAllSystemContract.Message");
			listAllSystemContractResponse.RequestId = _ctx.StringValue("ListAllSystemContract.RequestId");
			listAllSystemContractResponse.Success = _ctx.BooleanValue("ListAllSystemContract.Success");

			List<ListAllSystemContractResponse.ListAllSystemContract_SystemContractInfo> listAllSystemContractResponse_data = new List<ListAllSystemContractResponse.ListAllSystemContract_SystemContractInfo>();
			for (int i = 0; i < _ctx.Length("ListAllSystemContract.Data.Length"); i++) {
				ListAllSystemContractResponse.ListAllSystemContract_SystemContractInfo systemContractInfo = new ListAllSystemContractResponse.ListAllSystemContract_SystemContractInfo();
				systemContractInfo.Name = _ctx.StringValue("ListAllSystemContract.Data["+ i +"].Name");
				systemContractInfo.SystemContractId = _ctx.StringValue("ListAllSystemContract.Data["+ i +"].SystemContractId");

				listAllSystemContractResponse_data.Add(systemContractInfo);
			}
			listAllSystemContractResponse.Data = listAllSystemContractResponse_data;
        
			return listAllSystemContractResponse;
        }
    }
}
