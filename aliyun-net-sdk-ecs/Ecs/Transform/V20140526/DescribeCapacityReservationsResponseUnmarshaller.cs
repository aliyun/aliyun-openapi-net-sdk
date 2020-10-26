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
    public class DescribeCapacityReservationsResponseUnmarshaller
    {
        public static DescribeCapacityReservationsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCapacityReservationsResponse describeCapacityReservationsResponse = new DescribeCapacityReservationsResponse();

			describeCapacityReservationsResponse.HttpResponse = context.HttpResponse;
			describeCapacityReservationsResponse.RequestId = context.StringValue("DescribeCapacityReservations.RequestId");
			describeCapacityReservationsResponse.NextToken = context.StringValue("DescribeCapacityReservations.NextToken");
			describeCapacityReservationsResponse.MaxResults = context.IntegerValue("DescribeCapacityReservations.MaxResults");
			describeCapacityReservationsResponse.TotalCount = context.IntegerValue("DescribeCapacityReservations.TotalCount");

			List<DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem> describeCapacityReservationsResponse_capacityReservationSet = new List<DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem>();
			for (int i = 0; i < context.Length("DescribeCapacityReservations.CapacityReservationSet.Length"); i++) {
				DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem capacityReservationItem = new DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem();
				capacityReservationItem.PrivatePoolOptionsId = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].PrivatePoolOptionsId");
				capacityReservationItem.PrivatePoolOptionsName = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].PrivatePoolOptionsName");
				capacityReservationItem.Description = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].Description");
				capacityReservationItem.RegionId = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].RegionId");
				capacityReservationItem.PrivatePoolOptionsMatchCriteria = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].PrivatePoolOptionsMatchCriteria");
				capacityReservationItem.Status = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].Status");
				capacityReservationItem.StartTime = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].StartTime");
				capacityReservationItem.EndTime = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].EndTime");
				capacityReservationItem.EndTimeType = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].EndTimeType");
				capacityReservationItem.InstanceChargeType = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].InstanceChargeType");
				capacityReservationItem.Platform = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].Platform");

				List<DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem.DescribeCapacityReservations_AllocatedResource> capacityReservationItem_allocatedResources = new List<DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem.DescribeCapacityReservations_AllocatedResource>();
				for (int j = 0; j < context.Length("DescribeCapacityReservations.CapacityReservationSet["+ i +"].AllocatedResources.Length"); j++) {
					DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem.DescribeCapacityReservations_AllocatedResource allocatedResource = new DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem.DescribeCapacityReservations_AllocatedResource();
					allocatedResource.ZoneId = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].AllocatedResources["+ j +"].zoneId");
					allocatedResource.InstanceType = context.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].AllocatedResources["+ j +"].InstanceType");
					allocatedResource.TotalAmount = context.IntegerValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].AllocatedResources["+ j +"].TotalAmount");
					allocatedResource.UsedAmount = context.IntegerValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].AllocatedResources["+ j +"].UsedAmount");

					capacityReservationItem_allocatedResources.Add(allocatedResource);
				}
				capacityReservationItem.AllocatedResources = capacityReservationItem_allocatedResources;

				describeCapacityReservationsResponse_capacityReservationSet.Add(capacityReservationItem);
			}
			describeCapacityReservationsResponse.CapacityReservationSet = describeCapacityReservationsResponse_capacityReservationSet;
        
			return describeCapacityReservationsResponse;
        }
    }
}
