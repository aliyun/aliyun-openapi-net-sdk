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
	public class DescribeLiveSnapshotDetectPornConfigResponse : AcsResponse
	{

		private int? pageNum;

		private string requestId;

		private string order;

		private int? totalPage;

		private int? pageSize;

		private int? totalNum;

		private List<DescribeLiveSnapshotDetectPornConfig_LiveSnapshotDetectPornConfig> liveSnapshotDetectPornConfigList;

		[JsonProperty(PropertyName = "PageNum")]
		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
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

		[JsonProperty(PropertyName = "Order")]
		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
			}
		}

		[JsonProperty(PropertyName = "TotalPage")]
		public int? TotalPage
		{
			get
			{
				return totalPage;
			}
			set	
			{
				totalPage = value;
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		[JsonProperty(PropertyName = "TotalNum")]
		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		[JsonProperty(PropertyName = "LiveSnapshotDetectPornConfigList")]
		public List<DescribeLiveSnapshotDetectPornConfig_LiveSnapshotDetectPornConfig> LiveSnapshotDetectPornConfigList
		{
			get
			{
				return liveSnapshotDetectPornConfigList;
			}
			set	
			{
				liveSnapshotDetectPornConfigList = value;
			}
		}

		public class DescribeLiveSnapshotDetectPornConfig_LiveSnapshotDetectPornConfig
		{

			private string ossObject;

			private string appName;

			private int? interval;

			private string ossBucket;

			private string domainName;

			private string ossEndpoint;

			private List<string> scenes;

			[JsonProperty(PropertyName = "OssObject")]
			public string OssObject
			{
				get
				{
					return ossObject;
				}
				set	
				{
					ossObject = value;
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

			[JsonProperty(PropertyName = "Interval")]
			public int? Interval
			{
				get
				{
					return interval;
				}
				set	
				{
					interval = value;
				}
			}

			[JsonProperty(PropertyName = "OssBucket")]
			public string OssBucket
			{
				get
				{
					return ossBucket;
				}
				set	
				{
					ossBucket = value;
				}
			}

			[JsonProperty(PropertyName = "DomainName")]
			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			[JsonProperty(PropertyName = "OssEndpoint")]
			public string OssEndpoint
			{
				get
				{
					return ossEndpoint;
				}
				set	
				{
					ossEndpoint = value;
				}
			}

			[JsonProperty(PropertyName = "Scenes")]
			public List<string> Scenes
			{
				get
				{
					return scenes;
				}
				set	
				{
					scenes = value;
				}
			}
		}
	}
}
