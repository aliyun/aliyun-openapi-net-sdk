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
    public class CreateMigrateTaskRequest : RpcAcsRequest<CreateMigrateTaskResponse>
    {
        public CreateMigrateTaskRequest()
            : base("Rds", "2014-08-15", "CreateMigrateTask", "Rds", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string migrateTaskId;

		private string resourceOwnerAccount;

		private string isOnlineDB;

		private long? ownerId;

		private string ossObjectPositions;

		private string accessKeyId;

		private string oSSUrls;

		private string dBName;

		private string action;

		private string dBInstanceId;

		private string backupMode;

		private string checkDBMode;

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

		public string MigrateTaskId
		{
			get
			{
				return migrateTaskId;
			}
			set	
			{
				migrateTaskId = value;
				DictionaryUtil.Add(QueryParameters, "MigrateTaskId", value);
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

		public string IsOnlineDB
		{
			get
			{
				return isOnlineDB;
			}
			set	
			{
				isOnlineDB = value;
				DictionaryUtil.Add(QueryParameters, "IsOnlineDB", value);
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

		public string OssObjectPositions
		{
			get
			{
				return ossObjectPositions;
			}
			set	
			{
				ossObjectPositions = value;
				DictionaryUtil.Add(QueryParameters, "OssObjectPositions", value);
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

		public string OSSUrls
		{
			get
			{
				return oSSUrls;
			}
			set	
			{
				oSSUrls = value;
				DictionaryUtil.Add(QueryParameters, "OSSUrls", value);
			}
		}

		public string DBName
		{
			get
			{
				return dBName;
			}
			set	
			{
				dBName = value;
				DictionaryUtil.Add(QueryParameters, "DBName", value);
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

		public string CheckDBMode
		{
			get
			{
				return checkDBMode;
			}
			set	
			{
				checkDBMode = value;
				DictionaryUtil.Add(QueryParameters, "CheckDBMode", value);
			}
		}

        public override CreateMigrateTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateMigrateTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
