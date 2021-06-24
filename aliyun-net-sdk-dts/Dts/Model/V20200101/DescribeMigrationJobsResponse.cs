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

namespace Aliyun.Acs.Dts.Model.V20200101
{
	public class DescribeMigrationJobsResponse : AcsResponse
	{

		private string errCode;

		private string errMessage;

		private int? pageNumber;

		private int? pageRecordCount;

		private string requestId;

		private string success;

		private long? totalRecordCount;

		private List<DescribeMigrationJobs_MigrationJob> migrationJobs;

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
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

		public string Success
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

		public long? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public List<DescribeMigrationJobs_MigrationJob> MigrationJobs
		{
			get
			{
				return migrationJobs;
			}
			set	
			{
				migrationJobs = value;
			}
		}

		public class DescribeMigrationJobs_MigrationJob
		{

			private string migrationJobClass;

			private string migrationJobID;

			private string migrationJobName;

			private string migrationJobStatus;

			private string payType;

			private string jobCreateTime;

			private string instanceCreateTime;

			private List<DescribeMigrationJobs_SynchronousObject> migrationObject;

			private List<DescribeMigrationJobs_Tag> tags;

			private DescribeMigrationJobs_DataInitialization dataInitialization;

			private DescribeMigrationJobs_DataSynchronization dataSynchronization;

			private DescribeMigrationJobs_DestinationEndpoint destinationEndpoint;

			private DescribeMigrationJobs_MigrationMode migrationMode;

			private DescribeMigrationJobs_Precheck precheck;

			private DescribeMigrationJobs_SourceEndpoint sourceEndpoint;

			private DescribeMigrationJobs_StructureInitialization structureInitialization;

			public string MigrationJobClass
			{
				get
				{
					return migrationJobClass;
				}
				set	
				{
					migrationJobClass = value;
				}
			}

			public string MigrationJobID
			{
				get
				{
					return migrationJobID;
				}
				set	
				{
					migrationJobID = value;
				}
			}

			public string MigrationJobName
			{
				get
				{
					return migrationJobName;
				}
				set	
				{
					migrationJobName = value;
				}
			}

