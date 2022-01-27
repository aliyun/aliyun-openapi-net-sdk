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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyBackupPolicyRequest : RpcAcsRequest<ModifyBackupPolicyResponse>
    {
        public ModifyBackupPolicyRequest()
            : base("Rds", "2014-08-15", "ModifyBackupPolicy", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string localLogRetentionHours;

		private string logBackupFrequency;

		private int? archiveBackupKeepCount;

		private string backupLog;

		private string backupInterval;

		private string highSpaceUsageProtection;

		private int? logBackupLocalRetentionNumber;

		private string dBInstanceId;

		private string enableBackupLog;

		private string backupPolicyMode;

		private string preferredBackupPeriod;

		private string releasedKeepPolicy;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string compressType;

		private string localLogRetentionSpace;

		private long? ownerId;

		private string archiveBackupKeepPolicy;

		private string preferredBackupTime;

		private string backupRetentionPeriod;

		private string backupMethod;

		private string archiveBackupRetentionPeriod;

		private string category;

		private string logBackupRetentionPeriod;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string LocalLogRetentionHours
		{
			get
			{
				return localLogRetentionHours;
			}
			set	
			{
				localLogRetentionHours = value;
				DictionaryUtil.Add(QueryParameters, "LocalLogRetentionHours", value);
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
				DictionaryUtil.Add(QueryParameters, "LogBackupFrequency", value);
			}
		}

		public int? ArchiveBackupKeepCount
		{
			get
			{
				return archiveBackupKeepCount;
			}
			set	
			{
				archiveBackupKeepCount = value;
				DictionaryUtil.Add(QueryParameters, "ArchiveBackupKeepCount", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "BackupLog", value);
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
				DictionaryUtil.Add(QueryParameters, "BackupInterval", value);
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
				DictionaryUtil.Add(QueryParameters, "HighSpaceUsageProtection", value);
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
				DictionaryUtil.Add(QueryParameters, "LogBackupLocalRetentionNumber", value.ToString());
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
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
				DictionaryUtil.Add(QueryParameters, "EnableBackupLog", value);
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
				DictionaryUtil.Add(QueryParameters, "BackupPolicyMode", value);
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
				DictionaryUtil.Add(QueryParameters, "PreferredBackupPeriod", value);
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
				DictionaryUtil.Add(QueryParameters, "ReleasedKeepPolicy", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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
				DictionaryUtil.Add(QueryParameters, "CompressType", value);
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
				DictionaryUtil.Add(QueryParameters, "LocalLogRetentionSpace", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ArchiveBackupKeepPolicy", value);
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
				DictionaryUtil.Add(QueryParameters, "PreferredBackupTime", value);
			}
		}

		public string BackupRetentionPeriod
		{
			get
			{
				return backupRetentionPeriod;
			}
			set	
			{
				backupRetentionPeriod = value;
				DictionaryUtil.Add(QueryParameters, "BackupRetentionPeriod", value);
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
				DictionaryUtil.Add(QueryParameters, "BackupMethod", value);
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
				DictionaryUtil.Add(QueryParameters, "ArchiveBackupRetentionPeriod", value);
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
				DictionaryUtil.Add(QueryParameters, "Category", value);
			}
		}

		public string LogBackupRetentionPeriod
		{
			get
			{
				return logBackupRetentionPeriod;
			}
			set	
			{
				logBackupRetentionPeriod = value;
				DictionaryUtil.Add(QueryParameters, "LogBackupRetentionPeriod", value);
			}
		}

        public override ModifyBackupPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyBackupPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
