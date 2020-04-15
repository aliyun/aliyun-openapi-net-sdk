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
using Aliyun.Acs.Netana.Transform;
using Aliyun.Acs.Netana.Transform.V20181018;

namespace Aliyun.Acs.Netana.Model.V20181018
{
    public class CreateNetworkQuotaRequestRequest : RpcAcsRequest<CreateNetworkQuotaRequestResponse>
    {
        public CreateNetworkQuotaRequestRequest()
            : base("Netana", "2018-10-18", "CreateNetworkQuotaRequest", "Netana", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string requestQuantity;

		private string quotaPublicityName;

		private string mobilePhone;

		private string email;

		private string requestReason;

		private string product;

		private string resourceOwnerAccount;

		private string resourceType;

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

		public string RequestQuantity
		{
			get
			{
				return requestQuantity;
			}
			set	
			{
				requestQuantity = value;
				DictionaryUtil.Add(QueryParameters, "RequestQuantity", value);
			}
		}

		public string QuotaPublicityName
		{
			get
			{
				return quotaPublicityName;
			}
			set	
			{
				quotaPublicityName = value;
				DictionaryUtil.Add(QueryParameters, "QuotaPublicityName", value);
			}
		}

		public string MobilePhone
		{
			get
			{
				return mobilePhone;
			}
			set	
			{
				mobilePhone = value;
				DictionaryUtil.Add(QueryParameters, "MobilePhone", value);
			}
		}

		public string Email
		{
			get
			{
				return email;
			}
			set	
			{
				email = value;
				DictionaryUtil.Add(QueryParameters, "Email", value);
			}
		}

		public string RequestReason
		{
			get
			{
				return requestReason;
			}
			set	
			{
				requestReason = value;
				DictionaryUtil.Add(QueryParameters, "RequestReason", value);
			}
		}

		public string Product
		{
			get
			{
				return product;
			}
			set	
			{
				product = value;
				DictionaryUtil.Add(QueryParameters, "Product", value);
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

        public override CreateNetworkQuotaRequestResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateNetworkQuotaRequestResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
