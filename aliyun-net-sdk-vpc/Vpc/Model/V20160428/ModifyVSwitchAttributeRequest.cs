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
    public class ModifyVSwitchAttributeRequest : RpcAcsRequest<ModifyVSwitchAttributeResponse>
    {
        public ModifyVSwitchAttributeRequest()
            : base("Vpc", "2016-04-28", "ModifyVSwitchAttribute", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private bool? enableIPv6;

		private string description;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private int? ipv6CidrBlock;

		private string vSwitchId;

		private string vpcIpv6CidrBlock;

		private string vSwitchName;

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

		public bool? EnableIPv6
		{
			get
			{
				return enableIPv6;
			}
			set	
			{
				enableIPv6 = value;
				DictionaryUtil.Add(QueryParameters, "EnableIPv6", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
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

		public int? Ipv6CidrBlock
		{
			get
			{
				return ipv6CidrBlock;
			}
			set	
			{
				ipv6CidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "Ipv6CidrBlock", value.ToString());
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

		public string VpcIpv6CidrBlock
		{
			get
			{
				return vpcIpv6CidrBlock;
			}
			set	
			{
				vpcIpv6CidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "VpcIpv6CidrBlock", value);
			}
		}

		public string VSwitchName
		{
			get
			{
				return vSwitchName;
			}
			set	
			{
				vSwitchName = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchName", value);
			}
		}

        public override ModifyVSwitchAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyVSwitchAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
