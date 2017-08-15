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
using Aliyun.Acs.Slb.Transform;
using Aliyun.Acs.Slb.Transform.V20140515;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class UploadServerCertificateRequest : RpcAcsRequest<UploadServerCertificateResponse>
    {
        public UploadServerCertificateRequest()
            : base("Slb", "2014-05-15", "UploadServerCertificate", "slb", "openAPI")
        {
        }

		private string access_key_id;

		private long? resourceOwnerId;

		private string serverCertificate;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string aliCloudCertificateName;

		private string aliCloudCertificateId;

		private long? ownerId;

		private string accessKeyId;

		private string tags;

		private string privateKey;

		private string resourceGroupId;

		private string regionId;

		private string action;

		private string serverCertificateName;

		public string Access_key_id
		{
			get
			{
				return access_key_id;
			}
			set	
			{
				access_key_id = value;
				DictionaryUtil.Add(QueryParameters, "access_key_id", value);
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

		public string ServerCertificate
		{
			get
			{
				return serverCertificate;
			}
			set	
			{
				serverCertificate = value;
				DictionaryUtil.Add(QueryParameters, "ServerCertificate", value);
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

		public string AliCloudCertificateName
		{
			get
			{
				return aliCloudCertificateName;
			}
			set	
			{
				aliCloudCertificateName = value;
				DictionaryUtil.Add(QueryParameters, "AliCloudCertificateName", value);
			}
		}

		public string AliCloudCertificateId
		{
			get
			{
				return aliCloudCertificateId;
			}
			set	
			{
				aliCloudCertificateId = value;
				DictionaryUtil.Add(QueryParameters, "AliCloudCertificateId", value);
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

		public string PrivateKey
		{
			get
			{
				return privateKey;
			}
			set	
			{
				privateKey = value;
				DictionaryUtil.Add(QueryParameters, "PrivateKey", value);
			}
		}

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

		public string ServerCertificateName
		{
			get
			{
				return serverCertificateName;
			}
			set	
			{
				serverCertificateName = value;
				DictionaryUtil.Add(QueryParameters, "ServerCertificateName", value);
			}
		}

        public override UploadServerCertificateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UploadServerCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}