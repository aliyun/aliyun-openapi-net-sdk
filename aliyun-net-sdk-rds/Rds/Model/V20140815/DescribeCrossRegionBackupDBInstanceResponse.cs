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
	public class DescribeCrossRegionBackupDBInstanceResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private int? totalRecords;

		private int? pageSize;

		private int? pageNumber;

		private int? itemsNumbers;

		private List<DescribeCrossRegionBackupDBInstance_Item> items;

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

			private string dBInstanceId;

			private string dBInstanceDescription;

			private string dBInstanceStatus;

			private string dBInstanceStatusDesc;

			private string engine;

			private string engineVersion;

			private string crossBackupRegion;

			private string crossBackupType;

			private string backupEnabled;

			private string logBackupEnabled;

			private string logBackupEnabledTime;

			private string backupEnabledTime;

			private int? retentType;

			private int? retention;

			private string lockMode;

			private string relService;

			private string relServiceId;

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
		}
	}
}
