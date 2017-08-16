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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Domain.Model.V20160511;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class QueryBatchTaskListResponseUnmarshaller
    {
        public static QueryBatchTaskListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryBatchTaskListResponse queryBatchTaskListResponse = new QueryBatchTaskListResponse();

			queryBatchTaskListResponse.HttpResponse = context.HttpResponse;
			queryBatchTaskListResponse.RequestId = context.StringValue("QueryBatchTaskList.RequestId");
			queryBatchTaskListResponse.TotalItemNum = context.IntegerValue("QueryBatchTaskList.TotalItemNum");
			queryBatchTaskListResponse.CurrentPageNum = context.IntegerValue("QueryBatchTaskList.CurrentPageNum");
			queryBatchTaskListResponse.TotalPageNum = context.IntegerValue("QueryBatchTaskList.TotalPageNum");
			queryBatchTaskListResponse.PageSize = context.IntegerValue("QueryBatchTaskList.PageSize");
			queryBatchTaskListResponse.PrePage = context.BooleanValue("QueryBatchTaskList.PrePage");
			queryBatchTaskListResponse.NextPage = context.BooleanValue("QueryBatchTaskList.NextPage");

			List<QueryBatchTaskListResponse.QueryBatchTaskList_TaskInfo> queryBatchTaskListResponse_data = new List<QueryBatchTaskListResponse.QueryBatchTaskList_TaskInfo>();
			for (int i = 0; i < context.Length("QueryBatchTaskList.Data.Length"); i++) {
				QueryBatchTaskListResponse.QueryBatchTaskList_TaskInfo taskInfo = new QueryBatchTaskListResponse.QueryBatchTaskList_TaskInfo();
				taskInfo.TaskType = context.StringValue("QueryBatchTaskList.Data["+ i +"].TaskType");
				taskInfo.TaskNum = context.IntegerValue("QueryBatchTaskList.Data["+ i +"].TaskNum");
				taskInfo.TaskStatus = context.StringValue("QueryBatchTaskList.Data["+ i +"].TaskStatus");
				taskInfo.CreateTime = context.StringValue("QueryBatchTaskList.Data["+ i +"].CreateTime");
				taskInfo.Clientip = context.StringValue("QueryBatchTaskList.Data["+ i +"].Clientip");
				taskInfo.TaskNo = context.StringValue("QueryBatchTaskList.Data["+ i +"].TaskNo");

				queryBatchTaskListResponse_data.Add(taskInfo);
			}
			queryBatchTaskListResponse.Data = queryBatchTaskListResponse_data;
        
			return queryBatchTaskListResponse;
        }
    }
}