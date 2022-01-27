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
        public static StartExecutionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartExecutionResponse startExecutionResponse = new StartExecutionResponse();

			startExecutionResponse.HttpResponse = _ctx.HttpResponse;
			startExecutionResponse.RequestId = _ctx.StringValue("StartExecution.RequestId");

			StartExecutionResponse.StartExecution_Execution execution = new StartExecutionResponse.StartExecution_Execution();
			execution.ExecutionId = _ctx.StringValue("StartExecution.Execution.ExecutionId");
			execution.TemplateName = _ctx.StringValue("StartExecution.Execution.TemplateName");
			execution.TemplateId = _ctx.StringValue("StartExecution.Execution.TemplateId");
			execution.TemplateVersion = _ctx.StringValue("StartExecution.Execution.TemplateVersion");
			execution.Mode = _ctx.StringValue("StartExecution.Execution.Mode");
			execution.LoopMode = _ctx.StringValue("StartExecution.Execution.LoopMode");
			execution.ExecutedBy = _ctx.StringValue("StartExecution.Execution.ExecutedBy");
			execution.StartDate = _ctx.StringValue("StartExecution.Execution.StartDate");
			execution.EndDate = _ctx.StringValue("StartExecution.Execution.EndDate");
			execution.CreateDate = _ctx.StringValue("StartExecution.Execution.CreateDate");
			execution.UpdateDate = _ctx.StringValue("StartExecution.Execution.UpdateDate");
			execution.Status = _ctx.StringValue("StartExecution.Execution.Status");
			execution.StatusMessage = _ctx.StringValue("StartExecution.Execution.StatusMessage");
			execution.ParentExecutionId = _ctx.StringValue("StartExecution.Execution.ParentExecutionId");
			execution.Parameters = _ctx.StringValue("StartExecution.Execution.Parameters");
			execution.Outputs = _ctx.StringValue("StartExecution.Execution.Outputs");
			execution.SafetyCheck = _ctx.StringValue("StartExecution.Execution.SafetyCheck");
			execution.IsParent = _ctx.BooleanValue("StartExecution.Execution.IsParent");
			execution.Counters = _ctx.StringValue("StartExecution.Execution.Counters");
			execution.RamRole = _ctx.StringValue("StartExecution.Execution.RamRole");
			execution.Tags = _ctx.StringValue("StartExecution.Execution.Tags");
			execution.Description = _ctx.StringValue("StartExecution.Execution.Description");

			List<StartExecutionResponse.StartExecution_Execution.StartExecution_CurrentTask> execution_currentTasks = new List<StartExecutionResponse.StartExecution_Execution.StartExecution_CurrentTask>();
			for (int i = 0; i < _ctx.Length("StartExecution.Execution.CurrentTasks.Length"); i++) {
				StartExecutionResponse.StartExecution_Execution.StartExecution_CurrentTask currentTask = new StartExecutionResponse.StartExecution_Execution.StartExecution_CurrentTask();
				currentTask.TaskExecutionId = _ctx.StringValue("StartExecution.Execution.CurrentTasks["+ i +"].TaskExecutionId");
				currentTask.TaskName = _ctx.StringValue("StartExecution.Execution.CurrentTasks["+ i +"].TaskName");
				currentTask.TaskAction = _ctx.StringValue("StartExecution.Execution.CurrentTasks["+ i +"].TaskAction");

				execution_currentTasks.Add(currentTask);
			}
			execution.CurrentTasks = execution_currentTasks;
			startExecutionResponse.Execution = execution;
        
			return startExecutionResponse;
        }
    }
}
