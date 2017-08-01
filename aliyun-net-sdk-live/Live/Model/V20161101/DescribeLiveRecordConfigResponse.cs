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
	public class DescribeLiveRecordConfigResponse : AcsResponse
	{

		private string requestId;

		private int? pageNum;

		private int? pageSize;

		private string order;

		private int? totalNum;

		private int? totalPage;

		private List<DescribeLiveRecordConfig_LiveAppRecord> liveAppRecordList;

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

		public List<DescribeLiveRecordConfig_LiveAppRecord> LiveAppRecordList
		{
			get
			{
				return liveAppRecordList;
			}
			set	
			{
				liveAppRecordList = value;
			}
		}

		public class DescribeLiveRecordConfig_LiveAppRecord
		{

			private string domainName;

			private string appName;

			private string ossEndpoint;

			private string ossBucket;

			private string createTime;

			private List<DescribeLiveRecordConfig_RecordFormat> recordFormatList;

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

			public List<DescribeLiveRecordConfig_RecordFormat> RecordFormatList
			{
				get
				{
					return recordFormatList;
				}
				set	
				{
					recordFormatList = value;
				}
			}

			public class DescribeLiveRecordConfig_RecordFormat
			{

				private string format;

				private string ossObjectPrefix;

				private string sliceOssObjectPrefix;

				private int? cycleDuration;

				public string Format
				{
					get
					{
						return format;
					}
					set	
					{
						format = value;
					}
				}

				public string OssObjectPrefix
				{
					get
					{
						return ossObjectPrefix;
					}
					set	
					{
						ossObjectPrefix = value;
					}
				}

				public string SliceOssObjectPrefix
				{
					get
					{
						return sliceOssObjectPrefix;
					}
					set	
					{
						sliceOssObjectPrefix = value;
					}
				}

				public int? CycleDuration
				{
					get
					{
						return cycleDuration;
					}
					set	
					{
						cycleDuration = value;
					}
				}
			}
		}
	}
}