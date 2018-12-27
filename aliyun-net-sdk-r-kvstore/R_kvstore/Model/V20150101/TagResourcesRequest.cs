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
    public class TagResourcesRequest : RpcAcsRequest<TagResourcesResponse>
    {
        public TagResourcesRequest()
            : base("R_kvstore", "2015-01-01", "TagResources", "redisa", "openAPI")
        {
        }

		private string resourceId47;

		private string resourceId48;

		private string resourceId49;

		private string tag2Key;

		private string tag12Value;

		private string resourceId40;

		private string resourceId41;

		private string resourceId42;

		private string resourceId1;

		private string resourceId43;

		private string resourceId2;

		private string resourceId44;

		private string resourceId3;

		private string resourceId45;

		private string resourceId4;

		private string resourceId46;

		private string resourceId5;

		private string resourceId6;

		private string resourceId7;

		private string resourceId8;

		private string resourceId9;

		private string tag15Value;

		private string action;

		private string tag18Key;

		private string tag8Value;

		private string tag18Value;

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

		private string tag16Key;

		private string tag4Key;

		private string resourceId25;

		private string resourceId26;

		private string resourceId27;

		private string resourceId28;

		private string resourceId29;

		private string tag7Key;

		private string tag12Key;

		private string tag6Value;

		private string resourceId20;

		private string resourceId21;

		private string resourceId22;

		private string resourceId23;

		private string resourceId24;

		private string tag14Key;

		private string tag13Value;

		private string resourceId14;

		private string resourceId15;

		private string tag10Key;

		private string resourceId16;

		private string resourceId17;

		private string resourceId18;

		private string resourceOwnerAccount;

		private string resourceId19;

		private string tag19Key;

		private string resourceId10;

		private string resourceType;

		private string resourceId11;

		private string tag5Value;

		private string resourceId12;

		private string resourceId13;

		private string tag9Key;

		private string tag19Value;

		private string tag4Value;

		private long? resourceOwnerId;

		private string tag17Key;

		private string tag3Key;

		private string tag1Value;

		private string securityToken;

		private string tag15Key;

		private string tag11Value;

		private string tag5Key;

		private string tag14Value;

		private string tag7Value;

		private string tag20Key;

		private string tag20Value;

		private string tag17Value;

		private string tag13Key;

		private string tag9Value;

		private string accessKeyId;

		private string tag6Key;

		private string scope;

		private string tag10Value;

		private string tag3Value;

		private string ownerAccount;

		private string resourceId50;

		private string tag16Value;

		private string tag1Key;

		private string tag8Key;

		private string tag11Key;

		private string tag2Value;

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

		public string Tag12Value
		{
			get
			{
				return tag12Value;
			}
			set	
			{
				tag12Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.12.Value", value);
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

		public string Tag15Value
		{
			get
			{
				return tag15Value;
			}
			set	
			{
				tag15Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.15.Value", value);
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

		public string Tag18Key
		{
			get
			{
				return tag18Key;
			}
			set	
			{
				tag18Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.18.Key", value);
			}
		}

		public string Tag8Value
		{
			get
			{
				return tag8Value;
			}
			set	
			{
				tag8Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.8.Value", value);
			}
		}

		public string Tag18Value
		{
			get
			{
				return tag18Value;
			}
			set	
			{
				tag18Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.18.Value", value);
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

		public string Tag16Key
		{
			get
			{
				return tag16Key;
			}
			set	
			{
				tag16Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.16.Key", value);
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

		public string Tag7Key
		{
			get
			{
				return tag7Key;
			}
			set	
			{
				tag7Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.7.Key", value);
			}
		}

		public string Tag12Key
		{
			get
			{
				return tag12Key;
			}
			set	
			{
				tag12Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.12.Key", value);
			}
		}

		public string Tag6Value
		{
			get
			{
				return tag6Value;
			}
			set	
			{
				tag6Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.6.Value", value);
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

		public string Tag14Key
		{
			get
			{
				return tag14Key;
			}
			set	
			{
				tag14Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.14.Key", value);
			}
		}

		public string Tag13Value
		{
			get
			{
				return tag13Value;
			}
			set	
			{
				tag13Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.13.Value", value);
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

		public string Tag10Key
		{
			get
			{
				return tag10Key;
			}
			set	
			{
				tag10Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.10.Key", value);
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

		public string Tag19Key
		{
			get
			{
				return tag19Key;
			}
			set	
			{
				tag19Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.19.Key", value);
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

		public string Tag9Key
		{
			get
			{
				return tag9Key;
			}
			set	
			{
				tag9Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.9.Key", value);
			}
		}

		public string Tag19Value
		{
			get
			{
				return tag19Value;
			}
			set	
			{
				tag19Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.19.Value", value);
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

		public string Tag17Key
		{
			get
			{
				return tag17Key;
			}
			set	
			{
				tag17Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.17.Key", value);
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

		public string Tag15Key
		{
			get
			{
				return tag15Key;
			}
			set	
			{
				tag15Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.15.Key", value);
			}
		}

		public string Tag11Value
		{
			get
			{
				return tag11Value;
			}
			set	
			{
				tag11Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.11.Value", value);
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

		public string Tag14Value
		{
			get
			{
				return tag14Value;
			}
			set	
			{
				tag14Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.14.Value", value);
			}
		}

		public string Tag7Value
		{
			get
			{
				return tag7Value;
			}
			set	
			{
				tag7Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.7.Value", value);
			}
		}

		public string Tag20Key
		{
			get
			{
				return tag20Key;
			}
			set	
			{
				tag20Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.20.Key", value);
			}
		}

		public string Tag20Value
		{
			get
			{
				return tag20Value;
			}
			set	
			{
				tag20Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.20.Value", value);
			}
		}

		public string Tag17Value
		{
			get
			{
				return tag17Value;
			}
			set	
			{
				tag17Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.17.Value", value);
			}
		}

		public string Tag13Key
		{
			get
			{
				return tag13Key;
			}
			set	
			{
				tag13Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.13.Key", value);
			}
		}

		public string Tag9Value
		{
			get
			{
				return tag9Value;
			}
			set	
			{
				tag9Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.9.Value", value);
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

		public string Tag6Key
		{
			get
			{
				return tag6Key;
			}
			set	
			{
				tag6Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.6.Key", value);
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

		public string Tag10Value
		{
			get
			{
				return tag10Value;
			}
			set	
			{
				tag10Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.10.Value", value);
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

		public string Tag16Value
		{
			get
			{
				return tag16Value;
			}
			set	
			{
				tag16Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.16.Value", value);
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

		public string Tag8Key
		{
			get
			{
				return tag8Key;
			}
			set	
			{
				tag8Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.8.Key", value);
			}
		}

		public string Tag11Key
		{
			get
			{
				return tag11Key;
			}
			set	
			{
				tag11Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.11.Key", value);
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

        public override TagResourcesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return TagResourcesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}