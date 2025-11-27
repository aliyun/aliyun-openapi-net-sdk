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
	public class DescribeVodDomainMax95BpsDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string endTime;

		private string startTime;

		private string domesticMax95Bps;

		private string overseasMax95Bps;

		private string max95Bps;

		private List<DescribeVodDomainMax95BpsData_Max95Detail> detailData;

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

		public string DomesticMax95Bps
		{
			get
			{
				return domesticMax95Bps;
			}
			set	
			{
				domesticMax95Bps = value;
			}
		}

		public string OverseasMax95Bps
		{
			get
			{
				return overseasMax95Bps;
			}
			set	
			{
				overseasMax95Bps = value;
			}
		}

		public string Max95Bps
		{
			get
			{
				return max95Bps;
			}
			set	
			{
				max95Bps = value;
			}
		}

		public List<DescribeVodDomainMax95BpsData_Max95Detail> DetailData
		{
			get
			{
				return detailData;
			}
			set	
			{
				detailData = value;
			}
		}

		public class DescribeVodDomainMax95BpsData_Max95Detail
		{

			private string timeStamp;

			private string area;

			private string max95BpsPeakTime;

			private float? max95Bps;

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

			public string Max95BpsPeakTime
			{
				get
				{
					return max95BpsPeakTime;
				}
				set	
				{
					max95BpsPeakTime = value;
				}
			}

			public float? Max95Bps
			{
				get
				{
					return max95Bps;
				}
				set	
				{
					max95Bps = value;
				}
			}
		}
	}
}
