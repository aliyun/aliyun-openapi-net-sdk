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
    public class DescribeStorageSetDetailsResponseUnmarshaller
    {
        public static DescribeStorageSetDetailsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStorageSetDetailsResponse describeStorageSetDetailsResponse = new DescribeStorageSetDetailsResponse();

			describeStorageSetDetailsResponse.HttpResponse = context.HttpResponse;
			describeStorageSetDetailsResponse.RequestId = context.StringValue("DescribeStorageSetDetails.RequestId");
			describeStorageSetDetailsResponse.TotalCount = context.IntegerValue("DescribeStorageSetDetails.TotalCount");
			describeStorageSetDetailsResponse.PageNumber = context.IntegerValue("DescribeStorageSetDetails.PageNumber");
			describeStorageSetDetailsResponse.PageSize = context.IntegerValue("DescribeStorageSetDetails.PageSize");

			List<DescribeStorageSetDetailsResponse.DescribeStorageSetDetails_Disk> describeStorageSetDetailsResponse_disks = new List<DescribeStorageSetDetailsResponse.DescribeStorageSetDetails_Disk>();
			for (int i = 0; i < context.Length("DescribeStorageSetDetails.Disks.Length"); i++) {
				DescribeStorageSetDetailsResponse.DescribeStorageSetDetails_Disk disk = new DescribeStorageSetDetailsResponse.DescribeStorageSetDetails_Disk();
				disk.DiskId = context.StringValue("DescribeStorageSetDetails.Disks["+ i +"].DiskId");
				disk.DiskName = context.StringValue("DescribeStorageSetDetails.Disks["+ i +"].DiskName");
				disk.Category = context.StringValue("DescribeStorageSetDetails.Disks["+ i +"].Category");
				disk.StorageSetId = context.StringValue("DescribeStorageSetDetails.Disks["+ i +"].StorageSetId");
				disk.CreationTime = context.StringValue("DescribeStorageSetDetails.Disks["+ i +"].CreationTime");
				disk.StorageSetPartitionNumber = context.IntegerValue("DescribeStorageSetDetails.Disks["+ i +"].StorageSetPartitionNumber");
				disk.RegionId = context.StringValue("DescribeStorageSetDetails.Disks["+ i +"].RegionId");
				disk.ZoneId = context.StringValue("DescribeStorageSetDetails.Disks["+ i +"].ZoneId");

				describeStorageSetDetailsResponse_disks.Add(disk);
			}
			describeStorageSetDetailsResponse.Disks = describeStorageSetDetailsResponse_disks;
        
			return describeStorageSetDetailsResponse;
        }
    }
}
