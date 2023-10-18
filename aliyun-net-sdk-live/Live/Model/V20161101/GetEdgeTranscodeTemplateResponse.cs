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
	public class GetEdgeTranscodeTemplateResponse : AcsResponse
	{

		private string requestId;

		private GetEdgeTranscodeTemplate_Template template;

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

		[JsonProperty(PropertyName = "Template")]
		public GetEdgeTranscodeTemplate_Template Template
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

		public class GetEdgeTranscodeTemplate_Template
		{

			private string type;

			private string gop;

			private string createTime;

			private string codec;

			private string fps;

			private string bitrate;

			private string name;

			private string resolution;

			private string templateId;

			[JsonProperty(PropertyName = "Type")]
			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
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

			[JsonProperty(PropertyName = "CreateTime")]
			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			[JsonProperty(PropertyName = "Codec")]
			public string Codec
			{
				get
				{
					return codec;
				}
				set	
				{
					codec = value;
				}
			}

			[JsonProperty(PropertyName = "Fps")]
			public string Fps
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

			[JsonProperty(PropertyName = "Bitrate")]
			public string Bitrate
			{
				get
				{
					return bitrate;
				}
				set	
				{
					bitrate = value;
				}
			}

			[JsonProperty(PropertyName = "Name")]
			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			[JsonProperty(PropertyName = "Resolution")]
			public string Resolution
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

			[JsonProperty(PropertyName = "TemplateId")]
			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}
		}
	}
}
