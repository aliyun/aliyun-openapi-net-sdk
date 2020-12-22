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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Slb.Transform;
using Aliyun.Acs.Slb.Transform.V20140515;

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class UploadServerCertificateRequest : RpcAcsRequest<UploadServerCertificateResponse>
    {
        public UploadServerCertificateRequest()
            : base("Slb", "2014-05-15", "UploadServerCertificate", "slb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Slb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Slb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string serverCertificate;

		private string aliCloudCertificateName;

		private string aliCloudCertificateId;

		private string privateKey;

		private string resourceGroupId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string aliCloudCertificateRegionId;

		private string serverCertificateName;

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

		public string AliCloudCertificateRegionId
		{
			get
			{
				return aliCloudCertificateRegionId;
			}
			set	
			{
				aliCloudCertificateRegionId = value;
				DictionaryUtil.Add(QueryParameters, "AliCloudCertificateRegionId", value);
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

        public override UploadServerCertificateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UploadServerCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
