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
	public class DescribeLiveStreamsNotifyRecordsResponse : AcsResponse
	{

		private int? totalPage;

		private int? pageNum;

		private int? pageSize;

		private string requestId;

		private int? totalNum;

		private List<DescribeLiveStreamsNotifyRecords_LiveStreamNotifyRecordsInfo> notifyRecordsInfo;

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

		[JsonProperty(PropertyName = "NotifyRecordsInfo")]
		public List<DescribeLiveStreamsNotifyRecords_LiveStreamNotifyRecordsInfo> NotifyRecordsInfo
		{
			get
			{
				return notifyRecordsInfo;
			}
			set	
			{
				notifyRecordsInfo = value;
			}
		}

		public class DescribeLiveStreamsNotifyRecords_LiveStreamNotifyRecordsInfo
		{

			private string appName;

			private string notifyType;

			private string notifyContent;

			private string description;

			private string streamName;

			private string notifyUrl;

			private string notifyResult;

			private string notifyTime;

			private string domainName;

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

			[JsonProperty(PropertyName = "NotifyType")]
			public string NotifyType
			{
				get
				{
					return notifyType;
				}
				set	
				{
					notifyType = value;
				}
			}

			[JsonProperty(PropertyName = "NotifyContent")]
			public string NotifyContent
			{
				get
				{
					return notifyContent;
				}
				set	
				{
					notifyContent = value;
				}
			}

			[JsonProperty(PropertyName = "Description")]
			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			[JsonProperty(PropertyName = "NotifyUrl")]
			public string NotifyUrl
			{
				get
				{
					return notifyUrl;
				}
				set	
				{
					notifyUrl = value;
				}
			}

			[JsonProperty(PropertyName = "NotifyResult")]
			public string NotifyResult
			{
				get
				{
					return notifyResult;
				}
				set	
				{
					notifyResult = value;
				}
			}

			[JsonProperty(PropertyName = "NotifyTime")]
			public string NotifyTime
			{
				get
				{
					return notifyTime;
				}
				set	
				{
					notifyTime = value;
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
		}
	}
}
