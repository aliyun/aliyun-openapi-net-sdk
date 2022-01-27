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
	public class DescribeSynchronizationJobStatusResponse : AcsResponse
	{

		private string checkpoint;

		private string dataInitialization;

		private string delay;

		private long? delayMillis;

		private string errCode;

		private string errMessage;

		private string errorMessage;

		private string expireTime;

		private string payType;

		private string requestId;

		private string status;

		private string structureInitialization;

		private string success;

		private string synchronizationDirection;

		private string synchronizationJobClass;

		private string synchronizationJobId;

		private string synchronizationJobName;

		private string taskId;

		private List<DescribeSynchronizationJobStatus_SynchronizationObject> synchronizationObjects;

		private DescribeSynchronizationJobStatus_DataInitializationStatus dataInitializationStatus;

		private DescribeSynchronizationJobStatus_DataSynchronizationStatus dataSynchronizationStatus;

		private DescribeSynchronizationJobStatus_DestinationEndpoint destinationEndpoint;

		private DescribeSynchronizationJobStatus_Performance performance;

		private DescribeSynchronizationJobStatus_PrecheckStatus precheckStatus;

		private DescribeSynchronizationJobStatus_SourceEndpoint sourceEndpoint;

		private DescribeSynchronizationJobStatus_StructureInitializationStatus structureInitializationStatus;

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

		public string DataInitialization
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

		public long? DelayMillis
		{
			get
			{
				return delayMillis;
			}
			set	
			{
				delayMillis = value;
			}
		}

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

		public string StructureInitialization
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

		public string SynchronizationDirection
		{
			get
			{
				return synchronizationDirection;
			}
			set	
			{
				synchronizationDirection = value;
			}
		}

		public string SynchronizationJobClass
		{
			get
			{
				return synchronizationJobClass;
			}
			set	
			{
				synchronizationJobClass = value;
			}
		}

		public string SynchronizationJobId
		{
			get
			{
				return synchronizationJobId;
			}
			set	
			{
				synchronizationJobId = value;
			}
		}

		public string SynchronizationJobName
		{
			get
			{
				return synchronizationJobName;
			}
			set	
			{
				synchronizationJobName = value;
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

		public List<DescribeSynchronizationJobStatus_SynchronizationObject> SynchronizationObjects
		{
			get
			{
				return synchronizationObjects;
			}
			set	
			{
				synchronizationObjects = value;
			}
		}

		public DescribeSynchronizationJobStatus_DataInitializationStatus DataInitializationStatus
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

		public DescribeSynchronizationJobStatus_DataSynchronizationStatus DataSynchronizationStatus
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

		public DescribeSynchronizationJobStatus_DestinationEndpoint DestinationEndpoint
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

		public DescribeSynchronizationJobStatus_Performance Performance
		{
			get
			{
				return performance;
			}
			set	
			{
				performance = value;
			}
		}

		public DescribeSynchronizationJobStatus_PrecheckStatus PrecheckStatus
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

		public DescribeSynchronizationJobStatus_SourceEndpoint SourceEndpoint
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

		public DescribeSynchronizationJobStatus_StructureInitializationStatus StructureInitializationStatus
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

		public class DescribeSynchronizationJobStatus_SynchronizationObject
		{

			private string newSchemaName;

			private string schemaName;

			private List<DescribeSynchronizationJobStatus_TableExclude> tableExcludes;

			private List<DescribeSynchronizationJobStatus_TableInclude> tableIncludes;

			public string NewSchemaName
			{
				get
				{
					return newSchemaName;
				}
				set	
				{
					newSchemaName = value;
				}
			}

			public string SchemaName
			{
				get
				{
					return schemaName;
				}
				set	
				{
					schemaName = value;
				}
			}

			public List<DescribeSynchronizationJobStatus_TableExclude> TableExcludes
			{
				get
				{
					return tableExcludes;
				}
				set	
				{
					tableExcludes = value;
				}
			}

			public List<DescribeSynchronizationJobStatus_TableInclude> TableIncludes
			{
				get
				{
					return tableIncludes;
				}
				set	
				{
					tableIncludes = value;
				}
			}

			public class DescribeSynchronizationJobStatus_TableExclude
			{

				private string tableName;

				public string TableName
				{
					get
					{
						return tableName;
					}
					set	
					{
						tableName = value;
					}
				}
			}

			public class DescribeSynchronizationJobStatus_TableInclude
			{

				private string tableName;

				public string TableName
				{
					get
					{
						return tableName;
					}
					set	
					{
						tableName = value;
					}
				}
			}
		}

		public class DescribeSynchronizationJobStatus_DataInitializationStatus
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

		public class DescribeSynchronizationJobStatus_DataSynchronizationStatus
		{

			private string checkpoint;

			private string delay;

			private long? delayMillis;

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

			public long? DelayMillis
			{
				get
				{
					return delayMillis;
				}
				set	
				{
					delayMillis = value;
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

		public class DescribeSynchronizationJobStatus_DestinationEndpoint
		{

			private string engineName;

			private string iP;

			private string instanceId;

			private string instanceType;

			private string port;

			private string userName;

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
		}

		public class DescribeSynchronizationJobStatus_Performance
		{

			private string fLOW;

			private string rPS;

			public string FLOW
			{
				get
				{
					return fLOW;
				}
				set	
				{
					fLOW = value;
				}
			}

			public string RPS
			{
				get
				{
					return rPS;
				}
				set	
				{
					rPS = value;
				}
			}
		}

		public class DescribeSynchronizationJobStatus_PrecheckStatus
		{

			private string percent;

			private string status;

			private List<DescribeSynchronizationJobStatus_CheckItem> detail;

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

			public List<DescribeSynchronizationJobStatus_CheckItem> Detail
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

			public class DescribeSynchronizationJobStatus_CheckItem
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

		public class DescribeSynchronizationJobStatus_SourceEndpoint
		{

			private string engineName;

			private string iP;

			private string instanceId;

			private string instanceType;

			private string port;

			private string userName;

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
		}

		public class DescribeSynchronizationJobStatus_StructureInitializationStatus
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
