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
	public class DescribeLiveStreamsOnlineListResponse : AcsResponse
	{

		private string requestId;

		private int? totalPage;

		private int? pageNum;

		private int? pageSize;

		private int? totalNum;

		private List<DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo> onlineInfo;

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

		[JsonProperty(PropertyName = "TotalPage")]
		public int? TotalPage
		{
			get
			{
				return totalPage;
			}
			set	
			{
				totalPage = value;
			}
		}

		[JsonProperty(PropertyName = "PageNum")]
		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		[JsonProperty(PropertyName = "TotalNum")]
		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		[JsonProperty(PropertyName = "OnlineInfo")]
		public List<DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo> OnlineInfo
		{
			get
			{
				return onlineInfo;
			}
			set	
			{
				onlineInfo = value;
			}
		}

		public class DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo
		{

			private int? audioDataRate;

			private int? frameRate;

			private string publishUrl;

			private string streamName;

			private int? audioCodecId;

			private int? height;

			private int? videoDataRate;

			private string domainName;

			private string transcodeId;

			private string transcodeDrm;

			private string publishDomain;

			private string publishTime;

			private string appName;

			private string publishType;

			private int? videoCodecId;

			private string transcoded;

			private int? width;

			private string clientIp;

			private string serverIp;

			private string streamUrlArgs;

			private int? currAudioDataRate;

			private int? currVideoDataRate;

			private int? currWidth;

			private int? currHeight;

			private int? currFrameRate;

			private int? currVideoCodecId;

			[JsonProperty(PropertyName = "AudioDataRate")]
			public int? AudioDataRate
			{
				get
				{
					return audioDataRate;
				}
				set	
				{
					audioDataRate = value;
				}
			}

			[JsonProperty(PropertyName = "FrameRate")]
			public int? FrameRate
			{
				get
				{
					return frameRate;
				}
				set	
				{
					frameRate = value;
				}
			}

			[JsonProperty(PropertyName = "PublishUrl")]
			public string PublishUrl
			{
				get
				{
					return publishUrl;
				}
				set	
				{
					publishUrl = value;
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

			[JsonProperty(PropertyName = "AudioCodecId")]
			public int? AudioCodecId
			{
				get
				{
					return audioCodecId;
				}
				set	
				{
					audioCodecId = value;
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

			[JsonProperty(PropertyName = "VideoDataRate")]
			public int? VideoDataRate
			{
				get
				{
					return videoDataRate;
				}
				set	
				{
					videoDataRate = value;
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

			[JsonProperty(PropertyName = "TranscodeId")]
			public string TranscodeId
			{
				get
				{
					return transcodeId;
				}
				set	
				{
					transcodeId = value;
				}
			}

			[JsonProperty(PropertyName = "TranscodeDrm")]
			public string TranscodeDrm
			{
				get
				{
					return transcodeDrm;
				}
				set	
				{
					transcodeDrm = value;
				}
			}

			[JsonProperty(PropertyName = "PublishDomain")]
			public string PublishDomain
			{
				get
				{
					return publishDomain;
				}
				set	
				{
					publishDomain = value;
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

			[JsonProperty(PropertyName = "PublishType")]
			public string PublishType
			{
				get
				{
					return publishType;
				}
				set	
				{
					publishType = value;
				}
			}

			[JsonProperty(PropertyName = "VideoCodecId")]
			public int? VideoCodecId
			{
				get
				{
					return videoCodecId;
				}
				set	
				{
					videoCodecId = value;
				}
			}

			[JsonProperty(PropertyName = "Transcoded")]
			public string Transcoded
			{
				get
				{
					return transcoded;
				}
				set	
				{
					transcoded = value;
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

			[JsonProperty(PropertyName = "ClientIp")]
			public string ClientIp
			{
				get
				{
					return clientIp;
				}
				set	
				{
					clientIp = value;
				}
			}

			[JsonProperty(PropertyName = "ServerIp")]
			public string ServerIp
			{
				get
				{
					return serverIp;
				}
				set	
				{
					serverIp = value;
				}
			}

			[JsonProperty(PropertyName = "StreamUrlArgs")]
			public string StreamUrlArgs
			{
				get
				{
					return streamUrlArgs;
				}
				set	
				{
					streamUrlArgs = value;
				}
			}

			[JsonProperty(PropertyName = "CurrAudioDataRate")]
			public int? CurrAudioDataRate
			{
				get
				{
					return currAudioDataRate;
				}
				set	
				{
					currAudioDataRate = value;
				}
			}

			[JsonProperty(PropertyName = "CurrVideoDataRate")]
			public int? CurrVideoDataRate
			{
				get
				{
					return currVideoDataRate;
				}
				set	
				{
					currVideoDataRate = value;
				}
			}

			[JsonProperty(PropertyName = "CurrWidth")]
			public int? CurrWidth
			{
				get
				{
					return currWidth;
				}
				set	
				{
					currWidth = value;
				}
			}

			[JsonProperty(PropertyName = "CurrHeight")]
			public int? CurrHeight
			{
				get
				{
					return currHeight;
				}
				set	
				{
					currHeight = value;
				}
			}

			[JsonProperty(PropertyName = "CurrFrameRate")]
			public int? CurrFrameRate
			{
				get
				{
					return currFrameRate;
				}
				set	
				{
					currFrameRate = value;
				}
			}

			[JsonProperty(PropertyName = "CurrVideoCodecId")]
			public int? CurrVideoCodecId
			{
				get
				{
					return currVideoCodecId;
				}
				set	
				{
					currVideoCodecId = value;
				}
			}
		}
	}
}
