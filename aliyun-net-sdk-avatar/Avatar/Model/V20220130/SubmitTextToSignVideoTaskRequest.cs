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
using Aliyun.Acs.avatar;
using Aliyun.Acs.avatar.Transform;
using Aliyun.Acs.avatar.Transform.V20220130;

namespace Aliyun.Acs.avatar.Model.V20220130
{
    public class SubmitTextToSignVideoTaskRequest : RpcAcsRequest<SubmitTextToSignVideoTaskResponse>
    {
        public SubmitTextToSignVideoTaskRequest()
            : base("avatar", "2022-01-30", "SubmitTextToSignVideoTask")
        {
			Method = MethodType.POST;
        }

		private App app_;

		private VideoInfo videoInfo_;

		private long? tenantId;

		private string text;

		private string title;

		[JsonProperty(PropertyName = "App")]
		public App App_
		{
			get
			{
				return app_;
			}

			set
			{
				app_ = value;
				DictionaryUtil.Add(QueryParameters, "App", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "VideoInfo")]
		public VideoInfo VideoInfo_
		{
			get
			{
				return videoInfo_;
			}

			set
			{
				videoInfo_ = value;
				DictionaryUtil.Add(QueryParameters, "VideoInfo", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "TenantId")]
		public long? TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(QueryParameters, "TenantId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Text")]
		public string Text
		{
			get
			{
				return text;
			}
			set	
			{
				text = value;
				DictionaryUtil.Add(QueryParameters, "Text", value);
			}
		}

		[JsonProperty(PropertyName = "Title")]
		public string Title
		{
			get
			{
				return title;
			}
			set	
			{
				title = value;
				DictionaryUtil.Add(QueryParameters, "Title", value);
			}
		}

		public class App
		{

			private string appId;

			[JsonProperty(PropertyName = "AppId")]
			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}
		}

		public class VideoInfo
		{

			private bool? isAlpha;

			private bool? isSubtitles;

			private int? resolution;

			[JsonProperty(PropertyName = "IsAlpha")]
			public bool? IsAlpha
			{
				get
				{
					return isAlpha;
				}
				set	
				{
					isAlpha = value;
				}
			}

			[JsonProperty(PropertyName = "IsSubtitles")]
			public bool? IsSubtitles
			{
				get
				{
					return isSubtitles;
				}
				set	
				{
					isSubtitles = value;
				}
			}

			[JsonProperty(PropertyName = "Resolution")]
			public int? Resolution
			{
				get
				{
					return resolution;
				}
				set	
				{
					resolution = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitTextToSignVideoTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitTextToSignVideoTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
