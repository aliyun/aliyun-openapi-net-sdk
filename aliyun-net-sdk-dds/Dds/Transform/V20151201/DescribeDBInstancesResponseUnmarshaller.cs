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
    public class DescribeDBInstancesResponseUnmarshaller
    {
        public static DescribeDBInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstancesResponse describeDBInstancesResponse = new DescribeDBInstancesResponse();

			describeDBInstancesResponse.HttpResponse = context.HttpResponse;
			describeDBInstancesResponse.RequestId = context.StringValue("DescribeDBInstances.RequestId");
			describeDBInstancesResponse.PageNumber = context.IntegerValue("DescribeDBInstances.PageNumber");
			describeDBInstancesResponse.PageSize = context.IntegerValue("DescribeDBInstances.PageSize");
			describeDBInstancesResponse.TotalCount = context.IntegerValue("DescribeDBInstances.TotalCount");

			List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance> describeDBInstancesResponse_dBInstances = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance>();
			for (int i = 0; i < context.Length("DescribeDBInstances.DBInstances.Length"); i++) {
				DescribeDBInstancesResponse.DescribeDBInstances_DBInstance dBInstance = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance();
				dBInstance.DBInstanceId = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].DBInstanceId");
				dBInstance.DBInstanceDescription = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].DBInstanceDescription");
				dBInstance.RegionId = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].RegionId");
				dBInstance.ZoneId = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].ZoneId");
				dBInstance.Engine = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].Engine");
				dBInstance.EngineVersion = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].EngineVersion");
				dBInstance.DBInstanceClass = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].DBInstanceClass");
				dBInstance.DBInstanceStorage = context.IntegerValue("DescribeDBInstances.DBInstances["+ i +"].DBInstanceStorage");
				dBInstance.DBInstanceStatus = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].DBInstanceStatus");
				dBInstance.LockMode = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].LockMode");
				dBInstance.ChargeType = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].ChargeType");
				dBInstance.NetworkType = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].NetworkType");
				dBInstance.CreationTime = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].CreationTime");
				dBInstance.ExpireTime = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].ExpireTime");
				dBInstance.DBInstanceType = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].DBInstanceType");
				dBInstance.LastDowngradeTime = context.IntegerValue("DescribeDBInstances.DBInstances["+ i +"].LastDowngradeTime");

				List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_MongosAttribute> dBInstance_mongosList = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_MongosAttribute>();
				for (int j = 0; j < context.Length("DescribeDBInstances.DBInstances["+ i +"].MongosList.Length"); j++) {
					DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_MongosAttribute mongosAttribute = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_MongosAttribute();
					mongosAttribute.NodeId = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].MongosList["+ j +"].NodeId");
					mongosAttribute.NodeDescription = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].MongosList["+ j +"].NodeDescription");
					mongosAttribute.NodeClass = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].MongosList["+ j +"].NodeClass");
					mongosAttribute.ConnectSting = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].MongosList["+ j +"].ConnectSting");
					mongosAttribute.Port = context.IntegerValue("DescribeDBInstances.DBInstances["+ i +"].MongosList["+ j +"].Port");

					dBInstance_mongosList.Add(mongosAttribute);
				}
				dBInstance.MongosList = dBInstance_mongosList;

				List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ShardAttribute> dBInstance_shardList = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ShardAttribute>();
				for (int j = 0; j < context.Length("DescribeDBInstances.DBInstances["+ i +"].ShardList.Length"); j++) {
					DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ShardAttribute shardAttribute = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ShardAttribute();
					shardAttribute.NodeId = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].ShardList["+ j +"].NodeId");
					shardAttribute.NodeDescription = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].ShardList["+ j +"].NodeDescription");
					shardAttribute.NodeClass = context.StringValue("DescribeDBInstances.DBInstances["+ i +"].ShardList["+ j +"].NodeClass");
					shardAttribute.NodeStorage = context.IntegerValue("DescribeDBInstances.DBInstances["+ i +"].ShardList["+ j +"].NodeStorage");

					dBInstance_shardList.Add(shardAttribute);
				}
				dBInstance.ShardList = dBInstance_shardList;

				describeDBInstancesResponse_dBInstances.Add(dBInstance);
			}
			describeDBInstancesResponse.DBInstances = describeDBInstancesResponse_dBInstances;
        
			return describeDBInstancesResponse;
        }
    }
}