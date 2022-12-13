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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class ListFunctionTasksResponseUnmarshaller
    {
        public static ListFunctionTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFunctionTasksResponse listFunctionTasksResponse = new ListFunctionTasksResponse();

			listFunctionTasksResponse.HttpResponse = _ctx.HttpResponse;
			listFunctionTasksResponse.Status = _ctx.StringValue("ListFunctionTasks.Status");
			listFunctionTasksResponse.HttpCode = _ctx.LongValue("ListFunctionTasks.HttpCode");
			listFunctionTasksResponse.TotalCount = _ctx.LongValue("ListFunctionTasks.TotalCount");
			listFunctionTasksResponse.RequestId = _ctx.StringValue("ListFunctionTasks.RequestId");
			listFunctionTasksResponse.Message = _ctx.StringValue("ListFunctionTasks.Message");
			listFunctionTasksResponse.Code = _ctx.StringValue("ListFunctionTasks.Code");
			listFunctionTasksResponse.Latency = _ctx.LongValue("ListFunctionTasks.Latency");

			List<ListFunctionTasksResponse.ListFunctionTasks_ResultItem> listFunctionTasksResponse_result = new List<ListFunctionTasksResponse.ListFunctionTasks_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListFunctionTasks.Result.Length"); i++) {
				ListFunctionTasksResponse.ListFunctionTasks_ResultItem resultItem = new ListFunctionTasksResponse.ListFunctionTasks_ResultItem();
				resultItem.EndTime = _ctx.LongValue("ListFunctionTasks.Result["+ i +"].EndTime");
				resultItem.ExtendInfo = _ctx.StringValue("ListFunctionTasks.Result["+ i +"].ExtendInfo");
				resultItem.FunctionName = _ctx.StringValue("ListFunctionTasks.Result["+ i +"].FunctionName");
				resultItem.Progress = _ctx.LongValue("ListFunctionTasks.Result["+ i +"].Progress");
				resultItem.RunId = _ctx.StringValue("ListFunctionTasks.Result["+ i +"].RunId");
				resultItem.StartTime = _ctx.LongValue("ListFunctionTasks.Result["+ i +"].StartTime");
				resultItem.Status = _ctx.StringValue("ListFunctionTasks.Result["+ i +"].Status");
				resultItem.Generation = _ctx.StringValue("ListFunctionTasks.Result["+ i +"].Generation");

				listFunctionTasksResponse_result.Add(resultItem);
			}
			listFunctionTasksResponse.Result = listFunctionTasksResponse_result;
        
			return listFunctionTasksResponse;
        }
    }
}
