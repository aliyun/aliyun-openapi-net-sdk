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

		private int? totalPage;

		private int? pageNum;

		private int? pageSize;

		private string requestId;

		private int? totalNum;

		private List<DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo> onlineInfo;

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
		}
	}
}
