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
	public class DescribeRestoreTaskListResponse : AcsResponse
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

		private List<DescribeRestoreTaskList_RestoreTaskDetail> items;

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

		public List<DescribeRestoreTaskList_RestoreTaskDetail> Items
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

		public class DescribeRestoreTaskList_RestoreTaskDetail
		{

			private string backupPlanId;

			private string destinationEndpointInstanceType;

			private string destinationEndpointRegion;

			private string destinationEndpointInstanceID;

			private string destinationEndpointIpPort;

			private string destinationEndpointDatabaseName;

			private string destinationEndpointUserName;

			private string destinationEndpointOracleSID;

			private string restoreObjects;

			private long? backupGatewayId;

			private string restoreDir;

			private string restoreTaskName;

			private string backupSetId;

			private long? restoreTime;

			private long? restoreTaskCreateTime;

			private long? restoreTaskFinishTime;

			private string restoreStatus;

			private string restoreTaskId;

			private int? fullStruforeRestoreProgress;

			private int? fullDataRestoreProgress;

			private int? continuousRestoreProgress;

			private int? fullStruAfterRestoreProgress;

			private string crossAliyunId;

			private string crossRoleName;

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

			public string DestinationEndpointInstanceType
			{
				get
				{
					return destinationEndpointInstanceType;
				}
				set	
				{
					destinationEndpointInstanceType = value;
				}
			}

			public string DestinationEndpointRegion
			{
				get
				{
					return destinationEndpointRegion;
				}
				set	
				{
					destinationEndpointRegion = value;
				}
			}

			public string DestinationEndpointInstanceID
			{
				get
				{
					return destinationEndpointInstanceID;
				}
				set	
				{
					destinationEndpointInstanceID = value;
				}
			}

			public string DestinationEndpointIpPort
			{
				get
				{
					return destinationEndpointIpPort;
				}
				set	
				{
					destinationEndpointIpPort = value;
				}
			}

			public string DestinationEndpointDatabaseName
			{
				get
				{
					return destinationEndpointDatabaseName;
				}
				set	
				{
					destinationEndpointDatabaseName = value;
				}
			}

			public string DestinationEndpointUserName
			{
				get
				{
					return destinationEndpointUserName;
				}
				set	
				{
					destinationEndpointUserName = value;
				}
			}

			public string DestinationEndpointOracleSID
			{
				get
				{
					return destinationEndpointOracleSID;
				}
				set	
				{
					destinationEndpointOracleSID = value;
				}
			}

			public string RestoreObjects
			{
				get
				{
					return restoreObjects;
				}
				set	
				{
					restoreObjects = value;
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

			public string RestoreDir
			{
				get
				{
					return restoreDir;
				}
				set	
				{
					restoreDir = value;
				}
			}

			public string RestoreTaskName
			{
				get
				{
					return restoreTaskName;
				}
				set	
				{
					restoreTaskName = value;
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

			public long? RestoreTime
			{
				get
				{
					return restoreTime;
				}
				set	
				{
					restoreTime = value;
				}
			}

			public long? RestoreTaskCreateTime
			{
				get
				{
					return restoreTaskCreateTime;
				}
				set	
				{
					restoreTaskCreateTime = value;
				}
			}

			public long? RestoreTaskFinishTime
			{
				get
				{
					return restoreTaskFinishTime;
				}
				set	
				{
					restoreTaskFinishTime = value;
				}
			}

			public string RestoreStatus
			{
				get
				{
					return restoreStatus;
				}
				set	
				{
					restoreStatus = value;
				}
			}

			public string RestoreTaskId
			{
				get
				{
					return restoreTaskId;
				}
				set	
				{
					restoreTaskId = value;
				}
			}

			public int? FullStruforeRestoreProgress
			{
				get
				{
					return fullStruforeRestoreProgress;
				}
				set	
				{
					fullStruforeRestoreProgress = value;
				}
			}

			public int? FullDataRestoreProgress
			{
				get
				{
					return fullDataRestoreProgress;
				}
				set	
				{
					fullDataRestoreProgress = value;
				}
			}

			public int? ContinuousRestoreProgress
			{
				get
				{
					return continuousRestoreProgress;
				}
				set	
				{
					continuousRestoreProgress = value;
				}
			}

			public int? FullStruAfterRestoreProgress
			{
				get
				{
					return fullStruAfterRestoreProgress;
				}
				set	
				{
					fullStruAfterRestoreProgress = value;
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
