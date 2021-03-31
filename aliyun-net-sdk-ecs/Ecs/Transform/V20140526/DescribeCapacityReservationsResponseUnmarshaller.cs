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
        public static DescribeCapacityReservationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCapacityReservationsResponse describeCapacityReservationsResponse = new DescribeCapacityReservationsResponse();

			describeCapacityReservationsResponse.HttpResponse = _ctx.HttpResponse;
			describeCapacityReservationsResponse.RequestId = _ctx.StringValue("DescribeCapacityReservations.RequestId");
			describeCapacityReservationsResponse.NextToken = _ctx.StringValue("DescribeCapacityReservations.NextToken");
			describeCapacityReservationsResponse.MaxResults = _ctx.IntegerValue("DescribeCapacityReservations.MaxResults");
			describeCapacityReservationsResponse.TotalCount = _ctx.IntegerValue("DescribeCapacityReservations.TotalCount");

			List<DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem> describeCapacityReservationsResponse_capacityReservationSet = new List<DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem>();
			for (int i = 0; i < _ctx.Length("DescribeCapacityReservations.CapacityReservationSet.Length"); i++) {
				DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem capacityReservationItem = new DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem();
				capacityReservationItem.PrivatePoolOptionsId = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].PrivatePoolOptionsId");
				capacityReservationItem.PrivatePoolOptionsName = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].PrivatePoolOptionsName");
				capacityReservationItem.Description = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].Description");
				capacityReservationItem.RegionId = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].RegionId");
				capacityReservationItem.PrivatePoolOptionsMatchCriteria = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].PrivatePoolOptionsMatchCriteria");
				capacityReservationItem.Status = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].Status");
				capacityReservationItem.StartTime = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].StartTime");
				capacityReservationItem.EndTime = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].EndTime");
				capacityReservationItem.EndTimeType = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].EndTimeType");
				capacityReservationItem.InstanceChargeType = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].InstanceChargeType");
				capacityReservationItem.Platform = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].Platform");
				capacityReservationItem.TimeSlot = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].TimeSlot");
				capacityReservationItem.ResourceGroupId = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].ResourceGroupId");

				List<DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem.DescribeCapacityReservations_AllocatedResource> capacityReservationItem_allocatedResources = new List<DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem.DescribeCapacityReservations_AllocatedResource>();
				for (int j = 0; j < _ctx.Length("DescribeCapacityReservations.CapacityReservationSet["+ i +"].AllocatedResources.Length"); j++) {
					DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem.DescribeCapacityReservations_AllocatedResource allocatedResource = new DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem.DescribeCapacityReservations_AllocatedResource();
					allocatedResource.ZoneId = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].AllocatedResources["+ j +"].zoneId");
					allocatedResource.InstanceType = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].AllocatedResources["+ j +"].InstanceType");
					allocatedResource.TotalAmount = _ctx.IntegerValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].AllocatedResources["+ j +"].TotalAmount");
					allocatedResource.UsedAmount = _ctx.IntegerValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].AllocatedResources["+ j +"].UsedAmount");

					capacityReservationItem_allocatedResources.Add(allocatedResource);
				}
				capacityReservationItem.AllocatedResources = capacityReservationItem_allocatedResources;

				List<DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem.DescribeCapacityReservations_Tag> capacityReservationItem_tags = new List<DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem.DescribeCapacityReservations_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeCapacityReservations.CapacityReservationSet["+ i +"].Tags.Length"); j++) {
					DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem.DescribeCapacityReservations_Tag tag = new DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservationItem.DescribeCapacityReservations_Tag();
					tag.TagKey = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeCapacityReservations.CapacityReservationSet["+ i +"].Tags["+ j +"].TagValue");

					capacityReservationItem_tags.Add(tag);
				}
				capacityReservationItem.Tags = capacityReservationItem_tags;

				describeCapacityReservationsResponse_capacityReservationSet.Add(capacityReservationItem);
			}
			describeCapacityReservationsResponse.CapacityReservationSet = describeCapacityReservationsResponse_capacityReservationSet;
        
			return describeCapacityReservationsResponse;
        }
    }
}
