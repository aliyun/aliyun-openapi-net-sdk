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
    public class ListExecutionsResponseUnmarshaller
    {
        public static ListExecutionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListExecutionsResponse listExecutionsResponse = new ListExecutionsResponse();

			listExecutionsResponse.HttpResponse = _ctx.HttpResponse;
			listExecutionsResponse.RequestId = _ctx.StringValue("ListExecutions.RequestId");
			listExecutionsResponse.MaxResults = _ctx.IntegerValue("ListExecutions.MaxResults");
			listExecutionsResponse.NextToken = _ctx.StringValue("ListExecutions.NextToken");

			List<ListExecutionsResponse.ListExecutions_Execution> listExecutionsResponse_executions = new List<ListExecutionsResponse.ListExecutions_Execution>();
			for (int i = 0; i < _ctx.Length("ListExecutions.Executions.Length"); i++) {
				ListExecutionsResponse.ListExecutions_Execution execution = new ListExecutionsResponse.ListExecutions_Execution();
				execution.ExecutionId = _ctx.StringValue("ListExecutions.Executions["+ i +"].ExecutionId");
				execution.TemplateName = _ctx.StringValue("ListExecutions.Executions["+ i +"].TemplateName");
				execution.TemplateId = _ctx.StringValue("ListExecutions.Executions["+ i +"].TemplateId");
				execution.TemplateVersion = _ctx.StringValue("ListExecutions.Executions["+ i +"].TemplateVersion");
				execution.Mode = _ctx.StringValue("ListExecutions.Executions["+ i +"].Mode");
				execution.ExecutedBy = _ctx.StringValue("ListExecutions.Executions["+ i +"].ExecutedBy");
				execution.StartDate = _ctx.StringValue("ListExecutions.Executions["+ i +"].StartDate");
				execution.EndDate = _ctx.StringValue("ListExecutions.Executions["+ i +"].EndDate");
				execution.CreateDate = _ctx.StringValue("ListExecutions.Executions["+ i +"].CreateDate");
				execution.UpdateDate = _ctx.StringValue("ListExecutions.Executions["+ i +"].UpdateDate");
				execution.Status = _ctx.StringValue("ListExecutions.Executions["+ i +"].Status");
				execution.StatusMessage = _ctx.StringValue("ListExecutions.Executions["+ i +"].StatusMessage");
				execution.StatusReason = _ctx.StringValue("ListExecutions.Executions["+ i +"].StatusReason");
				execution.WaitingStatus = _ctx.StringValue("ListExecutions.Executions["+ i +"].WaitingStatus");
				execution.ParentExecutionId = _ctx.StringValue("ListExecutions.Executions["+ i +"].ParentExecutionId");
				execution.Parameters = _ctx.StringValue("ListExecutions.Executions["+ i +"].Parameters");
				execution.Outputs = _ctx.StringValue("ListExecutions.Executions["+ i +"].Outputs");
				execution.SafetyCheck = _ctx.StringValue("ListExecutions.Executions["+ i +"].SafetyCheck");
				execution.IsParent = _ctx.BooleanValue("ListExecutions.Executions["+ i +"].IsParent");
				execution.RamRole = _ctx.StringValue("ListExecutions.Executions["+ i +"].RamRole");
				execution.Counters = _ctx.StringValue("ListExecutions.Executions["+ i +"].Counters");
				execution.Category = _ctx.StringValue("ListExecutions.Executions["+ i +"].Category");
				execution.Tags = _ctx.StringValue("ListExecutions.Executions["+ i +"].Tags");
				execution.Description = _ctx.StringValue("ListExecutions.Executions["+ i +"].Description");
				execution.Targets = _ctx.StringValue("ListExecutions.Executions["+ i +"].Targets");
				execution.LastTriggerTime = _ctx.StringValue("ListExecutions.Executions["+ i +"].LastTriggerTime");
				execution.LastTriggerStatus = _ctx.StringValue("ListExecutions.Executions["+ i +"].LastTriggerStatus");
				execution.LastSuccessfulTriggerTime = _ctx.StringValue("ListExecutions.Executions["+ i +"].LastSuccessfulTriggerTime");
				execution.ResourceStatus = _ctx.StringValue("ListExecutions.Executions["+ i +"].ResourceStatus");

				List<ListExecutionsResponse.ListExecutions_Execution.ListExecutions_CurrentTask> execution_currentTasks = new List<ListExecutionsResponse.ListExecutions_Execution.ListExecutions_CurrentTask>();
				for (int j = 0; j < _ctx.Length("ListExecutions.Executions["+ i +"].CurrentTasks.Length"); j++) {
					ListExecutionsResponse.ListExecutions_Execution.ListExecutions_CurrentTask currentTask = new ListExecutionsResponse.ListExecutions_Execution.ListExecutions_CurrentTask();
					currentTask.TaskExecutionId = _ctx.StringValue("ListExecutions.Executions["+ i +"].CurrentTasks["+ j +"].TaskExecutionId");
					currentTask.TaskName = _ctx.StringValue("ListExecutions.Executions["+ i +"].CurrentTasks["+ j +"].TaskName");
					currentTask.TaskAction = _ctx.StringValue("ListExecutions.Executions["+ i +"].CurrentTasks["+ j +"].TaskAction");

					execution_currentTasks.Add(currentTask);
				}
				execution.CurrentTasks = execution_currentTasks;

				listExecutionsResponse_executions.Add(execution);
			}
			listExecutionsResponse.Executions = listExecutionsResponse_executions;
        
			return listExecutionsResponse;
        }
    }
}
