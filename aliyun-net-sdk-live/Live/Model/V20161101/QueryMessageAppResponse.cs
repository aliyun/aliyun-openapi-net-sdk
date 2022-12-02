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
	public class QueryMessageAppResponse : AcsResponse
	{

		private string requestId;

		private List<QueryMessageApp_ResultItem> result;

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
		public List<QueryMessageApp_ResultItem> Result
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

		public class QueryMessageApp_ResultItem
		{

			private int? totalCount;

			private bool? hasMore;

			private List<QueryMessageApp_AppListItem> appList;

			[JsonProperty(PropertyName = "TotalCount")]
			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
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
			public List<QueryMessageApp_AppListItem> AppList
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

			public class QueryMessageApp_AppListItem
			{

				private string appId;

				private string appName;

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

				[JsonProperty(PropertyName = "AppName")]
				public string AppName
				{
					get
					{
						return appName;
					}
					set	
					{
						appName = value;
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
