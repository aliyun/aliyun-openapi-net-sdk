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
	public class DescribeGlobalDatabaseNetworkResponse : AcsResponse
	{

		private string gDNStatus;

		private string dBVersion;

		private string requestId;

		private string gDNId;

		private string createTime;

		private string dBType;

		private string gDNDescription;

		private List<DescribeGlobalDatabaseNetwork_Connection> connections;

		private List<DescribeGlobalDatabaseNetwork_DBCluster> dBClusters;

		public string GDNStatus
		{
			get
			{
				return gDNStatus;
			}
			set	
			{
				gDNStatus = value;
			}
		}

		public string DBVersion
		{
			get
			{
				return dBVersion;
			}
			set	
			{
				dBVersion = value;
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

		public string GDNId
		{
			get
			{
				return gDNId;
			}
			set	
			{
				gDNId = value;
			}
		}

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public string DBType
		{
			get
			{
				return dBType;
			}
			set	
			{
				dBType = value;
			}
		}

		public string GDNDescription
		{
			get
			{
				return gDNDescription;
			}
			set	
			{
				gDNDescription = value;
			}
		}

		public List<DescribeGlobalDatabaseNetwork_Connection> Connections
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

		public List<DescribeGlobalDatabaseNetwork_DBCluster> DBClusters
		{
			get
			{
				return dBClusters;
			}
			set	
			{
				dBClusters = value;
			}
		}

		public class DescribeGlobalDatabaseNetwork_Connection
		{

			private string connectionString;

			private string netType;

			private string port;

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
		}

		public class DescribeGlobalDatabaseNetwork_DBCluster
		{

			private string replicaLag;

			private string expireTime;

			private string expired;

			private string dBNodeClass;

			private string payType;

			private string dBType;

			private string regionId;

			private string dBVersion;

			private string dBClusterId;

			private string dBClusterStatus;

			private string storageUsed;

			private string dBClusterDescription;

			private string role;

			public string ReplicaLag
			{
				get
				{
					return replicaLag;
				}
				set	
				{
					replicaLag = value;
				}
			}

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

			public string Expired
			{
				get
				{
					return expired;
				}
				set	
				{
					expired = value;
				}
			}

			public string DBNodeClass
			{
				get
				{
					return dBNodeClass;
				}
				set	
				{
					dBNodeClass = value;
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

			public string DBType
			{
				get
				{
					return dBType;
				}
				set	
				{
					dBType = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string DBVersion
			{
				get
				{
					return dBVersion;
				}
				set	
				{
					dBVersion = value;
				}
			}

			public string DBClusterId
			{
				get
				{
					return dBClusterId;
				}
				set	
				{
					dBClusterId = value;
				}
			}

			public string DBClusterStatus
			{
				get
				{
					return dBClusterStatus;
				}
				set	
				{
					dBClusterStatus = value;
				}
			}

			public string StorageUsed
			{
				get
				{
					return storageUsed;
				}
				set	
				{
					storageUsed = value;
				}
			}

			public string DBClusterDescription
			{
				get
				{
					return dBClusterDescription;
				}
				set	
				{
					dBClusterDescription = value;
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
		}
	}
}
