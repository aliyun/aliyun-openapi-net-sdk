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
    public class ImportKeyMaterialRequest : RpcAcsRequest<ImportKeyMaterialResponse>
    {
        public ImportKeyMaterialRequest()
            : base("Kms", "2016-01-20", "ImportKeyMaterial", "kms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string importToken;

		private string encryptedKeyMaterial;

		private long? keyMaterialExpireUnix;

		private string keyId;

		public string ImportToken
		{
			get
			{
				return importToken;
			}
			set	
			{
				importToken = value;
				DictionaryUtil.Add(QueryParameters, "ImportToken", value);
			}
		}

		public string EncryptedKeyMaterial
		{
			get
			{
				return encryptedKeyMaterial;
			}
			set	
			{
				encryptedKeyMaterial = value;
				DictionaryUtil.Add(QueryParameters, "EncryptedKeyMaterial", value);
			}
		}

		public long? KeyMaterialExpireUnix
		{
			get
			{
				return keyMaterialExpireUnix;
			}
			set	
			{
				keyMaterialExpireUnix = value;
				DictionaryUtil.Add(QueryParameters, "KeyMaterialExpireUnix", value.ToString());
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

        public override ImportKeyMaterialResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportKeyMaterialResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
