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
    public class QueryTaskDetailHistoryResponseUnmarshaller
    {
        public static QueryTaskDetailHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTaskDetailHistoryResponse queryTaskDetailHistoryResponse = new QueryTaskDetailHistoryResponse();

			queryTaskDetailHistoryResponse.HttpResponse = context.HttpResponse;
			queryTaskDetailHistoryResponse.RequestId = context.StringValue("QueryTaskDetailHistory.RequestId");
			queryTaskDetailHistoryResponse.PageSize = context.IntegerValue("QueryTaskDetailHistory.PageSize");

			QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_CurrentPageCursor currentPageCursor = new QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_CurrentPageCursor();
			currentPageCursor.TaskNo = context.StringValue("QueryTaskDetailHistory.CurrentPageCursor.TaskNo");
			currentPageCursor.TaskDetailNo = context.StringValue("QueryTaskDetailHistory.CurrentPageCursor.TaskDetailNo");
			currentPageCursor.TaskType = context.StringValue("QueryTaskDetailHistory.CurrentPageCursor.TaskType");
			currentPageCursor.InstanceId = context.StringValue("QueryTaskDetailHistory.CurrentPageCursor.InstanceId");
			currentPageCursor.DomainName = context.StringValue("QueryTaskDetailHistory.CurrentPageCursor.DomainName");
			currentPageCursor.TaskStatus = context.StringValue("QueryTaskDetailHistory.CurrentPageCursor.TaskStatus");
			currentPageCursor.UpdateTime = context.StringValue("QueryTaskDetailHistory.CurrentPageCursor.UpdateTime");
			currentPageCursor.CreateTime = context.StringValue("QueryTaskDetailHistory.CurrentPageCursor.CreateTime");
			currentPageCursor.TryCount = context.IntegerValue("QueryTaskDetailHistory.CurrentPageCursor.TryCount");
			currentPageCursor.ErrorMsg = context.StringValue("QueryTaskDetailHistory.CurrentPageCursor.ErrorMsg");
			currentPageCursor.TaskStatusCode = context.IntegerValue("QueryTaskDetailHistory.CurrentPageCursor.TaskStatusCode");
			currentPageCursor.TaskTypeDescription = context.StringValue("QueryTaskDetailHistory.CurrentPageCursor.TaskTypeDescription");
			queryTaskDetailHistoryResponse.CurrentPageCursor = currentPageCursor;

			QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_NextPageCursor nextPageCursor = new QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_NextPageCursor();
			nextPageCursor.TaskNo = context.StringValue("QueryTaskDetailHistory.NextPageCursor.TaskNo");
			nextPageCursor.TaskDetailNo = context.StringValue("QueryTaskDetailHistory.NextPageCursor.TaskDetailNo");
			nextPageCursor.TaskType = context.StringValue("QueryTaskDetailHistory.NextPageCursor.TaskType");
			nextPageCursor.InstanceId = context.StringValue("QueryTaskDetailHistory.NextPageCursor.InstanceId");
			nextPageCursor.DomainName = context.StringValue("QueryTaskDetailHistory.NextPageCursor.DomainName");
			nextPageCursor.TaskStatus = context.StringValue("QueryTaskDetailHistory.NextPageCursor.TaskStatus");
			nextPageCursor.UpdateTime = context.StringValue("QueryTaskDetailHistory.NextPageCursor.UpdateTime");
			nextPageCursor.CreateTime = context.StringValue("QueryTaskDetailHistory.NextPageCursor.CreateTime");
			nextPageCursor.TryCount = context.IntegerValue("QueryTaskDetailHistory.NextPageCursor.TryCount");
			nextPageCursor.ErrorMsg = context.StringValue("QueryTaskDetailHistory.NextPageCursor.ErrorMsg");
			nextPageCursor.TaskStatusCode = context.IntegerValue("QueryTaskDetailHistory.NextPageCursor.TaskStatusCode");
			nextPageCursor.TaskTypeDescription = context.StringValue("QueryTaskDetailHistory.NextPageCursor.TaskTypeDescription");
			queryTaskDetailHistoryResponse.NextPageCursor = nextPageCursor;

			QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_PrePageCursor prePageCursor = new QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_PrePageCursor();
			prePageCursor.TaskNo = context.StringValue("QueryTaskDetailHistory.PrePageCursor.TaskNo");
			prePageCursor.TaskDetailNo = context.StringValue("QueryTaskDetailHistory.PrePageCursor.TaskDetailNo");
			prePageCursor.TaskType = context.StringValue("QueryTaskDetailHistory.PrePageCursor.TaskType");
			prePageCursor.InstanceId = context.StringValue("QueryTaskDetailHistory.PrePageCursor.InstanceId");
			prePageCursor.DomainName = context.StringValue("QueryTaskDetailHistory.PrePageCursor.DomainName");
			prePageCursor.TaskStatus = context.StringValue("QueryTaskDetailHistory.PrePageCursor.TaskStatus");
			prePageCursor.UpdateTime = context.StringValue("QueryTaskDetailHistory.PrePageCursor.UpdateTime");
			prePageCursor.CreateTime = context.StringValue("QueryTaskDetailHistory.PrePageCursor.CreateTime");
			prePageCursor.TryCount = context.IntegerValue("QueryTaskDetailHistory.PrePageCursor.TryCount");
			prePageCursor.ErrorMsg = context.StringValue("QueryTaskDetailHistory.PrePageCursor.ErrorMsg");
			prePageCursor.TaskStatusCode = context.IntegerValue("QueryTaskDetailHistory.PrePageCursor.TaskStatusCode");
			prePageCursor.TaskTypeDescription = context.StringValue("QueryTaskDetailHistory.PrePageCursor.TaskTypeDescription");
			queryTaskDetailHistoryResponse.PrePageCursor = prePageCursor;

			List<QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_TaskDetailHistory> queryTaskDetailHistoryResponse_objects = new List<QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_TaskDetailHistory>();
			for (int i = 0; i < context.Length("QueryTaskDetailHistory.Objects.Length"); i++) {
				QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_TaskDetailHistory taskDetailHistory = new QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_TaskDetailHistory();
				taskDetailHistory.TaskNo = context.StringValue("QueryTaskDetailHistory.Objects["+ i +"].TaskNo");
				taskDetailHistory.TaskDetailNo = context.StringValue("QueryTaskDetailHistory.Objects["+ i +"].TaskDetailNo");
				taskDetailHistory.TaskType = context.StringValue("QueryTaskDetailHistory.Objects["+ i +"].TaskType");
				taskDetailHistory.InstanceId = context.StringValue("QueryTaskDetailHistory.Objects["+ i +"].InstanceId");
				taskDetailHistory.DomainName = context.StringValue("QueryTaskDetailHistory.Objects["+ i +"].DomainName");
				taskDetailHistory.TaskStatus = context.StringValue("QueryTaskDetailHistory.Objects["+ i +"].TaskStatus");
				taskDetailHistory.UpdateTime = context.StringValue("QueryTaskDetailHistory.Objects["+ i +"].UpdateTime");
				taskDetailHistory.CreateTime = context.StringValue("QueryTaskDetailHistory.Objects["+ i +"].CreateTime");
				taskDetailHistory.TryCount = context.IntegerValue("QueryTaskDetailHistory.Objects["+ i +"].TryCount");
				taskDetailHistory.ErrorMsg = context.StringValue("QueryTaskDetailHistory.Objects["+ i +"].ErrorMsg");
				taskDetailHistory.TaskStatusCode = context.IntegerValue("QueryTaskDetailHistory.Objects["+ i +"].TaskStatusCode");
				taskDetailHistory.TaskTypeDescription = context.StringValue("QueryTaskDetailHistory.Objects["+ i +"].TaskTypeDescription");

				queryTaskDetailHistoryResponse_objects.Add(taskDetailHistory);
			}
			queryTaskDetailHistoryResponse.Objects = queryTaskDetailHistoryResponse_objects;
        
			return queryTaskDetailHistoryResponse;
        }
    }
}