			public string MigrationJobStatus
			{
				get
				{
					return migrationJobStatus;
				}
				set	
				{
					migrationJobStatus = value;
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

			public string JobCreateTime
			{
				get
				{
					return jobCreateTime;
				}
				set	
				{
					jobCreateTime = value;
				}
			}

			public string InstanceCreateTime
			{
				get
				{
					return instanceCreateTime;
				}
				set	
				{
					instanceCreateTime = value;
				}
			}

			public List<DescribeMigrationJobs_SynchronousObject> MigrationObject
			{
				get
				{
					return migrationObject;
				}
				set	
				{
					migrationObject = value;
				}
			}

			public List<DescribeMigrationJobs_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public DescribeMigrationJobs_DataInitialization DataInitialization
			{
				get
				{
					return dataInitialization;
				}
				set	
				{
					dataInitialization = value;
				}
			}

			public DescribeMigrationJobs_DataSynchronization DataSynchronization
			{
				get
				{
					return dataSynchronization;
				}
				set	
				{
					dataSynchronization = value;
				}
			}

			public DescribeMigrationJobs_DestinationEndpoint DestinationEndpoint
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

			public DescribeMigrationJobs_MigrationMode MigrationMode
			{
				get
				{
					return migrationMode;
				}
				set	
				{
					migrationMode = value;
				}
			}

			public DescribeMigrationJobs_Precheck Precheck
			{
				get
				{
					return precheck;
				}
				set	
				{
					precheck = value;
				}
			}

			public DescribeMigrationJobs_SourceEndpoint SourceEndpoint
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

			public DescribeMigrationJobs_StructureInitialization StructureInitialization
			{
				get
				{
					return structureInitialization;
				}
				set	
				{
					structureInitialization = value;
				}
			}

			public class DescribeMigrationJobs_SynchronousObject
			{

				private string databaseName;

				private string wholeDatabase;

				private List<string> tableList;

				public string DatabaseName
				{
					get
					{
						return databaseName;
					}
					set	
					{
						databaseName = value;
					}
				}

				public string WholeDatabase
				{
					get
					{
						return wholeDatabase;
					}
					set	
					{
						wholeDatabase = value;
					}
				}

				public List<string> TableList
				{
					get
					{
						return tableList;
					}
					set	
					{
						tableList = value;
					}
				}
			}

			public class DescribeMigrationJobs_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeMigrationJobs_DataInitialization
			{

				private string errorMessage;

				private string percent;

				private string progress;

				private string status;

				public string ErrorMessage
				{
					get
					{
						return errorMessage;
					}
					set	
					{
						errorMessage = value;
					}
				}

				public string Percent
				{
					get
					{
						return percent;
					}
					set	
					{
						percent = value;
					}
				}

				public string Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
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
			}

			public class DescribeMigrationJobs_DataSynchronization
			{

				private string delay;

				private string errorMessage;

				private string percent;

				private string status;

				public string Delay
				{
					get
					{
						return delay;
					}
					set	
					{
						delay = value;
					}
				}

				public string ErrorMessage
				{
					get
					{
						return errorMessage;
					}
					set	
					{
						errorMessage = value;
					}
				}

				public string Percent
				{
					get
					{
						return percent;
					}
					set	
					{
						percent = value;
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
			}

			public class DescribeMigrationJobs_DestinationEndpoint
			{

				private string databaseName;

				private string engineName;

				private string iP;

				private string instanceID;

				private string instanceType;

				private string oracleSID;

				private string port;

				private string userName;

				public string DatabaseName
				{
					get
					{
						return databaseName;
					}
					set	
					{
						databaseName = value;
					}
				}

				public string EngineName
				{
					get
					{
						return engineName;
					}
					set	
					{
						engineName = value;
					}
				}

				public string IP
				{
					get
					{
						return iP;
					}
					set	
					{
						iP = value;
					}
				}

				public string InstanceID
				{
					get
					{
						return instanceID;
					}
					set	
					{
						instanceID = value;
					}
				}

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}

				public string OracleSID
				{
					get
					{
						return oracleSID;
					}
					set	
					{
						oracleSID = value;
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

				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
					}
				}
			}

			public class DescribeMigrationJobs_MigrationMode
			{

				private bool? dataInitialization;

				private bool? dataSynchronization;

				private bool? structureInitialization;

				public bool? DataInitialization
				{
					get
					{
						return dataInitialization;
					}
					set	
					{
						dataInitialization = value;
					}
				}

				public bool? DataSynchronization
				{
					get
					{
						return dataSynchronization;
					}
					set	
					{
						dataSynchronization = value;
					}
				}

				public bool? StructureInitialization
				{
					get
					{
						return structureInitialization;
					}
					set	
					{
						structureInitialization = value;
					}
				}
			}

			public class DescribeMigrationJobs_Precheck
			{

				private string percent;

				private string status;

				public string Percent
				{
					get
					{
						return percent;
					}
					set	
					{
						percent = value;
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
			}

			public class DescribeMigrationJobs_SourceEndpoint
			{

				private string databaseName;

				private string engineName;

				private string iP;

				private string instanceID;

				private string instanceType;

				private string oracleSID;

				private string port;

				private string userName;

				public string DatabaseName
				{
					get
					{
						return databaseName;
					}
					set	
					{
						databaseName = value;
					}
				}

				public string EngineName
				{
					get
					{
						return engineName;
					}
					set	
					{
						engineName = value;
					}
				}

				public string IP
				{
					get
					{
						return iP;
					}
					set	
					{
						iP = value;
					}
				}

				public string InstanceID
				{
					get
					{
						return instanceID;
					}
					set	
					{
						instanceID = value;
					}
				}

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}

				public string OracleSID
				{
					get
					{
						return oracleSID;
					}
					set	
					{
						oracleSID = value;
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

				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
					}
				}
			}

			public class DescribeMigrationJobs_StructureInitialization
			{

				private string errorMessage;

				private string percent;

				private string progress;

				private string status;

				public string ErrorMessage
				{
					get
					{
						return errorMessage;
					}
					set	
					{
						errorMessage = value;
					}
				}

				public string Percent
				{
					get
					{
						return percent;
					}
					set	
					{
						percent = value;
					}
				}

				public string Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
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
			}
		}
	}
}
