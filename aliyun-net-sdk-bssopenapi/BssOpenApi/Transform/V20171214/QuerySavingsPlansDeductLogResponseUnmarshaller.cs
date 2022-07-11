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
    public class QuerySavingsPlansDeductLogResponseUnmarshaller
    {
        public static QuerySavingsPlansDeductLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySavingsPlansDeductLogResponse querySavingsPlansDeductLogResponse = new QuerySavingsPlansDeductLogResponse();

			querySavingsPlansDeductLogResponse.HttpResponse = _ctx.HttpResponse;
			querySavingsPlansDeductLogResponse.Code = _ctx.StringValue("QuerySavingsPlansDeductLog.Code");
			querySavingsPlansDeductLogResponse.Message = _ctx.StringValue("QuerySavingsPlansDeductLog.Message");
			querySavingsPlansDeductLogResponse.RequestId = _ctx.StringValue("QuerySavingsPlansDeductLog.RequestId");
			querySavingsPlansDeductLogResponse.Success = _ctx.BooleanValue("QuerySavingsPlansDeductLog.Success");

			QuerySavingsPlansDeductLogResponse.QuerySavingsPlansDeductLog_Data data = new QuerySavingsPlansDeductLogResponse.QuerySavingsPlansDeductLog_Data();
			data.PageNum = _ctx.IntegerValue("QuerySavingsPlansDeductLog.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QuerySavingsPlansDeductLog.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QuerySavingsPlansDeductLog.Data.TotalCount");

			List<QuerySavingsPlansDeductLogResponse.QuerySavingsPlansDeductLog_Data.QuerySavingsPlansDeductLog_SavingsPlansDeductDetailResponse> data_items = new List<QuerySavingsPlansDeductLogResponse.QuerySavingsPlansDeductLog_Data.QuerySavingsPlansDeductLog_SavingsPlansDeductDetailResponse>();
			for (int i = 0; i < _ctx.Length("QuerySavingsPlansDeductLog.Data.Items.Length"); i++) {
				QuerySavingsPlansDeductLogResponse.QuerySavingsPlansDeductLog_Data.QuerySavingsPlansDeductLog_SavingsPlansDeductDetailResponse savingsPlansDeductDetailResponse = new QuerySavingsPlansDeductLogResponse.QuerySavingsPlansDeductLog_Data.QuerySavingsPlansDeductLog_SavingsPlansDeductDetailResponse();
				savingsPlansDeductDetailResponse.EndTime = _ctx.StringValue("QuerySavingsPlansDeductLog.Data.Items["+ i +"].EndTime");
				savingsPlansDeductDetailResponse.StartTime = _ctx.StringValue("QuerySavingsPlansDeductLog.Data.Items["+ i +"].StartTime");
				savingsPlansDeductDetailResponse.SavingsType = _ctx.StringValue("QuerySavingsPlansDeductLog.Data.Items["+ i +"].SavingsType");
				savingsPlansDeductDetailResponse.UserId = _ctx.LongValue("QuerySavingsPlansDeductLog.Data.Items["+ i +"].UserId");
				savingsPlansDeductDetailResponse.DiscountRate = _ctx.StringValue("QuerySavingsPlansDeductLog.Data.Items["+ i +"].DiscountRate");
				savingsPlansDeductDetailResponse.BillModule = _ctx.StringValue("QuerySavingsPlansDeductLog.Data.Items["+ i +"].BillModule");
				savingsPlansDeductDetailResponse.InstanceId = _ctx.StringValue("QuerySavingsPlansDeductLog.Data.Items["+ i +"].InstanceId");
				savingsPlansDeductDetailResponse.DeductInstanceId = _ctx.StringValue("QuerySavingsPlansDeductLog.Data.Items["+ i +"].DeductInstanceId");
				savingsPlansDeductDetailResponse.DeductCommodity = _ctx.StringValue("QuerySavingsPlansDeductLog.Data.Items["+ i +"].DeductCommodity");
				savingsPlansDeductDetailResponse.DeductRate = _ctx.StringValue("QuerySavingsPlansDeductLog.Data.Items["+ i +"].DeductRate");
				savingsPlansDeductDetailResponse.DeductFee = _ctx.StringValue("QuerySavingsPlansDeductLog.Data.Items["+ i +"].DeductFee");
				savingsPlansDeductDetailResponse.OwnerId = _ctx.LongValue("QuerySavingsPlansDeductLog.Data.Items["+ i +"].OwnerId");

				data_items.Add(savingsPlansDeductDetailResponse);
			}
			data.Items = data_items;
			querySavingsPlansDeductLogResponse.Data = data;
        
			return querySavingsPlansDeductLogResponse;
        }
    }
}
