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
    public class QueryTaskListResponseUnmarshaller
    {
        public static QueryTaskListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTaskListResponse queryTaskListResponse = new QueryTaskListResponse();

			queryTaskListResponse.HttpResponse = _ctx.HttpResponse;
			queryTaskListResponse.PrePage = _ctx.BooleanValue("QueryTaskList.PrePage");
			queryTaskListResponse.CurrentPageNum = _ctx.IntegerValue("QueryTaskList.CurrentPageNum");
			queryTaskListResponse.RequestId = _ctx.StringValue("QueryTaskList.RequestId");
			queryTaskListResponse.PageSize = _ctx.IntegerValue("QueryTaskList.PageSize");
			queryTaskListResponse.TotalPageNum = _ctx.IntegerValue("QueryTaskList.TotalPageNum");
			queryTaskListResponse.TotalItemNum = _ctx.IntegerValue("QueryTaskList.TotalItemNum");
			queryTaskListResponse.NextPage = _ctx.BooleanValue("QueryTaskList.NextPage");

			List<QueryTaskListResponse.QueryTaskList_TaskInfo> queryTaskListResponse_data = new List<QueryTaskListResponse.QueryTaskList_TaskInfo>();
			for (int i = 0; i < _ctx.Length("QueryTaskList.Data.Length"); i++) {
				QueryTaskListResponse.QueryTaskList_TaskInfo taskInfo = new QueryTaskListResponse.QueryTaskList_TaskInfo();
				taskInfo.TaskType = _ctx.StringValue("QueryTaskList.Data["+ i +"].TaskType");
				taskInfo.TaskCancelStatus = _ctx.StringValue("QueryTaskList.Data["+ i +"].TaskCancelStatus");
				taskInfo.TaskNo = _ctx.StringValue("QueryTaskList.Data["+ i +"].TaskNo");
				taskInfo.TaskCancelStatusCode = _ctx.IntegerValue("QueryTaskList.Data["+ i +"].TaskCancelStatusCode");
				taskInfo.TaskStatusCode = _ctx.IntegerValue("QueryTaskList.Data["+ i +"].TaskStatusCode");
				taskInfo.TaskStatus = _ctx.StringValue("QueryTaskList.Data["+ i +"].TaskStatus");
				taskInfo.TaskTypeDescription = _ctx.StringValue("QueryTaskList.Data["+ i +"].TaskTypeDescription");
				taskInfo.TaskNum = _ctx.IntegerValue("QueryTaskList.Data["+ i +"].TaskNum");
				taskInfo.CreateTime = _ctx.StringValue("QueryTaskList.Data["+ i +"].CreateTime");
				taskInfo.Clientip = _ctx.StringValue("QueryTaskList.Data["+ i +"].Clientip");

				queryTaskListResponse_data.Add(taskInfo);
			}
			queryTaskListResponse.Data = queryTaskListResponse_data;
        
			return queryTaskListResponse;
        }
    }
}
