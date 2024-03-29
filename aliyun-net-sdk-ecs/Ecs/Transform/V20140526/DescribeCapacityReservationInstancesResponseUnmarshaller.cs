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
    public class DescribeCapacityReservationInstancesResponseUnmarshaller
    {
        public static DescribeCapacityReservationInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCapacityReservationInstancesResponse describeCapacityReservationInstancesResponse = new DescribeCapacityReservationInstancesResponse();

			describeCapacityReservationInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeCapacityReservationInstancesResponse.NextToken = _ctx.StringValue("DescribeCapacityReservationInstances.NextToken");
			describeCapacityReservationInstancesResponse.RequestId = _ctx.StringValue("DescribeCapacityReservationInstances.RequestId");
			describeCapacityReservationInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeCapacityReservationInstances.TotalCount");
			describeCapacityReservationInstancesResponse.MaxResults = _ctx.IntegerValue("DescribeCapacityReservationInstances.MaxResults");

			List<DescribeCapacityReservationInstancesResponse.DescribeCapacityReservationInstances_InstanceIdSet> describeCapacityReservationInstancesResponse_capacityReservationItem = new List<DescribeCapacityReservationInstancesResponse.DescribeCapacityReservationInstances_InstanceIdSet>();
			for (int i = 0; i < _ctx.Length("DescribeCapacityReservationInstances.CapacityReservationItem.Length"); i++) {
				DescribeCapacityReservationInstancesResponse.DescribeCapacityReservationInstances_InstanceIdSet instanceIdSet = new DescribeCapacityReservationInstancesResponse.DescribeCapacityReservationInstances_InstanceIdSet();
				instanceIdSet.InstanceId = _ctx.StringValue("DescribeCapacityReservationInstances.CapacityReservationItem["+ i +"].InstanceId");

				describeCapacityReservationInstancesResponse_capacityReservationItem.Add(instanceIdSet);
			}
			describeCapacityReservationInstancesResponse.CapacityReservationItem = describeCapacityReservationInstancesResponse_capacityReservationItem;
        
			return describeCapacityReservationInstancesResponse;
        }
    }
}
