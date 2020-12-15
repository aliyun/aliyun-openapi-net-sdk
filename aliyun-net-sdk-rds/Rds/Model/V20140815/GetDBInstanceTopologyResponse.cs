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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class GetDBInstanceTopologyResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private GetDBInstanceTopology_Data data;

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

				private string netType;

				private string connectionString;

				private string zoneId;

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
			}

			public class GetDBInstanceTopology_Node
			{

				private string role;

				private string dedicatedHostId;

				private string zoneId;

				private string dedicatedHostGroupId;

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
