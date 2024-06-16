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
    public class DescribeInstanceTopologyResponseUnmarshaller
    {
        public static DescribeInstanceTopologyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceTopologyResponse describeInstanceTopologyResponse = new DescribeInstanceTopologyResponse();

			describeInstanceTopologyResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceTopologyResponse.RequestId = _ctx.StringValue("DescribeInstanceTopology.RequestId");

			DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology instanceTopology = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology();

			List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_TenantsItem> instanceTopology_tenants = new List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_TenantsItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceTopology.InstanceTopology.Tenants.Length"); i++) {
				DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_TenantsItem tenantsItem = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_TenantsItem();
				tenantsItem.TenantId = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantId");
				tenantsItem.TenantName = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantName");
				tenantsItem.TenantCpu = _ctx.FloatValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantCpu");
				tenantsItem.TenantMemory = _ctx.FloatValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantMemory");
				tenantsItem.TenantMode = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantMode");
				tenantsItem.TenantStatus = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantStatus");
				tenantsItem.TenantDeployType = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantDeployType");
				tenantsItem.TenantUnitNum = _ctx.IntegerValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantUnitNum");
				tenantsItem.PrimaryZoneDeployType = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].PrimaryZoneDeployType");

				List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_TenantsItem.DescribeInstanceTopology_TenantZonesItem> tenantsItem_tenantZones = new List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_TenantsItem.DescribeInstanceTopology_TenantZonesItem>();
				for (int j = 0; j < _ctx.Length("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones.Length"); j++) {
					DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_TenantsItem.DescribeInstanceTopology_TenantZonesItem tenantZonesItem = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_TenantsItem.DescribeInstanceTopology_TenantZonesItem();
					tenantZonesItem.TenantZoneRole = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].TenantZoneRole");
					tenantZonesItem.IsPrimaryTenantZone = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].IsPrimaryTenantZone");
					tenantZonesItem.TenantZoneId = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].TenantZoneId");

					List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_TenantsItem.DescribeInstanceTopology_TenantZonesItem.DescribeInstanceTopology_UnitsItem> tenantZonesItem_units = new List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_TenantsItem.DescribeInstanceTopology_TenantZonesItem.DescribeInstanceTopology_UnitsItem>();
					for (int k = 0; k < _ctx.Length("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].Units.Length"); k++) {
						DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_TenantsItem.DescribeInstanceTopology_TenantZonesItem.DescribeInstanceTopology_UnitsItem unitsItem = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_TenantsItem.DescribeInstanceTopology_TenantZonesItem.DescribeInstanceTopology_UnitsItem();
						unitsItem.UnitId = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].Units["+ k +"].UnitId");
						unitsItem.UnitStatus = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].Units["+ k +"].UnitStatus");
						unitsItem.NodeId = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].Units["+ k +"].NodeId");
						unitsItem.UnitCpu = _ctx.FloatValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].Units["+ k +"].UnitCpu");
						unitsItem.UnitMemory = _ctx.FloatValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].Units["+ k +"].UnitMemory");
						unitsItem.EnableMigrateUnit = _ctx.BooleanValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].Units["+ k +"].EnableMigrateUnit");
						unitsItem.ManualMigrate = _ctx.BooleanValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].Units["+ k +"].ManualMigrate");
						unitsItem.EnableCancelMigrateUnit = _ctx.BooleanValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].Units["+ k +"].EnableCancelMigrateUnit");
						unitsItem.UnitDataSize = _ctx.LongValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].Units["+ k +"].UnitDataSize");
						unitsItem.ReplicaType = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Tenants["+ i +"].TenantZones["+ j +"].Units["+ k +"].ReplicaType");

						tenantZonesItem_units.Add(unitsItem);
					}
					tenantZonesItem.Units = tenantZonesItem_units;

					tenantsItem_tenantZones.Add(tenantZonesItem);
				}
				tenantsItem.TenantZones = tenantsItem_tenantZones;

				instanceTopology_tenants.Add(tenantsItem);
			}
			instanceTopology.Tenants = instanceTopology_tenants;

			List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem> instanceTopology_zones = new List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceTopology.InstanceTopology.Zones.Length"); i++) {
				DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem zonesItem = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem();
				zonesItem.ZoneId = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].ZoneId");
				zonesItem.Region = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Region");
				zonesItem.ZoneDisk = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].ZoneDisk");

				DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_ZoneResource zoneResource = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_ZoneResource();

				DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_ZoneResource.DescribeInstanceTopology_DiskSize1 diskSize1 = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_ZoneResource.DescribeInstanceTopology_DiskSize1();
				diskSize1.MaxDiskUsedPercent = _ctx.DoubleValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].ZoneResource.DiskSize.MaxDiskUsedPercent");

				List<string> diskSize1_maxDiskUsedObServer = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].ZoneResource.DiskSize.MaxDiskUsedObServer.Length"); j++) {
					diskSize1_maxDiskUsedObServer.Add(_ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].ZoneResource.DiskSize.MaxDiskUsedObServer["+ j +"]"));
				}
				diskSize1.MaxDiskUsedObServer = diskSize1_maxDiskUsedObServer;
				zoneResource.DiskSize1 = diskSize1;
				zonesItem.ZoneResource = zoneResource;

				List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem> zonesItem_nodes = new List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem>();
				for (int j = 0; j < _ctx.Length("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes.Length"); j++) {
					DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem nodesItem = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem();
					nodesItem.NodeId = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].NodeId");
					nodesItem.NodeCopyId = _ctx.LongValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].NodeCopyId");
					nodesItem.NodeStatus = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].NodeStatus");
					nodesItem.ReplicaType = _ctx.StringValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].ReplicaType");
					nodesItem.FullCopyId = _ctx.LongValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].FullCopyId");
					nodesItem.ReadOnlyCopyId = _ctx.LongValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].ReadOnlyCopyId");

					List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem.DescribeInstanceTopology_NodeResourceItem> nodesItem_nodeResource = new List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem.DescribeInstanceTopology_NodeResourceItem>();
					for (int k = 0; k < _ctx.Length("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].NodeResource.Length"); k++) {
						DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem.DescribeInstanceTopology_NodeResourceItem nodeResourceItem = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem.DescribeInstanceTopology_NodeResourceItem();

						DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem.DescribeInstanceTopology_NodeResourceItem.DescribeInstanceTopology_Cpu cpu = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem.DescribeInstanceTopology_NodeResourceItem.DescribeInstanceTopology_Cpu();
						cpu.UsedCpu = _ctx.FloatValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].NodeResource["+ k +"].Cpu.UsedCpu");
						cpu.TotalCpu = _ctx.IntegerValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].NodeResource["+ k +"].Cpu.TotalCpu");
						nodeResourceItem.Cpu = cpu;

						DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem.DescribeInstanceTopology_NodeResourceItem.DescribeInstanceTopology_Memory memory = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem.DescribeInstanceTopology_NodeResourceItem.DescribeInstanceTopology_Memory();
						memory.UsedMemory = _ctx.FloatValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].NodeResource["+ k +"].Memory.UsedMemory");
						memory.TotalMemory = _ctx.LongValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].NodeResource["+ k +"].Memory.TotalMemory");
						nodeResourceItem.Memory = memory;

						DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem.DescribeInstanceTopology_NodeResourceItem.DescribeInstanceTopology_DiskSize diskSize = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_InstanceTopology.DescribeInstanceTopology_ZonesItem.DescribeInstanceTopology_NodesItem.DescribeInstanceTopology_NodeResourceItem.DescribeInstanceTopology_DiskSize();
						diskSize.TotalDiskSize = _ctx.DoubleValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].NodeResource["+ k +"].DiskSize.TotalDiskSize");
						diskSize.UsedDiskSize = _ctx.DoubleValue("DescribeInstanceTopology.InstanceTopology.Zones["+ i +"].Nodes["+ j +"].NodeResource["+ k +"].DiskSize.UsedDiskSize");
						nodeResourceItem.DiskSize = diskSize;

						nodesItem_nodeResource.Add(nodeResourceItem);
					}
					nodesItem.NodeResource = nodesItem_nodeResource;

					zonesItem_nodes.Add(nodesItem);
				}
				zonesItem.Nodes = zonesItem_nodes;

				instanceTopology_zones.Add(zonesItem);
			}
			instanceTopology.Zones = instanceTopology_zones;
			describeInstanceTopologyResponse.InstanceTopology = instanceTopology;
        
			return describeInstanceTopologyResponse;
        }
    }
}
