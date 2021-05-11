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

namespace Aliyun.Acs.scdn.Model.V20171115
{
	public class DescribeScdnDomainQpsDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string startTime;

		private string endTime;

		private string dataInterval;

		private List<DescribeScdnDomainQpsData_DataModule> qpsDataPerInterval;

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

		public List<DescribeScdnDomainQpsData_DataModule> QpsDataPerInterval
		{
			get
			{
				return qpsDataPerInterval;
			}
			set	
			{
				qpsDataPerInterval = value;
			}
		}

		public class DescribeScdnDomainQpsData_DataModule
		{

			private string timeStamp;

			private string qpsValue;

			private string httpQpsValue;

			private string httpsQpsValue;

			private string accValue;

			private string httpAccValue;

			private string httpsAccValue;

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

			public string QpsValue
			{
				get
				{
					return qpsValue;
				}
				set	
				{
					qpsValue = value;
				}
			}

			public string HttpQpsValue
			{
				get
				{
					return httpQpsValue;
				}
				set	
				{
					httpQpsValue = value;
				}
			}

			public string HttpsQpsValue
			{
				get
				{
					return httpsQpsValue;
				}
				set	
				{
					httpsQpsValue = value;
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

			public string HttpAccValue
			{
				get
				{
					return httpAccValue;
				}
				set	
				{
					httpAccValue = value;
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
		}
	}
}
