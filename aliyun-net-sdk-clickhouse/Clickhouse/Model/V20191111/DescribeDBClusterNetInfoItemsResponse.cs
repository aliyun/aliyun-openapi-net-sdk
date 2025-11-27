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

namespace Aliyun.Acs.clickhouse.Model.V20191111
{
	public class DescribeDBClusterNetInfoItemsResponse : AcsResponse
	{

		private string clusterNetworkType;

		private string requestId;

		private bool? enableSLB;

		private List<DescribeDBClusterNetInfoItems_NetInfoItem> netInfoItems;

		public string ClusterNetworkType
		{
			get
			{
				return clusterNetworkType;
			}
			set	
			{
				clusterNetworkType = value;
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

		public bool? EnableSLB
		{
			get
			{
				return enableSLB;
			}
			set	
			{
				enableSLB = value;
			}
		}

		public List<DescribeDBClusterNetInfoItems_NetInfoItem> NetInfoItems
		{
			get
			{
				return netInfoItems;
			}
			set	
			{
				netInfoItems = value;
			}
		}

		public class DescribeDBClusterNetInfoItems_NetInfoItem
		{

			private string vpcId;

			private string vSwitchId;

			private string connectionString;

			private string jdbcPort;

			private string netType;

			private string httpPort;

			private string iPAddress;

			private string httpsPort;

			private string mySQLPort;

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
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

			public string JdbcPort
			{
				get
				{
					return jdbcPort;
				}
				set	
				{
					jdbcPort = value;
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

			public string HttpPort
			{
				get
				{
					return httpPort;
				}
				set	
				{
					httpPort = value;
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

			public string HttpsPort
			{
				get
				{
					return httpsPort;
				}
				set	
				{
					httpsPort = value;
				}
			}

			public string MySQLPort
			{
				get
				{
					return mySQLPort;
				}
				set	
				{
					mySQLPort = value;
				}
			}
		}
	}
}
