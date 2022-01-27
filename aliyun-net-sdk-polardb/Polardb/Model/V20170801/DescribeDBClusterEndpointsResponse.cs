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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterEndpointsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBClusterEndpoints_DBEndpoint> items;

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

		public List<DescribeDBClusterEndpoints_DBEndpoint> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeDBClusterEndpoints_DBEndpoint
		{

			private string dBEndpointId;

			private string nodeWithRoles;

			private string autoAddNewNodes;

			private string endpointType;

			private string dBEndpointDescription;

			private string endpointConfig;

			private string readWriteMode;

			private string nodes;

			private List<DescribeDBClusterEndpoints_Address> addressItems;

			public string DBEndpointId
			{
				get
				{
					return dBEndpointId;
				}
				set	
				{
					dBEndpointId = value;
				}
			}

			public string NodeWithRoles
			{
				get
				{
					return nodeWithRoles;
				}
				set	
				{
					nodeWithRoles = value;
				}
			}

			public string AutoAddNewNodes
			{
				get
				{
					return autoAddNewNodes;
				}
				set	
				{
					autoAddNewNodes = value;
				}
			}

			public string EndpointType
			{
				get
				{
					return endpointType;
				}
				set	
				{
					endpointType = value;
				}
			}

			public string DBEndpointDescription
			{
				get
				{
					return dBEndpointDescription;
				}
				set	
				{
					dBEndpointDescription = value;
				}
			}

			public string EndpointConfig
			{
				get
				{
					return endpointConfig;
				}
				set	
				{
					endpointConfig = value;
				}
			}

			public string ReadWriteMode
			{
				get
				{
					return readWriteMode;
				}
				set	
				{
					readWriteMode = value;
				}
			}

			public string Nodes
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

			public List<DescribeDBClusterEndpoints_Address> AddressItems
			{
				get
				{
					return addressItems;
				}
				set	
				{
					addressItems = value;
				}
			}

			public class DescribeDBClusterEndpoints_Address
			{

				private string privateZoneConnectionString;

				private string vPCId;

				private string port;

				private string vSwitchId;

				private string vpcInstanceId;

				private string iPAddress;

				private string connectionString;

				private string netType;

				public string PrivateZoneConnectionString
				{
					get
					{
						return privateZoneConnectionString;
					}
					set	
					{
						privateZoneConnectionString = value;
					}
				}

				public string VPCId
				{
					get
					{
						return vPCId;
					}
					set	
					{
						vPCId = value;
					}
				}

				public string Port
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

				public string VSwitchId
				{
					get
					{
						return vSwitchId;
					}
					set	
					{
						vSwitchId = value;
					}
				}

				public string VpcInstanceId
				{
					get
					{
						return vpcInstanceId;
					}
					set	
					{
						vpcInstanceId = value;
					}
				}

				public string IPAddress
				{
					get
					{
						return iPAddress;
					}
					set	
					{
						iPAddress = value;
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
		}
	}
}
