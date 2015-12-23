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
using Aliyun.Acs.Ecs.Model.V20151101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20151101
{
    public class OpsDescribeDisksResponseUnmarshaller
    {
        public static OpsDescribeDisksResponse Unmarshall(UnmarshallerContext context)
        {
			OpsDescribeDisksResponse opsDescribeDisksResponse = new OpsDescribeDisksResponse();

			opsDescribeDisksResponse.HttpResponse = context.HttpResponse;
			opsDescribeDisksResponse.RequestId = context.StringValue("OpsDescribeDisks.RequestId");
			opsDescribeDisksResponse.TotalCount = context.IntegerValue("OpsDescribeDisks.TotalCount");
			opsDescribeDisksResponse.PageNo = context.IntegerValue("OpsDescribeDisks.PageNo");
			opsDescribeDisksResponse.PageSize = context.IntegerValue("OpsDescribeDisks.PageSize");

			List<OpsDescribeDisksResponse.Disk> disks = new List<OpsDescribeDisksResponse.Disk>();
			for (int i = 0; i < context.Length("OpsDescribeDisks.Disks.Length"); i++) {
				OpsDescribeDisksResponse.Disk disk = new OpsDescribeDisksResponse.Disk();
				disk.Id = context.LongValue("OpsDescribeDisks.Disks["+ i +"].Id");
				disk.AliUid = context.LongValue("OpsDescribeDisks.Disks["+ i +"].AliUid");
				disk.Bid = context.StringValue("OpsDescribeDisks.Disks["+ i +"].Bid");
				disk.DiskId = context.StringValue("OpsDescribeDisks.Disks["+ i +"].DiskId");
				disk.HouyiDiskId = context.StringValue("OpsDescribeDisks.Disks["+ i +"].HouyiDiskId");
				disk.DiskType = context.StringValue("OpsDescribeDisks.Disks["+ i +"].DiskType");
				disk.DiskCategory = context.StringValue("OpsDescribeDisks.Disks["+ i +"].DiskCategory");
				disk.Status = context.StringValue("OpsDescribeDisks.Disks["+ i +"].Status");
				disk.RegionNo = context.StringValue("OpsDescribeDisks.Disks["+ i +"].RegionNo");
				disk.IzNo = context.StringValue("OpsDescribeDisks.Disks["+ i +"].IzNo");
				disk.ZoneNo = context.StringValue("OpsDescribeDisks.Disks["+ i +"].ZoneNo");
				disk.DiskName = context.StringValue("OpsDescribeDisks.Disks["+ i +"].DiskName");
				disk.DiskDesc = context.StringValue("OpsDescribeDisks.Disks["+ i +"].DiskDesc");
				disk.DiskSize = context.IntegerValue("OpsDescribeDisks.Disks["+ i +"].DiskSize");
				disk.Active = context.BooleanValue("OpsDescribeDisks.Disks["+ i +"].Active");
				disk.Bootable = context.BooleanValue("OpsDescribeDisks.Disks["+ i +"].Bootable");
				disk.Portable = context.BooleanValue("OpsDescribeDisks.Disks["+ i +"].Portable");
				disk.ImageId = context.StringValue("OpsDescribeDisks.Disks["+ i +"].ImageId");
				disk.SnapshotId = context.StringValue("OpsDescribeDisks.Disks["+ i +"].SnapshotId");
				disk.EcsInstanceId = context.StringValue("OpsDescribeDisks.Disks["+ i +"].EcsInstanceId");
				disk.MountPoint = context.StringValue("OpsDescribeDisks.Disks["+ i +"].MountPoint");
				disk.DeleteWithInstance = context.BooleanValue("OpsDescribeDisks.Disks["+ i +"].DeleteWithInstance");
				disk.DeleteAutoSnapshot = context.BooleanValue("OpsDescribeDisks.Disks["+ i +"].DeleteAutoSnapshot");
				disk.EnableAutoSnapshot = context.BooleanValue("OpsDescribeDisks.Disks["+ i +"].EnableAutoSnapshot");
				disk.BusinessStatus = context.StringValue("OpsDescribeDisks.Disks["+ i +"].BusinessStatus");
				disk.CreatedTime = context.StringValue("OpsDescribeDisks.Disks["+ i +"].CreatedTime");
				disk.ModifiedTime = context.StringValue("OpsDescribeDisks.Disks["+ i +"].ModifiedTime");
				disk.LastAttachedTime = context.StringValue("OpsDescribeDisks.Disks["+ i +"].LastAttachedTime");
				disk.LastDetachedTime = context.StringValue("OpsDescribeDisks.Disks["+ i +"].LastDetachedTime");
				disk.IopsSize = context.IntegerValue("OpsDescribeDisks.Disks["+ i +"].IopsSize");
				disk.ProductCode = context.StringValue("OpsDescribeDisks.Disks["+ i +"].ProductCode");

				disks.Add(disk);
			}
			opsDescribeDisksResponse.Disks = disks;
        
			return opsDescribeDisksResponse;
        }
    }
}