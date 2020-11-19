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
using Aliyun.Acs.Cdn;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20180510;

namespace Aliyun.Acs.Cdn.Model.V20180510
{
    public class SetDomainServerCertificateRequest : RpcAcsRequest<SetDomainServerCertificateResponse>
    {
        public SetDomainServerCertificateRequest()
            : base("Cdn", "2018-05-10", "SetDomainServerCertificate")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string serverCertificate;

		private string privateKey;

		private string serverCertificateStatus;

		private string securityToken;

		private string certType;

		private string forceSet;

		private string certName;

		private string domainName;

		private long? ownerId;

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

		public string ServerCertificateStatus
		{
			get
			{
				return serverCertificateStatus;
			}
			set	
			{
				serverCertificateStatus = value;
				DictionaryUtil.Add(QueryParameters, "ServerCertificateStatus", value);
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

        public override SetDomainServerCertificateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetDomainServerCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
