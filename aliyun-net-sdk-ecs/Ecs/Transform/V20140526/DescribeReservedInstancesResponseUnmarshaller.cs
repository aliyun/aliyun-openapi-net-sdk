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
        public static DescribeReservedInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeReservedInstancesResponse describeReservedInstancesResponse = new DescribeReservedInstancesResponse();

			describeReservedInstancesResponse.HttpResponse = context.HttpResponse;
			describeReservedInstancesResponse.RequestId = context.StringValue("DescribeReservedInstances.RequestId");
			describeReservedInstancesResponse.TotalCount = context.IntegerValue("DescribeReservedInstances.TotalCount");
			describeReservedInstancesResponse.PageNumber = context.IntegerValue("DescribeReservedInstances.PageNumber");
			describeReservedInstancesResponse.PageSize = context.IntegerValue("DescribeReservedInstances.PageSize");

			List<DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance> describeReservedInstancesResponse_reservedInstances = new List<DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance>();
			for (int i = 0; i < context.Length("DescribeReservedInstances.ReservedInstances.Length"); i++) {
				DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance reservedInstance = new DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance();
				reservedInstance.ReservedInstanceId = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].ReservedInstanceId");
				reservedInstance.RegionId = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].RegionId");
				reservedInstance.ZoneId = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].ZoneId");
				reservedInstance.ReservedInstanceName = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].ReservedInstanceName");
				reservedInstance.Description = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].Description");
				reservedInstance.InstanceType = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].InstanceType");
				reservedInstance.Scope = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].Scope");
				reservedInstance.OfferingType = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].OfferingType");
				reservedInstance.Platform = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].Platform");
				reservedInstance.InstanceAmount = context.IntegerValue("DescribeReservedInstances.ReservedInstances["+ i +"].InstanceAmount");
				reservedInstance.Status = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].Status");
				reservedInstance.CreationTime = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].CreationTime");
				reservedInstance.ExpiredTime = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].ExpiredTime");
				reservedInstance.StartTime = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].StartTime");
				reservedInstance.ResourceGroupId = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].ResourceGroupId");
				reservedInstance.AllocationStatus = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].AllocationStatus");

				List<DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_OperationLock> reservedInstance_operationLocks = new List<DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_OperationLock>();
				for (int j = 0; j < context.Length("DescribeReservedInstances.ReservedInstances["+ i +"].OperationLocks.Length"); j++) {
					DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_OperationLock operationLock = new DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_OperationLock();
					operationLock.LockReason = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].OperationLocks["+ j +"].LockReason");

					reservedInstance_operationLocks.Add(operationLock);
				}
				reservedInstance.OperationLocks = reservedInstance_operationLocks;

				List<DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_Tag> reservedInstance_tags = new List<DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_Tag>();
				for (int j = 0; j < context.Length("DescribeReservedInstances.ReservedInstances["+ i +"].Tags.Length"); j++) {
					DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_Tag tag = new DescribeReservedInstancesResponse.DescribeReservedInstances_ReservedInstance.DescribeReservedInstances_Tag();
					tag.TagKey = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeReservedInstances.ReservedInstances["+ i +"].Tags["+ j +"].TagValue");

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
