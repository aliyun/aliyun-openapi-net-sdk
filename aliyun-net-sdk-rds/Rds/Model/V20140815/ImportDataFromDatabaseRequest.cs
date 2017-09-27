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
    public class ImportDataFromDatabaseRequest : RpcAcsRequest<ImportDataFromDatabaseResponse>
    {
        public ImportDataFromDatabaseRequest()
            : base("Rds", "2014-08-15", "ImportDataFromDatabase", "rds", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string importDataType;

		private string resourceOwnerAccount;

		private string isLockTable;

		private string ownerAccount;

		private string sourceDatabaseDBNames;

		private string sourceDatabaseIp;

		private long? ownerId;

		private string sourceDatabasePassword;

		private string accessKeyId;

		private string sourceDatabasePort;

		private string sourceDatabaseUserName;

		private string action;

		private string dBInstanceId;

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

		public string ImportDataType
		{
			get
			{
				return importDataType;
			}
			set	
			{
				importDataType = value;
				DictionaryUtil.Add(QueryParameters, "ImportDataType", value);
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

		public string IsLockTable
		{
			get
			{
				return isLockTable;
			}
			set	
			{
				isLockTable = value;
				DictionaryUtil.Add(QueryParameters, "IsLockTable", value);
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

		public string SourceDatabaseDBNames
		{
			get
			{
				return sourceDatabaseDBNames;
			}
			set	
			{
				sourceDatabaseDBNames = value;
				DictionaryUtil.Add(QueryParameters, "SourceDatabaseDBNames", value);
			}
		}

		public string SourceDatabaseIp
		{
			get
			{
				return sourceDatabaseIp;
			}
			set	
			{
				sourceDatabaseIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceDatabaseIp", value);
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

		public string SourceDatabasePassword
		{
			get
			{
				return sourceDatabasePassword;
			}
			set	
			{
				sourceDatabasePassword = value;
				DictionaryUtil.Add(QueryParameters, "SourceDatabasePassword", value);
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

		public string SourceDatabasePort
		{
			get
			{
				return sourceDatabasePort;
			}
			set	
			{
				sourceDatabasePort = value;
				DictionaryUtil.Add(QueryParameters, "SourceDatabasePort", value);
			}
		}

		public string SourceDatabaseUserName
		{
			get
			{
				return sourceDatabaseUserName;
			}
			set	
			{
				sourceDatabaseUserName = value;
				DictionaryUtil.Add(QueryParameters, "SourceDatabaseUserName", value);
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

        public override ImportDataFromDatabaseResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ImportDataFromDatabaseResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}