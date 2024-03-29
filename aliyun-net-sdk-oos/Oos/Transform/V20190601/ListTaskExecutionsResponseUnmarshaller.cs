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
        public static ListTaskExecutionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTaskExecutionsResponse listTaskExecutionsResponse = new ListTaskExecutionsResponse();

			listTaskExecutionsResponse.HttpResponse = _ctx.HttpResponse;
			listTaskExecutionsResponse.NextToken = _ctx.StringValue("ListTaskExecutions.NextToken");
			listTaskExecutionsResponse.RequestId = _ctx.StringValue("ListTaskExecutions.RequestId");
			listTaskExecutionsResponse.MaxResults = _ctx.IntegerValue("ListTaskExecutions.MaxResults");

			List<ListTaskExecutionsResponse.ListTaskExecutions_TaskExecution> listTaskExecutionsResponse_taskExecutions = new List<ListTaskExecutionsResponse.ListTaskExecutions_TaskExecution>();
			for (int i = 0; i < _ctx.Length("ListTaskExecutions.TaskExecutions.Length"); i++) {
				ListTaskExecutionsResponse.ListTaskExecutions_TaskExecution taskExecution = new ListTaskExecutionsResponse.ListTaskExecutions_TaskExecution();
				taskExecution.ChildExecutionId = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].ChildExecutionId");
				taskExecution.Outputs = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].Outputs");
				taskExecution.Status = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].Status");
				taskExecution.EndDate = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].EndDate");
				taskExecution.ParentTaskExecutionId = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].ParentTaskExecutionId");
				taskExecution.TaskName = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].TaskName");
				taskExecution.StartDate = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].StartDate");
				taskExecution.LoopItem = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].LoopItem");
				taskExecution.CreateDate = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].CreateDate");
				taskExecution.ExecutionId = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].ExecutionId");
				taskExecution.TaskAction = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].TaskAction");
				taskExecution.TaskExecutionId = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].TaskExecutionId");
				taskExecution.UpdateDate = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].UpdateDate");
				taskExecution.Loop = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].Loop");
				taskExecution.TemplateId = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].TemplateId");
				taskExecution.LoopBatchNumber = _ctx.IntegerValue("ListTaskExecutions.TaskExecutions["+ i +"].LoopBatchNumber");
				taskExecution.StatusMessage = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].StatusMessage");
				taskExecution.ExtraData = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].ExtraData");
				taskExecution.Properties = _ctx.StringValue("ListTaskExecutions.TaskExecutions["+ i +"].Properties");

				listTaskExecutionsResponse_taskExecutions.Add(taskExecution);
			}
			listTaskExecutionsResponse.TaskExecutions = listTaskExecutionsResponse_taskExecutions;
        
			return listTaskExecutionsResponse;
        }
    }
}
