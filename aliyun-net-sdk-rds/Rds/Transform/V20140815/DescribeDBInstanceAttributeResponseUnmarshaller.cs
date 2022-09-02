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
				dBInstanceAttribute.VpcId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VpcId");
				dBInstanceAttribute.CreationTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].CreationTime");
				dBInstanceAttribute.IncrementSourceDBInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].IncrementSourceDBInstanceId");
				dBInstanceAttribute.MaintainTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MaintainTime");
				dBInstanceAttribute.PayType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].PayType");
				dBInstanceAttribute.AvailabilityValue = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AvailabilityValue");
				dBInstanceAttribute.AccountType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AccountType");
				dBInstanceAttribute.EngineVersion = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].EngineVersion");
				dBInstanceAttribute.DedicatedHostGroupId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DedicatedHostGroupId");
				dBInstanceAttribute.InsId = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].InsId");
				dBInstanceAttribute.ConnectionString = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConnectionString");
				dBInstanceAttribute.SuperPermissionMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SuperPermissionMode");
				dBInstanceAttribute.InstanceNetworkType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].InstanceNetworkType");
				dBInstanceAttribute.MasterInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MasterInstanceId");
				dBInstanceAttribute.TempUpgradeRecoveryMaxConnections = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryMaxConnections");
				dBInstanceAttribute.AutoUpgradeMinorVersion = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AutoUpgradeMinorVersion");
				dBInstanceAttribute.MultipleTempUpgrade = _ctx.BooleanValue("DescribeDBInstanceAttribute.Items["+ i +"].MultipleTempUpgrade");
				dBInstanceAttribute.ExpireTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ExpireTime");
				dBInstanceAttribute.AccountMaxQuantity = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].AccountMaxQuantity");
				dBInstanceAttribute.SupportCreateSuperAccount = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SupportCreateSuperAccount");
				dBInstanceAttribute.MasterZone = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MasterZone");
				dBInstanceAttribute.GuardDBInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].GuardDBInstanceId");
				dBInstanceAttribute.DBInstanceStorage = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStorage");
				dBInstanceAttribute.TimeZone = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TimeZone");
				dBInstanceAttribute.CanTempUpgrade = _ctx.BooleanValue("DescribeDBInstanceAttribute.Items["+ i +"].CanTempUpgrade");
				dBInstanceAttribute.LatestKernelVersion = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LatestKernelVersion");
				dBInstanceAttribute.TipsLevel = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].TipsLevel");
				dBInstanceAttribute.ZoneId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ZoneId");
				dBInstanceAttribute.MaxConnections = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MaxConnections");
				dBInstanceAttribute.DBInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceId");
				dBInstanceAttribute.TempUpgradeRecoveryTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryTime");
				dBInstanceAttribute.DispenseMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DispenseMode");
				dBInstanceAttribute.TempUpgradeRecoveryMemory = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryMemory");
				dBInstanceAttribute.ReplicateId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReplicateId");
				dBInstanceAttribute.TempDBInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempDBInstanceId");
				dBInstanceAttribute.SupportUpgradeAccountType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SupportUpgradeAccountType");
				dBInstanceAttribute.AdvancedFeatures = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AdvancedFeatures");
				dBInstanceAttribute.DBInstanceStorageType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStorageType");
				dBInstanceAttribute.DBInstanceMemory = _ctx.LongValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceMemory");
				dBInstanceAttribute.IPType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].IPType");
				dBInstanceAttribute.ReadDelayTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReadDelayTime");
				dBInstanceAttribute.ConsoleVersion = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConsoleVersion");
				dBInstanceAttribute.ConnectionMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConnectionMode");
				dBInstanceAttribute.Port = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Port");
				dBInstanceAttribute.LockMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LockMode");
				dBInstanceAttribute.GeneralGroupName = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].GeneralGroupName");
				dBInstanceAttribute.OriginConfiguration = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].OriginConfiguration");
				dBInstanceAttribute.VpcCloudInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VpcCloudInstanceId");
				dBInstanceAttribute.Collation = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Collation");
				dBInstanceAttribute.MaxIOPS = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MaxIOPS");
				dBInstanceAttribute.MaxIOMBPS = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MaxIOMBPS");
				dBInstanceAttribute.Tips = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Tips");
				dBInstanceAttribute.SecurityIPList = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SecurityIPList");
				dBInstanceAttribute.SecurityIPMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SecurityIPMode");
				dBInstanceAttribute.DBInstanceClassType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceClassType");
				dBInstanceAttribute.GuardDBInstanceName = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].GuardDBInstanceName");
				dBInstanceAttribute.DBInstanceDiskUsed = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceDiskUsed");
				dBInstanceAttribute.ProxyType = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].ProxyType");
				dBInstanceAttribute.CurrentKernelVersion = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].CurrentKernelVersion");
				dBInstanceAttribute.DBInstanceDescription = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceDescription");
				dBInstanceAttribute.TempUpgradeRecoveryClass = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryClass");
				dBInstanceAttribute.TempUpgradeTimeStart = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeTimeStart");
				dBInstanceAttribute.DBInstanceCPU = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceCPU");
				dBInstanceAttribute.DBInstanceNetType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceNetType");
				dBInstanceAttribute.DBInstanceType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceType");
				dBInstanceAttribute.TempUpgradeRecoveryMaxIOPS = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryMaxIOPS");
				dBInstanceAttribute.LockReason = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LockReason");
				dBInstanceAttribute.DBInstanceStatus = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStatus");
				dBInstanceAttribute.DBMaxQuantity = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].DBMaxQuantity");
				dBInstanceAttribute.RegionId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].RegionId");
				dBInstanceAttribute.ReadonlyInstanceSQLDelayedTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReadonlyInstanceSQLDelayedTime");
				dBInstanceAttribute.TempUpgradeTimeEnd = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeTimeEnd");
				dBInstanceAttribute.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VSwitchId");
				dBInstanceAttribute.ResourceGroupId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ResourceGroupId");
				dBInstanceAttribute.Category = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Category");
				dBInstanceAttribute.TempUpgradeRecoveryCpu = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryCpu");
				dBInstanceAttribute.DBInstanceClass = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceClass");
				dBInstanceAttribute.Engine = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Engine");
				dBInstanceAttribute.DeletionProtection = _ctx.BooleanValue("DescribeDBInstanceAttribute.Items["+ i +"].DeletionProtection");
				dBInstanceAttribute.KindCode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].kindCode");

				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Extra extra = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Extra();
				extra.ReplicaGroupStatus = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Extra.ReplicaGroupStatus");
				extra.ActiveReplicaDBInstanceID = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Extra.ActiveReplicaDBInstanceID");
				extra.ReplicaGroupID = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Extra.ReplicaGroupID");

				List<string> extra_dBInstanceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.Items["+ i +"].Extra.DBInstanceIds.Length"); j++) {
					extra_dBInstanceIds.Add(_ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Extra.DBInstanceIds["+ j +"]"));
				}
				extra.DBInstanceIds = extra_dBInstanceIds;
				dBInstanceAttribute.Extra = extra;

				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_ServerlessConfig serverlessConfig = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_ServerlessConfig();
				serverlessConfig.ScaleMin = _ctx.DoubleValue("DescribeDBInstanceAttribute.Items["+ i +"].ServerlessConfig.ScaleMin");
				serverlessConfig.ScaleMax = _ctx.DoubleValue("DescribeDBInstanceAttribute.Items["+ i +"].ServerlessConfig.ScaleMax");
				serverlessConfig.AutoPause = _ctx.BooleanValue("DescribeDBInstanceAttribute.Items["+ i +"].ServerlessConfig.AutoPause");
				serverlessConfig.SwitchForce = _ctx.BooleanValue("DescribeDBInstanceAttribute.Items["+ i +"].ServerlessConfig.SwitchForce");
				dBInstanceAttribute.ServerlessConfig = serverlessConfig;

				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_BabelfishConfig babelfishConfig = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_BabelfishConfig();
				babelfishConfig.BabelfishEnabled = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].BabelfishConfig.BabelfishEnabled");
				babelfishConfig.MigrationMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].BabelfishConfig.MigrationMode");
				dBInstanceAttribute.BabelfishConfig = babelfishConfig;

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
