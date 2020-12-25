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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListClusterOperationTaskResponseUnmarshaller
    {
        public static ListClusterOperationTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterOperationTaskResponse listClusterOperationTaskResponse = new ListClusterOperationTaskResponse();

			listClusterOperationTaskResponse.HttpResponse = _ctx.HttpResponse;
			listClusterOperationTaskResponse.RequestId = _ctx.StringValue("ListClusterOperationTask.RequestId");
			listClusterOperationTaskResponse.TotalCount = _ctx.IntegerValue("ListClusterOperationTask.TotalCount");
			listClusterOperationTaskResponse.PageNumber = _ctx.IntegerValue("ListClusterOperationTask.PageNumber");
			listClusterOperationTaskResponse.PageSize = _ctx.IntegerValue("ListClusterOperationTask.PageSize");

			List<ListClusterOperationTaskResponse.ListClusterOperationTask_ClusterOperationTask> listClusterOperationTaskResponse_clusterOperationTaskList = new List<ListClusterOperationTaskResponse.ListClusterOperationTask_ClusterOperationTask>();
			for (int i = 0; i < _ctx.Length("ListClusterOperationTask.ClusterOperationTaskList.Length"); i++) {
				ListClusterOperationTaskResponse.ListClusterOperationTask_ClusterOperationTask clusterOperationTask = new ListClusterOperationTaskResponse.ListClusterOperationTask_ClusterOperationTask();
				clusterOperationTask.TaskId = _ctx.StringValue("ListClusterOperationTask.ClusterOperationTaskList["+ i +"].TaskId");
				clusterOperationTask.TaskName = _ctx.StringValue("ListClusterOperationTask.ClusterOperationTaskList["+ i +"].TaskName");
				clusterOperationTask.Status = _ctx.StringValue("ListClusterOperationTask.ClusterOperationTaskList["+ i +"].Status");
				clusterOperationTask.Percentage = _ctx.StringValue("ListClusterOperationTask.ClusterOperationTaskList["+ i +"].Percentage");

				listClusterOperationTaskResponse_clusterOperationTaskList.Add(clusterOperationTask);
			}
			listClusterOperationTaskResponse.ClusterOperationTaskList = listClusterOperationTaskResponse_clusterOperationTaskList;
        
			return listClusterOperationTaskResponse;
        }
    }
}
