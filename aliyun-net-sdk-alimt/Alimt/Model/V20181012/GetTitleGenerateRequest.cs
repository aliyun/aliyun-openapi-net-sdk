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
using Aliyun.Acs.alimt.Transform;
using Aliyun.Acs.alimt.Transform.V20181012;

namespace Aliyun.Acs.alimt.Model.V20181012
{
    public class GetTitleGenerateRequest : RpcAcsRequest<GetTitleGenerateResponse>
    {
        public GetTitleGenerateRequest()
            : base("alimt", "2018-10-12", "GetTitleGenerate", "alimt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.alimt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.alimt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string language;

		private string title;

		private string platform;

		private string extra;

		private string attributes;

		private string hotWords;

		private string categoryId;

		public string Language
		{
			get
			{
				return language;
			}
			set	
			{
				language = value;
				DictionaryUtil.Add(BodyParameters, "Language", value);
			}
		}

		public string Title
		{
			get
			{
				return title;
			}
			set	
			{
				title = value;
				DictionaryUtil.Add(BodyParameters, "Title", value);
			}
		}

		public string Platform
		{
			get
			{
				return platform;
			}
			set	
			{
				platform = value;
				DictionaryUtil.Add(BodyParameters, "Platform", value);
			}
		}

		public string Extra
		{
			get
			{
				return extra;
			}
			set	
			{
				extra = value;
				DictionaryUtil.Add(BodyParameters, "Extra", value);
			}
		}

		public string Attributes
		{
			get
			{
				return attributes;
			}
			set	
			{
				attributes = value;
				DictionaryUtil.Add(BodyParameters, "Attributes", value);
			}
		}

		public string HotWords
		{
			get
			{
				return hotWords;
			}
			set	
			{
				hotWords = value;
				DictionaryUtil.Add(BodyParameters, "HotWords", value);
			}
		}

		public string CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
				DictionaryUtil.Add(BodyParameters, "CategoryId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetTitleGenerateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetTitleGenerateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
