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
	public class DescribeBackupPolicyResponse : AcsResponse
	{

		private int? logBackupRetentionPeriod;

		private string archiveBackupKeepPolicy;

		private string archiveBackupKeepCount;

		private int? localLogRetentionHours;

		private int? backupRetentionPeriod;

		private string requestId;

		private string preferredBackupPeriod;

		private string compressType;

		private int? supportReleasedKeep;

		private string localLogRetentionSpace;

		private int? supportVolumeShadowCopy;

		private string backupMethod;

		private string logBackupFrequency;

		private string preferredNextBackupTime;

		private string highSpaceUsageProtection;

		private string duplicationContent;

		private string archiveBackupRetentionPeriod;

		private string backupInterval;

		private string releasedKeepPolicy;

		private string preferredBackupTime;

		private string duplication;

		private int? logBackupLocalRetentionNumber;

		private string category;

		private string enableBackupLog;

		private string backupLog;

		private bool? enableIncrementDataBackup;

		private bool? supportModifyBackupPriority;

		private int? backupPriority;

		private bool? enablePitrProtection;

		private int? pitrRetentionPeriod;

		private DescribeBackupPolicy_DuplicationLocation duplicationLocation;

		[JsonProperty(PropertyName = "LogBackupRetentionPeriod")]
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

		[JsonProperty(PropertyName = "ArchiveBackupKeepPolicy")]
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

		[JsonProperty(PropertyName = "ArchiveBackupKeepCount")]
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

		[JsonProperty(PropertyName = "LocalLogRetentionHours")]
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

		[JsonProperty(PropertyName = "BackupRetentionPeriod")]
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

		[JsonProperty(PropertyName = "PreferredBackupPeriod")]
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

		[JsonProperty(PropertyName = "CompressType")]
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

		[JsonProperty(PropertyName = "SupportReleasedKeep")]
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

		[JsonProperty(PropertyName = "LocalLogRetentionSpace")]
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

		[JsonProperty(PropertyName = "SupportVolumeShadowCopy")]
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

		[JsonProperty(PropertyName = "LogBackupFrequency")]
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

		[JsonProperty(PropertyName = "PreferredNextBackupTime")]
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

		[JsonProperty(PropertyName = "HighSpaceUsageProtection")]
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

		[JsonProperty(PropertyName = "DuplicationContent")]
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

		[JsonProperty(PropertyName = "ArchiveBackupRetentionPeriod")]
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

		[JsonProperty(PropertyName = "BackupInterval")]
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

		[JsonProperty(PropertyName = "ReleasedKeepPolicy")]
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

		[JsonProperty(PropertyName = "PreferredBackupTime")]
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

		[JsonProperty(PropertyName = "Duplication")]
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

		[JsonProperty(PropertyName = "LogBackupLocalRetentionNumber")]
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

		[JsonProperty(PropertyName = "EnableBackupLog")]
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

		[JsonProperty(PropertyName = "BackupLog")]
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

		[JsonProperty(PropertyName = "EnableIncrementDataBackup")]
		public bool? EnableIncrementDataBackup
		{
			get
			{
				return enableIncrementDataBackup;
			}
			set	
			{
				enableIncrementDataBackup = value;
			}
		}

		[JsonProperty(PropertyName = "SupportModifyBackupPriority")]
		public bool? SupportModifyBackupPriority
		{
			get
			{
				return supportModifyBackupPriority;
			}
			set	
			{
				supportModifyBackupPriority = value;
			}
		}

		[JsonProperty(PropertyName = "BackupPriority")]
		public int? BackupPriority
		{
			get
			{
				return backupPriority;
			}
			set	
			{
				backupPriority = value;
			}
		}

		[JsonProperty(PropertyName = "EnablePitrProtection")]
		public bool? EnablePitrProtection
		{
			get
			{
				return enablePitrProtection;
			}
			set	
			{
				enablePitrProtection = value;
			}
		}

		[JsonProperty(PropertyName = "PitrRetentionPeriod")]
		public int? PitrRetentionPeriod
		{
			get
			{
				return pitrRetentionPeriod;
			}
			set	
			{
				pitrRetentionPeriod = value;
			}
		}

		[JsonProperty(PropertyName = "DuplicationLocation")]
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

			[JsonProperty(PropertyName = "Sotrage")]
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

			[JsonProperty(PropertyName = "Location")]
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

				private string bucket;

				private string endpoint;

				[JsonProperty(PropertyName = "Bucket")]
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

				[JsonProperty(PropertyName = "Endpoint")]
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
			}
		}
	}
}
