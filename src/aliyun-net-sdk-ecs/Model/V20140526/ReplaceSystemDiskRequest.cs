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
    public class ReplaceSystemDiskRequest : RpcAcsRequest<ReplaceSystemDiskResponse>
    {
        public ReplaceSystemDiskRequest()
            : base("Ecs", "2014-05-26", "ReplaceSystemDisk")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _instanceId;

		private string _imageId;

		private int? _systemDiskSize;

		private string _clientToken;

		private string _ownerAccount;

		private bool? _useAdditionalService;

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

		public string InstanceId
		{
			get
			{
				return _instanceId;
			}
			set	
			{
				_instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
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

		public int? SystemDiskSize
		{
			get
			{
				return _systemDiskSize;
			}
			set	
			{
				_systemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Size", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return _clientToken;
			}
			set	
			{
				_clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
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

		public bool? UseAdditionalService
		{
			get
			{
				return _useAdditionalService;
			}
			set	
			{
				_useAdditionalService = value;
				DictionaryUtil.Add(QueryParameters, "UseAdditionalService", value.ToString());
			}
		}

        public override ReplaceSystemDiskResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ReplaceSystemDiskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}