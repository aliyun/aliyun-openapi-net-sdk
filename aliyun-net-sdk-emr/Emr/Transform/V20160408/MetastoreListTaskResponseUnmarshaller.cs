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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class MetastoreListTaskResponseUnmarshaller
    {
        public static MetastoreListTaskResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreListTaskResponse metastoreListTaskResponse = new MetastoreListTaskResponse();

			metastoreListTaskResponse.HttpResponse = context.HttpResponse;
			metastoreListTaskResponse.RequestId = context.StringValue("MetastoreListTask.RequestId");
			metastoreListTaskResponse.TotalCount = context.IntegerValue("MetastoreListTask.TotalCount");
			metastoreListTaskResponse.PageNumber = context.IntegerValue("MetastoreListTask.PageNumber");
			metastoreListTaskResponse.PageSize = context.IntegerValue("MetastoreListTask.PageSize");

			List<MetastoreListTaskResponse.MetastoreListTask_Task> metastoreListTaskResponse_taskList = new List<MetastoreListTaskResponse.MetastoreListTask_Task>();
			for (int i = 0; i < context.Length("MetastoreListTask.TaskList.Length"); i++) {
				MetastoreListTaskResponse.MetastoreListTask_Task task = new MetastoreListTaskResponse.MetastoreListTask_Task();
				task.BizId = context.StringValue("MetastoreListTask.TaskList["+ i +"].BizId");
				task.TaskType = context.StringValue("MetastoreListTask.TaskList["+ i +"].TaskType");
				task.TaskObject = context.StringValue("MetastoreListTask.TaskList["+ i +"].TaskObject");
				task.TaskStatus = context.StringValue("MetastoreListTask.TaskList["+ i +"].TaskStatus");
				task.StartTime = context.LongValue("MetastoreListTask.TaskList["+ i +"].StartTime");
				task.EndTime = context.LongValue("MetastoreListTask.TaskList["+ i +"].EndTime");
				task.TaskProcess = context.IntegerValue("MetastoreListTask.TaskList["+ i +"].TaskProcess");
				task.TriggerUser = context.StringValue("MetastoreListTask.TaskList["+ i +"].TriggerUser");
				task.TriggerType = context.StringValue("MetastoreListTask.TaskList["+ i +"].TriggerType");
				task.GmtCreate = context.LongValue("MetastoreListTask.TaskList["+ i +"].GmtCreate");
				task.GmtModified = context.LongValue("MetastoreListTask.TaskList["+ i +"].GmtModified");
				task.ExecuteTime = context.LongValue("MetastoreListTask.TaskList["+ i +"].ExecuteTime");

				metastoreListTaskResponse_taskList.Add(task);
			}
			metastoreListTaskResponse.TaskList = metastoreListTaskResponse_taskList;
        
			return metastoreListTaskResponse;
        }
    }
}
