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
    public class ListExecutionPlanInstancesResponseUnmarshaller
    {
        public static ListExecutionPlanInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			ListExecutionPlanInstancesResponse listExecutionPlanInstancesResponse = new ListExecutionPlanInstancesResponse();

			listExecutionPlanInstancesResponse.HttpResponse = context.HttpResponse;
			listExecutionPlanInstancesResponse.RequestId = context.StringValue("ListExecutionPlanInstances.RequestId");
			listExecutionPlanInstancesResponse.TotalCount = context.IntegerValue("ListExecutionPlanInstances.TotalCount");
			listExecutionPlanInstancesResponse.PageNumber = context.IntegerValue("ListExecutionPlanInstances.PageNumber");
			listExecutionPlanInstancesResponse.PageSize = context.IntegerValue("ListExecutionPlanInstances.PageSize");

			List<ListExecutionPlanInstancesResponse.ListExecutionPlanInstances_ExecutionPlanInstance> listExecutionPlanInstancesResponse_executionPlanInstances = new List<ListExecutionPlanInstancesResponse.ListExecutionPlanInstances_ExecutionPlanInstance>();
			for (int i = 0; i < context.Length("ListExecutionPlanInstances.ExecutionPlanInstances.Length"); i++) {
				ListExecutionPlanInstancesResponse.ListExecutionPlanInstances_ExecutionPlanInstance executionPlanInstance = new ListExecutionPlanInstancesResponse.ListExecutionPlanInstances_ExecutionPlanInstance();
				executionPlanInstance.Id = context.StringValue("ListExecutionPlanInstances.ExecutionPlanInstances["+ i +"].Id");
				executionPlanInstance.ExecutionPlanId = context.StringValue("ListExecutionPlanInstances.ExecutionPlanInstances["+ i +"].ExecutionPlanId");
				executionPlanInstance.ExecutionPlanName = context.StringValue("ListExecutionPlanInstances.ExecutionPlanInstances["+ i +"].ExecutionPlanName");
				executionPlanInstance.StartTime = context.LongValue("ListExecutionPlanInstances.ExecutionPlanInstances["+ i +"].StartTime");
				executionPlanInstance.RunTime = context.IntegerValue("ListExecutionPlanInstances.ExecutionPlanInstances["+ i +"].RunTime");
				executionPlanInstance.ClusterId = context.StringValue("ListExecutionPlanInstances.ExecutionPlanInstances["+ i +"].ClusterId");
				executionPlanInstance.ClusterName = context.StringValue("ListExecutionPlanInstances.ExecutionPlanInstances["+ i +"].ClusterName");
				executionPlanInstance.ClusterType = context.StringValue("ListExecutionPlanInstances.ExecutionPlanInstances["+ i +"].ClusterType");
				executionPlanInstance.Status = context.StringValue("ListExecutionPlanInstances.ExecutionPlanInstances["+ i +"].Status");
				executionPlanInstance.LogEnable = context.BooleanValue("ListExecutionPlanInstances.ExecutionPlanInstances["+ i +"].LogEnable");
				executionPlanInstance.LogPath = context.StringValue("ListExecutionPlanInstances.ExecutionPlanInstances["+ i +"].LogPath");
				executionPlanInstance.WorkflowApp = context.StringValue("ListExecutionPlanInstances.ExecutionPlanInstances["+ i +"].WorkflowApp");

				listExecutionPlanInstancesResponse_executionPlanInstances.Add(executionPlanInstance);
			}
			listExecutionPlanInstancesResponse.ExecutionPlanInstances = listExecutionPlanInstancesResponse_executionPlanInstances;
        
			return listExecutionPlanInstancesResponse;
        }
    }
}
