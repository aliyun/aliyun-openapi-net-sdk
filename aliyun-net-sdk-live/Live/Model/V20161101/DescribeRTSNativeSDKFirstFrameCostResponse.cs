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
	public class DescribeRTSNativeSDKFirstFrameCostResponse : AcsResponse
	{

		private string requestId;

		private string dataInterval;

		private string startTime;

		private string endTime;

		private List<DescribeRTSNativeSDKFirstFrameCost_Data> firstFrameCostData;

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

		[JsonProperty(PropertyName = "FirstFrameCostData")]
		public List<DescribeRTSNativeSDKFirstFrameCost_Data> FirstFrameCostData
		{
			get
			{
				return firstFrameCostData;
			}
			set	
			{
				firstFrameCostData = value;
			}
		}

		public class DescribeRTSNativeSDKFirstFrameCost_Data
		{

			private string timeStamp;

			private string initialized;

			private string connected;

			private string finishGetStreamInfo;

			private string firstPacket;

			private string firstFrameComplete;

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

			[JsonProperty(PropertyName = "Initialized")]
			public string Initialized
			{
				get
				{
					return initialized;
				}
				set	
				{
					initialized = value;
				}
			}

			[JsonProperty(PropertyName = "Connected")]
			public string Connected
			{
				get
				{
					return connected;
				}
				set	
				{
					connected = value;
				}
			}

			[JsonProperty(PropertyName = "FinishGetStreamInfo")]
			public string FinishGetStreamInfo
			{
				get
				{
					return finishGetStreamInfo;
				}
				set	
				{
					finishGetStreamInfo = value;
				}
			}

			[JsonProperty(PropertyName = "FirstPacket")]
			public string FirstPacket
			{
				get
				{
					return firstPacket;
				}
				set	
				{
					firstPacket = value;
				}
			}

			[JsonProperty(PropertyName = "FirstFrameComplete")]
			public string FirstFrameComplete
			{
				get
				{
					return firstFrameComplete;
				}
				set	
				{
					firstFrameComplete = value;
				}
			}
		}
	}
}
