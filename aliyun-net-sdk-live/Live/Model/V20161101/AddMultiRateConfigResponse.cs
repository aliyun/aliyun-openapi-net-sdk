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
	public class AddMultiRateConfigResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<AddMultiRateConfig_FailedTemplates> body;

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

		public List<AddMultiRateConfig_FailedTemplates> Body
		{
			get
			{
				return body;
			}
			set	
			{
				body = value;
			}
		}

		public class AddMultiRateConfig_FailedTemplates
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
