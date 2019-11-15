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
	public class DescribeDcdnDomainTrafficDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string startTime;

		private string endTime;

		private string dataInterval;

		private List<DescribeDcdnDomainTrafficData_DataModule> trafficDataPerInterval;

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

		public List<DescribeDcdnDomainTrafficData_DataModule> TrafficDataPerInterval
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

		public class DescribeDcdnDomainTrafficData_DataModule
		{

			private string timeStamp;

			private float? traffic;

			private float? dynamicHttpTraffic;

			private float? dynamicHttpsTraffic;

			private float? staticHttpTraffic;

			private float? staticHttpsTraffic;

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

			public float? Traffic
			{
				get
				{
					return traffic;
				}
				set	
				{
					traffic = value;
				}
			}

			public float? DynamicHttpTraffic
			{
				get
				{
					return dynamicHttpTraffic;
				}
				set	
				{
					dynamicHttpTraffic = value;
				}
			}

			public float? DynamicHttpsTraffic
			{
				get
				{
					return dynamicHttpsTraffic;
				}
				set	
				{
					dynamicHttpsTraffic = value;
				}
			}

			public float? StaticHttpTraffic
			{
				get
				{
					return staticHttpTraffic;
				}
				set	
				{
					staticHttpTraffic = value;
				}
			}

			public float? StaticHttpsTraffic
			{
				get
				{
					return staticHttpsTraffic;
				}
				set	
				{
					staticHttpsTraffic = value;
				}
			}
		}
	}
}
