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
	public class DescribeDtsJobsResponse : AcsResponse
	{

		private string dynamicCode;

		private string dynamicMessage;

		private string errCode;

		private string errMessage;

		private int? httpStatusCode;

		private int? pageNumber;

		private int? pageRecordCount;

		private string requestId;

		private bool? success;

		private int? totalRecordCount;

		private List<DescribeDtsJobs_DtsJobStatus> dtsJobList;

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public bool? Success
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

		public int? TotalRecordCount
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

		public List<DescribeDtsJobs_DtsJobStatus> DtsJobList
		{
			get
			{
				return dtsJobList;
			}
			set	
			{
				dtsJobList = value;
			}
		}

		public class DescribeDtsJobs_DtsJobStatus
		{

			private string checkpoint;

			private string createTime;

			private string dbObject;

			private int? delay;

			private string dtsInstanceID;

			private string dtsJobClass;

			private string dtsJobDirection;

			private string dtsJobId;

			private string dtsJobName;

			private string errorMessage;

			private string expireTime;

			private string payType;

			private string reserved;

			private string status;

			private string consumptionClient;

			private string beginTimestamp;

			private string endTimestamp;

			private string consumptionCheckpoint;

			private string appName;

			private List<DescribeDtsJobs_DtsTag> tagList;

			private DescribeDtsJobs_DataInitializationStatus dataInitializationStatus;

			private DescribeDtsJobs_DataSynchronizationStatus dataSynchronizationStatus;

			private DescribeDtsJobs_DataEtlStatus dataEtlStatus;

			private DescribeDtsJobs_DestinationEndpoint destinationEndpoint;

			private DescribeDtsJobs_MigrationMode migrationMode;

			private DescribeDtsJobs_Performance performance;

			private DescribeDtsJobs_PrecheckStatus precheckStatus;

			private DescribeDtsJobs_ReverseJob reverseJob;

			private DescribeDtsJobs_SourceEndpoint sourceEndpoint;

			private DescribeDtsJobs_StructureInitializationStatus structureInitializationStatus;

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

			public string DbObject
			{
				get
				{
					return dbObject;
				}
				set	
				{
					dbObject = value;
				}
			}

			public int? Delay
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

			public string DtsJobClass
			{
				get
				{
					return dtsJobClass;
				}
				set	
				{
					dtsJobClass = value;
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

			public string Reserved
			{
				get
				{
					return reserved;
				}
				set	
				{
					reserved = value;
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

			public string ConsumptionClient
			{
				get
				{
					return consumptionClient;
				}
				set	
				{
					consumptionClient = value;
				}
			}

			public string BeginTimestamp
			{
				get
				{
					return beginTimestamp;
				}
				set	
				{
					beginTimestamp = value;
				}
			}

			public string EndTimestamp
			{
				get
				{
					return endTimestamp;
				}
				set	
				{
					endTimestamp = value;
				}
			}

			public string ConsumptionCheckpoint
			{
				get
				{
					return consumptionCheckpoint;
				}
				set	
				{
					consumptionCheckpoint = value;
				}
			}

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public List<DescribeDtsJobs_DtsTag> TagList
			{
				get
				{
					return tagList;
				}
				set	
				{
					tagList = value;
				}
			}

			public DescribeDtsJobs_DataInitializationStatus DataInitializationStatus
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

			public DescribeDtsJobs_DataSynchronizationStatus DataSynchronizationStatus
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

			public DescribeDtsJobs_DataEtlStatus DataEtlStatus
			{
				get
				{
					return dataEtlStatus;
				}
				set	
				{
					dataEtlStatus = value;
				}
			}

			public DescribeDtsJobs_DestinationEndpoint DestinationEndpoint
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

			public DescribeDtsJobs_MigrationMode MigrationMode
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

			public DescribeDtsJobs_Performance Performance
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

			public DescribeDtsJobs_PrecheckStatus PrecheckStatus
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

			public DescribeDtsJobs_ReverseJob ReverseJob
			{
				get
				{
					return reverseJob;
				}
				set	
				{
					reverseJob = value;
				}
			}

			public DescribeDtsJobs_SourceEndpoint SourceEndpoint
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

			public DescribeDtsJobs_StructureInitializationStatus StructureInitializationStatus
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

			public class DescribeDtsJobs_DtsTag
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}

			public class DescribeDtsJobs_DataInitializationStatus
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

			public class DescribeDtsJobs_DataSynchronizationStatus
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

			public class DescribeDtsJobs_DataEtlStatus
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

			public class DescribeDtsJobs_DestinationEndpoint
			{

				private string databaseName;

				private string engineName;

				private string instanceID;

				private string instanceType;

				private string ip;

				private string oracleSID;

				private string port;

				private string region;

				private string sslSolutionEnum;

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

				public string Ip
				{
					get
					{
						return ip;
					}
					set	
					{
						ip = value;
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

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public string SslSolutionEnum
				{
					get
					{
						return sslSolutionEnum;
					}
					set	
					{
						sslSolutionEnum = value;
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

			public class DescribeDtsJobs_MigrationMode
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

			public class DescribeDtsJobs_Performance
			{

				private string flow;

				private string rps;

				public string Flow
				{
					get
					{
						return flow;
					}
					set	
					{
						flow = value;
					}
				}

				public string Rps
				{
					get
					{
						return rps;
					}
					set	
					{
						rps = value;
					}
				}
			}

			public class DescribeDtsJobs_PrecheckStatus
			{

				private string errorMessage;

				private string percent;

				private string status;

				private List<DescribeDtsJobs_PrecheckDetail> detail;

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

				public List<DescribeDtsJobs_PrecheckDetail> Detail
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

				public class DescribeDtsJobs_PrecheckDetail
				{

					private string checkItem;

					private string checkItemDescription;

					private string checkResult;

					private string failedReason;

					private string repairMethod;

					public string CheckItem
					{
						get
						{
							return checkItem;
						}
						set	
						{
							checkItem = value;
						}
					}

					public string CheckItemDescription
					{
						get
						{
							return checkItemDescription;
						}
						set	
						{
							checkItemDescription = value;
						}
					}

					public string CheckResult
					{
						get
						{
							return checkResult;
						}
						set	
						{
							checkResult = value;
						}
					}

					public string FailedReason
					{
						get
						{
							return failedReason;
						}
						set	
						{
							failedReason = value;
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

			public class DescribeDtsJobs_ReverseJob
			{

				private string checkpoint;

				private string createTime;

				private string dbObject;

				private int? delay;

				private string dtsInstanceID;

				private string dtsJobClass;

				private string dtsJobDirection;

				private string dtsJobId;

				private string dtsJobName;

				private string errorMessage;

				private string expireTime;

				private string payType;

				private string reserved;

				private string status;

				private DescribeDtsJobs_DataInitializationStatus1 dataInitializationStatus1;

				private DescribeDtsJobs_DataSynchronizationStatus2 dataSynchronizationStatus2;

				private DescribeDtsJobs_DestinationEndpoint3 destinationEndpoint3;

				private DescribeDtsJobs_MigrationMode4 migrationMode4;

				private DescribeDtsJobs_Performance5 performance5;

				private DescribeDtsJobs_PrecheckStatus6 precheckStatus6;

				private DescribeDtsJobs_SourceEndpoint7 sourceEndpoint7;

				private DescribeDtsJobs_StructureInitializationStatus8 structureInitializationStatus8;

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

				public string DbObject
				{
					get
					{
						return dbObject;
					}
					set	
					{
						dbObject = value;
					}
				}

				public int? Delay
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

				public string DtsJobClass
				{
					get
					{
						return dtsJobClass;
					}
					set	
					{
						dtsJobClass = value;
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

				public string Reserved
				{
					get
					{
						return reserved;
					}
					set	
					{
						reserved = value;
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

				public DescribeDtsJobs_DataInitializationStatus1 DataInitializationStatus1
				{
					get
					{
						return dataInitializationStatus1;
					}
					set	
					{
						dataInitializationStatus1 = value;
					}
				}

				public DescribeDtsJobs_DataSynchronizationStatus2 DataSynchronizationStatus2
				{
					get
					{
						return dataSynchronizationStatus2;
					}
					set	
					{
						dataSynchronizationStatus2 = value;
					}
				}

				public DescribeDtsJobs_DestinationEndpoint3 DestinationEndpoint3
				{
					get
					{
						return destinationEndpoint3;
					}
					set	
					{
						destinationEndpoint3 = value;
					}
				}

				public DescribeDtsJobs_MigrationMode4 MigrationMode4
				{
					get
					{
						return migrationMode4;
					}
					set	
					{
						migrationMode4 = value;
					}
				}

				public DescribeDtsJobs_Performance5 Performance5
				{
					get
					{
						return performance5;
					}
					set	
					{
						performance5 = value;
					}
				}

				public DescribeDtsJobs_PrecheckStatus6 PrecheckStatus6
				{
					get
					{
						return precheckStatus6;
					}
					set	
					{
						precheckStatus6 = value;
					}
				}

				public DescribeDtsJobs_SourceEndpoint7 SourceEndpoint7
				{
					get
					{
						return sourceEndpoint7;
					}
					set	
					{
						sourceEndpoint7 = value;
					}
				}

				public DescribeDtsJobs_StructureInitializationStatus8 StructureInitializationStatus8
				{
					get
					{
						return structureInitializationStatus8;
					}
					set	
					{
						structureInitializationStatus8 = value;
					}
				}

				public class DescribeDtsJobs_DataInitializationStatus1
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

				public class DescribeDtsJobs_DataSynchronizationStatus2
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

				public class DescribeDtsJobs_DestinationEndpoint3
				{

					private string databaseName;

					private string engineName;

					private string instanceID;

					private string instanceType;

					private string ip;

					private string oracleSID;

					private string port;

					private string region;

					private string sslSolutionEnum;

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

					public string Ip
					{
						get
						{
							return ip;
						}
						set	
						{
							ip = value;
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

					public string Region
					{
						get
						{
							return region;
						}
						set	
						{
							region = value;
						}
					}

					public string SslSolutionEnum
					{
						get
						{
							return sslSolutionEnum;
						}
						set	
						{
							sslSolutionEnum = value;
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

				public class DescribeDtsJobs_MigrationMode4
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

				public class DescribeDtsJobs_Performance5
				{

					private string flow;

					private string rps;

					public string Flow
					{
						get
						{
							return flow;
						}
						set	
						{
							flow = value;
						}
					}

					public string Rps
					{
						get
						{
							return rps;
						}
						set	
						{
							rps = value;
						}
					}
				}

				public class DescribeDtsJobs_PrecheckStatus6
				{

					private string errorMessage;

					private string percent;

					private string status;

					private List<DescribeDtsJobs_PrecheckDetail10> detail9;

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

					public List<DescribeDtsJobs_PrecheckDetail10> Detail9
					{
						get
						{
							return detail9;
						}
						set	
						{
							detail9 = value;
						}
					}

					public class DescribeDtsJobs_PrecheckDetail10
					{

						private string checkItem;

						private string checkItemDescription;

						private string checkResult;

						private string failedReason;

						private string repairMethod;

						public string CheckItem
						{
							get
							{
								return checkItem;
							}
							set	
							{
								checkItem = value;
							}
						}

						public string CheckItemDescription
						{
							get
							{
								return checkItemDescription;
							}
							set	
							{
								checkItemDescription = value;
							}
						}

						public string CheckResult
						{
							get
							{
								return checkResult;
							}
							set	
							{
								checkResult = value;
							}
						}

						public string FailedReason
						{
							get
							{
								return failedReason;
							}
							set	
							{
								failedReason = value;
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

				public class DescribeDtsJobs_SourceEndpoint7
				{

					private string databaseName;

					private string engineName;

					private string instanceID;

					private string instanceType;

					private string ip;

					private string oracleSID;

					private string port;

					private string region;

					private string sslSolutionEnum;

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

					public string Ip
					{
						get
						{
							return ip;
						}
						set	
						{
							ip = value;
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

					public string Region
					{
						get
						{
							return region;
						}
						set	
						{
							region = value;
						}
					}

					public string SslSolutionEnum
					{
						get
						{
							return sslSolutionEnum;
						}
						set	
						{
							sslSolutionEnum = value;
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

				public class DescribeDtsJobs_StructureInitializationStatus8
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

			public class DescribeDtsJobs_SourceEndpoint
			{

				private string databaseName;

				private string engineName;

				private string instanceID;

				private string instanceType;

				private string ip;

				private string oracleSID;

				private string port;

				private string region;

				private string sslSolutionEnum;

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

				public string Ip
				{
					get
					{
						return ip;
					}
					set	
					{
						ip = value;
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

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public string SslSolutionEnum
				{
					get
					{
						return sslSolutionEnum;
					}
					set	
					{
						sslSolutionEnum = value;
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

			public class DescribeDtsJobs_StructureInitializationStatus
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
