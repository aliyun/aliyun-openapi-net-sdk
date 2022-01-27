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
	public class DescribeMigrationJobStatusResponse : AcsResponse
	{

		private string errCode;

		private string errMessage;

		private string migrationJobClass;

		private string migrationJobId;

		private string migrationJobName;

		private string migrationJobStatus;

		private string migrationObject;

		private string payType;

		private string requestId;

		private string success;

		private string taskId;

		private DescribeMigrationJobStatus_DataInitializationStatus dataInitializationStatus;

		private DescribeMigrationJobStatus_DataSynchronizationStatus dataSynchronizationStatus;

		private DescribeMigrationJobStatus_DestinationEndpoint destinationEndpoint;

		private DescribeMigrationJobStatus_MigrationMode migrationMode;

		private DescribeMigrationJobStatus_PrecheckStatus precheckStatus;

		private DescribeMigrationJobStatus_SourceEndpoint sourceEndpoint;

		private DescribeMigrationJobStatus_StructureInitializationStatus structureInitializationStatus;

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

		public string MigrationJobId
		{
			get
			{
				return migrationJobId;
			}
			set	
			{
				migrationJobId = value;
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

		public string MigrationObject
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

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
			}
		}

		public DescribeMigrationJobStatus_DataInitializationStatus DataInitializationStatus
		{
			get
			{
				return dataInitializationStatus;
			}
			set	
			{
				dataInitializationStatus = value;
			}
		}

		public DescribeMigrationJobStatus_DataSynchronizationStatus DataSynchronizationStatus
		{
			get
			{
				return dataSynchronizationStatus;
			}
			set	
			{
				dataSynchronizationStatus = value;
			}
		}

		public DescribeMigrationJobStatus_DestinationEndpoint DestinationEndpoint
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

		public DescribeMigrationJobStatus_MigrationMode MigrationMode
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

		public DescribeMigrationJobStatus_PrecheckStatus PrecheckStatus
		{
			get
			{
				return precheckStatus;
			}
			set	
			{
				precheckStatus = value;
			}
		}

		public DescribeMigrationJobStatus_SourceEndpoint SourceEndpoint
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

		public DescribeMigrationJobStatus_StructureInitializationStatus StructureInitializationStatus
		{
			get
			{
				return structureInitializationStatus;
			}
			set	
			{
				structureInitializationStatus = value;
			}
		}

		public class DescribeMigrationJobStatus_DataInitializationStatus
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

		public class DescribeMigrationJobStatus_DataSynchronizationStatus
		{

			private string checkpoint;

			private string delay;

			private string errorMessage;

			private string percent;

			private string status;

			public string Checkpoint
			{
				get
				{
					return checkpoint;
				}
				set	
				{
					checkpoint = value;
				}
			}

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

		public class DescribeMigrationJobStatus_DestinationEndpoint
		{

			private string databaseName;

			private string engineName;

			private string iP;

			private string instanceId;

			private string instanceType;

			private string port;

			private string userName;

			private string oracleSID;

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

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
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
		}

		public class DescribeMigrationJobStatus_MigrationMode
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

		public class DescribeMigrationJobStatus_PrecheckStatus
		{

			private string percent;

			private string status;

			private List<DescribeMigrationJobStatus_CheckItem> detail;

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

			public List<DescribeMigrationJobStatus_CheckItem> Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public class DescribeMigrationJobStatus_CheckItem
			{

				private string checkStatus;

				private string errorMessage;

				private string itemName;

				private string repairMethod;

				public string CheckStatus
				{
					get
					{
						return checkStatus;
					}
					set	
					{
						checkStatus = value;
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

				public string ItemName
				{
					get
					{
						return itemName;
					}
					set	
					{
						itemName = value;
					}
				}

				public string RepairMethod
				{
					get
					{
						return repairMethod;
					}
					set	
					{
						repairMethod = value;
					}
				}
			}
		}

		public class DescribeMigrationJobStatus_SourceEndpoint
		{

			private string databaseName;

			private string engineName;

			private string iP;

			private string instanceId;

			private string instanceType;

			private string port;

			private string userName;

			private string oracleSID;

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

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
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
		}

		public class DescribeMigrationJobStatus_StructureInitializationStatus
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
