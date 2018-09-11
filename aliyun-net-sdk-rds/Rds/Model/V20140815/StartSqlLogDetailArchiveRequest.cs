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
    public class StartSqlLogDetailArchiveRequest : RpcAcsRequest<StartSqlLogDetailArchiveResponse>
    {
        public StartSqlLogDetailArchiveRequest()
            : base("Rds", "2014-08-15", "StartSqlLogDetailArchive", "rds", "openAPI")
        {
        }

		private string sqlType;

		private long? resourceOwnerId;

		private long? minConsume;

		private string resourceOwnerAccount;

		private string columns;

		private string ownerAccount;

		private string queryKeyword;

		private long? minScanRows;

		private string endTime;

		private string startTime;

		private long? ownerId;

		private string accessKeyId;

		private long? maxConsume;

		private int? threadID;

		private string hostAddress;

		private string dBName;

		private string accountName;

		private string securityToken;

		private string action;

		private string dBInstanceId;

		private long? maxScanRows;

		private string state;

		private string tableName;

		public string SqlType
		{
			get
			{
				return sqlType;
			}
			set	
			{
				sqlType = value;
				DictionaryUtil.Add(QueryParameters, "SqlType", value);
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

		public long? MinConsume
		{
			get
			{
				return minConsume;
			}
			set	
			{
				minConsume = value;
				DictionaryUtil.Add(QueryParameters, "MinConsume", value.ToString());
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

		public string Columns
		{
			get
			{
				return columns;
			}
			set	
			{
				columns = value;
				DictionaryUtil.Add(QueryParameters, "Columns", value);
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

		public string QueryKeyword
		{
			get
			{
				return queryKeyword;
			}
			set	
			{
				queryKeyword = value;
				DictionaryUtil.Add(QueryParameters, "QueryKeyword", value);
			}
		}

		public long? MinScanRows
		{
			get
			{
				return minScanRows;
			}
			set	
			{
				minScanRows = value;
				DictionaryUtil.Add(QueryParameters, "MinScanRows", value.ToString());
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

		public long? MaxConsume
		{
			get
			{
				return maxConsume;
			}
			set	
			{
				maxConsume = value;
				DictionaryUtil.Add(QueryParameters, "MaxConsume", value.ToString());
			}
		}

		public int? ThreadID
		{
			get
			{
				return threadID;
			}
			set	
			{
				threadID = value;
				DictionaryUtil.Add(QueryParameters, "ThreadID", value.ToString());
			}
		}

		public string HostAddress
		{
			get
			{
				return hostAddress;
			}
			set	
			{
				hostAddress = value;
				DictionaryUtil.Add(QueryParameters, "HostAddress", value);
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

		public string AccountName
		{
			get
			{
				return accountName;
			}
			set	
			{
				accountName = value;
				DictionaryUtil.Add(QueryParameters, "AccountName", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
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

		public long? MaxScanRows
		{
			get
			{
				return maxScanRows;
			}
			set	
			{
				maxScanRows = value;
				DictionaryUtil.Add(QueryParameters, "MaxScanRows", value.ToString());
			}
		}

		public string State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
				DictionaryUtil.Add(QueryParameters, "State", value);
			}
		}

		public string TableName
		{
			get
			{
				return tableName;
			}
			set	
			{
				tableName = value;
				DictionaryUtil.Add(QueryParameters, "TableName", value);
			}
		}

        public override StartSqlLogDetailArchiveResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return StartSqlLogDetailArchiveResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}