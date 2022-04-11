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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class DescribeVodDomainTrafficDataResponse : AcsResponse
	{

		private string endTime;

		private string startTime;

		private string requestId;

		private string domainName;

		private string totalTraffic;

		private string dataInterval;

		private List<DescribeVodDomainTrafficData_DataModule> trafficDataPerInterval;

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

		public string TotalTraffic
		{
			get
			{
				return totalTraffic;
			}
			set	
			{
				totalTraffic = value;
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

		public List<DescribeVodDomainTrafficData_DataModule> TrafficDataPerInterval
		{
			get
			{
				return trafficDataPerInterval;
			}
			set	
			{
				trafficDataPerInterval = value;
			}
		}

		public class DescribeVodDomainTrafficData_DataModule
		{

			private string httpsDomesticValue;

			private string _value;

			private string overseasValue;

			private string httpsValue;

			private string httpsOverseasValue;

			private string timeStamp;

			private string domesticValue;

			public string HttpsDomesticValue
			{
				get
				{
					return httpsDomesticValue;
				}
				set	
				{
					httpsDomesticValue = value;
				}
			}

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

			public string OverseasValue
			{
				get
				{
					return overseasValue;
				}
				set	
				{
					overseasValue = value;
				}
			}

			public string HttpsValue
			{
				get
				{
					return httpsValue;
				}
				set	
				{
					httpsValue = value;
				}
			}

			public string HttpsOverseasValue
			{
				get
				{
					return httpsOverseasValue;
				}
				set	
				{
					httpsOverseasValue = value;
				}
			}

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

			public string DomesticValue
			{
				get
				{
					return domesticValue;
				}
				set	
				{
					domesticValue = value;
				}
			}
		}
	}
}
