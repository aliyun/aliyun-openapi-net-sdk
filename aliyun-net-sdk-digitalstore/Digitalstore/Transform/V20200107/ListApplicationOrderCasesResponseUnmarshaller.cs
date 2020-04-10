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
    public class ListApplicationOrderCasesResponseUnmarshaller
    {
        public static ListApplicationOrderCasesResponse Unmarshall(UnmarshallerContext context)
        {
			ListApplicationOrderCasesResponse listApplicationOrderCasesResponse = new ListApplicationOrderCasesResponse();

			listApplicationOrderCasesResponse.HttpResponse = context.HttpResponse;
			listApplicationOrderCasesResponse.PageSize = context.IntegerValue("ListApplicationOrderCases.PageSize");
			listApplicationOrderCasesResponse.TotalCount = context.IntegerValue("ListApplicationOrderCases.TotalCount");
			listApplicationOrderCasesResponse.PageNumber = context.IntegerValue("ListApplicationOrderCases.PageNumber");
			listApplicationOrderCasesResponse.RequestId = context.StringValue("ListApplicationOrderCases.RequestId");
			listApplicationOrderCasesResponse.Success = context.BooleanValue("ListApplicationOrderCases.Success");

			List<ListApplicationOrderCasesResponse.ListApplicationOrderCases_ApplyOrderCaseModel> listApplicationOrderCasesResponse_applyOrderCases = new List<ListApplicationOrderCasesResponse.ListApplicationOrderCases_ApplyOrderCaseModel>();
			for (int i = 0; i < context.Length("ListApplicationOrderCases.ApplyOrderCases.Length"); i++) {
				ListApplicationOrderCasesResponse.ListApplicationOrderCases_ApplyOrderCaseModel applyOrderCaseModel = new ListApplicationOrderCasesResponse.ListApplicationOrderCases_ApplyOrderCaseModel();
				applyOrderCaseModel.CreateDate = context.StringValue("ListApplicationOrderCases.ApplyOrderCases["+ i +"].CreateDate");
				applyOrderCaseModel.Status = context.StringValue("ListApplicationOrderCases.ApplyOrderCases["+ i +"].Status");
				applyOrderCaseModel.OrderCaseId = context.StringValue("ListApplicationOrderCases.ApplyOrderCases["+ i +"].OrderCaseId");
				applyOrderCaseModel.ProductTotal = context.IntegerValue("ListApplicationOrderCases.ApplyOrderCases["+ i +"].ProductTotal");
				applyOrderCaseModel.CaseCode = context.StringValue("ListApplicationOrderCases.ApplyOrderCases["+ i +"].CaseCode");
				applyOrderCaseModel.ReceivedQuantity = context.IntegerValue("ListApplicationOrderCases.ApplyOrderCases["+ i +"].ReceivedQuantity");
				applyOrderCaseModel.UpdateDate = context.StringValue("ListApplicationOrderCases.ApplyOrderCases["+ i +"].UpdateDate");
				applyOrderCaseModel.OrderId = context.StringValue("ListApplicationOrderCases.ApplyOrderCases["+ i +"].OrderId");
				applyOrderCaseModel.CaseId = context.StringValue("ListApplicationOrderCases.ApplyOrderCases["+ i +"].CaseId");

				listApplicationOrderCasesResponse_applyOrderCases.Add(applyOrderCaseModel);
			}
			listApplicationOrderCasesResponse.ApplyOrderCases = listApplicationOrderCasesResponse_applyOrderCases;
        
			return listApplicationOrderCasesResponse;
        }
    }
}
