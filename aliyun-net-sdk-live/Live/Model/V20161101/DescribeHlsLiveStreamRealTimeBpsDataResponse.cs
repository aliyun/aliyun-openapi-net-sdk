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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeHlsLiveStreamRealTimeBpsDataResponse : AcsResponse
	{

		private string time;

		private string requestId;

		private List<DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain> usageData;

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