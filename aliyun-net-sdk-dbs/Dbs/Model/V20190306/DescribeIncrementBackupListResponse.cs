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
	public class DescribeIncrementBackupListResponse : AcsResponse
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

		private List<DescribeIncrementBackupList_IncrementBackupFile> items;

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

		public List<DescribeIncrementBackupList_IncrementBackupFile> Items
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

		public class DescribeIncrementBackupList_IncrementBackupFile
		{

			private long? endTime;

			private long? backupSetExpiredTime;

			private long? startTime;

			private string storageMethod;

			private string backupSetJobId;

			private string backupSetId;

			private string backupStatus;

			private string sourceEndpointIpPort;

			private long? backupSize;

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public long? BackupSetExpiredTime
			{
				get
				{
					return backupSetExpiredTime;
				}
				set	
				{
					backupSetExpiredTime = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string StorageMethod
			{
				get
				{
					return storageMethod;
				}
				set	
				{
					storageMethod = value;
				}
			}

			public string BackupSetJobId
			{
				get
				{
					return backupSetJobId;
				}
				set	
				{
					backupSetJobId = value;
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

			public string BackupStatus
			{
				get
				{
					return backupStatus;
				}
				set	
				{
					backupStatus = value;
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

			public long? BackupSize
			{
				get
				{
					return backupSize;
				}
				set	
				{
					backupSize = value;
				}
			}
		}
	}
}
