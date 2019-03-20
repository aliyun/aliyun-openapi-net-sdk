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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class TaskConfigListResponseUnmarshaller
    {
        public static TaskConfigListResponse Unmarshall(UnmarshallerContext context)
        {
			TaskConfigListResponse taskConfigListResponse = new TaskConfigListResponse();

			taskConfigListResponse.HttpResponse = context.HttpResponse;
			taskConfigListResponse.ErrorCode = context.IntegerValue("TaskConfigList.ErrorCode");
			taskConfigListResponse.ErrorMessage = context.StringValue("TaskConfigList.ErrorMessage");
			taskConfigListResponse.Success = context.BooleanValue("TaskConfigList.Success");
			taskConfigListResponse.RequestId = context.StringValue("TaskConfigList.RequestId");
			taskConfigListResponse.PageNumber = context.IntegerValue("TaskConfigList.PageNumber");
			taskConfigListResponse.PageSize = context.IntegerValue("TaskConfigList.PageSize");
			taskConfigListResponse.PageTotal = context.IntegerValue("TaskConfigList.PageTotal");
			taskConfigListResponse.Total = context.IntegerValue("TaskConfigList.Total");

			List<TaskConfigListResponse.TaskConfigList_NodeTaskConfig> taskConfigListResponse_taskList = new List<TaskConfigListResponse.TaskConfigList_NodeTaskConfig>();
			for (int i = 0; i < context.Length("TaskConfigList.TaskList.Length"); i++) {
				TaskConfigListResponse.TaskConfigList_NodeTaskConfig nodeTaskConfig = new TaskConfigListResponse.TaskConfigList_NodeTaskConfig();
				nodeTaskConfig.Id = context.LongValue("TaskConfigList.TaskList["+ i +"].Id");
				nodeTaskConfig.TaskName = context.StringValue("TaskConfigList.TaskList["+ i +"].TaskName");
				nodeTaskConfig.TaskType = context.StringValue("TaskConfigList.TaskList["+ i +"].TaskType");
				nodeTaskConfig.TaskScope = context.StringValue("TaskConfigList.TaskList["+ i +"].TaskScope");
				nodeTaskConfig.Disabled = context.BooleanValue("TaskConfigList.TaskList["+ i +"].Disabled");
				nodeTaskConfig.GroupId = context.LongValue("TaskConfigList.TaskList["+ i +"].GroupId");
				nodeTaskConfig.GroupName = context.StringValue("TaskConfigList.TaskList["+ i +"].GroupName");
				nodeTaskConfig.JsonData = context.StringValue("TaskConfigList.TaskList["+ i +"].JsonData");
				nodeTaskConfig.AlertConfig = context.StringValue("TaskConfigList.TaskList["+ i +"].AlertConfig");

				List<string> nodeTaskConfig_instanceList = new List<string>();
				for (int j = 0; j < context.Length("TaskConfigList.TaskList["+ i +"].InstanceList.Length"); j++) {
					nodeTaskConfig_instanceList.Add(context.StringValue("TaskConfigList.TaskList["+ i +"].InstanceList["+ j +"]"));
				}
				nodeTaskConfig.InstanceList = nodeTaskConfig_instanceList;

				taskConfigListResponse_taskList.Add(nodeTaskConfig);
			}
			taskConfigListResponse.TaskList = taskConfigListResponse_taskList;
        
			return taskConfigListResponse;
        }
    }
}
