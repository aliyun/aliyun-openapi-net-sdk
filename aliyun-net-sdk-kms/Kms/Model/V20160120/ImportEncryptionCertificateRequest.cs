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
using Aliyun.Acs.Kms.Transform;
using Aliyun.Acs.Kms.Transform.V20160120;

namespace Aliyun.Acs.Kms.Model.V20160120
{
    public class ImportEncryptionCertificateRequest : RpcAcsRequest<ImportEncryptionCertificateResponse>
    {
        public ImportEncryptionCertificateRequest()
            : base("Kms", "2016-01-20", "ImportEncryptionCertificate", "kms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Kms.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Kms.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string asymmetricAlgorithm;

		private string symmetricAlgorithm;

		private string encryptedPrivateKey;

		private string encryptedSymmetricKey;

		private string certificateId;

		private string certificate;

		private string certificateChain;

		public string AsymmetricAlgorithm
		{
			get
			{
				return asymmetricAlgorithm;
			}
			set	
			{
				asymmetricAlgorithm = value;
				DictionaryUtil.Add(QueryParameters, "AsymmetricAlgorithm", value);
			}
		}

		public string SymmetricAlgorithm
		{
			get
			{
				return symmetricAlgorithm;
			}
			set	
			{
				symmetricAlgorithm = value;
				DictionaryUtil.Add(QueryParameters, "SymmetricAlgorithm", value);
			}
		}

		public string EncryptedPrivateKey
		{
			get
			{
				return encryptedPrivateKey;
			}
			set	
			{
				encryptedPrivateKey = value;
				DictionaryUtil.Add(QueryParameters, "EncryptedPrivateKey", value);
			}
		}

		public string EncryptedSymmetricKey
		{
			get
			{
				return encryptedSymmetricKey;
			}
			set	
			{
				encryptedSymmetricKey = value;
				DictionaryUtil.Add(QueryParameters, "EncryptedSymmetricKey", value);
			}
		}

		public string CertificateId
		{
			get
			{
				return certificateId;
			}
			set	
			{
				certificateId = value;
				DictionaryUtil.Add(QueryParameters, "CertificateId", value);
			}
		}

		public string Certificate
		{
			get
			{
				return certificate;
			}
			set	
			{
				certificate = value;
				DictionaryUtil.Add(QueryParameters, "Certificate", value);
			}
		}

		public string CertificateChain
		{
			get
			{
				return certificateChain;
			}
			set	
			{
				certificateChain = value;
				DictionaryUtil.Add(QueryParameters, "CertificateChain", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ImportEncryptionCertificateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportEncryptionCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
