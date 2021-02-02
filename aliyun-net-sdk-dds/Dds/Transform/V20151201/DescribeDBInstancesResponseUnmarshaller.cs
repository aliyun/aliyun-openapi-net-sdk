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
    public class DescribeDBInstancesResponseUnmarshaller
    {
        public static DescribeDBInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstancesResponse describeDBInstancesResponse = new DescribeDBInstancesResponse();

			describeDBInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeDBInstances.TotalCount");
			describeDBInstancesResponse.PageSize = _ctx.IntegerValue("DescribeDBInstances.PageSize");
			describeDBInstancesResponse.RequestId = _ctx.StringValue("DescribeDBInstances.RequestId");
			describeDBInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeDBInstances.PageNumber");

			List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance> describeDBInstancesResponse_dBInstances = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstances.DBInstances.Length"); i++) {
				DescribeDBInstancesResponse.DescribeDBInstances_DBInstance dBInstance = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance();
				dBInstance.EngineVersion = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].EngineVersion");
				dBInstance.ReplicationFactor = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].ReplicationFactor");
				dBInstance.ZoneId = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].ZoneId");
				dBInstance.ResourceGroupId = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].ResourceGroupId");
				dBInstance.DBInstanceStatus = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].DBInstanceStatus");
				dBInstance.DBInstanceClass = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].DBInstanceClass");
				dBInstance.DestroyTime = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].DestroyTime");
				dBInstance.DBInstanceType = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].DBInstanceType");
				dBInstance.LockMode = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].LockMode");
				dBInstance.DBInstanceId = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].DBInstanceId");
				dBInstance.NetworkType = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].NetworkType");
				dBInstance.VpcAuthMode = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].VpcAuthMode");
				dBInstance.ChargeType = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].ChargeType");
				dBInstance.DBInstanceStorage = _ctx.IntegerValue("DescribeDBInstances.DBInstances["+ i +"].DBInstanceStorage");
				dBInstance.LastDowngradeTime = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].LastDowngradeTime");
				dBInstance.CreationTime = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].CreationTime");
				dBInstance.RegionId = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].RegionId");
				dBInstance.ExpireTime = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].ExpireTime");
				dBInstance.KindCode = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].KindCode");
				dBInstance.Engine = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Engine");
				dBInstance.DBInstanceDescription = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].DBInstanceDescription");

				List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_MongosAttribute> dBInstance_mongosList = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_MongosAttribute>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstances.DBInstances["+ i +"].MongosList.Length"); j++) {
					DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_MongosAttribute mongosAttribute = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_MongosAttribute();
					mongosAttribute.NodeClass = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].MongosList["+ j +"].NodeClass");
					mongosAttribute.NodeDescription = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].MongosList["+ j +"].NodeDescription");
					mongosAttribute.NodeId = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].MongosList["+ j +"].NodeId");

					dBInstance_mongosList.Add(mongosAttribute);
				}
				dBInstance.MongosList = dBInstance_mongosList;

				List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ShardAttribute> dBInstance_shardList = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ShardAttribute>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstances.DBInstances["+ i +"].ShardList.Length"); j++) {
					DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ShardAttribute shardAttribute = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ShardAttribute();
					shardAttribute.NodeClass = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].ShardList["+ j +"].NodeClass");
					shardAttribute.NodeDescription = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].ShardList["+ j +"].NodeDescription");
					shardAttribute.ReadonlyReplicas = _ctx.IntegerValue("DescribeDBInstances.DBInstances["+ i +"].ShardList["+ j +"].ReadonlyReplicas");
					shardAttribute.NodeId = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].ShardList["+ j +"].NodeId");
					shardAttribute.NodeStorage = _ctx.IntegerValue("DescribeDBInstances.DBInstances["+ i +"].ShardList["+ j +"].NodeStorage");

					dBInstance_shardList.Add(shardAttribute);
				}
				dBInstance.ShardList = dBInstance_shardList;

				List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_Tag> dBInstance_tags = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstances.DBInstances["+ i +"].Tags.Length"); j++) {
					DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_Tag tag = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_Tag();
					tag._Value = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Tags["+ j +"].Value");
					tag.Key = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Tags["+ j +"].Key");

					dBInstance_tags.Add(tag);
				}
				dBInstance.Tags = dBInstance_tags;

				describeDBInstancesResponse_dBInstances.Add(dBInstance);
			}
			describeDBInstancesResponse.DBInstances = describeDBInstancesResponse_dBInstances;
        
			return describeDBInstancesResponse;
        }
    }
}
