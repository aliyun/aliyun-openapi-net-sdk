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
using Aliyun.Acs.WebsiteBuild;
using Aliyun.Acs.WebsiteBuild.Transform;
using Aliyun.Acs.WebsiteBuild.Transform.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
    public class SetAppDomainCertificateRequest : RpcAcsRequest<SetAppDomainCertificateResponse>
    {
        public SetAppDomainCertificateRequest()
            : base("WebsiteBuild", "2025-04-29", "SetAppDomainCertificate")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string domainName;

		private string publicKey;

		private string certificateType;

		private string privateKey;

		private string bizId;

		private string certificateName;

		[JsonProperty(PropertyName = "DomainName")]
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

		[JsonProperty(PropertyName = "PublicKey")]
		public string PublicKey
		{
			get
			{
				return publicKey;
			}
			set	
			{
				publicKey = value;
				DictionaryUtil.Add(QueryParameters, "PublicKey", value);
			}
		}

		[JsonProperty(PropertyName = "CertificateType")]
		public string CertificateType
		{
			get
			{
				return certificateType;
			}
			set	
			{
				certificateType = value;
				DictionaryUtil.Add(QueryParameters, "CertificateType", value);
			}
		}

		[JsonProperty(PropertyName = "PrivateKey")]
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

		[JsonProperty(PropertyName = "BizId")]
		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		[JsonProperty(PropertyName = "CertificateName")]
		public string CertificateName
		{
			get
			{
				return certificateName;
			}
			set	
			{
				certificateName = value;
				DictionaryUtil.Add(QueryParameters, "CertificateName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetAppDomainCertificateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetAppDomainCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
