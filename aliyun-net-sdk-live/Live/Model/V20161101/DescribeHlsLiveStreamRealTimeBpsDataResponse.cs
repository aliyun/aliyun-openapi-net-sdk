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
	public class DescribeHlsLiveStreamRealTimeBpsDataResponse : AcsResponse
	{

		private string time;

		private string requestId;

		private List<DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain> usageData;

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

		[JsonProperty(PropertyName = "UsageData")]
		public List<DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain> UsageData
		{
			get
			{
				return usageData;
			}
			set	
			{
				usageData = value;
			}
		}

		public class DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain
		{

			private string domainName;

			private List<DescribeHlsLiveStreamRealTimeBpsData_StreamInfo> streamInfos;

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

			[JsonProperty(PropertyName = "StreamInfos")]
			public List<DescribeHlsLiveStreamRealTimeBpsData_StreamInfo> StreamInfos
			{
				get
				{
					return streamInfos;
				}
				set	
				{
					streamInfos = value;
				}
			}

			public class DescribeHlsLiveStreamRealTimeBpsData_StreamInfo
			{

				private string streamName;

				private List<DescribeHlsLiveStreamRealTimeBpsData_Info> infos;

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

				[JsonProperty(PropertyName = "Infos")]
				public List<DescribeHlsLiveStreamRealTimeBpsData_Info> Infos
				{
					get
					{
						return infos;
					}
					set	
					{
						infos = value;
					}
				}

				public class DescribeHlsLiveStreamRealTimeBpsData_Info
				{

					private float? downFlow;

					private string rate;

					private float? online;

					[JsonProperty(PropertyName = "DownFlow")]
					public float? DownFlow
					{
						get
						{
							return downFlow;
						}
						set	
						{
							downFlow = value;
						}
					}

					[JsonProperty(PropertyName = "Rate")]
					public string Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					[JsonProperty(PropertyName = "Online")]
					public float? Online
					{
						get
						{
							return online;
						}
						set	
						{
							online = value;
						}
					}
				}
			}
		}
	}
}
