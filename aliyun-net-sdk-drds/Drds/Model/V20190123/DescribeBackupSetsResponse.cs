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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeBackupSetsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeBackupSets_BackupSet> backupSets;

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

		public List<DescribeBackupSets_BackupSet> BackupSets
		{
			get
			{
				return backupSets;
			}
			set	
			{
				backupSets = value;
			}
		}

		public class DescribeBackupSets_BackupSet
		{

			private string id;

			private long? backupStartTime;

			private long? backupEndTime;

			private string backupMode;

			private string backupLevel;

			private string backupType;

			private long? status;

			private bool? enableRecovery;

			private string backupTotalSize;

			private string backupConsitentTime;

			private List<string> backupDbs;

			public string Id
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

			public long? BackupStartTime
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

			public long? BackupEndTime
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

			public string BackupMode
			{
				get
				{
					return backupMode;
				}
				set	
				{
					backupMode = value;
				}
			}

			public string BackupLevel
			{
				get
				{
					return backupLevel;
				}
				set	
				{
					backupLevel = value;
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

			public long? Status
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

			public bool? EnableRecovery
			{
				get
				{
					return enableRecovery;
				}
				set	
				{
					enableRecovery = value;
				}
			}

			public string BackupTotalSize
			{
				get
				{
					return backupTotalSize;
				}
				set	
				{
					backupTotalSize = value;
				}
			}

			public string BackupConsitentTime
			{
				get
				{
					return backupConsitentTime;
				}
				set	
				{
					backupConsitentTime = value;
				}
			}

			public List<string> BackupDbs
			{
				get
				{
					return backupDbs;
				}
				set	
				{
					backupDbs = value;
				}
			}
		}
	}
}
