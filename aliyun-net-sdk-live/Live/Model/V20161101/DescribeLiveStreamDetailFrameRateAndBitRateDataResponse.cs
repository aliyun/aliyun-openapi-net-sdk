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
	public class DescribeLiveStreamDetailFrameRateAndBitRateDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamDetailFrameRateAndBitRateData_Frabr> frameRateAndBitRateInfos;

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

		[JsonProperty(PropertyName = "FrameRateAndBitRateInfos")]
		public List<DescribeLiveStreamDetailFrameRateAndBitRateData_Frabr> FrameRateAndBitRateInfos
		{
			get
			{
				return frameRateAndBitRateInfos;
			}
			set	
			{
				frameRateAndBitRateInfos = value;
			}
		}

		public class DescribeLiveStreamDetailFrameRateAndBitRateData_Frabr
		{

			private float? audioBitRate;

			private float? audioFrameRate;

			private float? bitRate;

			private string streamUrl;

			private string time;

			private float? videoBitRate;

			private float? videoFrameRate;

			[JsonProperty(PropertyName = "AudioBitRate")]
			public float? AudioBitRate
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

			[JsonProperty(PropertyName = "AudioFrameRate")]
			public float? AudioFrameRate
			{
				get
				{
					return audioFrameRate;
				}
				set	
				{
					audioFrameRate = value;
				}
			}

			[JsonProperty(PropertyName = "BitRate")]
			public float? BitRate
			{
				get
				{
					return bitRate;
				}
				set	
				{
					bitRate = value;
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

			[JsonProperty(PropertyName = "Time")]
			public string Time
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

			[JsonProperty(PropertyName = "VideoBitRate")]
			public float? VideoBitRate
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

			[JsonProperty(PropertyName = "VideoFrameRate")]
			public float? VideoFrameRate
			{
				get
				{
					return videoFrameRate;
				}
				set	
				{
					videoFrameRate = value;
				}
			}
		}
	}
}
