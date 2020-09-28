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
    public class CreateSecretRequest : RpcAcsRequest<CreateSecretResponse>
    {
        public CreateSecretRequest()
            : base("Kms", "2016-01-20", "CreateSecret", "kms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string versionId;

		private string secretData;

		private string description;

		private string secretName;

		private string encryptionKeyId;

		private string secretDataType;

		private string tags;

		public string VersionId
		{
			get
			{
				return versionId;
			}
			set	
			{
				versionId = value;
				DictionaryUtil.Add(QueryParameters, "VersionId", value);
			}
		}

		public string SecretData
		{
			get
			{
				return secretData;
			}
			set	
			{
				secretData = value;
				DictionaryUtil.Add(QueryParameters, "SecretData", value);
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

		public string SecretName
		{
			get
			{
				return secretName;
			}
			set	
			{
				secretName = value;
				DictionaryUtil.Add(QueryParameters, "SecretName", value);
			}
		}

		public string EncryptionKeyId
		{
			get
			{
				return encryptionKeyId;
			}
			set	
			{
				encryptionKeyId = value;
				DictionaryUtil.Add(QueryParameters, "EncryptionKeyId", value);
			}
		}

		public string SecretDataType
		{
			get
			{
				return secretDataType;
			}
			set	
			{
				secretDataType = value;
				DictionaryUtil.Add(QueryParameters, "SecretDataType", value);
			}
		}

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

        public override CreateSecretResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSecretResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
