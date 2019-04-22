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
        public static QueryTaskInfoHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTaskInfoHistoryResponse queryTaskInfoHistoryResponse = new QueryTaskInfoHistoryResponse();

			queryTaskInfoHistoryResponse.HttpResponse = context.HttpResponse;
			queryTaskInfoHistoryResponse.RequestId = context.StringValue("QueryTaskInfoHistory.RequestId");
			queryTaskInfoHistoryResponse.PageSize = context.IntegerValue("QueryTaskInfoHistory.PageSize");

			QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_CurrentPageCursor currentPageCursor = new QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_CurrentPageCursor();
			currentPageCursor.TaskType = context.StringValue("QueryTaskInfoHistory.CurrentPageCursor.TaskType");
			currentPageCursor.TaskNum = context.IntegerValue("QueryTaskInfoHistory.CurrentPageCursor.TaskNum");
			currentPageCursor.TaskStatus = context.StringValue("QueryTaskInfoHistory.CurrentPageCursor.TaskStatus");
			currentPageCursor.CreateTime = context.StringValue("QueryTaskInfoHistory.CurrentPageCursor.CreateTime");
			currentPageCursor.Clientip = context.StringValue("QueryTaskInfoHistory.CurrentPageCursor.Clientip");
			currentPageCursor.TaskNo = context.StringValue("QueryTaskInfoHistory.CurrentPageCursor.TaskNo");
			currentPageCursor.CreateTimeLong = context.LongValue("QueryTaskInfoHistory.CurrentPageCursor.CreateTimeLong");
			currentPageCursor.TaskStatusCode = context.IntegerValue("QueryTaskInfoHistory.CurrentPageCursor.TaskStatusCode");
			currentPageCursor.TaskTypeDescription = context.StringValue("QueryTaskInfoHistory.CurrentPageCursor.TaskTypeDescription");
			queryTaskInfoHistoryResponse.CurrentPageCursor = currentPageCursor;

			QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_NextPageCursor nextPageCursor = new QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_NextPageCursor();
			nextPageCursor.TaskType = context.StringValue("QueryTaskInfoHistory.NextPageCursor.TaskType");
			nextPageCursor.TaskNum = context.IntegerValue("QueryTaskInfoHistory.NextPageCursor.TaskNum");
			nextPageCursor.TaskStatus = context.StringValue("QueryTaskInfoHistory.NextPageCursor.TaskStatus");
			nextPageCursor.CreateTime = context.StringValue("QueryTaskInfoHistory.NextPageCursor.CreateTime");
			nextPageCursor.Clientip = context.StringValue("QueryTaskInfoHistory.NextPageCursor.Clientip");
			nextPageCursor.TaskNo = context.StringValue("QueryTaskInfoHistory.NextPageCursor.TaskNo");
			nextPageCursor.CreateTimeLong = context.LongValue("QueryTaskInfoHistory.NextPageCursor.CreateTimeLong");
			nextPageCursor.TaskStatusCode = context.IntegerValue("QueryTaskInfoHistory.NextPageCursor.TaskStatusCode");
			nextPageCursor.TaskTypeDescription = context.StringValue("QueryTaskInfoHistory.NextPageCursor.TaskTypeDescription");
			queryTaskInfoHistoryResponse.NextPageCursor = nextPageCursor;

			QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_PrePageCursor prePageCursor = new QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_PrePageCursor();
			prePageCursor.TaskType = context.StringValue("QueryTaskInfoHistory.PrePageCursor.TaskType");
			prePageCursor.TaskNum = context.IntegerValue("QueryTaskInfoHistory.PrePageCursor.TaskNum");
			prePageCursor.TaskStatus = context.StringValue("QueryTaskInfoHistory.PrePageCursor.TaskStatus");
			prePageCursor.CreateTime = context.StringValue("QueryTaskInfoHistory.PrePageCursor.CreateTime");
			prePageCursor.Clientip = context.StringValue("QueryTaskInfoHistory.PrePageCursor.Clientip");
			prePageCursor.TaskNo = context.StringValue("QueryTaskInfoHistory.PrePageCursor.TaskNo");
			prePageCursor.CreateTimeLong = context.LongValue("QueryTaskInfoHistory.PrePageCursor.CreateTimeLong");
			prePageCursor.TaskStatusCode = context.IntegerValue("QueryTaskInfoHistory.PrePageCursor.TaskStatusCode");
			prePageCursor.TaskTypeDescription = context.StringValue("QueryTaskInfoHistory.PrePageCursor.TaskTypeDescription");
			queryTaskInfoHistoryResponse.PrePageCursor = prePageCursor;

			List<QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_TaskInfoHistory> queryTaskInfoHistoryResponse_objects = new List<QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_TaskInfoHistory>();
			for (int i = 0; i < context.Length("QueryTaskInfoHistory.Objects.Length"); i++) {
				QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_TaskInfoHistory taskInfoHistory = new QueryTaskInfoHistoryResponse.QueryTaskInfoHistory_TaskInfoHistory();
				taskInfoHistory.TaskType = context.StringValue("QueryTaskInfoHistory.Objects["+ i +"].TaskType");
				taskInfoHistory.TaskNum = context.IntegerValue("QueryTaskInfoHistory.Objects["+ i +"].TaskNum");
				taskInfoHistory.TaskStatus = context.StringValue("QueryTaskInfoHistory.Objects["+ i +"].TaskStatus");
				taskInfoHistory.CreateTime = context.StringValue("QueryTaskInfoHistory.Objects["+ i +"].CreateTime");
				taskInfoHistory.Clientip = context.StringValue("QueryTaskInfoHistory.Objects["+ i +"].Clientip");
				taskInfoHistory.TaskNo = context.StringValue("QueryTaskInfoHistory.Objects["+ i +"].TaskNo");
				taskInfoHistory.CreateTimeLong = context.LongValue("QueryTaskInfoHistory.Objects["+ i +"].CreateTimeLong");
				taskInfoHistory.TaskStatusCode = context.IntegerValue("QueryTaskInfoHistory.Objects["+ i +"].TaskStatusCode");
				taskInfoHistory.TaskTypeDescription = context.StringValue("QueryTaskInfoHistory.Objects["+ i +"].TaskTypeDescription");

				queryTaskInfoHistoryResponse_objects.Add(taskInfoHistory);
			}
			queryTaskInfoHistoryResponse.Objects = queryTaskInfoHistoryResponse_objects;
        
			return queryTaskInfoHistoryResponse;
        }
    }
}
