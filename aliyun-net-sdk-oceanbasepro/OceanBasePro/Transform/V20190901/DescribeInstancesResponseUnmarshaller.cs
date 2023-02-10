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
    public class DescribeInstancesResponseUnmarshaller
    {
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeInstances.TotalCount");
			describeInstancesResponse.RequestId = _ctx.StringValue("DescribeInstances.RequestId");

			List<DescribeInstancesResponse.DescribeInstances_Data> describeInstancesResponse_instances = new List<DescribeInstancesResponse.DescribeInstances_Data>();
			for (int i = 0; i < _ctx.Length("DescribeInstances.Instances.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_Data data = new DescribeInstancesResponse.DescribeInstances_Data();
				data.VpcId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].VpcId");
				data.CommodityCode = _ctx.StringValue("DescribeInstances.Instances["+ i +"].CommodityCode");
				data.ExpireTime = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ExpireTime");
				data.State = _ctx.StringValue("DescribeInstances.Instances["+ i +"].State");
				data.InstanceClass = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceClass");
				data.CreateTime = _ctx.StringValue("DescribeInstances.Instances["+ i +"].CreateTime");
				data.DeployMode = _ctx.StringValue("DescribeInstances.Instances["+ i +"].DeployMode");
				data.MaintainTime = _ctx.StringValue("DescribeInstances.Instances["+ i +"].MaintainTime");
				data.DeployType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].DeployType");
				data.PayType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].PayType");
				data.DiskSize = _ctx.StringValue("DescribeInstances.Instances["+ i +"].DiskSize");
				data.DiskType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].DiskType");
				data.InstanceId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceId");
				data.ExpireSeconds = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].ExpireSeconds");
				data.Mem = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Mem");
				data.EnableUpgradeNodes = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].EnableUpgradeNodes");
				data.Cpu = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].Cpu");
				data.Version = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Version");
				data.InstanceName = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceName");
				data.Series = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Series");
				data.UsedDiskSize = _ctx.LongValue("DescribeInstances.Instances["+ i +"].UsedDiskSize");
				data.ResourceGroupId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ResourceGroupId");
				data.InstanceType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceType");
				data.InstanceRole = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceRole");

				List<string> data_availableZones = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeInstances.Instances["+ i +"].AvailableZones.Length"); j++) {
					data_availableZones.Add(_ctx.StringValue("DescribeInstances.Instances["+ i +"].AvailableZones["+ j +"]"));
				}
				data.AvailableZones = data_availableZones;

				List<string> data_securityIps = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeInstances.Instances["+ i +"].SecurityIps.Length"); j++) {
					data_securityIps.Add(_ctx.StringValue("DescribeInstances.Instances["+ i +"].SecurityIps["+ j +"]"));
				}
				data.SecurityIps = data_securityIps;

				DescribeInstancesResponse.DescribeInstances_Data.DescribeInstances_Resource resource = new DescribeInstancesResponse.DescribeInstances_Data.DescribeInstances_Resource();
				resource.UnitCount = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Resource.UnitCount");

				DescribeInstancesResponse.DescribeInstances_Data.DescribeInstances_Resource.DescribeInstances_Cpu cpu = new DescribeInstancesResponse.DescribeInstances_Data.DescribeInstances_Resource.DescribeInstances_Cpu();
				cpu.TotalCpu = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Resource.Cpu.TotalCpu");
				cpu.UsedCpu = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Resource.Cpu.UsedCpu");
				cpu.UnitCpu = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Resource.Cpu.UnitCpu");
				resource.Cpu = cpu;

				DescribeInstancesResponse.DescribeInstances_Data.DescribeInstances_Resource.DescribeInstances_Memory memory = new DescribeInstancesResponse.DescribeInstances_Data.DescribeInstances_Resource.DescribeInstances_Memory();
				memory.TotalMemory = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Resource.Memory.TotalMemory");
				memory.UsedMemory = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Resource.Memory.UsedMemory");
				memory.UnitMemory = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Resource.Memory.UnitMemory");
				resource.Memory = memory;

				DescribeInstancesResponse.DescribeInstances_Data.DescribeInstances_Resource.DescribeInstances_DiskSize diskSize = new DescribeInstancesResponse.DescribeInstances_Data.DescribeInstances_Resource.DescribeInstances_DiskSize();
				diskSize.TotalDiskSize = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Resource.DiskSize.TotalDiskSize");
				diskSize.UsedDiskSize = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Resource.DiskSize.UsedDiskSize");
				diskSize.UnitDiskSize = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Resource.DiskSize.UnitDiskSize");
				resource.DiskSize = diskSize;
				data.Resource = resource;

				describeInstancesResponse_instances.Add(data);
			}
			describeInstancesResponse.Instances = describeInstancesResponse_instances;
        
			return describeInstancesResponse;
        }
    }
}
