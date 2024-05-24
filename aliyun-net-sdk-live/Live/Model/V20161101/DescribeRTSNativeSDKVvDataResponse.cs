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
	public class DescribeRTSNativeSDKVvDataResponse : AcsResponse
	{

		private string dataInterval;

		private string endTime;

		private string requestId;

		private string startTime;

		private List<DescribeRTSNativeSDKVvData_Data> vvData;

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

		[JsonProperty(PropertyName = "VvData")]
		public List<DescribeRTSNativeSDKVvData_Data> VvData
		{
			get
			{
				return vvData;
			}
			set	
			{
				vvData = value;
			}
		}

		public class DescribeRTSNativeSDKVvData_Data
		{

			private string timeStamp;

			private string vvSuccess;

			private string vvTotal;

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

			[JsonProperty(PropertyName = "VvSuccess")]
			public string VvSuccess
			{
				get
				{
					return vvSuccess;
				}
				set	
				{
					vvSuccess = value;
				}
			}

			[JsonProperty(PropertyName = "VvTotal")]
			public string VvTotal
			{
				get
				{
					return vvTotal;
				}
				set	
				{
					vvTotal = value;
				}
			}
		}
	}
}
