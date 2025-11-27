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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterMigrationResponse : AcsResponse
	{

		private string comment;

		private string requestId;

		private string expiredTime;

		private string dBClusterId;

		private string topologies;

		private string rdsReadWriteMode;

		private string sourceRDSDBInstanceId;

		private string dBClusterReadWriteMode;

		private int? delayedSeconds;

		private string migrationStatus;

		private string dtsInstanceId;

		private string srcDbType;

		private string migrationSwitch;

		private string migrationDtsJobEndpoint;

		private string dstBinlogPosition;

		private string srcBinlogPosition;

		private string migrationProgress;

		private List<DescribeDBClusterMigration_DBClusterEndpoint> dBClusterEndpointList;

		private List<DescribeDBClusterMigration_RdsEndpoint> rdsEndpointList;

		private List<DescribeDBClusterMigration_SrcDtsJob> srcDtsJobList;

		private List<DescribeDBClusterMigration_DstDtsJob> dstDtsJobList;

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

		public string DtsInstanceId
		{
			get
			{
				return dtsInstanceId;
			}
			set	
			{
				dtsInstanceId = value;
			}
		}

		public string SrcDbType
		{
			get
			{
				return srcDbType;
			}
			set	
			{
				srcDbType = value;
			}
		}

		public string MigrationSwitch
		{
			get
			{
				return migrationSwitch;
			}
			set	
			{
				migrationSwitch = value;
			}
		}

		public string MigrationDtsJobEndpoint
		{
			get
			{
				return migrationDtsJobEndpoint;
			}
			set	
			{
				migrationDtsJobEndpoint = value;
			}
		}

		public string DstBinlogPosition
		{
			get
			{
				return dstBinlogPosition;
			}
			set	
			{
				dstBinlogPosition = value;
			}
		}

		public string SrcBinlogPosition
		{
			get
			{
				return srcBinlogPosition;
			}
			set	
			{
				srcBinlogPosition = value;
			}
		}

		public string MigrationProgress
		{
			get
			{
				return migrationProgress;
			}
			set	
			{
				migrationProgress = value;
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

		public List<DescribeDBClusterMigration_SrcDtsJob> SrcDtsJobList
		{
			get
			{
				return srcDtsJobList;
			}
			set	
			{
				srcDtsJobList = value;
			}
		}

		public List<DescribeDBClusterMigration_DstDtsJob> DstDtsJobList
		{
			get
			{
				return dstDtsJobList;
			}
			set	
			{
				dstDtsJobList = value;
			}
		}

		public class DescribeDBClusterMigration_DBClusterEndpoint
		{

			private string dBEndpointId;

			private string endpointType;

			private string readWriteMode;

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

				private string vSwitchId;

				private string connectionString;

				private string netType;

				private string port;

				private string vPCId;

				private string iPAddress;

				private string sSLEnabled;

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

				public string SSLEnabled
				{
					get
					{
						return sSLEnabled;
					}
					set	
					{
						sSLEnabled = value;
					}
				}
			}
		}

		public class DescribeDBClusterMigration_RdsEndpoint
		{

			private string dBEndpointId;

			private string endpointType;

			private string custinsType;

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

			public string CustinsType
			{
				get
				{
					return custinsType;
				}
				set	
				{
					custinsType = value;
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

				private string vSwitchId;

				private string connectionString;

				private string netType;

				private string port;

				private string vPCId;

				private string iPAddress;

				private string sSLEnabled;

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

				public string SSLEnabled
				{
					get
					{
						return sSLEnabled;
					}
					set	
					{
						sSLEnabled = value;
					}
				}
			}
		}

		public class DescribeDBClusterMigration_SrcDtsJob
		{

			private string dtsJobId;

			private string dtsJobName;

			private string dtsInstanceID;

			private string dtsJobDirection;

			private string status;

			private string sourceEndpoint;

			private string destinationEndpoint;

			public string DtsJobId
			{
				get
				{
					return dtsJobId;
				}
				set	
				{
					dtsJobId = value;
				}
			}

			public string DtsJobName
			{
				get
				{
					return dtsJobName;
				}
				set	
				{
					dtsJobName = value;
				}
			}

			public string DtsInstanceID
			{
				get
				{
					return dtsInstanceID;
				}
				set	
				{
					dtsInstanceID = value;
				}
			}

			public string DtsJobDirection
			{
				get
				{
					return dtsJobDirection;
				}
				set	
				{
					dtsJobDirection = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string SourceEndpoint
			{
				get
				{
					return sourceEndpoint;
				}
				set	
				{
					sourceEndpoint = value;
				}
			}

			public string DestinationEndpoint
			{
				get
				{
					return destinationEndpoint;
				}
				set	
				{
					destinationEndpoint = value;
				}
			}
		}

		public class DescribeDBClusterMigration_DstDtsJob
		{

			private string dtsJobId;

			private string dtsJobName;

			private string dtsInstanceId;

			private string dtsJobDirection;

			private string status;

			private string sourceEndpoint;

			private string destinationEndpoint;

			public string DtsJobId
			{
				get
				{
					return dtsJobId;
				}
				set	
				{
					dtsJobId = value;
				}
			}

			public string DtsJobName
			{
				get
				{
					return dtsJobName;
				}
				set	
				{
					dtsJobName = value;
				}
			}

			public string DtsInstanceId
			{
				get
				{
					return dtsInstanceId;
				}
				set	
				{
					dtsInstanceId = value;
				}
			}

			public string DtsJobDirection
			{
				get
				{
					return dtsJobDirection;
				}
				set	
				{
					dtsJobDirection = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string SourceEndpoint
			{
				get
				{
					return sourceEndpoint;
				}
				set	
				{
					sourceEndpoint = value;
				}
			}

			public string DestinationEndpoint
			{
				get
				{
					return destinationEndpoint;
				}
				set	
				{
					destinationEndpoint = value;
				}
			}
		}
	}
}
