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

		private string requestId;

		private bool? success;

		private string errCode;

		private string errMessage;

		private string dynamicCode;

		private string dynamicMessage;

		private int? httpStatusCode;

		private int? pageNumber;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private List<DescribeDtsJobs_DtsJobStatus> dtsJobList;

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

			private string dtsInstanceID;

			private string dtsJobId;

			private string dtsJobName;

			private string dtsJobClass;

			private string dtsJobDirection;

			private string payType;

			private string expireTime;

			private string createTime;

			private string status;

			private string errorMessage;

			private int? delay;

			private string checkpoint;

			private string dbObject;

			private string reserved;

			private List<DescribeDtsJobs_DtsTag> tagList;

			private DescribeDtsJobs_SourceEndpoint sourceEndpoint;

			private DescribeDtsJobs_DestinationEndpoint destinationEndpoint;

			private DescribeDtsJobs_MigrationMode migrationMode;

			private DescribeDtsJobs_PrecheckStatus precheckStatus;

			private DescribeDtsJobs_StructureInitializationStatus structureInitializationStatus;

			private DescribeDtsJobs_DataInitializationStatus dataInitializationStatus;

			private DescribeDtsJobs_DataSynchronizationStatus dataSynchronizationStatus;

			private DescribeDtsJobs_Performance performance;

			private DescribeDtsJobs_ReverseJob reverseJob;

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

			public class DescribeDtsJobs_SourceEndpoint
			{

				private string instanceID;

				private string instanceType;

				private string engineName;

				private string ip;

				private string port;

				private string databaseName;

				private string oracleSID;

				private string userName;

				private string sslSolutionEnum;

				private string region;

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
			}

			public class DescribeDtsJobs_DestinationEndpoint
			{

				private string instanceID;

				private string instanceType;

				private string engineName;

				private string ip;

				private string port;

				private string databaseName;

				private string oracleSID;

				private string userName;

				private string sslSolutionEnum;

				private string region;

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
			}

			public class DescribeDtsJobs_MigrationMode
			{

				private bool? structureInitialization;

				private bool? dataInitialization;

				private bool? dataSynchronization;

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
			}

			public class DescribeDtsJobs_PrecheckStatus
			{

				private string status;

				private string percent;

				private string errorMessage;

				private List<DescribeDtsJobs_PrecheckDetail> detail;

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

			public class DescribeDtsJobs_StructureInitializationStatus
			{

				private string status;

				private string errorMessage;

				private string percent;

				private string progress;

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
			}

			public class DescribeDtsJobs_DataInitializationStatus
			{

				private string status;

				private string errorMessage;

				private string percent;

				private string progress;

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
			}

			public class DescribeDtsJobs_DataSynchronizationStatus
			{

				private string status;

				private string errorMessage;

				private string percent;

				private string progress;

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
			}

			public class DescribeDtsJobs_Performance
			{

				private string rps;

				private string flow;

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
			}

			public class DescribeDtsJobs_ReverseJob
			{

				private string dtsInstanceID;

				private string dtsJobId;

				private string dtsJobName;

				private string dtsJobClass;

				private string dtsJobDirection;

				private string payType;

				private string expireTime;

				private string createTime;

				private string status;

				private string errorMessage;

				private int? delay;

				private string checkpoint;

				private string dbObject;

				private string reserved;

				private DescribeDtsJobs_SourceEndpoint1 sourceEndpoint1;

				private DescribeDtsJobs_DestinationEndpoint2 destinationEndpoint2;

				private DescribeDtsJobs_MigrationMode3 migrationMode3;

				private DescribeDtsJobs_PrecheckStatus4 precheckStatus4;

				private DescribeDtsJobs_StructureInitializationStatus5 structureInitializationStatus5;

				private DescribeDtsJobs_DataInitializationStatus6 dataInitializationStatus6;

				private DescribeDtsJobs_DataSynchronizationStatus7 dataSynchronizationStatus7;

				private DescribeDtsJobs_Performance8 performance8;

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

				public DescribeDtsJobs_SourceEndpoint1 SourceEndpoint1
				{
					get
					{
						return sourceEndpoint1;
					}
					set	
					{
						sourceEndpoint1 = value;
					}
				}

				public DescribeDtsJobs_DestinationEndpoint2 DestinationEndpoint2
				{
					get
					{
						return destinationEndpoint2;
					}
					set	
					{
						destinationEndpoint2 = value;
					}
				}

				public DescribeDtsJobs_MigrationMode3 MigrationMode3
				{
					get
					{
						return migrationMode3;
					}
					set	
					{
						migrationMode3 = value;
					}
				}

				public DescribeDtsJobs_PrecheckStatus4 PrecheckStatus4
				{
					get
					{
						return precheckStatus4;
					}
					set	
					{
						precheckStatus4 = value;
					}
				}

				public DescribeDtsJobs_StructureInitializationStatus5 StructureInitializationStatus5
				{
					get
					{
						return structureInitializationStatus5;
					}
					set	
					{
						structureInitializationStatus5 = value;
					}
				}

				public DescribeDtsJobs_DataInitializationStatus6 DataInitializationStatus6
				{
					get
					{
						return dataInitializationStatus6;
					}
					set	
					{
						dataInitializationStatus6 = value;
					}
				}

				public DescribeDtsJobs_DataSynchronizationStatus7 DataSynchronizationStatus7
				{
					get
					{
						return dataSynchronizationStatus7;
					}
					set	
					{
						dataSynchronizationStatus7 = value;
					}
				}

				public DescribeDtsJobs_Performance8 Performance8
				{
					get
					{
						return performance8;
					}
					set	
					{
						performance8 = value;
					}
				}

				public class DescribeDtsJobs_SourceEndpoint1
				{

					private string instanceID;

					private string instanceType;

					private string engineName;

					private string ip;

					private string port;

					private string databaseName;

					private string oracleSID;

					private string userName;

					private string sslSolutionEnum;

					private string region;

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
				}

				public class DescribeDtsJobs_DestinationEndpoint2
				{

					private string instanceID;

					private string instanceType;

					private string engineName;

					private string ip;

					private string port;

					private string databaseName;

					private string oracleSID;

					private string userName;

					private string sslSolutionEnum;

					private string region;

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
				}

				public class DescribeDtsJobs_MigrationMode3
				{

					private bool? structureInitialization;

					private bool? dataInitialization;

					private bool? dataSynchronization;

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
				}

				public class DescribeDtsJobs_PrecheckStatus4
				{

					private string status;

					private string percent;

					private string errorMessage;

					private List<DescribeDtsJobs_PrecheckDetail10> detail9;

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

				public class DescribeDtsJobs_StructureInitializationStatus5
				{

					private string status;

					private string errorMessage;

					private string percent;

					private string progress;

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
				}

				public class DescribeDtsJobs_DataInitializationStatus6
				{

					private string status;

					private string errorMessage;

					private string percent;

					private string progress;

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
				}

				public class DescribeDtsJobs_DataSynchronizationStatus7
				{

					private string status;

					private string errorMessage;

					private string percent;

					private string progress;

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
				}

				public class DescribeDtsJobs_Performance8
				{

					private string rps;

					private string flow;

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
				}
			}
		}
	}
}
