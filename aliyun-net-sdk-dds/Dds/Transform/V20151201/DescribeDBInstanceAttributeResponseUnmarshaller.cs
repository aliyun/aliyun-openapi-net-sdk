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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dds.Model.V20151201;
using System;
using System.Collections.Generic;

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
				dBInstance.DBInstanceId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceId");
				dBInstance.DBInstanceDescription = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceDescription");
				dBInstance.RegionId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].RegionId");
				dBInstance.ZoneId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].ZoneId");
				dBInstance.Engine = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].Engine");
				dBInstance.EngineVersion = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].EngineVersion");
				dBInstance.StorageEngine = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].StorageEngine");
				dBInstance.DBInstanceClass = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceClass");
				dBInstance.DBInstanceStorage = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].DBInstanceStorage");
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
				dBInstance.LastDowngradeTime = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].LastDowngradeTime");

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute> dBInstance_mongosList = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute>();
				for (int j = 0; j < context.Length("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute mongosAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_MongosAttribute();
					mongosAttribute.NodeId = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].NodeId");
					mongosAttribute.NodeDescription = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].NodeDescription");
					mongosAttribute.NodeClass = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].NodeClass");
					mongosAttribute.ConnectSting = context.StringValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].ConnectSting");
					mongosAttribute.Port = context.IntegerValue("DescribeDBInstanceAttribute.DBInstances["+ i +"].MongosList["+ j +"].Port");

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

					dBInstance_shardList.Add(shardAttribute);
				}
				dBInstance.ShardList = dBInstance_shardList;

				describeDBInstanceAttributeResponse_dBInstances.Add(dBInstance);
			}
			describeDBInstanceAttributeResponse.DBInstances = describeDBInstanceAttributeResponse_dBInstances;
        
			return describeDBInstanceAttributeResponse;
        }
    }
}