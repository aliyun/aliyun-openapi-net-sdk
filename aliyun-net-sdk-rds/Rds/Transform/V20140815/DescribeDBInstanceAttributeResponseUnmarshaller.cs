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
    public class DescribeDBInstanceAttributeResponseUnmarshaller
    {
        public static DescribeDBInstanceAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceAttributeResponse describeDBInstanceAttributeResponse = new DescribeDBInstanceAttributeResponse();

			describeDBInstanceAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceAttributeResponse.RequestId = _ctx.StringValue("DescribeDBInstanceAttribute.RequestId");

			List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute> describeDBInstanceAttributeResponse_items = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceAttribute.Items.Length"); i++) {
				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute dBInstanceAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute();
				dBInstanceAttribute.IPType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].IPType");
				dBInstanceAttribute.DBInstanceDiskUsed = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceDiskUsed");
				dBInstanceAttribute.GuardDBInstanceName = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].GuardDBInstanceName");
				dBInstanceAttribute.CanTempUpgrade = _ctx.BooleanValue("DescribeDBInstanceAttribute.Items["+ i +"].CanTempUpgrade");
				dBInstanceAttribute.TempUpgradeTimeStart = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeTimeStart");
				dBInstanceAttribute.TempUpgradeTimeEnd = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeTimeEnd");
				dBInstanceAttribute.TempUpgradeRecoveryTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryTime");
				dBInstanceAttribute.TempUpgradeRecoveryClass = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryClass");
				dBInstanceAttribute.TempUpgradeRecoveryCpu = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryCpu");
				dBInstanceAttribute.TempUpgradeRecoveryMemory = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryMemory");
				dBInstanceAttribute.TempUpgradeRecoveryMaxIOPS = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryMaxIOPS");
				dBInstanceAttribute.TempUpgradeRecoveryMaxConnections = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryMaxConnections");
				dBInstanceAttribute.InsId = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].InsId");
				dBInstanceAttribute.DBInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceId");
				dBInstanceAttribute.PayType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].PayType");
				dBInstanceAttribute.DBInstanceClassType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceClassType");
				dBInstanceAttribute.DBInstanceType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceType");
				dBInstanceAttribute.RegionId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].RegionId");
				dBInstanceAttribute.ConnectionString = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConnectionString");
				dBInstanceAttribute.Port = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Port");
				dBInstanceAttribute.Engine = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Engine");
				dBInstanceAttribute.EngineVersion = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].EngineVersion");
				dBInstanceAttribute.DBInstanceClass = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceClass");
				dBInstanceAttribute.DBInstanceMemory = _ctx.LongValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceMemory");
				dBInstanceAttribute.DBInstanceStorage = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStorage");
				dBInstanceAttribute.VpcCloudInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VpcCloudInstanceId");
				dBInstanceAttribute.DBInstanceNetType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceNetType");
				dBInstanceAttribute.DBInstanceStatus = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStatus");
				dBInstanceAttribute.DBInstanceDescription = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceDescription");
				dBInstanceAttribute.LockMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LockMode");
				dBInstanceAttribute.LockReason = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LockReason");
				dBInstanceAttribute.ReadDelayTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReadDelayTime");
				dBInstanceAttribute.DBMaxQuantity = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].DBMaxQuantity");
				dBInstanceAttribute.AccountMaxQuantity = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].AccountMaxQuantity");
				dBInstanceAttribute.CreationTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].CreationTime");
				dBInstanceAttribute.ExpireTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ExpireTime");
				dBInstanceAttribute.MaintainTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MaintainTime");
				dBInstanceAttribute.AvailabilityValue = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AvailabilityValue");
				dBInstanceAttribute.MaxIOPS = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MaxIOPS");
				dBInstanceAttribute.MaxConnections = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MaxConnections");
				dBInstanceAttribute.MasterInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MasterInstanceId");
				dBInstanceAttribute.DBInstanceCPU = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceCPU");
				dBInstanceAttribute.IncrementSourceDBInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].IncrementSourceDBInstanceId");
				dBInstanceAttribute.GuardDBInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].GuardDBInstanceId");
				dBInstanceAttribute.ReplicateId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReplicateId");
				dBInstanceAttribute.TempDBInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempDBInstanceId");
				dBInstanceAttribute.SecurityIPList = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SecurityIPList");
				dBInstanceAttribute.ZoneId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ZoneId");
				dBInstanceAttribute.InstanceNetworkType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].InstanceNetworkType");
				dBInstanceAttribute.DBInstanceStorageType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStorageType");
				dBInstanceAttribute.AdvancedFeatures = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AdvancedFeatures");
				dBInstanceAttribute.Category = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Category");
				dBInstanceAttribute.AccountType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AccountType");
				dBInstanceAttribute.SupportUpgradeAccountType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SupportUpgradeAccountType");
				dBInstanceAttribute.SupportCreateSuperAccount = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SupportCreateSuperAccount");
				dBInstanceAttribute.VpcId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VpcId");
				dBInstanceAttribute.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VSwitchId");
				dBInstanceAttribute.ConnectionMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConnectionMode");
				dBInstanceAttribute.CurrentKernelVersion = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].CurrentKernelVersion");
				dBInstanceAttribute.LatestKernelVersion = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LatestKernelVersion");
				dBInstanceAttribute.ResourceGroupId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ResourceGroupId");
				dBInstanceAttribute.ReadonlyInstanceSQLDelayedTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReadonlyInstanceSQLDelayedTime");
				dBInstanceAttribute.SecurityIPMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SecurityIPMode");
				dBInstanceAttribute.TimeZone = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TimeZone");
				dBInstanceAttribute.Collation = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Collation");
				dBInstanceAttribute.DispenseMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DispenseMode");
				dBInstanceAttribute.MasterZone = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MasterZone");
				dBInstanceAttribute.AutoUpgradeMinorVersion = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AutoUpgradeMinorVersion");
				dBInstanceAttribute.ProxyType = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].ProxyType");
				dBInstanceAttribute.ConsoleVersion = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConsoleVersion");
				dBInstanceAttribute.MultipleTempUpgrade = _ctx.BooleanValue("DescribeDBInstanceAttribute.Items["+ i +"].MultipleTempUpgrade");
				dBInstanceAttribute.OriginConfiguration = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].OriginConfiguration");
				dBInstanceAttribute.DedicatedHostGroupId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DedicatedHostGroupId");
				dBInstanceAttribute.SuperPermissionMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SuperPermissionMode");

				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Extra extra = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Extra();
				extra.ReplicaGroupID = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Extra.ReplicaGroupID");
				extra.ReplicaGroupStatus = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Extra.ReplicaGroupStatus");
				extra.ActiveReplicaDBInstanceID = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Extra.ActiveReplicaDBInstanceID");

				List<string> extra_dBInstanceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.Items["+ i +"].Extra.DBInstanceIds.Length"); j++) {
					extra_dBInstanceIds.Add(_ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Extra.DBInstanceIds["+ j +"]"));
				}
				extra.DBInstanceIds = extra_dBInstanceIds;
				dBInstanceAttribute.Extra = extra;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_SlaveZone> dBInstanceAttribute_slaveZones = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_SlaveZone>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.Items["+ i +"].SlaveZones.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_SlaveZone slaveZone = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_SlaveZone();
					slaveZone.ZoneId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SlaveZones["+ j +"].ZoneId");

					dBInstanceAttribute_slaveZones.Add(slaveZone);
				}
				dBInstanceAttribute.SlaveZones = dBInstanceAttribute_slaveZones;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_ReadOnlyDBInstanceId> dBInstanceAttribute_readOnlyDBInstanceIds = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_ReadOnlyDBInstanceId>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.Items["+ i +"].ReadOnlyDBInstanceIds.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_ReadOnlyDBInstanceId readOnlyDBInstanceId = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_ReadOnlyDBInstanceId();
					readOnlyDBInstanceId.DBInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReadOnlyDBInstanceIds["+ j +"].DBInstanceId");

					dBInstanceAttribute_readOnlyDBInstanceIds.Add(readOnlyDBInstanceId);
				}
				dBInstanceAttribute.ReadOnlyDBInstanceIds = dBInstanceAttribute_readOnlyDBInstanceIds;

				describeDBInstanceAttributeResponse_items.Add(dBInstanceAttribute);
			}
			describeDBInstanceAttributeResponse.Items = describeDBInstanceAttributeResponse_items;
        
			return describeDBInstanceAttributeResponse;
        }
    }
}
