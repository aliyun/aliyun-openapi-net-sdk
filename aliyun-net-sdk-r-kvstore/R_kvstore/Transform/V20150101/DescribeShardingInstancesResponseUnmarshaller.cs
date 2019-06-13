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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeShardingInstancesResponseUnmarshaller
    {
        public static DescribeShardingInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeShardingInstancesResponse describeShardingInstancesResponse = new DescribeShardingInstancesResponse();

			describeShardingInstancesResponse.HttpResponse = context.HttpResponse;
			describeShardingInstancesResponse.RequestId = context.StringValue("DescribeShardingInstances.RequestId");
			describeShardingInstancesResponse.TotalCount = context.IntegerValue("DescribeShardingInstances.TotalCount");

			List<DescribeShardingInstancesResponse.DescribeShardingInstances_Instance> describeShardingInstancesResponse_instances = new List<DescribeShardingInstancesResponse.DescribeShardingInstances_Instance>();
			for (int i = 0; i < context.Length("DescribeShardingInstances.Instances.Length"); i++) {
				DescribeShardingInstancesResponse.DescribeShardingInstances_Instance instance = new DescribeShardingInstancesResponse.DescribeShardingInstances_Instance();
				instance.InstanceId = context.StringValue("DescribeShardingInstances.Instances["+ i +"].InstanceId");

				List<DescribeShardingInstancesResponse.DescribeShardingInstances_Instance.DescribeShardingInstances_Shard> instance_shardList = new List<DescribeShardingInstancesResponse.DescribeShardingInstances_Instance.DescribeShardingInstances_Shard>();
				for (int j = 0; j < context.Length("DescribeShardingInstances.Instances["+ i +"].ShardList.Length"); j++) {
					DescribeShardingInstancesResponse.DescribeShardingInstances_Instance.DescribeShardingInstances_Shard shard = new DescribeShardingInstancesResponse.DescribeShardingInstances_Instance.DescribeShardingInstances_Shard();
					shard.NodeId = context.StringValue("DescribeShardingInstances.Instances["+ i +"].ShardList["+ j +"].NodeId");
					shard.ShardReplicaClass = context.StringValue("DescribeShardingInstances.Instances["+ i +"].ShardList["+ j +"].ShardReplicaClass");
					shard.ShardStorageQuantity = context.StringValue("DescribeShardingInstances.Instances["+ i +"].ShardList["+ j +"].ShardStorageQuantity");

					instance_shardList.Add(shard);
				}
				instance.ShardList = instance_shardList;

				describeShardingInstancesResponse_instances.Add(instance);
			}
			describeShardingInstancesResponse.Instances = describeShardingInstancesResponse_instances;
        
			return describeShardingInstancesResponse;
        }
    }
}
