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
			describeDisksResponse.NextToken = _ctx.StringValue("DescribeDisks.NextToken");
			describeDisksResponse.PageSize = _ctx.IntegerValue("DescribeDisks.PageSize");
			describeDisksResponse.PageNumber = _ctx.IntegerValue("DescribeDisks.PageNumber");
			describeDisksResponse.RequestId = _ctx.StringValue("DescribeDisks.RequestId");
			describeDisksResponse.TotalCount = _ctx.IntegerValue("DescribeDisks.TotalCount");

			List<DescribeDisksResponse.DescribeDisks_Disk> describeDisksResponse_disks = new List<DescribeDisksResponse.DescribeDisks_Disk>();
			for (int i = 0; i < _ctx.Length("DescribeDisks.Disks.Length"); i++) {
				DescribeDisksResponse.DescribeDisks_Disk disk = new DescribeDisksResponse.DescribeDisks_Disk();
				disk.SerialNumber = _ctx.StringValue("DescribeDisks.Disks["+ i +"].SerialNumber");
				disk.CreationTime = _ctx.StringValue("DescribeDisks.Disks["+ i +"].CreationTime");
				disk.Status = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Status");
				disk.Type = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Type");
				disk.PerformanceLevel = _ctx.StringValue("DescribeDisks.Disks["+ i +"].PerformanceLevel");
				disk.BdfId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].BdfId");
				disk.EnableAutoSnapshot = _ctx.BooleanValue("DescribeDisks.Disks["+ i +"].EnableAutoSnapshot");
				disk.StorageSetId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].StorageSetId");
				disk.StorageSetPartitionNumber = _ctx.IntegerValue("DescribeDisks.Disks["+ i +"].StorageSetPartitionNumber");
				disk.DiskId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].DiskId");
				disk.DeleteAutoSnapshot = _ctx.BooleanValue("DescribeDisks.Disks["+ i +"].DeleteAutoSnapshot");
				disk.DedicatedBlockStorageClusterId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].DedicatedBlockStorageClusterId");
				disk.Encrypted = _ctx.BooleanValue("DescribeDisks.Disks["+ i +"].Encrypted");
				disk.IOPSRead = _ctx.IntegerValue("DescribeDisks.Disks["+ i +"].IOPSRead");
				disk.MountInstanceNum = _ctx.IntegerValue("DescribeDisks.Disks["+ i +"].MountInstanceNum");
				disk.Description = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Description");
				disk.Device = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Device");
				disk.DiskName = _ctx.StringValue("DescribeDisks.Disks["+ i +"].DiskName");
				disk.Portable = _ctx.BooleanValue("DescribeDisks.Disks["+ i +"].Portable");
				disk.ImageId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].ImageId");
				disk.KMSKeyId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].KMSKeyId");
				disk.DeleteWithInstance = _ctx.BooleanValue("DescribeDisks.Disks["+ i +"].DeleteWithInstance");
				disk.DetachedTime = _ctx.StringValue("DescribeDisks.Disks["+ i +"].DetachedTime");
				disk.SourceSnapshotId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].SourceSnapshotId");
				disk.AutoSnapshotPolicyId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].AutoSnapshotPolicyId");
				disk.EnableAutomatedSnapshotPolicy = _ctx.BooleanValue("DescribeDisks.Disks["+ i +"].EnableAutomatedSnapshotPolicy");
				disk.IOPSWrite = _ctx.IntegerValue("DescribeDisks.Disks["+ i +"].IOPSWrite");
				disk.InstanceId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].InstanceId");
				disk.IOPS = _ctx.IntegerValue("DescribeDisks.Disks["+ i +"].IOPS");
				disk.RegionId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].RegionId");
				disk.ExpiredTime = _ctx.StringValue("DescribeDisks.Disks["+ i +"].ExpiredTime");
				disk.Size = _ctx.IntegerValue("DescribeDisks.Disks["+ i +"].Size");
				disk.ResourceGroupId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].ResourceGroupId");
				disk.DiskChargeType = _ctx.StringValue("DescribeDisks.Disks["+ i +"].DiskChargeType");
				disk.ZoneId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].ZoneId");
				disk.AttachedTime = _ctx.StringValue("DescribeDisks.Disks["+ i +"].AttachedTime");
				disk.Category = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Category");
				disk.ProductCode = _ctx.StringValue("DescribeDisks.Disks["+ i +"].ProductCode");
				disk.MultiAttach = _ctx.StringValue("DescribeDisks.Disks["+ i +"].MultiAttach");

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
					mountInstance.AttachedTime = _ctx.StringValue("DescribeDisks.Disks["+ i +"].MountInstances["+ j +"].AttachedTime");
					mountInstance.InstanceId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].MountInstances["+ j +"].InstanceId");
					mountInstance.Device = _ctx.StringValue("DescribeDisks.Disks["+ i +"].MountInstances["+ j +"].Device");

					disk_mountInstances.Add(mountInstance);
				}
				disk.MountInstances = disk_mountInstances;

				List<DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_Tag> disk_tags = new List<DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDisks.Disks["+ i +"].Tags.Length"); j++) {
					DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_Tag tag = new DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_Tag();
					tag.TagValue = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Tags["+ j +"].TagValue");
					tag.TagKey = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Tags["+ j +"].TagKey");

					disk_tags.Add(tag);
				}
				disk.Tags = disk_tags;

				List<DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_Attachment> disk_attachments = new List<DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_Attachment>();
				for (int j = 0; j < _ctx.Length("DescribeDisks.Disks["+ i +"].Attachments.Length"); j++) {
					DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_Attachment attachment = new DescribeDisksResponse.DescribeDisks_Disk.DescribeDisks_Attachment();
					attachment.InstanceId = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Attachments["+ j +"].InstanceId");
					attachment.Device = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Attachments["+ j +"].Device");
					attachment.AttachedTime = _ctx.StringValue("DescribeDisks.Disks["+ i +"].Attachments["+ j +"].AttachedTime");

					disk_attachments.Add(attachment);
				}
				disk.Attachments = disk_attachments;

				describeDisksResponse_disks.Add(disk);
			}
			describeDisksResponse.Disks = describeDisksResponse_disks;
        
			return describeDisksResponse;
        }
    }
}
