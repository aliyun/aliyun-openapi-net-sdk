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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn.Transform.V20141111;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class SetDomainServerCertificateRequest : RpcAcsRequest<SetDomainServerCertificateResponse>
    {
        public SetDomainServerCertificateRequest()
            : base("Cdn", "2014-11-11", "SetDomainServerCertificate")
        {
        }

		private long? _ownerId;

		private string _securityToken;

		private string _domainName;

		private string _certName;

		private string _serverCertificateStatus;

		private string _serverCertificate;

		private string _privateKey;

		private string _region;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return _securityToken;
			}
			set	
			{
				_securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string DomainName
		{
			get
			{
				return _domainName;
			}
			set	
			{
				_domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string CertName
		{
			get
			{
				return _certName;
			}
			set	
			{
				_certName = value;
				DictionaryUtil.Add(QueryParameters, "CertName", value);
			}
		}

		public string ServerCertificateStatus
		{
			get
			{
				return _serverCertificateStatus;
			}
			set	
			{
				_serverCertificateStatus = value;
				DictionaryUtil.Add(QueryParameters, "ServerCertificateStatus", value);
			}
		}

		public string ServerCertificate
		{
			get
			{
				return _serverCertificate;
			}
			set	
			{
				_serverCertificate = value;
				DictionaryUtil.Add(QueryParameters, "ServerCertificate", value);
			}
		}

		public string PrivateKey
		{
			get
			{
				return _privateKey;
			}
			set	
			{
				_privateKey = value;
				DictionaryUtil.Add(QueryParameters, "PrivateKey", value);
			}
		}

		public string Region
		{
			get
			{
				return _region;
			}
			set	
			{
				_region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

        public override SetDomainServerCertificateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetDomainServerCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}