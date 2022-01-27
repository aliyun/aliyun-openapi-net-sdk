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
using Aliyun.Acs.nlp_automl.Transform;
using Aliyun.Acs.nlp_automl.Transform.V20191111;

namespace Aliyun.Acs.nlp_automl.Model.V20191111
{
    public class CreateAsyncPredictRequest : RpcAcsRequest<CreateAsyncPredictResponse>
    {
        public CreateAsyncPredictRequest()
            : base("nlp-automl", "2019-11-11", "CreateAsyncPredict", "nlpautoml", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.nlp_automl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.nlp_automl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? topK;

		private string fileType;

		private string detailTag;

		private string fetchContent;

		private string content;

		private string fileContent;

		private int? modelId;

		private string fileUrl;

		private string modelVersion;

		public int? TopK
		{
			get
			{
				return topK;
			}
			set	
			{
				topK = value;
				DictionaryUtil.Add(BodyParameters, "TopK", value.ToString());
			}
		}

		public string FileType
		{
			get
			{
				return fileType;
			}
			set	
			{
				fileType = value;
				DictionaryUtil.Add(BodyParameters, "FileType", value);
			}
		}

		public string DetailTag
		{
			get
			{
				return detailTag;
			}
			set	
			{
				detailTag = value;
				DictionaryUtil.Add(BodyParameters, "DetailTag", value);
			}
		}

		public string FetchContent
		{
			get
			{
				return fetchContent;
			}
			set	
			{
				fetchContent = value;
				DictionaryUtil.Add(BodyParameters, "FetchContent", value);
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

		public string FileContent
		{
			get
			{
				return fileContent;
			}
			set	
			{
				fileContent = value;
				DictionaryUtil.Add(BodyParameters, "FileContent", value);
			}
		}

		public int? ModelId
		{
			get
			{
				return modelId;
			}
			set	
			{
				modelId = value;
				DictionaryUtil.Add(BodyParameters, "ModelId", value.ToString());
			}
		}

		public string FileUrl
		{
			get
			{
				return fileUrl;
			}
			set	
			{
				fileUrl = value;
				DictionaryUtil.Add(BodyParameters, "FileUrl", value);
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
				DictionaryUtil.Add(BodyParameters, "ModelVersion", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateAsyncPredictResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAsyncPredictResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
