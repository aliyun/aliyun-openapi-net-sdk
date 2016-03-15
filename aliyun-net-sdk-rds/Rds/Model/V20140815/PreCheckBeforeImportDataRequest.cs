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
    public class PreCheckBeforeImportDataRequest : RpcAcsRequest<PreCheckBeforeImportDataResponse>
    {
        public PreCheckBeforeImportDataRequest()
            : base("Rds", "2014-08-15", "PreCheckBeforeImportData")
        {
        }

		private long? ownerId;

		private string resourceOwnerAccount;

		private long? resourceOwnerId;

		private string clientToken;

		private string dBInstanceId;

		private string sourceDatabaseIp;

		private string sourceDatabasePort;

		private string sourceDatabaseUserName;

		private string sourceDatabasePassword;

		private string importDataType;

		private string sourceDatabaseDBNames;

		private string ownerAccount;

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

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
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

        public override PreCheckBeforeImportDataResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PreCheckBeforeImportDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}