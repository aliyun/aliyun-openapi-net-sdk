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

namespace Aliyun.Acs.Dbs.Model.V20190306
{
	public class DescribeBackupPlanListResponse : AcsResponse
	{

		private bool? success;

		private string errCode;

		private string errMessage;

		private int? httpStatusCode;

		private string requestId;

		private int? totalPages;

		private int? pageSize;

		private int? pageNum;

		private int? totalElements;

		private List<DescribeBackupPlanList_BackupPlanDetail> items;

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

			private string backupPlanId;

			private string sourceEndpointInstanceType;

			private string sourceEndpointRegion;

			private string sourceEndpointInstanceID;

			private string sourceEndpointIpPort;

			private string sourceEndpointDatabaseName;

			private string sourceEndpointUserName;

			private string backupObjects;

			private long? backupGatewayId;

			private string oSSBucketRegion;

			private string oSSBucketName;

			private string backupPeriod;

			private string backupStartTime;

			private bool? enableBackupLog;

			private int? backupRetentionPeriod;

			private int? duplicationInfrequentAccessPeriod;

			private int? duplicationArchivePeriod;

			private string backupPlanName;

			private string sourceEndpointOracleSID;

			private string instanceClass;

			private string backupMethod;

			private long? backupPlanCreateTime;

			private string backupPlanStatus;

			private long? beginTimestampForRestore;

			private long? endTimestampForRestore;

			private bool? openBackupSetAutoDownload;

			private string backupSetDownloadTargetType;

			private string backupSetDownloadDir;

			private long? backupSetDownloadGatewayId;

			private string backupSetDownloadFullDataFormat;

			private string backupSetDownloadIncrementDataFormat;

			private string crossAliyunId;

			private string crossRoleName;

			private string backupStorageType;

			private string errMessage;

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
		}
	}
}
