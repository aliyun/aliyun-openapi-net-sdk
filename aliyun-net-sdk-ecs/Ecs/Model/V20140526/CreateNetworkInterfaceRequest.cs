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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class CreateNetworkInterfaceRequest : RpcAcsRequest<CreateNetworkInterfaceResponse>
    {
        public CreateNetworkInterfaceRequest()
            : base("Ecs", "2014-05-26", "CreateNetworkInterface", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? queueNumber;

		private long? resourceOwnerId;

		private string clientToken;

		private string securityGroupId;

		private string description;

		private int? secondaryPrivateIpAddressCount;

		private string businessType;

		private string resourceGroupId;

		private string instanceType;

		private List<Tag> tags = new List<Tag>(){ };

		private string networkInterfaceName;

		private bool? visible;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<string> securityGroupIdss = new List<string>(){ };

		private string vSwitchId;

		private List<string> privateIpAddresss = new List<string>(){ };

		private string primaryIpAddress;

		public int? QueueNumber
		{
			get
			{
				return queueNumber;
			}
			set	
			{
				queueNumber = value;
				DictionaryUtil.Add(QueryParameters, "QueueNumber", value.ToString());
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

		public int? SecondaryPrivateIpAddressCount
		{
			get
			{
				return secondaryPrivateIpAddressCount;
			}
			set	
			{
				secondaryPrivateIpAddressCount = value;
				DictionaryUtil.Add(QueryParameters, "SecondaryPrivateIpAddressCount", value.ToString());
			}
		}

		public string BusinessType
		{
			get
			{
				return businessType;
			}
			set	
			{
				businessType = value;
				DictionaryUtil.Add(QueryParameters, "BusinessType", value);
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

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
				}
			}
		}

		public string NetworkInterfaceName
		{
			get
			{
				return networkInterfaceName;
			}
			set	
			{
				networkInterfaceName = value;
				DictionaryUtil.Add(QueryParameters, "NetworkInterfaceName", value);
			}
		}

		public bool? Visible
		{
			get
			{
				return visible;
			}
			set	
			{
				visible = value;
				DictionaryUtil.Add(QueryParameters, "Visible", value.ToString());
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

		public List<string> SecurityGroupIdss
		{
			get
			{
				return securityGroupIdss;
			}

			set
			{
				securityGroupIdss = value;
				for (int i = 0; i < securityGroupIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SecurityGroupIds." + (i + 1) , securityGroupIdss[i]);
				}
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

		public List<string> PrivateIpAddresss
		{
			get
			{
				return privateIpAddresss;
			}

			set
			{
				privateIpAddresss = value;
				for (int i = 0; i < privateIpAddresss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PrivateIpAddress." + (i + 1) , privateIpAddresss[i]);
				}
			}
		}

		public string PrimaryIpAddress
		{
			get
			{
				return primaryIpAddress;
			}
			set	
			{
				primaryIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "PrimaryIpAddress", value);
			}
		}

		public class Tag
		{

			private string key;

			private string value_;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}

        public override CreateNetworkInterfaceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateNetworkInterfaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
