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
	public class DescribeDomainHttpsDataResponse : AcsResponse
	{

		private string domainNames;

		private string dataInterval;

		private List<HttpsStatisticsInfo> httpsStatisticsInfos;

		public string DomainNames
		{
			get
			{
				return domainNames;
			}
			set	
			{
				domainNames = value;
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

		public List<HttpsStatisticsInfo> HttpsStatisticsInfos
		{
			get
			{
				return httpsStatisticsInfos;
			}
			set	
			{
				httpsStatisticsInfos = value;
			}
		}

		public class HttpsStatisticsInfo{

			private string time;

			private float? l1HttpsBps;

			private float? l1HttpsInnerBps;

			private float? l1HttpsOutBps;

			private long? l1HttpsQps;

			private long? l1HttpsInnerQps;

			private long? l1HttpsOutQps;

			private long? l1HttpsTtraf;

			private long? httpsSrcBps;

			private long? httpsSrcTraf;

			private long? l1HttpsInnerTraf;

			private long? l1HttpsOutTraf;

			private float? httpsByteHitRate;

			private float? httpsReqHitRate;

			private float? l1HttpsHitRate;

			private float? l1HttpsInner_acc;

			private float? l1HttpsOut_acc;

			private float? l1HttpsTacc;

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public float? L1HttpsBps
			{
				get
				{
					return l1HttpsBps;
				}
				set	
				{
					l1HttpsBps = value;
				}
			}

			public float? L1HttpsInnerBps
			{
				get
				{
					return l1HttpsInnerBps;
				}
				set	
				{
					l1HttpsInnerBps = value;
				}
			}

			public float? L1HttpsOutBps
			{
				get
				{
					return l1HttpsOutBps;
				}
				set	
				{
					l1HttpsOutBps = value;
				}
			}

			public long? L1HttpsQps
			{
				get
				{
					return l1HttpsQps;
				}
				set	
				{
					l1HttpsQps = value;
				}
			}

			public long? L1HttpsInnerQps
			{
				get
				{
					return l1HttpsInnerQps;
				}
				set	
				{
					l1HttpsInnerQps = value;
				}
			}

			public long? L1HttpsOutQps
			{
				get
				{
					return l1HttpsOutQps;
				}
				set	
				{
					l1HttpsOutQps = value;
				}
			}

			public long? L1HttpsTtraf
			{
				get
				{
					return l1HttpsTtraf;
				}
				set	
				{
					l1HttpsTtraf = value;
				}
			}

			public long? HttpsSrcBps
			{
				get
				{
					return httpsSrcBps;
				}
				set	
				{
					httpsSrcBps = value;
				}
			}

			public long? HttpsSrcTraf
			{
				get
				{
					return httpsSrcTraf;
				}
				set	
				{
					httpsSrcTraf = value;
				}
			}

			public long? L1HttpsInnerTraf
			{
				get
				{
					return l1HttpsInnerTraf;
				}
				set	
				{
					l1HttpsInnerTraf = value;
				}
			}

			public long? L1HttpsOutTraf
			{
				get
				{
					return l1HttpsOutTraf;
				}
				set	
				{
					l1HttpsOutTraf = value;
				}
			}

			public float? HttpsByteHitRate
			{
				get
				{
					return httpsByteHitRate;
				}
				set	
				{
					httpsByteHitRate = value;
				}
			}

			public float? HttpsReqHitRate
			{
				get
				{
					return httpsReqHitRate;
				}
				set	
				{
					httpsReqHitRate = value;
				}
			}

			public float? L1HttpsHitRate
			{
				get
				{
					return l1HttpsHitRate;
				}
				set	
				{
					l1HttpsHitRate = value;
				}
			}

			public float? L1HttpsInner_acc
			{
				get
				{
					return l1HttpsInner_acc;
				}
				set	
				{
					l1HttpsInner_acc = value;
				}
			}

			public float? L1HttpsOut_acc
			{
				get
				{
					return l1HttpsOut_acc;
				}
				set	
				{
					l1HttpsOut_acc = value;
				}
			}

			public float? L1HttpsTacc
			{
				get
				{
					return l1HttpsTacc;
				}
				set	
				{
					l1HttpsTacc = value;
				}
			}
		}
	}
}