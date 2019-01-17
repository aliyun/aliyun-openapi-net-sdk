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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class DescribeVodDomainQpsDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string startTime;

		private string endTime;

		private string dataInterval;

		private List<DescribeVodDomainQpsData_DataModule> qpsDataInterval;

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

		public List<DescribeVodDomainQpsData_DataModule> QpsDataInterval
		{
			get
			{
				return qpsDataInterval;
			}
			set	
			{
				qpsDataInterval = value;
			}
		}

		public class DescribeVodDomainQpsData_DataModule
		{

			private string timeStamp;

			private string _value;

			private string domesticValue;

			private string overseasValue;

			private string accValue;

			private string accDomesticValue;

			private string accOverseasValue;

			private string httpsValue;

			private string httpsDomesticValue;

			private string httpsOverseasValue;

			private string httpsAccValue;

			private string httpsAccDomesticValue;

			private string httpsAccOverseasValue;

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

			public string AccValue
			{
				get
				{
					return accValue;
				}
				set	
				{
					accValue = value;
				}
			}

			public string AccDomesticValue
			{
				get
				{
					return accDomesticValue;
				}
				set	
				{
					accDomesticValue = value;
				}
			}

			public string AccOverseasValue
			{
				get
				{
					return accOverseasValue;
				}
				set	
				{
					accOverseasValue = value;
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

			public string HttpsAccValue
			{
				get
				{
					return httpsAccValue;
				}
				set	
				{
					httpsAccValue = value;
				}
			}

			public string HttpsAccDomesticValue
			{
				get
				{
					return httpsAccDomesticValue;
				}
				set	
				{
					httpsAccDomesticValue = value;
				}
			}

			public string HttpsAccOverseasValue
			{
				get
				{
					return httpsAccOverseasValue;
				}
				set	
				{
					httpsAccOverseasValue = value;
				}
			}
		}
	}
}