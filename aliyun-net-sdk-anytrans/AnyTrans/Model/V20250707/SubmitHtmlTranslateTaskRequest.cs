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
    public class SubmitHtmlTranslateTaskRequest : RoaAcsRequest<SubmitHtmlTranslateTaskResponse>
    {
        public SubmitHtmlTranslateTaskRequest()
            : base("AnyTrans", "2025-07-07", "SubmitHtmlTranslateTask")
        {
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/anytrans/translate/html/submit";
			Method = MethodType.POST;
        }

		private Ext ext_;

		private string sourceLanguage;

		private string format;

		private string scene;

		private string targetLanguage;

		private string text;

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

		[JsonProperty(PropertyName = "format")]
		public string Format
		{
			get
			{
				return format;
			}
			set	
			{
				format = value;
				DictionaryUtil.Add(BodyParameters, "format", value);
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

		public class Ext
		{

			private List<string> sensitives = new List<string>(){ };

			private List<TerminologiesItem> terminologies = new List<TerminologiesItem>(){ };

			private TextTransform textTransform_;

			private List<ExamplesItem> examples = new List<ExamplesItem>(){ };

			private string domainHint;

			[JsonProperty(PropertyName = "sensitives")]
			public List<string> Sensitives
			{
				get
				{
					return sensitives;
				}
				set	
				{
					sensitives = value;
				}
			}

			[JsonProperty(PropertyName = "terminologies")]
			public List<TerminologiesItem> Terminologies
			{
				get
				{
					return terminologies;
				}
				set	
				{
					terminologies = value;
				}
			}

			[JsonProperty(PropertyName = "textTransform")]
			public TextTransform TextTransform_
			{
				get
				{
					return textTransform_;
				}
				set	
				{
					textTransform_ = value;
				}
			}

			[JsonProperty(PropertyName = "examples")]
			public List<ExamplesItem> Examples
			{
				get
				{
					return examples;
				}
				set	
				{
					examples = value;
				}
			}

			[JsonProperty(PropertyName = "domainHint")]
			public string DomainHint
			{
				get
				{
					return domainHint;
				}
				set	
				{
					domainHint = value;
				}
			}

			public class TerminologiesItem
			{

				private string tgt;

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

			public class TextTransform
			{

				private bool? toLower;

				private bool? toUpper;

				private bool? toTitle;

				[JsonProperty(PropertyName = "toLower")]
				public bool? ToLower
				{
					get
					{
						return toLower;
					}
					set	
					{
						toLower = value;
					}
				}

				[JsonProperty(PropertyName = "toUpper")]
				public bool? ToUpper
				{
					get
					{
						return toUpper;
					}
					set	
					{
						toUpper = value;
					}
				}

				[JsonProperty(PropertyName = "toTitle")]
				public bool? ToTitle
				{
					get
					{
						return toTitle;
					}
					set	
					{
						toTitle = value;
					}
				}
			}

			public class ExamplesItem
			{

				private string tgt;

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

        public override SubmitHtmlTranslateTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitHtmlTranslateTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
