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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstancesResponseUnmarshaller
    {
        public static DescribeDBInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstancesResponse describeDBInstancesResponse = new DescribeDBInstancesResponse();

			describeDBInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstancesResponse.RequestId = _ctx.StringValue("DescribeDBInstances.RequestId");
			describeDBInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeDBInstances.PageNumber");
			describeDBInstancesResponse.PageRecordCount = _ctx.IntegerValue("DescribeDBInstances.PageRecordCount");
			describeDBInstancesResponse.TotalRecordCount = _ctx.IntegerValue("DescribeDBInstances.TotalRecordCount");
			describeDBInstancesResponse.NextToken = _ctx.StringValue("DescribeDBInstances.NextToken");

			List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance> describeDBInstancesResponse_items = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstances.Items.Length"); i++) {
				DescribeDBInstancesResponse.DescribeDBInstances_DBInstance dBInstance = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance();
				dBInstance.VpcId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].VpcId");
				dBInstance.DedicatedHostIdForLog = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostIdForLog");
				dBInstance.CreateTime = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].CreateTime");
				dBInstance.PayType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].PayType");
				dBInstance.DedicatedHostNameForLog = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostNameForLog");
				dBInstance.MutriORsignle = _ctx.BooleanValue("DescribeDBInstances.Items["+ i +"].MutriORsignle");
				dBInstance.DedicatedHostGroupName = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostGroupName");
				dBInstance.EngineVersion = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].EngineVersion");
				dBInstance.DedicatedHostGroupId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostGroupId");
				dBInstance.VpcName = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].VpcName");
				dBInstance.DedicatedHostZoneIdForMaster = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostZoneIdForMaster");
				dBInstance.InsId = _ctx.IntegerValue("DescribeDBInstances.Items["+ i +"].InsId");
				dBInstance.ConnectionString = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ConnectionString");
				dBInstance.InstanceNetworkType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].InstanceNetworkType");
				dBInstance.MasterInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].MasterInstanceId");
				dBInstance.AutoUpgradeMinorVersion = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].AutoUpgradeMinorVersion");
				dBInstance.ExpireTime = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ExpireTime");
				dBInstance.DestroyTime = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DestroyTime");
				dBInstance.GuardDBInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].GuardDBInstanceId");
				dBInstance.DedicatedHostNameForMaster = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostNameForMaster");
				dBInstance.ZoneId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ZoneId");
				dBInstance.TipsLevel = _ctx.IntegerValue("DescribeDBInstances.Items["+ i +"].TipsLevel");
				dBInstance.DBInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceId");
				dBInstance.DedicatedHostIdForMaster = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostIdForMaster");
				dBInstance.ReplicateId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ReplicateId");
				dBInstance.TempDBInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].TempDBInstanceId");
				dBInstance.DBInstanceStorageType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceStorageType");
				dBInstance.ConnectionMode = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ConnectionMode");
				dBInstance.LockMode = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].LockMode");
				dBInstance.GeneralGroupName = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].GeneralGroupName");
				dBInstance.VpcCloudInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].VpcCloudInstanceId");
				dBInstance.DedicatedHostZoneIdForSlave = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostZoneIdForSlave");
				dBInstance.Tips = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].Tips");
				dBInstance.DedicatedHostZoneIdForLog = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostZoneIdForLog");
				dBInstance.DedicatedHostNameForSlave = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostNameForSlave");
				dBInstance.DBInstanceDescription = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceDescription");
				dBInstance.DBInstanceCPU = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceCPU");
				dBInstance.DBInstanceMemory = _ctx.IntegerValue("DescribeDBInstances.Items["+ i +"].DBInstanceMemory");
				dBInstance.DBInstanceNetType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceNetType");
				dBInstance.DBInstanceType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceType");
				dBInstance.LockReason = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].LockReason");
				dBInstance.DBInstanceStatus = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceStatus");
				dBInstance.RegionId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].RegionId");
				dBInstance.VSwitchId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].VSwitchId");
				dBInstance.DedicatedHostIdForSlave = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostIdForSlave");
				dBInstance.ResourceGroupId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ResourceGroupId");
				dBInstance.Category = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].Category");
				dBInstance.Engine = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].Engine");
				dBInstance.DBInstanceClass = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceClass");
				dBInstance.SwitchWeight = _ctx.IntegerValue("DescribeDBInstances.Items["+ i +"].SwitchWeight");
				dBInstance.DeletionProtection = _ctx.BooleanValue("DescribeDBInstances.Items["+ i +"].DeletionProtection");
				dBInstance.BurstingEnabled = _ctx.BooleanValue("DescribeDBInstances.Items["+ i +"].BurstingEnabled");
				dBInstance.BpeEnabled = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].BpeEnabled");
				dBInstance.IoAccelerationEnabled = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].IoAccelerationEnabled");
				dBInstance.ColdDataEnabled = _ctx.BooleanValue("DescribeDBInstances.Items["+ i +"].ColdDataEnabled");

				List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ReadOnlyDBInstanceId> dBInstance_readOnlyDBInstanceIds = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ReadOnlyDBInstanceId>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstances.Items["+ i +"].ReadOnlyDBInstanceIds.Length"); j++) {
					DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ReadOnlyDBInstanceId readOnlyDBInstanceId = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ReadOnlyDBInstanceId();
					readOnlyDBInstanceId.DBInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ReadOnlyDBInstanceIds["+ j +"].DBInstanceId");

					dBInstance_readOnlyDBInstanceIds.Add(readOnlyDBInstanceId);
				}
				dBInstance.ReadOnlyDBInstanceIds = dBInstance_readOnlyDBInstanceIds;

				describeDBInstancesResponse_items.Add(dBInstance);
			}
			describeDBInstancesResponse.Items = describeDBInstancesResponse_items;
        
			return describeDBInstancesResponse;
        }
    }
}
