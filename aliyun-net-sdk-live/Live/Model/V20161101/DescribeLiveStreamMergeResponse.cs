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
	public class DescribeLiveStreamMergeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamMerge_LiveStreamMerge> liveStreamMergeList;

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

		[JsonProperty(PropertyName = "LiveStreamMergeList")]
		public List<DescribeLiveStreamMerge_LiveStreamMerge> LiveStreamMergeList
		{
			get
			{
				return liveStreamMergeList;
			}
			set	
			{
				liveStreamMergeList = value;
			}
		}

		public class DescribeLiveStreamMerge_LiveStreamMerge
		{

			private string appName;

			private string appUsing;

			private string domainName;

			private string endTime;

			private string extraInAppStreams;

			private string inAppName1;

			private string inAppName2;

			private string inStreamName1;

			private string inStreamName2;

			private string protocol;

			private string startTime;

			private string streamName;

			private string streamUsing;

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

			[JsonProperty(PropertyName = "AppUsing")]
			public string AppUsing
			{
				get
				{
					return appUsing;
				}
				set	
				{
					appUsing = value;
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

			[JsonProperty(PropertyName = "ExtraInAppStreams")]
			public string ExtraInAppStreams
			{
				get
				{
					return extraInAppStreams;
				}
				set	
				{
					extraInAppStreams = value;
				}
			}

			[JsonProperty(PropertyName = "InAppName1")]
			public string InAppName1
			{
				get
				{
					return inAppName1;
				}
				set	
				{
					inAppName1 = value;
				}
			}

			[JsonProperty(PropertyName = "InAppName2")]
			public string InAppName2
			{
				get
				{
					return inAppName2;
				}
				set	
				{
					inAppName2 = value;
				}
			}

			[JsonProperty(PropertyName = "InStreamName1")]
			public string InStreamName1
			{
				get
				{
					return inStreamName1;
				}
				set	
				{
					inStreamName1 = value;
				}
			}

			[JsonProperty(PropertyName = "InStreamName2")]
			public string InStreamName2
			{
				get
				{
					return inStreamName2;
				}
				set	
				{
					inStreamName2 = value;
				}
			}

			[JsonProperty(PropertyName = "Protocol")]
			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
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

			[JsonProperty(PropertyName = "StreamUsing")]
			public string StreamUsing
			{
				get
				{
					return streamUsing;
				}
				set	
				{
					streamUsing = value;
				}
			}
		}
	}
}
