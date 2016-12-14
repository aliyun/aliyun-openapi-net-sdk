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
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class ModifySignatureRequest : RpcAcsRequest<ModifySignatureResponse>
    {
        public ModifySignatureRequest()
            : base("CloudAPI", "2016-07-14", "ModifySignature")
        {
        }

		private string signatureId;

		private string signatureName;

		private string signatureKey;

		private string signatureSecret;

		public string SignatureId
		{
			get
			{
				return signatureId;
			}
			set	
			{
				signatureId = value;
				DictionaryUtil.Add(QueryParameters, "SignatureId", value);
			}
		}

		public string SignatureName
		{
			get
			{
				return signatureName;
			}
			set	
			{
				signatureName = value;
				DictionaryUtil.Add(QueryParameters, "SignatureName", value);
			}
		}

		public string SignatureKey
		{
			get
			{
				return signatureKey;
			}
			set	
			{
				signatureKey = value;
				DictionaryUtil.Add(QueryParameters, "SignatureKey", value);
			}
		}

		public string SignatureSecret
		{
			get
			{
				return signatureSecret;
			}
			set	
			{
				signatureSecret = value;
				DictionaryUtil.Add(QueryParameters, "SignatureSecret", value);
			}
		}

        public override ModifySignatureResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifySignatureResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}