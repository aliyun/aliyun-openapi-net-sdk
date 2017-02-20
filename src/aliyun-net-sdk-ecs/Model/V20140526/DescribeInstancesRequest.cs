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
    public class DescribeInstancesRequest : RpcAcsRequest<DescribeInstancesResponse>
    {
        public DescribeInstancesRequest()
            : base("Ecs", "2014-05-26", "DescribeInstances")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _vpcId;

		private string _vSwitchId;

		private string _zoneId;

		private string _instanceNetworkType;

		private string _securityGroupId;

		private string _instanceIds;

		private int? _pageNumber;

		private int? _pageSize;

		private string _innerIpAddresses;

		private string _privateIpAddresses;

		private string _publicIpAddresses;

		private string _ownerAccount;

		private string _instanceChargeType;

		private string _internetChargeType;

		private string _instanceName;

		private string _imageId;

		private string _status;

		private string _lockReason;

		private string _filter1Key;

		private string _filter2Key;

		private string _filter3Key;

		private string _filter4Key;

		private string _filter1Value;

		private string _filter2Value;

		private string _filter3Value;

		private string _filter4Value;

		private bool? _deviceAvailable;

		private bool? _ioOptimized;

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

		private string _instanceType;

		private string _instanceTypeFamily;

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

		public string VSwitchId
		{
			get
			{
				return _vSwitchId;
			}
			set	
			{
				_vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return _zoneId;
			}
			set	
			{
				_zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
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

		public string InstanceIds
		{
			get
			{
				return _instanceIds;
			}
			set	
			{
				_instanceIds = value;
				DictionaryUtil.Add(QueryParameters, "InstanceIds", value);
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

		public string InnerIpAddresses
		{
			get
			{
				return _innerIpAddresses;
			}
			set	
			{
				_innerIpAddresses = value;
				DictionaryUtil.Add(QueryParameters, "InnerIpAddresses", value);
			}
		}

		public string PrivateIpAddresses
		{
			get
			{
				return _privateIpAddresses;
			}
			set	
			{
				_privateIpAddresses = value;
				DictionaryUtil.Add(QueryParameters, "PrivateIpAddresses", value);
			}
		}

		public string PublicIpAddresses
		{
			get
			{
				return _publicIpAddresses;
			}
			set	
			{
				_publicIpAddresses = value;
				DictionaryUtil.Add(QueryParameters, "PublicIpAddresses", value);
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

		public string InstanceChargeType
		{
			get
			{
				return _instanceChargeType;
			}
			set	
			{
				_instanceChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceChargeType", value);
			}
		}

		public string InternetChargeType
		{
			get
			{
				return _internetChargeType;
			}
			set	
			{
				_internetChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
			}
		}

		public string InstanceName
		{
			get
			{
				return _instanceName;
			}
			set	
			{
				_instanceName = value;
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
			}
		}

		public string ImageId
		{
			get
			{
				return _imageId;
			}
			set	
			{
				_imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
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

		public string Filter3Key
		{
			get
			{
				return _filter3Key;
			}
			set	
			{
				_filter3Key = value;
				DictionaryUtil.Add(QueryParameters, "Filter.3.Key", value);
			}
		}

		public string Filter4Key
		{
			get
			{
				return _filter4Key;
			}
			set	
			{
				_filter4Key = value;
				DictionaryUtil.Add(QueryParameters, "Filter.4.Key", value);
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

		public string Filter3Value
		{
			get
			{
				return _filter3Value;
			}
			set	
			{
				_filter3Value = value;
				DictionaryUtil.Add(QueryParameters, "Filter.3.Value", value);
			}
		}

		public string Filter4Value
		{
			get
			{
				return _filter4Value;
			}
			set	
			{
				_filter4Value = value;
				DictionaryUtil.Add(QueryParameters, "Filter.4.Value", value);
			}
		}

		public bool? DeviceAvailable
		{
			get
			{
				return _deviceAvailable;
			}
			set	
			{
				_deviceAvailable = value;
				DictionaryUtil.Add(QueryParameters, "DeviceAvailable", value.ToString());
			}
		}

		public bool? IoOptimized
		{
			get
			{
				return _ioOptimized;
			}
			set	
			{
				_ioOptimized = value;
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value.ToString());
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

		public string InstanceType
		{
			get
			{
				return _instanceType;
			}
			set	
			{
				_instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string InstanceTypeFamily
		{
			get
			{
				return _instanceTypeFamily;
			}
			set	
			{
				_instanceTypeFamily = value;
				DictionaryUtil.Add(QueryParameters, "InstanceTypeFamily", value);
			}
		}

        public override DescribeInstancesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}