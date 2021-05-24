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
	public class DescribeDtsJobDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? code;

		private string errCode;

		private string errMessage;

		private string dynamicMessage;

		private int? httpStatusCode;

		private string dtsInstanceID;

		private string dtsJobId;

		private string dtsJobName;

		private string dtsJobClass;

		private string dtsJobDirection;

		private string payType;

		private string expireTime;

		private string createTime;

		private string finishTime;

		private string status;

		private int? checkpoint;

		private int? delay;

		private string reserved;

		private string errorMessage;

		private string dbObject;

		private string synchronizationDirection;

		private string etlCalculator;

		private string groupId;

		private int? databaseCount;

		private string subscribeTopic;

		private string consumptionCheckpoint;

		private string beginTimestamp;

		private string endTimestamp;

		private string consumptionClient;

		private string appName;

		private string destNetType;

		private DescribeDtsJobDetail_SourceEndpoint sourceEndpoint;

		private DescribeDtsJobDetail_DestinationEndpoint destinationEndpoint;

		private DescribeDtsJobDetail_MigrationMode migrationMode;

		private DescribeDtsJobDetail_SubscriptionHost subscriptionHost;

		private DescribeDtsJobDetail_SubscriptionDataType subscriptionDataType;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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

		public string FinishTime
		{
			get
			{
				return finishTime;
			}
			set	
			{
				finishTime = value;
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

		public int? Checkpoint
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

		public string EtlCalculator
		{
			get
			{
				return etlCalculator;
			}
			set	
			{
				etlCalculator = value;
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
			}
		}

		public int? DatabaseCount
		{
			get
			{
				return databaseCount;
			}
			set	
			{
				databaseCount = value;
			}
		}

		public string SubscribeTopic
		{
			get
			{
				return subscribeTopic;
			}
			set	
			{
				subscribeTopic = value;
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

		public string DestNetType
		{
			get
			{
				return destNetType;
			}
			set	
			{
				destNetType = value;
			}
		}

		public DescribeDtsJobDetail_SourceEndpoint SourceEndpoint
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

		public DescribeDtsJobDetail_DestinationEndpoint DestinationEndpoint
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

		public DescribeDtsJobDetail_MigrationMode MigrationMode
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

		public DescribeDtsJobDetail_SubscriptionHost SubscriptionHost
		{
			get
			{
				return subscriptionHost;
			}
			set	
			{
				subscriptionHost = value;
			}
		}

		public DescribeDtsJobDetail_SubscriptionDataType SubscriptionDataType
		{
			get
			{
				return subscriptionDataType;
			}
			set	
			{
				subscriptionDataType = value;
			}
		}

		public class DescribeDtsJobDetail_SourceEndpoint
		{

			private string instanceID;

			private string region;

			private string instanceType;

			private string engineName;

			private string ip;

			private string port;

			private string databaseName;

			private string oracleSID;

			private string userName;

			private string sslSolutionEnum;

			private string roleName;

			private string aliyunUid;

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

			public string RoleName
			{
				get
				{
					return roleName;
				}
				set	
				{
					roleName = value;
				}
			}

			public string AliyunUid
			{
				get
				{
					return aliyunUid;
				}
				set	
				{
					aliyunUid = value;
				}
			}
		}

		public class DescribeDtsJobDetail_DestinationEndpoint
		{

			private string instanceID;

			private string region;

			private string instanceType;

			private string engineName;

			private string ip;

			private string port;

			private string databaseName;

			private string oracleSID;

			private string userName;

			private string sslSolutionEnum;

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
		}

		public class DescribeDtsJobDetail_MigrationMode
		{

			private bool? structureInitialization;

			private bool? dataInitialization;

			private bool? dataSynchronization;

			private bool? dataExtractTransformLoad;

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

			public bool? DataExtractTransformLoad
			{
				get
				{
					return dataExtractTransformLoad;
				}
				set	
				{
					dataExtractTransformLoad = value;
				}
			}
		}

		public class DescribeDtsJobDetail_SubscriptionHost
		{

			private string publicHost;

			private string privateHost;

			private string vpcHost;

			public string PublicHost
			{
				get
				{
					return publicHost;
				}
				set	
				{
					publicHost = value;
				}
			}

			public string PrivateHost
			{
				get
				{
					return privateHost;
				}
				set	
				{
					privateHost = value;
				}
			}

			public string VpcHost
			{
				get
				{
					return vpcHost;
				}
				set	
				{
					vpcHost = value;
				}
			}
		}

		public class DescribeDtsJobDetail_SubscriptionDataType
		{

			private bool? ddl;

			private bool? dml;

			public bool? Ddl
			{
				get
				{
					return ddl;
				}
				set	
				{
					ddl = value;
				}
			}

			public bool? Dml
			{
				get
				{
					return dml;
				}
				set	
				{
					dml = value;
				}
			}
		}
	}
}
