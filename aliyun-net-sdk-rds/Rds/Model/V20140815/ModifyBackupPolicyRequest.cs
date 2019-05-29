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
        }

		private string preferredBackupPeriod;

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string localLogRetentionHours;

		private string ownerAccount;

		private string logBackupFrequency;

		private string compressType;

		private string backupLog;

		private string localLogRetentionSpace;

		private long? ownerId;

		private string duplication;

		private string preferredBackupTime;

		private string backupRetentionPeriod;

		private string duplicationContent;

		private string highSpaceUsageProtection;

		private string dBInstanceId;

		private string duplicationLocation;

		private string logBackupRetentionPeriod;

		private string enableBackupLog;

		private string backupPolicyMode;

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

		public string Duplication
		{
			get
			{
				return duplication;
			}
			set	
			{
				duplication = value;
				DictionaryUtil.Add(QueryParameters, "Duplication", value);
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

		public string DuplicationContent
		{
			get
			{
				return duplicationContent;
			}
			set	
			{
				duplicationContent = value;
				DictionaryUtil.Add(QueryParameters, "DuplicationContent", value);
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

		public string DuplicationLocation
		{
			get
			{
				return duplicationLocation;
			}
			set	
			{
				duplicationLocation = value;
				DictionaryUtil.Add(QueryParameters, "DuplicationLocation", value);
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

        public override ModifyBackupPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyBackupPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
