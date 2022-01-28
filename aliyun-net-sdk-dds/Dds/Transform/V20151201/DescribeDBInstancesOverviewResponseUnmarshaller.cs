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
    public class DescribeDBInstancesOverviewResponseUnmarshaller
    {
        public static DescribeDBInstancesOverviewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstancesOverviewResponse describeDBInstancesOverviewResponse = new DescribeDBInstancesOverviewResponse();

			describeDBInstancesOverviewResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstancesOverviewResponse.TotalCount = _ctx.StringValue("DescribeDBInstancesOverview.TotalCount");
			describeDBInstancesOverviewResponse.RequestId = _ctx.StringValue("DescribeDBInstancesOverview.RequestId");

			List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance> describeDBInstancesOverviewResponse_dBInstances = new List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstancesOverview.DBInstances.Length"); i++) {
				DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance dBInstance = new DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance();
				dBInstance.CreationTime = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].CreationTime");
				dBInstance.ExpireTime = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].ExpireTime");
				dBInstance.LastDowngradeTime = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].LastDowngradeTime");
				dBInstance.DBInstanceType = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].DBInstanceType");
				dBInstance.DestroyTime = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].DestroyTime");
				dBInstance.ChargeType = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].ChargeType");
				dBInstance.CapacityUnit = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].CapacityUnit");
				dBInstance.VpcAuthMode = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].VpcAuthMode");
				dBInstance.DBInstanceStatus = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].DBInstanceStatus");
				dBInstance.NetworkType = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].NetworkType");
				dBInstance.LockMode = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].LockMode");
				dBInstance.EngineVersion = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].EngineVersion");
				dBInstance.RegionId = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].RegionId");
				dBInstance.DBInstanceStorage = _ctx.IntegerValue("DescribeDBInstancesOverview.DBInstances["+ i +"].DBInstanceStorage");
				dBInstance.ResourceGroupId = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].ResourceGroupId");
				dBInstance.ZoneId = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].ZoneId");
				dBInstance.DBInstanceId = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].DBInstanceId");
				dBInstance.DBInstanceClass = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].DBInstanceClass");
				dBInstance.Engine = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].Engine");
				dBInstance.ReplicationFactor = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].ReplicationFactor");
				dBInstance.DBInstanceDescription = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].DBInstanceDescription");
				dBInstance.KindCode = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].KindCode");

				List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance.DescribeDBInstancesOverview_Tag> dBInstance_tags = new List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance.DescribeDBInstancesOverview_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstancesOverview.DBInstances["+ i +"].Tags.Length"); j++) {
					DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance.DescribeDBInstancesOverview_Tag tag = new DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance.DescribeDBInstancesOverview_Tag();
					tag.Key = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].Tags["+ j +"].Value");

					dBInstance_tags.Add(tag);
				}
				dBInstance.Tags = dBInstance_tags;

				List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance.DescribeDBInstancesOverview_ShardAttribute> dBInstance_shardList = new List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance.DescribeDBInstancesOverview_ShardAttribute>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstancesOverview.DBInstances["+ i +"].ShardList.Length"); j++) {
					DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance.DescribeDBInstancesOverview_ShardAttribute shardAttribute = new DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance.DescribeDBInstancesOverview_ShardAttribute();
					shardAttribute.NodeClass = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].ShardList["+ j +"].NodeClass");
					shardAttribute.NodeDescription = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].ShardList["+ j +"].NodeDescription");
					shardAttribute.NodeStorage = _ctx.IntegerValue("DescribeDBInstancesOverview.DBInstances["+ i +"].ShardList["+ j +"].NodeStorage");
					shardAttribute.NodeId = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].ShardList["+ j +"].NodeId");
					shardAttribute.ReadonlyReplicas = _ctx.IntegerValue("DescribeDBInstancesOverview.DBInstances["+ i +"].ShardList["+ j +"].ReadonlyReplicas");

					dBInstance_shardList.Add(shardAttribute);
				}
				dBInstance.ShardList = dBInstance_shardList;

				List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance.DescribeDBInstancesOverview_MongosAttribute> dBInstance_mongosList = new List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance.DescribeDBInstancesOverview_MongosAttribute>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstancesOverview.DBInstances["+ i +"].MongosList.Length"); j++) {
					DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance.DescribeDBInstancesOverview_MongosAttribute mongosAttribute = new DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_DBInstance.DescribeDBInstancesOverview_MongosAttribute();
					mongosAttribute.NodeClass = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].MongosList["+ j +"].NodeClass");
					mongosAttribute.NodeDescription = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].MongosList["+ j +"].NodeDescription");
					mongosAttribute.NodeId = _ctx.StringValue("DescribeDBInstancesOverview.DBInstances["+ i +"].MongosList["+ j +"].NodeId");

					dBInstance_mongosList.Add(mongosAttribute);
				}
				dBInstance.MongosList = dBInstance_mongosList;

				describeDBInstancesOverviewResponse_dBInstances.Add(dBInstance);
			}
			describeDBInstancesOverviewResponse.DBInstances = describeDBInstancesOverviewResponse_dBInstances;
        
			return describeDBInstancesOverviewResponse;
        }
    }
}
