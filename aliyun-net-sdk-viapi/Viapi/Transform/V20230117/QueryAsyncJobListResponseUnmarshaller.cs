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
using Aliyun.Acs.viapi.Model.V20230117;

namespace Aliyun.Acs.viapi.Transform.V20230117
{
    public class QueryAsyncJobListResponseUnmarshaller
    {
        public static QueryAsyncJobListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAsyncJobListResponse queryAsyncJobListResponse = new QueryAsyncJobListResponse();

			queryAsyncJobListResponse.HttpResponse = _ctx.HttpResponse;
			queryAsyncJobListResponse.RequestId = _ctx.StringValue("QueryAsyncJobList.RequestId");
			queryAsyncJobListResponse.Message = _ctx.StringValue("QueryAsyncJobList.Message");
			queryAsyncJobListResponse.Success = _ctx.BooleanValue("QueryAsyncJobList.Success");
			queryAsyncJobListResponse.HttpCode = _ctx.StringValue("QueryAsyncJobList.HttpCode");

			QueryAsyncJobListResponse.QueryAsyncJobList_Data data = new QueryAsyncJobListResponse.QueryAsyncJobList_Data();
			data.CurrentPage = _ctx.IntegerValue("QueryAsyncJobList.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("QueryAsyncJobList.Data.PageSize");
			data.TotalPage = _ctx.IntegerValue("QueryAsyncJobList.Data.TotalPage");
			data.TotalRecord = _ctx.IntegerValue("QueryAsyncJobList.Data.TotalRecord");

			List<QueryAsyncJobListResponse.QueryAsyncJobList_Data.QueryAsyncJobList_ResultItem> data_result = new List<QueryAsyncJobListResponse.QueryAsyncJobList_Data.QueryAsyncJobList_ResultItem>();
			for (int i = 0; i < _ctx.Length("QueryAsyncJobList.Data.Result.Length"); i++) {
				QueryAsyncJobListResponse.QueryAsyncJobList_Data.QueryAsyncJobList_ResultItem resultItem = new QueryAsyncJobListResponse.QueryAsyncJobList_Data.QueryAsyncJobList_ResultItem();
				resultItem.CallerParentId = _ctx.StringValue("QueryAsyncJobList.Data.Result["+ i +"].CallerParentId");
				resultItem.EndTime = _ctx.StringValue("QueryAsyncJobList.Data.Result["+ i +"].EndTime");
				resultItem.GmtCreate = _ctx.StringValue("QueryAsyncJobList.Data.Result["+ i +"].GmtCreate");
				resultItem.JobId = _ctx.StringValue("QueryAsyncJobList.Data.Result["+ i +"].JobId");
				resultItem.PopApiName = _ctx.StringValue("QueryAsyncJobList.Data.Result["+ i +"].PopApiName");
				resultItem.PopProduct = _ctx.StringValue("QueryAsyncJobList.Data.Result["+ i +"].PopProduct");
				resultItem.StartTime = _ctx.StringValue("QueryAsyncJobList.Data.Result["+ i +"].StartTime");
				resultItem.Status = _ctx.StringValue("QueryAsyncJobList.Data.Result["+ i +"].Status");

				data_result.Add(resultItem);
			}
			data.Result = data_result;
			queryAsyncJobListResponse.Data = data;
        
			return queryAsyncJobListResponse;
        }
    }
}
