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
	public class DescribeLiveRecordVodConfigsResponse : AcsResponse
	{

		private int? pageNum;

		private string requestId;

		private int? pageSize;

		private string total;

		private List<DescribeLiveRecordVodConfigs_LiveRecordVodConfig> liveRecordVodConfigs;

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

		[JsonProperty(PropertyName = "Total")]
		public string Total
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

		[JsonProperty(PropertyName = "LiveRecordVodConfigs")]
		public List<DescribeLiveRecordVodConfigs_LiveRecordVodConfig> LiveRecordVodConfigs
		{
			get
			{
				return liveRecordVodConfigs;
			}
			set	
			{
				liveRecordVodConfigs = value;
			}
		}

		public class DescribeLiveRecordVodConfigs_LiveRecordVodConfig
		{

			private string appName;

			private string autoCompose;

			private string streamName;

			private string createTime;

			private string vodTranscodeGroupId;

			private int? cycleDuration;

			private string domainName;

			private string composeVodTranscodeGroupId;

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

			[JsonProperty(PropertyName = "AutoCompose")]
			public string AutoCompose
			{
				get
				{
					return autoCompose;
				}
				set	
				{
					autoCompose = value;
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

			[JsonProperty(PropertyName = "VodTranscodeGroupId")]
			public string VodTranscodeGroupId
			{
				get
				{
					return vodTranscodeGroupId;
				}
				set	
				{
					vodTranscodeGroupId = value;
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

			[JsonProperty(PropertyName = "ComposeVodTranscodeGroupId")]
			public string ComposeVodTranscodeGroupId
			{
				get
				{
					return composeVodTranscodeGroupId;
				}
				set	
				{
					composeVodTranscodeGroupId = value;
				}
			}
		}
	}
}
