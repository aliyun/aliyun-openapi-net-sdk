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
	public class DescribeLiveCenterStreamRateDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveCenterStreamRateData_Data> rateDatas;

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

		[JsonProperty(PropertyName = "RateDatas")]
		public List<DescribeLiveCenterStreamRateData_Data> RateDatas
		{
			get
			{
				return rateDatas;
			}
			set	
			{
				rateDatas = value;
			}
		}

		public class DescribeLiveCenterStreamRateData_Data
		{

			private string videoFps;

			private string videoRate;

			private string audioFps;

			private string audioRate;

			private string time;

			[JsonProperty(PropertyName = "VideoFps")]
			public string VideoFps
			{
				get
				{
					return videoFps;
				}
				set	
				{
					videoFps = value;
				}
			}

			[JsonProperty(PropertyName = "VideoRate")]
			public string VideoRate
			{
				get
				{
					return videoRate;
				}
				set	
				{
					videoRate = value;
				}
			}

			[JsonProperty(PropertyName = "AudioFps")]
			public string AudioFps
			{
				get
				{
					return audioFps;
				}
				set	
				{
					audioFps = value;
				}
			}

			[JsonProperty(PropertyName = "AudioRate")]
			public string AudioRate
			{
				get
				{
					return audioRate;
				}
				set	
				{
					audioRate = value;
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
		}
	}
}
