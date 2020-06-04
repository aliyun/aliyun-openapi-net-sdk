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
    public class ListOutboundOrderCasesResponseUnmarshaller
    {
        public static ListOutboundOrderCasesResponse Unmarshall(UnmarshallerContext context)
        {
			ListOutboundOrderCasesResponse listOutboundOrderCasesResponse = new ListOutboundOrderCasesResponse();

			listOutboundOrderCasesResponse.HttpResponse = context.HttpResponse;
			listOutboundOrderCasesResponse.PageSize = context.IntegerValue("ListOutboundOrderCases.PageSize");
			listOutboundOrderCasesResponse.TotalCount = context.IntegerValue("ListOutboundOrderCases.TotalCount");
			listOutboundOrderCasesResponse.PageNumber = context.IntegerValue("ListOutboundOrderCases.PageNumber");
			listOutboundOrderCasesResponse.RequestId = context.StringValue("ListOutboundOrderCases.RequestId");
			listOutboundOrderCasesResponse.Success = context.BooleanValue("ListOutboundOrderCases.Success");

			List<ListOutboundOrderCasesResponse.ListOutboundOrderCases_CaseBiz> listOutboundOrderCasesResponse_cases = new List<ListOutboundOrderCasesResponse.ListOutboundOrderCases_CaseBiz>();
			for (int i = 0; i < context.Length("ListOutboundOrderCases.Cases.Length"); i++) {
				ListOutboundOrderCasesResponse.ListOutboundOrderCases_CaseBiz caseBiz = new ListOutboundOrderCasesResponse.ListOutboundOrderCases_CaseBiz();
				caseBiz.Id = context.StringValue("ListOutboundOrderCases.Cases["+ i +"].Id");
				caseBiz.OperateQuantity = context.IntegerValue("ListOutboundOrderCases.Cases["+ i +"].OperateQuantity");
				caseBiz.CaseCode = context.StringValue("ListOutboundOrderCases.Cases["+ i +"].CaseCode");
				caseBiz.CaseStatus = context.StringValue("ListOutboundOrderCases.Cases["+ i +"].CaseStatus");
				caseBiz.BeConfirmInboundCase = context.BooleanValue("ListOutboundOrderCases.Cases["+ i +"].BeConfirmInboundCase");
				caseBiz.BeConfirmOutboundCase = context.BooleanValue("ListOutboundOrderCases.Cases["+ i +"].BeConfirmOutboundCase");
				caseBiz.ApplyStatus = context.StringValue("ListOutboundOrderCases.Cases["+ i +"].ApplyStatus");

				listOutboundOrderCasesResponse_cases.Add(caseBiz);
			}
			listOutboundOrderCasesResponse.Cases = listOutboundOrderCasesResponse_cases;
        
			return listOutboundOrderCasesResponse;
        }
    }
}
