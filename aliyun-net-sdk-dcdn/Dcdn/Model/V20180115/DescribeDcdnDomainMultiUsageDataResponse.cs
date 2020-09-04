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
	public class DescribeDcdnDomainMultiUsageDataResponse : AcsResponse
	{

		private string requestId;

		private string startTime;

		private string endTime;

		private List<DescribeDcdnDomainMultiUsageData_RequestDataModule> requestPerInterval;

		private List<DescribeDcdnDomainMultiUsageData_TrafficDataModule> trafficPerInterval;

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

		public List<DescribeDcdnDomainMultiUsageData_RequestDataModule> RequestPerInterval
		{
			get
			{
				return requestPerInterval;
			}
			set	
			{
				requestPerInterval = value;
			}
		}

		public List<DescribeDcdnDomainMultiUsageData_TrafficDataModule> TrafficPerInterval
		{
			get
			{
				return trafficPerInterval;
			}
			set	
			{
				trafficPerInterval = value;
			}
		}

		public class DescribeDcdnDomainMultiUsageData_RequestDataModule
		{

			private string timeStamp;

			private string domain;

			private long? request;

			private string type;

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

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public long? Request
			{
				get
				{
					return request;
				}
				set	
				{
					request = value;
				}
			}

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
		}

		public class DescribeDcdnDomainMultiUsageData_TrafficDataModule
		{

			private string timeStamp;

			private string domain;

			private float? bps;

			private string type;

			private string area;

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

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public float? Bps
			{
				get
				{
					return bps;
				}
				set	
				{
					bps = value;
				}
			}

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
		}
	}
}
