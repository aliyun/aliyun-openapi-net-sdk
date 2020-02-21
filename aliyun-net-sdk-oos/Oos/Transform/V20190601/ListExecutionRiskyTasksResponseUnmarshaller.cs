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
    public class ListExecutionRiskyTasksResponseUnmarshaller
    {
        public static ListExecutionRiskyTasksResponse Unmarshall(UnmarshallerContext context)
        {
			ListExecutionRiskyTasksResponse listExecutionRiskyTasksResponse = new ListExecutionRiskyTasksResponse();

			listExecutionRiskyTasksResponse.HttpResponse = context.HttpResponse;
			listExecutionRiskyTasksResponse.RequestId = context.StringValue("ListExecutionRiskyTasks.RequestId");

			List<ListExecutionRiskyTasksResponse.ListExecutionRiskyTasks_RiskyTask> listExecutionRiskyTasksResponse_riskyTasks = new List<ListExecutionRiskyTasksResponse.ListExecutionRiskyTasks_RiskyTask>();
			for (int i = 0; i < context.Length("ListExecutionRiskyTasks.RiskyTasks.Length"); i++) {
				ListExecutionRiskyTasksResponse.ListExecutionRiskyTasks_RiskyTask riskyTask = new ListExecutionRiskyTasksResponse.ListExecutionRiskyTasks_RiskyTask();
				riskyTask.Service = context.StringValue("ListExecutionRiskyTasks.RiskyTasks["+ i +"].Service");
				riskyTask.API = context.StringValue("ListExecutionRiskyTasks.RiskyTasks["+ i +"].API");

				List<string> riskyTask_task = new List<string>();
				for (int j = 0; j < context.Length("ListExecutionRiskyTasks.RiskyTasks["+ i +"].Task.Length"); j++) {
					riskyTask_task.Add(context.StringValue("ListExecutionRiskyTasks.RiskyTasks["+ i +"].Task["+ j +"]"));
				}
				riskyTask.Task = riskyTask_task;

				List<string> riskyTask_template = new List<string>();
				for (int j = 0; j < context.Length("ListExecutionRiskyTasks.RiskyTasks["+ i +"].Template.Length"); j++) {
					riskyTask_template.Add(context.StringValue("ListExecutionRiskyTasks.RiskyTasks["+ i +"].Template["+ j +"]"));
				}
				riskyTask.Template = riskyTask_template;

				listExecutionRiskyTasksResponse_riskyTasks.Add(riskyTask);
			}
			listExecutionRiskyTasksResponse.RiskyTasks = listExecutionRiskyTasksResponse_riskyTasks;
        
			return listExecutionRiskyTasksResponse;
        }
    }
}
