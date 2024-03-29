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
    public class AssociateVpcCidrBlockRequest : RpcAcsRequest<AssociateVpcCidrBlockResponse>
    {
        public AssociateVpcCidrBlockRequest()
            : base("Vpc", "2016-04-28", "AssociateVpcCidrBlock", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string ipv6Isp;

		private string ipVersion;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string iPv6CidrBlock;

		private string secondaryCidrBlock;

		private string vpcId;

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

		public string Ipv6Isp
		{
			get
			{
				return ipv6Isp;
			}
			set	
			{
				ipv6Isp = value;
				DictionaryUtil.Add(QueryParameters, "Ipv6Isp", value);
			}
		}

		public string IpVersion
		{
			get
			{
				return ipVersion;
			}
			set	
			{
				ipVersion = value;
				DictionaryUtil.Add(QueryParameters, "IpVersion", value);
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

		public string IPv6CidrBlock
		{
			get
			{
				return iPv6CidrBlock;
			}
			set	
			{
				iPv6CidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "IPv6CidrBlock", value);
			}
		}

		public string SecondaryCidrBlock
		{
			get
			{
				return secondaryCidrBlock;
			}
			set	
			{
				secondaryCidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "SecondaryCidrBlock", value);
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

        public override AssociateVpcCidrBlockResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AssociateVpcCidrBlockResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
