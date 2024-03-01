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
	public class DescribeLiveDomainPublishErrorCodeResponse : AcsResponse
	{

		private string requestId;

		private string dataInterval;

		private string domainName;

		private string startTime;

		private string endTime;

		private List<DescribeLiveDomainPublishErrorCode_Rtcd> realTimeCodeData;

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

		[JsonProperty(PropertyName = "RealTimeCodeData")]
		public List<DescribeLiveDomainPublishErrorCode_Rtcd> RealTimeCodeData
		{
			get
			{
				return realTimeCodeData;
			}
			set	
			{
				realTimeCodeData = value;
			}
		}

		public class DescribeLiveDomainPublishErrorCode_Rtcd
		{

			private string timeStamp;

			private List<DescribeLiveDomainPublishErrorCode_Cd> codeData;

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

			[JsonProperty(PropertyName = "CodeData")]
			public List<DescribeLiveDomainPublishErrorCode_Cd> CodeData
			{
				get
				{
					return codeData;
				}
				set	
				{
					codeData = value;
				}
			}

			public class DescribeLiveDomainPublishErrorCode_Cd
			{

				private string code;

				private string count;

				private string proportion;

				[JsonProperty(PropertyName = "Code")]
				public string Code
				{
					get
					{
						return code;
					}
					set	
					{
						code = value;
					}
				}

				[JsonProperty(PropertyName = "Count")]
				public string Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				[JsonProperty(PropertyName = "Proportion")]
				public string Proportion
				{
					get
					{
						return proportion;
					}
					set	
					{
						proportion = value;
					}
				}
			}
		}
	}
}
