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
using Aliyun.Acs.Dypnsapi.Transform;
using Aliyun.Acs.Dypnsapi.Transform.V20170525;

namespace Aliyun.Acs.Dypnsapi.Model.V20170525
{
    public class VerifyPhoneWithTokenRequest : RpcAcsRequest<VerifyPhoneWithTokenResponse>
    {
        public VerifyPhoneWithTokenRequest()
            : base("Dypnsapi", "2017-05-25", "VerifyPhoneWithToken", "dypns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string phoneNumber;

		private long? ownerId;

		private string spToken;

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

		public string PhoneNumber
		{
			get
			{
				return phoneNumber;
			}
			set	
			{
				phoneNumber = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNumber", value);
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

		public string SpToken
		{
			get
			{
				return spToken;
			}
			set	
			{
				spToken = value;
				DictionaryUtil.Add(QueryParameters, "SpToken", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override VerifyPhoneWithTokenResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return VerifyPhoneWithTokenResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
