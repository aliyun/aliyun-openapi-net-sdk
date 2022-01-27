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
	public class DescribeSynchronizationJobsResponse : AcsResponse
	{

		private int? pageNumber;

		private int? pageRecordCount;

		private string requestId;

		private long? totalRecordCount;

		private List<DescribeSynchronizationJobs_SynchronizationInstance> synchronizationInstances;

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

		public List<DescribeSynchronizationJobs_SynchronizationInstance> SynchronizationInstances
		{
			get
			{
				return synchronizationInstances;
			}
			set	
			{
				synchronizationInstances = value;
			}
		}

		public class DescribeSynchronizationJobs_SynchronizationInstance
		{

			private string createTime;

			private string dataInitialization;

			private string delay;

			private string errorMessage;

			private string expireTime;

			private string payType;

			private string status;

			private string structureInitialization;

			private string synchronizationDirection;

			private string synchronizationJobClass;

			private string synchronizationJobId;

			private string synchronizationJobName;

			private string jobCreateTime;

			private string instanceCreateTime;

			private List<DescribeSynchronizationJobs_Tag> tags;

			private List<DescribeSynchronizationJobs_SynchronizationObject> synchronizationObjects;

			private DescribeSynchronizationJobs_DataInitializationStatus dataInitializationStatus;

			private DescribeSynchronizationJobs_DataSynchronizationStatus dataSynchronizationStatus;

			private DescribeSynchronizationJobs_DestinationEndpoint destinationEndpoint;

			private DescribeSynchronizationJobs_Performance performance;

			private DescribeSynchronizationJobs_PrecheckStatus precheckStatus;

			private DescribeSynchronizationJobs_SourceEndpoint sourceEndpoint;

			private DescribeSynchronizationJobs_StructureInitializationStatus structureInitializationStatus;

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

			public List<DescribeSynchronizationJobs_Tag> Tags
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

			public List<DescribeSynchronizationJobs_SynchronizationObject> SynchronizationObjects
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

			public DescribeSynchronizationJobs_DataInitializationStatus DataInitializationStatus
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

			public DescribeSynchronizationJobs_DataSynchronizationStatus DataSynchronizationStatus
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

			public DescribeSynchronizationJobs_DestinationEndpoint DestinationEndpoint
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

			public DescribeSynchronizationJobs_Performance Performance
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

			public DescribeSynchronizationJobs_PrecheckStatus PrecheckStatus
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

			public DescribeSynchronizationJobs_SourceEndpoint SourceEndpoint
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

			public DescribeSynchronizationJobs_StructureInitializationStatus StructureInitializationStatus
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

			public class DescribeSynchronizationJobs_Tag
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

			public class DescribeSynchronizationJobs_SynchronizationObject
			{

				private string newSchemaName;

				private string schemaName;

				private List<DescribeSynchronizationJobs_TableExclude> tableExcludes;

				private List<DescribeSynchronizationJobs_TableInclude> tableIncludes;

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

				public List<DescribeSynchronizationJobs_TableExclude> TableExcludes
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

				public List<DescribeSynchronizationJobs_TableInclude> TableIncludes
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

				public class DescribeSynchronizationJobs_TableExclude
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

				public class DescribeSynchronizationJobs_TableInclude
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

			public class DescribeSynchronizationJobs_DataInitializationStatus
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

			public class DescribeSynchronizationJobs_DataSynchronizationStatus
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

			public class DescribeSynchronizationJobs_DestinationEndpoint
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

			public class DescribeSynchronizationJobs_Performance
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

			public class DescribeSynchronizationJobs_PrecheckStatus
			{

				private string percent;

				private string status;

				private List<DescribeSynchronizationJobs_CheckItem> detail;

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

				public List<DescribeSynchronizationJobs_CheckItem> Detail
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

				public class DescribeSynchronizationJobs_CheckItem
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

			public class DescribeSynchronizationJobs_SourceEndpoint
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

			public class DescribeSynchronizationJobs_StructureInitializationStatus
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
