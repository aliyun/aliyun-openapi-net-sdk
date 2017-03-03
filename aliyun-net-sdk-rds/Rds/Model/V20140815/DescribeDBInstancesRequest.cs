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
    public class DescribeDBInstancesRequest : RpcAcsRequest<DescribeDBInstancesResponse>
    {
        public DescribeDBInstancesRequest()
            : base("Rds", "2014-08-15", "DescribeDBInstances")
        {
        }

		private long? ownerId;

		private string resourceOwnerAccount;

		private long? resourceOwnerId;

		private string clientToken;

		private string proxyId;

		private string engine;

		private string dBInstanceStatus;

		private string searchKey;

		private string dBInstanceId;

		private string dBInstanceType;

		private int? pageSize;

		private int? pageNumber;

		private string instanceNetworkType;

		private string connectionMode;

		private string tag1key;

		private string tag2key;

		private string tag3key;

		private string tag4key;

		private string tag5key;

		private string tag1value;

		private string tag2value;

		private string tag3value;

		private string tag4value;

		private string tag5value;

		private string tags;

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

		public string ProxyId
		{
			get
			{
				return proxyId;
			}
			set	
			{
				proxyId = value;
				DictionaryUtil.Add(QueryParameters, "proxyId", value);
			}
		}

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
				DictionaryUtil.Add(QueryParameters, "Engine", value);
			}
		}

		public string DBInstanceStatus
		{
			get
			{
				return dBInstanceStatus;
			}
			set	
			{
				dBInstanceStatus = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceStatus", value);
			}
		}

		public string SearchKey
		{
			get
			{
				return searchKey;
			}
			set	
			{
				searchKey = value;
				DictionaryUtil.Add(QueryParameters, "SearchKey", value);
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

		public string DBInstanceType
		{
			get
			{
				return dBInstanceType;
			}
			set	
			{
				dBInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceType", value);
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

		public string InstanceNetworkType
		{
			get
			{
				return instanceNetworkType;
			}
			set	
			{
				instanceNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceNetworkType", value);
			}
		}

		public string ConnectionMode
		{
			get
			{
				return connectionMode;
			}
			set	
			{
				connectionMode = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionMode", value);
			}
		}

		public string Tag1key
		{
			get
			{
				return tag1key;
			}
			set	
			{
				tag1key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.key", value);
			}
		}

		public string Tag2key
		{
			get
			{
				return tag2key;
			}
			set	
			{
				tag2key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.key", value);
			}
		}

		public string Tag3key
		{
			get
			{
				return tag3key;
			}
			set	
			{
				tag3key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.key", value);
			}
		}

		public string Tag4key
		{
			get
			{
				return tag4key;
			}
			set	
			{
				tag4key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.key", value);
			}
		}

		public string Tag5key
		{
			get
			{
				return tag5key;
			}
			set	
			{
				tag5key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.key", value);
			}
		}

		public string Tag1value
		{
			get
			{
				return tag1value;
			}
			set	
			{
				tag1value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.value", value);
			}
		}

		public string Tag2value
		{
			get
			{
				return tag2value;
			}
			set	
			{
				tag2value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.value", value);
			}
		}

		public string Tag3value
		{
			get
			{
				return tag3value;
			}
			set	
			{
				tag3value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.value", value);
			}
		}

		public string Tag4value
		{
			get
			{
				return tag4value;
			}
			set	
			{
				tag4value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.value", value);
			}
		}

		public string Tag5value
		{
			get
			{
				return tag5value;
			}
			set	
			{
				tag5value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.value", value);
			}
		}

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
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

        public override DescribeDBInstancesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeDBInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}