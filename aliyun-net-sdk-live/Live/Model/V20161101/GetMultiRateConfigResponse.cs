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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class GetMultiRateConfigResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private int? code;

		private string domain;

		private string app;

		private string stream;

		private string avFormat;

		private string groupId;

		private string isLazy;

		private string isTimeAlign;

		private List<GetMultiRateConfig_Detail> templatesInfo;

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

			private string template;

			private string templateType;

			private int? height;

			private int? width;

			private int? fps;

			private string gop;

			private int? videoBitrate;

			private int? profile;

			private string audioProfile;

			private string audioCodec;

			private int? audioRate;

			private int? audioBitrate;

			private int? audioChannelNum;

			private int? bandWidth;

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
		}
	}
}
