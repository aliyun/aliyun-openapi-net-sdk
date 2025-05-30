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
using Aliyun.Acs.AIPodcast;
using Aliyun.Acs.AIPodcast.Transform;
using Aliyun.Acs.AIPodcast.Transform.V20250228;

namespace Aliyun.Acs.AIPodcast.Model.V20250228
{
    public class PodcastTaskSubmitRequest : RoaAcsRequest<PodcastTaskSubmitResponse>
    {
        public PodcastTaskSubmitRequest()
            : base("AIPodcast", "2025-02-28", "PodcastTaskSubmit")
        {
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/podcast/task/submit";
			Method = MethodType.POST;
        }

		private string sourceLang;

		private int? counts;

		private List<string> fileUrls = new List<string>(){ };

		private string text;

		private List<string> voices = new List<string>(){ };

		private string topic;

		private string workspaceId;

		[JsonProperty(PropertyName = "sourceLang")]
		public string SourceLang
		{
			get
			{
				return sourceLang;
			}
			set	
			{
				sourceLang = value;
				DictionaryUtil.Add(BodyParameters, "sourceLang", value);
			}
		}

		[JsonProperty(PropertyName = "counts")]
		public int? Counts
		{
			get
			{
				return counts;
			}
			set	
			{
				counts = value;
				DictionaryUtil.Add(BodyParameters, "counts", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "fileUrls")]
		public List<string> FileUrls
		{
			get
			{
				return fileUrls;
			}

			set
			{
				fileUrls = value;
				if(fileUrls != null)
				{
					for (int depth1 = 0; depth1 < fileUrls.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"fileUrls." + (depth1 + 1), fileUrls[depth1]);
					}
				}
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

		[JsonProperty(PropertyName = "voices")]
		public List<string> Voices
		{
			get
			{
				return voices;
			}

			set
			{
				voices = value;
				if(voices != null)
				{
					for (int depth1 = 0; depth1 < voices.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"voices." + (depth1 + 1), voices[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "topic")]
		public string Topic
		{
			get
			{
				return topic;
			}
			set	
			{
				topic = value;
				DictionaryUtil.Add(BodyParameters, "topic", value);
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

        public override PodcastTaskSubmitResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PodcastTaskSubmitResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
