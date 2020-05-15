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
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class ListProduceOrderCasesResponseUnmarshaller
    {
        public static ListProduceOrderCasesResponse Unmarshall(UnmarshallerContext context)
        {
			ListProduceOrderCasesResponse listProduceOrderCasesResponse = new ListProduceOrderCasesResponse();

			listProduceOrderCasesResponse.HttpResponse = context.HttpResponse;
			listProduceOrderCasesResponse.PageSize = context.IntegerValue("ListProduceOrderCases.PageSize");
			listProduceOrderCasesResponse.TotalCount = context.IntegerValue("ListProduceOrderCases.TotalCount");
			listProduceOrderCasesResponse.PageNumber = context.IntegerValue("ListProduceOrderCases.PageNumber");
			listProduceOrderCasesResponse.RequestId = context.StringValue("ListProduceOrderCases.RequestId");
			listProduceOrderCasesResponse.Success = context.BooleanValue("ListProduceOrderCases.Success");

			List<ListProduceOrderCasesResponse.ListProduceOrderCases_ProduceOrderCaseModel> listProduceOrderCasesResponse_produceOrderCases = new List<ListProduceOrderCasesResponse.ListProduceOrderCases_ProduceOrderCaseModel>();
			for (int i = 0; i < context.Length("ListProduceOrderCases.ProduceOrderCases.Length"); i++) {
				ListProduceOrderCasesResponse.ListProduceOrderCases_ProduceOrderCaseModel produceOrderCaseModel = new ListProduceOrderCasesResponse.ListProduceOrderCases_ProduceOrderCaseModel();
				produceOrderCaseModel.BindingQuantity = context.IntegerValue("ListProduceOrderCases.ProduceOrderCases["+ i +"].BindingQuantity");
				produceOrderCaseModel.CaseCode = context.StringValue("ListProduceOrderCases.ProduceOrderCases["+ i +"].CaseCode");
				produceOrderCaseModel.OrderId = context.StringValue("ListProduceOrderCases.ProduceOrderCases["+ i +"].OrderId");
				produceOrderCaseModel.BoxQuantity = context.IntegerValue("ListProduceOrderCases.ProduceOrderCases["+ i +"].BoxQuantity");
				produceOrderCaseModel.CaseId = context.StringValue("ListProduceOrderCases.ProduceOrderCases["+ i +"].CaseId");
				produceOrderCaseModel.EncasementMode = context.StringValue("ListProduceOrderCases.ProduceOrderCases["+ i +"].EncasementMode");
				produceOrderCaseModel.BeConfirmInboundCase = context.BooleanValue("ListProduceOrderCases.ProduceOrderCases["+ i +"].BeConfirmInboundCase");
				produceOrderCaseModel.BeConfirmOutboundCase = context.BooleanValue("ListProduceOrderCases.ProduceOrderCases["+ i +"].BeConfirmOutboundCase");
				produceOrderCaseModel.ApplyStatus = context.StringValue("ListProduceOrderCases.ProduceOrderCases["+ i +"].ApplyStatus");

				listProduceOrderCasesResponse_produceOrderCases.Add(produceOrderCaseModel);
			}
			listProduceOrderCasesResponse.ProduceOrderCases = listProduceOrderCasesResponse_produceOrderCases;
        
			return listProduceOrderCasesResponse;
        }
    }
}
