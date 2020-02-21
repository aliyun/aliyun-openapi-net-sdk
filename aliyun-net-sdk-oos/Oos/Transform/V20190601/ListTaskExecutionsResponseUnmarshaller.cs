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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListTaskExecutionsResponseUnmarshaller
    {
        public static ListTaskExecutionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTaskExecutionsResponse listTaskExecutionsResponse = new ListTaskExecutionsResponse();

			listTaskExecutionsResponse.HttpResponse = context.HttpResponse;
			listTaskExecutionsResponse.RequestId = context.StringValue("ListTaskExecutions.RequestId");
			listTaskExecutionsResponse.MaxResults = context.IntegerValue("ListTaskExecutions.MaxResults");
			listTaskExecutionsResponse.NextToken = context.StringValue("ListTaskExecutions.NextToken");

			List<ListTaskExecutionsResponse.ListTaskExecutions_TaskExecution> listTaskExecutionsResponse_taskExecutions = new List<ListTaskExecutionsResponse.ListTaskExecutions_TaskExecution>();
			for (int i = 0; i < context.Length("ListTaskExecutions.TaskExecutions.Length"); i++) {
				ListTaskExecutionsResponse.ListTaskExecutions_TaskExecution taskExecution = new ListTaskExecutionsResponse.ListTaskExecutions_TaskExecution();
				taskExecution.ExecutionId = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].ExecutionId");
				taskExecution.TaskExecutionId = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].TaskExecutionId");
				taskExecution.TemplateId = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].TemplateId");
				taskExecution.StartDate = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].StartDate");
				taskExecution.EndDate = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].EndDate");
				taskExecution.CreateDate = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].CreateDate");
				taskExecution.UpdateDate = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].UpdateDate");
				taskExecution.Status = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].Status");
				taskExecution.Properties = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].Properties");
				taskExecution.Outputs = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].Outputs");
				taskExecution.TaskAction = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].TaskAction");
				taskExecution.TaskName = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].TaskName");
				taskExecution.StatusMessage = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].StatusMessage");
				taskExecution.ChildExecutionId = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].ChildExecutionId");
				taskExecution.ParentTaskExecutionId = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].ParentTaskExecutionId");
				taskExecution.LoopItem = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].LoopItem");
				taskExecution.Loop = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].Loop");
				taskExecution.ExtraData = context.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].ExtraData");
				taskExecution.LoopBatchNumber = context.IntegerValue("ListTaskExecutions.TaskExecutions["+ i +"].LoopBatchNumber");

				listTaskExecutionsResponse_taskExecutions.Add(taskExecution);
			}
			listTaskExecutionsResponse.TaskExecutions = listTaskExecutionsResponse_taskExecutions;
        
			return listTaskExecutionsResponse;
        }
    }
}
