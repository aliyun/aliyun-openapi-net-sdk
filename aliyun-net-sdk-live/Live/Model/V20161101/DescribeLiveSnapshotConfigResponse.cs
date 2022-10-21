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
	public class DescribeLiveSnapshotConfigResponse : AcsResponse
	{

		private int? pageNum;

		private string requestId;

		private string order;

		private int? totalPage;

		private int? pageSize;

		private int? totalNum;

		private List<DescribeLiveSnapshotConfig_LiveStreamSnapshotConfig> liveStreamSnapshotConfigList;

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

		[JsonProperty(PropertyName = "LiveStreamSnapshotConfigList")]
		public List<DescribeLiveSnapshotConfig_LiveStreamSnapshotConfig> LiveStreamSnapshotConfigList
		{
			get
			{
				return liveStreamSnapshotConfigList;
			}
			set	
			{
				liveStreamSnapshotConfigList = value;
			}
		}

		public class DescribeLiveSnapshotConfig_LiveStreamSnapshotConfig
		{

			private string overwriteOssObject;

			private int? timeInterval;

			private string appName;

			private string createTime;

			private string ossBucket;

			private string domainName;

			private string callback;

			private string sequenceOssObject;

			private string ossEndpoint;

			[JsonProperty(PropertyName = "OverwriteOssObject")]
			public string OverwriteOssObject
			{
				get
				{
					return overwriteOssObject;
				}
				set	
				{
					overwriteOssObject = value;
				}
			}

			[JsonProperty(PropertyName = "TimeInterval")]
			public int? TimeInterval
			{
				get
				{
					return timeInterval;
				}
				set	
				{
					timeInterval = value;
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
			public string CreateTime
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

			[JsonProperty(PropertyName = "Callback")]
			public string Callback
			{
				get
				{
					return callback;
				}
				set	
				{
					callback = value;
				}
			}

			[JsonProperty(PropertyName = "SequenceOssObject")]
			public string SequenceOssObject
			{
				get
				{
					return sequenceOssObject;
				}
				set	
				{
					sequenceOssObject = value;
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
		}
	}
}
