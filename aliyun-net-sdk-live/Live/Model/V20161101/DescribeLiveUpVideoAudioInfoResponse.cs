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
	public class DescribeLiveUpVideoAudioInfoResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveUpVideoAudioInfo_PublishItem> upItems;

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

		[JsonProperty(PropertyName = "UpItems")]
		public List<DescribeLiveUpVideoAudioInfo_PublishItem> UpItems
		{
			get
			{
				return upItems;
			}
			set	
			{
				upItems = value;
			}
		}

		public class DescribeLiveUpVideoAudioInfo_PublishItem
		{

			private string appName;

			private string codecInfo;

			private string domainName;

			private string publishInterval;

			private string publishIp;

			private string publishStatus;

			private string publishTime;

			private string stopTime;

			private string streamName;

			private string uniqueId;

			private List<DescribeLiveUpVideoAudioInfo_AacHeadersItem> aacHeaders;

			private List<DescribeLiveUpVideoAudioInfo_AudioBitRateItem> audioBitRate;

			private List<DescribeLiveUpVideoAudioInfo_AudioFramesItem> audioFrames;

			private List<DescribeLiveUpVideoAudioInfo_AudioIntervalItem> audioInterval;

			private List<DescribeLiveUpVideoAudioInfo_AudioStampsItem> audioStamps;

			private List<DescribeLiveUpVideoAudioInfo_AvcHeadersItem> avcHeaders;

			private List<DescribeLiveUpVideoAudioInfo_ErrorFlagsItem> errorFlags;

			private List<DescribeLiveUpVideoAudioInfo_V_AStamp> videoAndAudioStamp;

			private List<DescribeLiveUpVideoAudioInfo_VideoBitRateItem> videoBitRate;

			private List<DescribeLiveUpVideoAudioInfo_VideoFramesItem> videoFrames;

			private List<DescribeLiveUpVideoAudioInfo_VideoIntervalItem> videoInterval;

			private List<DescribeLiveUpVideoAudioInfo_VideoStampsItem> videoStamps;

			[JsonProperty(PropertyName = "AppName")]
			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			[JsonProperty(PropertyName = "CodecInfo")]
			public string CodecInfo
			{
				get
				{
					return codecInfo;
				}
				set	
				{
					codecInfo = value;
				}
			}

			[JsonProperty(PropertyName = "DomainName")]
			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			[JsonProperty(PropertyName = "PublishInterval")]
			public string PublishInterval
			{
				get
				{
					return publishInterval;
				}
				set	
				{
					publishInterval = value;
				}
			}

			[JsonProperty(PropertyName = "PublishIp")]
			public string PublishIp
			{
				get
				{
					return publishIp;
				}
				set	
				{
					publishIp = value;
				}
			}

			[JsonProperty(PropertyName = "PublishStatus")]
			public string PublishStatus
			{
				get
				{
					return publishStatus;
				}
				set	
				{
					publishStatus = value;
				}
			}

			[JsonProperty(PropertyName = "PublishTime")]
			public string PublishTime
			{
				get
				{
					return publishTime;
				}
				set	
				{
					publishTime = value;
				}
			}

			[JsonProperty(PropertyName = "StopTime")]
			public string StopTime
			{
				get
				{
					return stopTime;
				}
				set	
				{
					stopTime = value;
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

			[JsonProperty(PropertyName = "UniqueId")]
			public string UniqueId
			{
				get
				{
					return uniqueId;
				}
				set	
				{
					uniqueId = value;
				}
			}

			[JsonProperty(PropertyName = "AacHeaders")]
			public List<DescribeLiveUpVideoAudioInfo_AacHeadersItem> AacHeaders
			{
				get
				{
					return aacHeaders;
				}
				set	
				{
					aacHeaders = value;
				}
			}

			[JsonProperty(PropertyName = "AudioBitRate")]
			public List<DescribeLiveUpVideoAudioInfo_AudioBitRateItem> AudioBitRate
			{
				get
				{
					return audioBitRate;
				}
				set	
				{
					audioBitRate = value;
				}
			}

			[JsonProperty(PropertyName = "AudioFrames")]
			public List<DescribeLiveUpVideoAudioInfo_AudioFramesItem> AudioFrames
			{
				get
				{
					return audioFrames;
				}
				set	
				{
					audioFrames = value;
				}
			}

			[JsonProperty(PropertyName = "AudioInterval")]
			public List<DescribeLiveUpVideoAudioInfo_AudioIntervalItem> AudioInterval
			{
				get
				{
					return audioInterval;
				}
				set	
				{
					audioInterval = value;
				}
			}

			[JsonProperty(PropertyName = "AudioStamps")]
			public List<DescribeLiveUpVideoAudioInfo_AudioStampsItem> AudioStamps
			{
				get
				{
					return audioStamps;
				}
				set	
				{
					audioStamps = value;
				}
			}

			[JsonProperty(PropertyName = "AvcHeaders")]
			public List<DescribeLiveUpVideoAudioInfo_AvcHeadersItem> AvcHeaders
			{
				get
				{
					return avcHeaders;
				}
				set	
				{
					avcHeaders = value;
				}
			}

			[JsonProperty(PropertyName = "ErrorFlags")]
			public List<DescribeLiveUpVideoAudioInfo_ErrorFlagsItem> ErrorFlags
			{
				get
				{
					return errorFlags;
				}
				set	
				{
					errorFlags = value;
				}
			}

			[JsonProperty(PropertyName = "VideoAndAudioStamp")]
			public List<DescribeLiveUpVideoAudioInfo_V_AStamp> VideoAndAudioStamp
			{
				get
				{
					return videoAndAudioStamp;
				}
				set	
				{
					videoAndAudioStamp = value;
				}
			}

			[JsonProperty(PropertyName = "VideoBitRate")]
			public List<DescribeLiveUpVideoAudioInfo_VideoBitRateItem> VideoBitRate
			{
				get
				{
					return videoBitRate;
				}
				set	
				{
					videoBitRate = value;
				}
			}

			[JsonProperty(PropertyName = "VideoFrames")]
			public List<DescribeLiveUpVideoAudioInfo_VideoFramesItem> VideoFrames
			{
				get
				{
					return videoFrames;
				}
				set	
				{
					videoFrames = value;
				}
			}

			[JsonProperty(PropertyName = "VideoInterval")]
			public List<DescribeLiveUpVideoAudioInfo_VideoIntervalItem> VideoInterval
			{
				get
				{
					return videoInterval;
				}
				set	
				{
					videoInterval = value;
				}
			}

			[JsonProperty(PropertyName = "VideoStamps")]
			public List<DescribeLiveUpVideoAudioInfo_VideoStampsItem> VideoStamps
			{
				get
				{
					return videoStamps;
				}
				set	
				{
					videoStamps = value;
				}
			}

			public class DescribeLiveUpVideoAudioInfo_AacHeadersItem
			{

				private long? time;

				private int? _value;

				[JsonProperty(PropertyName = "Time")]
				public long? Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public int? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeLiveUpVideoAudioInfo_AudioBitRateItem
			{

				private long? time;

				private int? _value;

				[JsonProperty(PropertyName = "Time")]
				public long? Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public int? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeLiveUpVideoAudioInfo_AudioFramesItem
			{

				private long? time;

				private int? _value;

				[JsonProperty(PropertyName = "Time")]
				public long? Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public int? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeLiveUpVideoAudioInfo_AudioIntervalItem
			{

				private long? time;

				private int? _value;

				[JsonProperty(PropertyName = "Time")]
				public long? Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public int? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeLiveUpVideoAudioInfo_AudioStampsItem
			{

				private long? time;

				private int? _value;

				[JsonProperty(PropertyName = "Time")]
				public long? Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public int? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeLiveUpVideoAudioInfo_AvcHeadersItem
			{

				private long? time;

				private int? _value;

				[JsonProperty(PropertyName = "Time")]
				public long? Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public int? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeLiveUpVideoAudioInfo_ErrorFlagsItem
			{

				private long? time;

				private int? _value;

				[JsonProperty(PropertyName = "Time")]
				public long? Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public int? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeLiveUpVideoAudioInfo_V_AStamp
			{

				private long? time;

				private int? _value;

				[JsonProperty(PropertyName = "Time")]
				public long? Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public int? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeLiveUpVideoAudioInfo_VideoBitRateItem
			{

				private long? time;

				private int? _value;

				[JsonProperty(PropertyName = "Time")]
				public long? Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public int? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeLiveUpVideoAudioInfo_VideoFramesItem
			{

				private long? time;

				private int? _value;

				[JsonProperty(PropertyName = "Time")]
				public long? Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public int? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeLiveUpVideoAudioInfo_VideoIntervalItem
			{

				private long? time;

				private int? _value;

				[JsonProperty(PropertyName = "Time")]
				public long? Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public int? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeLiveUpVideoAudioInfo_VideoStampsItem
			{

				private long? time;

				private int? _value;

				[JsonProperty(PropertyName = "Time")]
				public long? Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public int? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
