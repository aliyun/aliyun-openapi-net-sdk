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
    public class ReEncryptRequest : RpcAcsRequest<ReEncryptResponse>
    {
        public ReEncryptRequest()
            : base("Kms", "2016-01-20", "ReEncrypt", "kms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string destinationEncryptionContext;

		private string sourceEncryptionAlgorithm;

		private string sourceKeyVersionId;

		private string destinationKeyId;

		private string sourceKeyId;

		private string sourceEncryptionContext;

		private string ciphertextBlob;

		public string DestinationEncryptionContext
		{
			get
			{
				return destinationEncryptionContext;
			}
			set	
			{
				destinationEncryptionContext = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEncryptionContext", value);
			}
		}

		public string SourceEncryptionAlgorithm
		{
			get
			{
				return sourceEncryptionAlgorithm;
			}
			set	
			{
				sourceEncryptionAlgorithm = value;
				DictionaryUtil.Add(QueryParameters, "SourceEncryptionAlgorithm", value);
			}
		}

		public string SourceKeyVersionId
		{
			get
			{
				return sourceKeyVersionId;
			}
			set	
			{
				sourceKeyVersionId = value;
				DictionaryUtil.Add(QueryParameters, "SourceKeyVersionId", value);
			}
		}

		public string DestinationKeyId
		{
			get
			{
				return destinationKeyId;
			}
			set	
			{
				destinationKeyId = value;
				DictionaryUtil.Add(QueryParameters, "DestinationKeyId", value);
			}
		}

		public string SourceKeyId
		{
			get
			{
				return sourceKeyId;
			}
			set	
			{
				sourceKeyId = value;
				DictionaryUtil.Add(QueryParameters, "SourceKeyId", value);
			}
		}

		public string SourceEncryptionContext
		{
			get
			{
				return sourceEncryptionContext;
			}
			set	
			{
				sourceEncryptionContext = value;
				DictionaryUtil.Add(QueryParameters, "SourceEncryptionContext", value);
			}
		}

		public string CiphertextBlob
		{
			get
			{
				return ciphertextBlob;
			}
			set	
			{
				ciphertextBlob = value;
				DictionaryUtil.Add(QueryParameters, "CiphertextBlob", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ReEncryptResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ReEncryptResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
