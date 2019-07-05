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
        public static QueryTaskListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTaskListResponse queryTaskListResponse = new QueryTaskListResponse();

			queryTaskListResponse.HttpResponse = context.HttpResponse;
			queryTaskListResponse.RequestId = context.StringValue("QueryTaskList.RequestId");
			queryTaskListResponse.TotalItemNum = context.IntegerValue("QueryTaskList.TotalItemNum");
			queryTaskListResponse.CurrentPageNum = context.IntegerValue("QueryTaskList.CurrentPageNum");
			queryTaskListResponse.TotalPageNum = context.IntegerValue("QueryTaskList.TotalPageNum");
			queryTaskListResponse.PageSize = context.IntegerValue("QueryTaskList.PageSize");
			queryTaskListResponse.PrePage = context.BooleanValue("QueryTaskList.PrePage");
			queryTaskListResponse.NextPage = context.BooleanValue("QueryTaskList.NextPage");

			List<QueryTaskListResponse.QueryTaskList_TaskInfo> queryTaskListResponse_data = new List<QueryTaskListResponse.QueryTaskList_TaskInfo>();
			for (int i = 0; i < context.Length("QueryTaskList.Data.Length"); i++) {
				QueryTaskListResponse.QueryTaskList_TaskInfo taskInfo = new QueryTaskListResponse.QueryTaskList_TaskInfo();
				taskInfo.TaskType = context.StringValue("QueryTaskList.Data["+ i +"].TaskType");
				taskInfo.TaskNum = context.IntegerValue("QueryTaskList.Data["+ i +"].TaskNum");
				taskInfo.TaskStatus = context.StringValue("QueryTaskList.Data["+ i +"].TaskStatus");
				taskInfo.CreateTime = context.StringValue("QueryTaskList.Data["+ i +"].CreateTime");
				taskInfo.Clientip = context.StringValue("QueryTaskList.Data["+ i +"].Clientip");
				taskInfo.TaskNo = context.StringValue("QueryTaskList.Data["+ i +"].TaskNo");
				taskInfo.TaskStatusCode = context.IntegerValue("QueryTaskList.Data["+ i +"].TaskStatusCode");
				taskInfo.TaskTypeDescription = context.StringValue("QueryTaskList.Data["+ i +"].TaskTypeDescription");
				taskInfo.TaskCancelStatus = context.StringValue("QueryTaskList.Data["+ i +"].TaskCancelStatus");
				taskInfo.TaskCancelStatusCode = context.IntegerValue("QueryTaskList.Data["+ i +"].TaskCancelStatusCode");

				queryTaskListResponse_data.Add(taskInfo);
			}
			queryTaskListResponse.Data = queryTaskListResponse_data;
        
			return queryTaskListResponse;
        }
    }
}
