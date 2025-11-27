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
    public class TermEditRequest : RoaAcsRequest<TermEditResponse>
    {
        public TermEditRequest()
            : base("AnyTrans", "2025-07-07", "TermEdit")
        {
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/anytrans/translate/intervene/edit";
			Method = MethodType.POST;
        }

		private Ext ext_;

		private string sourceLanguage;

		private string scene;

		private string targetLanguage;

		private string workspaceId;

		[JsonProperty(PropertyName = "ext")]
		public Ext Ext_
		{
			get
			{
				return ext_;
			}

			set
			{
				ext_ = value;
				DictionaryUtil.Add(BodyParameters, "ext", JsonConvert.SerializeObject(value));

			}
		}

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

		public class Ext
		{

			private List<TermsItem> terms = new List<TermsItem>(){ };

			[JsonProperty(PropertyName = "terms")]
			public List<TermsItem> Terms
			{
				get
				{
					return terms;
				}
				set	
				{
					terms = value;
				}
			}

			public class TermsItem
			{

				private string tgt;

				private string termId;

				private string src;

				[JsonProperty(PropertyName = "tgt")]
				public string Tgt
				{
					get
					{
						return tgt;
					}
					set	
					{
						tgt = value;
					}
				}

				[JsonProperty(PropertyName = "termId")]
				public string TermId
				{
					get
					{
						return termId;
					}
					set	
					{
						termId = value;
					}
				}

				[JsonProperty(PropertyName = "src")]
				public string Src
				{
					get
					{
						return src;
					}
					set	
					{
						src = value;
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override TermEditResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TermEditResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
