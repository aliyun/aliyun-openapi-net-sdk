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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeDomainRealTimeSrcHttpCodeDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string startTime;

		private string endTime;

		private string dataInterval;

		private List<DescribeDomainRealTimeSrcHttpCodeData_UsageData> realTimeSrcHttpCodeData;

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

		public List<DescribeDomainRealTimeSrcHttpCodeData_UsageData> RealTimeSrcHttpCodeData
		{
			get
			{
				return realTimeSrcHttpCodeData;
			}
			set	
			{
				realTimeSrcHttpCodeData = value;
			}
		}

		public class DescribeDomainRealTimeSrcHttpCodeData_UsageData
		{

			private string timeStamp;

			private List<DescribeDomainRealTimeSrcHttpCodeData_RealTimeSrcCodeProportionData> _value;

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

			public List<DescribeDomainRealTimeSrcHttpCodeData_RealTimeSrcCodeProportionData> _Value
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

			public class DescribeDomainRealTimeSrcHttpCodeData_RealTimeSrcCodeProportionData
			{

				private string code;

				private string proportion;

				private string count;

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
			}
		}
	}
}
