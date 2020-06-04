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
    public class ListInboundOrderCasesResponseUnmarshaller
    {
        public static ListInboundOrderCasesResponse Unmarshall(UnmarshallerContext context)
        {
			ListInboundOrderCasesResponse listInboundOrderCasesResponse = new ListInboundOrderCasesResponse();

			listInboundOrderCasesResponse.HttpResponse = context.HttpResponse;
			listInboundOrderCasesResponse.PageSize = context.IntegerValue("ListInboundOrderCases.PageSize");
			listInboundOrderCasesResponse.TotalCount = context.IntegerValue("ListInboundOrderCases.TotalCount");
			listInboundOrderCasesResponse.PageNumber = context.IntegerValue("ListInboundOrderCases.PageNumber");
			listInboundOrderCasesResponse.RequestId = context.StringValue("ListInboundOrderCases.RequestId");
			listInboundOrderCasesResponse.Success = context.BooleanValue("ListInboundOrderCases.Success");

			List<ListInboundOrderCasesResponse.ListInboundOrderCases_CaseBiz> listInboundOrderCasesResponse_cases = new List<ListInboundOrderCasesResponse.ListInboundOrderCases_CaseBiz>();
			for (int i = 0; i < context.Length("ListInboundOrderCases.Cases.Length"); i++) {
				ListInboundOrderCasesResponse.ListInboundOrderCases_CaseBiz caseBiz = new ListInboundOrderCasesResponse.ListInboundOrderCases_CaseBiz();
				caseBiz.Id = context.StringValue("ListInboundOrderCases.Cases["+ i +"].Id");
				caseBiz.OperateQuantity = context.IntegerValue("ListInboundOrderCases.Cases["+ i +"].OperateQuantity");
				caseBiz.CaseCode = context.StringValue("ListInboundOrderCases.Cases["+ i +"].CaseCode");
				caseBiz.CaseStatus = context.StringValue("ListInboundOrderCases.Cases["+ i +"].CaseStatus");
				caseBiz.BeConfirmInboundCase = context.BooleanValue("ListInboundOrderCases.Cases["+ i +"].BeConfirmInboundCase");
				caseBiz.BeConfirmOutboundCase = context.BooleanValue("ListInboundOrderCases.Cases["+ i +"].BeConfirmOutboundCase");
				caseBiz.ApplyStatus = context.StringValue("ListInboundOrderCases.Cases["+ i +"].ApplyStatus");
				caseBiz.PreboxingQuantity = context.IntegerValue("ListInboundOrderCases.Cases["+ i +"].PreboxingQuantity");

				listInboundOrderCasesResponse_cases.Add(caseBiz);
			}
			listInboundOrderCasesResponse.Cases = listInboundOrderCasesResponse_cases;
        
			return listInboundOrderCasesResponse;
        }
    }
}
