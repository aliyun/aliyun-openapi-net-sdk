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
	public class ListEventSubEventResponse : AcsResponse
	{

		private string requestId;

		private long? count;

		private bool? hasMore;

		private List<ListEventSubEvent_LogsItem> logs;

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
		public List<ListEventSubEvent_LogsItem> Logs
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

		public class ListEventSubEvent_LogsItem
		{

			private string appId;

			private string subId;

			private string messageId;

			private string data;

			private int? cost;

			private string time;

			private string url;

			private int? code;

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

			[JsonProperty(PropertyName = "MessageId")]
			public string MessageId
			{
				get
				{
					return messageId;
				}
				set	
				{
					messageId = value;
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

			[JsonProperty(PropertyName = "Cost")]
			public int? Cost
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

			[JsonProperty(PropertyName = "Url")]
			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			[JsonProperty(PropertyName = "Code")]
			public int? Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}
		}
	}
}
