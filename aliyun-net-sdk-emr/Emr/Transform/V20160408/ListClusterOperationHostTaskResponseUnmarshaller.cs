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
    public class ListClusterOperationHostTaskResponseUnmarshaller
    {
        public static ListClusterOperationHostTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterOperationHostTaskResponse listClusterOperationHostTaskResponse = new ListClusterOperationHostTaskResponse();

			listClusterOperationHostTaskResponse.HttpResponse = _ctx.HttpResponse;
			listClusterOperationHostTaskResponse.RequestId = _ctx.StringValue("ListClusterOperationHostTask.RequestId");
			listClusterOperationHostTaskResponse.TotalCount = _ctx.IntegerValue("ListClusterOperationHostTask.TotalCount");
			listClusterOperationHostTaskResponse.PageNumber = _ctx.IntegerValue("ListClusterOperationHostTask.PageNumber");
			listClusterOperationHostTaskResponse.PageSize = _ctx.IntegerValue("ListClusterOperationHostTask.PageSize");

			List<ListClusterOperationHostTaskResponse.ListClusterOperationHostTask_ClusterOperationHostTask> listClusterOperationHostTaskResponse_clusterOperationHostTaskList = new List<ListClusterOperationHostTaskResponse.ListClusterOperationHostTask_ClusterOperationHostTask>();
			for (int i = 0; i < _ctx.Length("ListClusterOperationHostTask.ClusterOperationHostTaskList.Length"); i++) {
				ListClusterOperationHostTaskResponse.ListClusterOperationHostTask_ClusterOperationHostTask clusterOperationHostTask = new ListClusterOperationHostTaskResponse.ListClusterOperationHostTask_ClusterOperationHostTask();
				clusterOperationHostTask.TaskId = _ctx.StringValue("ListClusterOperationHostTask.ClusterOperationHostTaskList["+ i +"].TaskId");
				clusterOperationHostTask.TaskName = _ctx.StringValue("ListClusterOperationHostTask.ClusterOperationHostTaskList["+ i +"].TaskName");
				clusterOperationHostTask.Status = _ctx.StringValue("ListClusterOperationHostTask.ClusterOperationHostTaskList["+ i +"].Status");
				clusterOperationHostTask.Percentage = _ctx.StringValue("ListClusterOperationHostTask.ClusterOperationHostTaskList["+ i +"].Percentage");

				listClusterOperationHostTaskResponse_clusterOperationHostTaskList.Add(clusterOperationHostTask);
			}
			listClusterOperationHostTaskResponse.ClusterOperationHostTaskList = listClusterOperationHostTaskResponse_clusterOperationHostTaskList;
        
			return listClusterOperationHostTaskResponse;
        }
    }
}
