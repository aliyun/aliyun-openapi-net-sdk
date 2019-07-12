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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveRecordVodConfigsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNum;

		private int? pageSize;

		private string total;

		private List<DescribeLiveRecordVodConfigs_LiveRecordVodConfig> liveRecordVodConfigs;

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

			private string createTime;

			private string domainName;

			private string appName;

			private string streamName;

			private string vodTranscodeGroupId;

			private int? cycleDuration;

			private string autoCompose;

			private string composeVodTranscodeGroupId;

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
