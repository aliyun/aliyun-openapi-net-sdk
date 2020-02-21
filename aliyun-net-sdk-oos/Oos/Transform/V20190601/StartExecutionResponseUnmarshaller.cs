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
    public class StartExecutionResponseUnmarshaller
    {
        public static StartExecutionResponse Unmarshall(UnmarshallerContext context)
        {
			StartExecutionResponse startExecutionResponse = new StartExecutionResponse();

			startExecutionResponse.HttpResponse = context.HttpResponse;
			startExecutionResponse.RequestId = context.StringValue("StartExecution.RequestId");

			StartExecutionResponse.StartExecution_Execution execution = new StartExecutionResponse.StartExecution_Execution();
			execution.ExecutionId = context.StringValue("StartExecution.Execution.ExecutionId");
			execution.TemplateName = context.StringValue("StartExecution.Execution.TemplateName");
			execution.TemplateId = context.StringValue("StartExecution.Execution.TemplateId");
			execution.TemplateVersion = context.StringValue("StartExecution.Execution.TemplateVersion");
			execution.Mode = context.StringValue("StartExecution.Execution.Mode");
			execution.LoopMode = context.StringValue("StartExecution.Execution.LoopMode");
			execution.ExecutedBy = context.StringValue("StartExecution.Execution.ExecutedBy");
			execution.StartDate = context.StringValue("StartExecution.Execution.StartDate");
			execution.EndDate = context.StringValue("StartExecution.Execution.EndDate");
			execution.CreateDate = context.StringValue("StartExecution.Execution.CreateDate");
			execution.UpdateDate = context.StringValue("StartExecution.Execution.UpdateDate");
			execution.Status = context.StringValue("StartExecution.Execution.Status");
			execution.StatusMessage = context.StringValue("StartExecution.Execution.StatusMessage");
			execution.ParentExecutionId = context.StringValue("StartExecution.Execution.ParentExecutionId");
			execution.Parameters = context.StringValue("StartExecution.Execution.Parameters");
			execution.Outputs = context.StringValue("StartExecution.Execution.Outputs");
			execution.SafetyCheck = context.StringValue("StartExecution.Execution.SafetyCheck");
			execution.IsParent = context.BooleanValue("StartExecution.Execution.IsParent");
			execution.Counters = context.StringValue("StartExecution.Execution.Counters");
			execution.RamRole = context.StringValue("StartExecution.Execution.RamRole");
			execution.Tags = context.StringValue("StartExecution.Execution.Tags");
			execution.Description = context.StringValue("StartExecution.Execution.Description");

			List<StartExecutionResponse.StartExecution_Execution.StartExecution_CurrentTask> execution_currentTasks = new List<StartExecutionResponse.StartExecution_Execution.StartExecution_CurrentTask>();
			for (int i = 0; i < context.Length("StartExecution.Execution.CurrentTasks.Length"); i++) {
				StartExecutionResponse.StartExecution_Execution.StartExecution_CurrentTask currentTask = new StartExecutionResponse.StartExecution_Execution.StartExecution_CurrentTask();
				currentTask.TaskExecutionId = context.StringValue("StartExecution.Execution.CurrentTasks["+ i +"].TaskExecutionId");
				currentTask.TaskName = context.StringValue("StartExecution.Execution.CurrentTasks["+ i +"].TaskName");
				currentTask.TaskAction = context.StringValue("StartExecution.Execution.CurrentTasks["+ i +"].TaskAction");

				execution_currentTasks.Add(currentTask);
			}
			execution.CurrentTasks = execution_currentTasks;
			startExecutionResponse.Execution = execution;
        
			return startExecutionResponse;
        }
    }
}
