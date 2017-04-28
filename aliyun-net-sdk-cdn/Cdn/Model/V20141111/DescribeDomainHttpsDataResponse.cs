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

			private float? l1DyHttpsBps;

			private float? l1DyHttpsInnerBps;

			private float? l1DyHttpsOutBps;

			private float? l1StHttpsBps;

			private float? l1StHttpsInnerBps;

			private float? l1StHttpsOutBps;

			private float? l1DyHttpsTraf;

			private float? l1DyHttpsInnerTraf;

			private float? l1DyHttpsOutTraf;

			private float? l1StHttpsTraf;

			private float? l1StHttpsInnerTraf;

			private float? l1StHttpsOutTraf;

			private float? l1DyHttpsQps;

			private float? l1DyHttpsInnerQps;

			private float? l1DyHttpsOutQps;

			private float? l1StHttpsQps;

			private float? l1StHttpsInnerQps;

			private float? l1StHttpsOutQps;

			private float? l1DyHttpsAcc;

			private float? l1DyHttpsInnerAcc;

			private float? l1DyHttpsOutAcc;

			private float? l1StHttpsAcc;

			private float? l1StHttpsInnerAcc;

			private float? l1StHttpsOutAcc;

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

			public float? L1DyHttpsBps
			{
				get
				{
					return l1DyHttpsBps;
				}
				set	
				{
					l1DyHttpsBps = value;
				}
			}

			public float? L1DyHttpsInnerBps
			{
				get
				{
					return l1DyHttpsInnerBps;
				}
				set	
				{
					l1DyHttpsInnerBps = value;
				}
			}

			public float? L1DyHttpsOutBps
			{
				get
				{
					return l1DyHttpsOutBps;
				}
				set	
				{
					l1DyHttpsOutBps = value;
				}
			}

			public float? L1StHttpsBps
			{
				get
				{
					return l1StHttpsBps;
				}
				set	
				{
					l1StHttpsBps = value;
				}
			}

			public float? L1StHttpsInnerBps
			{
				get
				{
					return l1StHttpsInnerBps;
				}
				set	
				{
					l1StHttpsInnerBps = value;
				}
			}

			public float? L1StHttpsOutBps
			{
				get
				{
					return l1StHttpsOutBps;
				}
				set	
				{
					l1StHttpsOutBps = value;
				}
			}

			public float? L1DyHttpsTraf
			{
				get
				{
					return l1DyHttpsTraf;
				}
				set	
				{
					l1DyHttpsTraf = value;
				}
			}

			public float? L1DyHttpsInnerTraf
			{
				get
				{
					return l1DyHttpsInnerTraf;
				}
				set	
				{
					l1DyHttpsInnerTraf = value;
				}
			}

			public float? L1DyHttpsOutTraf
			{
				get
				{
					return l1DyHttpsOutTraf;
				}
				set	
				{
					l1DyHttpsOutTraf = value;
				}
			}

			public float? L1StHttpsTraf
			{
				get
				{
					return l1StHttpsTraf;
				}
				set	
				{
					l1StHttpsTraf = value;
				}
			}

			public float? L1StHttpsInnerTraf
			{
				get
				{
					return l1StHttpsInnerTraf;
				}
				set	
				{
					l1StHttpsInnerTraf = value;
				}
			}

			public float? L1StHttpsOutTraf
			{
				get
				{
					return l1StHttpsOutTraf;
				}
				set	
				{
					l1StHttpsOutTraf = value;
				}
			}

			public float? L1DyHttpsQps
			{
				get
				{
					return l1DyHttpsQps;
				}
				set	
				{
					l1DyHttpsQps = value;
				}
			}

			public float? L1DyHttpsInnerQps
			{
				get
				{
					return l1DyHttpsInnerQps;
				}
				set	
				{
					l1DyHttpsInnerQps = value;
				}
			}

			public float? L1DyHttpsOutQps
			{
				get
				{
					return l1DyHttpsOutQps;
				}
				set	
				{
					l1DyHttpsOutQps = value;
				}
			}

			public float? L1StHttpsQps
			{
				get
				{
					return l1StHttpsQps;
				}
				set	
				{
					l1StHttpsQps = value;
				}
			}

			public float? L1StHttpsInnerQps
			{
				get
				{
					return l1StHttpsInnerQps;
				}
				set	
				{
					l1StHttpsInnerQps = value;
				}
			}

			public float? L1StHttpsOutQps
			{
				get
				{
					return l1StHttpsOutQps;
				}
				set	
				{
					l1StHttpsOutQps = value;
				}
			}

			public float? L1DyHttpsAcc
			{
				get
				{
					return l1DyHttpsAcc;
				}
				set	
				{
					l1DyHttpsAcc = value;
				}
			}

			public float? L1DyHttpsInnerAcc
			{
				get
				{
					return l1DyHttpsInnerAcc;
				}
				set	
				{
					l1DyHttpsInnerAcc = value;
				}
			}

			public float? L1DyHttpsOutAcc
			{
				get
				{
					return l1DyHttpsOutAcc;
				}
				set	
				{
					l1DyHttpsOutAcc = value;
				}
			}

			public float? L1StHttpsAcc
			{
				get
				{
					return l1StHttpsAcc;
				}
				set	
				{
					l1StHttpsAcc = value;
				}
			}

			public float? L1StHttpsInnerAcc
			{
				get
				{
					return l1StHttpsInnerAcc;
				}
				set	
				{
					l1StHttpsInnerAcc = value;
				}
			}

			public float? L1StHttpsOutAcc
			{
				get
				{
					return l1StHttpsOutAcc;
				}
				set	
				{
					l1StHttpsOutAcc = value;
				}
			}
		}
	}
}