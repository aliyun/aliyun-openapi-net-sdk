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
	public class DescribeDomainUsageDataResponse : AcsResponse
	{

		private string endTime;

		private string startTime;

		private string requestId;

		private string area;

		private string field;

		private string domainName;

		private string dataInterval;

		private List<DescribeDomainUsageData_DataModule> usageDataPerInterval;

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

		[JsonProperty(PropertyName = "Field")]
		public string Field
		{
			get
			{
				return field;
			}
			set	
			{
				field = value;
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

		[JsonProperty(PropertyName = "DataInterval")]
		public string DataInterval
		{
			get
			{
				return dataInterval;
			}
			set	
			{
				dataInterval = value;
			}
		}

		[JsonProperty(PropertyName = "UsageDataPerInterval")]
		public List<DescribeDomainUsageData_DataModule> UsageDataPerInterval
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

		public class DescribeDomainUsageData_DataModule
		{

			private string _value;

			private string timeStamp;

			[JsonProperty(PropertyName = "_Value")]
			public string _Value
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
		}
	}
}
