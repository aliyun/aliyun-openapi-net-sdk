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
	public class DescribeBackupPolicyResponse : AcsResponse
	{

		private string requestId;

		private int? backupRetentionPeriod;

		private string preferredNextBackupTime;

		private string preferredBackupTime;

		private string preferredBackupPeriod;

		private string backupLog;

		private int? logBackupRetentionPeriod;

		private string enableBackupLog;

		private int? localLogRetentionHours;

		private string localLogRetentionSpace;

		private string duplication;

		private string duplicationContent;

		private string highSpaceUsageProtection;

		private string logBackupFrequency;

		private string compressType;

		private string archiveBackupRetentionPeriod;

		private string archiveBackupKeepPolicy;

		private string archiveBackupKeepCount;

		private string releasedKeepPolicy;

		private int? logBackupLocalRetentionNumber;

		private string category;

		private int? supportReleasedKeep;

		private string backupInterval;

		private int? supportVolumeShadowCopy;

		private string backupMethod;

		private DescribeBackupPolicy_DuplicationLocation duplicationLocation;

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

		public int? BackupRetentionPeriod
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

		public string PreferredNextBackupTime
		{
			get
			{
				return preferredNextBackupTime;
			}
			set	
			{
				preferredNextBackupTime = value;
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

		public int? LogBackupRetentionPeriod
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

		public string EnableBackupLog
		{
			get
			{
				return enableBackupLog;
			}
			set	
			{
				enableBackupLog = value;
			}
		}

		public int? LocalLogRetentionHours
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

		public string LocalLogRetentionSpace
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

		public string Duplication
		{
			get
			{
				return duplication;
			}
			set	
			{
				duplication = value;
			}
		}

		public string DuplicationContent
		{
			get
			{
				return duplicationContent;
			}
			set	
			{
				duplicationContent = value;
			}
		}

		public string HighSpaceUsageProtection
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

		public string LogBackupFrequency
		{
			get
			{
				return logBackupFrequency;
			}
			set	
			{
				logBackupFrequency = value;
			}
		}

		public string CompressType
		{
			get
			{
				return compressType;
			}
			set	
			{
				compressType = value;
			}
		}

		public string ArchiveBackupRetentionPeriod
		{
			get
			{
				return archiveBackupRetentionPeriod;
			}
			set	
			{
				archiveBackupRetentionPeriod = value;
			}
		}

		public string ArchiveBackupKeepPolicy
		{
			get
			{
				return archiveBackupKeepPolicy;
			}
			set	
			{
				archiveBackupKeepPolicy = value;
			}
		}

		public string ArchiveBackupKeepCount
		{
			get
			{
				return archiveBackupKeepCount;
			}
			set	
			{
				archiveBackupKeepCount = value;
			}
		}

		public string ReleasedKeepPolicy
		{
			get
			{
				return releasedKeepPolicy;
			}
			set	
			{
				releasedKeepPolicy = value;
			}
		}

		public int? LogBackupLocalRetentionNumber
		{
			get
			{
				return logBackupLocalRetentionNumber;
			}
			set	
			{
				logBackupLocalRetentionNumber = value;
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

		public int? SupportReleasedKeep
		{
			get
			{
				return supportReleasedKeep;
			}
			set	
			{
				supportReleasedKeep = value;
			}
		}

		public string BackupInterval
		{
			get
			{
				return backupInterval;
			}
			set	
			{
				backupInterval = value;
			}
		}

		public int? SupportVolumeShadowCopy
		{
			get
			{
				return supportVolumeShadowCopy;
			}
			set	
			{
				supportVolumeShadowCopy = value;
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

		public DescribeBackupPolicy_DuplicationLocation DuplicationLocation
		{
			get
			{
				return duplicationLocation;
			}
			set	
			{
				duplicationLocation = value;
			}
		}

		public class DescribeBackupPolicy_DuplicationLocation
		{

			private string sotrage;

			private DescribeBackupPolicy_Location location;

			public string Sotrage
			{
				get
				{
					return sotrage;
				}
				set	
				{
					sotrage = value;
				}
			}

			public DescribeBackupPolicy_Location Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public class DescribeBackupPolicy_Location
			{

				private string endpoint;

				private string bucket;

				public string Endpoint
				{
					get
					{
						return endpoint;
					}
					set	
					{
						endpoint = value;
					}
				}

				public string Bucket
				{
					get
					{
						return bucket;
					}
					set	
					{
						bucket = value;
					}
				}
			}
		}
	}
}
