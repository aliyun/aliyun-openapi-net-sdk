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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class PlayInfoResponse : AcsResponse
	{

		private string requestId;

		private List<PlayInfo_PlayInfo> playInfoList;

		private List<string> notFoundCDNDomain;

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

		public List<PlayInfo_PlayInfo> PlayInfoList
		{
			get
			{
				return playInfoList;
			}
			set	
			{
				playInfoList = value;
			}
		}

		public List<string> NotFoundCDNDomain
		{
			get
			{
				return notFoundCDNDomain;
			}
			set	
			{
				notFoundCDNDomain = value;
			}
		}

		public class PlayInfo_PlayInfo
		{

			private string url;

			private string duration;

			private string size;

			private string width;

			private string height;

			private string bitrate;

			private string fps;

			private string format;

			private string definition;

			private string encryption;

			private string rand;

			private string plaintext;

			private string complexity;

			private string activityName;

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public string Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public string Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public string Width
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

			public string Height
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

			public string Format
			{
				get
				{
					return format;
				}
				set	
				{
					format = value;
				}
			}

			public string Definition
			{
				get
				{
					return definition;
				}
				set	
				{
					definition = value;
				}
			}

			public string Encryption
			{
				get
				{
					return encryption;
				}
				set	
				{
					encryption = value;
				}
			}

			public string Rand
			{
				get
				{
					return rand;
				}
				set	
				{
					rand = value;
				}
			}

			public string Plaintext
			{
				get
				{
					return plaintext;
				}
				set	
				{
					plaintext = value;
				}
			}

			public string Complexity
			{
				get
				{
					return complexity;
				}
				set	
				{
					complexity = value;
				}
			}

			public string ActivityName
			{
				get
				{
					return activityName;
				}
				set	
				{
					activityName = value;
				}
			}
		}
	}
}