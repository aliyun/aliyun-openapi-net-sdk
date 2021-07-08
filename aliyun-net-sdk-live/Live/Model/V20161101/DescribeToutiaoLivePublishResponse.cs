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
	public class DescribeToutiaoLivePublishResponse : AcsResponse
	{

		private string requestId;

		private string description;

		private List<DescribeToutiaoLivePublish_ContentItem> content;

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

			private string app;

			private float? bitrate;

			private float? bwDiff;

			private string cdnName;

			private string domain;

			private float? flr;

			private float? fps;

			private string streamName;

			private long? timestamp;

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
		}
	}
}
