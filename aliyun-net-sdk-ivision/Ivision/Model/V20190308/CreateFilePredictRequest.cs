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
using Aliyun.Acs.ivision;
using Aliyun.Acs.ivision.Transform;
using Aliyun.Acs.ivision.Transform.V20190308;

namespace Aliyun.Acs.ivision.Model.V20190308
{
    public class CreateFilePredictRequest : RpcAcsRequest<CreateFilePredictResponse>
    {
        public CreateFilePredictRequest()
            : base("ivision", "2019-03-08", "CreateFilePredict")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ivision.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ivision.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string outputOss;

		private string clientToken;

		private string pushConfig;

		private string resourceUrl;

		private string decryptConfig;

		private string algorithmCode;

		private string outputRegion;

		public string OutputOss
		{
			get
			{
				return outputOss;
			}
			set	
			{
				outputOss = value;
				DictionaryUtil.Add(BodyParameters, "OutputOss", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(BodyParameters, "ClientToken", value);
			}
		}

		public string PushConfig
		{
			get
			{
				return pushConfig;
			}
			set	
			{
				pushConfig = value;
				DictionaryUtil.Add(BodyParameters, "PushConfig", value);
			}
		}

		public string ResourceUrl
		{
			get
			{
				return resourceUrl;
			}
			set	
			{
				resourceUrl = value;
				DictionaryUtil.Add(BodyParameters, "ResourceUrl", value);
			}
		}

		public string DecryptConfig
		{
			get
			{
				return decryptConfig;
			}
			set	
			{
				decryptConfig = value;
				DictionaryUtil.Add(BodyParameters, "DecryptConfig", value);
			}
		}

		public string AlgorithmCode
		{
			get
			{
				return algorithmCode;
			}
			set	
			{
				algorithmCode = value;
				DictionaryUtil.Add(BodyParameters, "AlgorithmCode", value);
			}
		}

		public string OutputRegion
		{
			get
			{
				return outputRegion;
			}
			set	
			{
				outputRegion = value;
				DictionaryUtil.Add(BodyParameters, "OutputRegion", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateFilePredictResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateFilePredictResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
