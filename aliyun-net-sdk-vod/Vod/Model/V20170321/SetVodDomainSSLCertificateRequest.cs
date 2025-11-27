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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class SetVodDomainSSLCertificateRequest : RpcAcsRequest<SetVodDomainSSLCertificateResponse>
    {
        public SetVodDomainSSLCertificateRequest()
            : base("vod", "2017-03-21", "SetVodDomainSSLCertificate", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sSLProtocol;

		private long? certId;

		private string securityToken;

		private string certType;

		private string sSLPri;

		private string certRegion;

		private string certName;

		private string domainName;

		private long? ownerId;

		private string env;

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

		public long? CertId
		{
			get
			{
				return certId;
			}
			set	
			{
				certId = value;
				DictionaryUtil.Add(QueryParameters, "CertId", value.ToString());
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

		public string CertRegion
		{
			get
			{
				return certRegion;
			}
			set	
			{
				certRegion = value;
				DictionaryUtil.Add(QueryParameters, "CertRegion", value);
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

		public string Env
		{
			get
			{
				return env;
			}
			set	
			{
				env = value;
				DictionaryUtil.Add(QueryParameters, "Env", value);
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

        public override SetVodDomainSSLCertificateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetVodDomainSSLCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
