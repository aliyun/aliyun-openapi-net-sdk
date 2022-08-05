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
        public static QueryTaskDetailHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTaskDetailHistoryResponse queryTaskDetailHistoryResponse = new QueryTaskDetailHistoryResponse();

			queryTaskDetailHistoryResponse.HttpResponse = _ctx.HttpResponse;
			queryTaskDetailHistoryResponse.PageSize = _ctx.IntegerValue("QueryTaskDetailHistory.PageSize");
			queryTaskDetailHistoryResponse.RequestId = _ctx.StringValue("QueryTaskDetailHistory.RequestId");

			QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_CurrentPageCursor currentPageCursor = new QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_CurrentPageCursor();
			currentPageCursor.UpdateTime = _ctx.StringValue("QueryTaskDetailHistory.CurrentPageCursor.UpdateTime");
			currentPageCursor.TaskDetailNo = _ctx.StringValue("QueryTaskDetailHistory.CurrentPageCursor.TaskDetailNo");
			currentPageCursor.CreateTime = _ctx.StringValue("QueryTaskDetailHistory.CurrentPageCursor.CreateTime");
			currentPageCursor.InstanceId = _ctx.StringValue("QueryTaskDetailHistory.CurrentPageCursor.InstanceId");
			currentPageCursor.DomainName = _ctx.StringValue("QueryTaskDetailHistory.CurrentPageCursor.DomainName");
			currentPageCursor.TaskType = _ctx.StringValue("QueryTaskDetailHistory.CurrentPageCursor.TaskType");
			currentPageCursor.TaskNo = _ctx.StringValue("QueryTaskDetailHistory.CurrentPageCursor.TaskNo");
			currentPageCursor.TaskStatusCode = _ctx.IntegerValue("QueryTaskDetailHistory.CurrentPageCursor.TaskStatusCode");
			currentPageCursor.TaskStatus = _ctx.StringValue("QueryTaskDetailHistory.CurrentPageCursor.TaskStatus");
			currentPageCursor.TaskTypeDescription = _ctx.StringValue("QueryTaskDetailHistory.CurrentPageCursor.TaskTypeDescription");
			currentPageCursor.TryCount = _ctx.IntegerValue("QueryTaskDetailHistory.CurrentPageCursor.TryCount");
			currentPageCursor.ErrorMsg = _ctx.StringValue("QueryTaskDetailHistory.CurrentPageCursor.ErrorMsg");
			queryTaskDetailHistoryResponse.CurrentPageCursor = currentPageCursor;

			QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_PrePageCursor prePageCursor = new QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_PrePageCursor();
			prePageCursor.UpdateTime = _ctx.StringValue("QueryTaskDetailHistory.PrePageCursor.UpdateTime");
			prePageCursor.TaskDetailNo = _ctx.StringValue("QueryTaskDetailHistory.PrePageCursor.TaskDetailNo");
			prePageCursor.CreateTime = _ctx.StringValue("QueryTaskDetailHistory.PrePageCursor.CreateTime");
			prePageCursor.InstanceId = _ctx.StringValue("QueryTaskDetailHistory.PrePageCursor.InstanceId");
			prePageCursor.DomainName = _ctx.StringValue("QueryTaskDetailHistory.PrePageCursor.DomainName");
			prePageCursor.TaskType = _ctx.StringValue("QueryTaskDetailHistory.PrePageCursor.TaskType");
			prePageCursor.TaskNo = _ctx.StringValue("QueryTaskDetailHistory.PrePageCursor.TaskNo");
			prePageCursor.TaskStatusCode = _ctx.IntegerValue("QueryTaskDetailHistory.PrePageCursor.TaskStatusCode");
			prePageCursor.TaskStatus = _ctx.StringValue("QueryTaskDetailHistory.PrePageCursor.TaskStatus");
			prePageCursor.TaskTypeDescription = _ctx.StringValue("QueryTaskDetailHistory.PrePageCursor.TaskTypeDescription");
			prePageCursor.TryCount = _ctx.IntegerValue("QueryTaskDetailHistory.PrePageCursor.TryCount");
			prePageCursor.ErrorMsg = _ctx.StringValue("QueryTaskDetailHistory.PrePageCursor.ErrorMsg");
			queryTaskDetailHistoryResponse.PrePageCursor = prePageCursor;

			QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_NextPageCursor nextPageCursor = new QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_NextPageCursor();
			nextPageCursor.UpdateTime = _ctx.StringValue("QueryTaskDetailHistory.NextPageCursor.UpdateTime");
			nextPageCursor.TaskDetailNo = _ctx.StringValue("QueryTaskDetailHistory.NextPageCursor.TaskDetailNo");
			nextPageCursor.CreateTime = _ctx.StringValue("QueryTaskDetailHistory.NextPageCursor.CreateTime");
			nextPageCursor.InstanceId = _ctx.StringValue("QueryTaskDetailHistory.NextPageCursor.InstanceId");
			nextPageCursor.DomainName = _ctx.StringValue("QueryTaskDetailHistory.NextPageCursor.DomainName");
			nextPageCursor.TaskType = _ctx.StringValue("QueryTaskDetailHistory.NextPageCursor.TaskType");
			nextPageCursor.TaskNo = _ctx.StringValue("QueryTaskDetailHistory.NextPageCursor.TaskNo");
			nextPageCursor.TaskStatusCode = _ctx.IntegerValue("QueryTaskDetailHistory.NextPageCursor.TaskStatusCode");
			nextPageCursor.TaskStatus = _ctx.StringValue("QueryTaskDetailHistory.NextPageCursor.TaskStatus");
			nextPageCursor.TaskTypeDescription = _ctx.StringValue("QueryTaskDetailHistory.NextPageCursor.TaskTypeDescription");
			nextPageCursor.TryCount = _ctx.IntegerValue("QueryTaskDetailHistory.NextPageCursor.TryCount");
			nextPageCursor.ErrorMsg = _ctx.StringValue("QueryTaskDetailHistory.NextPageCursor.ErrorMsg");
			queryTaskDetailHistoryResponse.NextPageCursor = nextPageCursor;

			List<QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_TaskDetailHistory> queryTaskDetailHistoryResponse_objects = new List<QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_TaskDetailHistory>();
			for (int i = 0; i < _ctx.Length("QueryTaskDetailHistory.Objects.Length"); i++) {
				QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_TaskDetailHistory taskDetailHistory = new QueryTaskDetailHistoryResponse.QueryTaskDetailHistory_TaskDetailHistory();
				taskDetailHistory.UpdateTime = _ctx.StringValue("QueryTaskDetailHistory.Objects["+ i +"].UpdateTime");
				taskDetailHistory.TaskDetailNo = _ctx.StringValue("QueryTaskDetailHistory.Objects["+ i +"].TaskDetailNo");
				taskDetailHistory.CreateTime = _ctx.StringValue("QueryTaskDetailHistory.Objects["+ i +"].CreateTime");
				taskDetailHistory.InstanceId = _ctx.StringValue("QueryTaskDetailHistory.Objects["+ i +"].InstanceId");
				taskDetailHistory.DomainName = _ctx.StringValue("QueryTaskDetailHistory.Objects["+ i +"].DomainName");
				taskDetailHistory.TaskType = _ctx.StringValue("QueryTaskDetailHistory.Objects["+ i +"].TaskType");
				taskDetailHistory.TaskNo = _ctx.StringValue("QueryTaskDetailHistory.Objects["+ i +"].TaskNo");
				taskDetailHistory.TaskStatusCode = _ctx.IntegerValue("QueryTaskDetailHistory.Objects["+ i +"].TaskStatusCode");
				taskDetailHistory.TaskStatus = _ctx.StringValue("QueryTaskDetailHistory.Objects["+ i +"].TaskStatus");
				taskDetailHistory.TaskTypeDescription = _ctx.StringValue("QueryTaskDetailHistory.Objects["+ i +"].TaskTypeDescription");
				taskDetailHistory.TryCount = _ctx.IntegerValue("QueryTaskDetailHistory.Objects["+ i +"].TryCount");
				taskDetailHistory.ErrorMsg = _ctx.StringValue("QueryTaskDetailHistory.Objects["+ i +"].ErrorMsg");

				queryTaskDetailHistoryResponse_objects.Add(taskDetailHistory);
			}
			queryTaskDetailHistoryResponse.Objects = queryTaskDetailHistoryResponse_objects;
        
			return queryTaskDetailHistoryResponse;
        }
    }
}
