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
	public class ListMessageAppResponse : AcsResponse
	{

		private string requestId;

		private ListMessageApp_Result result;

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

		[JsonProperty(PropertyName = "Result")]
		public ListMessageApp_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListMessageApp_Result
		{

			private int? total;

			private bool? hasMore;

			private List<ListMessageApp_AppListItem> appList;

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

			[JsonProperty(PropertyName = "AppList")]
			public List<ListMessageApp_AppListItem> AppList
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

			public class ListMessageApp_AppListItem
			{

				private string appId;

				private long? createTime;

				private int? status;

				private string appConfig;

				private string extension;

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

				[JsonProperty(PropertyName = "CreateTime")]
				public long? CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				[JsonProperty(PropertyName = "Status")]
				public int? Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				[JsonProperty(PropertyName = "AppConfig")]
				public string AppConfig
				{
					get
					{
						return appConfig;
					}
					set	
					{
						appConfig = value;
					}
				}

				[JsonProperty(PropertyName = "Extension")]
				public string Extension
				{
					get
					{
						return extension;
					}
					set	
					{
						extension = value;
					}
				}
			}
		}
	}
}
