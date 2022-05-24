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
	public class DescribeCrossRegionBackupsResponse : AcsResponse
	{

		private string endTime;

		private string startTime;

		private string requestId;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private int? pageNumber;

		private string regionId;

		private List<DescribeCrossRegionBackups_Item> items;

		[JsonProperty(PropertyName = "EndTime")]
		public string EndTime
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

		[JsonProperty(PropertyName = "StartTime")]
		public string StartTime
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

		[JsonProperty(PropertyName = "PageRecordCount")]
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

		[JsonProperty(PropertyName = "TotalRecordCount")]
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
		public List<DescribeCrossRegionBackups_Item> Items
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

		public class DescribeCrossRegionBackups_Item
		{

			private string consistentTime;

			private string dBInstanceStorageType;

			private int? crossBackupId;

			private string backupType;

			private string backupStartTime;

			private string crossBackupSetLocation;

			private int? instanceId;

			private string crossBackupDownloadLink;

			private string backupEndTime;

			private string engineVersion;

			private int? backupSetStatus;

			private string crossBackupSetFile;

			private int? backupSetScale;

			private long? crossBackupSetSize;

			private string hasBackupTableMeta;

			private string crossBackupRegion;

			private string category;

			private string engine;

			private string backupMethod;

			private List<string> restoreRegions;

			[JsonProperty(PropertyName = "ConsistentTime")]
			public string ConsistentTime
			{
				get
				{
					return consistentTime;
				}
				set	
				{
					consistentTime = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceStorageType")]
			public string DBInstanceStorageType
			{
				get
				{
					return dBInstanceStorageType;
				}
				set	
				{
					dBInstanceStorageType = value;
				}
			}

			[JsonProperty(PropertyName = "CrossBackupId")]
			public int? CrossBackupId
			{
				get
				{
					return crossBackupId;
				}
				set	
				{
					crossBackupId = value;
				}
			}

			[JsonProperty(PropertyName = "BackupType")]
			public string BackupType
			{
				get
				{
					return backupType;
				}
				set	
				{
					backupType = value;
				}
			}

			[JsonProperty(PropertyName = "BackupStartTime")]
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

			[JsonProperty(PropertyName = "CrossBackupSetLocation")]
			public string CrossBackupSetLocation
			{
				get
				{
					return crossBackupSetLocation;
				}
				set	
				{
					crossBackupSetLocation = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
			public int? InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			[JsonProperty(PropertyName = "CrossBackupDownloadLink")]
			public string CrossBackupDownloadLink
			{
				get
				{
					return crossBackupDownloadLink;
				}
				set	
				{
					crossBackupDownloadLink = value;
				}
			}

			[JsonProperty(PropertyName = "BackupEndTime")]
			public string BackupEndTime
			{
				get
				{
					return backupEndTime;
				}
				set	
				{
					backupEndTime = value;
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

			[JsonProperty(PropertyName = "BackupSetStatus")]
			public int? BackupSetStatus
			{
				get
				{
					return backupSetStatus;
				}
				set	
				{
					backupSetStatus = value;
				}
			}

			[JsonProperty(PropertyName = "CrossBackupSetFile")]
			public string CrossBackupSetFile
			{
				get
				{
					return crossBackupSetFile;
				}
				set	
				{
					crossBackupSetFile = value;
				}
			}

			[JsonProperty(PropertyName = "BackupSetScale")]
			public int? BackupSetScale
			{
				get
				{
					return backupSetScale;
				}
				set	
				{
					backupSetScale = value;
				}
			}

			[JsonProperty(PropertyName = "CrossBackupSetSize")]
			public long? CrossBackupSetSize
			{
				get
				{
					return crossBackupSetSize;
				}
				set	
				{
					crossBackupSetSize = value;
				}
			}

			[JsonProperty(PropertyName = "HasBackupTableMeta")]
			public string HasBackupTableMeta
			{
				get
				{
					return hasBackupTableMeta;
				}
				set	
				{
					hasBackupTableMeta = value;
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

			[JsonProperty(PropertyName = "Category")]
			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
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

			[JsonProperty(PropertyName = "BackupMethod")]
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

			[JsonProperty(PropertyName = "RestoreRegions")]
			public List<string> RestoreRegions
			{
				get
				{
					return restoreRegions;
				}
				set	
				{
					restoreRegions = value;
				}
			}
		}
	}
}
