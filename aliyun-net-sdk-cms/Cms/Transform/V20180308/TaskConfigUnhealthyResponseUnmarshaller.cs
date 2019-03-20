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
    public class TaskConfigUnhealthyResponseUnmarshaller
    {
        public static TaskConfigUnhealthyResponse Unmarshall(UnmarshallerContext context)
        {
			TaskConfigUnhealthyResponse taskConfigUnhealthyResponse = new TaskConfigUnhealthyResponse();

			taskConfigUnhealthyResponse.HttpResponse = context.HttpResponse;
			taskConfigUnhealthyResponse.ErrorCode = context.IntegerValue("TaskConfigUnhealthy.ErrorCode");
			taskConfigUnhealthyResponse.ErrorMessage = context.StringValue("TaskConfigUnhealthy.ErrorMessage");
			taskConfigUnhealthyResponse.Success = context.BooleanValue("TaskConfigUnhealthy.Success");
			taskConfigUnhealthyResponse.RequestId = context.StringValue("TaskConfigUnhealthy.RequestId");

			List<TaskConfigUnhealthyResponse.TaskConfigUnhealthy_NodeTaskInstance> taskConfigUnhealthyResponse_unhealthyList = new List<TaskConfigUnhealthyResponse.TaskConfigUnhealthy_NodeTaskInstance>();
			for (int i = 0; i < context.Length("TaskConfigUnhealthy.UnhealthyList.Length"); i++) {
				TaskConfigUnhealthyResponse.TaskConfigUnhealthy_NodeTaskInstance nodeTaskInstance = new TaskConfigUnhealthyResponse.TaskConfigUnhealthy_NodeTaskInstance();
				nodeTaskInstance.TaskId = context.LongValue("TaskConfigUnhealthy.UnhealthyList["+ i +"].TaskId");

				List<string> nodeTaskInstance_instanceList = new List<string>();
				for (int j = 0; j < context.Length("TaskConfigUnhealthy.UnhealthyList["+ i +"].InstanceList.Length"); j++) {
					nodeTaskInstance_instanceList.Add(context.StringValue("TaskConfigUnhealthy.UnhealthyList["+ i +"].InstanceList["+ j +"]"));
				}
				nodeTaskInstance.InstanceList = nodeTaskInstance_instanceList;

				taskConfigUnhealthyResponse_unhealthyList.Add(nodeTaskInstance);
			}
			taskConfigUnhealthyResponse.UnhealthyList = taskConfigUnhealthyResponse_unhealthyList;
        
			return taskConfigUnhealthyResponse;
        }
    }
}
