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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeGlobalAccelerationInstancesResponseUnmarshaller
    {
        public static DescribeGlobalAccelerationInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGlobalAccelerationInstancesResponse describeGlobalAccelerationInstancesResponse = new DescribeGlobalAccelerationInstancesResponse();

			describeGlobalAccelerationInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeGlobalAccelerationInstancesResponse.RequestId = _ctx.StringValue("DescribeGlobalAccelerationInstances.RequestId");
			describeGlobalAccelerationInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeGlobalAccelerationInstances.TotalCount");
			describeGlobalAccelerationInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeGlobalAccelerationInstances.PageNumber");
			describeGlobalAccelerationInstancesResponse.PageSize = _ctx.IntegerValue("DescribeGlobalAccelerationInstances.PageSize");

			List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance> describeGlobalAccelerationInstancesResponse_globalAccelerationInstances = new List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance>();
			for (int i = 0; i < _ctx.Length("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances.Length"); i++) {
				DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance globalAccelerationInstance = new DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance();
				globalAccelerationInstance.RegionId = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].RegionId");
				globalAccelerationInstance.GlobalAccelerationInstanceId = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].GlobalAccelerationInstanceId");
				globalAccelerationInstance.IpAddress = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].IpAddress");
				globalAccelerationInstance.Status = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].Status");
				globalAccelerationInstance.Bandwidth = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].Bandwidth");
				globalAccelerationInstance.InternetChargeType = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].InternetChargeType");
				globalAccelerationInstance.ChargeType = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].ChargeType");
				globalAccelerationInstance.BandwidthType = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].BandwidthType");
				globalAccelerationInstance.AccelerationLocation = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].AccelerationLocation");
				globalAccelerationInstance.ServiceLocation = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].ServiceLocation");
				globalAccelerationInstance.Name = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].Name");
				globalAccelerationInstance.Description = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].Description");
				globalAccelerationInstance.ExpiredTime = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].ExpiredTime");
				globalAccelerationInstance.CreationTime = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].CreationTime");
				globalAccelerationInstance.HasReservationData = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].HasReservationData");
				globalAccelerationInstance.ReservationBandwidth = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].ReservationBandwidth");
				globalAccelerationInstance.ReservationInternetChargeType = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].ReservationInternetChargeType");
				globalAccelerationInstance.ReservationActiveTime = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].ReservationActiveTime");
				globalAccelerationInstance.ReservationOrderType = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].ReservationOrderType");

				List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_LockReason> globalAccelerationInstance_operationLocks = new List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_LockReason>();
				for (int j = 0; j < _ctx.Length("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].OperationLocks.Length"); j++) {
					DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_LockReason lockReason = new DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_LockReason();
					lockReason.LockReason = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].OperationLocks["+ j +"].LockReason");

					globalAccelerationInstance_operationLocks.Add(lockReason);
				}
				globalAccelerationInstance.OperationLocks = globalAccelerationInstance_operationLocks;

				List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_BackendServer> globalAccelerationInstance_backendServers = new List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_BackendServer>();
				for (int j = 0; j < _ctx.Length("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].BackendServers.Length"); j++) {
					DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_BackendServer backendServer = new DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_BackendServer();
					backendServer.RegionId = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].BackendServers["+ j +"].RegionId");
					backendServer.ServerId = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].BackendServers["+ j +"].ServerId");
					backendServer.ServerIpAddress = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].BackendServers["+ j +"].ServerIpAddress");
					backendServer.ServerType = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].BackendServers["+ j +"].ServerType");

					globalAccelerationInstance_backendServers.Add(backendServer);
				}
				globalAccelerationInstance.BackendServers = globalAccelerationInstance_backendServers;

				List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_PublicIpAddress> globalAccelerationInstance_publicIpAddresses = new List<DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_PublicIpAddress>();
				for (int j = 0; j < _ctx.Length("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].PublicIpAddresses.Length"); j++) {
					DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_PublicIpAddress publicIpAddress = new DescribeGlobalAccelerationInstancesResponse.DescribeGlobalAccelerationInstances_GlobalAccelerationInstance.DescribeGlobalAccelerationInstances_PublicIpAddress();
					publicIpAddress.AllocationId = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].PublicIpAddresses["+ j +"].AllocationId");
					publicIpAddress.IpAddress = _ctx.StringValue("DescribeGlobalAccelerationInstances.GlobalAccelerationInstances["+ i +"].PublicIpAddresses["+ j +"].IpAddress");

					globalAccelerationInstance_publicIpAddresses.Add(publicIpAddress);
				}
				globalAccelerationInstance.PublicIpAddresses = globalAccelerationInstance_publicIpAddresses;

				describeGlobalAccelerationInstancesResponse_globalAccelerationInstances.Add(globalAccelerationInstance);
			}
			describeGlobalAccelerationInstancesResponse.GlobalAccelerationInstances = describeGlobalAccelerationInstancesResponse_globalAccelerationInstances;
        
			return describeGlobalAccelerationInstancesResponse;
        }
    }
}
