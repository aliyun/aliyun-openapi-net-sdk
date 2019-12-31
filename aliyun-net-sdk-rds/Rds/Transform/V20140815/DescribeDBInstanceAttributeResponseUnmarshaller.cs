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
        public static DescribeDBInstanceAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstanceAttributeResponse describeDBInstanceAttributeResponse = new DescribeDBInstanceAttributeResponse();

			describeDBInstanceAttributeResponse.HttpResponse = context.HttpResponse;
			describeDBInstanceAttributeResponse.RequestId = context.StringValue("DescribeDBInstanceAttribute.RequestId");

			List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute> describeDBInstanceAttributeResponse_items = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute>();
			for (int i = 0; i < context.Length("DescribeDBInstanceAttribute.Items.Length"); i++) {
				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute dBInstanceAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute();
				dBInstanceAttribute.IPType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].IPType");
				dBInstanceAttribute.DBInstanceDiskUsed = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceDiskUsed");
				dBInstanceAttribute.GuardDBInstanceName = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].GuardDBInstanceName");
				dBInstanceAttribute.CanTempUpgrade = context.BooleanValue("DescribeDBInstanceAttribute.Items["+ i +"].CanTempUpgrade");
				dBInstanceAttribute.TempUpgradeTimeStart = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeTimeStart");
				dBInstanceAttribute.TempUpgradeTimeEnd = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeTimeEnd");
				dBInstanceAttribute.TempUpgradeRecoveryTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryTime");
				dBInstanceAttribute.TempUpgradeRecoveryClass = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryClass");
				dBInstanceAttribute.TempUpgradeRecoveryCpu = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryCpu");
				dBInstanceAttribute.TempUpgradeRecoveryMemory = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryMemory");
				dBInstanceAttribute.TempUpgradeRecoveryMaxIOPS = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryMaxIOPS");
				dBInstanceAttribute.TempUpgradeRecoveryMaxConnections = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempUpgradeRecoveryMaxConnections");
				dBInstanceAttribute.InsId = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].InsId");
				dBInstanceAttribute.DBInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceId");
				dBInstanceAttribute.PayType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].PayType");
				dBInstanceAttribute.DBInstanceClassType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceClassType");
				dBInstanceAttribute.DBInstanceType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceType");
				dBInstanceAttribute.RegionId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].RegionId");
				dBInstanceAttribute.ConnectionString = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConnectionString");
				dBInstanceAttribute.Port = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Port");
				dBInstanceAttribute.Engine = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Engine");
				dBInstanceAttribute.EngineVersion = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].EngineVersion");
				dBInstanceAttribute.DBInstanceClass = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceClass");
				dBInstanceAttribute.DBInstanceMemory = context.LongValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceMemory");
				dBInstanceAttribute.DBInstanceStorage = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStorage");
				dBInstanceAttribute.VpcCloudInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VpcCloudInstanceId");
				dBInstanceAttribute.DBInstanceNetType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceNetType");
				dBInstanceAttribute.DBInstanceStatus = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStatus");
				dBInstanceAttribute.DBInstanceDescription = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceDescription");
				dBInstanceAttribute.LockMode = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LockMode");
				dBInstanceAttribute.LockReason = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LockReason");
				dBInstanceAttribute.ReadDelayTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReadDelayTime");
				dBInstanceAttribute.DBMaxQuantity = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].DBMaxQuantity");
				dBInstanceAttribute.AccountMaxQuantity = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].AccountMaxQuantity");
				dBInstanceAttribute.CreationTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].CreationTime");
				dBInstanceAttribute.ExpireTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ExpireTime");
				dBInstanceAttribute.MaintainTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MaintainTime");
				dBInstanceAttribute.AvailabilityValue = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AvailabilityValue");
				dBInstanceAttribute.MaxIOPS = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MaxIOPS");
				dBInstanceAttribute.MaxConnections = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MaxConnections");
				dBInstanceAttribute.MasterInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MasterInstanceId");
				dBInstanceAttribute.DBInstanceCPU = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceCPU");
				dBInstanceAttribute.IncrementSourceDBInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].IncrementSourceDBInstanceId");
				dBInstanceAttribute.GuardDBInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].GuardDBInstanceId");
				dBInstanceAttribute.ReplicateId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReplicateId");
				dBInstanceAttribute.TempDBInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempDBInstanceId");
				dBInstanceAttribute.SecurityIPList = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SecurityIPList");
				dBInstanceAttribute.ZoneId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ZoneId");
				dBInstanceAttribute.InstanceNetworkType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].InstanceNetworkType");
				dBInstanceAttribute.DBInstanceStorageType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStorageType");
				dBInstanceAttribute.AdvancedFeatures = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AdvancedFeatures");
				dBInstanceAttribute.Category = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Category");
				dBInstanceAttribute.AccountType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AccountType");
				dBInstanceAttribute.SupportUpgradeAccountType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SupportUpgradeAccountType");
				dBInstanceAttribute.SupportCreateSuperAccount = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SupportCreateSuperAccount");
				dBInstanceAttribute.VpcId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VpcId");
				dBInstanceAttribute.VSwitchId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VSwitchId");
				dBInstanceAttribute.ConnectionMode = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConnectionMode");
				dBInstanceAttribute.CurrentKernelVersion = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].CurrentKernelVersion");
				dBInstanceAttribute.LatestKernelVersion = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LatestKernelVersion");
				dBInstanceAttribute.ResourceGroupId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ResourceGroupId");
				dBInstanceAttribute.ReadonlyInstanceSQLDelayedTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReadonlyInstanceSQLDelayedTime");
				dBInstanceAttribute.SecurityIPMode = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SecurityIPMode");
				dBInstanceAttribute.TimeZone = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TimeZone");
				dBInstanceAttribute.Collation = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Collation");
				dBInstanceAttribute.DispenseMode = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DispenseMode");
				dBInstanceAttribute.MasterZone = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MasterZone");
				dBInstanceAttribute.AutoUpgradeMinorVersion = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AutoUpgradeMinorVersion");
				dBInstanceAttribute.ProxyType = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].ProxyType");
				dBInstanceAttribute.ConsoleVersion = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConsoleVersion");
				dBInstanceAttribute.MultipleTempUpgrade = context.BooleanValue("DescribeDBInstanceAttribute.Items["+ i +"].MultipleTempUpgrade");
				dBInstanceAttribute.OriginConfiguration = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].OriginConfiguration");
				dBInstanceAttribute.DedicatedHostGroupId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DedicatedHostGroupId");

				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Extra extra = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Extra();
				extra.ReplicaGroupID = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Extra.ReplicaGroupID");
				extra.ReplicaGroupStatus = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Extra.ReplicaGroupStatus");
				extra.ActiveReplicaDBInstanceID = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Extra.ActiveReplicaDBInstanceID");

				List<string> extra_dBInstanceId = new List<string>();
				for (int j = 0; j < context.Length("DescribeDBInstanceAttribute.Items["+ i +"].Extra.DBInstanceId.Length"); j++) {
					extra_dBInstanceId.Add(context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Extra.DBInstanceId["+ j +"]"));
				}
				extra.DBInstanceId = extra_dBInstanceId;
				dBInstanceAttribute.Extra = extra;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_SlaveZone> dBInstanceAttribute_slaveZones = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_SlaveZone>();
				for (int j = 0; j < context.Length("DescribeDBInstanceAttribute.Items["+ i +"].SlaveZones.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_SlaveZone slaveZone = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_SlaveZone();
					slaveZone.ZoneId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SlaveZones["+ j +"].ZoneId");

					dBInstanceAttribute_slaveZones.Add(slaveZone);
				}
				dBInstanceAttribute.SlaveZones = dBInstanceAttribute_slaveZones;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_ReadOnlyDBInstanceId> dBInstanceAttribute_readOnlyDBInstanceIds = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_ReadOnlyDBInstanceId>();
				for (int j = 0; j < context.Length("DescribeDBInstanceAttribute.Items["+ i +"].ReadOnlyDBInstanceIds.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_ReadOnlyDBInstanceId readOnlyDBInstanceId = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_ReadOnlyDBInstanceId();
					readOnlyDBInstanceId.DBInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReadOnlyDBInstanceIds["+ j +"].DBInstanceId");

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
