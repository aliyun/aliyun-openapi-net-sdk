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
	public class DescribeLiveStreamsPublishListResponse : AcsResponse
	{

		private int? totalPage;

		private int? pageNum;

		private int? pageSize;

		private string requestId;

		private int? totalNum;

		private List<DescribeLiveStreamsPublishList_LiveStreamPublishInfo> publishInfo;

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

		[JsonProperty(PropertyName = "PublishInfo")]
		public List<DescribeLiveStreamsPublishList_LiveStreamPublishInfo> PublishInfo
		{
			get
			{
				return publishInfo;
			}
			set	
			{
				publishInfo = value;
			}
		}

		public class DescribeLiveStreamsPublishList_LiveStreamPublishInfo
		{

			private string edgeNodeAddr;

			private string publishUrl;

			private string streamName;

			private string domainName;

			private string stopTime;

			private string transcodeId;

			private string publishDomain;

			private string appName;

			private string publishTime;

			private string publishType;

			private string transcoded;

			private string clientAddr;

			private string streamUrl;

			[JsonProperty(PropertyName = "EdgeNodeAddr")]
			public string EdgeNodeAddr
			{
				get
				{
					return edgeNodeAddr;
				}
				set	
				{
					edgeNodeAddr = value;
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

			[JsonProperty(PropertyName = "ClientAddr")]
			public string ClientAddr
			{
				get
				{
					return clientAddr;
				}
				set	
				{
					clientAddr = value;
				}
			}

			[JsonProperty(PropertyName = "StreamUrl")]
			public string StreamUrl
			{
				get
				{
					return streamUrl;
				}
				set	
				{
					streamUrl = value;
				}
			}
		}
	}
}
