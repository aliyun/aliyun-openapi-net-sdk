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
    public class AddDRMCertificateRequest : RpcAcsRequest<AddDRMCertificateResponse>
    {
        public AddDRMCertificateRequest()
            : base("live", "2016-11-01", "AddDRMCertificate", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string servCert;

		private string description;

		private string privateKey;

		private string certName;

		private long? ownerId;

		private string ask;

		private string passphrase;

		public string ServCert
		{
			get
			{
				return servCert;
			}
			set	
			{
				servCert = value;
				DictionaryUtil.Add(QueryParameters, "ServCert", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
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

		public string Ask
		{
			get
			{
				return ask;
			}
			set	
			{
				ask = value;
				DictionaryUtil.Add(QueryParameters, "Ask", value);
			}
		}

		public string Passphrase
		{
			get
			{
				return passphrase;
			}
			set	
			{
				passphrase = value;
				DictionaryUtil.Add(QueryParameters, "Passphrase", value);
			}
		}

        public override AddDRMCertificateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddDRMCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
