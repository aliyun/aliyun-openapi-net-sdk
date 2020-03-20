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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ListStackInstancesResponseUnmarshaller
    {
        public static ListStackInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			ListStackInstancesResponse listStackInstancesResponse = new ListStackInstancesResponse();

			listStackInstancesResponse.HttpResponse = context.HttpResponse;
			listStackInstancesResponse.RequestId = context.StringValue("ListStackInstances.RequestId");
			listStackInstancesResponse.PageNumber = context.IntegerValue("ListStackInstances.PageNumber");
			listStackInstancesResponse.PageSize = context.IntegerValue("ListStackInstances.PageSize");
			listStackInstancesResponse.TotalCount = context.IntegerValue("ListStackInstances.TotalCount");

			List<ListStackInstancesResponse.ListStackInstances_StackInstance> listStackInstancesResponse_stackInstances = new List<ListStackInstancesResponse.ListStackInstances_StackInstance>();
			for (int i = 0; i < context.Length("ListStackInstances.StackInstances.Length"); i++) {
				ListStackInstancesResponse.ListStackInstances_StackInstance stackInstance = new ListStackInstancesResponse.ListStackInstances_StackInstance();
				stackInstance.StackGroupName = context.StringValue("ListStackInstances.StackInstances["+ i +"].StackGroupName");
				stackInstance.StackGroupId = context.StringValue("ListStackInstances.StackInstances["+ i +"].StackGroupId");
				stackInstance.StackId = context.StringValue("ListStackInstances.StackInstances["+ i +"].StackId");
				stackInstance.AccountId = context.StringValue("ListStackInstances.StackInstances["+ i +"].AccountId");
				stackInstance.RegionId = context.StringValue("ListStackInstances.StackInstances["+ i +"].RegionId");
				stackInstance.Status = context.StringValue("ListStackInstances.StackInstances["+ i +"].Status");
				stackInstance.StatusReason = context.StringValue("ListStackInstances.StackInstances["+ i +"].StatusReason");
				stackInstance.StackDriftStatus = context.StringValue("ListStackInstances.StackInstances["+ i +"].StackDriftStatus");
				stackInstance.DriftDetectionTime = context.StringValue("ListStackInstances.StackInstances["+ i +"].DriftDetectionTime");

				listStackInstancesResponse_stackInstances.Add(stackInstance);
			}
			listStackInstancesResponse.StackInstances = listStackInstancesResponse_stackInstances;
        
			return listStackInstancesResponse;
        }
    }
}
