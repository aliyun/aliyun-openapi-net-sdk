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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryEvaluateListResponseUnmarshaller
    {
        public static QueryEvaluateListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEvaluateListResponse queryEvaluateListResponse = new QueryEvaluateListResponse();

			queryEvaluateListResponse.HttpResponse = context.HttpResponse;
			queryEvaluateListResponse.RequestId = context.StringValue("QueryEvaluateList.RequestId");
			queryEvaluateListResponse.Success = context.BooleanValue("QueryEvaluateList.Success");
			queryEvaluateListResponse.Code = context.StringValue("QueryEvaluateList.Code");
			queryEvaluateListResponse.Message = context.StringValue("QueryEvaluateList.Message");

			QueryEvaluateListResponse.QueryEvaluateList_Data data = new QueryEvaluateListResponse.QueryEvaluateList_Data();
			data.HostId = context.StringValue("QueryEvaluateList.Data.HostId");
			data.PageNum = context.IntegerValue("QueryEvaluateList.Data.PageNum");
			data.PageSize = context.IntegerValue("QueryEvaluateList.Data.PageSize");
			data.TotalCount = context.IntegerValue("QueryEvaluateList.Data.TotalCount");
			data.TotalInvoiceAmount = context.LongValue("QueryEvaluateList.Data.TotalInvoiceAmount");
			data.TotalUnAppliedInvoiceAmount = context.LongValue("QueryEvaluateList.Data.TotalUnAppliedInvoiceAmount");

			List<QueryEvaluateListResponse.QueryEvaluateList_Data.QueryEvaluateList_Evaluate> data_evaluateList = new List<QueryEvaluateListResponse.QueryEvaluateList_Data.QueryEvaluateList_Evaluate>();
			for (int i = 0; i < context.Length("QueryEvaluateList.Data.EvaluateList.Length"); i++) {
				QueryEvaluateListResponse.QueryEvaluateList_Data.QueryEvaluateList_Evaluate evaluate = new QueryEvaluateListResponse.QueryEvaluateList_Data.QueryEvaluateList_Evaluate();
				evaluate.Id = context.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].Id");
				evaluate.GmtCreate = context.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].GmtCreate");
				evaluate.GmtModified = context.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].GmtModified");
				evaluate.UserId = context.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].UserId");
				evaluate.UserNick = context.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].UserNick");
				evaluate.OutBizId = context.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].OutBizId");
				evaluate.BillId = context.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].BillId");
				evaluate.ItemId = context.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].ItemId");
				evaluate.BillCycle = context.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].BillCycle");
				evaluate.BizType = context.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].BizType");
				evaluate.OriginalAmount = context.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].OriginalAmount");
				evaluate.PresentAmount = context.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].PresentAmount");
				evaluate.CanInvoiceAmount = context.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].CanInvoiceAmount");
				evaluate.InvoicedAmount = context.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].InvoicedAmount");
				evaluate.OffsetCostAmount = context.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].OffsetCostAmount");
				evaluate.OffsetAcceptAmount = context.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].OffsetAcceptAmount");
				evaluate.Status = context.IntegerValue("QueryEvaluateList.Data.EvaluateList["+ i +"].Status");
				evaluate.OpId = context.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].OpId");
				evaluate.Name = context.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].Name");
				evaluate.BizTime = context.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].BizTime");
				evaluate.Type = context.IntegerValue("QueryEvaluateList.Data.EvaluateList["+ i +"].Type");

				data_evaluateList.Add(evaluate);
			}
			data.EvaluateList = data_evaluateList;
			queryEvaluateListResponse.Data = data;
        
			return queryEvaluateListResponse;
        }
    }
}
