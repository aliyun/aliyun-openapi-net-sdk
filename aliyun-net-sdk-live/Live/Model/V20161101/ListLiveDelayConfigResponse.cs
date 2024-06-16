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
	public class ListLiveDelayConfigResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private List<ListLiveDelayConfig_DelayConfig> delayConfigList;

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

		[JsonProperty(PropertyName = "Total")]
		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		[JsonProperty(PropertyName = "DelayConfigList")]
		public List<ListLiveDelayConfig_DelayConfig> DelayConfigList
		{
			get
			{
				return delayConfigList;
			}
			set	
			{
				delayConfigList = value;
			}
		}

		public class ListLiveDelayConfig_DelayConfig
		{

			private string app;

			private string delayTime;

			private string domain;

			private string stream;

			private string taskTriggerMode;

			[JsonProperty(PropertyName = "App")]
			public string App
			{
				get
				{
					return app;
				}
				set	
				{
					app = value;
				}
			}

			[JsonProperty(PropertyName = "DelayTime")]
			public string DelayTime
			{
				get
				{
					return delayTime;
				}
				set	
				{
					delayTime = value;
				}
			}

			[JsonProperty(PropertyName = "Domain")]
			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			[JsonProperty(PropertyName = "Stream")]
			public string Stream
			{
				get
				{
					return stream;
				}
				set	
				{
					stream = value;
				}
			}

			[JsonProperty(PropertyName = "TaskTriggerMode")]
			public string TaskTriggerMode
			{
				get
				{
					return taskTriggerMode;
				}
				set	
				{
					taskTriggerMode = value;
				}
			}
		}
	}
}
