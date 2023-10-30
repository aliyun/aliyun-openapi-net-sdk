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
	public class ListLiveMessageAppsResponse : AcsResponse
	{

		private string requestId;

		private bool? hasMore;

		private long? nextPageToken;

		private List<ListLiveMessageApps_Apps> appList;

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

		[JsonProperty(PropertyName = "NextPageToken")]
		public long? NextPageToken
		{
			get
			{
				return nextPageToken;
			}
			set	
			{
				nextPageToken = value;
			}
		}

		[JsonProperty(PropertyName = "AppList")]
		public List<ListLiveMessageApps_Apps> AppList
		{
			get
			{
				return appList;
			}
			set	
			{
				appList = value;
			}
		}

		public class ListLiveMessageApps_Apps
		{

			private string appId;

			private string appKey;

			private string appSign;

			private string disable;

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

			[JsonProperty(PropertyName = "AppKey")]
			public string AppKey
			{
				get
				{
					return appKey;
				}
				set	
				{
					appKey = value;
				}
			}

			[JsonProperty(PropertyName = "AppSign")]
			public string AppSign
			{
				get
				{
					return appSign;
				}
				set	
				{
					appSign = value;
				}
			}

			[JsonProperty(PropertyName = "Disable")]
			public string Disable
			{
				get
				{
					return disable;
				}
				set	
				{
					disable = value;
				}
			}
		}
	}
}
