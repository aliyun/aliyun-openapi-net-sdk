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
	public class DescribeLiveProducerUsageDataResponse : AcsResponse
	{

		private string endTime;

		private string startTime;

		private string requestId;

		private List<DescribeLiveProducerUsageData_BillProducerDataItem> billProducerData;

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

		[JsonProperty(PropertyName = "BillProducerData")]
		public List<DescribeLiveProducerUsageData_BillProducerDataItem> BillProducerData
		{
			get
			{
				return billProducerData;
			}
			set	
			{
				billProducerData = value;
			}
		}

		public class DescribeLiveProducerUsageData_BillProducerDataItem
		{

			private long? tranSdDuration;

			private string type;

			private long? tranLdDuration;

			private string instance;

			private long? tranHdDuration;

			private string region;

			private string timeStamp;

			private long? outputHdDuration;

			private long? outputSdDuration;

			private string domainName;

			private long? outputLdDuration;

			[JsonProperty(PropertyName = "TranSdDuration")]
			public long? TranSdDuration
			{
				get
				{
					return tranSdDuration;
				}
				set	
				{
					tranSdDuration = value;
				}
			}

			[JsonProperty(PropertyName = "Type")]
			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			[JsonProperty(PropertyName = "TranLdDuration")]
			public long? TranLdDuration
			{
				get
				{
					return tranLdDuration;
				}
				set	
				{
					tranLdDuration = value;
				}
			}

			[JsonProperty(PropertyName = "Instance")]
			public string Instance
			{
				get
				{
					return instance;
				}
				set	
				{
					instance = value;
				}
			}

			[JsonProperty(PropertyName = "TranHdDuration")]
			public long? TranHdDuration
			{
				get
				{
					return tranHdDuration;
				}
				set	
				{
					tranHdDuration = value;
				}
			}

			[JsonProperty(PropertyName = "Region")]
			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

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

			[JsonProperty(PropertyName = "OutputHdDuration")]
			public long? OutputHdDuration
			{
				get
				{
					return outputHdDuration;
				}
				set	
				{
					outputHdDuration = value;
				}
			}

			[JsonProperty(PropertyName = "OutputSdDuration")]
			public long? OutputSdDuration
			{
				get
				{
					return outputSdDuration;
				}
				set	
				{
					outputSdDuration = value;
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

			[JsonProperty(PropertyName = "OutputLdDuration")]
			public long? OutputLdDuration
			{
				get
				{
					return outputLdDuration;
				}
				set	
				{
					outputLdDuration = value;
				}
			}
		}
	}
}
