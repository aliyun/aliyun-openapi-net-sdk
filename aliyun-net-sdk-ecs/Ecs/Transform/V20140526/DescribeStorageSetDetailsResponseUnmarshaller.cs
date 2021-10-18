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
        public static DescribeStorageSetDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStorageSetDetailsResponse describeStorageSetDetailsResponse = new DescribeStorageSetDetailsResponse();

			describeStorageSetDetailsResponse.HttpResponse = _ctx.HttpResponse;
			describeStorageSetDetailsResponse.PageSize = _ctx.IntegerValue("DescribeStorageSetDetails.PageSize");
			describeStorageSetDetailsResponse.RequestId = _ctx.StringValue("DescribeStorageSetDetails.RequestId");
			describeStorageSetDetailsResponse.PageNumber = _ctx.IntegerValue("DescribeStorageSetDetails.PageNumber");
			describeStorageSetDetailsResponse.TotalCount = _ctx.IntegerValue("DescribeStorageSetDetails.TotalCount");

			List<DescribeStorageSetDetailsResponse.DescribeStorageSetDetails_Disk> describeStorageSetDetailsResponse_disks = new List<DescribeStorageSetDetailsResponse.DescribeStorageSetDetails_Disk>();
			for (int i = 0; i < _ctx.Length("DescribeStorageSetDetails.Disks.Length"); i++) {
				DescribeStorageSetDetailsResponse.DescribeStorageSetDetails_Disk disk = new DescribeStorageSetDetailsResponse.DescribeStorageSetDetails_Disk();
				disk.CreationTime = _ctx.StringValue("DescribeStorageSetDetails.Disks["+ i +"].CreationTime");
				disk.DiskName = _ctx.StringValue("DescribeStorageSetDetails.Disks["+ i +"].DiskName");
				disk.ZoneId = _ctx.StringValue("DescribeStorageSetDetails.Disks["+ i +"].ZoneId");
				disk.StorageSetId = _ctx.StringValue("DescribeStorageSetDetails.Disks["+ i +"].StorageSetId");
				disk.DiskId = _ctx.StringValue("DescribeStorageSetDetails.Disks["+ i +"].DiskId");
				disk.Category = _ctx.StringValue("DescribeStorageSetDetails.Disks["+ i +"].Category");
				disk.StorageSetPartitionNumber = _ctx.IntegerValue("DescribeStorageSetDetails.Disks["+ i +"].StorageSetPartitionNumber");
				disk.RegionId = _ctx.StringValue("DescribeStorageSetDetails.Disks["+ i +"].RegionId");

				describeStorageSetDetailsResponse_disks.Add(disk);
			}
			describeStorageSetDetailsResponse.Disks = describeStorageSetDetailsResponse_disks;
        
			return describeStorageSetDetailsResponse;
        }
    }
}
