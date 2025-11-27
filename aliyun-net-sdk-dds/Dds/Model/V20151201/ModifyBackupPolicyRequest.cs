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
using Aliyun.Acs.Dds.Transform;
using Aliyun.Acs.Dds.Transform.V20151201;

namespace Aliyun.Acs.Dds.Model.V20151201
{
    public class ModifyBackupPolicyRequest : RpcAcsRequest<ModifyBackupPolicyResponse>
    {
        public ModifyBackupPolicyRequest()
            : base("Dds", "2015-12-01", "ModifyBackupPolicy", "dds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? crossLogRetentionValue;

		private string srcRegion;

		private string crossRetentionType;

		private string backupInterval;

		private string instanceType;

		private string dBInstanceId;

		private long? enableBackupLog;

		private string preferredBackupPeriod;

		private int? backupRetentionPolicyOnClusterDeletion;

		private string destRegion;

		private string resourceOwnerAccount;

		private string crossBackupType;

		private string ownerAccount;

		private long? ownerId;

		private string snapshotBackupType;

		private string preferredBackupTime;

		private long? backupRetentionPeriod;

		private long? highFrequencyBackupRetention;

		private int? enableCrossLogBackup;

		private string crossBackupPeriod;

		private int? crossRetentionValue;

		private string crossLogRetentionType;

		private long? logBackupRetentionPeriod;

		private bool? preserveOneEachHour;

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

		public int? CrossLogRetentionValue
		{
			get
			{
				return crossLogRetentionValue;
			}
			set	
			{
				crossLogRetentionValue = value;
				DictionaryUtil.Add(QueryParameters, "CrossLogRetentionValue", value.ToString());
			}
		}

		public string SrcRegion
		{
			get
			{
				return srcRegion;
			}
			set	
			{
				srcRegion = value;
				DictionaryUtil.Add(QueryParameters, "SrcRegion", value);
			}
		}

		public string CrossRetentionType
		{
			get
			{
				return crossRetentionType;
			}
			set	
			{
				crossRetentionType = value;
				DictionaryUtil.Add(QueryParameters, "CrossRetentionType", value);
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

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
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

		public long? EnableBackupLog
		{
			get
			{
				return enableBackupLog;
			}
			set	
			{
				enableBackupLog = value;
				DictionaryUtil.Add(QueryParameters, "EnableBackupLog", value.ToString());
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

		public int? BackupRetentionPolicyOnClusterDeletion
		{
			get
			{
				return backupRetentionPolicyOnClusterDeletion;
			}
			set	
			{
				backupRetentionPolicyOnClusterDeletion = value;
				DictionaryUtil.Add(QueryParameters, "BackupRetentionPolicyOnClusterDeletion", value.ToString());
			}
		}

		public string DestRegion
		{
			get
			{
				return destRegion;
			}
			set	
			{
				destRegion = value;
				DictionaryUtil.Add(QueryParameters, "DestRegion", value);
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

		public string CrossBackupType
		{
			get
			{
				return crossBackupType;
			}
			set	
			{
				crossBackupType = value;
				DictionaryUtil.Add(QueryParameters, "CrossBackupType", value);
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

		public string SnapshotBackupType
		{
			get
			{
				return snapshotBackupType;
			}
			set	
			{
				snapshotBackupType = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotBackupType", value);
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

		public long? BackupRetentionPeriod
		{
			get
			{
				return backupRetentionPeriod;
			}
			set	
			{
				backupRetentionPeriod = value;
				DictionaryUtil.Add(QueryParameters, "BackupRetentionPeriod", value.ToString());
			}
		}

		public long? HighFrequencyBackupRetention
		{
			get
			{
				return highFrequencyBackupRetention;
			}
			set	
			{
				highFrequencyBackupRetention = value;
				DictionaryUtil.Add(QueryParameters, "HighFrequencyBackupRetention", value.ToString());
			}
		}

		public int? EnableCrossLogBackup
		{
			get
			{
				return enableCrossLogBackup;
			}
			set	
			{
				enableCrossLogBackup = value;
				DictionaryUtil.Add(QueryParameters, "EnableCrossLogBackup", value.ToString());
			}
		}

		public string CrossBackupPeriod
		{
			get
			{
				return crossBackupPeriod;
			}
			set	
			{
				crossBackupPeriod = value;
				DictionaryUtil.Add(QueryParameters, "CrossBackupPeriod", value);
			}
		}

		public int? CrossRetentionValue
		{
			get
			{
				return crossRetentionValue;
			}
			set	
			{
				crossRetentionValue = value;
				DictionaryUtil.Add(QueryParameters, "CrossRetentionValue", value.ToString());
			}
		}

		public string CrossLogRetentionType
		{
			get
			{
				return crossLogRetentionType;
			}
			set	
			{
				crossLogRetentionType = value;
				DictionaryUtil.Add(QueryParameters, "CrossLogRetentionType", value);
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
				DictionaryUtil.Add(QueryParameters, "LogBackupRetentionPeriod", value.ToString());
			}
		}

		public bool? PreserveOneEachHour
		{
			get
			{
				return preserveOneEachHour;
			}
			set	
			{
				preserveOneEachHour = value;
				DictionaryUtil.Add(QueryParameters, "PreserveOneEachHour", value.ToString());
			}
		}

        public override ModifyBackupPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyBackupPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
