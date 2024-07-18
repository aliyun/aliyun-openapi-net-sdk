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
using Aliyun.Acs.AiContent;
using Aliyun.Acs.AiContent.Transform;
using Aliyun.Acs.AiContent.Transform.V20240611;

namespace Aliyun.Acs.AiContent.Model.V20240611
{
    public class Personalizedtxt2imgQueryImageAssetRequest : RoaAcsRequest<Personalizedtxt2imgQueryImageAssetResponse>
    {
        public Personalizedtxt2imgQueryImageAssetRequest()
            : base("AiContent", "20240611", "Personalizedtxt2imgQueryImageAsset")
        {
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/api/v1/personalizedtxt2img/queryImageAsset";
			Method = MethodType.GET;
        }

		private string imageId;

		private string modelId;

		private string encodeFormat;

		private string promptId;

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "imageId", value);
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
				DictionaryUtil.Add(QueryParameters, "modelId", value);
			}
		}

		public string EncodeFormat
		{
			get
			{
				return encodeFormat;
			}
			set	
			{
				encodeFormat = value;
				DictionaryUtil.Add(QueryParameters, "encodeFormat", value);
			}
		}

		public string PromptId
		{
			get
			{
				return promptId;
			}
			set	
			{
				promptId = value;
				DictionaryUtil.Add(QueryParameters, "promptId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override Personalizedtxt2imgQueryImageAssetResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return Personalizedtxt2imgQueryImageAssetResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
