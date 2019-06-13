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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeShardingInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeShardingInstances_Instance> instances;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeShardingInstances_Instance> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public class DescribeShardingInstances_Instance
		{

			private string instanceId;

			private List<DescribeShardingInstances_Shard> shardList;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public List<DescribeShardingInstances_Shard> ShardList
			{
				get
				{
					return shardList;
				}
				set	
				{
					shardList = value;
				}
			}

			public class DescribeShardingInstances_Shard
			{

				private string nodeId;

				private string shardReplicaClass;

				private string shardStorageQuantity;

				public string NodeId
				{
					get
					{
						return nodeId;
					}
					set	
					{
						nodeId = value;
					}
				}

				public string ShardReplicaClass
				{
					get
					{
						return shardReplicaClass;
					}
					set	
					{
						shardReplicaClass = value;
					}
				}

				public string ShardStorageQuantity
				{
					get
					{
						return shardStorageQuantity;
					}
					set	
					{
						shardStorageQuantity = value;
					}
				}
			}
		}
	}
}
