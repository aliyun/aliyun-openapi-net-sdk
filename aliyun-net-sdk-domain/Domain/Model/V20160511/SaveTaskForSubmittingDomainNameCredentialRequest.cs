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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20160511;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Model.V20160511
{
    public class SaveTaskForSubmittingDomainNameCredentialRequest : RpcAcsRequest<SaveTaskForSubmittingDomainNameCredentialResponse>
    {
        public SaveTaskForSubmittingDomainNameCredentialRequest()
            : base("Domain", "2016-05-11", "SaveTaskForSubmittingDomainNameCredential")
        {
        }

		private string credentialNo;

		private string saleId;

		private string credential;

		private string userClientIp;

		private string domainName;

		private string lang;

		private string accessKeyId;

		public string CredentialNo
		{
			get
			{
				return credentialNo;
			}
			set	
			{
				credentialNo = value;
				DictionaryUtil.Add(QueryParameters, "CredentialNo", value);
			}
		}

		public string SaleId
		{
			get
			{
				return saleId;
			}
			set	
			{
				saleId = value;
				DictionaryUtil.Add(QueryParameters, "SaleId", value);
			}
		}

		public string Credential
		{
			get
			{
				return credential;
			}
			set	
			{
				credential = value;
				DictionaryUtil.Add(QueryParameters, "Credential", value);
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

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
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

        public override SaveTaskForSubmittingDomainNameCredentialResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveTaskForSubmittingDomainNameCredentialResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}