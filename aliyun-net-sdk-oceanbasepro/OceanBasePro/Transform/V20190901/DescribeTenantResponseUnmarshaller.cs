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
			tenant.TenantResource = tenantResource;

			List<DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantConnectionsItem> tenant_tenantConnections = new List<DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantConnectionsItem>();
			for (int i = 0; i < _ctx.Length("DescribeTenant.Tenant.TenantConnections.Length"); i++) {
				DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantConnectionsItem tenantConnectionsItem = new DescribeTenantResponse.DescribeTenant_Tenant.DescribeTenant_TenantConnectionsItem();
				tenantConnectionsItem.ConnectionRole = _ctx.StringValue("DescribeTenant.Tenant.TenantConnections["+ i +"].ConnectionRole");
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

				tenant_tenantZones.Add(tenantZonesItem);
			}
			tenant.TenantZones = tenant_tenantZones;
			describeTenantResponse.Tenant = tenant;
        
			return describeTenantResponse;
        }
    }
}
