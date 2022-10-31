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
	public class DescribeRTSNativeSDKPlayFailStatusResponse : AcsResponse
	{

		private string requestId;

		private string dataInterval;

		private string startTime;

		private string endTime;

		private List<DescribeRTSNativeSDKPlayFailStatus_Data> playFailStatus;

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

		[JsonProperty(PropertyName = "PlayFailStatus")]
		public List<DescribeRTSNativeSDKPlayFailStatus_Data> PlayFailStatus
		{
			get
			{
				return playFailStatus;
			}
			set	
			{
				playFailStatus = value;
			}
		}

		public class DescribeRTSNativeSDKPlayFailStatus_Data
		{

			private string timeStamp;

			private string v20001;

			private string v20002;

			private string v20011;

			private string v20012;

			private string v20013;

			private string v20052;

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

			[JsonProperty(PropertyName = "V20001")]
			public string V20001
			{
				get
				{
					return v20001;
				}
				set	
				{
					v20001 = value;
				}
			}

			[JsonProperty(PropertyName = "V20002")]
			public string V20002
			{
				get
				{
					return v20002;
				}
				set	
				{
					v20002 = value;
				}
			}

			[JsonProperty(PropertyName = "V20011")]
			public string V20011
			{
				get
				{
					return v20011;
				}
				set	
				{
					v20011 = value;
				}
			}

			[JsonProperty(PropertyName = "V20012")]
			public string V20012
			{
				get
				{
					return v20012;
				}
				set	
				{
					v20012 = value;
				}
			}

			[JsonProperty(PropertyName = "V20013")]
			public string V20013
			{
				get
				{
					return v20013;
				}
				set	
				{
					v20013 = value;
				}
			}

			[JsonProperty(PropertyName = "V20052")]
			public string V20052
			{
				get
				{
					return v20052;
				}
				set	
				{
					v20052 = value;
				}
			}
		}
	}
}
