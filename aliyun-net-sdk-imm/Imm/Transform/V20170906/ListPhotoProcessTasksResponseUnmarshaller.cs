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
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListPhotoProcessTasksResponseUnmarshaller
    {
        public static ListPhotoProcessTasksResponse Unmarshall(UnmarshallerContext context)
        {
			ListPhotoProcessTasksResponse listPhotoProcessTasksResponse = new ListPhotoProcessTasksResponse();

			listPhotoProcessTasksResponse.HttpResponse = context.HttpResponse;
			listPhotoProcessTasksResponse.RequestId = context.StringValue("ListPhotoProcessTasks.RequestId");
			listPhotoProcessTasksResponse.NextMarker = context.StringValue("ListPhotoProcessTasks.NextMarker");

			List<ListPhotoProcessTasksResponse.ListPhotoProcessTasks_TasksItem> listPhotoProcessTasksResponse_tasks = new List<ListPhotoProcessTasksResponse.ListPhotoProcessTasks_TasksItem>();
			for (int i = 0; i < context.Length("ListPhotoProcessTasks.Tasks.Length"); i++) {
				ListPhotoProcessTasksResponse.ListPhotoProcessTasks_TasksItem tasksItem = new ListPhotoProcessTasksResponse.ListPhotoProcessTasks_TasksItem();
				tasksItem.TaskId = context.StringValue("ListPhotoProcessTasks.Tasks["+ i +"].TaskId");
				tasksItem.Status = context.StringValue("ListPhotoProcessTasks.Tasks["+ i +"].Status");
				tasksItem.SrcUri = context.StringValue("ListPhotoProcessTasks.Tasks["+ i +"].SrcUri");
				tasksItem.TgtUri = context.StringValue("ListPhotoProcessTasks.Tasks["+ i +"].TgtUri");
				tasksItem.Style = context.StringValue("ListPhotoProcessTasks.Tasks["+ i +"].Style");
				tasksItem.NotifyTopicName = context.StringValue("ListPhotoProcessTasks.Tasks["+ i +"].NotifyTopicName");
				tasksItem.NotifyEndpoint = context.StringValue("ListPhotoProcessTasks.Tasks["+ i +"].NotifyEndpoint");
				tasksItem.ExternalID = context.StringValue("ListPhotoProcessTasks.Tasks["+ i +"].ExternalID");
				tasksItem.CreateTime = context.StringValue("ListPhotoProcessTasks.Tasks["+ i +"].CreateTime");
				tasksItem.FinishTime = context.StringValue("ListPhotoProcessTasks.Tasks["+ i +"].FinishTime");
				tasksItem.Percent = context.IntegerValue("ListPhotoProcessTasks.Tasks["+ i +"].Percent");

				listPhotoProcessTasksResponse_tasks.Add(tasksItem);
			}
			listPhotoProcessTasksResponse.Tasks = listPhotoProcessTasksResponse_tasks;
        
			return listPhotoProcessTasksResponse;
        }
    }
}