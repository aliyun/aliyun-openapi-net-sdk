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
    public class ReplaceSystemDiskRequest : RpcAcsRequest<ReplaceSystemDiskResponse>
    {
        public ReplaceSystemDiskRequest()
            : base("Ecs", "2014-05-26", "ReplaceSystemDisk", "ecs", "openAPI")
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

		private string clientToken;

		private string securityEnhancementStrategy;

		private string keyPairName;

		private string platform;

		private string password;

		private bool? passwordInherit;

		private string diskId;

		private string architecture;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string instanceId;

		private int? systemDiskSize;

		private bool? useAdditionalService;

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

		public string SecurityEnhancementStrategy
		{
			get
			{
				return securityEnhancementStrategy;
			}
			set	
			{
				securityEnhancementStrategy = value;
				DictionaryUtil.Add(QueryParameters, "SecurityEnhancementStrategy", value);
			}
		}

		public string KeyPairName
		{
			get
			{
				return keyPairName;
			}
			set	
			{
				keyPairName = value;
				DictionaryUtil.Add(QueryParameters, "KeyPairName", value);
			}
		}

		public string Platform
		{
			get
			{
				return platform;
			}
			set	
			{
				platform = value;
				DictionaryUtil.Add(QueryParameters, "Platform", value);
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public bool? PasswordInherit
		{
			get
			{
				return passwordInherit;
			}
			set	
			{
				passwordInherit = value;
				DictionaryUtil.Add(QueryParameters, "PasswordInherit", value.ToString());
			}
		}

		public string DiskId
		{
			get
			{
				return diskId;
			}
			set	
			{
				diskId = value;
				DictionaryUtil.Add(QueryParameters, "DiskId", value);
			}
		}

		public string Architecture
		{
			get
			{
				return architecture;
			}
			set	
			{
				architecture = value;
				DictionaryUtil.Add(QueryParameters, "Architecture", value);
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

		public int? SystemDiskSize
		{
			get
			{
				return systemDiskSize;
			}
			set	
			{
				systemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Size", value.ToString());
			}
		}

		public bool? UseAdditionalService
		{
			get
			{
				return useAdditionalService;
			}
			set	
			{
				useAdditionalService = value;
				DictionaryUtil.Add(QueryParameters, "UseAdditionalService", value.ToString());
			}
		}

        public override ReplaceSystemDiskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ReplaceSystemDiskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
