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
	public class DescribeLivePullStreamConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLivePullStreamConfig_LiveAppRecord> liveAppRecordList;

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

		[JsonProperty(PropertyName = "LiveAppRecordList")]
		public List<DescribeLivePullStreamConfig_LiveAppRecord> LiveAppRecordList
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

		public class DescribeLivePullStreamConfig_LiveAppRecord
		{

			private string endTime;

			private string appName;

			private string sourceUrl;

			private string startTime;

			private string always;

			private string streamName;

			private string sourceUsing;

			private string domainName;

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

			[JsonProperty(PropertyName = "SourceUrl")]
			public string SourceUrl
			{
				get
				{
					return sourceUrl;
				}
				set	
				{
					sourceUrl = value;
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

			[JsonProperty(PropertyName = "Always")]
			public string Always
			{
				get
				{
					return always;
				}
				set	
				{
					always = value;
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

			[JsonProperty(PropertyName = "SourceUsing")]
			public string SourceUsing
			{
				get
				{
					return sourceUsing;
				}
				set	
				{
					sourceUsing = value;
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
