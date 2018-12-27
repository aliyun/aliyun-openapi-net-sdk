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
using Aliyun.Acs.R_kvstore.Transform;
using Aliyun.Acs.R_kvstore.Transform.V20150101;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
    public class UntagResourcesRequest : RpcAcsRequest<UntagResourcesResponse>
    {
        public UntagResourcesRequest()
            : base("R_kvstore", "2015-01-01", "UntagResources", "redisa", "openAPI")
        {
        }

		private string resourceId47;

		private string resourceId48;

		private long? resourceOwnerId;

		private string resourceId49;

		private string resourceId40;

		private string resourceId41;

		private string resourceId42;

		private string tagKey9;

		private string resourceId1;

		private string resourceId43;

		private string resourceId2;

		private string resourceId44;

		private string resourceId3;

		private string resourceId45;

		private string resourceId4;

		private string resourceId46;

		private string resourceId5;

		private string tagKey4;

		private string resourceId6;

		private string tagKey3;

		private string resourceId7;

		private string tagKey2;

		private string resourceId8;

		private string tagKey1;

		private string resourceId9;

		private string tagKey8;

		private string tagKey20;

		private string securityToken;

		private string tagKey7;

		private string tagKey6;

		private string tagKey5;

		private string action;

		private string resourceId36;

		private string resourceId37;

		private string resourceId38;

		private string resourceId39;

		private string resourceId30;

		private string resourceId31;

		private long? ownerId;

		private string resourceId32;

		private string resourceId33;

		private string resourceId34;

		private string resourceId35;

		private string resourceId25;

		private string resourceId26;

		private string resourceId27;

		private string resourceId28;

		private string resourceId29;

		private string resourceId20;

		private string resourceId21;

		private string resourceId22;

		private string resourceId23;

		private string accessKeyId;

		private string resourceId24;

		private string scope;

		private string resourceId14;

		private string resourceId15;

		private string resourceId16;

		private string tagKey19;

		private string resourceId17;

		private string tagKey18;

		private string resourceId18;

		private string resourceOwnerAccount;

		private string resourceId19;

		private string ownerAccount;

		private string resourceId50;

		private string resourceId10;

		private string resourceType;

		private string resourceId11;

		private string resourceId12;

		private string resourceId13;

		private string tagKey13;

		private string tagKey12;

		private string tagKey11;

		private string tagKey10;

		private string tagKey17;

		private string tagKey16;

		private string tagKey15;

		private string tagKey14;

		public string ResourceId47
		{
			get
			{
				return resourceId47;
			}
			set	
			{
				resourceId47 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.47", value);
			}
		}

		public string ResourceId48
		{
			get
			{
				return resourceId48;
			}
			set	
			{
				resourceId48 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.48", value);
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

		public string ResourceId49
		{
			get
			{
				return resourceId49;
			}
			set	
			{
				resourceId49 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.49", value);
			}
		}

		public string ResourceId40
		{
			get
			{
				return resourceId40;
			}
			set	
			{
				resourceId40 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.40", value);
			}
		}

		public string ResourceId41
		{
			get
			{
				return resourceId41;
			}
			set	
			{
				resourceId41 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.41", value);
			}
		}

		public string ResourceId42
		{
			get
			{
				return resourceId42;
			}
			set	
			{
				resourceId42 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.42", value);
			}
		}

		public string TagKey9
		{
			get
			{
				return tagKey9;
			}
			set	
			{
				tagKey9 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.9", value);
			}
		}

		public string ResourceId1
		{
			get
			{
				return resourceId1;
			}
			set	
			{
				resourceId1 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.1", value);
			}
		}

		public string ResourceId43
		{
			get
			{
				return resourceId43;
			}
			set	
			{
				resourceId43 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.43", value);
			}
		}

		public string ResourceId2
		{
			get
			{
				return resourceId2;
			}
			set	
			{
				resourceId2 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.2", value);
			}
		}

		public string ResourceId44
		{
			get
			{
				return resourceId44;
			}
			set	
			{
				resourceId44 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.44", value);
			}
		}

		public string ResourceId3
		{
			get
			{
				return resourceId3;
			}
			set	
			{
				resourceId3 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.3", value);
			}
		}

		public string ResourceId45
		{
			get
			{
				return resourceId45;
			}
			set	
			{
				resourceId45 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.45", value);
			}
		}

		public string ResourceId4
		{
			get
			{
				return resourceId4;
			}
			set	
			{
				resourceId4 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.4", value);
			}
		}

		public string ResourceId46
		{
			get
			{
				return resourceId46;
			}
			set	
			{
				resourceId46 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.46", value);
			}
		}

		public string ResourceId5
		{
			get
			{
				return resourceId5;
			}
			set	
			{
				resourceId5 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.5", value);
			}
		}

		public string TagKey4
		{
			get
			{
				return tagKey4;
			}
			set	
			{
				tagKey4 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.4", value);
			}
		}

		public string ResourceId6
		{
			get
			{
				return resourceId6;
			}
			set	
			{
				resourceId6 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.6", value);
			}
		}

		public string TagKey3
		{
			get
			{
				return tagKey3;
			}
			set	
			{
				tagKey3 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.3", value);
			}
		}

		public string ResourceId7
		{
			get
			{
				return resourceId7;
			}
			set	
			{
				resourceId7 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.7", value);
			}
		}

		public string TagKey2
		{
			get
			{
				return tagKey2;
			}
			set	
			{
				tagKey2 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.2", value);
			}
		}

		public string ResourceId8
		{
			get
			{
				return resourceId8;
			}
			set	
			{
				resourceId8 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.8", value);
			}
		}

		public string TagKey1
		{
			get
			{
				return tagKey1;
			}
			set	
			{
				tagKey1 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.1", value);
			}
		}

		public string ResourceId9
		{
			get
			{
				return resourceId9;
			}
			set	
			{
				resourceId9 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.9", value);
			}
		}

		public string TagKey8
		{
			get
			{
				return tagKey8;
			}
			set	
			{
				tagKey8 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.8", value);
			}
		}

		public string TagKey20
		{
			get
			{
				return tagKey20;
			}
			set	
			{
				tagKey20 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.20", value);
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

		public string TagKey7
		{
			get
			{
				return tagKey7;
			}
			set	
			{
				tagKey7 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.7", value);
			}
		}

		public string TagKey6
		{
			get
			{
				return tagKey6;
			}
			set	
			{
				tagKey6 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.6", value);
			}
		}

		public string TagKey5
		{
			get
			{
				return tagKey5;
			}
			set	
			{
				tagKey5 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.5", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string ResourceId36
		{
			get
			{
				return resourceId36;
			}
			set	
			{
				resourceId36 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.36", value);
			}
		}

		public string ResourceId37
		{
			get
			{
				return resourceId37;
			}
			set	
			{
				resourceId37 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.37", value);
			}
		}

		public string ResourceId38
		{
			get
			{
				return resourceId38;
			}
			set	
			{
				resourceId38 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.38", value);
			}
		}

		public string ResourceId39
		{
			get
			{
				return resourceId39;
			}
			set	
			{
				resourceId39 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.39", value);
			}
		}

		public string ResourceId30
		{
			get
			{
				return resourceId30;
			}
			set	
			{
				resourceId30 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.30", value);
			}
		}

		public string ResourceId31
		{
			get
			{
				return resourceId31;
			}
			set	
			{
				resourceId31 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.31", value);
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

		public string ResourceId32
		{
			get
			{
				return resourceId32;
			}
			set	
			{
				resourceId32 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.32", value);
			}
		}

		public string ResourceId33
		{
			get
			{
				return resourceId33;
			}
			set	
			{
				resourceId33 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.33", value);
			}
		}

		public string ResourceId34
		{
			get
			{
				return resourceId34;
			}
			set	
			{
				resourceId34 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.34", value);
			}
		}

		public string ResourceId35
		{
			get
			{
				return resourceId35;
			}
			set	
			{
				resourceId35 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.35", value);
			}
		}

		public string ResourceId25
		{
			get
			{
				return resourceId25;
			}
			set	
			{
				resourceId25 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.25", value);
			}
		}

		public string ResourceId26
		{
			get
			{
				return resourceId26;
			}
			set	
			{
				resourceId26 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.26", value);
			}
		}

		public string ResourceId27
		{
			get
			{
				return resourceId27;
			}
			set	
			{
				resourceId27 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.27", value);
			}
		}

		public string ResourceId28
		{
			get
			{
				return resourceId28;
			}
			set	
			{
				resourceId28 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.28", value);
			}
		}

		public string ResourceId29
		{
			get
			{
				return resourceId29;
			}
			set	
			{
				resourceId29 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.29", value);
			}
		}

		public string ResourceId20
		{
			get
			{
				return resourceId20;
			}
			set	
			{
				resourceId20 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.20", value);
			}
		}

		public string ResourceId21
		{
			get
			{
				return resourceId21;
			}
			set	
			{
				resourceId21 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.21", value);
			}
		}

		public string ResourceId22
		{
			get
			{
				return resourceId22;
			}
			set	
			{
				resourceId22 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.22", value);
			}
		}

		public string ResourceId23
		{
			get
			{
				return resourceId23;
			}
			set	
			{
				resourceId23 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.23", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string ResourceId24
		{
			get
			{
				return resourceId24;
			}
			set	
			{
				resourceId24 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.24", value);
			}
		}

		public string Scope
		{
			get
			{
				return scope;
			}
			set	
			{
				scope = value;
				DictionaryUtil.Add(QueryParameters, "Scope", value);
			}
		}

		public string ResourceId14
		{
			get
			{
				return resourceId14;
			}
			set	
			{
				resourceId14 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.14", value);
			}
		}

		public string ResourceId15
		{
			get
			{
				return resourceId15;
			}
			set	
			{
				resourceId15 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.15", value);
			}
		}

		public string ResourceId16
		{
			get
			{
				return resourceId16;
			}
			set	
			{
				resourceId16 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.16", value);
			}
		}

		public string TagKey19
		{
			get
			{
				return tagKey19;
			}
			set	
			{
				tagKey19 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.19", value);
			}
		}

		public string ResourceId17
		{
			get
			{
				return resourceId17;
			}
			set	
			{
				resourceId17 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.17", value);
			}
		}

		public string TagKey18
		{
			get
			{
				return tagKey18;
			}
			set	
			{
				tagKey18 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.18", value);
			}
		}

		public string ResourceId18
		{
			get
			{
				return resourceId18;
			}
			set	
			{
				resourceId18 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.18", value);
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

		public string ResourceId19
		{
			get
			{
				return resourceId19;
			}
			set	
			{
				resourceId19 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.19", value);
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

		public string ResourceId50
		{
			get
			{
				return resourceId50;
			}
			set	
			{
				resourceId50 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.50", value);
			}
		}

		public string ResourceId10
		{
			get
			{
				return resourceId10;
			}
			set	
			{
				resourceId10 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.10", value);
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public string ResourceId11
		{
			get
			{
				return resourceId11;
			}
			set	
			{
				resourceId11 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.11", value);
			}
		}

		public string ResourceId12
		{
			get
			{
				return resourceId12;
			}
			set	
			{
				resourceId12 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.12", value);
			}
		}

		public string ResourceId13
		{
			get
			{
				return resourceId13;
			}
			set	
			{
				resourceId13 = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId.13", value);
			}
		}

		public string TagKey13
		{
			get
			{
				return tagKey13;
			}
			set	
			{
				tagKey13 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.13", value);
			}
		}

		public string TagKey12
		{
			get
			{
				return tagKey12;
			}
			set	
			{
				tagKey12 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.12", value);
			}
		}

		public string TagKey11
		{
			get
			{
				return tagKey11;
			}
			set	
			{
				tagKey11 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.11", value);
			}
		}

		public string TagKey10
		{
			get
			{
				return tagKey10;
			}
			set	
			{
				tagKey10 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.10", value);
			}
		}

		public string TagKey17
		{
			get
			{
				return tagKey17;
			}
			set	
			{
				tagKey17 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.17", value);
			}
		}

		public string TagKey16
		{
			get
			{
				return tagKey16;
			}
			set	
			{
				tagKey16 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.16", value);
			}
		}

		public string TagKey15
		{
			get
			{
				return tagKey15;
			}
			set	
			{
				tagKey15 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.15", value);
			}
		}

		public string TagKey14
		{
			get
			{
				return tagKey14;
			}
			set	
			{
				tagKey14 = value;
				DictionaryUtil.Add(QueryParameters, "TagKey.14", value);
			}
		}

        public override UntagResourcesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UntagResourcesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}