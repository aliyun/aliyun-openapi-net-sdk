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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeDisksResponseUnmarshaller
    {
        public static DescribeDisksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDisksResponse describeDisksResponse = new DescribeDisksResponse();

			describeDisksResponse.HttpResponse = context.HttpResponse;
			describeDisksResponse.RequestId = context.StringValue("DescribeDisks.RequestId");
			describeDisksResponse.TotalCount = context.IntegerValue("DescribeDisks.TotalCount");
			describeDisksResponse.PageNumber = context.IntegerValue("DescribeDisks.PageNumber");
			describeDisksResponse.PageSize = context.IntegerValue("DescribeDisks.PageSize");

			List<DescribeDisksResponse.Disk> disks = new List<DescribeDisksResponse.Disk>();
			for (int i = 0; i < context.Length("DescribeDisks.Disks.Length"); i++) {
				DescribeDisksResponse.Disk disk = new DescribeDisksResponse.Disk();
				disk.DiskId = context.StringValue("DescribeDisks.Disks["+ i +"].DiskId");
				disk.RegionId = context.StringValue("DescribeDisks.Disks["+ i +"].RegionId");
				disk.ZoneId = context.StringValue("DescribeDisks.Disks["+ i +"].ZoneId");
				disk.DiskName = context.StringValue("DescribeDisks.Disks["+ i +"].DiskName");
				disk.Description = context.StringValue("DescribeDisks.Disks["+ i +"].Description");
				disk.Type = (DescribeDisksResponse.Disk.Type_)Enum.Parse(typeof(DescribeDisksResponse.Disk.Type_),
					 context.StringValue("DescribeDisks.Disks["+ i +"].Type"));
				disk.Category = (DescribeDisksResponse.Disk.Category_)Enum.Parse(typeof(DescribeDisksResponse.Disk.Category_),
					 context.StringValue("DescribeDisks.Disks["+ i +"].Category"));
				disk.Size = context.IntegerValue("DescribeDisks.Disks["+ i +"].Size");
				disk.ImageId = context.StringValue("DescribeDisks.Disks["+ i +"].ImageId");
				disk.SourceSnapshotId = context.StringValue("DescribeDisks.Disks["+ i +"].SourceSnapshotId");
				disk.ProductCode = context.StringValue("DescribeDisks.Disks["+ i +"].ProductCode");
				disk.Portable = context.BooleanValue("DescribeDisks.Disks["+ i +"].Portable");
				disk.Status = context.StringValue("DescribeDisks.Disks["+ i +"].Status");
				disk.InstanceId = context.StringValue("DescribeDisks.Disks["+ i +"].InstanceId");
				disk.Device = context.StringValue("DescribeDisks.Disks["+ i +"].Device");
				disk.DeleteWithInstance = context.BooleanValue("DescribeDisks.Disks["+ i +"].DeleteWithInstance");
				disk.DeleteAutoSnapshot = context.BooleanValue("DescribeDisks.Disks["+ i +"].DeleteAutoSnapshot");
				disk.EnableAutoSnapshot = context.BooleanValue("DescribeDisks.Disks["+ i +"].EnableAutoSnapshot");
				disk.CreationTime = context.StringValue("DescribeDisks.Disks["+ i +"].CreationTime");
				disk.AttachedTime = context.StringValue("DescribeDisks.Disks["+ i +"].AttachedTime");
				disk.DetachedTime = context.StringValue("DescribeDisks.Disks["+ i +"].DetachedTime");
				disk.DiskChargeType = context.StringValue("DescribeDisks.Disks["+ i +"].DiskChargeType");
				disk.ExpiredTime = context.StringValue("DescribeDisks.Disks["+ i +"].ExpiredTime");

				List<DescribeDisksResponse.Disk.OperationLock> operationLocks = new List<DescribeDisksResponse.Disk.OperationLock>();
				for (int j = 0; j < context.Length("DescribeDisks.Disks["+ i +"].OperationLocks.Length"); j++) {
					DescribeDisksResponse.Disk.OperationLock operationLock = new DescribeDisksResponse.Disk.OperationLock();
					operationLock.LockReason = context.StringValue("DescribeDisks.Disks["+ i +"].OperationLocks["+ j +"].LockReason");

					operationLocks.Add(operationLock);
				}
				disk.OperationLocks = operationLocks;

				List<DescribeDisksResponse.Disk.Tag> tags = new List<DescribeDisksResponse.Disk.Tag>();
				for (int j = 0; j < context.Length("DescribeDisks.Disks["+ i +"].Tags.Length"); j++) {
					DescribeDisksResponse.Disk.Tag tag = new DescribeDisksResponse.Disk.Tag();
					tag.TagKey = context.StringValue("DescribeDisks.Disks["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeDisks.Disks["+ i +"].Tags["+ j +"].TagValue");

					tags.Add(tag);
				}
				disk.Tags = tags;

				disks.Add(disk);
			}
			describeDisksResponse.Disks = disks;
        
			return describeDisksResponse;
        }
    }
}