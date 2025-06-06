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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeDBInstanceAttributeResponseUnmarshaller
    {
        public static DescribeDBInstanceAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceAttributeResponse describeDBInstanceAttributeResponse = new DescribeDBInstanceAttributeResponse();

			describeDBInstanceAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceAttributeResponse.RequestId = _ctx.StringValue("DescribeDBInstanceAttribute.RequestId");

			List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance> describeDBInstanceAttributeResponse_dBInstances = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceAttribute.DBInstances.Length"); i++) {
				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance dBInstance = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance();
				dBInstance.CreationTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].CreationTime");
				dBInstance.ReplacateId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplacateId");
				dBInstance.VpcAuthMode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].VpcAuthMode");
				dBInstance.NetworkType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkType");
				dBInstance.LockMode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].LockMode");
				dBInstance.EngineVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].EngineVersion");
				dBInstance.MaxIOPS = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaxIOPS");
				dBInstance.MaxMBPS = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaxMBPS");
				dBInstance.VPCCloudInstanceIds = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].VPCCloudInstanceIds");
				dBInstance.ProtocolType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ProtocolType");
				dBInstance.DBInstanceDescription = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceDescription");
				dBInstance.CurrentKernelVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].CurrentKernelVersion");
				dBInstance.DBInstanceReleaseProtection = _ctx.BooleanValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceReleaseProtection");
				dBInstance.ExpireTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ExpireTime");
				dBInstance.MaintainStartTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaintainStartTime");
				dBInstance.DBInstanceType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceType");
				dBInstance.LastDowngradeTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].LastDowngradeTime");
				dBInstance.MaintainEndTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaintainEndTime");
				dBInstance.DBInstanceStatus = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceStatus");
				dBInstance.VPCId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].VPCId");
				dBInstance.RegionId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].RegionId");
				dBInstance.DBInstanceStorage = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceStorage");
				dBInstance.ReplicaSetName = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSetName");
				dBInstance.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].VSwitchId");
				dBInstance.StorageEngine = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].StorageEngine");
				dBInstance.ResourceGroupId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ResourceGroupId");
				dBInstance.ZoneId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ZoneId");
				dBInstance.MaxConnections = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaxConnections");
				dBInstance.DBInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceId");
				dBInstance.DBInstanceClass = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceClass");
				dBInstance.Engine = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].Engine");
				dBInstance.ReadonlyReplicas = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReadonlyReplicas");
				dBInstance.ReplicationFactor = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicationFactor");
				dBInstance.KindCode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].KindCode");
				dBInstance.CapacityUnit = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].CapacityUnit");
				dBInstance.CloudType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].CloudType");
				dBInstance.ChargeType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ChargeType");
				dBInstance.StorageType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].StorageType");
				dBInstance.SecondaryZoneId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].SecondaryZoneId");
				dBInstance.HiddenZoneId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].HiddenZoneId");
				dBInstance.DestroyTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DestroyTime");
				dBInstance.PaymentType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].PaymentType");
				dBInstance.DBInstanceOrderStatus = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceOrderStatus");
				dBInstance.Encrypted = _ctx.BooleanValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].Encrypted");
				dBInstance.EncryptionKey = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].EncryptionKey");
				dBInstance.SyncPercent = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].SyncPercent");
				dBInstance.UseClusterBackup = _ctx.BooleanValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].UseClusterBackup");
				dBInstance.BurstingEnabled = _ctx.BooleanValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].BurstingEnabled");
				dBInstance.ProvisionedIops = _ctx.LongValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ProvisionedIops");

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ReplicaSet> dBInstance_replicaSets = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ReplicaSet>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ReplicaSet replicaSet = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ReplicaSet();
					replicaSet.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].VSwitchId");
					replicaSet.ConnectionPort = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].ConnectionPort");
					replicaSet.ReplicaSetRole = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].ReplicaSetRole");
					replicaSet.ConnectionDomain = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].ConnectionDomain");
					replicaSet.VPCCloudInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].VPCCloudInstanceId");
					replicaSet.NetworkType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].NetworkType");
					replicaSet.VPCId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].VPCId");

					dBInstance_replicaSets.Add(replicaSet);
				}
				dBInstance.ReplicaSets = dBInstance_replicaSets;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_Tag> dBInstance_tags = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].Tags.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_Tag tag = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_Tag();
					tag.Key = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].Tags["+ j +"].Value");

					dBInstance_tags.Add(tag);
				}
				dBInstance.Tags = dBInstance_tags;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute> dBInstance_mongosList = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute mongosAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute();
					mongosAttribute.VpcCloudInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].VpcCloudInstanceId");
					mongosAttribute.LockMode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].LockMode");
					mongosAttribute.MaxIOPS = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].MaxIOPS");
					mongosAttribute.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].VSwitchId");
					mongosAttribute.NodeClass = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].NodeClass");
					mongosAttribute.MaxConnections = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].MaxConnections");
					mongosAttribute.Port = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].Port");
					mongosAttribute.VPCId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].VPCId");
					mongosAttribute.ConnectSting = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].ConnectSting");
					mongosAttribute.NodeDescription = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].NodeDescription");
					mongosAttribute.NodeId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].NodeId");
					mongosAttribute.Status = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].Status");
					mongosAttribute.CurrentKernelVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].CurrentKernelVersion");
					mongosAttribute.ConnectString = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].ConnectString");

					dBInstance_mongosList.Add(mongosAttribute);
				}
				dBInstance.MongosList = dBInstance_mongosList;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ShardAttribute> dBInstance_shardList = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ShardAttribute>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ShardAttribute shardAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ShardAttribute();
					shardAttribute.LockMode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].LockMode");
					shardAttribute.MaxIOPS = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].MaxIOPS");
					shardAttribute.ConnectString = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].ConnectString");
					shardAttribute.NodeClass = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].NodeClass");
					shardAttribute.MaxConnections = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].MaxConnections");
					shardAttribute.Port = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].Port");
					shardAttribute.NodeDescription = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].NodeDescription");
					shardAttribute.NodeId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].NodeId");
					shardAttribute.NodeStorage = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].NodeStorage");
					shardAttribute.ReadonlyReplicas = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].ReadonlyReplicas");
					shardAttribute.Status = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].Status");
					shardAttribute.MaxDiskMbps = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].MaxDiskMbps");
					shardAttribute.CurrentKernelVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].CurrentKernelVersion");

					dBInstance_shardList.Add(shardAttribute);
				}
				dBInstance.ShardList = dBInstance_shardList;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConfigserverAttribute> dBInstance_configserverList = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConfigserverAttribute>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConfigserverAttribute configserverAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConfigserverAttribute();
					configserverAttribute.MaxIOPS = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].MaxIOPS");
					configserverAttribute.LockMode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].LockMode");
					configserverAttribute.ConnectString = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].ConnectString");
					configserverAttribute.NodeClass = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].NodeClass");
					configserverAttribute.MaxConnections = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].MaxConnections");
					configserverAttribute.Port = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].Port");
					configserverAttribute.NodeDescription = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].NodeDescription");
					configserverAttribute.NodeId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].NodeId");
					configserverAttribute.NodeStorage = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].NodeStorage");
					configserverAttribute.Status = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].Status");
					configserverAttribute.CurrentKernelVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].CurrentKernelVersion");

					dBInstance_configserverList.Add(configserverAttribute);
				}
				dBInstance.ConfigserverList = dBInstance_configserverList;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_NetworkAddress> dBInstance_networkAddresses = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_NetworkAddress>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkAddresses.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_NetworkAddress networkAddress = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_NetworkAddress();
					networkAddress.NodeType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkAddresses["+ j +"].NodeType");
					networkAddress.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkAddresses["+ j +"].VSwitchId");
					networkAddress.ExpiredTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkAddresses["+ j +"].ExpiredTime");
					networkAddress.NetworkType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkAddresses["+ j +"].NetworkType");
					networkAddress.Role = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkAddresses["+ j +"].Role");
					networkAddress.Port = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkAddresses["+ j +"].Port");
					networkAddress.VPCId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkAddresses["+ j +"].VPCId");
					networkAddress.NetworkAddress = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkAddresses["+ j +"].NetworkAddress");
					networkAddress.NodeId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkAddresses["+ j +"].NodeId");
					networkAddress.IPAddress = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkAddresses["+ j +"].IPAddress");

					dBInstance_networkAddresses.Add(networkAddress);
				}
				dBInstance.NetworkAddresses = dBInstance_networkAddresses;

				describeDBInstanceAttributeResponse_dBInstances.Add(dBInstance);
			}
			describeDBInstanceAttributeResponse.DBInstances = describeDBInstanceAttributeResponse_dBInstances;
        
			return describeDBInstanceAttributeResponse;
        }
    }
}
