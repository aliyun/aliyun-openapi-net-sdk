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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class SetLiveDomainCertificateRequest : RpcAcsRequest<SetLiveDomainCertificateResponse>
    {
        public SetLiveDomainCertificateRequest()
            : base("live", "2016-11-01", "SetLiveDomainCertificate", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sSLProtocol;

		private string securityToken;

		private string certType;

		private string sSLPri;

		private string forceSet;

		private string certName;

		private string domainName;

		private long? ownerId;

		private string sSLPub;

		public string SSLProtocol
		{
			get
			{
				return sSLProtocol;
			}
			set	
			{
				sSLProtocol = value;
				DictionaryUtil.Add(QueryParameters, "SSLProtocol", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string CertType
		{
			get
			{
				return certType;
			}
			set	
			{
				certType = value;
				DictionaryUtil.Add(QueryParameters, "CertType", value);
			}
		}

		public string SSLPri
		{
			get
			{
				return sSLPri;
			}
			set	
			{
				sSLPri = value;
				DictionaryUtil.Add(QueryParameters, "SSLPri", value);
			}
		}

		public string ForceSet
		{
			get
			{
				return forceSet;
			}
			set	
			{
				forceSet = value;
				DictionaryUtil.Add(QueryParameters, "ForceSet", value);
			}
		}

		public string CertName
		{
			get
			{
				return certName;
			}
			set	
			{
				certName = value;
				DictionaryUtil.Add(QueryParameters, "CertName", value);
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

		public string SSLPub
		{
			get
			{
				return sSLPub;
			}
			set	
			{
				sSLPub = value;
				DictionaryUtil.Add(QueryParameters, "SSLPub", value);
			}
		}

        public override SetLiveDomainCertificateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetLiveDomainCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
