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
    public class DescribeEipAddressesRequest : RpcAcsRequest<DescribeEipAddressesResponse>
    {
        public DescribeEipAddressesRequest()
            : base("Ecs", "2014-05-26", "DescribeEipAddresses")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _status;

		private string _eipAddress;

		private string _allocationId;

		private int? _pageNumber;

		private int? _pageSize;

		private string _ownerAccount;

		private string _filter1Key;

		private string _filter2Key;

		private string _filter1Value;

		private string _filter2Value;

		private string _lockReason;

		private string _associatedInstanceType;

		private string _associatedInstanceId;

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

		public string Status
		{
			get
			{
				return _status;
			}
			set	
			{
				_status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public string EipAddress
		{
			get
			{
				return _eipAddress;
			}
			set	
			{
				_eipAddress = value;
				DictionaryUtil.Add(QueryParameters, "EipAddress", value);
			}
		}

		public string AllocationId
		{
			get
			{
				return _allocationId;
			}
			set	
			{
				_allocationId = value;
				DictionaryUtil.Add(QueryParameters, "AllocationId", value);
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

		public string Filter1Key
		{
			get
			{
				return _filter1Key;
			}
			set	
			{
				_filter1Key = value;
				DictionaryUtil.Add(QueryParameters, "Filter.1.Key", value);
			}
		}

		public string Filter2Key
		{
			get
			{
				return _filter2Key;
			}
			set	
			{
				_filter2Key = value;
				DictionaryUtil.Add(QueryParameters, "Filter.2.Key", value);
			}
		}

		public string Filter1Value
		{
			get
			{
				return _filter1Value;
			}
			set	
			{
				_filter1Value = value;
				DictionaryUtil.Add(QueryParameters, "Filter.1.Value", value);
			}
		}

		public string Filter2Value
		{
			get
			{
				return _filter2Value;
			}
			set	
			{
				_filter2Value = value;
				DictionaryUtil.Add(QueryParameters, "Filter.2.Value", value);
			}
		}

		public string LockReason
		{
			get
			{
				return _lockReason;
			}
			set	
			{
				_lockReason = value;
				DictionaryUtil.Add(QueryParameters, "LockReason", value);
			}
		}

		public string AssociatedInstanceType
		{
			get
			{
				return _associatedInstanceType;
			}
			set	
			{
				_associatedInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "AssociatedInstanceType", value);
			}
		}

		public string AssociatedInstanceId
		{
			get
			{
				return _associatedInstanceId;
			}
			set	
			{
				_associatedInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "AssociatedInstanceId", value);
			}
		}

        public override DescribeEipAddressesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeEipAddressesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}