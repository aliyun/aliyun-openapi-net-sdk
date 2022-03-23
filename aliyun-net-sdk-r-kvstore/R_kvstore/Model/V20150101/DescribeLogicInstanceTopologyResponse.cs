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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeLogicInstanceTopologyResponse : AcsResponse
	{

		private string instanceId;

		private string requestId;

		private List<DescribeLogicInstanceTopology_NodeInfo> redisProxyList;

		private List<DescribeLogicInstanceTopology_NodeInfo> redisShardList;

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

		public List<DescribeLogicInstanceTopology_NodeInfo> RedisProxyList
		{
			get
			{
				return redisProxyList;
			}
			set	
			{
				redisProxyList = value;
			}
		}

		public List<DescribeLogicInstanceTopology_NodeInfo> RedisShardList
		{
			get
			{
				return redisShardList;
			}
			set	
			{
				redisShardList = value;
			}
		}

		public class DescribeLogicInstanceTopology_NodeInfo
		{

			private string capacity;

			private string connection;

			private string nodeType;

			private string bandwidth;

			private string nodeId;

			public string Capacity
			{
				get
				{
					return capacity;
				}
				set	
				{
					capacity = value;
				}
			}

			public string Connection
			{
				get
				{
					return connection;
				}
				set	
				{
					connection = value;
				}
			}

			public string NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			public string Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

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
		}
	}
}
