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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class GetEdgeInstanceDeploymentResponseUnmarshaller
    {
        public static GetEdgeInstanceDeploymentResponse Unmarshall(UnmarshallerContext context)
        {
			GetEdgeInstanceDeploymentResponse getEdgeInstanceDeploymentResponse = new GetEdgeInstanceDeploymentResponse();

			getEdgeInstanceDeploymentResponse.HttpResponse = context.HttpResponse;
			getEdgeInstanceDeploymentResponse.RequestId = context.StringValue("GetEdgeInstanceDeployment.RequestId");
			getEdgeInstanceDeploymentResponse.Success = context.BooleanValue("GetEdgeInstanceDeployment.Success");
			getEdgeInstanceDeploymentResponse.Code = context.StringValue("GetEdgeInstanceDeployment.Code");
			getEdgeInstanceDeploymentResponse.ErrorMessage = context.StringValue("GetEdgeInstanceDeployment.ErrorMessage");

			GetEdgeInstanceDeploymentResponse.GetEdgeInstanceDeployment_Data data = new GetEdgeInstanceDeploymentResponse.GetEdgeInstanceDeployment_Data();
			data.GmtCreate = context.StringValue("GetEdgeInstanceDeployment.Data.GmtCreate");
			data.GmtModified = context.StringValue("GetEdgeInstanceDeployment.Data.GmtModified");
			data.GmtCompleted = context.StringValue("GetEdgeInstanceDeployment.Data.GmtCompleted");
			data.DeploymentId = context.StringValue("GetEdgeInstanceDeployment.Data.DeploymentId");
			data.Description = context.StringValue("GetEdgeInstanceDeployment.Data.Description");
			data.Status = context.IntegerValue("GetEdgeInstanceDeployment.Data.Status");
			data.Type = context.StringValue("GetEdgeInstanceDeployment.Data.Type");
			data.GmtCreateTimestamp = context.LongValue("GetEdgeInstanceDeployment.Data.GmtCreateTimestamp");
			data.GmtModifiedTimestamp = context.LongValue("GetEdgeInstanceDeployment.Data.GmtModifiedTimestamp");
			data.GmtCompletedTimestamp = context.LongValue("GetEdgeInstanceDeployment.Data.GmtCompletedTimestamp");

			List<GetEdgeInstanceDeploymentResponse.GetEdgeInstanceDeployment_Data.GetEdgeInstanceDeployment_Task> data_taskList = new List<GetEdgeInstanceDeploymentResponse.GetEdgeInstanceDeployment_Data.GetEdgeInstanceDeployment_Task>();
			for (int i = 0; i < context.Length("GetEdgeInstanceDeployment.Data.TaskList.Length"); i++) {
				GetEdgeInstanceDeploymentResponse.GetEdgeInstanceDeployment_Data.GetEdgeInstanceDeployment_Task task = new GetEdgeInstanceDeploymentResponse.GetEdgeInstanceDeployment_Data.GetEdgeInstanceDeployment_Task();
				task.GmtCreate = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].GmtCreate");
				task.GmtModified = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].GmtModified");
				task.GmtCompleted = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].GmtCompleted");
				task.GatewayId = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].GatewayId");
				task.TaskId = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].TaskId");
				task.Stage = context.IntegerValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].Stage");
				task.Status = context.IntegerValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].Status");
				task.GmtCreateTimestamp = context.LongValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].GmtCreateTimestamp");
				task.GmtModifiedTimestamp = context.LongValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].GmtModifiedTimestamp");
				task.GmtCompletedTimestamp = context.LongValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].GmtCompletedTimestamp");

				List<GetEdgeInstanceDeploymentResponse.GetEdgeInstanceDeployment_Data.GetEdgeInstanceDeployment_Task.GetEdgeInstanceDeployment_ResourceSnapshot> task_resourceSnapshotList = new List<GetEdgeInstanceDeploymentResponse.GetEdgeInstanceDeployment_Data.GetEdgeInstanceDeployment_Task.GetEdgeInstanceDeployment_ResourceSnapshot>();
				for (int j = 0; j < context.Length("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList.Length"); j++) {
					GetEdgeInstanceDeploymentResponse.GetEdgeInstanceDeployment_Data.GetEdgeInstanceDeployment_Task.GetEdgeInstanceDeployment_ResourceSnapshot resourceSnapshot = new GetEdgeInstanceDeploymentResponse.GetEdgeInstanceDeployment_Data.GetEdgeInstanceDeployment_Task.GetEdgeInstanceDeployment_ResourceSnapshot();
					resourceSnapshot.GmtCreate = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].GmtCreate");
					resourceSnapshot.GmtModified = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].GmtModified");
					resourceSnapshot.GmtCompleted = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].GmtCompleted");
					resourceSnapshot.SnapshotId = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].SnapshotId");
					resourceSnapshot.ResourceType = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].ResourceType");
					resourceSnapshot.ResourceId = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].ResourceId");
					resourceSnapshot.ResourceName = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].ResourceName");
					resourceSnapshot.OperateType = context.IntegerValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].OperateType");
					resourceSnapshot.Stage = context.IntegerValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].Stage");
					resourceSnapshot.Status = context.IntegerValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].Status");
					resourceSnapshot.Log = context.StringValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].Log");
					resourceSnapshot.GmtCreateTimestamp = context.LongValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].GmtCreateTimestamp");
					resourceSnapshot.GmtModifiedTimestamp = context.LongValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].GmtModifiedTimestamp");
					resourceSnapshot.GmtCompletedTimestamp = context.LongValue("GetEdgeInstanceDeployment.Data.TaskList["+ i +"].ResourceSnapshotList["+ j +"].GmtCompletedTimestamp");

					task_resourceSnapshotList.Add(resourceSnapshot);
				}
				task.ResourceSnapshotList = task_resourceSnapshotList;

				data_taskList.Add(task);
			}
			data.TaskList = data_taskList;
			getEdgeInstanceDeploymentResponse.Data = data;
        
			return getEdgeInstanceDeploymentResponse;
        }
    }
}
