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
using Aliyun.Acs.nlp_automl.Transform;
using Aliyun.Acs.nlp_automl.Transform.V20190701;

namespace Aliyun.Acs.nlp_automl.Model.V20190701
{
    public class PredictMTModelRequest : RpcAcsRequest<PredictMTModelResponse>
    {
        public PredictMTModelRequest()
            : base("nlp-automl", "2019-07-01", "PredictMTModel", "nlpautoml", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.nlp_automl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.nlp_automl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string product;

		private string modelId;

		private string content;

		private string modelVersion;

		public string Product
		{
			get
			{
				return product;
			}
			set	
			{
				product = value;
				DictionaryUtil.Add(QueryParameters, "Product", value);
			}
		}

		public string ModelId
		{
			get
			{
				return modelId;
			}
			set	
			{
				modelId = value;
				DictionaryUtil.Add(QueryParameters, "ModelId", value);
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(BodyParameters, "Content", value);
			}
		}

		public string ModelVersion
		{
			get
			{
				return modelVersion;
			}
			set	
			{
				modelVersion = value;
				DictionaryUtil.Add(QueryParameters, "ModelVersion", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PredictMTModelResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PredictMTModelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
