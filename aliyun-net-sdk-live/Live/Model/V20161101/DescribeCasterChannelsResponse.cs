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
	public class DescribeCasterChannelsResponse : AcsResponse
	{

		private int? total;

		private string requestId;

		private List<DescribeCasterChannels_Channel> channels;

		[JsonProperty(PropertyName = "Total")]
		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
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

		[JsonProperty(PropertyName = "Channels")]
		public List<DescribeCasterChannels_Channel> Channels
		{
			get
			{
				return channels;
			}
			set	
			{
				channels = value;
			}
		}

		public class DescribeCasterChannels_Channel
		{

			private int? inputType;

			private string rtmpUrl;

			private string channelId;

			private string rtsUrl;

			private string faceBeauty;

			private string resourceId;

			private string streamUrl;

			[JsonProperty(PropertyName = "InputType")]
			public int? InputType
			{
				get
				{
					return inputType;
				}
				set	
				{
					inputType = value;
				}
			}

			[JsonProperty(PropertyName = "RtmpUrl")]
			public string RtmpUrl
			{
				get
				{
					return rtmpUrl;
				}
				set	
				{
					rtmpUrl = value;
				}
			}

			[JsonProperty(PropertyName = "ChannelId")]
			public string ChannelId
			{
				get
				{
					return channelId;
				}
				set	
				{
					channelId = value;
				}
			}

			[JsonProperty(PropertyName = "RtsUrl")]
			public string RtsUrl
			{
				get
				{
					return rtsUrl;
				}
				set	
				{
					rtsUrl = value;
				}
			}

			[JsonProperty(PropertyName = "FaceBeauty")]
			public string FaceBeauty
			{
				get
				{
					return faceBeauty;
				}
				set	
				{
					faceBeauty = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceId")]
			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
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
