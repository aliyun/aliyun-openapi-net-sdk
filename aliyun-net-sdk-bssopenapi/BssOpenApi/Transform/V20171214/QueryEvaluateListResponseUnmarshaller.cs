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
        public static QueryEvaluateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEvaluateListResponse queryEvaluateListResponse = new QueryEvaluateListResponse();

			queryEvaluateListResponse.HttpResponse = _ctx.HttpResponse;
			queryEvaluateListResponse.Code = _ctx.StringValue("QueryEvaluateList.Code");
			queryEvaluateListResponse.Message = _ctx.StringValue("QueryEvaluateList.Message");
			queryEvaluateListResponse.RequestId = _ctx.StringValue("QueryEvaluateList.RequestId");
			queryEvaluateListResponse.Success = _ctx.BooleanValue("QueryEvaluateList.Success");

			QueryEvaluateListResponse.QueryEvaluateList_Data data = new QueryEvaluateListResponse.QueryEvaluateList_Data();
			data.PageNum = _ctx.IntegerValue("QueryEvaluateList.Data.PageNum");
			data.TotalUnAppliedInvoiceAmount = _ctx.LongValue("QueryEvaluateList.Data.TotalUnAppliedInvoiceAmount");
			data.PageSize = _ctx.IntegerValue("QueryEvaluateList.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QueryEvaluateList.Data.TotalCount");
			data.TotalInvoiceAmount = _ctx.LongValue("QueryEvaluateList.Data.TotalInvoiceAmount");
			data.HostId = _ctx.StringValue("QueryEvaluateList.Data.HostId");

			List<QueryEvaluateListResponse.QueryEvaluateList_Data.QueryEvaluateList_Evaluate> data_evaluateList = new List<QueryEvaluateListResponse.QueryEvaluateList_Data.QueryEvaluateList_Evaluate>();
			for (int i = 0; i < _ctx.Length("QueryEvaluateList.Data.EvaluateList.Length"); i++) {
				QueryEvaluateListResponse.QueryEvaluateList_Data.QueryEvaluateList_Evaluate evaluate = new QueryEvaluateListResponse.QueryEvaluateList_Data.QueryEvaluateList_Evaluate();
				evaluate.Type = _ctx.IntegerValue("QueryEvaluateList.Data.EvaluateList["+ i +"].Type");
				evaluate.Status = _ctx.IntegerValue("QueryEvaluateList.Data.EvaluateList["+ i +"].Status");
				evaluate.BillId = _ctx.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].BillId");
				evaluate.UserId = _ctx.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].UserId");
				evaluate.BillCycle = _ctx.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].BillCycle");
				evaluate.CanInvoiceAmount = _ctx.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].CanInvoiceAmount");
				evaluate.OffsetAcceptAmount = _ctx.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].OffsetAcceptAmount");
				evaluate.ItemId = _ctx.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].ItemId");
				evaluate.OutBizId = _ctx.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].OutBizId");
				evaluate.UserNick = _ctx.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].UserNick");
				evaluate.GmtModified = _ctx.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].GmtModified");
				evaluate.OpId = _ctx.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].OpId");
				evaluate.BizType = _ctx.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].BizType");
				evaluate.OriginalAmount = _ctx.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].OriginalAmount");
				evaluate.InvoicedAmount = _ctx.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].InvoicedAmount");
				evaluate.GmtCreate = _ctx.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].GmtCreate");
				evaluate.PresentAmount = _ctx.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].PresentAmount");
				evaluate.BizTime = _ctx.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].BizTime");
				evaluate.Name = _ctx.StringValue("QueryEvaluateList.Data.EvaluateList["+ i +"].Name");
				evaluate.OffsetCostAmount = _ctx.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].OffsetCostAmount");
				evaluate.Id = _ctx.LongValue("QueryEvaluateList.Data.EvaluateList["+ i +"].Id");

				data_evaluateList.Add(evaluate);
			}
			data.EvaluateList = data_evaluateList;
			queryEvaluateListResponse.Data = data;
        
			return queryEvaluateListResponse;
        }
    }
}
