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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifySecurityIpsForChannelRequest : RpcAcsRequest<ModifySecurityIpsForChannelResponse>
    {
        public ModifySecurityIpsForChannelRequest()
            : base("Rds", "2014-08-15", "ModifySecurityIpsForChannel")
        {
        }

		private long? ownerId;

		private string resourceOwnerAccount;

		private long? resourceOwnerId;

		private string clientToken;

		private string dBInstanceId;

		private string securityIps;

		private string dBInstanceIPArrayName;

		private string dBInstanceIPArrayAttribute;

		private string modifyMode;

		private string ownerAccount;

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

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
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

		public string DBInstanceIPArrayName
		{
			get
			{
				return dBInstanceIPArrayName;
			}
			set	
			{
				dBInstanceIPArrayName = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceIPArrayName", value);
			}
		}

		public string DBInstanceIPArrayAttribute
		{
			get
			{
				return dBInstanceIPArrayAttribute;
			}
			set	
			{
				dBInstanceIPArrayAttribute = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceIPArrayAttribute", value);
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

        public override ModifySecurityIpsForChannelResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifySecurityIpsForChannelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}