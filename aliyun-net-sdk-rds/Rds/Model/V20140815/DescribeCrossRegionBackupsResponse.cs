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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeCrossRegionBackupsResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private string startTime;

		private string endTime;

		private int? totalRecordCount;

		private int? pageRecordCount;

		private int? pageNumber;

		private List<DescribeCrossRegionBackups_Item> items;

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

			private int? crossBackupId;

			private string crossBackupRegion;

			private int? backupSetStatus;

			private string backupStartTime;

			private string backupEndTime;

			private string backupType;

			private string backupMethod;

			private long? crossBackupSetSize;

			private string crossBackupSetFile;

			private string crossBackupDownloadLink;

			private string engine;

			private string engineVersion;

			private string crossBackupSetLocation;

			private int? backupSetScale;

			private int? instanceId;

			private string dBInstanceStorageType;

			private string category;

			private string consistentTime;

			private string hasBackupTableMeta;

			private List<string> restoreRegions;

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
