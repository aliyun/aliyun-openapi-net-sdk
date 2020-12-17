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
        public static ListStackInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStackInstancesResponse listStackInstancesResponse = new ListStackInstancesResponse();

			listStackInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listStackInstancesResponse.RequestId = _ctx.StringValue("ListStackInstances.RequestId");
			listStackInstancesResponse.PageNumber = _ctx.IntegerValue("ListStackInstances.PageNumber");
			listStackInstancesResponse.PageSize = _ctx.IntegerValue("ListStackInstances.PageSize");
			listStackInstancesResponse.TotalCount = _ctx.IntegerValue("ListStackInstances.TotalCount");

			List<ListStackInstancesResponse.ListStackInstances_StackInstance> listStackInstancesResponse_stackInstances = new List<ListStackInstancesResponse.ListStackInstances_StackInstance>();
			for (int i = 0; i < _ctx.Length("ListStackInstances.StackInstances.Length"); i++) {
				ListStackInstancesResponse.ListStackInstances_StackInstance stackInstance = new ListStackInstancesResponse.ListStackInstances_StackInstance();
				stackInstance.StackGroupName = _ctx.StringValue("ListStackInstances.StackInstances["+ i +"].StackGroupName");
				stackInstance.StackGroupId = _ctx.StringValue("ListStackInstances.StackInstances["+ i +"].StackGroupId");
				stackInstance.StackId = _ctx.StringValue("ListStackInstances.StackInstances["+ i +"].StackId");
				stackInstance.AccountId = _ctx.StringValue("ListStackInstances.StackInstances["+ i +"].AccountId");
				stackInstance.RegionId = _ctx.StringValue("ListStackInstances.StackInstances["+ i +"].RegionId");
				stackInstance.Status = _ctx.StringValue("ListStackInstances.StackInstances["+ i +"].Status");
				stackInstance.StatusReason = _ctx.StringValue("ListStackInstances.StackInstances["+ i +"].StatusReason");
				stackInstance.StackDriftStatus = _ctx.StringValue("ListStackInstances.StackInstances["+ i +"].StackDriftStatus");
				stackInstance.DriftDetectionTime = _ctx.StringValue("ListStackInstances.StackInstances["+ i +"].DriftDetectionTime");

				listStackInstancesResponse_stackInstances.Add(stackInstance);
			}
			listStackInstancesResponse.StackInstances = listStackInstancesResponse_stackInstances;
        
			return listStackInstancesResponse;
        }
    }
}
