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
    public class ModifySslVpnServerRequest : RpcAcsRequest<ModifySslVpnServerResponse>
    {
        public ModifySslVpnServerRequest()
            : base("Vpc", "2016-04-28", "ModifySslVpnServer", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string sslVpnServerId;

		private string localSubnet;

		private string iDaaSRegionId;

		private bool? enableMultiFactorAuth;

		private string iDaaSInstanceId;

		private string cipher;

		private string clientIpPool;

		private string resourceOwnerAccount;

		private bool? compress;

		private string ownerAccount;

		private long? ownerId;

		private int? port;

		private string proto;

		private string name;

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

		public string SslVpnServerId
		{
			get
			{
				return sslVpnServerId;
			}
			set	
			{
				sslVpnServerId = value;
				DictionaryUtil.Add(QueryParameters, "SslVpnServerId", value);
			}
		}

		public string LocalSubnet
		{
			get
			{
				return localSubnet;
			}
			set	
			{
				localSubnet = value;
				DictionaryUtil.Add(QueryParameters, "LocalSubnet", value);
			}
		}

		public string IDaaSRegionId
		{
			get
			{
				return iDaaSRegionId;
			}
			set	
			{
				iDaaSRegionId = value;
				DictionaryUtil.Add(QueryParameters, "IDaaSRegionId", value);
			}
		}

		public bool? EnableMultiFactorAuth
		{
			get
			{
				return enableMultiFactorAuth;
			}
			set	
			{
				enableMultiFactorAuth = value;
				DictionaryUtil.Add(QueryParameters, "EnableMultiFactorAuth", value.ToString());
			}
		}

		public string IDaaSInstanceId
		{
			get
			{
				return iDaaSInstanceId;
			}
			set	
			{
				iDaaSInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IDaaSInstanceId", value);
			}
		}

		public string Cipher
		{
			get
			{
				return cipher;
			}
			set	
			{
				cipher = value;
				DictionaryUtil.Add(QueryParameters, "Cipher", value);
			}
		}

		public string ClientIpPool
		{
			get
			{
				return clientIpPool;
			}
			set	
			{
				clientIpPool = value;
				DictionaryUtil.Add(QueryParameters, "ClientIpPool", value);
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

		public bool? Compress
		{
			get
			{
				return compress;
			}
			set	
			{
				compress = value;
				DictionaryUtil.Add(QueryParameters, "Compress", value.ToString());
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

		public int? Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(QueryParameters, "Port", value.ToString());
			}
		}

		public string Proto
		{
			get
			{
				return proto;
			}
			set	
			{
				proto = value;
				DictionaryUtil.Add(QueryParameters, "Proto", value);
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

        public override ModifySslVpnServerResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySslVpnServerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
