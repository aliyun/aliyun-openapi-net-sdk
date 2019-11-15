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

namespace Aliyun.Acs.dcdn.Model.V20180115
{
	public class DescribeDcdnDomainHttpCodeDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string startTime;

		private string endTime;

		private string dataInterval;

		private List<DescribeDcdnDomainHttpCodeData_DataModule> dataPerInterval;

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

		public List<DescribeDcdnDomainHttpCodeData_DataModule> DataPerInterval
		{
			get
			{
				return dataPerInterval;
			}
			set	
			{
				dataPerInterval = value;
			}
		}

		public class DescribeDcdnDomainHttpCodeData_DataModule
		{

			private string timeStamp;

			private List<DescribeDcdnDomainHttpCodeData_HttpCodeDataModule> httpCodeDataPerInterval;

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

			public List<DescribeDcdnDomainHttpCodeData_HttpCodeDataModule> HttpCodeDataPerInterval
			{
				get
				{
					return httpCodeDataPerInterval;
				}
				set	
				{
					httpCodeDataPerInterval = value;
				}
			}

			public class DescribeDcdnDomainHttpCodeData_HttpCodeDataModule
			{

				private int? code;

				private float? proportion;

				private float? count;

				public int? Code
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

				public float? Proportion
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

				public float? Count
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
