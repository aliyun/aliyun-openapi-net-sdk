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
using Aliyun.Acs.scdn.Transform;
using Aliyun.Acs.scdn.Transform.V20171115;
using System.Collections.Generic;

namespace Aliyun.Acs.scdn.Model.V20171115
{
    public class SetScdnDomainCertificateRequest : RpcAcsRequest<SetScdnDomainCertificateResponse>
    {
        public SetScdnDomainCertificateRequest()
            : base("scdn", "2017-11-15", "SetScdnDomainCertificate")
        {
        }

		private string securityToken;

		private string certType;

		private string sSLPub;

		private string certName;

		private string sSLProtocol;

		private string domainName;

		private string action;

		private long? ownerId;

		private string region;

		private string accessKeyId;

		private string sSLPri;

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

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
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

        public override SetScdnDomainCertificateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetScdnDomainCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}