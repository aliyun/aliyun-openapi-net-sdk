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
using Aliyun.Acs.AnyTrans;
using Aliyun.Acs.AnyTrans.Transform;
using Aliyun.Acs.AnyTrans.Transform.V20250707;

namespace Aliyun.Acs.AnyTrans.Model.V20250707
{
    public class TermQueryRequest : RoaAcsRequest<TermQueryResponse>
    {
        public TermQueryRequest()
            : base("AnyTrans", "2025-07-07", "TermQuery")
        {
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/anytrans/translate/intervene/query";
			Method = MethodType.POST;
        }

		private string sourceLanguage;

		private string scene;

		private string targetLanguage;

		private string text;

		private string workspaceId;

		[JsonProperty(PropertyName = "sourceLanguage")]
		public string SourceLanguage
		{
			get
			{
				return sourceLanguage;
			}
			set	
			{
				sourceLanguage = value;
				DictionaryUtil.Add(BodyParameters, "sourceLanguage", value);
			}
		}

		[JsonProperty(PropertyName = "scene")]
		public string Scene
		{
			get
			{
				return scene;
			}
			set	
			{
				scene = value;
				DictionaryUtil.Add(BodyParameters, "scene", value);
			}
		}

		[JsonProperty(PropertyName = "targetLanguage")]
		public string TargetLanguage
		{
			get
			{
				return targetLanguage;
			}
			set	
			{
				targetLanguage = value;
				DictionaryUtil.Add(BodyParameters, "targetLanguage", value);
			}
		}

		[JsonProperty(PropertyName = "text")]
		public string Text
		{
			get
			{
				return text;
			}
			set	
			{
				text = value;
				DictionaryUtil.Add(BodyParameters, "text", value);
			}
		}

		[JsonProperty(PropertyName = "workspaceId")]
		public string WorkspaceId
		{
			get
			{
				return workspaceId;
			}
			set	
			{
				workspaceId = value;
				DictionaryUtil.Add(BodyParameters, "workspaceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override TermQueryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TermQueryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
