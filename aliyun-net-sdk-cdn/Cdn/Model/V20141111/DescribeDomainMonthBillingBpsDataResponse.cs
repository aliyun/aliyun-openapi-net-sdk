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
	public class DescribeDomainMonthBillingBpsDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string startTime;

		private string endTime;

		private float? bandwidth95Bps;

		private float? domesticBandwidth95Bps;

		private float? overseasBandwidth95Bps;

		private float? monthavgBps;

		private float? domesticMonthavgBps;

		private float? overseasMonthavgBps;

		private float? month4thBps;

		private float? domesticMonth4thBps;

		private float? overseasMonth4thBps;

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

		public float? Bandwidth95Bps
		{
			get
			{
				return bandwidth95Bps;
			}
			set	
			{
				bandwidth95Bps = value;
			}
		}

		public float? DomesticBandwidth95Bps
		{
			get
			{
				return domesticBandwidth95Bps;
			}
			set	
			{
				domesticBandwidth95Bps = value;
			}
		}

		public float? OverseasBandwidth95Bps
		{
			get
			{
				return overseasBandwidth95Bps;
			}
			set	
			{
				overseasBandwidth95Bps = value;
			}
		}

		public float? MonthavgBps
		{
			get
			{
				return monthavgBps;
			}
			set	
			{
				monthavgBps = value;
			}
		}

		public float? DomesticMonthavgBps
		{
			get
			{
				return domesticMonthavgBps;
			}
			set	
			{
				domesticMonthavgBps = value;
			}
		}

		public float? OverseasMonthavgBps
		{
			get
			{
				return overseasMonthavgBps;
			}
			set	
			{
				overseasMonthavgBps = value;
			}
		}

		public float? Month4thBps
		{
			get
			{
				return month4thBps;
			}
			set	
			{
				month4thBps = value;
			}
		}

		public float? DomesticMonth4thBps
		{
			get
			{
				return domesticMonth4thBps;
			}
			set	
			{
				domesticMonth4thBps = value;
			}
		}

		public float? OverseasMonth4thBps
		{
			get
			{
				return overseasMonth4thBps;
			}
			set	
			{
				overseasMonth4thBps = value;
			}
		}
	}
}