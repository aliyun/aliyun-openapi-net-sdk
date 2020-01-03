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
        public static DescribeDBInstanceAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstanceAttributeResponse describeDBInstanceAttributeResponse = new DescribeDBInstanceAttributeResponse();

			describeDBInstanceAttributeResponse.HttpResponse = context.HttpResponse;
			describeDBInstanceAttributeResponse.RequestId = context.StringValue("DescribeDBInstanceAttribute.RequestId");

			List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance> describeDBInstanceAttributeResponse_dBInstances = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance>();
			for (int i = 0; i < context.Length("DescribeDBInstanceAttribute.DBInstances.Length"); i++) {
				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance dBInstance = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance();
				dBInstance.ResourceGroupId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ResourceGroupId");
				dBInstance.DBInstanceId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceId");
				dBInstance.DBInstanceDescription = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceDescription");
				dBInstance.RegionId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].RegionId");
				dBInstance.ZoneId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ZoneId");
				dBInstance.Engine = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].Engine");
				dBInstance.EngineVersion = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].EngineVersion");
				dBInstance.StorageEngine = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].StorageEngine");
				dBInstance.DBInstanceClass = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceClass");
				dBInstance.DBInstanceStorage = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceStorage");
				dBInstance.ReplacateId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplacateId");
				dBInstance.VPCId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].VPCId");
				dBInstance.VSwitchId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].VSwitchId");
				dBInstance.VPCCloudInstanceIds = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].VPCCloudInstanceIds");
				dBInstance.DBInstanceStatus = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceStatus");
				dBInstance.LockMode = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].LockMode");
				dBInstance.ChargeType = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ChargeType");
				dBInstance.CreationTime = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].CreationTime");
				dBInstance.ReplicaSetName = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSetName");
				dBInstance.NetworkType = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].NetworkType");
				dBInstance.ExpireTime = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ExpireTime");
				dBInstance.MaintainStartTime = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaintainStartTime");
				dBInstance.MaintainEndTime = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaintainEndTime");
				dBInstance.DBInstanceType = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceType");
				dBInstance.LastDowngradeTime = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].LastDowngradeTime");
				dBInstance.ReplicationFactor = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicationFactor");
				dBInstance.ReadonlyReplicas = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReadonlyReplicas");
				dBInstance.MaxIOPS = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaxIOPS");
				dBInstance.MaxConnections = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MaxConnections");
				dBInstance.CurrentKernelVersion = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].CurrentKernelVersion");
				dBInstance.VpcAuthMode = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].VpcAuthMode");

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute> dBInstance_mongosList = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute>();
				for (int j = 0; j < context.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute mongosAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute();
					mongosAttribute.NodeId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].NodeId");
					mongosAttribute.NodeDescription = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].NodeDescription");
					mongosAttribute.NodeClass = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].NodeClass");
					mongosAttribute.ConnectSting = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].ConnectSting");
					mongosAttribute.MaxIOPS = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].MaxIOPS");
					mongosAttribute.MaxConnections = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].MaxConnections");
					mongosAttribute.Port = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].Port");
					mongosAttribute.VpcCloudInstanceId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].VpcCloudInstanceId");
					mongosAttribute.VPCId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].VPCId");
					mongosAttribute.VSwitchId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].VSwitchId");

					dBInstance_mongosList.Add(mongosAttribute);
				}
				dBInstance.MongosList = dBInstance_mongosList;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ShardAttribute> dBInstance_shardList = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ShardAttribute>();
				for (int j = 0; j < context.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ShardAttribute shardAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ShardAttribute();
					shardAttribute.NodeId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].NodeId");
					shardAttribute.NodeDescription = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].NodeDescription");
					shardAttribute.NodeClass = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].NodeClass");
					shardAttribute.NodeStorage = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].NodeStorage");
					shardAttribute.MaxIOPS = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].MaxIOPS");
					shardAttribute.MaxConnections = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].MaxConnections");
					shardAttribute.ConnectString = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].ConnectString");
					shardAttribute.Port = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ShardList["+ j +"].Port");

					dBInstance_shardList.Add(shardAttribute);
				}
				dBInstance.ShardList = dBInstance_shardList;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConfigserverAttribute> dBInstance_configserverList = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConfigserverAttribute>();
				for (int j = 0; j < context.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConfigserverAttribute configserverAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConfigserverAttribute();
					configserverAttribute.NodeId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].NodeId");
					configserverAttribute.NodeDescription = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].NodeDescription");
					configserverAttribute.NodeClass = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].NodeClass");
					configserverAttribute.NodeStorage = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].NodeStorage");
					configserverAttribute.MaxIOPS = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].MaxIOPS");
					configserverAttribute.MaxConnections = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].MaxConnections");
					configserverAttribute.ConnectString = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].ConnectString");
					configserverAttribute.Port = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ConfigserverList["+ j +"].Port");

					dBInstance_configserverList.Add(configserverAttribute);
				}
				dBInstance.ConfigserverList = dBInstance_configserverList;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ReplicaSet> dBInstance_replicaSets = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ReplicaSet>();
				for (int j = 0; j < context.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ReplicaSet replicaSet = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ReplicaSet();
					replicaSet.ReplicaSetRole = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].ReplicaSetRole");
					replicaSet.ConnectionDomain = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].ConnectionDomain");
					replicaSet.ConnectionPort = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].ConnectionPort");
					replicaSet.VPCCloudInstanceId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].VPCCloudInstanceId");
					replicaSet.VPCId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].VPCId");
					replicaSet.VSwitchId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].VSwitchId");
					replicaSet.NetworkType = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ReplicaSets["+ j +"].NetworkType");

					dBInstance_replicaSets.Add(replicaSet);
				}
				dBInstance.ReplicaSets = dBInstance_replicaSets;

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_Tag> dBInstance_tags = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_Tag>();
				for (int j = 0; j < context.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].Tags.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_Tag tag = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_Tag();
					tag.Key = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].Tags["+ j +"].Value");

					dBInstance_tags.Add(tag);
				}
				dBInstance.Tags = dBInstance_tags;

				describeDBInstanceAttributeResponse_dBInstances.Add(dBInstance);
			}
			describeDBInstanceAttributeResponse.DBInstances = describeDBInstanceAttributeResponse_dBInstances;
        
			return describeDBInstanceAttributeResponse;
        }
    }
}
