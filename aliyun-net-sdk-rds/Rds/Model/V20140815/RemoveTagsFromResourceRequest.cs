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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class RemoveTagsFromResourceRequest : RpcAcsRequest<RemoveTagsFromResourceResponse>
    {
        public RemoveTagsFromResourceRequest()
            : base("Rds", "2014-08-15", "RemoveTagsFromResource", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string tag4value;

		private long? resourceOwnerId;

		private string tag2key;

		private string clientToken;

		private string tag3key;

		private string tag1value;

		private string resourceGroupId;

		private string dBInstanceId;

		private string tag3value;

		private string proxyId;

		private string tag5key;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string tag5value;

		private string tags;

		private string tag1key;

		private string tag2value;

		private string tag4key;

		[JsonProperty(PropertyName = "Tag.4.value")]
		public string Tag4value
		{
			get
			{
				return tag4value;
			}
			set	
			{
				tag4value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.value", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "Tag.2.key")]
		public string Tag2key
		{
			get
			{
				return tag2key;
			}
			set	
			{
				tag2key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.key", value);
			}
		}

		[JsonProperty(PropertyName = "ClientToken")]
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

		[JsonProperty(PropertyName = "Tag.3.key")]
		public string Tag3key
		{
			get
			{
				return tag3key;
			}
			set	
			{
				tag3key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.key", value);
			}
		}

		[JsonProperty(PropertyName = "Tag.1.value")]
		public string Tag1value
		{
			get
			{
				return tag1value;
			}
			set	
			{
				tag1value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.value", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceGroupId")]
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

		[JsonProperty(PropertyName = "DBInstanceId")]
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

		[JsonProperty(PropertyName = "Tag.3.value")]
		public string Tag3value
		{
			get
			{
				return tag3value;
			}
			set	
			{
				tag3value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.value", value);
			}
		}

		[JsonProperty(PropertyName = "proxyId")]
		public string ProxyId
		{
			get
			{
				return proxyId;
			}
			set	
			{
				proxyId = value;
				DictionaryUtil.Add(QueryParameters, "proxyId", value);
			}
		}

		[JsonProperty(PropertyName = "Tag.5.key")]
		public string Tag5key
		{
			get
			{
				return tag5key;
			}
			set	
			{
				tag5key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.key", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "Tag.5.value")]
		public string Tag5value
		{
			get
			{
				return tag5value;
			}
			set	
			{
				tag5value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.value", value);
			}
		}

		[JsonProperty(PropertyName = "Tags")]
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

		[JsonProperty(PropertyName = "Tag.1.key")]
		public string Tag1key
		{
			get
			{
				return tag1key;
			}
			set	
			{
				tag1key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.key", value);
			}
		}

		[JsonProperty(PropertyName = "Tag.2.value")]
		public string Tag2value
		{
			get
			{
				return tag2value;
			}
			set	
			{
				tag2value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.value", value);
			}
		}

		[JsonProperty(PropertyName = "Tag.4.key")]
		public string Tag4key
		{
			get
			{
				return tag4key;
			}
			set	
			{
				tag4key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.key", value);
			}
		}

        public override RemoveTagsFromResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RemoveTagsFromResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
