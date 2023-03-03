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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeInstanceResponseUnmarshaller
    {
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceResponse.RequestId = _ctx.StringValue("DescribeInstance.RequestId");

			DescribeInstanceResponse.DescribeInstance_Instance instance = new DescribeInstanceResponse.DescribeInstance_Instance();
			instance.InstanceId = _ctx.StringValue("DescribeInstance.Instance.InstanceId");
			instance.InstanceName = _ctx.StringValue("DescribeInstance.Instance.InstanceName");
			instance.InstanceClass = _ctx.StringValue("DescribeInstance.Instance.InstanceClass");
			instance.Series = _ctx.StringValue("DescribeInstance.Instance.Series");
			instance.PayType = _ctx.StringValue("DescribeInstance.Instance.PayType");
			instance.CreateTime = _ctx.StringValue("DescribeInstance.Instance.CreateTime");
			instance.ExpireTime = _ctx.StringValue("DescribeInstance.Instance.ExpireTime");
			instance.Version = _ctx.StringValue("DescribeInstance.Instance.Version");
			instance.DeployType = _ctx.StringValue("DescribeInstance.Instance.DeployType");
			instance.DeployMode = _ctx.StringValue("DescribeInstance.Instance.DeployMode");
			instance.DiskType = _ctx.StringValue("DescribeInstance.Instance.DiskType");
			instance.MaintainTime = _ctx.StringValue("DescribeInstance.Instance.MaintainTime");
			instance.DataMergeTime = _ctx.StringValue("DescribeInstance.Instance.DataMergeTime");
			instance.AutoRenewal = _ctx.BooleanValue("DescribeInstance.Instance.AutoRenewal");
			instance.IsTrustEcs = _ctx.BooleanValue("DescribeInstance.Instance.IsTrustEcs");
			instance.Status = _ctx.StringValue("DescribeInstance.Instance.Status");
			instance.AutoUpgradeObVersion = _ctx.BooleanValue("DescribeInstance.Instance.AutoUpgradeObVersion");
			instance.ObRpmVersion = _ctx.StringValue("DescribeInstance.Instance.ObRpmVersion");
			instance.IsLatestObVersion = _ctx.BooleanValue("DescribeInstance.Instance.IsLatestObVersion");
			instance.EnableUpgradeLogDisk = _ctx.BooleanValue("DescribeInstance.Instance.EnableUpgradeLogDisk");
			instance.InstanceRole = _ctx.StringValue("DescribeInstance.Instance.InstanceRole");
			instance.NodeNum = _ctx.StringValue("DescribeInstance.Instance.NodeNum");

			List<string> instance_availableZones = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Instance.AvailableZones.Length"); i++) {
				instance_availableZones.Add(_ctx.StringValue("DescribeInstance.Instance.AvailableZones["+ i +"]"));
			}
			instance.AvailableZones = instance_availableZones;

			List<string> instance_zones = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Instance.Zones.Length"); i++) {
				instance_zones.Add(_ctx.StringValue("DescribeInstance.Instance.Zones["+ i +"]"));
			}
			instance.Zones = instance_zones;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource resource = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource();
			resource.UnitCount = _ctx.LongValue("DescribeInstance.Instance.Resource.UnitCount");

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_Cpu cpu = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_Cpu();
			cpu.TotalCpu = _ctx.LongValue("DescribeInstance.Instance.Resource.Cpu.TotalCpu");
			cpu.UsedCpu = _ctx.LongValue("DescribeInstance.Instance.Resource.Cpu.UsedCpu");
			cpu.UnitCpu = _ctx.LongValue("DescribeInstance.Instance.Resource.Cpu.UnitCpu");
			resource.Cpu = cpu;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_Memory memory = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_Memory();
			memory.TotalMemory = _ctx.LongValue("DescribeInstance.Instance.Resource.Memory.TotalMemory");
			memory.UsedMemory = _ctx.LongValue("DescribeInstance.Instance.Resource.Memory.UsedMemory");
			memory.UnitMemory = _ctx.LongValue("DescribeInstance.Instance.Resource.Memory.UnitMemory");
			resource.Memory = memory;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_DiskSize diskSize = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_DiskSize();
			diskSize.TotalDiskSize = _ctx.LongValue("DescribeInstance.Instance.Resource.DiskSize.TotalDiskSize");
			diskSize.UsedDiskSize = _ctx.LongValue("DescribeInstance.Instance.Resource.DiskSize.UsedDiskSize");
			diskSize.UnitDiskSize = _ctx.LongValue("DescribeInstance.Instance.Resource.DiskSize.UnitDiskSize");
			diskSize.DataUsedSize = _ctx.DoubleValue("DescribeInstance.Instance.Resource.DiskSize.DataUsedSize");
			diskSize.MaxDiskUsedPercent = _ctx.DoubleValue("DescribeInstance.Instance.Resource.DiskSize.MaxDiskUsedPercent");

			List<string> diskSize_maxDiskUsedObServer = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Instance.Resource.DiskSize.MaxDiskUsedObServer.Length"); i++) {
				diskSize_maxDiskUsedObServer.Add(_ctx.StringValue("DescribeInstance.Instance.Resource.DiskSize.MaxDiskUsedObServer["+ i +"]"));
			}
			diskSize.MaxDiskUsedObServer = diskSize_maxDiskUsedObServer;
			resource.DiskSize = diskSize;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_LogDiskSize logDiskSize = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_LogDiskSize();
			logDiskSize.TotalDiskSize = _ctx.LongValue("DescribeInstance.Instance.Resource.LogDiskSize.TotalDiskSize");
			logDiskSize.UnitDiskSize = _ctx.LongValue("DescribeInstance.Instance.Resource.LogDiskSize.UnitDiskSize");
			resource.LogDiskSize = logDiskSize;
			instance.Resource = resource;
			describeInstanceResponse.Instance = instance;
        
			return describeInstanceResponse;
        }
    }
}
