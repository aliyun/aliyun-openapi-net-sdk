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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeDomainDetailDataByLayerResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDomainDetailDataByLayer_DataModule> data;

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

		public List<DescribeDomainDetailDataByLayer_DataModule> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeDomainDetailDataByLayer_DataModule
		{

			private string timeStamp;

			private string domainName;

			private float? bps;

			private float? qps;

			private long? traf;

			private long? acc;

			private long? ipv6Traf;

			private float? ipv6Bps;

			private long? ipv6Acc;

			private float? ipv6Qps;

			private string httpCode;

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

			public float? Qps
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

			public long? Traf
			{
				get
				{
					return traf;
				}
				set	
				{
					traf = value;
				}
			}

			public long? Acc
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

			public long? Ipv6Traf
			{
				get
				{
					return ipv6Traf;
				}
				set	
				{
					ipv6Traf = value;
				}
			}

			public float? Ipv6Bps
			{
				get
				{
					return ipv6Bps;
				}
				set	
				{
					ipv6Bps = value;
				}
			}

			public long? Ipv6Acc
			{
				get
				{
					return ipv6Acc;
				}
				set	
				{
					ipv6Acc = value;
				}
			}

			public float? Ipv6Qps
			{
				get
				{
					return ipv6Qps;
				}
				set	
				{
					ipv6Qps = value;
				}
			}

			public string HttpCode
			{
				get
				{
					return httpCode;
				}
				set	
				{
					httpCode = value;
				}
			}
		}
	}
}
