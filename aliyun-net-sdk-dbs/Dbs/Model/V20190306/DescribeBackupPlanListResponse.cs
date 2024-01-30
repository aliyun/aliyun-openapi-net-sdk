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

namespace Aliyun.Acs.Dbs.Model.V20190306
{
	public class DescribeBackupPlanListResponse : AcsResponse
	{

		private int? httpStatusCode;

		private int? pageNum;

		private string requestId;

		private string errCode;

		private bool? success;

		private string errMessage;

		private int? totalPages;

		private int? totalElements;

		private int? pageSize;

		private List<DescribeBackupPlanList_BackupPlanDetail> items;

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

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
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

		public int? TotalPages
		{
			get
			{
				return totalPages;
			}
			set	
			{
				totalPages = value;
			}
		}

		public int? TotalElements
		{
			get
			{
				return totalElements;
			}
			set	
			{
				totalElements = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeBackupPlanList_BackupPlanDetail> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeBackupPlanList_BackupPlanDetail
		{

			private string crossRoleName;

			private string sourceEndpointInstanceType;

			private string backupSetDownloadDir;

			private string sourceEndpointIpPort;

			private string crossAliyunId;

			private int? duplicationArchivePeriod;

			private string backupPlanId;

			private long? endTimestampForRestore;

			private string backupPlanStatus;

			private string backupSetDownloadFullDataFormat;

			private int? backupRetentionPeriod;

			private string oSSBucketRegion;

			private string sourceEndpointOracleSID;

			private string backupStorageType;

			private string backupMethod;

			private string sourceEndpointRegion;

			private string backupPeriod;

			private string sourceEndpointDatabaseName;

			private long? backupSetDownloadGatewayId;

			private long? backupPlanCreateTime;

			private string instanceClass;

			private string backupSetDownloadTargetType;

			private int? duplicationInfrequentAccessPeriod;

			private string backupStartTime;

			private string errMessage;

			private string backupObjects;

			private long? beginTimestampForRestore;

			private string sourceEndpointInstanceID;

			private bool? openBackupSetAutoDownload;

			private string backupPlanName;

			private string oSSBucketName;

			private long? backupGatewayId;

			private string sourceEndpointUserName;

			private string backupSetDownloadIncrementDataFormat;

			private bool? enableBackupLog;

			private string resourceGroupId;

			private string databaseType;

			public string CrossRoleName
			{
				get
				{
					return crossRoleName;
				}
				set	
				{
					crossRoleName = value;
				}
			}

			public string SourceEndpointInstanceType
			{
				get
				{
					return sourceEndpointInstanceType;
				}
				set	
				{
					sourceEndpointInstanceType = value;
				}
			}

			public string BackupSetDownloadDir
			{
				get
				{
					return backupSetDownloadDir;
				}
				set	
				{
					backupSetDownloadDir = value;
				}
			}

			public string SourceEndpointIpPort
			{
				get
				{
					return sourceEndpointIpPort;
				}
				set	
				{
					sourceEndpointIpPort = value;
				}
			}

			public string CrossAliyunId
			{
				get
				{
					return crossAliyunId;
				}
				set	
				{
					crossAliyunId = value;
				}
			}

			public int? DuplicationArchivePeriod
			{
				get
				{
					return duplicationArchivePeriod;
				}
				set	
				{
					duplicationArchivePeriod = value;
				}
			}

			public string BackupPlanId
			{
				get
				{
					return backupPlanId;
				}
				set	
				{
					backupPlanId = value;
				}
			}

			public long? EndTimestampForRestore
			{
				get
				{
					return endTimestampForRestore;
				}
				set	
				{
					endTimestampForRestore = value;
				}
			}

			public string BackupPlanStatus
			{
				get
				{
					return backupPlanStatus;
				}
				set	
				{
					backupPlanStatus = value;
				}
			}

			public string BackupSetDownloadFullDataFormat
			{
				get
				{
					return backupSetDownloadFullDataFormat;
				}
				set	
				{
					backupSetDownloadFullDataFormat = value;
				}
			}

			public int? BackupRetentionPeriod
			{
				get
				{
					return backupRetentionPeriod;
				}
				set	
				{
					backupRetentionPeriod = value;
				}
			}

			public string OSSBucketRegion
			{
				get
				{
					return oSSBucketRegion;
				}
				set	
				{
					oSSBucketRegion = value;
				}
			}

			public string SourceEndpointOracleSID
			{
				get
				{
					return sourceEndpointOracleSID;
				}
				set	
				{
					sourceEndpointOracleSID = value;
				}
			}

			public string BackupStorageType
			{
				get
				{
					return backupStorageType;
				}
				set	
				{
					backupStorageType = value;
				}
			}

			public string BackupMethod
			{
				get
				{
					return backupMethod;
				}
				set	
				{
					backupMethod = value;
				}
			}

			public string SourceEndpointRegion
			{
				get
				{
					return sourceEndpointRegion;
				}
				set	
				{
					sourceEndpointRegion = value;
				}
			}

			public string BackupPeriod
			{
				get
				{
					return backupPeriod;
				}
				set	
				{
					backupPeriod = value;
				}
			}

			public string SourceEndpointDatabaseName
			{
				get
				{
					return sourceEndpointDatabaseName;
				}
				set	
				{
					sourceEndpointDatabaseName = value;
				}
			}

			public long? BackupSetDownloadGatewayId
			{
				get
				{
					return backupSetDownloadGatewayId;
				}
				set	
				{
					backupSetDownloadGatewayId = value;
				}
			}

			public long? BackupPlanCreateTime
			{
				get
				{
					return backupPlanCreateTime;
				}
				set	
				{
					backupPlanCreateTime = value;
				}
			}

			public string InstanceClass
			{
				get
				{
					return instanceClass;
				}
				set	
				{
					instanceClass = value;
				}
			}

			public string BackupSetDownloadTargetType
			{
				get
				{
					return backupSetDownloadTargetType;
				}
				set	
				{
					backupSetDownloadTargetType = value;
				}
			}

			public int? DuplicationInfrequentAccessPeriod
			{
				get
				{
					return duplicationInfrequentAccessPeriod;
				}
				set	
				{
					duplicationInfrequentAccessPeriod = value;
				}
			}

			public string BackupStartTime
			{
				get
				{
					return backupStartTime;
				}
				set	
				{
					backupStartTime = value;
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

			public string BackupObjects
			{
				get
				{
					return backupObjects;
				}
				set	
				{
					backupObjects = value;
				}
			}

			public long? BeginTimestampForRestore
			{
				get
				{
					return beginTimestampForRestore;
				}
				set	
				{
					beginTimestampForRestore = value;
				}
			}

			public string SourceEndpointInstanceID
			{
				get
				{
					return sourceEndpointInstanceID;
				}
				set	
				{
					sourceEndpointInstanceID = value;
				}
			}

			public bool? OpenBackupSetAutoDownload
			{
				get
				{
					return openBackupSetAutoDownload;
				}
				set	
				{
					openBackupSetAutoDownload = value;
				}
			}

			public string BackupPlanName
			{
				get
				{
					return backupPlanName;
				}
				set	
				{
					backupPlanName = value;
				}
			}

			public string OSSBucketName
			{
				get
				{
					return oSSBucketName;
				}
				set	
				{
					oSSBucketName = value;
				}
			}

			public long? BackupGatewayId
			{
				get
				{
					return backupGatewayId;
				}
				set	
				{
					backupGatewayId = value;
				}
			}

			public string SourceEndpointUserName
			{
				get
				{
					return sourceEndpointUserName;
				}
				set	
				{
					sourceEndpointUserName = value;
				}
			}

			public string BackupSetDownloadIncrementDataFormat
			{
				get
				{
					return backupSetDownloadIncrementDataFormat;
				}
				set	
				{
					backupSetDownloadIncrementDataFormat = value;
				}
			}

			public bool? EnableBackupLog
			{
				get
				{
					return enableBackupLog;
				}
				set	
				{
					enableBackupLog = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public string DatabaseType
			{
				get
				{
					return databaseType;
				}
				set	
				{
					databaseType = value;
				}
			}
		}
	}
}
