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
	public class DescribeDcdnDomainBpsDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string startTime;

		private string endTime;

		private string dataInterval;

		private List<DescribeDcdnDomainBpsData_DataModule> bpsDataPerInterval;

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

		public List<DescribeDcdnDomainBpsData_DataModule> BpsDataPerInterval
		{
			get
			{
				return bpsDataPerInterval;
			}
			set	
			{
				bpsDataPerInterval = value;
			}
		}

		public class DescribeDcdnDomainBpsData_DataModule
		{

			private string timeStamp;

			private float? bps;

			private float? dynamicHttpBps;

			private float? dynamicHttpsBps;

			private float? staticHttpBps;

			private float? staticHttpsBps;

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

			public float? DynamicHttpBps
			{
				get
				{
					return dynamicHttpBps;
				}
				set	
				{
					dynamicHttpBps = value;
				}
			}

			public float? DynamicHttpsBps
			{
				get
				{
					return dynamicHttpsBps;
				}
				set	
				{
					dynamicHttpsBps = value;
				}
			}

			public float? StaticHttpBps
			{
				get
				{
					return staticHttpBps;
				}
				set	
				{
					staticHttpBps = value;
				}
			}

			public float? StaticHttpsBps
			{
				get
				{
					return staticHttpsBps;
				}
				set	
				{
					staticHttpsBps = value;
				}
			}
		}
	}
}
