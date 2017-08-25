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

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeExtensiveDomainDataResponse : AcsResponse
	{

		private string requestId;

		private string extensiveDomain;

		private string dataInterval;

		private string startTime;

		private string endTime;

		private string pageNumber;

		private string totalCount;

		private string pageSize;

		private List<DescribeExtensiveDomainData_UsageData> dataPerInterval;

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

		public string ExtensiveDomain
		{
			get
			{
				return extensiveDomain;
			}
			set	
			{
				extensiveDomain = value;
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

		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public string TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeExtensiveDomainData_UsageData> DataPerInterval
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

		public class DescribeExtensiveDomainData_UsageData
		{

			private string exactDomain;

			private string timeStamp;

			private string acc;

			private string flow;

			public string ExactDomain
			{
				get
				{
					return exactDomain;
				}
				set	
				{
					exactDomain = value;
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

			public string Acc
			{
				get
				{
					return acc;
				}
				set	
				{
					acc = value;
				}
			}

			public string Flow
			{
				get
				{
					return flow;
				}
				set	
				{
					flow = value;
				}
			}
		}
	}
}