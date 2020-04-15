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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
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
			queryTaskListResponse.PageSize = context.IntegerValue("QueryTaskList.PageSize");
			queryTaskListResponse.TotalPageNum = context.IntegerValue("QueryTaskList.TotalPageNum");

			List<QueryTaskListResponse.QueryTaskList_TaskList> queryTaskListResponse_data = new List<QueryTaskListResponse.QueryTaskList_TaskList>();
			for (int i = 0; i < context.Length("QueryTaskList.Data.Length"); i++) {
				QueryTaskListResponse.QueryTaskList_TaskList taskList = new QueryTaskListResponse.QueryTaskList_TaskList();
				taskList.TaskStatus = context.StringValue("QueryTaskList.Data["+ i +"].TaskStatus");
				taskList.TaskType = context.StringValue("QueryTaskList.Data["+ i +"].TaskType");
				taskList.ErrMsg = context.StringValue("QueryTaskList.Data["+ i +"].ErrMsg");
				taskList.Result = context.StringValue("QueryTaskList.Data["+ i +"].Result");
				taskList.FileName = context.StringValue("QueryTaskList.Data["+ i +"].FileName");
				taskList.CreateTime = context.LongValue("QueryTaskList.Data["+ i +"].CreateTime");
				taskList.CompleteTime = context.LongValue("QueryTaskList.Data["+ i +"].CompleteTime");

				queryTaskListResponse_data.Add(taskList);
			}
			queryTaskListResponse.Data = queryTaskListResponse_data;
        
			return queryTaskListResponse;
        }
    }
}
