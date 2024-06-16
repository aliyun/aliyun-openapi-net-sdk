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
    public class DescribeTenantResponseUnmarshaller
    {
        public static DescribeTenantResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTenantResponse describeTenantResponse = new DescribeTenantResponse();

			describeTenantResponse.HttpResponse = _ctx.HttpResponse;
			describeTenantResponse.RequestId = _ctx.StringValue("DescribeTenant.RequestId");

			DescribeTenantResponse.DescribeTenant_Tenant tenant = new DescribeTenantResponse.DescribeTenant_Tenant();
			tenant.TenantId = _ctx.StringValue("DescribeTenant.Tenant.TenantId");
			tenant.TenantName = _ctx.StringValue("DescribeTenant.Tenant.TenantName");
			tenant.TenantMode = _ctx.StringValue("DescribeTenant.Tenant.TenantMode");
			tenant.VpcId = _ctx.StringValue("DescribeTenant.Tenant.VpcId");
			tenant.Status = _ctx.StringValue("DescribeTenant.Tenant.Status");
			tenant.EnableInternetAddressService = _ctx.BooleanValue("DescribeTenant.Tenant.EnableInternetAddressService");
			tenant.PrimaryZone = _ctx.StringValue("DescribeTenant.Tenant.PrimaryZone");
			tenant.DeployType = _ctx.StringValue("DescribeTenant.Tenant.DeployType");
			tenant.DeployMode = _ctx.StringValue("DescribeTenant.Tenant.DeployMode");
			tenant.Description = _ctx.StringValue("DescribeTenant.Tenant.Description");
			tenant.CreateTime = _ctx.StringValue("DescribeTenant.Tenant.CreateTime");
			tenant.ClogServiceStatus = _ctx.StringValue("DescribeTenant.Tenant.ClogServiceStatus");
			tenant.EnableClogService = _ctx.BooleanValue("DescribeTenant.Tenant.EnableClogService");
			tenant.Charset = _ctx.StringValue("DescribeTenant.Tenant.Charset");
			tenant.Collation = _ctx.StringValue("DescribeTenant.Tenant.Collation");
			tenant.PrimaryZoneDeployType = _ctx.StringValue("DescribeTenant.Tenant.PrimaryZoneDeployType");
			tenant.MasterIntranetAddressZone = _ctx.StringValue("DescribeTenant.Tenant.MasterIntranetAddressZone");
			tenant.PayType = _ctx.StringValue("DescribeTenant.Tenant.PayType");
			tenant.InstanceType = _ctx.StringValue("DescribeTenant.Tenant.InstanceType");
			tenant.Series = _ctx.StringValue("DescribeTenant.Tenant.Series");
			tenant.DiskType = _ctx.StringValue("DescribeTenant.Tenant.DiskType");
			tenant.EnableReadWriteSplit = _ctx.BooleanValue("DescribeTenant.Tenant.EnableReadWriteSplit");
			tenant.EnableParallelQuery = _ctx.BooleanValue("DescribeTenant.Tenant.EnableParallelQuery");
			tenant.MaxParallelQueryDegree = _ctx.LongValue("DescribeTenant.Tenant.MaxParallelQueryDegree");
			tenant.EnableBinlogService = _ctx.BooleanValue("DescribeTenant.Tenant.EnableBinlogService");
			tenant.TimeZone = _ctx.StringValue("DescribeTenant.Tenant.TimeZone");
			tenant.DataMergeTime = _ctx.StringValue("DescribeTenant.Tenant.DataMergeTime");

			List<string> tenant_availableZones = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeTenant.Tenant.AvailableZones.Length"); i++) {
				tenant_availableZones.Add(_ctx.StringValue("DescribeTenant.Tenant.AvailableZones["+ i +"]"));
			}
			tenant.AvailableZones = tenant_availableZones;

			DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantResource tenantResource = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantResource();
			tenantResource.UnitNum = _ctx.IntegerValue("DescribeTenant.Tenant.TenantResource.UnitNum");

			DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantResource.DescribeTenant_Cpu cpu = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantResource.DescribeTenant_Cpu();
			cpu.UsedCpu = _ctx.FloatValue("DescribeTenant.Tenant.TenantResource.Cpu.UsedCpu");
			cpu.TotalCpu = _ctx.FloatValue("DescribeTenant.Tenant.TenantResource.Cpu.TotalCpu");
			cpu.UnitCpu = _ctx.FloatValue("DescribeTenant.Tenant.TenantResource.Cpu.UnitCpu");
			tenantResource.Cpu = cpu;

			DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantResource.DescribeTenant_Memory memory = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantResource.DescribeTenant_Memory();
			memory.UsedMemory = _ctx.FloatValue("DescribeTenant.Tenant.TenantResource.Memory.UsedMemory");
			memory.TotalMemory = _ctx.FloatValue("DescribeTenant.Tenant.TenantResource.Memory.TotalMemory");
			memory.UnitMemory = _ctx.FloatValue("DescribeTenant.Tenant.TenantResource.Memory.UnitMemory");
			tenantResource.Memory = memory;

			DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantResource.DescribeTenant_DiskSize diskSize = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantResource.DescribeTenant_DiskSize();
			diskSize.UsedDiskSize = _ctx.FloatValue("DescribeTenant.Tenant.TenantResource.DiskSize.UsedDiskSize");
			tenantResource.DiskSize = diskSize;

			DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantResource.DescribeTenant_CapacityUnit capacityUnit = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantResource.DescribeTenant_CapacityUnit();
			capacityUnit.MaxCapacityUnit = _ctx.IntegerValue("DescribeTenant.Tenant.TenantResource.CapacityUnit.MaxCapacityUnit");
			capacityUnit.MinCapacityUnit = _ctx.IntegerValue("DescribeTenant.Tenant.TenantResource.CapacityUnit.MinCapacityUnit");
			capacityUnit.UsedCapacit = _ctx.IntegerValue("DescribeTenant.Tenant.TenantResource.CapacityUnit.UsedCapacit");
			tenantResource.CapacityUnit = capacityUnit;

			DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantResource.DescribeTenant_LogDiskSize logDiskSize = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantResource.DescribeTenant_LogDiskSize();
			logDiskSize.TotalLogDisk = _ctx.IntegerValue("DescribeTenant.Tenant.TenantResource.LogDiskSize.TotalLogDisk");
			logDiskSize.UnitLogDisk = _ctx.IntegerValue("DescribeTenant.Tenant.TenantResource.LogDiskSize.UnitLogDisk");
			tenantResource.LogDiskSize = logDiskSize;
			tenant.TenantResource = tenantResource;

			DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_ReadOnlyResource readOnlyResource = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_ReadOnlyResource();
			readOnlyResource.UnitNum = _ctx.IntegerValue("DescribeTenant.Tenant.ReadOnlyResource.UnitNum");

			DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_ReadOnlyResource.DescribeTenant_Cpu1 cpu1 = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_ReadOnlyResource.DescribeTenant_Cpu1();
			cpu1.UsedCpu = _ctx.FloatValue("DescribeTenant.Tenant.ReadOnlyResource.Cpu.UsedCpu");
			cpu1.TotalCpu = _ctx.FloatValue("DescribeTenant.Tenant.ReadOnlyResource.Cpu.TotalCpu");
			cpu1.UnitCpu = _ctx.FloatValue("DescribeTenant.Tenant.ReadOnlyResource.Cpu.UnitCpu");
			readOnlyResource.Cpu1 = cpu1;

			DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_ReadOnlyResource.DescribeTenant_Memory2 memory2 = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_ReadOnlyResource.DescribeTenant_Memory2();
			memory2.UsedMemory = _ctx.FloatValue("DescribeTenant.Tenant.ReadOnlyResource.Memory.UsedMemory");
			memory2.TotalMemory = _ctx.FloatValue("DescribeTenant.Tenant.ReadOnlyResource.Memory.TotalMemory");
			memory2.UnitMemory = _ctx.FloatValue("DescribeTenant.Tenant.ReadOnlyResource.Memory.UnitMemory");
			readOnlyResource.Memory2 = memory2;

			DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_ReadOnlyResource.DescribeTenant_DiskSize3 diskSize3 = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_ReadOnlyResource.DescribeTenant_DiskSize3();
			diskSize3.UsedDiskSize = _ctx.FloatValue("DescribeTenant.Tenant.ReadOnlyResource.DiskSize.UsedDiskSize");
			readOnlyResource.DiskSize3 = diskSize3;

			DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_ReadOnlyResource.DescribeTenant_CapacityUnit4 capacityUnit4 = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_ReadOnlyResource.DescribeTenant_CapacityUnit4();
			capacityUnit4.MaxCapacityUnit = _ctx.IntegerValue("DescribeTenant.Tenant.ReadOnlyResource.CapacityUnit.MaxCapacityUnit");
			capacityUnit4.MinCapacityUnit = _ctx.IntegerValue("DescribeTenant.Tenant.ReadOnlyResource.CapacityUnit.MinCapacityUnit");
			capacityUnit4.UsedCapacit = _ctx.IntegerValue("DescribeTenant.Tenant.ReadOnlyResource.CapacityUnit.UsedCapacit");
			readOnlyResource.CapacityUnit4 = capacityUnit4;

			DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_ReadOnlyResource.DescribeTenant_LogDiskSize5 logDiskSize5 = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_ReadOnlyResource.DescribeTenant_LogDiskSize5();
			logDiskSize5.TotalLogDisk = _ctx.IntegerValue("DescribeTenant.Tenant.ReadOnlyResource.LogDiskSize.TotalLogDisk");
			logDiskSize5.UnitLogDisk = _ctx.IntegerValue("DescribeTenant.Tenant.ReadOnlyResource.LogDiskSize.UnitLogDisk");
			readOnlyResource.LogDiskSize5 = logDiskSize5;
			tenant.ReadOnlyResource = readOnlyResource;

			List<DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantConnectionsItem> tenant_tenantConnections = new List<DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantConnectionsItem>();
			for (int i = 0; i < _ctx.Length("DescribeTenant.Tenant.TenantConnections.Length"); i++) {
				DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantConnectionsItem tenantConnectionsItem = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantConnectionsItem();
				tenantConnectionsItem.IntranetAddress = _ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].IntranetAddress");
				tenantConnectionsItem.IntranetPort = _ctx.IntegerValue("DescribeTenant.Tenant.TenantConnections["+ i +"].IntranetPort");
				tenantConnectionsItem.InternetAddress = _ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].InternetAddress");
				tenantConnectionsItem.InternetPort = _ctx.IntegerValue("DescribeTenant.Tenant.TenantConnections["+ i +"].InternetPort");
				tenantConnectionsItem.VpcId = _ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].VpcId");
				tenantConnectionsItem.VSwitchId = _ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].VSwitchId");
				tenantConnectionsItem.IntranetAddressMasterZoneId = _ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].IntranetAddressMasterZoneId");
				tenantConnectionsItem.IntranetAddressSlaveZoneId = _ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].IntranetAddressSlaveZoneId");
				tenantConnectionsItem.IntranetAddressStatus = _ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].IntranetAddressStatus");
				tenantConnectionsItem.InternetAddressStatus = _ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].InternetAddressStatus");
				tenantConnectionsItem.TransactionSplit = _ctx.BooleanValue("DescribeTenant.Tenant.TenantConnections["+ i +"].TransactionSplit");
				tenantConnectionsItem.AddressType = _ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].AddressType");
				tenantConnectionsItem.EnableTransactionSplit = _ctx.BooleanValue("DescribeTenant.Tenant.TenantConnections["+ i +"].EnableTransactionSplit");
				tenantConnectionsItem.ParallelQueryDegree = _ctx.LongValue("DescribeTenant.Tenant.TenantConnections["+ i +"].ParallelQueryDegree");
				tenantConnectionsItem.TenantEndpointId = _ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].TenantEndpointId");
				tenantConnectionsItem.MaxConnectionNum = _ctx.LongValue("DescribeTenant.Tenant.TenantConnections["+ i +"].MaxConnectionNum");
				tenantConnectionsItem.ConnectionReplicaType = _ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].ConnectionReplicaType");

				List<string> tenantConnectionsItem_connectionZones = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeTenant.Tenant.TenantConnections["+ i +"].ConnectionZones.Length"); j++) {
					tenantConnectionsItem_connectionZones.Add(_ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].ConnectionZones["+ j +"]"));
				}
				tenantConnectionsItem.ConnectionZones = tenantConnectionsItem_connectionZones;

				tenant_tenantConnections.Add(tenantConnectionsItem);
			}
			tenant.TenantConnections = tenant_tenantConnections;

			List<DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantZonesItem> tenant_tenantZones = new List<DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantZonesItem>();
			for (int i = 0; i < _ctx.Length("DescribeTenant.Tenant.TenantZones.Length"); i++) {
				DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantZonesItem tenantZonesItem = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantZonesItem();
				tenantZonesItem.TenantZoneId = _ctx.StringValue("DescribeTenant.Tenant.TenantZones["+ i +"].TenantZoneId");
				tenantZonesItem.Region = _ctx.StringValue("DescribeTenant.Tenant.TenantZones["+ i +"].Region");
				tenantZonesItem.TenantZoneRole = _ctx.StringValue("DescribeTenant.Tenant.TenantZones["+ i +"].TenantZoneRole");

				List<DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantZonesItem.DescribeTenant_TenantZoneReplicasItem> tenantZonesItem_tenantZoneReplicas = new List<DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantZonesItem.DescribeTenant_TenantZoneReplicasItem>();
				for (int j = 0; j < _ctx.Length("DescribeTenant.Tenant.TenantZones["+ i +"].TenantZoneReplicas.Length"); j++) {
					DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantZonesItem.DescribeTenant_TenantZoneReplicasItem tenantZoneReplicasItem = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantZonesItem.DescribeTenant_TenantZoneReplicasItem();
					tenantZoneReplicasItem.ZoneReplicaType = _ctx.StringValue("DescribeTenant.Tenant.TenantZones["+ i +"].TenantZoneReplicas["+ j +"].ZoneReplicaType");
					tenantZoneReplicasItem.ZoneNodes = _ctx.StringValue("DescribeTenant.Tenant.TenantZones["+ i +"].TenantZoneReplicas["+ j +"].ZoneNodes");
					tenantZoneReplicasItem.LogicZoneName = _ctx.StringValue("DescribeTenant.Tenant.TenantZones["+ i +"].TenantZoneReplicas["+ j +"].LogicZoneName");
					tenantZoneReplicasItem.ZoneCopyId = _ctx.IntegerValue("DescribeTenant.Tenant.TenantZones["+ i +"].TenantZoneReplicas["+ j +"].ZoneCopyId");
					tenantZoneReplicasItem.FullCopyId = _ctx.IntegerValue("DescribeTenant.Tenant.TenantZones["+ i +"].TenantZoneReplicas["+ j +"].FullCopyId");
					tenantZoneReplicasItem.ReadOnlyCopyId = _ctx.StringValue("DescribeTenant.Tenant.TenantZones["+ i +"].TenantZoneReplicas["+ j +"].ReadOnlyCopyId");

					tenantZonesItem_tenantZoneReplicas.Add(tenantZoneReplicasItem);
				}
				tenantZonesItem.TenantZoneReplicas = tenantZonesItem_tenantZoneReplicas;

				tenant_tenantZones.Add(tenantZonesItem);
			}
			tenant.TenantZones = tenant_tenantZones;
			describeTenantResponse.Tenant = tenant;
        
			return describeTenantResponse;
        }
    }
}
