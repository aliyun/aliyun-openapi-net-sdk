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
	public class DescribeCrossRegionBackupDBInstanceResponse : AcsResponse
	{

		private string requestId;

		private int? totalRecords;

		private int? itemsNumbers;

		private int? pageSize;

		private int? pageNumber;

		private string regionId;

		private List<DescribeCrossRegionBackupDBInstance_Item> items;

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

		[JsonProperty(PropertyName = "TotalRecords")]
		public int? TotalRecords
		{
			get
			{
				return totalRecords;
			}
			set	
			{
				totalRecords = value;
			}
		}

		[JsonProperty(PropertyName = "ItemsNumbers")]
		public int? ItemsNumbers
		{
			get
			{
				return itemsNumbers;
			}
			set	
			{
				itemsNumbers = value;
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "RegionId")]
		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
			}
		}

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeCrossRegionBackupDBInstance_Item> Items
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

		public class DescribeCrossRegionBackupDBInstance_Item
		{

			private string relServiceId;

			private string logBackupEnabledTime;

			private string dBInstanceStatusDesc;

			private string relService;

			private string backupEnabled;

			private string dBInstanceStatus;

			private string lockMode;

			private string engineVersion;

			private string logBackupEnabled;

			private int? retentType;

			private int? retention;

			private string crossBackupType;

			private string crossBackupRegion;

			private string dBInstanceId;

			private string engine;

			private string backupEnabledTime;

			private string dBInstanceDescription;

			[JsonProperty(PropertyName = "RelServiceId")]
			public string RelServiceId
			{
				get
				{
					return relServiceId;
				}
				set	
				{
					relServiceId = value;
				}
			}

			[JsonProperty(PropertyName = "LogBackupEnabledTime")]
			public string LogBackupEnabledTime
			{
				get
				{
					return logBackupEnabledTime;
				}
				set	
				{
					logBackupEnabledTime = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceStatusDesc")]
			public string DBInstanceStatusDesc
			{
				get
				{
					return dBInstanceStatusDesc;
				}
				set	
				{
					dBInstanceStatusDesc = value;
				}
			}

			[JsonProperty(PropertyName = "RelService")]
			public string RelService
			{
				get
				{
					return relService;
				}
				set	
				{
					relService = value;
				}
			}

			[JsonProperty(PropertyName = "BackupEnabled")]
			public string BackupEnabled
			{
				get
				{
					return backupEnabled;
				}
				set	
				{
					backupEnabled = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceStatus")]
			public string DBInstanceStatus
			{
				get
				{
					return dBInstanceStatus;
				}
				set	
				{
					dBInstanceStatus = value;
				}
			}

			[JsonProperty(PropertyName = "LockMode")]
			public string LockMode
			{
				get
				{
					return lockMode;
				}
				set	
				{
					lockMode = value;
				}
			}

			[JsonProperty(PropertyName = "EngineVersion")]
			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			[JsonProperty(PropertyName = "LogBackupEnabled")]
			public string LogBackupEnabled
			{
				get
				{
					return logBackupEnabled;
				}
				set	
				{
					logBackupEnabled = value;
				}
			}

			[JsonProperty(PropertyName = "RetentType")]
			public int? RetentType
			{
				get
				{
					return retentType;
				}
				set	
				{
					retentType = value;
				}
			}

			[JsonProperty(PropertyName = "Retention")]
			public int? Retention
			{
				get
				{
					return retention;
				}
				set	
				{
					retention = value;
				}
			}

			[JsonProperty(PropertyName = "CrossBackupType")]
			public string CrossBackupType
			{
				get
				{
					return crossBackupType;
				}
				set	
				{
					crossBackupType = value;
				}
			}

			[JsonProperty(PropertyName = "CrossBackupRegion")]
			public string CrossBackupRegion
			{
				get
				{
					return crossBackupRegion;
				}
				set	
				{
					crossBackupRegion = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceId")]
			public string DBInstanceId
			{
				get
				{
					return dBInstanceId;
				}
				set	
				{
					dBInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "Engine")]
			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			[JsonProperty(PropertyName = "BackupEnabledTime")]
			public string BackupEnabledTime
			{
				get
				{
					return backupEnabledTime;
				}
				set	
				{
					backupEnabledTime = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceDescription")]
			public string DBInstanceDescription
			{
				get
				{
					return dBInstanceDescription;
				}
				set	
				{
					dBInstanceDescription = value;
				}
			}
		}
	}
}
