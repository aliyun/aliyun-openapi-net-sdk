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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class GetMultiRateConfigResponse : AcsResponse
	{

		private string domain;

		private string requestId;

		private string groupId;

		private string app;

		private string avFormat;

		private string stream;

		private int? code;

		private string message;

		private string isLazy;

		private string isTimeAlign;

		private List<GetMultiRateConfig_Detail> templatesInfo;

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
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "GroupId")]
		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
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
			}
		}

		[JsonProperty(PropertyName = "AvFormat")]
		public string AvFormat
		{
			get
			{
				return avFormat;
			}
			set	
			{
				avFormat = value;
			}
		}

		[JsonProperty(PropertyName = "Stream")]
		public string Stream
		{
			get
			{
				return stream;
			}
			set	
			{
				stream = value;
			}
		}

		[JsonProperty(PropertyName = "Code")]
		public int? Code
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

		[JsonProperty(PropertyName = "Message")]
		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		[JsonProperty(PropertyName = "IsLazy")]
		public string IsLazy
		{
			get
			{
				return isLazy;
			}
			set	
			{
				isLazy = value;
			}
		}

		[JsonProperty(PropertyName = "IsTimeAlign")]
		public string IsTimeAlign
		{
			get
			{
				return isTimeAlign;
			}
			set	
			{
				isTimeAlign = value;
			}
		}

		[JsonProperty(PropertyName = "TemplatesInfo")]
		public List<GetMultiRateConfig_Detail> TemplatesInfo
		{
			get
			{
				return templatesInfo;
			}
			set	
			{
				templatesInfo = value;
			}
		}

		public class GetMultiRateConfig_Detail
		{

			private int? audioBitrate;

			private string template;

			private int? height;

			private string templateType;

			private int? bandWidth;

			private int? profile;

			private int? audioRate;

			private string audioCodec;

			private string gop;

			private int? width;

			private int? videoBitrate;

			private int? audioChannelNum;

			private int? fps;

			private string audioProfile;

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
				}
			}

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
				}
			}

			[JsonProperty(PropertyName = "BandWidth")]
			public int? BandWidth
			{
				get
				{
					return bandWidth;
				}
				set	
				{
					bandWidth = value;
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
				}
			}

			[JsonProperty(PropertyName = "Fps")]
			public int? Fps
			{
				get
				{
					return fps;
				}
				set	
				{
					fps = value;
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
				}
			}
		}
	}
}
