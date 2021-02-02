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
				dBInstance.VPCCloudInstanceIds = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].VPCCloudInstanceIds");
				dBInstance.ResourceGroupId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ResourceGroupId");
				dBInstance.DBInstanceType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceType");
				dBInstance.ReplicaSetName = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSetName");
				dBInstance.StorageEngine = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].StorageEngine");
				dBInstance.MaintainEndTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaintainEndTime");
				dBInstance.DBInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceId");
				dBInstance.NetworkType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkType");
				dBInstance.DBInstanceStorage = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceStorage");
				dBInstance.LastDowngradeTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].LastDowngradeTime");
				dBInstance.Engine = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].Engine");
				dBInstance.MaintainStartTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaintainStartTime");
				dBInstance.DBInstanceDescription = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceDescription");
				dBInstance.ReplacateId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplacateId");
				dBInstance.DBInstanceReleaseProtection = _ctx.BooleanValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceReleaseProtection");
				dBInstance.EngineVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].EngineVersion");
				dBInstance.ReplicationFactor = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicationFactor");
				dBInstance.ReadonlyReplicas = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReadonlyReplicas");
				dBInstance.MaxConnections = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaxConnections");
				dBInstance.ZoneId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ZoneId");
				dBInstance.DBInstanceStatus = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceStatus");
				dBInstance.DBInstanceClass = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceClass");
				dBInstance.VPCId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].VPCId");
				dBInstance.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].VSwitchId");
				dBInstance.LockMode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].LockMode");
				dBInstance.MaxIOPS = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaxIOPS");
				dBInstance.CurrentKernelVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].CurrentKernelVersion");
				dBInstance.ProtocolType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ProtocolType");
				dBInstance.VpcAuthMode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].VpcAuthMode");
				dBInstance.ChargeType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ChargeType");
				dBInstance.CreationTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].CreationTime");
				dBInstance.RegionId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].RegionId");
				dBInstance.ExpireTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ExpireTime");
				dBInstance.KindCode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].KindCode");

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute> dBInstance_mongosList = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute mongosAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute();
					mongosAttribute.ConnectSting = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].ConnectSting");
					mongosAttribute.NodeClass = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].NodeClass");
					mongosAttribute.NodeDescription = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].NodeDescription");
					mongosAttribute.MaxConnections = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].MaxConnections");
					mongosAttribute.VPCId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].VPCId");
					mongosAttribute.Port = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].Port");
					mongosAttribute.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].VSwitchId");
					mongosAttribute.NodeId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].NodeId");
					mongosAttribute.VpcCloudInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].VpcCloudInstanceId");
					mongosAttribute.MaxIOPS = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].MaxIOPS");

					dBInstance_mongosList.Add(mongosAttribute);
				}
				dBInstance.MongosList = dBInstance_mongosList;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ShardAttribute> dBInstance_shardList = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ShardAttribute>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ShardAttribute shardAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ShardAttribute();
					shardAttribute.NodeClass = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].NodeClass");
					shardAttribute.NodeDescription = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].NodeDescription");
					shardAttribute.ReadonlyReplicas = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].ReadonlyReplicas");
					shardAttribute.MaxConnections = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].MaxConnections");
					shardAttribute.Port = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].Port");
					shardAttribute.NodeStorage = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].NodeStorage");
					shardAttribute.NodeId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].NodeId");
					shardAttribute.ConnectString = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].ConnectString");
					shardAttribute.MaxIOPS = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].MaxIOPS");

					dBInstance_shardList.Add(shardAttribute);
				}
				dBInstance.ShardList = dBInstance_shardList;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConfigserverAttribute> dBInstance_configserverList = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConfigserverAttribute>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConfigserverAttribute configserverAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConfigserverAttribute();
					configserverAttribute.NodeClass = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].NodeClass");
					configserverAttribute.NodeDescription = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].NodeDescription");
					configserverAttribute.MaxConnections = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].MaxConnections");
					configserverAttribute.Port = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].Port");
					configserverAttribute.NodeStorage = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].NodeStorage");
					configserverAttribute.NodeId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].NodeId");
					configserverAttribute.ConnectString = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].ConnectString");
					configserverAttribute.MaxIOPS = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].MaxIOPS");

					dBInstance_configserverList.Add(configserverAttribute);
				}
				dBInstance.ConfigserverList = dBInstance_configserverList;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_Tag> dBInstance_tags = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].Tags.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_Tag tag = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_Tag();
					tag._Value = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].Tags["+ j +"].Value");
					tag.Key = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].Tags["+ j +"].Key");

					dBInstance_tags.Add(tag);
				}
				dBInstance.Tags = dBInstance_tags;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ReplicaSet> dBInstance_replicaSets = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ReplicaSet>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ReplicaSet replicaSet = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ReplicaSet();
					replicaSet.ConnectionDomain = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].ConnectionDomain");
					replicaSet.ReplicaSetRole = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].ReplicaSetRole");
					replicaSet.VPCCloudInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].VPCCloudInstanceId");
					replicaSet.VPCId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].VPCId");
					replicaSet.ConnectionPort = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].ConnectionPort");
					replicaSet.NetworkType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].NetworkType");
					replicaSet.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].VSwitchId");

					dBInstance_replicaSets.Add(replicaSet);
				}
				dBInstance.ReplicaSets = dBInstance_replicaSets;

				describeDBInstanceAttributeResponse_dBInstances.Add(dBInstance);
			}
			describeDBInstanceAttributeResponse.DBInstances = describeDBInstanceAttributeResponse_dBInstances;
        
			return describeDBInstanceAttributeResponse;
        }
    }
}
