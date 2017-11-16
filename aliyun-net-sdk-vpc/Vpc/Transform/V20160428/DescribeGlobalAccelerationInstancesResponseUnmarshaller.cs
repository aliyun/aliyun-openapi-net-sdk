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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeGlobalAccelerationInstancesResponseUnmarshaller
    {
        public static DescribeGlobalAccelerationInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGlobalAccelerationInstancesResponse describeGlobalAccelerationInstancesResponse = new DescribeGlobalAccelerationInstancesResponse();

			describeGlobalAccelerationInstancesResponse.HttpResponse = context.HttpResponse;
			describeGlobalAccelerationInstancesResponse.RequestId = context.StringValue("DescribeGlobalAccelerationInstances.RequestId");
			describeGlobalAccelerationInstancesResponse.TotalCount = context.IntegerValue("DescribeGlobalAccelerationInstances.TotalCount");
			describeGlobalAccelerationInstancesResponse.PageNumber = context.IntegerValue("DescribeGlobalAccelerationInstances.PageNumber");
			describeGlobalAccelerationInstancesResponse.PageSize = context.IntegerValue("DescribeGlobalAccelerationInstances.PageSize");

			List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance> describeGlobalAccelerationInstancesResponse_globalAccelerationInstances = new List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance>();
			for (int i = 0; i < context.Length("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances.Length"); i++) {
				DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance globalAccelerationInstance = new DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance();
				globalAccelerationInstance.RegionId = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].RegionId");
				globalAccelerationInstance.GlobalAccelerationInstanceId = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].GlobalAccelerationInstanceId");
				globalAccelerationInstance.IpAddress = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].IpAddress");
				globalAccelerationInstance.Status = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].Status");
				globalAccelerationInstance.Bandwidth = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].Bandwidth");
				globalAccelerationInstance.InternetChargeType = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].InternetChargeType");
				globalAccelerationInstance.ChargeType = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].ChargeType");
				globalAccelerationInstance.AccelerationLocation = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].AccelerationLocation");
				globalAccelerationInstance.ServiceLocation = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].ServiceLocation");
				globalAccelerationInstance.Name = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].Name");
				globalAccelerationInstance.Description = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].Description");
				globalAccelerationInstance.ExpiredTime = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].ExpiredTime");
				globalAccelerationInstance.CreationTime = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].CreationTime");

				List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_LockReason> globalAccelerationInstance_operationLocks = new List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_LockReason>();
				for (int j = 0; j < context.Length("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].OperationLocks.Length"); j++) {
					DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_LockReason lockReason = new DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_LockReason();
					lockReason.LockReason = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].OperationLocks["+ j +"].LockReason");

					globalAccelerationInstance_operationLocks.Add(lockReason);
				}
				globalAccelerationInstance.OperationLocks = globalAccelerationInstance_operationLocks;

				List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_BackendServer> globalAccelerationInstance_backendServers = new List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_BackendServer>();
				for (int j = 0; j < context.Length("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].BackendServers.Length"); j++) {
					DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_BackendServer backendServer = new DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_BackendServer();
					backendServer.RegionId = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].BackendServers["+ j +"].RegionId");
					backendServer.ServerId = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].BackendServers["+ j +"].ServerId");
					backendServer.ServerIpAddress = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].BackendServers["+ j +"].ServerIpAddress");
					backendServer.ServerType = context.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].BackendServers["+ j +"].ServerType");

					globalAccelerationInstance_backendServers.Add(backendServer);
				}
				globalAccelerationInstance.BackendServers = globalAccelerationInstance_backendServers;

				describeGlobalAccelerationInstancesResponse_globalAccelerationInstances.Add(globalAccelerationInstance);
			}
			describeGlobalAccelerationInstancesResponse.GlobalAccelerationInstances = describeGlobalAccelerationInstancesResponse_globalAccelerationInstances;
        
			return describeGlobalAccelerationInstancesResponse;
        }
    }
}