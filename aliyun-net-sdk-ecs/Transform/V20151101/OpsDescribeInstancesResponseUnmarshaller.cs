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
    public class OpsDescribeInstancesResponseUnmarshaller
    {
        public static OpsDescribeInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			OpsDescribeInstancesResponse opsDescribeInstancesResponse = new OpsDescribeInstancesResponse();

			opsDescribeInstancesResponse.HttpResponse = context.HttpResponse;
			opsDescribeInstancesResponse.RequestId = context.StringValue("OpsDescribeInstances.RequestId");
			opsDescribeInstancesResponse.TotalCount = context.IntegerValue("OpsDescribeInstances.TotalCount");
			opsDescribeInstancesResponse.PageNo = context.IntegerValue("OpsDescribeInstances.PageNo");
			opsDescribeInstancesResponse.PageSize = context.IntegerValue("OpsDescribeInstances.PageSize");

			List<OpsDescribeInstancesResponse.Instance> instances = new List<OpsDescribeInstancesResponse.Instance>();
			for (int i = 0; i < context.Length("OpsDescribeInstances.Instances.Length"); i++) {
				OpsDescribeInstancesResponse.Instance instance = new OpsDescribeInstancesResponse.Instance();
				instance.RegionNo = context.StringValue("OpsDescribeInstances.Instances["+ i +"].RegionNo");
				instance.IzNo = context.StringValue("OpsDescribeInstances.Instances["+ i +"].IzNo");
				instance.ZoneNo = context.StringValue("OpsDescribeInstances.Instances["+ i +"].ZoneNo");
				instance.EcsInstanceId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].EcsInstanceId");
				instance.AliUid = context.StringValue("OpsDescribeInstances.Instances["+ i +"].AliUid");
				instance.Bid = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Bid");
				instance.Hostname = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Hostname");
				instance.EcsInstanceName = context.StringValue("OpsDescribeInstances.Instances["+ i +"].EcsInstanceName");
				instance.Description = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Description");
				instance.Status = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Status");
				instance.BusinessStatus = context.EnumValue<OpsDescribeInstancesResponse.Instance.BusinessStatusEnum>("OpsDescribeInstances.Instances["+ i +"].BusinessStatus");
				instance.HouyiStatus = context.StringValue("OpsDescribeInstances.Instances["+ i +"].HouyiStatus");
				instance.PrivateIpAddress = context.StringValue("OpsDescribeInstances.Instances["+ i +"].PrivateIpAddress");
				instance.PublicIpAddress = context.StringValue("OpsDescribeInstances.Instances["+ i +"].PublicIpAddress");
				instance.ImageId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].ImageId");
				instance.ImageName = context.StringValue("OpsDescribeInstances.Instances["+ i +"].ImageName");
				instance.Cores = context.IntegerValue("OpsDescribeInstances.Instances["+ i +"].Cores");
				instance.Mem = context.IntegerValue("OpsDescribeInstances.Instances["+ i +"].Mem");
				instance.Disk = context.IntegerValue("OpsDescribeInstances.Instances["+ i +"].Disk");
				instance.IntranetRx = context.IntegerValue("OpsDescribeInstances.Instances["+ i +"].IntranetRx");
				instance.IntranetTx = context.IntegerValue("OpsDescribeInstances.Instances["+ i +"].IntranetTx");
				instance.InternetRx = context.IntegerValue("OpsDescribeInstances.Instances["+ i +"].InternetRx");
				instance.InternetTx = context.IntegerValue("OpsDescribeInstances.Instances["+ i +"].InternetTx");
				instance.SecurityControl = context.StringValue("OpsDescribeInstances.Instances["+ i +"].SecurityControl");
				instance.SystemDeviceCategory = context.StringValue("OpsDescribeInstances.Instances["+ i +"].SystemDeviceCategory");
				instance.CreatedTime = context.StringValue("OpsDescribeInstances.Instances["+ i +"].CreatedTime");
				instance.VpcId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].VpcId");
				instance.VswId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].VswId");
				instance.NatIp = context.StringValue("OpsDescribeInstances.Instances["+ i +"].NatIp");
				instance.Eip = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Eip");
				instance.EipId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].EipId");
				instance.EipBandwidth = context.IntegerValue("OpsDescribeInstances.Instances["+ i +"].EipBandwidth");
				instance.NetWorkType = context.StringValue("OpsDescribeInstances.Instances["+ i +"].NetWorkType");
				instance.NetworkValidation = context.BooleanValue("OpsDescribeInstances.Instances["+ i +"].NetworkValidation");
				instance.IoOptimized = context.BooleanValue("OpsDescribeInstances.Instances["+ i +"].IoOptimized");
				instance.MountAvailable = context.BooleanValue("OpsDescribeInstances.Instances["+ i +"].MountAvailable");
				instance.VlanId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].VlanId");
				instance.NcId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].NcId");
				instance.NcIp = context.StringValue("OpsDescribeInstances.Instances["+ i +"].NcIp");
				instance.RackId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].RackId");
				instance.VncHost = context.StringValue("OpsDescribeInstances.Instances["+ i +"].VncHost");
				instance.VncPort = context.IntegerValue("OpsDescribeInstances.Instances["+ i +"].VncPort");
				instance.VncPassword = context.StringValue("OpsDescribeInstances.Instances["+ i +"].VncPassword");
				instance.Platform = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Platform");

				List<string> groupIds = new List<string>();
				for (int j = 0; j < context.Length("OpsDescribeInstances.Instances["+ i +"].GroupIds.Length"); j++) {
					groupIds.Add(context.StringValue("OpsDescribeInstances.Instances["+ i +"].GroupIds["+ j +"]"));
				}
				instance.GroupIds = groupIds;

				List<OpsDescribeInstancesResponse.Instance.Disk> disks = new List<OpsDescribeInstancesResponse.Instance.Disk>();
				for (int j = 0; j < context.Length("OpsDescribeInstances.Instances["+ i +"].Disks.Length"); j++) {
					OpsDescribeInstancesResponse.Instance.Disk disk = new OpsDescribeInstancesResponse.Instance.Disk();
					disk.Id = context.LongValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].Id");
					disk.AliUid = context.LongValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].AliUid");
					disk.Bid = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].Bid");
					disk.DiskId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].DiskId");
					disk.HouyiDiskId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].HouyiDiskId");
					disk.DiskType = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].DiskType");
					disk.DiskCategory = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].DiskCategory");
					disk.Status = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].Status");
					disk.RegionNo = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].RegionNo");
					disk.IzNo = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].IzNo");
					disk.ZoneNo = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].ZoneNo");
					disk.DiskName = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].DiskName");
					disk.DiskDesc = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].DiskDesc");
					disk.DiskSize = context.IntegerValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].DiskSize");
					disk.Active = context.BooleanValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].Active");
					disk.Bootable = context.BooleanValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].Bootable");
					disk.Portable = context.BooleanValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].Portable");
					disk.ImageId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].ImageId");
					disk.SnapshotId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].SnapshotId");
					disk.EcsInstanceId = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].EcsInstanceId");
					disk.MountPoint = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].MountPoint");
					disk.DeleteWithInstance = context.BooleanValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].DeleteWithInstance");
					disk.DeleteAutoSnapshot = context.BooleanValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].DeleteAutoSnapshot");
					disk.EnableAutoSnapshot = context.BooleanValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].EnableAutoSnapshot");
					disk.BusinessStatus = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].BusinessStatus");
					disk.IopsSize = context.IntegerValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].IopsSize");
					disk.ProductCode = context.StringValue("OpsDescribeInstances.Instances["+ i +"].Disks["+ j +"].ProductCode");

					disks.Add(disk);
				}
				instance.Disks = disks;

				instances.Add(instance);
			}
			opsDescribeInstancesResponse.Instances = instances;
        
			return opsDescribeInstancesResponse;
        }
    }
}