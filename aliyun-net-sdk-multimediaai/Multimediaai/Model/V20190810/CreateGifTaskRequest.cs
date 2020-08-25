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
using Aliyun.Acs.multimediaai;
using Aliyun.Acs.multimediaai.Transform;
using Aliyun.Acs.multimediaai.Transform.V20190810;

namespace Aliyun.Acs.multimediaai.Model.V20190810
{
    public class CreateGifTaskRequest : RpcAcsRequest<CreateGifTaskResponse>
    {
        public CreateGifTaskRequest()
            : base("multimediaai", "2019-08-10", "CreateGifTask")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? templateId;

		private string videoUrl;

		private string scales;

		private string videoName;

		private string callbackUrl;

		private string applicationId;

		public long? TemplateId
		{
			get
			{
				return templateId;
			}
			set	
			{
				templateId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateId", value.ToString());
			}
		}

		public string VideoUrl
		{
			get
			{
				return videoUrl;
			}
			set	
			{
				videoUrl = value;
				DictionaryUtil.Add(QueryParameters, "VideoUrl", value);
			}
		}

		public string Scales
		{
			get
			{
				return scales;
			}
			set	
			{
				scales = value;
				DictionaryUtil.Add(BodyParameters, "Scales", value);
			}
		}

		public string VideoName
		{
			get
			{
				return videoName;
			}
			set	
			{
				videoName = value;
				DictionaryUtil.Add(QueryParameters, "VideoName", value);
			}
		}

		public string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set	
			{
				callbackUrl = value;
				DictionaryUtil.Add(QueryParameters, "CallbackUrl", value);
			}
		}

		public string ApplicationId
		{
			get
			{
				return applicationId;
			}
			set	
			{
				applicationId = value;
				DictionaryUtil.Add(QueryParameters, "ApplicationId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateGifTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateGifTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
