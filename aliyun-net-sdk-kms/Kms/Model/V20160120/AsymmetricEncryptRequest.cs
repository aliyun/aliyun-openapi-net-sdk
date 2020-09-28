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
using Aliyun.Acs.Kms.Transform;
using Aliyun.Acs.Kms.Transform.V20160120;

namespace Aliyun.Acs.Kms.Model.V20160120
{
    public class AsymmetricEncryptRequest : RpcAcsRequest<AsymmetricEncryptResponse>
    {
        public AsymmetricEncryptRequest()
            : base("Kms", "2016-01-20", "AsymmetricEncrypt", "kms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string keyVersionId;

		private string keyId;

		private string plaintext;

		private string algorithm;

		public string KeyVersionId
		{
			get
			{
				return keyVersionId;
			}
			set	
			{
				keyVersionId = value;
				DictionaryUtil.Add(QueryParameters, "KeyVersionId", value);
			}
		}

		public string KeyId
		{
			get
			{
				return keyId;
			}
			set	
			{
				keyId = value;
				DictionaryUtil.Add(QueryParameters, "KeyId", value);
			}
		}

		public string Plaintext
		{
			get
			{
				return plaintext;
			}
			set	
			{
				plaintext = value;
				DictionaryUtil.Add(QueryParameters, "Plaintext", value);
			}
		}

		public string Algorithm
		{
			get
			{
				return algorithm;
			}
			set	
			{
				algorithm = value;
				DictionaryUtil.Add(QueryParameters, "Algorithm", value);
			}
		}

        public override AsymmetricEncryptResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AsymmetricEncryptResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
