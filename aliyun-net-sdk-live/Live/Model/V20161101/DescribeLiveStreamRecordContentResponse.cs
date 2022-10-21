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
	public class DescribeLiveStreamRecordContentResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamRecordContent_RecordContentInfo> recordContentInfoList;

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

		[JsonProperty(PropertyName = "RecordContentInfoList")]
		public List<DescribeLiveStreamRecordContent_RecordContentInfo> RecordContentInfoList
		{
			get
			{
				return recordContentInfoList;
			}
			set	
			{
				recordContentInfoList = value;
			}
		}

		public class DescribeLiveStreamRecordContent_RecordContentInfo
		{

			private string endTime;

			private string startTime;

			private float? duration;

			private string ossBucket;

			private string ossObjectPrefix;

			private string ossEndpoint;

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

			[JsonProperty(PropertyName = "Duration")]
			public float? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
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
