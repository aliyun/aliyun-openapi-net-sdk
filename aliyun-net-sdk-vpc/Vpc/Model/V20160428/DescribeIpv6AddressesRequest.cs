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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class DescribeIpv6AddressesRequest : RpcAcsRequest<DescribeIpv6AddressesResponse>
    {
        public DescribeIpv6AddressesRequest()
            : base("Vpc", "2016-04-28", "DescribeIpv6Addresses", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string ipv6InternetBandwidthId;

		private string networkType;

		private int? pageNumber;

		private string associatedInstanceType;

		private int? pageSize;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string vSwitchId;

		private string ipv6AddressId;

		private string vpcId;

		private string name;

		private string ipv6Address;

		private string associatedInstanceId;

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

		public string Ipv6InternetBandwidthId
		{
			get
			{
				return ipv6InternetBandwidthId;
			}
			set	
			{
				ipv6InternetBandwidthId = value;
				DictionaryUtil.Add(QueryParameters, "Ipv6InternetBandwidthId", value);
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

		public string AssociatedInstanceType
		{
			get
			{
				return associatedInstanceType;
			}
			set	
			{
				associatedInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "AssociatedInstanceType", value);
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

		public string Ipv6AddressId
		{
			get
			{
				return ipv6AddressId;
			}
			set	
			{
				ipv6AddressId = value;
				DictionaryUtil.Add(QueryParameters, "Ipv6AddressId", value);
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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Ipv6Address
		{
			get
			{
				return ipv6Address;
			}
			set	
			{
				ipv6Address = value;
				DictionaryUtil.Add(QueryParameters, "Ipv6Address", value);
			}
		}

		public string AssociatedInstanceId
		{
			get
			{
				return associatedInstanceId;
			}
			set	
			{
				associatedInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "AssociatedInstanceId", value);
			}
		}

        public override DescribeIpv6AddressesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeIpv6AddressesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
