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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Slb.Transform;
using Aliyun.Acs.Slb.Transform.V20140515;

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class DescribeLoadBalancersRequest : RpcAcsRequest<DescribeLoadBalancersResponse>
    {
        public DescribeLoadBalancersRequest()
            : base("Slb", "2014-05-15", "DescribeLoadBalancers", "slb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Slb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Slb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string networkType;

		private string addressIPVersion;

		private string masterZoneId;

		private string resourceGroupId;

		private string loadBalancerName;

		private string slaveZoneId;

		private long? ownerId;

		private string serverId;

		private string tags;

		private string serverIntranetAddress;

		private string vSwitchId;

		private string loadBalancerId;

		private string internetChargeType;

		private int? pageNumber;

		private int? pageSize;

		private string addressType;

		private string address;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string loadBalancerStatus;

		private string vpcId;

		private string payType;

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

		public string NetworkType
		{
			get
			{
				return networkType;
			}
			set	
			{
				networkType = value;
				DictionaryUtil.Add(QueryParameters, "NetworkType", value);
			}
		}

		public string AddressIPVersion
		{
			get
			{
				return addressIPVersion;
			}
			set	
			{
				addressIPVersion = value;
				DictionaryUtil.Add(QueryParameters, "AddressIPVersion", value);
			}
		}

		public string MasterZoneId
		{
			get
			{
				return masterZoneId;
			}
			set	
			{
				masterZoneId = value;
				DictionaryUtil.Add(QueryParameters, "MasterZoneId", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string LoadBalancerName
		{
			get
			{
				return loadBalancerName;
			}
			set	
			{
				loadBalancerName = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerName", value);
			}
		}

		public string SlaveZoneId
		{
			get
			{
				return slaveZoneId;
			}
			set	
			{
				slaveZoneId = value;
				DictionaryUtil.Add(QueryParameters, "SlaveZoneId", value);
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

		public string ServerId
		{
			get
			{
				return serverId;
			}
			set	
			{
				serverId = value;
				DictionaryUtil.Add(QueryParameters, "ServerId", value);
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

		public string ServerIntranetAddress
		{
			get
			{
				return serverIntranetAddress;
			}
			set	
			{
				serverIntranetAddress = value;
				DictionaryUtil.Add(QueryParameters, "ServerIntranetAddress", value);
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

		public string LoadBalancerId
		{
			get
			{
				return loadBalancerId;
			}
			set	
			{
				loadBalancerId = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerId", value);
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

		public string AddressType
		{
			get
			{
				return addressType;
			}
			set	
			{
				addressType = value;
				DictionaryUtil.Add(QueryParameters, "AddressType", value);
			}
		}

		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
				DictionaryUtil.Add(QueryParameters, "Address", value);
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

		public string LoadBalancerStatus
		{
			get
			{
				return loadBalancerStatus;
			}
			set	
			{
				loadBalancerStatus = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerStatus", value);
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

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
			}
		}

        public override DescribeLoadBalancersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeLoadBalancersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
