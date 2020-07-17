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
	public class DescribeDBClusterMigrationResponse : AcsResponse
	{

		private string requestId;

		private string dBClusterId;

		private string sourceRDSDBInstanceId;

		private string migrationStatus;

		private string topologies;

		private int? delayedSeconds;

		private string expiredTime;

		private string rdsReadWriteMode;

		private string dBClusterReadWriteMode;

		private string comment;

		private List<DescribeDBClusterMigration_DBClusterEndpoint> dBClusterEndpointList;

		private List<DescribeDBClusterMigration_RdsEndpoint> rdsEndpointList;

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

		public string SourceRDSDBInstanceId
		{
			get
			{
				return sourceRDSDBInstanceId;
			}
			set	
			{
				sourceRDSDBInstanceId = value;
			}
		}

		public string MigrationStatus
		{
			get
			{
				return migrationStatus;
			}
			set	
			{
				migrationStatus = value;
			}
		}

		public string Topologies
		{
			get
			{
				return topologies;
			}
			set	
			{
				topologies = value;
			}
		}

		public int? DelayedSeconds
		{
			get
			{
				return delayedSeconds;
			}
			set	
			{
				delayedSeconds = value;
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

		public string RdsReadWriteMode
		{
			get
			{
				return rdsReadWriteMode;
			}
			set	
			{
				rdsReadWriteMode = value;
			}
		}

		public string DBClusterReadWriteMode
		{
			get
			{
				return dBClusterReadWriteMode;
			}
			set	
			{
				dBClusterReadWriteMode = value;
			}
		}

		public string Comment
		{
			get
			{
				return comment;
			}
			set	
			{
				comment = value;
			}
		}

		public List<DescribeDBClusterMigration_DBClusterEndpoint> DBClusterEndpointList
		{
			get
			{
				return dBClusterEndpointList;
			}
			set	
			{
				dBClusterEndpointList = value;
			}
		}

		public List<DescribeDBClusterMigration_RdsEndpoint> RdsEndpointList
		{
			get
			{
				return rdsEndpointList;
			}
			set	
			{
				rdsEndpointList = value;
			}
		}

		public class DescribeDBClusterMigration_DBClusterEndpoint
		{

			private string dBEndpointId;

			private string endpointType;

			private List<DescribeDBClusterMigration_Address> addressItems;

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

			public List<DescribeDBClusterMigration_Address> AddressItems
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

			public class DescribeDBClusterMigration_Address
			{

				private string connectionString;

				private string iPAddress;

				private string netType;

				private string port;

				private string vPCId;

				private string vSwitchId;

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
			}
		}

		public class DescribeDBClusterMigration_RdsEndpoint
		{

			private string dBEndpointId;

			private string endpointType;

			private List<DescribeDBClusterMigration_Address2> addressItems1;

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

			public List<DescribeDBClusterMigration_Address2> AddressItems1
			{
				get
				{
					return addressItems1;
				}
				set	
				{
					addressItems1 = value;
				}
			}

			public class DescribeDBClusterMigration_Address2
			{

				private string connectionString;

				private string iPAddress;

				private string netType;

				private string port;

				private string vPCId;

				private string vSwitchId;

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
			}
		}
	}
}
