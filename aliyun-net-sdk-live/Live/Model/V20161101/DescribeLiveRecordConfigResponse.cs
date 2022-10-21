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
	public class DescribeLiveRecordConfigResponse : AcsResponse
	{

		private int? pageNum;

		private string requestId;

		private string order;

		private int? totalPage;

		private int? pageSize;

		private int? totalNum;

		private List<DescribeLiveRecordConfig_LiveAppRecord> liveAppRecordList;

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

		[JsonProperty(PropertyName = "LiveAppRecordList")]
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

			private string endTime;

			private string startTime;

			private string appName;

			private string streamName;

			private string createTime;

			private int? onDemond;

			private string ossBucket;

			private string domainName;

			private string ossEndpoint;

			private List<DescribeLiveRecordConfig_RecordFormat> recordFormatList;

			private List<DescribeLiveRecordConfig_RecordFormat> transcodeRecordFormatList;

			private List<string> transcodeTemplates;

			[JsonProperty(PropertyName = "EndTime")]
			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			[JsonProperty(PropertyName = "StartTime")]
			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
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

			[JsonProperty(PropertyName = "StreamName")]
			public string StreamName
			{
				get
				{
					return streamName;
				}
				set	
				{
					streamName = value;
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

			[JsonProperty(PropertyName = "OnDemond")]
			public int? OnDemond
			{
				get
				{
					return onDemond;
				}
				set	
				{
					onDemond = value;
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

			[JsonProperty(PropertyName = "RecordFormatList")]
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

			[JsonProperty(PropertyName = "TranscodeRecordFormatList")]
			public List<DescribeLiveRecordConfig_RecordFormat> TranscodeRecordFormatList
			{
				get
				{
					return transcodeRecordFormatList;
				}
				set	
				{
					transcodeRecordFormatList = value;
				}
			}

			[JsonProperty(PropertyName = "TranscodeTemplates")]
			public List<string> TranscodeTemplates
			{
				get
				{
					return transcodeTemplates;
				}
				set	
				{
					transcodeTemplates = value;
				}
			}

			public class DescribeLiveRecordConfig_RecordFormat
			{

				private int? sliceDuration;

				private int? cycleDuration;

				private string sliceOssObjectPrefix;

				private string ossObjectPrefix;

				private string format;

				[JsonProperty(PropertyName = "SliceDuration")]
				public int? SliceDuration
				{
					get
					{
						return sliceDuration;
					}
					set	
					{
						sliceDuration = value;
					}
				}

				[JsonProperty(PropertyName = "CycleDuration")]
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

				[JsonProperty(PropertyName = "SliceOssObjectPrefix")]
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

				[JsonProperty(PropertyName = "OssObjectPrefix")]
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

				[JsonProperty(PropertyName = "Format")]
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
			}
		}
	}
}
