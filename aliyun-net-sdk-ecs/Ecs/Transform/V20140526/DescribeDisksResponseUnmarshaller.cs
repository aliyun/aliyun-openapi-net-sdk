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
    public class DescribeDisksResponseUnmarshaller
    {
        public static DescribeDisksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDisksResponse describeDisksResponse = new DescribeDisksResponse();

			describeDisksResponse.HttpResponse = _ctx.HttpResponse;
			describeDisksResponse.RequestId = _ctx.StringValue("DescribeDisks.RequestId");
			describeDisksResponse.TotalCount = _ctx.IntegerValue("DescribeDisks.TotalCount");
			describeDisksResponse.PageNumber = _ctx.IntegerValue("DescribeDisks.PageNumber");
			describeDisksResponse.PageSize = _ctx.IntegerValue("DescribeDisks.PageSize");
			describeDisksResponse.NextToken = _ctx.StringValue("DescribeDisks.NextToken");

			List<DescribeDisksResponse.DescribeDisks_Disk> describeDisksResponse_disks = new List<DescribeDisksResponse.DescribeDisks_Disk>();
			for (int i = 0; i < _ctx.Length("DescribeDisks.Disks.Length"); i++) {
				DescribeDisksResponse.DescribeDisks_Disk disk = new DescribeDisksResponse.DescribeDisks_Disk();
				disk.DiskId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].DiskId");
				disk.RegionId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].RegionId");
				disk.ZoneId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].ZoneId");
				disk.DiskName = _ctx.StringValue("DescribeDisks.Disks["+ i +"].DiskName");
				disk.Description = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Description");
				disk.Type = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Type");
				disk.Category = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Category");
				disk.Size = _ctx.IntegerValue("DescribeDisks.Disks["+ i +"].Size");
				disk.ImageId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].ImageId");
				disk.SourceSnapshotId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].SourceSnapshotId");
				disk.AutoSnapshotPolicyId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].AutoSnapshotPolicyId");
				disk.ProductCode = _ctx.StringValue("DescribeDisks.Disks["+ i +"].ProductCode");
				disk.Portable = _ctx.BooleanValue("DescribeDisks.Disks["+ i +"].Portable");
				disk.Status = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Status");
				disk.InstanceId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].InstanceId");
				disk.Device = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Device");
				disk.DeleteWithInstance = _ctx.BooleanValue("DescribeDisks.Disks["+ i +"].DeleteWithInstance");
				disk.DeleteAutoSnapshot = _ctx.BooleanValue("DescribeDisks.Disks["+ i +"].DeleteAutoSnapshot");
				disk.EnableAutoSnapshot = _ctx.BooleanValue("DescribeDisks.Disks["+ i +"].EnableAutoSnapshot");
				disk.EnableAutomatedSnapshotPolicy = _ctx.BooleanValue("DescribeDisks.Disks["+ i +"].EnableAutomatedSnapshotPolicy");
				disk.CreationTime = _ctx.StringValue("DescribeDisks.Disks["+ i +"].CreationTime");
				disk.AttachedTime = _ctx.StringValue("DescribeDisks.Disks["+ i +"].AttachedTime");
				disk.DetachedTime = _ctx.StringValue("DescribeDisks.Disks["+ i +"].DetachedTime");
				disk.DiskChargeType = _ctx.StringValue("DescribeDisks.Disks["+ i +"].DiskChargeType");
				disk.ExpiredTime = _ctx.StringValue("DescribeDisks.Disks["+ i +"].ExpiredTime");
				disk.ResourceGroupId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].ResourceGroupId");
				disk.Encrypted = _ctx.BooleanValue("DescribeDisks.Disks["+ i +"].Encrypted");
				disk.StorageSetId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].StorageSetId");
				disk.StorageSetPartitionNumber = _ctx.IntegerValue("DescribeDisks.Disks["+ i +"].StorageSetPartitionNumber");
				disk.MountInstanceNum = _ctx.IntegerValue("DescribeDisks.Disks["+ i +"].MountInstanceNum");
				disk.IOPS = _ctx.IntegerValue("DescribeDisks.Disks["+ i +"].IOPS");
				disk.IOPSRead = _ctx.IntegerValue("DescribeDisks.Disks["+ i +"].IOPSRead");
				disk.IOPSWrite = _ctx.IntegerValue("DescribeDisks.Disks["+ i +"].IOPSWrite");
				disk.KMSKeyId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].KMSKeyId");
				disk.PerformanceLevel = _ctx.StringValue("DescribeDisks.Disks["+ i +"].PerformanceLevel");
				disk.BdfId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].BdfId");
				disk.SerialNumber = _ctx.StringValue("DescribeDisks.Disks["+ i +"].SerialNumber");
				disk.DedicatedBlockStorageClusterId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].DedicatedBlockStorageClusterId");

				List<DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_OperationLock> disk_operationLocks = new List<DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_OperationLock>();
				for (int j = 0; j < _ctx.Length("DescribeDisks.Disks["+ i +"].OperationLocks.Length"); j++) {
					DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_OperationLock operationLock = new DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_OperationLock();
					operationLock.LockReason = _ctx.StringValue("DescribeDisks.Disks["+ i +"].OperationLocks["+ j +"].LockReason");

					disk_operationLocks.Add(operationLock);
				}
				disk.OperationLocks = disk_operationLocks;

				List<DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_MountInstance> disk_mountInstances = new List<DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_MountInstance>();
				for (int j = 0; j < _ctx.Length("DescribeDisks.Disks["+ i +"].MountInstances.Length"); j++) {
					DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_MountInstance mountInstance = new DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_MountInstance();
					mountInstance.InstanceId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].MountInstances["+ j +"].InstanceId");
					mountInstance.Device = _ctx.StringValue("DescribeDisks.Disks["+ i +"].MountInstances["+ j +"].Device");
					mountInstance.AttachedTime = _ctx.StringValue("DescribeDisks.Disks["+ i +"].MountInstances["+ j +"].AttachedTime");

					disk_mountInstances.Add(mountInstance);
				}
				disk.MountInstances = disk_mountInstances;

				List<DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_Tag> disk_tags = new List<DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDisks.Disks["+ i +"].Tags.Length"); j++) {
					DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_Tag tag = new DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_Tag();
					tag.TagKey = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Tags["+ j +"].TagValue");

					disk_tags.Add(tag);
				}
				disk.Tags = disk_tags;

				describeDisksResponse_disks.Add(disk);
			}
			describeDisksResponse.Disks = describeDisksResponse_disks;
        
			return describeDisksResponse;
        }
    }
}
