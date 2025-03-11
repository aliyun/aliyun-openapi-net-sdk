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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeDrdsDBClusterResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private DescribeDrdsDBCluster_DbInstance dbInstance;

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public DescribeDrdsDBCluster_DbInstance DbInstance
		{
			get
			{
				return dbInstance;
			}
			set	
			{
				dbInstance = value;
			}
		}

		public class DescribeDrdsDBCluster_DbInstance
		{

			private string expireTime;

			private string payType;

			private string dBInstanceStatus;

			private string networkType;

			private int? port;

			private string engineVersion;

			private string rdsInstType;

			private string remainDays;

			private string dBInstanceId;

			private string dbInstType;

			private string engine;

			private string readMode;

			private List<DescribeDrdsDBCluster_Endpoint> endpoints;

			private List<DescribeDrdsDBCluster_DBNode> dBNodes;

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public string DBInstanceStatus
			{
				get
				{
					return dBInstanceStatus;
				}
				set	
				{
					dBInstanceStatus = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			public string RdsInstType
			{
				get
				{
					return rdsInstType;
				}
				set	
				{
					rdsInstType = value;
				}
			}

			public string RemainDays
			{
				get
				{
					return remainDays;
				}
				set	
				{
					remainDays = value;
				}
			}

			public string DBInstanceId
			{
				get
				{
					return dBInstanceId;
				}
				set	
				{
					dBInstanceId = value;
				}
			}

			public string DbInstType
			{
				get
				{
					return dbInstType;
				}
				set	
				{
					dbInstType = value;
				}
			}

			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			public string ReadMode
			{
				get
				{
					return readMode;
				}
				set	
				{
					readMode = value;
				}
			}

			public List<DescribeDrdsDBCluster_Endpoint> Endpoints
			{
				get
				{
					return endpoints;
				}
				set	
				{
					endpoints = value;
				}
			}

			public List<DescribeDrdsDBCluster_DBNode> DBNodes
			{
				get
				{
					return dBNodes;
				}
				set	
				{
					dBNodes = value;
				}
			}

			public class DescribeDrdsDBCluster_Endpoint
			{

				private int? readWeight;

				private string endpointId;

				private string nodeIds;

				public int? ReadWeight
				{
					get
					{
						return readWeight;
					}
					set	
					{
						readWeight = value;
					}
				}

				public string EndpointId
				{
					get
					{
						return endpointId;
					}
					set	
					{
						endpointId = value;
					}
				}

				public string NodeIds
				{
					get
					{
						return nodeIds;
					}
					set	
					{
						nodeIds = value;
					}
				}
			}

			public class DescribeDrdsDBCluster_DBNode
			{

				private string dBNodeRole;

				private string zoneId;

				private string dBNodeId;

				private string dBNodeStatus;

				public string DBNodeRole
				{
					get
					{
						return dBNodeRole;
					}
					set	
					{
						dBNodeRole = value;
					}
				}

				public string ZoneId
				{
					get
					{
						return zoneId;
					}
					set	
					{
						zoneId = value;
					}
				}

				public string DBNodeId
				{
					get
					{
						return dBNodeId;
					}
					set	
					{
						dBNodeId = value;
					}
				}

				public string DBNodeStatus
				{
					get
					{
						return dBNodeStatus;
					}
					set	
					{
						dBNodeStatus = value;
					}
				}
			}
		}
	}
}
