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
	public class DescribeLiveStreamDelayConfigResponse : AcsResponse
	{

		private string requestId;

		private DescribeLiveStreamDelayConfig_LiveStreamHlsDelayConfig liveStreamHlsDelayConfig;

		private DescribeLiveStreamDelayConfig_LiveStreamFlvDelayConfig liveStreamFlvDelayConfig;

		private DescribeLiveStreamDelayConfig_LiveStreamRtmpDelayConfig liveStreamRtmpDelayConfig;

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

		public DescribeLiveStreamDelayConfig_LiveStreamHlsDelayConfig LiveStreamHlsDelayConfig
		{
			get
			{
				return liveStreamHlsDelayConfig;
			}
			set	
			{
				liveStreamHlsDelayConfig = value;
			}
		}

		public DescribeLiveStreamDelayConfig_LiveStreamFlvDelayConfig LiveStreamFlvDelayConfig
		{
			get
			{
				return liveStreamFlvDelayConfig;
			}
			set	
			{
				liveStreamFlvDelayConfig = value;
			}
		}

		public DescribeLiveStreamDelayConfig_LiveStreamRtmpDelayConfig LiveStreamRtmpDelayConfig
		{
			get
			{
				return liveStreamRtmpDelayConfig;
			}
			set	
			{
				liveStreamRtmpDelayConfig = value;
			}
		}

		public class DescribeLiveStreamDelayConfig_LiveStreamHlsDelayConfig
		{

			private string level;

			private int? delay;

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public int? Delay
			{
				get
				{
					return delay;
				}
				set	
				{
					delay = value;
				}
			}
		}

		public class DescribeLiveStreamDelayConfig_LiveStreamFlvDelayConfig
		{

			private string level;

			private int? delay;

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public int? Delay
			{
				get
				{
					return delay;
				}
				set	
				{
					delay = value;
				}
			}
		}

		public class DescribeLiveStreamDelayConfig_LiveStreamRtmpDelayConfig
		{

			private string level;

			private int? delay;

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public int? Delay
			{
				get
				{
					return delay;
				}
				set	
				{
					delay = value;
				}
			}
		}
	}
}
