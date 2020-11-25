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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeReservedInstancesResponseUnmarshaller
    {
        public static DescribeReservedInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeReservedInstancesResponse describeReservedInstancesResponse = new DescribeReservedInstancesResponse();

			describeReservedInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeReservedInstancesResponse.RequestId = _ctx.StringValue("DescribeReservedInstances.RequestId");
			describeReservedInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeReservedInstances.TotalCount");
			describeReservedInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeReservedInstances.PageNumber");
			describeReservedInstancesResponse.PageSize = _ctx.IntegerValue("DescribeReservedInstances.PageSize");

			List<DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance> describeReservedInstancesResponse_reservedInstances = new List<DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance>();
			for (int i = 0; i < _ctx.Length("DescribeReservedInstances.ReservedInstances.Length"); i++) {
				DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance reservedInstance = new DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance();
				reservedInstance.ReservedInstanceId = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].ReservedInstanceId");
				reservedInstance.RegionId = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].RegionId");
				reservedInstance.ZoneId = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].ZoneId");
				reservedInstance.ReservedInstanceName = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].ReservedInstanceName");
				reservedInstance.Description = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].Description");
				reservedInstance.InstanceType = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].InstanceType");
				reservedInstance.Scope = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].Scope");
				reservedInstance.OfferingType = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].OfferingType");
				reservedInstance.Platform = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].Platform");
				reservedInstance.InstanceAmount = _ctx.IntegerValue("DescribeReservedInstances.ReservedInstances["+ i +"].InstanceAmount");
				reservedInstance.Status = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].Status");
				reservedInstance.CreationTime = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].CreationTime");
				reservedInstance.ExpiredTime = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].ExpiredTime");
				reservedInstance.StartTime = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].StartTime");
				reservedInstance.ResourceGroupId = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].ResourceGroupId");
				reservedInstance.AllocationStatus = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].AllocationStatus");

				List<DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_OperationLock> reservedInstance_operationLocks = new List<DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_OperationLock>();
				for (int j = 0; j < _ctx.Length("DescribeReservedInstances.ReservedInstances["+ i +"].OperationLocks.Length"); j++) {
					DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_OperationLock operationLock = new DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_OperationLock();
					operationLock.LockReason = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].OperationLocks["+ j +"].LockReason");

					reservedInstance_operationLocks.Add(operationLock);
				}
				reservedInstance.OperationLocks = reservedInstance_operationLocks;

				List<DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_Tag> reservedInstance_tags = new List<DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeReservedInstances.ReservedInstances["+ i +"].Tags.Length"); j++) {
					DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_Tag tag = new DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_Tag();
					tag.TagKey = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].Tags["+ j +"].TagValue");

					reservedInstance_tags.Add(tag);
				}
				reservedInstance.Tags = reservedInstance_tags;

				describeReservedInstancesResponse_reservedInstances.Add(reservedInstance);
			}
			describeReservedInstancesResponse.ReservedInstances = describeReservedInstancesResponse_reservedInstances;
        
			return describeReservedInstancesResponse;
        }
    }
}
