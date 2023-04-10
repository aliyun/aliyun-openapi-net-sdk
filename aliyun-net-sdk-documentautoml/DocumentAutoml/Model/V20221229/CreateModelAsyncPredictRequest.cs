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
using Aliyun.Acs.documentAutoml.Transform;
using Aliyun.Acs.documentAutoml.Transform.V20221229;

namespace Aliyun.Acs.documentAutoml.Model.V20221229
{
    public class CreateModelAsyncPredictRequest : RpcAcsRequest<CreateModelAsyncPredictResponse>
    {
        public CreateModelAsyncPredictRequest()
            : base("documentAutoml", "2022-12-29", "CreateModelAsyncPredict", "documentAutoml", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string body;

		private bool? binaryToText;

		private string content;

		private string serviceName;

		private long? modelId;

		private string serviceVersion;

		private string modelVersion;

		public string Body
		{
			get
			{
				return body;
			}
			set	
			{
				body = value;
				DictionaryUtil.Add(BodyParameters, "body", value);
			}
		}

		public bool? BinaryToText
		{
			get
			{
				return binaryToText;
			}
			set	
			{
				binaryToText = value;
				DictionaryUtil.Add(QueryParameters, "BinaryToText", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Content", value);
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public long? ModelId
		{
			get
			{
				return modelId;
			}
			set	
			{
				modelId = value;
				DictionaryUtil.Add(QueryParameters, "ModelId", value.ToString());
			}
		}

		public string ServiceVersion
		{
			get
			{
				return serviceVersion;
			}
			set	
			{
				serviceVersion = value;
				DictionaryUtil.Add(QueryParameters, "ServiceVersion", value);
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

        public override CreateModelAsyncPredictResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateModelAsyncPredictResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
