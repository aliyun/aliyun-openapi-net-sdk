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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyImageSharePermissionRequest : RpcAcsRequest<ModifyImageSharePermissionResponse>
    {
        public ModifyImageSharePermissionRequest()
            : base("Ecs", "2014-05-26", "ModifyImageSharePermission", "ecs", "openAPI")
        {
        }

		private string addAccount1;

		private long? resourceOwnerId;

		private string imageId;

		private string regionId;

		private string addAccount9;

		private string action;

		private string addAccount8;

		private string addAccount7;

		private string addAccount6;

		private string addAccount5;

		private string addAccount10;

		private string addAccount4;

		private string addAccount3;

		private string addAccount2;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string removeAccount1;

		private string removeAccount2;

		private string removeAccount3;

		private string removeAccount4;

		private long? ownerId;

		private string removeAccount9;

		private string removeAccount5;

		private string removeAccount6;

		private string removeAccount7;

		private string removeAccount8;

		private string removeAccount10;

		public string AddAccount1
		{
			get
			{
				return addAccount1;
			}
			set	
			{
				addAccount1 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.1", value);
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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public string AddAccount9
		{
			get
			{
				return addAccount9;
			}
			set	
			{
				addAccount9 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.9", value);
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

		public string AddAccount8
		{
			get
			{
				return addAccount8;
			}
			set	
			{
				addAccount8 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.8", value);
			}
		}

		public string AddAccount7
		{
			get
			{
				return addAccount7;
			}
			set	
			{
				addAccount7 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.7", value);
			}
		}

		public string AddAccount6
		{
			get
			{
				return addAccount6;
			}
			set	
			{
				addAccount6 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.6", value);
			}
		}

		public string AddAccount5
		{
			get
			{
				return addAccount5;
			}
			set	
			{
				addAccount5 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.5", value);
			}
		}

		public string AddAccount10
		{
			get
			{
				return addAccount10;
			}
			set	
			{
				addAccount10 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.10", value);
			}
		}

		public string AddAccount4
		{
			get
			{
				return addAccount4;
			}
			set	
			{
				addAccount4 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.4", value);
			}
		}

		public string AddAccount3
		{
			get
			{
				return addAccount3;
			}
			set	
			{
				addAccount3 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.3", value);
			}
		}

		public string AddAccount2
		{
			get
			{
				return addAccount2;
			}
			set	
			{
				addAccount2 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.2", value);
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

		public string RemoveAccount1
		{
			get
			{
				return removeAccount1;
			}
			set	
			{
				removeAccount1 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.1", value);
			}
		}

		public string RemoveAccount2
		{
			get
			{
				return removeAccount2;
			}
			set	
			{
				removeAccount2 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.2", value);
			}
		}

		public string RemoveAccount3
		{
			get
			{
				return removeAccount3;
			}
			set	
			{
				removeAccount3 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.3", value);
			}
		}

		public string RemoveAccount4
		{
			get
			{
				return removeAccount4;
			}
			set	
			{
				removeAccount4 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.4", value);
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

		public string RemoveAccount9
		{
			get
			{
				return removeAccount9;
			}
			set	
			{
				removeAccount9 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.9", value);
			}
		}

		public string RemoveAccount5
		{
			get
			{
				return removeAccount5;
			}
			set	
			{
				removeAccount5 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.5", value);
			}
		}

		public string RemoveAccount6
		{
			get
			{
				return removeAccount6;
			}
			set	
			{
				removeAccount6 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.6", value);
			}
		}

		public string RemoveAccount7
		{
			get
			{
				return removeAccount7;
			}
			set	
			{
				removeAccount7 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.7", value);
			}
		}

		public string RemoveAccount8
		{
			get
			{
				return removeAccount8;
			}
			set	
			{
				removeAccount8 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.8", value);
			}
		}

		public string RemoveAccount10
		{
			get
			{
				return removeAccount10;
			}
			set	
			{
				removeAccount10 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.10", value);
			}
		}

        public override ModifyImageSharePermissionResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyImageSharePermissionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}