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

namespace Aliyun.Acs.DBFS.Model.V20200418
{
	public class GenerateUpgradeRecordResponse : AcsResponse
	{

		private string requestId;

		private List<GenerateUpgradeRecord_RecordsItem> records;

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

		public List<GenerateUpgradeRecord_RecordsItem> Records
		{
			get
			{
				return records;
			}
			set	
			{
				records = value;
			}
		}

		public class GenerateUpgradeRecord_RecordsItem
		{

			private long? id;

			private string batchStrategyNo;

			private string accountId;

			private string dbfsId;

			private string ecsId;

			private string taskId;

			private string regionId;

			private string zoneId;

			private string state;

			private string currentVersion;

			private string targetVersion;

			private long? upgradeStartTime;

			private long? upgradeEndTime;

			private int? taskExecutionCounts;

			private string taskErrorReason;

			private long? createTime;

			private long? updateTime;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string BatchStrategyNo
			{
				get
				{
					return batchStrategyNo;
				}
				set	
				{
					batchStrategyNo = value;
				}
			}

			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			public string DbfsId
			{
				get
				{
					return dbfsId;
				}
				set	
				{
					dbfsId = value;
				}
			}

			public string EcsId
			{
				get
				{
					return ecsId;
				}
				set	
				{
					ecsId = value;
				}
			}

			public string TaskId
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

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string CurrentVersion
			{
				get
				{
					return currentVersion;
				}
				set	
				{
					currentVersion = value;
				}
			}

			public string TargetVersion
			{
				get
				{
					return targetVersion;
				}
				set	
				{
					targetVersion = value;
				}
			}

			public long? UpgradeStartTime
			{
				get
				{
					return upgradeStartTime;
				}
				set	
				{
					upgradeStartTime = value;
				}
			}

			public long? UpgradeEndTime
			{
				get
				{
					return upgradeEndTime;
				}
				set	
				{
					upgradeEndTime = value;
				}
			}

			public int? TaskExecutionCounts
			{
				get
				{
					return taskExecutionCounts;
				}
				set	
				{
					taskExecutionCounts = value;
				}
			}

			public string TaskErrorReason
			{
				get
				{
					return taskErrorReason;
				}
				set	
				{
					taskErrorReason = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}
		}
	}
}
