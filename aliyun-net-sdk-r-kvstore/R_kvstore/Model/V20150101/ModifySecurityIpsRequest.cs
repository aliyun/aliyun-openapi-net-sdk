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
using Aliyun.Acs.R_kvstore.Transform;
using Aliyun.Acs.R_kvstore.Transform.V20150101;

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
    public class ModifySecurityIpsRequest : RpcAcsRequest<ModifySecurityIpsResponse>
    {
        public ModifySecurityIpsRequest()
            : base("R-kvstore", "2015-01-01", "ModifySecurityIps", "redisa", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.R_kvstore.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.R_kvstore.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string securityIps;

		private string securityIpGroupName;

		private string securityToken;

		private string modifyMode;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string instanceId;

		private string securityIpGroupAttribute;

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

		public string SecurityIps
		{
			get
			{
				return securityIps;
			}
			set	
			{
				securityIps = value;
				DictionaryUtil.Add(QueryParameters, "SecurityIps", value);
			}
		}

		public string SecurityIpGroupName
		{
			get
			{
				return securityIpGroupName;
			}
			set	
			{
				securityIpGroupName = value;
				DictionaryUtil.Add(QueryParameters, "SecurityIpGroupName", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string ModifyMode
		{
			get
			{
				return modifyMode;
			}
			set	
			{
				modifyMode = value;
				DictionaryUtil.Add(QueryParameters, "ModifyMode", value);
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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string SecurityIpGroupAttribute
		{
			get
			{
				return securityIpGroupAttribute;
			}
			set	
			{
				securityIpGroupAttribute = value;
				DictionaryUtil.Add(QueryParameters, "SecurityIpGroupAttribute", value);
			}
		}

        public override ModifySecurityIpsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySecurityIpsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
