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
        public static DescribeStorageCapacityUnitsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStorageCapacityUnitsResponse describeStorageCapacityUnitsResponse = new DescribeStorageCapacityUnitsResponse();

			describeStorageCapacityUnitsResponse.HttpResponse = _ctx.HttpResponse;
			describeStorageCapacityUnitsResponse.RequestId = _ctx.StringValue("DescribeStorageCapacityUnits.RequestId");
			describeStorageCapacityUnitsResponse.TotalCount = _ctx.IntegerValue("DescribeStorageCapacityUnits.TotalCount");
			describeStorageCapacityUnitsResponse.PageNumber = _ctx.IntegerValue("DescribeStorageCapacityUnits.PageNumber");
			describeStorageCapacityUnitsResponse.PageSize = _ctx.IntegerValue("DescribeStorageCapacityUnits.PageSize");

			List<DescribeStorageCapacityUnitsResponse.DescribeStorageCapacityUnits_StorageCapacityUnit> describeStorageCapacityUnitsResponse_storageCapacityUnits = new List<DescribeStorageCapacityUnitsResponse.DescribeStorageCapacityUnits_StorageCapacityUnit>();
			for (int i = 0; i < _ctx.Length("DescribeStorageCapacityUnits.StorageCapacityUnits.Length"); i++) {
				DescribeStorageCapacityUnitsResponse.DescribeStorageCapacityUnits_StorageCapacityUnit storageCapacityUnit = new DescribeStorageCapacityUnitsResponse.DescribeStorageCapacityUnits_StorageCapacityUnit();
				storageCapacityUnit.RegionId = _ctx.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].RegionId");
				storageCapacityUnit.StorageCapacityUnitId = _ctx.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].StorageCapacityUnitId");
				storageCapacityUnit.Name = _ctx.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].Name");
				storageCapacityUnit.Capacity = _ctx.IntegerValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].Capacity");
				storageCapacityUnit.Status = _ctx.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].Status");
				storageCapacityUnit.CreationTime = _ctx.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].CreationTime");
				storageCapacityUnit.ExpiredTime = _ctx.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].ExpiredTime");
				storageCapacityUnit.StartTime = _ctx.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].StartTime");
				storageCapacityUnit.Description = _ctx.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].Description");
				storageCapacityUnit.AllocationStatus = _ctx.StringValue("DescribeStorageCapacityUnits.StorageCapacityUnits["+ i +"].AllocationStatus");

				describeStorageCapacityUnitsResponse_storageCapacityUnits.Add(storageCapacityUnit);
			}
			describeStorageCapacityUnitsResponse.StorageCapacityUnits = describeStorageCapacityUnitsResponse_storageCapacityUnits;
        
			return describeStorageCapacityUnitsResponse;
        }
    }
}
