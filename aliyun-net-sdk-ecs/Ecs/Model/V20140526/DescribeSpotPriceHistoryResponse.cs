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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeSpotPriceHistoryResponse : AcsResponse
	{

		private string requestId;

		private string currency;

		private int? nextOffset;

		private List<DescribeSpotPriceHistory_SpotPriceType> spotPrices;

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

		public string Currency
		{
			get
			{
				return currency;
			}
			set	
			{
				currency = value;
			}
		}

		public int? NextOffset
		{
			get
			{
				return nextOffset;
			}
			set	
			{
				nextOffset = value;
			}
		}

		public List<DescribeSpotPriceHistory_SpotPriceType> SpotPrices
		{
			get
			{
				return spotPrices;
			}
			set	
			{
				spotPrices = value;
			}
		}

		public class DescribeSpotPriceHistory_SpotPriceType
		{

			private string ioOptimized;

			private string zoneId;

			private float? spotPrice;

			private string timestamp;

			private string networkType;

			private string instanceType;

			private float? originPrice;

			public string IoOptimized
			{
				get
				{
					return ioOptimized;
				}
				set	
				{
					ioOptimized = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public float? SpotPrice
			{
				get
				{
					return spotPrice;
				}
				set	
				{
					spotPrice = value;
				}
			}

			public string Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public float? OriginPrice
			{
				get
				{
					return originPrice;
				}
				set	
				{
					originPrice = value;
				}
			}
		}
	}
}
