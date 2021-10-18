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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyImageSharePermissionRequest : RpcAcsRequest<ModifyImageSharePermissionResponse>
    {
        public ModifyImageSharePermissionRequest()
            : base("Ecs", "2014-05-26", "ModifyImageSharePermission", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string imageId;

		private bool? isPublic;

		private string launchPermission;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<string> addAccounts = new List<string>(){ };

		private List<string> removeAccounts = new List<string>(){ };

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

		[JsonProperty(PropertyName = "ImageId")]
		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		[JsonProperty(PropertyName = "IsPublic")]
		public bool? IsPublic
		{
			get
			{
				return isPublic;
			}
			set	
			{
				isPublic = value;
				DictionaryUtil.Add(QueryParameters, "IsPublic", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "LaunchPermission")]
		public string LaunchPermission
		{
			get
			{
				return launchPermission;
			}
			set	
			{
				launchPermission = value;
				DictionaryUtil.Add(QueryParameters, "LaunchPermission", value);
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

		[JsonProperty(PropertyName = "AddAccount")]
		public List<string> AddAccounts
		{
			get
			{
				return addAccounts;
			}

			set
			{
				addAccounts = value;
			}
		}

		[JsonProperty(PropertyName = "RemoveAccount")]
		public List<string> RemoveAccounts
		{
			get
			{
				return removeAccounts;
			}

			set
			{
				removeAccounts = value;
			}
		}

        public override ModifyImageSharePermissionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyImageSharePermissionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
