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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListDISyncTasksResponseUnmarshaller
    {
        public static ListDISyncTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDISyncTasksResponse listDISyncTasksResponse = new ListDISyncTasksResponse();

			listDISyncTasksResponse.HttpResponse = _ctx.HttpResponse;
			listDISyncTasksResponse.RequestId = _ctx.StringValue("ListDISyncTasks.RequestId");
			listDISyncTasksResponse.Success = _ctx.BooleanValue("ListDISyncTasks.Success");

			ListDISyncTasksResponse.ListDISyncTasks_TaskList taskList = new ListDISyncTasksResponse.ListDISyncTasks_TaskList();
			taskList.PageNumber = _ctx.IntegerValue("ListDISyncTasks.TaskList.PageNumber");
			taskList.PageSize = _ctx.IntegerValue("ListDISyncTasks.TaskList.PageSize");
			taskList.TotalCount = _ctx.IntegerValue("ListDISyncTasks.TaskList.TotalCount");

			List<ListDISyncTasksResponse.ListDISyncTasks_TaskList.ListDISyncTasks_RealTimeSolutionListItem> taskList_realTimeSolutionList = new List<ListDISyncTasksResponse.ListDISyncTasks_TaskList.ListDISyncTasks_RealTimeSolutionListItem>();
			for (int i = 0; i < _ctx.Length("ListDISyncTasks.TaskList.RealTimeSolutionList.Length"); i++) {
				ListDISyncTasksResponse.ListDISyncTasks_TaskList.ListDISyncTasks_RealTimeSolutionListItem realTimeSolutionListItem = new ListDISyncTasksResponse.ListDISyncTasks_TaskList.ListDISyncTasks_RealTimeSolutionListItem();
				realTimeSolutionListItem.ProcessId = _ctx.LongValue("ListDISyncTasks.TaskList.RealTimeSolutionList["+ i +"].ProcessId");
				realTimeSolutionListItem.ProcessName = _ctx.StringValue("ListDISyncTasks.TaskList.RealTimeSolutionList["+ i +"].ProcessName");
				realTimeSolutionListItem.TaskStatus = _ctx.StringValue("ListDISyncTasks.TaskList.RealTimeSolutionList["+ i +"].TaskStatus");
				realTimeSolutionListItem.TaskType = _ctx.StringValue("ListDISyncTasks.TaskList.RealTimeSolutionList["+ i +"].TaskType");
				realTimeSolutionListItem.CreateTime = _ctx.LongValue("ListDISyncTasks.TaskList.RealTimeSolutionList["+ i +"].CreateTime");

				taskList_realTimeSolutionList.Add(realTimeSolutionListItem);
			}
			taskList.RealTimeSolutionList = taskList_realTimeSolutionList;
			listDISyncTasksResponse.TaskList = taskList;
        
			return listDISyncTasksResponse;
        }
    }
}
