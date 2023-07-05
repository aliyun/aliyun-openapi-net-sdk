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
    public class SubmitTextTo2DAvatarVideoTaskRequest : RpcAcsRequest<SubmitTextTo2DAvatarVideoTaskResponse>
    {
        public SubmitTextTo2DAvatarVideoTaskRequest()
            : base("avatar", "2022-01-30", "SubmitTextTo2DAvatarVideoTask")
        {
			Method = MethodType.POST;
        }

		private App app_;

		private AudioInfo audioInfo_;

		private AvatarInfo avatarInfo_;

		private string title;

		private string extParams;

		private VideoInfo videoInfo_;

		private string callbackParams;

		private long? tenantId;

		private bool? callback;

		private string text;

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

		[JsonProperty(PropertyName = "AudioInfo")]
		public AudioInfo AudioInfo_
		{
			get
			{
				return audioInfo_;
			}

			set
			{
				audioInfo_ = value;
				DictionaryUtil.Add(QueryParameters, "AudioInfo", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "AvatarInfo")]
		public AvatarInfo AvatarInfo_
		{
			get
			{
				return avatarInfo_;
			}

			set
			{
				avatarInfo_ = value;
				DictionaryUtil.Add(QueryParameters, "AvatarInfo", JsonConvert.SerializeObject(value));

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

		[JsonProperty(PropertyName = "ExtParams")]
		public string ExtParams
		{
			get
			{
				return extParams;
			}
			set	
			{
				extParams = value;
				DictionaryUtil.Add(QueryParameters, "ExtParams", value);
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

		[JsonProperty(PropertyName = "CallbackParams")]
		public string CallbackParams
		{
			get
			{
				return callbackParams;
			}
			set	
			{
				callbackParams = value;
				DictionaryUtil.Add(QueryParameters, "CallbackParams", value);
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

		[JsonProperty(PropertyName = "Callback")]
		public bool? Callback
		{
			get
			{
				return callback;
			}
			set	
			{
				callback = value;
				DictionaryUtil.Add(QueryParameters, "Callback", value.ToString());
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

		public class AudioInfo
		{

			private string voice;

			private int? volume;

			private int? speechRate;

			private int? pitchRate;

			[JsonProperty(PropertyName = "Voice")]
			public string Voice
			{
				get
				{
					return voice;
				}
				set	
				{
					voice = value;
				}
			}

			[JsonProperty(PropertyName = "Volume")]
			public int? Volume
			{
				get
				{
					return volume;
				}
				set	
				{
					volume = value;
				}
			}

			[JsonProperty(PropertyName = "SpeechRate")]
			public int? SpeechRate
			{
				get
				{
					return speechRate;
				}
				set	
				{
					speechRate = value;
				}
			}

			[JsonProperty(PropertyName = "PitchRate")]
			public int? PitchRate
			{
				get
				{
					return pitchRate;
				}
				set	
				{
					pitchRate = value;
				}
			}
		}

		public class AvatarInfo
		{

			private string code;

			[JsonProperty(PropertyName = "Code")]
			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}
		}

		public class VideoInfo
		{

			private bool? isAlpha;

			private string backgroundImageUrl;

			private bool? isSubtitles;

			private int? resolution;

			private int? alphaFormat;

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

			[JsonProperty(PropertyName = "BackgroundImageUrl")]
			public string BackgroundImageUrl
			{
				get
				{
					return backgroundImageUrl;
				}
				set	
				{
					backgroundImageUrl = value;
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

			[JsonProperty(PropertyName = "AlphaFormat")]
			public int? AlphaFormat
			{
				get
				{
					return alphaFormat;
				}
				set	
				{
					alphaFormat = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitTextTo2DAvatarVideoTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitTextTo2DAvatarVideoTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
