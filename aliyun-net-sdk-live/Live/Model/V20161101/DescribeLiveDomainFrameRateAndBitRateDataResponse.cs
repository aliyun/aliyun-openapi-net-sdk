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
	public class DescribeLiveDomainFrameRateAndBitRateDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveDomainFrameRateAndBitRateData_FrameRateAndBitRateInfo> frameRateAndBitRateInfos;

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

		public List<DescribeLiveDomainFrameRateAndBitRateData_FrameRateAndBitRateInfo> FrameRateAndBitRateInfos
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

		public class DescribeLiveDomainFrameRateAndBitRateData_FrameRateAndBitRateInfo
		{

			private float? audioFrameRate;

			private float? bitRate;

			private float? videoFrameRate;

			private string streamUrl;

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
