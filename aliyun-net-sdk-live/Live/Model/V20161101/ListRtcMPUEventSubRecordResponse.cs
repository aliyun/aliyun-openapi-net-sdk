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
	public class ListRtcMPUEventSubRecordResponse : AcsResponse
	{

		private string requestId;

		private long? count;

		private bool? hasMore;

		private List<ListRtcMPUEventSubRecord_SubInfo> logs;

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

		[JsonProperty(PropertyName = "Count")]
		public long? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		[JsonProperty(PropertyName = "HasMore")]
		public bool? HasMore
		{
			get
			{
				return hasMore;
			}
			set	
			{
				hasMore = value;
			}
		}

		[JsonProperty(PropertyName = "Logs")]
		public List<ListRtcMPUEventSubRecord_SubInfo> Logs
		{
			get
			{
				return logs;
			}
			set	
			{
				logs = value;
			}
		}

		public class ListRtcMPUEventSubRecord_SubInfo
		{

			private string appId;

			private string subId;

			private string msgId;

			private string data;

			private string time;

			private long? cost;

			private string callbackUrl;

			private string hTTPCode;

			[JsonProperty(PropertyName = "AppId")]
			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			[JsonProperty(PropertyName = "SubId")]
			public string SubId
			{
				get
				{
					return subId;
				}
				set	
				{
					subId = value;
				}
			}

			[JsonProperty(PropertyName = "MsgId")]
			public string MsgId
			{
				get
				{
					return msgId;
				}
				set	
				{
					msgId = value;
				}
			}

			[JsonProperty(PropertyName = "Data")]
			public string Data
			{
				get
				{
					return data;
				}
				set	
				{
					data = value;
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

			[JsonProperty(PropertyName = "Cost")]
			public long? Cost
			{
				get
				{
					return cost;
				}
				set	
				{
					cost = value;
				}
			}

			[JsonProperty(PropertyName = "CallbackUrl")]
			public string CallbackUrl
			{
				get
				{
					return callbackUrl;
				}
				set	
				{
					callbackUrl = value;
				}
			}

			[JsonProperty(PropertyName = "HTTPCode")]
			public string HTTPCode
			{
				get
				{
					return hTTPCode;
				}
				set	
				{
					hTTPCode = value;
				}
			}
		}
	}
}
