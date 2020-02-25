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
	public class DescribeBackupSetDownloadTaskListResponse : AcsResponse
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

		private List<DescribeBackupSetDownloadTaskList_BackupSetDownloadTaskDetail> items;

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

		public List<DescribeBackupSetDownloadTaskList_BackupSetDownloadTaskDetail> Items
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

		public class DescribeBackupSetDownloadTaskList_BackupSetDownloadTaskDetail
		{

			private string backupPlanId;

			private string backupSetDownloadTaskId;

			private string backupSetDownloadTaskName;

			private string backupSetDownloadStatus;

			private long? backupSetDownloadCreateTime;

			private long? backupSetDownloadFinishTime;

			private string backupSetId;

			private string backupSetCode;

			private string backupSetJobType;

			private long? backupSetDataSize;

			private string backupSetDataFormat;

			private string backupSetDbType;

			private string backupSetDownloadWay;

			private string backupSetDownloadDir;

			private string backupSetDownloadTargetType;

			private long? backupGatewayId;

			private string backupSetDownloadIntranetUrl;

			private string backupSetDownloadInternetUrl;

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

			public string BackupSetDownloadTaskId
			{
				get
				{
					return backupSetDownloadTaskId;
				}
				set	
				{
					backupSetDownloadTaskId = value;
				}
			}

			public string BackupSetDownloadTaskName
			{
				get
				{
					return backupSetDownloadTaskName;
				}
				set	
				{
					backupSetDownloadTaskName = value;
				}
			}

			public string BackupSetDownloadStatus
			{
				get
				{
					return backupSetDownloadStatus;
				}
				set	
				{
					backupSetDownloadStatus = value;
				}
			}

			public long? BackupSetDownloadCreateTime
			{
				get
				{
					return backupSetDownloadCreateTime;
				}
				set	
				{
					backupSetDownloadCreateTime = value;
				}
			}

			public long? BackupSetDownloadFinishTime
			{
				get
				{
					return backupSetDownloadFinishTime;
				}
				set	
				{
					backupSetDownloadFinishTime = value;
				}
			}

			public string BackupSetId
			{
				get
				{
					return backupSetId;
				}
				set	
				{
					backupSetId = value;
				}
			}

			public string BackupSetCode
			{
				get
				{
					return backupSetCode;
				}
				set	
				{
					backupSetCode = value;
				}
			}

			public string BackupSetJobType
			{
				get
				{
					return backupSetJobType;
				}
				set	
				{
					backupSetJobType = value;
				}
			}

			public long? BackupSetDataSize
			{
				get
				{
					return backupSetDataSize;
				}
				set	
				{
					backupSetDataSize = value;
				}
			}

			public string BackupSetDataFormat
			{
				get
				{
					return backupSetDataFormat;
				}
				set	
				{
					backupSetDataFormat = value;
				}
			}

			public string BackupSetDbType
			{
				get
				{
					return backupSetDbType;
				}
				set	
				{
					backupSetDbType = value;
				}
			}

			public string BackupSetDownloadWay
			{
				get
				{
					return backupSetDownloadWay;
				}
				set	
				{
					backupSetDownloadWay = value;
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

			public string BackupSetDownloadIntranetUrl
			{
				get
				{
					return backupSetDownloadIntranetUrl;
				}
				set	
				{
					backupSetDownloadIntranetUrl = value;
				}
			}

			public string BackupSetDownloadInternetUrl
			{
				get
				{
					return backupSetDownloadInternetUrl;
				}
				set	
				{
					backupSetDownloadInternetUrl = value;
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
