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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveSnapshotDetectPornConfigResponse : AcsResponse
	{

		private string requestId;

		private int? pageNum;

		private int? pageSize;

		private string order;

		private int? totalNum;

		private int? totalPage;

		private List<DescribeLiveSnapshotDetectPornConfig_LiveSnapshotDetectPornConfig> liveSnapshotDetectPornConfigList;

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

			private string domainName;

			private string appName;

			private string ossEndpoint;

			private string ossBucket;

			private string ossObject;

			private int? interval;

			private List<string> scenes;

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