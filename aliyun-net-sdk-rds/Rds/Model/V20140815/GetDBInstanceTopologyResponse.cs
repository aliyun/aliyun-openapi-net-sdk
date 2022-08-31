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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class GetDBInstanceTopologyResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetDBInstanceTopology_Data data;

		[JsonProperty(PropertyName = "Code")]
		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		[JsonProperty(PropertyName = "Message")]
		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Data")]
		public GetDBInstanceTopology_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetDBInstanceTopology_Data
		{

			private string dBInstanceName;

			private List<GetDBInstanceTopology_Connection> connections;

			private List<GetDBInstanceTopology_Node> nodes;

			[JsonProperty(PropertyName = "DBInstanceName")]
			public string DBInstanceName
			{
				get
				{
					return dBInstanceName;
				}
				set	
				{
					dBInstanceName = value;
				}
			}

			[JsonProperty(PropertyName = "Connections")]
			public List<GetDBInstanceTopology_Connection> Connections
			{
				get
				{
					return connections;
				}
				set	
				{
					connections = value;
				}
			}

			[JsonProperty(PropertyName = "Nodes")]
			public List<GetDBInstanceTopology_Node> Nodes
			{
				get
				{
					return nodes;
				}
				set	
				{
					nodes = value;
				}
			}

			public class GetDBInstanceTopology_Connection
			{

				private string zoneId;

				private string dBInstanceName;

				private string connectionString;

				private string netType;

				[JsonProperty(PropertyName = "ZoneId")]
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

				[JsonProperty(PropertyName = "DBInstanceName")]
				public string DBInstanceName
				{
					get
					{
						return dBInstanceName;
					}
					set	
					{
						dBInstanceName = value;
					}
				}

				[JsonProperty(PropertyName = "ConnectionString")]
				public string ConnectionString
				{
					get
					{
						return connectionString;
					}
					set	
					{
						connectionString = value;
					}
				}

				[JsonProperty(PropertyName = "NetType")]
				public string NetType
				{
					get
					{
						return netType;
					}
					set	
					{
						netType = value;
					}
				}
			}

			public class GetDBInstanceTopology_Node
			{

				private string dBInstanceName;

				private string zoneId;

				private string dedicatedHostId;

				private string role;

				private string nodeId;

				private string dedicatedHostGroupId;

				[JsonProperty(PropertyName = "DBInstanceName")]
				public string DBInstanceName
				{
					get
					{
						return dBInstanceName;
					}
					set	
					{
						dBInstanceName = value;
					}
				}

				[JsonProperty(PropertyName = "ZoneId")]
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

				[JsonProperty(PropertyName = "DedicatedHostId")]
				public string DedicatedHostId
				{
					get
					{
						return dedicatedHostId;
					}
					set	
					{
						dedicatedHostId = value;
					}
				}

				[JsonProperty(PropertyName = "Role")]
				public string Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
					}
				}

				[JsonProperty(PropertyName = "NodeId")]
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

				[JsonProperty(PropertyName = "DedicatedHostGroupId")]
				public string DedicatedHostGroupId
				{
					get
					{
						return dedicatedHostGroupId;
					}
					set	
					{
						dedicatedHostGroupId = value;
					}
				}
			}
		}
	}
}
