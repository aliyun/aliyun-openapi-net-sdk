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
	public class DescribeLiveStreamsControlHistoryResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamsControlHistory_LiveStreamControlInfo> controlInfo;

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

		[JsonProperty(PropertyName = "ControlInfo")]
		public List<DescribeLiveStreamsControlHistory_LiveStreamControlInfo> ControlInfo
		{
			get
			{
				return controlInfo;
			}
			set	
			{
				controlInfo = value;
			}
		}

		public class DescribeLiveStreamsControlHistory_LiveStreamControlInfo
		{

			private string clientIP;

			private string timeStamp;

			private string action;

			private string streamName;

			[JsonProperty(PropertyName = "ClientIP")]
			public string ClientIP
			{
				get
				{
					return clientIP;
				}
				set	
				{
					clientIP = value;
				}
			}

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

			[JsonProperty(PropertyName = "Action")]
			public string Action
			{
				get
				{
					return action;
				}
				set	
				{
					action = value;
				}
			}

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
		}
	}
}
