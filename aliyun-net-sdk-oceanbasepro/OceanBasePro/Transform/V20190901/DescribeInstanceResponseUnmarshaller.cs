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
			instance.ReplicaMode = _ctx.StringValue("DescribeInstance.Instance.ReplicaMode");
			instance.IsolationOptimization = _ctx.BooleanValue("DescribeInstance.Instance.IsolationOptimization");
			instance.EnableIsolationOptimization = _ctx.BooleanValue("DescribeInstance.Instance.EnableIsolationOptimization");
			instance.InTempCapacityStatus = _ctx.BooleanValue("DescribeInstance.Instance.InTempCapacityStatus");
			instance.DataDiskAutoScale = _ctx.BooleanValue("DescribeInstance.Instance.DataDiskAutoScale");
			instance.EnableProxyService = _ctx.BooleanValue("DescribeInstance.Instance.EnableProxyService");
			instance.ProxyServiceStatus = _ctx.StringValue("DescribeInstance.Instance.ProxyServiceStatus");
			instance.ProxyClusterId = _ctx.StringValue("DescribeInstance.Instance.ProxyClusterId");
			instance.CpuArchitecture = _ctx.StringValue("DescribeInstance.Instance.CpuArchitecture");

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
			cpu.OriginalTotalCpu = _ctx.LongValue("DescribeInstance.Instance.Resource.Cpu.OriginalTotalCpu");
			resource.Cpu = cpu;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_Memory memory = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_Memory();
			memory.TotalMemory = _ctx.LongValue("DescribeInstance.Instance.Resource.Memory.TotalMemory");
			memory.UsedMemory = _ctx.LongValue("DescribeInstance.Instance.Resource.Memory.UsedMemory");
			memory.UnitMemory = _ctx.LongValue("DescribeInstance.Instance.Resource.Memory.UnitMemory");
			memory.OriginalTotalMemory = _ctx.LongValue("DescribeInstance.Instance.Resource.Memory.OriginalTotalMemory");
			resource.Memory = memory;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_DiskSize diskSize = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_DiskSize();
			diskSize.TotalDiskSize = _ctx.LongValue("DescribeInstance.Instance.Resource.DiskSize.TotalDiskSize");
			diskSize.UsedDiskSize = _ctx.LongValue("DescribeInstance.Instance.Resource.DiskSize.UsedDiskSize");
			diskSize.UnitDiskSize = _ctx.LongValue("DescribeInstance.Instance.Resource.DiskSize.UnitDiskSize");
			diskSize.DataUsedSize = _ctx.DoubleValue("DescribeInstance.Instance.Resource.DiskSize.DataUsedSize");
			diskSize.MaxDiskUsedPercent = _ctx.DoubleValue("DescribeInstance.Instance.Resource.DiskSize.MaxDiskUsedPercent");
			diskSize.OriginalTotalDiskSize = _ctx.LongValue("DescribeInstance.Instance.Resource.DiskSize.OriginalTotalDiskSize");
			diskSize.MaxDiskSize = _ctx.DoubleValue("DescribeInstance.Instance.Resource.DiskSize.MaxDiskSize");

			List<string> diskSize_maxDiskUsedObServer = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Instance.Resource.DiskSize.MaxDiskUsedObServer.Length"); i++) {
				diskSize_maxDiskUsedObServer.Add(_ctx.StringValue("DescribeInstance.Instance.Resource.DiskSize.MaxDiskUsedObServer["+ i +"]"));
			}
			diskSize.MaxDiskUsedObServer = diskSize_maxDiskUsedObServer;
			resource.DiskSize = diskSize;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_LogDiskSize logDiskSize = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_LogDiskSize();
			logDiskSize.TotalDiskSize = _ctx.LongValue("DescribeInstance.Instance.Resource.LogDiskSize.TotalDiskSize");
			logDiskSize.UnitDiskSize = _ctx.LongValue("DescribeInstance.Instance.Resource.LogDiskSize.UnitDiskSize");
			logDiskSize.LogAssignedSize = _ctx.StringValue("DescribeInstance.Instance.Resource.LogDiskSize.LogAssignedSize");
			logDiskSize.MaxLogAssignedPercent = _ctx.StringValue("DescribeInstance.Instance.Resource.LogDiskSize.MaxLogAssignedPercent");
			logDiskSize.OriginalTotalDiskSize = _ctx.IntegerValue("DescribeInstance.Instance.Resource.LogDiskSize.OriginalTotalDiskSize");

			List<string> logDiskSize_maxLogAssignedObServer = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Instance.Resource.LogDiskSize.MaxLogAssignedObServer.Length"); i++) {
				logDiskSize_maxLogAssignedObServer.Add(_ctx.StringValue("DescribeInstance.Instance.Resource.LogDiskSize.MaxLogAssignedObServer["+ i +"]"));
			}
			logDiskSize.MaxLogAssignedObServer = logDiskSize_maxLogAssignedObServer;
			resource.LogDiskSize = logDiskSize;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_CapacityUnit capacityUnit = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_Resource.DescribeInstance_CapacityUnit();
			capacityUnit.MaxCapacityUnit = _ctx.IntegerValue("DescribeInstance.Instance.Resource.CapacityUnit.MaxCapacityUnit");
			capacityUnit.MinCapacityUnit = _ctx.IntegerValue("DescribeInstance.Instance.Resource.CapacityUnit.MinCapacityUnit");
			capacityUnit.UsedCapacityUnit = _ctx.StringValue("DescribeInstance.Instance.Resource.CapacityUnit.UsedCapacityUnit");
			resource.CapacityUnit = capacityUnit;
			instance.Resource = resource;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_TenantCreatable tenantCreatable = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_TenantCreatable();
			tenantCreatable.EnableCreateTenant = _ctx.BooleanValue("DescribeInstance.Instance.TenantCreatable.EnableCreateTenant");
			tenantCreatable.DisableCreateTenantReason = _ctx.StringValue("DescribeInstance.Instance.TenantCreatable.DisableCreateTenantReason");
			instance.TenantCreatable = tenantCreatable;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_DataDiskAutoScaleConfig dataDiskAutoScaleConfig = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_DataDiskAutoScaleConfig();
			dataDiskAutoScaleConfig.AutoScale = _ctx.BooleanValue("DescribeInstance.Instance.DataDiskAutoScaleConfig.AutoScale");
			dataDiskAutoScaleConfig.Upperbound = _ctx.LongValue("DescribeInstance.Instance.DataDiskAutoScaleConfig.Upperbound");
			dataDiskAutoScaleConfig.UpperThreshold = _ctx.LongValue("DescribeInstance.Instance.DataDiskAutoScaleConfig.UpperThreshold");
			dataDiskAutoScaleConfig.UpperMergeThreshold = _ctx.LongValue("DescribeInstance.Instance.DataDiskAutoScaleConfig.UpperMergeThreshold");
			dataDiskAutoScaleConfig.MaxDiskSize = _ctx.LongValue("DescribeInstance.Instance.DataDiskAutoScaleConfig.MaxDiskSize");
			dataDiskAutoScaleConfig.ScaleStepInNormal = _ctx.LongValue("DescribeInstance.Instance.DataDiskAutoScaleConfig.ScaleStepInNormal");
			dataDiskAutoScaleConfig.ScaleStepInMerge = _ctx.LongValue("DescribeInstance.Instance.DataDiskAutoScaleConfig.ScaleStepInMerge");
			instance.DataDiskAutoScaleConfig = dataDiskAutoScaleConfig;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_ReadOnlyResource readOnlyResource = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_ReadOnlyResource();
			readOnlyResource.UnitCount = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.UnitCount");

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_ReadOnlyResource.DescribeInstance_Cpu1 cpu1 = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_ReadOnlyResource.DescribeInstance_Cpu1();
			cpu1.TotalCpu = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.Cpu.TotalCpu");
			cpu1.UsedCpu = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.Cpu.UsedCpu");
			cpu1.UnitCpu = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.Cpu.UnitCpu");
			cpu1.OriginalTotalCpu = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.Cpu.OriginalTotalCpu");
			readOnlyResource.Cpu1 = cpu1;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_ReadOnlyResource.DescribeInstance_Memory2 memory2 = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_ReadOnlyResource.DescribeInstance_Memory2();
			memory2.TotalMemory = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.Memory.TotalMemory");
			memory2.UsedMemory = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.Memory.UsedMemory");
			memory2.UnitMemory = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.Memory.UnitMemory");
			memory2.OriginalTotalMemory = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.Memory.OriginalTotalMemory");
			readOnlyResource.Memory2 = memory2;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_ReadOnlyResource.DescribeInstance_DiskSize3 diskSize3 = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_ReadOnlyResource.DescribeInstance_DiskSize3();
			diskSize3.TotalDiskSize = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.DiskSize.TotalDiskSize");
			diskSize3.UsedDiskSize = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.DiskSize.UsedDiskSize");
			diskSize3.UnitDiskSize = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.DiskSize.UnitDiskSize");
			diskSize3.DataUsedSize = _ctx.DoubleValue("DescribeInstance.Instance.ReadOnlyResource.DiskSize.DataUsedSize");
			diskSize3.MaxDiskUsedPercent = _ctx.DoubleValue("DescribeInstance.Instance.ReadOnlyResource.DiskSize.MaxDiskUsedPercent");
			diskSize3.OriginalTotalDiskSize = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.DiskSize.OriginalTotalDiskSize");
			diskSize3.MaxDiskSize = _ctx.DoubleValue("DescribeInstance.Instance.ReadOnlyResource.DiskSize.MaxDiskSize");

			List<string> diskSize3_maxDiskUsedObServer6 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Instance.ReadOnlyResource.DiskSize.MaxDiskUsedObServer.Length"); i++) {
				diskSize3_maxDiskUsedObServer6.Add(_ctx.StringValue("DescribeInstance.Instance.ReadOnlyResource.DiskSize.MaxDiskUsedObServer["+ i +"]"));
			}
			diskSize3.MaxDiskUsedObServer6 = diskSize3_maxDiskUsedObServer6;
			readOnlyResource.DiskSize3 = diskSize3;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_ReadOnlyResource.DescribeInstance_LogDiskSize4 logDiskSize4 = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_ReadOnlyResource.DescribeInstance_LogDiskSize4();
			logDiskSize4.TotalDiskSize = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.LogDiskSize.TotalDiskSize");
			logDiskSize4.UnitDiskSize = _ctx.LongValue("DescribeInstance.Instance.ReadOnlyResource.LogDiskSize.UnitDiskSize");
			logDiskSize4.LogAssignedSize = _ctx.StringValue("DescribeInstance.Instance.ReadOnlyResource.LogDiskSize.LogAssignedSize");
			logDiskSize4.MaxLogAssignedPercent = _ctx.StringValue("DescribeInstance.Instance.ReadOnlyResource.LogDiskSize.MaxLogAssignedPercent");

			List<string> logDiskSize4_maxLogAssignedObServer7 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Instance.ReadOnlyResource.LogDiskSize.MaxLogAssignedObServer.Length"); i++) {
				logDiskSize4_maxLogAssignedObServer7.Add(_ctx.StringValue("DescribeInstance.Instance.ReadOnlyResource.LogDiskSize.MaxLogAssignedObServer["+ i +"]"));
			}
			logDiskSize4.MaxLogAssignedObServer7 = logDiskSize4_maxLogAssignedObServer7;
			readOnlyResource.LogDiskSize4 = logDiskSize4;

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_ReadOnlyResource.DescribeInstance_CapacityUnit5 capacityUnit5 = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_ReadOnlyResource.DescribeInstance_CapacityUnit5();
			capacityUnit5.MaxCapacityUnit = _ctx.IntegerValue("DescribeInstance.Instance.ReadOnlyResource.CapacityUnit.MaxCapacityUnit");
			capacityUnit5.MinCapacityUnit = _ctx.IntegerValue("DescribeInstance.Instance.ReadOnlyResource.CapacityUnit.MinCapacityUnit");
			capacityUnit5.UsedCapacityUnit = _ctx.StringValue("DescribeInstance.Instance.ReadOnlyResource.CapacityUnit.UsedCapacityUnit");
			readOnlyResource.CapacityUnit5 = capacityUnit5;
			instance.ReadOnlyResource = readOnlyResource;
			describeInstanceResponse.Instance = instance;
        
			return describeInstanceResponse;
        }
    }
}
