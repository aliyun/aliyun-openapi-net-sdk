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
	public class DescribeDomainISPDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string dataInterval;

		private string startTime;

		private string endTime;

		private List<DescribeDomainISPData_ISPProportionData> _value;

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

		public List<DescribeDomainISPData_ISPProportionData> _Value
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

		public class DescribeDomainISPData_ISPProportionData
		{

			private string iSP;

			private string proportion;

			private string ispEname;

			private string avgObjectSize;

			private string avgResponseTime;

			private string bps;

			private string byteHitRate;

			private string qps;

			private string reqErrRate;

			private string reqHitRate;

			private string avgResponseRate;

			private string totalBytes;

			private string bytesProportion;

			private string totalQuery;

			public string ISP
			{
				get
				{
					return iSP;
				}
				set	
				{
					iSP = value;
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

			public string IspEname
			{
				get
				{
					return ispEname;
				}
				set	
				{
					ispEname = value;
				}
			}

			public string AvgObjectSize
			{
				get
				{
					return avgObjectSize;
				}
				set	
				{
					avgObjectSize = value;
				}
			}

			public string AvgResponseTime
			{
				get
				{
					return avgResponseTime;
				}
				set	
				{
					avgResponseTime = value;
				}
			}

			public string Bps
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

			public string ByteHitRate
			{
				get
				{
					return byteHitRate;
				}
				set	
				{
					byteHitRate = value;
				}
			}

			public string Qps
			{
				get
				{
					return qps;
				}
				set	
				{
					qps = value;
				}
			}

			public string ReqErrRate
			{
				get
				{
					return reqErrRate;
				}
				set	
				{
					reqErrRate = value;
				}
			}

			public string ReqHitRate
			{
				get
				{
					return reqHitRate;
				}
				set	
				{
					reqHitRate = value;
				}
			}

			public string AvgResponseRate
			{
				get
				{
					return avgResponseRate;
				}
				set	
				{
					avgResponseRate = value;
				}
			}

			public string TotalBytes
			{
				get
				{
					return totalBytes;
				}
				set	
				{
					totalBytes = value;
				}
			}

			public string BytesProportion
			{
				get
				{
					return bytesProportion;
				}
				set	
				{
					bytesProportion = value;
				}
			}

			public string TotalQuery
			{
				get
				{
					return totalQuery;
				}
				set	
				{
					totalQuery = value;
				}
			}
		}
	}
}