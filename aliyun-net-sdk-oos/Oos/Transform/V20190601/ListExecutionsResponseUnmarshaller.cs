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
        public static ListExecutionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListExecutionsResponse listExecutionsResponse = new ListExecutionsResponse();

			listExecutionsResponse.HttpResponse = context.HttpResponse;
			listExecutionsResponse.RequestId = context.StringValue("ListExecutions.RequestId");
			listExecutionsResponse.MaxResults = context.IntegerValue("ListExecutions.MaxResults");
			listExecutionsResponse.NextToken = context.StringValue("ListExecutions.NextToken");

			List<ListExecutionsResponse.ListExecutions_Execution> listExecutionsResponse_executions = new List<ListExecutionsResponse.ListExecutions_Execution>();
			for (int i = 0; i < context.Length("ListExecutions.Executions.Length"); i++) {
				ListExecutionsResponse.ListExecutions_Execution execution = new ListExecutionsResponse.ListExecutions_Execution();
				execution.ExecutionId = context.StringValue("ListExecutions.Executions["+ i +"].ExecutionId");
				execution.TemplateName = context.StringValue("ListExecutions.Executions["+ i +"].TemplateName");
				execution.TemplateId = context.StringValue("ListExecutions.Executions["+ i +"].TemplateId");
				execution.TemplateVersion = context.StringValue("ListExecutions.Executions["+ i +"].TemplateVersion");
				execution.Mode = context.StringValue("ListExecutions.Executions["+ i +"].Mode");
				execution.ExecutedBy = context.StringValue("ListExecutions.Executions["+ i +"].ExecutedBy");
				execution.StartDate = context.StringValue("ListExecutions.Executions["+ i +"].StartDate");
				execution.EndDate = context.StringValue("ListExecutions.Executions["+ i +"].EndDate");
				execution.CreateDate = context.StringValue("ListExecutions.Executions["+ i +"].CreateDate");
				execution.UpdateDate = context.StringValue("ListExecutions.Executions["+ i +"].UpdateDate");
				execution.Status = context.StringValue("ListExecutions.Executions["+ i +"].Status");
				execution.StatusMessage = context.StringValue("ListExecutions.Executions["+ i +"].StatusMessage");
				execution.StatusReason = context.StringValue("ListExecutions.Executions["+ i +"].StatusReason");
				execution.WaitingStatus = context.StringValue("ListExecutions.Executions["+ i +"].WaitingStatus");
				execution.ParentExecutionId = context.StringValue("ListExecutions.Executions["+ i +"].ParentExecutionId");
				execution.Parameters = context.StringValue("ListExecutions.Executions["+ i +"].Parameters");
				execution.Outputs = context.StringValue("ListExecutions.Executions["+ i +"].Outputs");
				execution.SafetyCheck = context.StringValue("ListExecutions.Executions["+ i +"].SafetyCheck");
				execution.IsParent = context.BooleanValue("ListExecutions.Executions["+ i +"].IsParent");
				execution.RamRole = context.StringValue("ListExecutions.Executions["+ i +"].RamRole");
				execution.Counters = context.StringValue("ListExecutions.Executions["+ i +"].Counters");
				execution.Category = context.StringValue("ListExecutions.Executions["+ i +"].Category");
				execution.Tags = context.StringValue("ListExecutions.Executions["+ i +"].Tags");
				execution.Description = context.StringValue("ListExecutions.Executions["+ i +"].Description");
				execution.Targets = context.StringValue("ListExecutions.Executions["+ i +"].Targets");
				execution.LastTriggerTime = context.StringValue("ListExecutions.Executions["+ i +"].LastTriggerTime");
				execution.LastTriggerStatus = context.StringValue("ListExecutions.Executions["+ i +"].LastTriggerStatus");
				execution.LastSuccessfulTriggerTime = context.StringValue("ListExecutions.Executions["+ i +"].LastSuccessfulTriggerTime");
				execution.ResourceStatus = context.StringValue("ListExecutions.Executions["+ i +"].ResourceStatus");

				List<ListExecutionsResponse.ListExecutions_Execution.ListExecutions_CurrentTask> execution_currentTasks = new List<ListExecutionsResponse.ListExecutions_Execution.ListExecutions_CurrentTask>();
				for (int j = 0; j < context.Length("ListExecutions.Executions["+ i +"].CurrentTasks.Length"); j++) {
					ListExecutionsResponse.ListExecutions_Execution.ListExecutions_CurrentTask currentTask = new ListExecutionsResponse.ListExecutions_Execution.ListExecutions_CurrentTask();
					currentTask.TaskExecutionId = context.StringValue("ListExecutions.Executions["+ i +"].CurrentTasks["+ j +"].TaskExecutionId");
					currentTask.TaskName = context.StringValue("ListExecutions.Executions["+ i +"].CurrentTasks["+ j +"].TaskName");
					currentTask.TaskAction = context.StringValue("ListExecutions.Executions["+ i +"].CurrentTasks["+ j +"].TaskAction");

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
