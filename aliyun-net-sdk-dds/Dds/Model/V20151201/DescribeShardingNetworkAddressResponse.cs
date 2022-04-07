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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeShardingNetworkAddressResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeShardingNetworkAddress_CompatibleConnection> compatibleConnections;

		private List<DescribeShardingNetworkAddress_NetworkAddress> networkAddresses;

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

		public List<DescribeShardingNetworkAddress_CompatibleConnection> CompatibleConnections
		{
			get
			{
				return compatibleConnections;
			}
			set	
			{
				compatibleConnections = value;
			}
		}

		public List<DescribeShardingNetworkAddress_NetworkAddress> NetworkAddresses
		{
			get
			{
				return networkAddresses;
			}
			set	
			{
				networkAddresses = value;
			}
		}

		public class DescribeShardingNetworkAddress_CompatibleConnection
		{

			private string vswitchId;

			private string expiredTime;

			private string networkType;

			private string port;

			private string networkAddress;

			private string vPCId;

			private string iPAddress;

			public string VswitchId
			{
				get
				{
					return vswitchId;
				}
				set	
				{
					vswitchId = value;
				}
			}

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
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

			public string NetworkAddress
			{
				get
				{
					return networkAddress;
				}
				set	
				{
					networkAddress = value;
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
		}

		public class DescribeShardingNetworkAddress_NetworkAddress
		{

			private string nodeType;

			private string vswitchId;

			private string expiredTime;

			private string networkType;

			private string role;

			private string port;

			private string vPCId;

			private string networkAddress;

			private string nodeId;

			private string iPAddress;

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

			public string VswitchId
			{
				get
				{
					return vswitchId;
				}
				set	
				{
					vswitchId = value;
				}
			}

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
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

			public string NetworkAddress
			{
				get
				{
					return networkAddress;
				}
				set	
				{
					networkAddress = value;
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
		}
	}
}
