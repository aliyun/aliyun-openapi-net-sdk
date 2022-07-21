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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryTaskInfoHistoryResponseUnmarshaller
    {
        public static QueryTaskInfoHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTaskInfoHistoryResponse queryTaskInfoHistoryResponse = new QueryTaskInfoHistoryResponse();

			queryTaskInfoHistoryResponse.HttpResponse = _ctx.HttpResponse;
			queryTaskInfoHistoryResponse.PageSize = _ctx.IntegerValue("QueryTaskInfoHistory.PageSize");
			queryTaskInfoHistoryResponse.RequestId = _ctx.StringValue("QueryTaskInfoHistory.RequestId");

			QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_CurrentPageCursor currentPageCursor = new QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_CurrentPageCursor();
			currentPageCursor.TaskType = _ctx.StringValue("QueryTaskInfoHistory.CurrentPageCursor.TaskType");
			currentPageCursor.TaskNo = _ctx.StringValue("QueryTaskInfoHistory.CurrentPageCursor.TaskNo");
			currentPageCursor.TaskStatusCode = _ctx.IntegerValue("QueryTaskInfoHistory.CurrentPageCursor.TaskStatusCode");
			currentPageCursor.TaskStatus = _ctx.StringValue("QueryTaskInfoHistory.CurrentPageCursor.TaskStatus");
			currentPageCursor.TaskTypeDescription = _ctx.StringValue("QueryTaskInfoHistory.CurrentPageCursor.TaskTypeDescription");
			currentPageCursor.TaskNum = _ctx.IntegerValue("QueryTaskInfoHistory.CurrentPageCursor.TaskNum");
			currentPageCursor.CreateTime = _ctx.StringValue("QueryTaskInfoHistory.CurrentPageCursor.CreateTime");
			currentPageCursor.CreateTimeLong = _ctx.LongValue("QueryTaskInfoHistory.CurrentPageCursor.CreateTimeLong");
			currentPageCursor.Clientip = _ctx.StringValue("QueryTaskInfoHistory.CurrentPageCursor.Clientip");
			queryTaskInfoHistoryResponse.CurrentPageCursor = currentPageCursor;

			QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_PrePageCursor prePageCursor = new QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_PrePageCursor();
			prePageCursor.TaskType = _ctx.StringValue("QueryTaskInfoHistory.PrePageCursor.TaskType");
			prePageCursor.TaskNo = _ctx.StringValue("QueryTaskInfoHistory.PrePageCursor.TaskNo");
			prePageCursor.TaskStatusCode = _ctx.IntegerValue("QueryTaskInfoHistory.PrePageCursor.TaskStatusCode");
			prePageCursor.TaskStatus = _ctx.StringValue("QueryTaskInfoHistory.PrePageCursor.TaskStatus");
			prePageCursor.TaskTypeDescription = _ctx.StringValue("QueryTaskInfoHistory.PrePageCursor.TaskTypeDescription");
			prePageCursor.TaskNum = _ctx.IntegerValue("QueryTaskInfoHistory.PrePageCursor.TaskNum");
			prePageCursor.CreateTime = _ctx.StringValue("QueryTaskInfoHistory.PrePageCursor.CreateTime");
			prePageCursor.CreateTimeLong = _ctx.LongValue("QueryTaskInfoHistory.PrePageCursor.CreateTimeLong");
			prePageCursor.Clientip = _ctx.StringValue("QueryTaskInfoHistory.PrePageCursor.Clientip");
			queryTaskInfoHistoryResponse.PrePageCursor = prePageCursor;

			QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_NextPageCursor nextPageCursor = new QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_NextPageCursor();
			nextPageCursor.TaskType = _ctx.StringValue("QueryTaskInfoHistory.NextPageCursor.TaskType");
			nextPageCursor.TaskNo = _ctx.StringValue("QueryTaskInfoHistory.NextPageCursor.TaskNo");
			nextPageCursor.TaskStatusCode = _ctx.IntegerValue("QueryTaskInfoHistory.NextPageCursor.TaskStatusCode");
			nextPageCursor.TaskStatus = _ctx.StringValue("QueryTaskInfoHistory.NextPageCursor.TaskStatus");
			nextPageCursor.TaskTypeDescription = _ctx.StringValue("QueryTaskInfoHistory.NextPageCursor.TaskTypeDescription");
			nextPageCursor.TaskNum = _ctx.IntegerValue("QueryTaskInfoHistory.NextPageCursor.TaskNum");
			nextPageCursor.CreateTime = _ctx.StringValue("QueryTaskInfoHistory.NextPageCursor.CreateTime");
			nextPageCursor.CreateTimeLong = _ctx.LongValue("QueryTaskInfoHistory.NextPageCursor.CreateTimeLong");
			nextPageCursor.Clientip = _ctx.StringValue("QueryTaskInfoHistory.NextPageCursor.Clientip");
			queryTaskInfoHistoryResponse.NextPageCursor = nextPageCursor;

			List<QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_TaskInfoHistory> queryTaskInfoHistoryResponse_objects = new List<QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_TaskInfoHistory>();
			for (int i = 0; i < _ctx.Length("QueryTaskInfoHistory.Objects.Length"); i++) {
				QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_TaskInfoHistory taskInfoHistory = new QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_TaskInfoHistory();
				taskInfoHistory.TaskType = _ctx.StringValue("QueryTaskInfoHistory.Objects["+ i +"].TaskType");
				taskInfoHistory.TaskNo = _ctx.StringValue("QueryTaskInfoHistory.Objects["+ i +"].TaskNo");
				taskInfoHistory.TaskStatusCode = _ctx.IntegerValue("QueryTaskInfoHistory.Objects["+ i +"].TaskStatusCode");
				taskInfoHistory.TaskStatus = _ctx.StringValue("QueryTaskInfoHistory.Objects["+ i +"].TaskStatus");
				taskInfoHistory.TaskTypeDescription = _ctx.StringValue("QueryTaskInfoHistory.Objects["+ i +"].TaskTypeDescription");
				taskInfoHistory.TaskNum = _ctx.IntegerValue("QueryTaskInfoHistory.Objects["+ i +"].TaskNum");
				taskInfoHistory.CreateTime = _ctx.StringValue("QueryTaskInfoHistory.Objects["+ i +"].CreateTime");
				taskInfoHistory.CreateTimeLong = _ctx.LongValue("QueryTaskInfoHistory.Objects["+ i +"].CreateTimeLong");
				taskInfoHistory.Clientip = _ctx.StringValue("QueryTaskInfoHistory.Objects["+ i +"].Clientip");

				queryTaskInfoHistoryResponse_objects.Add(taskInfoHistory);
			}
			queryTaskInfoHistoryResponse.Objects = queryTaskInfoHistoryResponse_objects;
        
			return queryTaskInfoHistoryResponse;
        }
    }
}
