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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyImageSharePermissionRequest : RpcAcsRequest<ModifyImageSharePermissionResponse>
    {
        public ModifyImageSharePermissionRequest()
            : base("Ecs", "2014-05-26", "ModifyImageSharePermission")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _imageId;

		private string _addAccount1;

		private string _addAccount2;

		private string _addAccount3;

		private string _addAccount4;

		private string _addAccount5;

		private string _addAccount6;

		private string _addAccount7;

		private string _addAccount8;

		private string _addAccount9;

		private string _addAccount10;

		private string _removeAccount1;

		private string _removeAccount2;

		private string _removeAccount3;

		private string _removeAccount4;

		private string _removeAccount5;

		private string _removeAccount6;

		private string _removeAccount7;

		private string _removeAccount8;

		private string _removeAccount9;

		private string _removeAccount10;

		private string _ownerAccount;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ImageId
		{
			get
			{
				return _imageId;
			}
			set	
			{
				_imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		public string AddAccount1
		{
			get
			{
				return _addAccount1;
			}
			set	
			{
				_addAccount1 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.1", value);
			}
		}

		public string AddAccount2
		{
			get
			{
				return _addAccount2;
			}
			set	
			{
				_addAccount2 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.2", value);
			}
		}

		public string AddAccount3
		{
			get
			{
				return _addAccount3;
			}
			set	
			{
				_addAccount3 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.3", value);
			}
		}

		public string AddAccount4
		{
			get
			{
				return _addAccount4;
			}
			set	
			{
				_addAccount4 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.4", value);
			}
		}

		public string AddAccount5
		{
			get
			{
				return _addAccount5;
			}
			set	
			{
				_addAccount5 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.5", value);
			}
		}

		public string AddAccount6
		{
			get
			{
				return _addAccount6;
			}
			set	
			{
				_addAccount6 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.6", value);
			}
		}

		public string AddAccount7
		{
			get
			{
				return _addAccount7;
			}
			set	
			{
				_addAccount7 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.7", value);
			}
		}

		public string AddAccount8
		{
			get
			{
				return _addAccount8;
			}
			set	
			{
				_addAccount8 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.8", value);
			}
		}

		public string AddAccount9
		{
			get
			{
				return _addAccount9;
			}
			set	
			{
				_addAccount9 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.9", value);
			}
		}

		public string AddAccount10
		{
			get
			{
				return _addAccount10;
			}
			set	
			{
				_addAccount10 = value;
				DictionaryUtil.Add(QueryParameters, "AddAccount.10", value);
			}
		}

		public string RemoveAccount1
		{
			get
			{
				return _removeAccount1;
			}
			set	
			{
				_removeAccount1 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.1", value);
			}
		}

		public string RemoveAccount2
		{
			get
			{
				return _removeAccount2;
			}
			set	
			{
				_removeAccount2 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.2", value);
			}
		}

		public string RemoveAccount3
		{
			get
			{
				return _removeAccount3;
			}
			set	
			{
				_removeAccount3 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.3", value);
			}
		}

		public string RemoveAccount4
		{
			get
			{
				return _removeAccount4;
			}
			set	
			{
				_removeAccount4 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.4", value);
			}
		}

		public string RemoveAccount5
		{
			get
			{
				return _removeAccount5;
			}
			set	
			{
				_removeAccount5 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.5", value);
			}
		}

		public string RemoveAccount6
		{
			get
			{
				return _removeAccount6;
			}
			set	
			{
				_removeAccount6 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.6", value);
			}
		}

		public string RemoveAccount7
		{
			get
			{
				return _removeAccount7;
			}
			set	
			{
				_removeAccount7 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.7", value);
			}
		}

		public string RemoveAccount8
		{
			get
			{
				return _removeAccount8;
			}
			set	
			{
				_removeAccount8 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.8", value);
			}
		}

		public string RemoveAccount9
		{
			get
			{
				return _removeAccount9;
			}
			set	
			{
				_removeAccount9 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.9", value);
			}
		}

		public string RemoveAccount10
		{
			get
			{
				return _removeAccount10;
			}
			set	
			{
				_removeAccount10 = value;
				DictionaryUtil.Add(QueryParameters, "RemoveAccount.10", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

        public override ModifyImageSharePermissionResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyImageSharePermissionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}