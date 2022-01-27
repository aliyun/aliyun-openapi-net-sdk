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
	public class DescribeBackupLocalResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribeBackupLocal_BackupPolicyDO backupPolicyDO;

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

		public DescribeBackupLocal_BackupPolicyDO BackupPolicyDO
		{
			get
			{
				return backupPolicyDO;
			}
			set	
			{
				backupPolicyDO = value;
			}
		}

		public class DescribeBackupLocal_BackupPolicyDO
		{

			private long? gmtCreate;

			private long? gmtModified;

			private string backupPolicyMode;

			private string backupType;

			private string backupLevel;

			private string backupDbName;

			private string preferredBackupTime;

			private string preferredBackupPeriod;

			private long? dataBackupRetentionPeriod;

			private long? logBackupRetentionPeriod;

			private long? backupRetentionPeriod;

			private string backupLog;

			private long? localLogRetentionHours;

			private long? localLogRetentionSpace;

			private long? highSpaceUsageProtection;

			private string backupAppName;

			private string backupMode;

			private string nextBackupActuallyTime;

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
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

			public string BackupPolicyMode
			{
				get
				{
					return backupPolicyMode;
				}
				set	
				{
					backupPolicyMode = value;
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

			public string BackupDbName
			{
				get
				{
					return backupDbName;
				}
				set	
				{
					backupDbName = value;
				}
			}

			public string PreferredBackupTime
			{
				get
				{
					return preferredBackupTime;
				}
				set	
				{
					preferredBackupTime = value;
				}
			}

			public string PreferredBackupPeriod
			{
				get
				{
					return preferredBackupPeriod;
				}
				set	
				{
					preferredBackupPeriod = value;
				}
			}

			public long? DataBackupRetentionPeriod
			{
				get
				{
					return dataBackupRetentionPeriod;
				}
				set	
				{
					dataBackupRetentionPeriod = value;
				}
			}

			public long? LogBackupRetentionPeriod
			{
				get
				{
					return logBackupRetentionPeriod;
				}
				set	
				{
					logBackupRetentionPeriod = value;
				}
			}

			public long? BackupRetentionPeriod
			{
				get
				{
					return backupRetentionPeriod;
				}
				set	
				{
					backupRetentionPeriod = value;
				}
			}

			public string BackupLog
			{
				get
				{
					return backupLog;
				}
				set	
				{
					backupLog = value;
				}
			}

			public long? LocalLogRetentionHours
			{
				get
				{
					return localLogRetentionHours;
				}
				set	
				{
					localLogRetentionHours = value;
				}
			}

			public long? LocalLogRetentionSpace
			{
				get
				{
					return localLogRetentionSpace;
				}
				set	
				{
					localLogRetentionSpace = value;
				}
			}

			public long? HighSpaceUsageProtection
			{
				get
				{
					return highSpaceUsageProtection;
				}
				set	
				{
					highSpaceUsageProtection = value;
				}
			}

			public string BackupAppName
			{
				get
				{
					return backupAppName;
				}
				set	
				{
					backupAppName = value;
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

			public string NextBackupActuallyTime
			{
				get
				{
					return nextBackupActuallyTime;
				}
				set	
				{
					nextBackupActuallyTime = value;
				}
			}
		}
	}
}
