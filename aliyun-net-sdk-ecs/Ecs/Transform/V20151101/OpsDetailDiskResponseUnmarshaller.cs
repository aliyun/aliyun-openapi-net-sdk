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
    public class OpsDetailDiskResponseUnmarshaller
    {
        public static OpsDetailDiskResponse Unmarshall(UnmarshallerContext context)
        {
			OpsDetailDiskResponse opsDetailDiskResponse = new OpsDetailDiskResponse();

			opsDetailDiskResponse.HttpResponse = context.HttpResponse;
			opsDetailDiskResponse.RequestId = context.StringValue("OpsDetailDisk.RequestId");
			opsDetailDiskResponse.Id = context.LongValue("OpsDetailDisk.Id");
			opsDetailDiskResponse.AliUid = context.LongValue("OpsDetailDisk.AliUid");
			opsDetailDiskResponse.Bid = context.StringValue("OpsDetailDisk.Bid");
			opsDetailDiskResponse.HouyiDiskId = context.StringValue("OpsDetailDisk.HouyiDiskId");
			opsDetailDiskResponse.DiskType = context.StringValue("OpsDetailDisk.DiskType");
			opsDetailDiskResponse.DiskCategory = context.StringValue("OpsDetailDisk.DiskCategory");
			opsDetailDiskResponse.RegionNo = context.StringValue("OpsDetailDisk.RegionNo");
			opsDetailDiskResponse.IzNo = context.StringValue("OpsDetailDisk.IzNo");
			opsDetailDiskResponse.ZoneNo = context.StringValue("OpsDetailDisk.ZoneNo");
			opsDetailDiskResponse.DiskName = context.StringValue("OpsDetailDisk.DiskName");
			opsDetailDiskResponse.DiskDesc = context.StringValue("OpsDetailDisk.DiskDesc");
			opsDetailDiskResponse.Bootable = context.BooleanValue("OpsDetailDisk.Bootable");
			opsDetailDiskResponse.Portable = context.BooleanValue("OpsDetailDisk.Portable");
			opsDetailDiskResponse.ImageId = context.StringValue("OpsDetailDisk.ImageId");
			opsDetailDiskResponse.SnapshotId = context.StringValue("OpsDetailDisk.SnapshotId");
			opsDetailDiskResponse.EcsInstanceId = context.StringValue("OpsDetailDisk.EcsInstanceId");
			opsDetailDiskResponse.MountPoint = context.StringValue("OpsDetailDisk.MountPoint");
			opsDetailDiskResponse.DeleteWithInstance = context.BooleanValue("OpsDetailDisk.DeleteWithInstance");
			opsDetailDiskResponse.DeleteAutoSnapshot = context.BooleanValue("OpsDetailDisk.DeleteAutoSnapshot");
			opsDetailDiskResponse.EnableAutoSnapshot = context.BooleanValue("OpsDetailDisk.EnableAutoSnapshot");
			opsDetailDiskResponse.BusinessStatus = context.StringValue("OpsDetailDisk.BusinessStatus");
			opsDetailDiskResponse.CreatedTime = context.StringValue("OpsDetailDisk.CreatedTime");
			opsDetailDiskResponse.ModifiedTime = context.StringValue("OpsDetailDisk.ModifiedTime");
			opsDetailDiskResponse.LastAttachedTime = context.StringValue("OpsDetailDisk.LastAttachedTime");
			opsDetailDiskResponse.LastDetachedTime = context.StringValue("OpsDetailDisk.LastDetachedTime");
			opsDetailDiskResponse.IopsSize = context.IntegerValue("OpsDetailDisk.IopsSize");
			opsDetailDiskResponse.ProductCode = context.StringValue("OpsDetailDisk.ProductCode");
        
			return opsDetailDiskResponse;
        }
    }
}