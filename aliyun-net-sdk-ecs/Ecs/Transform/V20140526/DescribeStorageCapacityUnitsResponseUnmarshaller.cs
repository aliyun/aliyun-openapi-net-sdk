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
    public class DescribeStorageCapacityUnitsResponseUnmarshaller
    {
        public static DescribeStorageCapacityUnitsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStorageCapacityUnitsResponse describeStorageCapacityUnitsResponse = new DescribeStorageCapacityUnitsResponse();

			describeStorageCapacityUnitsResponse.HttpResponse = context.HttpResponse;
			describeStorageCapacityUnitsResponse.RequestId = context.StringValue("DescribeStorageCapacityUnits.RequestId");
			describeStorageCapacityUnitsResponse.TotalCount = context.IntegerValue("DescribeStorageCapacityUnits.TotalCount");
			describeStorageCapacityUnitsResponse.PageNumber = context.IntegerValue("DescribeStorageCapacityUnits.PageNumber");
			describeStorageCapacityUnitsResponse.PageSize = context.IntegerValue("DescribeStorageCapacityUnits.PageSize");

			List<DescribeStorageCapacityUnitsResponse.DescribeStorageCapacityUnits_StorageCapacityUnit> describeStorageCapacityUnitsResponse_storageCapacityUnits = new List<DescribeStorageCapacityUnitsResponse.DescribeStorageCapacityUnits_StorageCapacityUnit>();
			for (int i = 0; i < context.Length("DescribeStorageCapacityUnits.StorageCapacityUnits.Length"); i++) {
				DescribeStorageCapacityUnitsResponse.DescribeStorageCapacityUnits_StorageCapacityUnit storageCapacityUnit = new DescribeStorageCapacityUnitsResponse.DescribeStorageCapacityUnits_StorageCapacityUnit();
				storageCapacityUnit.RegionId = context.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].RegionId");
				storageCapacityUnit.StorageCapacityUnitId = context.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].StorageCapacityUnitId");
				storageCapacityUnit.Name = context.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].Name");
				storageCapacityUnit.Capacity = context.IntegerValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].Capacity");
				storageCapacityUnit.Status = context.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].Status");
				storageCapacityUnit.CreationTime = context.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].CreationTime");
				storageCapacityUnit.ExpiredTime = context.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].ExpiredTime");
				storageCapacityUnit.StartTime = context.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].StartTime");
				storageCapacityUnit.Description = context.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].Description");
				storageCapacityUnit.AllocationStatus = context.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].AllocationStatus");

				describeStorageCapacityUnitsResponse_storageCapacityUnits.Add(storageCapacityUnit);
			}
			describeStorageCapacityUnitsResponse.StorageCapacityUnits = describeStorageCapacityUnitsResponse_storageCapacityUnits;
        
			return describeStorageCapacityUnitsResponse;
        }
    }
}
