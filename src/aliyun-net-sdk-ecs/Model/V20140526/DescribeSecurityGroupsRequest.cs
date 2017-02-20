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
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeSecurityGroupsRequest : RpcAcsRequest<DescribeSecurityGroupsResponse>
    {
        public DescribeSecurityGroupsRequest()
            : base("Ecs", "2014-05-26", "DescribeSecurityGroups")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _vpcId;

		private int? _pageNumber;

		private int? _pageSize;

		private string _ownerAccount;

		private string _securityGroupIds;

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

		private string _networkType;

		private string _securityGroupId;

		private string _securityGroupName;

		private bool? _isQueryEcsCount;

		private bool? _fuzzyQuery;

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

		public string VpcId
		{
			get
			{
				return _vpcId;
			}
			set	
			{
				_vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
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

		public string SecurityGroupIds
		{
			get
			{
				return _securityGroupIds;
			}
			set	
			{
				_securityGroupIds = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupIds", value);
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
				DictionaryUtil.Add(QueryParameters, "Tag.1.Key", value);
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
				DictionaryUtil.Add(QueryParameters, "Tag.2.Key", value);
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
				DictionaryUtil.Add(QueryParameters, "Tag.3.Key", value);
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
				DictionaryUtil.Add(QueryParameters, "Tag.4.Key", value);
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
				DictionaryUtil.Add(QueryParameters, "Tag.5.Key", value);
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
				DictionaryUtil.Add(QueryParameters, "Tag.1.Value", value);
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
				DictionaryUtil.Add(QueryParameters, "Tag.2.Value", value);
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
				DictionaryUtil.Add(QueryParameters, "Tag.3.Value", value);
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
				DictionaryUtil.Add(QueryParameters, "Tag.4.Value", value);
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
				DictionaryUtil.Add(QueryParameters, "Tag.5.Value", value);
			}
		}

		public string NetworkType
		{
			get
			{
				return _networkType;
			}
			set	
			{
				_networkType = value;
				DictionaryUtil.Add(QueryParameters, "NetworkType", value);
			}
		}

		public string SecurityGroupId
		{
			get
			{
				return _securityGroupId;
			}
			set	
			{
				_securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
			}
		}

		public string SecurityGroupName
		{
			get
			{
				return _securityGroupName;
			}
			set	
			{
				_securityGroupName = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupName", value);
			}
		}

		public bool? IsQueryEcsCount
		{
			get
			{
				return _isQueryEcsCount;
			}
			set	
			{
				_isQueryEcsCount = value;
				DictionaryUtil.Add(QueryParameters, "IsQueryEcsCount", value.ToString());
			}
		}

		public bool? FuzzyQuery
		{
			get
			{
				return _fuzzyQuery;
			}
			set	
			{
				_fuzzyQuery = value;
				DictionaryUtil.Add(QueryParameters, "FuzzyQuery", value.ToString());
			}
		}

        public override DescribeSecurityGroupsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeSecurityGroupsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}