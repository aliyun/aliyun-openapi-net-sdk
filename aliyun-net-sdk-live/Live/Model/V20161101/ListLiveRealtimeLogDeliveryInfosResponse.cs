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
	public class ListLiveRealtimeLogDeliveryInfosResponse : AcsResponse
	{

		private string requestId;

		private List<ListLiveRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos> content;

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

		[JsonProperty(PropertyName = "Content")]
		public List<ListLiveRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos> Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public class ListLiveRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos
		{

			private string logstore;

			private string project;

			private string region;

			[JsonProperty(PropertyName = "Logstore")]
			public string Logstore
			{
				get
				{
					return logstore;
				}
				set	
				{
					logstore = value;
				}
			}

			[JsonProperty(PropertyName = "Project")]
			public string Project
			{
				get
				{
					return project;
				}
				set	
				{
					project = value;
				}
			}

			[JsonProperty(PropertyName = "Region")]
			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}
		}
	}
}
