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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribeBackupsForSecurityRequest : RpcAcsRequest<DescribeBackupsForSecurityResponse>
    {
        public DescribeBackupsForSecurityRequest()
            : base("Rds", "2014-08-15", "DescribeBackupsForSecurity", "rds", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string targetAliBid;

		private string backupId;

		private string ownerAccount;

		private string endTime;

		private string startTime;

		private long? ownerId;

		private int? pageNumber;

		private string accessKeyId;

		private string backupStatus;

		private string backupLocation;

		private string targetAliUid;

		private int? pageSize;

		private string action;

		private string dBInstanceId;

		private string backupMode;

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

		public string TargetAliBid
		{
			get
			{
				return targetAliBid;
			}
			set	
			{
				targetAliBid = value;
				DictionaryUtil.Add(QueryParameters, "TargetAliBid", value);
			}
		}

		public string BackupId
		{
			get
			{
				return backupId;
			}
			set	
			{
				backupId = value;
				DictionaryUtil.Add(QueryParameters, "BackupId", value);
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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
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
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string BackupStatus
		{
			get
			{
				return backupStatus;
			}
			set	
			{
				backupStatus = value;
				DictionaryUtil.Add(QueryParameters, "BackupStatus", value);
			}
		}

		public string BackupLocation
		{
			get
			{
				return backupLocation;
			}
			set	
			{
				backupLocation = value;
				DictionaryUtil.Add(QueryParameters, "BackupLocation", value);
			}
		}

		public string TargetAliUid
		{
			get
			{
				return targetAliUid;
			}
			set	
			{
				targetAliUid = value;
				DictionaryUtil.Add(QueryParameters, "TargetAliUid", value);
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

		public string BackupMode
		{
			get
			{
				return backupMode;
			}
			set	
			{
				backupMode = value;
				DictionaryUtil.Add(QueryParameters, "BackupMode", value);
			}
		}

        public override DescribeBackupsForSecurityResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeBackupsForSecurityResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}