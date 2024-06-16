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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class AddRtsLiveStreamTranscodeRequest : RpcAcsRequest<AddRtsLiveStreamTranscodeResponse>
    {
        public AddRtsLiveStreamTranscodeRequest()
            : base("live", "2016-11-01", "AddRtsLiveStreamTranscode", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string template;

		private bool? deleteBframes;

		private string lazy;

		private string gop;

		private bool? opus;

		private string audioCodec;

		private string templateType;

		private string audioProfile;

		private int? height;

		private string app;

		private int? audioChannelNum;

		private int? profile;

		private int? fPS;

		private long? ownerId;

		private int? audioRate;

		private int? audioBitrate;

		private string domain;

		private int? width;

		private int? videoBitrate;

		[JsonProperty(PropertyName = "Template")]
		public string Template
		{
			get
			{
				return template;
			}
			set	
			{
				template = value;
				DictionaryUtil.Add(QueryParameters, "Template", value);
			}
		}

		[JsonProperty(PropertyName = "DeleteBframes")]
		public bool? DeleteBframes
		{
			get
			{
				return deleteBframes;
			}
			set	
			{
				deleteBframes = value;
				DictionaryUtil.Add(QueryParameters, "DeleteBframes", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Lazy")]
		public string Lazy
		{
			get
			{
				return lazy;
			}
			set	
			{
				lazy = value;
				DictionaryUtil.Add(QueryParameters, "Lazy", value);
			}
		}

		[JsonProperty(PropertyName = "Gop")]
		public string Gop
		{
			get
			{
				return gop;
			}
			set	
			{
				gop = value;
				DictionaryUtil.Add(QueryParameters, "Gop", value);
			}
		}

		[JsonProperty(PropertyName = "Opus")]
		public bool? Opus
		{
			get
			{
				return opus;
			}
			set	
			{
				opus = value;
				DictionaryUtil.Add(QueryParameters, "Opus", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AudioCodec")]
		public string AudioCodec
		{
			get
			{
				return audioCodec;
			}
			set	
			{
				audioCodec = value;
				DictionaryUtil.Add(QueryParameters, "AudioCodec", value);
			}
		}

		[JsonProperty(PropertyName = "TemplateType")]
		public string TemplateType
		{
			get
			{
				return templateType;
			}
			set	
			{
				templateType = value;
				DictionaryUtil.Add(QueryParameters, "TemplateType", value);
			}
		}

		[JsonProperty(PropertyName = "AudioProfile")]
		public string AudioProfile
		{
			get
			{
				return audioProfile;
			}
			set	
			{
				audioProfile = value;
				DictionaryUtil.Add(QueryParameters, "AudioProfile", value);
			}
		}

		[JsonProperty(PropertyName = "Height")]
		public int? Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
				DictionaryUtil.Add(QueryParameters, "Height", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "App")]
		public string App
		{
			get
			{
				return app;
			}
			set	
			{
				app = value;
				DictionaryUtil.Add(QueryParameters, "App", value);
			}
		}

		[JsonProperty(PropertyName = "AudioChannelNum")]
		public int? AudioChannelNum
		{
			get
			{
				return audioChannelNum;
			}
			set	
			{
				audioChannelNum = value;
				DictionaryUtil.Add(QueryParameters, "AudioChannelNum", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Profile")]
		public int? Profile
		{
			get
			{
				return profile;
			}
			set	
			{
				profile = value;
				DictionaryUtil.Add(QueryParameters, "Profile", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "FPS")]
		public int? FPS
		{
			get
			{
				return fPS;
			}
			set	
			{
				fPS = value;
				DictionaryUtil.Add(QueryParameters, "FPS", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AudioRate")]
		public int? AudioRate
		{
			get
			{
				return audioRate;
			}
			set	
			{
				audioRate = value;
				DictionaryUtil.Add(QueryParameters, "AudioRate", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AudioBitrate")]
		public int? AudioBitrate
		{
			get
			{
				return audioBitrate;
			}
			set	
			{
				audioBitrate = value;
				DictionaryUtil.Add(QueryParameters, "AudioBitrate", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Domain")]
		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
			}
		}

		[JsonProperty(PropertyName = "Width")]
		public int? Width
		{
			get
			{
				return width;
			}
			set	
			{
				width = value;
				DictionaryUtil.Add(QueryParameters, "Width", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "VideoBitrate")]
		public int? VideoBitrate
		{
			get
			{
				return videoBitrate;
			}
			set	
			{
				videoBitrate = value;
				DictionaryUtil.Add(QueryParameters, "VideoBitrate", value.ToString());
			}
		}

        public override AddRtsLiveStreamTranscodeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddRtsLiveStreamTranscodeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
