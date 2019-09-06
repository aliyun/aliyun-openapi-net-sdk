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
    public class DescribeStorageSetsResponseUnmarshaller
    {
        public static DescribeStorageSetsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStorageSetsResponse describeStorageSetsResponse = new DescribeStorageSetsResponse();

			describeStorageSetsResponse.HttpResponse = context.HttpResponse;
			describeStorageSetsResponse.RequestId = context.StringValue("DescribeStorageSets.RequestId");
			describeStorageSetsResponse.TotalCount = context.IntegerValue("DescribeStorageSets.TotalCount");
			describeStorageSetsResponse.PageNumber = context.IntegerValue("DescribeStorageSets.PageNumber");
			describeStorageSetsResponse.PageSize = context.IntegerValue("DescribeStorageSets.PageSize");

			List<DescribeStorageSetsResponse.DescribeStorageSets_StorageSet> describeStorageSetsResponse_storageSets = new List<DescribeStorageSetsResponse.DescribeStorageSets_StorageSet>();
			for (int i = 0; i < context.Length("DescribeStorageSets.StorageSets.Length"); i++) {
				DescribeStorageSetsResponse.DescribeStorageSets_StorageSet storageSet = new DescribeStorageSetsResponse.DescribeStorageSets_StorageSet();
				storageSet.StorageSetId = context.StringValue("DescribeStorageSets.StorageSets["+ i +"].StorageSetId");
				storageSet.CreationTime = context.StringValue("DescribeStorageSets.StorageSets["+ i +"].CreationTime");
				storageSet.StorageSetName = context.StringValue("DescribeStorageSets.StorageSets["+ i +"].StorageSetName");
				storageSet.Description = context.StringValue("DescribeStorageSets.StorageSets["+ i +"].Description");
				storageSet.StorageSetPartitionNumber = context.IntegerValue("DescribeStorageSets.StorageSets["+ i +"].StorageSetPartitionNumber");
				storageSet.RegionId = context.StringValue("DescribeStorageSets.StorageSets["+ i +"].RegionId");
				storageSet.ZoneId = context.StringValue("DescribeStorageSets.StorageSets["+ i +"].ZoneId");

				describeStorageSetsResponse_storageSets.Add(storageSet);
			}
			describeStorageSetsResponse.StorageSets = describeStorageSetsResponse_storageSets;
        
			return describeStorageSetsResponse;
        }
    }
}
