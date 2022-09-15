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
	public class DescribeToutiaoLivePublishResponse : AcsResponse
	{

		private string description;

		private string requestId;

		private List<DescribeToutiaoLivePublish_ContentItem> content;

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
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

		[JsonProperty(PropertyName = "Content")]
		public List<DescribeToutiaoLivePublish_ContentItem> Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public class DescribeToutiaoLivePublish_ContentItem
		{

			private string domain;

			private string streamName;

			private string app;

			private float? fps;

			private float? flr;

			private long? timestamp;

			private float? bitrate;

			private float? bwDiff;

			private string cdnName;

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

			[JsonProperty(PropertyName = "StreamName")]
			public string StreamName
			{
				get
				{
					return streamName;
				}
				set	
				{
					streamName = value;
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

			[JsonProperty(PropertyName = "Fps")]
			public float? Fps
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

			[JsonProperty(PropertyName = "Flr")]
			public float? Flr
			{
				get
				{
					return flr;
				}
				set	
				{
					flr = value;
				}
			}

			[JsonProperty(PropertyName = "Timestamp")]
			public long? Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			[JsonProperty(PropertyName = "Bitrate")]
			public float? Bitrate
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

			[JsonProperty(PropertyName = "BwDiff")]
			public float? BwDiff
			{
				get
				{
					return bwDiff;
				}
				set	
				{
					bwDiff = value;
				}
			}

			[JsonProperty(PropertyName = "CdnName")]
			public string CdnName
			{
				get
				{
					return cdnName;
				}
				set	
				{
					cdnName = value;
				}
			}
		}
	}
}
