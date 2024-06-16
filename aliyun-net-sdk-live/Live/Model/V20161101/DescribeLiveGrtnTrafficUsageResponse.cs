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
	public class DescribeLiveGrtnTrafficUsageResponse : AcsResponse
	{

		private string appId;

		private string area;

		private string endTime;

		private string filed;

		private string requestId;

		private string startTime;

		private List<DescribeLiveGrtnTrafficUsage_UsageData> usageDataPerInterval;

		[JsonProperty(PropertyName = "AppId")]
		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
			}
		}

		[JsonProperty(PropertyName = "Area")]
		public string Area
		{
			get
			{
				return area;
			}
			set	
			{
				area = value;
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

		[JsonProperty(PropertyName = "Filed")]
		public string Filed
		{
			get
			{
				return filed;
			}
			set	
			{
				filed = value;
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

		[JsonProperty(PropertyName = "UsageDataPerInterval")]
		public List<DescribeLiveGrtnTrafficUsage_UsageData> UsageDataPerInterval
		{
			get
			{
				return usageDataPerInterval;
			}
			set	
			{
				usageDataPerInterval = value;
			}
		}

		public class DescribeLiveGrtnTrafficUsage_UsageData
		{

			private string timeStamp;

			private double? _value;

			[JsonProperty(PropertyName = "TimeStamp")]
			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			[JsonProperty(PropertyName = "_Value")]
			public double? _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}
	}
}
