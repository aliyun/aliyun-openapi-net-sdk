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
using Aliyun.Acs.Domain;
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class RegistrantProfileRealNameVerificationRequest : RpcAcsRequest<RegistrantProfileRealNameVerificationResponse>
    {
        public RegistrantProfileRealNameVerificationRequest()
            : base("Domain", "2018-01-29", "RegistrantProfileRealNameVerification")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string identityCredentialType;

		private long? registrantProfileID;

		private string identityCredential;

		private string userClientIp;

		private string lang;

		private string identityCredentialNo;

		public string IdentityCredentialType
		{
			get
			{
				return identityCredentialType;
			}
			set	
			{
				identityCredentialType = value;
				DictionaryUtil.Add(QueryParameters, "IdentityCredentialType", value);
			}
		}

		public long? RegistrantProfileID
		{
			get
			{
				return registrantProfileID;
			}
			set	
			{
				registrantProfileID = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantProfileID", value.ToString());
			}
		}

		public string IdentityCredential
		{
			get
			{
				return identityCredential;
			}
			set	
			{
				identityCredential = value;
				DictionaryUtil.Add(BodyParameters, "IdentityCredential", value);
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string IdentityCredentialNo
		{
			get
			{
				return identityCredentialNo;
			}
			set	
			{
				identityCredentialNo = value;
				DictionaryUtil.Add(QueryParameters, "IdentityCredentialNo", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RegistrantProfileRealNameVerificationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RegistrantProfileRealNameVerificationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
