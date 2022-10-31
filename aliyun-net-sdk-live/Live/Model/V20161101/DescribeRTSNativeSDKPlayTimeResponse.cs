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
	public class DescribeRTSNativeSDKPlayTimeResponse : AcsResponse
	{

		private string requestId;

		private string dataInterval;

		private string startTime;

		private string endTime;

		private List<DescribeRTSNativeSDKPlayTime_Data> playTimeData;

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

		[JsonProperty(PropertyName = "DataInterval")]
		public string DataInterval
		{
			get
			{
				return dataInterval;
			}
			set	
			{
				dataInterval = value;
			}
		}

		[JsonProperty(PropertyName = "StartTime")]
		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		[JsonProperty(PropertyName = "EndTime")]
		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		[JsonProperty(PropertyName = "PlayTimeData")]
		public List<DescribeRTSNativeSDKPlayTime_Data> PlayTimeData
		{
			get
			{
				return playTimeData;
			}
			set	
			{
				playTimeData = value;
			}
		}

		public class DescribeRTSNativeSDKPlayTime_Data
		{

			private string timeStamp;

			private string playTime;

			private string stallTime;

			[JsonProperty(PropertyName = "TimeStamp")]
			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			[JsonProperty(PropertyName = "PlayTime")]
			public string PlayTime
			{
				get
				{
					return playTime;
				}
				set	
				{
					playTime = value;
				}
			}

			[JsonProperty(PropertyName = "StallTime")]
			public string StallTime
			{
				get
				{
					return stallTime;
				}
				set	
				{
					stallTime = value;
				}
			}
		}
	}
}
