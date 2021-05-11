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
	public class DescribeScdnDomainHttpCodeDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string startTime;

		private string endTime;

		private string dataInterval;

		private List<DescribeScdnDomainHttpCodeData_DataModule> dataPerInterval;

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

		public List<DescribeScdnDomainHttpCodeData_DataModule> DataPerInterval
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

		public class DescribeScdnDomainHttpCodeData_DataModule
		{

			private string timeStamp;

			private List<DescribeScdnDomainHttpCodeData_HttpCodeDataModule> httpCodeDataPerInterval;

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

			public List<DescribeScdnDomainHttpCodeData_HttpCodeDataModule> HttpCodeDataPerInterval
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

			public class DescribeScdnDomainHttpCodeData_HttpCodeDataModule
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
