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
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string imageId;

		private string launchPermission;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<string> addAccounts = new List<string>(){ };

		private List<string> removeAccounts = new List<string>(){ };

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

		public List<string> AddAccounts
		{
			get
			{
				return addAccounts;
			}

			set
			{
				addAccounts = value;
				for (int i = 0; i < addAccounts.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AddAccount." + (i + 1) , addAccounts[i]);
				}
			}
		}

		public List<string> RemoveAccounts
		{
			get
			{
				return removeAccounts;
			}

			set
			{
				removeAccounts = value;
				for (int i = 0; i < removeAccounts.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RemoveAccount." + (i + 1) , removeAccounts[i]);
				}
			}
		}

        public override ModifyImageSharePermissionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyImageSharePermissionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
