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
    public class DescribeDBInstancesRequest : RpcAcsRequest<DescribeDBInstancesResponse>
    {
        public DescribeDBInstancesRequest()
            : base("Rds", "2014-08-15", "DescribeDBInstances")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _clientToken;

		private string _proxyId;

		private string _engine;

		private string _dBInstanceStatus;

		private string _searchKey;

		private string _dBInstanceId;

		private string _dBInstanceType;

		private int? _pageSize;

		private int? _pageNumber;

		private string _instanceNetworkType;

		private string _connectionMode;

		private string _tag1Key;

		private string _tag2Key;

		private string _tag3Key;

		private string _tag4Key;

		private string _tag5Key;

		private string _tag1Value;

		private string _tag2Value;

		private string _tag3Value;

		private string _tag4Value;

		private string _tag5Value;

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

		public string ProxyId
		{
			get
			{
				return _proxyId;
			}
			set	
			{
				_proxyId = value;
				DictionaryUtil.Add(QueryParameters, "proxyId", value);
			}
		}

		public string Engine
		{
			get
			{
				return _engine;
			}
			set	
			{
				_engine = value;
				DictionaryUtil.Add(QueryParameters, "Engine", value);
			}
		}

		public string DBInstanceStatus
		{
			get
			{
				return _dBInstanceStatus;
			}
			set	
			{
				_dBInstanceStatus = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceStatus", value);
			}
		}

		public string SearchKey
		{
			get
			{
				return _searchKey;
			}
			set	
			{
				_searchKey = value;
				DictionaryUtil.Add(QueryParameters, "SearchKey", value);
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

		public string DBInstanceType
		{
			get
			{
				return _dBInstanceType;
			}
			set	
			{
				_dBInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceType", value);
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

		public string InstanceNetworkType
		{
			get
			{
				return _instanceNetworkType;
			}
			set	
			{
				_instanceNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceNetworkType", value);
			}
		}

		public string ConnectionMode
		{
			get
			{
				return _connectionMode;
			}
			set	
			{
				_connectionMode = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionMode", value);
			}
		}

		public string Tag1Key
		{
			get
			{
				return _tag1Key;
			}
			set	
			{
				_tag1Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.key", value);
			}
		}

		public string Tag2Key
		{
			get
			{
				return _tag2Key;
			}
			set	
			{
				_tag2Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.key", value);
			}
		}

		public string Tag3Key
		{
			get
			{
				return _tag3Key;
			}
			set	
			{
				_tag3Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.key", value);
			}
		}

		public string Tag4Key
		{
			get
			{
				return _tag4Key;
			}
			set	
			{
				_tag4Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.key", value);
			}
		}

		public string Tag5Key
		{
			get
			{
				return _tag5Key;
			}
			set	
			{
				_tag5Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.key", value);
			}
		}

		public string Tag1Value
		{
			get
			{
				return _tag1Value;
			}
			set	
			{
				_tag1Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.value", value);
			}
		}

		public string Tag2Value
		{
			get
			{
				return _tag2Value;
			}
			set	
			{
				_tag2Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.value", value);
			}
		}

		public string Tag3Value
		{
			get
			{
				return _tag3Value;
			}
			set	
			{
				_tag3Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.value", value);
			}
		}

		public string Tag4Value
		{
			get
			{
				return _tag4Value;
			}
			set	
			{
				_tag4Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.value", value);
			}
		}

		public string Tag5Value
		{
			get
			{
				return _tag5Value;
			}
			set	
			{
				_tag5Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.value", value);
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

        public override DescribeDBInstancesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeDBInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}