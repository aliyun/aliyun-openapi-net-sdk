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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeInstancesRequest : RpcAcsRequest<DescribeInstancesResponse>
    {
        public DescribeInstancesRequest()
            : base("Ecs", "2014-05-26", "DescribeInstances")
        {
        }

	private long? ownerId;

	private string resourceOwnerAccount;

	private long? resourceOwnerId;

	private string vpcId;

	private string vSwitchId;

	private string zoneId;

	private string instanceNetworkType;

	private string securityGroupId;

	private string instanceIds;

	private int? pageNumber;

	private int? pageSize;

	private string innerIpAddresses;

	private string privateIpAddresses;

	private string publicIpAddresses;

	private string ownerAccount;

	private string instanceChargeType;

	private string internetChargeType;

	private string instanceName;

	private string imageId;

	private string status;

	private string lockReason;

	private string filter1Key;

	private string filter2Key;

	private string filter3Key;

	private string filter4Key;

	private string filter1Value;

	private string filter2Value;

	private string filter3Value;

	private string filter4Value;

	private bool? deviceAvailable;

	private bool? ioOptimized;

	private string tag1Key;

	private string tag2Key;

	private string tag3Key;

	private string tag4Key;

	private string tag5Key;

	private string tag1Value;

	private string tag2Value;

	private string tag3Value;

	private string tag4Value;

	private string tag5Value;

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

	public string VpcId
	{
		get
		{
			return vpcId;
		}
		set	
		{
			vpcId = value;
			DictionaryUtil.Add(QueryParameters, "VpcId", value);
		}
	}

	public string VSwitchId
	{
		get
		{
			return vSwitchId;
		}
		set	
		{
			vSwitchId = value;
			DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
		}
	}

	public string ZoneId
	{
		get
		{
			return zoneId;
		}
		set	
		{
			zoneId = value;
			DictionaryUtil.Add(QueryParameters, "ZoneId", value);
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

	public string SecurityGroupId
	{
		get
		{
			return securityGroupId;
		}
		set	
		{
			securityGroupId = value;
			DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
		}
	}

	public string InstanceIds
	{
		get
		{
			return instanceIds;
		}
		set	
		{
			instanceIds = value;
			DictionaryUtil.Add(QueryParameters, "InstanceIds", value);
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

	public string InnerIpAddresses
	{
		get
		{
			return innerIpAddresses;
		}
		set	
		{
			innerIpAddresses = value;
			DictionaryUtil.Add(QueryParameters, "InnerIpAddresses", value);
		}
	}

	public string PrivateIpAddresses
	{
		get
		{
			return privateIpAddresses;
		}
		set	
		{
			privateIpAddresses = value;
			DictionaryUtil.Add(QueryParameters, "PrivateIpAddresses", value);
		}
	}

	public string PublicIpAddresses
	{
		get
		{
			return publicIpAddresses;
		}
		set	
		{
			publicIpAddresses = value;
			DictionaryUtil.Add(QueryParameters, "PublicIpAddresses", value);
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

	public string InstanceChargeType
	{
		get
		{
			return instanceChargeType;
		}
		set	
		{
			instanceChargeType = value;
			DictionaryUtil.Add(QueryParameters, "InstanceChargeType", value);
		}
	}

	public string InternetChargeType
	{
		get
		{
			return internetChargeType;
		}
		set	
		{
			internetChargeType = value;
			DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
		}
	}

	public string InstanceName
	{
		get
		{
			return instanceName;
		}
		set	
		{
			instanceName = value;
			DictionaryUtil.Add(QueryParameters, "InstanceName", value);
		}
	}

	public string ImageId
	{
		get
		{
			return imageId;
		}
		set	
		{
			imageId = value;
			DictionaryUtil.Add(QueryParameters, "ImageId", value);
		}
	}

	public string Status
	{
		get
		{
			return status;
		}
		set	
		{
			status = value;
			DictionaryUtil.Add(QueryParameters, "Status", value);
		}
	}

	public string LockReason
	{
		get
		{
			return lockReason;
		}
		set	
		{
			lockReason = value;
			DictionaryUtil.Add(QueryParameters, "LockReason", value);
		}
	}

	public string Filter1Key
	{
		get
		{
			return filter1Key;
		}
		set	
		{
			filter1Key = value;
			DictionaryUtil.Add(QueryParameters, "Filter.1.Key", value);
		}
	}

	public string Filter2Key
	{
		get
		{
			return filter2Key;
		}
		set	
		{
			filter2Key = value;
			DictionaryUtil.Add(QueryParameters, "Filter.2.Key", value);
		}
	}

	public string Filter3Key
	{
		get
		{
			return filter3Key;
		}
		set	
		{
			filter3Key = value;
			DictionaryUtil.Add(QueryParameters, "Filter.3.Key", value);
		}
	}

	public string Filter4Key
	{
		get
		{
			return filter4Key;
		}
		set	
		{
			filter4Key = value;
			DictionaryUtil.Add(QueryParameters, "Filter.4.Key", value);
		}
	}

	public string Filter1Value
	{
		get
		{
			return filter1Value;
		}
		set	
		{
			filter1Value = value;
			DictionaryUtil.Add(QueryParameters, "Filter.1.Value", value);
		}
	}

	public string Filter2Value
	{
		get
		{
			return filter2Value;
		}
		set	
		{
			filter2Value = value;
			DictionaryUtil.Add(QueryParameters, "Filter.2.Value", value);
		}
	}

	public string Filter3Value
	{
		get
		{
			return filter3Value;
		}
		set	
		{
			filter3Value = value;
			DictionaryUtil.Add(QueryParameters, "Filter.3.Value", value);
		}
	}

	public string Filter4Value
	{
		get
		{
			return filter4Value;
		}
		set	
		{
			filter4Value = value;
			DictionaryUtil.Add(QueryParameters, "Filter.4.Value", value);
		}
	}

	public bool? DeviceAvailable
	{
		get
		{
			return deviceAvailable;
		}
		set	
		{
			deviceAvailable = value;
			DictionaryUtil.Add(QueryParameters, "DeviceAvailable", value.ToString());
		}
	}

	public bool? IoOptimized
	{
		get
		{
			return ioOptimized;
		}
		set	
		{
			ioOptimized = value;
			DictionaryUtil.Add(QueryParameters, "IoOptimized", value.ToString());
		}
	}

	public string Tag1Key
	{
		get
		{
			return tag1Key;
		}
		set	
		{
			tag1Key = value;
			DictionaryUtil.Add(QueryParameters, "Tag.1.Key", value);
		}
	}

	public string Tag2Key
	{
		get
		{
			return tag2Key;
		}
		set	
		{
			tag2Key = value;
			DictionaryUtil.Add(QueryParameters, "Tag.2.Key", value);
		}
	}

	public string Tag3Key
	{
		get
		{
			return tag3Key;
		}
		set	
		{
			tag3Key = value;
			DictionaryUtil.Add(QueryParameters, "Tag.3.Key", value);
		}
	}

	public string Tag4Key
	{
		get
		{
			return tag4Key;
		}
		set	
		{
			tag4Key = value;
			DictionaryUtil.Add(QueryParameters, "Tag.4.Key", value);
		}
	}

	public string Tag5Key
	{
		get
		{
			return tag5Key;
		}
		set	
		{
			tag5Key = value;
			DictionaryUtil.Add(QueryParameters, "Tag.5.Key", value);
		}
	}

	public string Tag1Value
	{
		get
		{
			return tag1Value;
		}
		set	
		{
			tag1Value = value;
			DictionaryUtil.Add(QueryParameters, "Tag.1.Value", value);
		}
	}

	public string Tag2Value
	{
		get
		{
			return tag2Value;
		}
		set	
		{
			tag2Value = value;
			DictionaryUtil.Add(QueryParameters, "Tag.2.Value", value);
		}
	}

	public string Tag3Value
	{
		get
		{
			return tag3Value;
		}
		set	
		{
			tag3Value = value;
			DictionaryUtil.Add(QueryParameters, "Tag.3.Value", value);
		}
	}

	public string Tag4Value
	{
		get
		{
			return tag4Value;
		}
		set	
		{
			tag4Value = value;
			DictionaryUtil.Add(QueryParameters, "Tag.4.Value", value);
		}
	}

	public string Tag5Value
	{
		get
		{
			return tag5Value;
		}
		set	
		{
			tag5Value = value;
			DictionaryUtil.Add(QueryParameters, "Tag.5.Value", value);
		}
	}

        public override DescribeInstancesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}