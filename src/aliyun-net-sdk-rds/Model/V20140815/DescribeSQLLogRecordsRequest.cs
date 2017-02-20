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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribeSQLLogRecordsRequest : RpcAcsRequest<DescribeSQLLogRecordsResponse>
    {
        public DescribeSQLLogRecordsRequest()
            : base("Rds", "2014-08-15", "DescribeSQLLogRecords")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _clientToken;

		private string _dBInstanceId;

		private long? _sQlId;

		private string _queryKeywords;

		private string _startTime;

		private string _database;

		private string _user;

		private string _form;

		private string _endTime;

		private int? _pageSize;

		private int? _pageNumber;

		private string _ownerAccount;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return _clientToken;
			}
			set	
			{
				_clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return _dBInstanceId;
			}
			set	
			{
				_dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public long? SQLId
		{
			get
			{
				return _sQlId;
			}
			set	
			{
				_sQlId = value;
				DictionaryUtil.Add(QueryParameters, "SQLId", value.ToString());
			}
		}

		public string QueryKeywords
		{
			get
			{
				return _queryKeywords;
			}
			set	
			{
				_queryKeywords = value;
				DictionaryUtil.Add(QueryParameters, "QueryKeywords", value);
			}
		}

		public string StartTime
		{
			get
			{
				return _startTime;
			}
			set	
			{
				_startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string Database
		{
			get
			{
				return _database;
			}
			set	
			{
				_database = value;
				DictionaryUtil.Add(QueryParameters, "Database", value);
			}
		}

		public string User
		{
			get
			{
				return _user;
			}
			set	
			{
				_user = value;
				DictionaryUtil.Add(QueryParameters, "User", value);
			}
		}

		public string Form
		{
			get
			{
				return _form;
			}
			set	
			{
				_form = value;
				DictionaryUtil.Add(QueryParameters, "Form", value);
			}
		}

		public string EndTime
		{
			get
			{
				return _endTime;
			}
			set	
			{
				_endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return _pageSize;
			}
			set	
			{
				_pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return _pageNumber;
			}
			set	
			{
				_pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

        public override DescribeSQLLogRecordsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeSQLLogRecordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}