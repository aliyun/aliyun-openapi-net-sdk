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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeCloudMigrationResultResponse : AcsResponse
	{

		private int? totalSize;

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private List<DescribeCloudMigrationResult_Tasks> items;

		[JsonProperty(PropertyName = "TotalSize")]
		public int? TotalSize
		{
			get
			{
				return totalSize;
			}
			set	
			{
				totalSize = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PageNumber")]
		public long? PageNumber
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

		[JsonProperty(PropertyName = "PageSize")]
		public long? PageSize
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

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeCloudMigrationResult_Tasks> Items
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

		public class DescribeCloudMigrationResult_Tasks
		{

			private string gmtCreated;

			private string gmtModified;

			private long? taskId;

			private string taskName;

			private string status;

			private string migrateStage;

			private string sourceCategory;

			private string sourceIpAddress;

			private long? sourcePort;

			private string sourceAccount;

			private string sourcePassword;

			private string targetEip;

			private string targetInstanceName;

			private string replicationState;

			private string replicationInfo;

			private string detail;

			private string switchTime;

			[JsonProperty(PropertyName = "GmtCreated")]
			public string GmtCreated
			{
				get
				{
					return gmtCreated;
				}
				set	
				{
					gmtCreated = value;
				}
			}

			[JsonProperty(PropertyName = "GmtModified")]
			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			[JsonProperty(PropertyName = "TaskId")]
			public long? TaskId
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

			[JsonProperty(PropertyName = "TaskName")]
			public string TaskName
			{
				get
				{
					return taskName;
				}
				set	
				{
					taskName = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "MigrateStage")]
			public string MigrateStage
			{
				get
				{
					return migrateStage;
				}
				set	
				{
					migrateStage = value;
				}
			}

			[JsonProperty(PropertyName = "SourceCategory")]
			public string SourceCategory
			{
				get
				{
					return sourceCategory;
				}
				set	
				{
					sourceCategory = value;
				}
			}

			[JsonProperty(PropertyName = "SourceIpAddress")]
			public string SourceIpAddress
			{
				get
				{
					return sourceIpAddress;
				}
				set	
				{
					sourceIpAddress = value;
				}
			}

			[JsonProperty(PropertyName = "SourcePort")]
			public long? SourcePort
			{
				get
				{
					return sourcePort;
				}
				set	
				{
					sourcePort = value;
				}
			}

			[JsonProperty(PropertyName = "SourceAccount")]
			public string SourceAccount
			{
				get
				{
					return sourceAccount;
				}
				set	
				{
					sourceAccount = value;
				}
			}

			[JsonProperty(PropertyName = "SourcePassword")]
			public string SourcePassword
			{
				get
				{
					return sourcePassword;
				}
				set	
				{
					sourcePassword = value;
				}
			}

			[JsonProperty(PropertyName = "TargetEip")]
			public string TargetEip
			{
				get
				{
					return targetEip;
				}
				set	
				{
					targetEip = value;
				}
			}

			[JsonProperty(PropertyName = "TargetInstanceName")]
			public string TargetInstanceName
			{
				get
				{
					return targetInstanceName;
				}
				set	
				{
					targetInstanceName = value;
				}
			}

			[JsonProperty(PropertyName = "ReplicationState")]
			public string ReplicationState
			{
				get
				{
					return replicationState;
				}
				set	
				{
					replicationState = value;
				}
			}

			[JsonProperty(PropertyName = "ReplicationInfo")]
			public string ReplicationInfo
			{
				get
				{
					return replicationInfo;
				}
				set	
				{
					replicationInfo = value;
				}
			}

			[JsonProperty(PropertyName = "Detail")]
			public string Detail
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

			[JsonProperty(PropertyName = "SwitchTime")]
			public string SwitchTime
			{
				get
				{
					return switchTime;
				}
				set	
				{
					switchTime = value;
				}
			}
		}
	}
}
