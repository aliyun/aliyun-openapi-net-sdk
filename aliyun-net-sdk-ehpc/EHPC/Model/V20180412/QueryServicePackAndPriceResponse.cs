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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class QueryServicePackAndPriceResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private float? tradePrice;

		private float? originalPrice;

		private float? discountPrice;

		private string currency;

		private int? originalAmount;

		private int? chargeAmount;

		private List<QueryServicePackAndPrice_ServicePackInfo> servicePack;

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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
			}
		}

		public float? TradePrice
		{
			get
			{
				return tradePrice;
			}
			set	
			{
				tradePrice = value;
			}
		}

		public float? OriginalPrice
		{
			get
			{
				return originalPrice;
			}
			set	
			{
				originalPrice = value;
			}
		}

		public float? DiscountPrice
		{
			get
			{
				return discountPrice;
			}
			set	
			{
				discountPrice = value;
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

		public int? OriginalAmount
		{
			get
			{
				return originalAmount;
			}
			set	
			{
				originalAmount = value;
			}
		}

		public int? ChargeAmount
		{
			get
			{
				return chargeAmount;
			}
			set	
			{
				chargeAmount = value;
			}
		}

		public List<QueryServicePackAndPrice_ServicePackInfo> ServicePack
		{
			get
			{
				return servicePack;
			}
			set	
			{
				servicePack = value;
			}
		}

		public class QueryServicePackAndPrice_ServicePackInfo
		{

			private string instanceName;

			private int? capacity;

			private int? startTime;

			private int? endTime;

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public int? Capacity
			{
				get
				{
					return capacity;
				}
				set	
				{
					capacity = value;
				}
			}

			public int? StartTime
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

			public int? EndTime
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
		}
	}
}
