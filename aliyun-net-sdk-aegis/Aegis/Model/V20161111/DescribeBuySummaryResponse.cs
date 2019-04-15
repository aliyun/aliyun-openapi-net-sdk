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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeBuySummaryResponse : AcsResponse
	{

		private string requestId;

		private DescribeBuySummary_BuySummary buySummary;

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

		public DescribeBuySummary_BuySummary BuySummary
		{
			get
			{
				return buySummary;
			}
			set	
			{
				buySummary = value;
			}
		}

		public class DescribeBuySummary_BuySummary
		{

			private long? expireDateTimestamp;

			private long? purchaseDate;

			private string buyVersion;

			private int? safePointSurplusDays;

			private int? safePointdailyCost;

			private int? capacity;

			private int? totalMachineNum;

			private bool? canApplyTrial;

			private string instanceId;

			private int? useCapacity;

			private bool? canAccessHidden;

			private bool? buyStatus;

			private string buyType;

			private long? expireDate;

			private int? safePointCapacity;

			private bool? needFeedBack;

			private string safePointBuyVersion;

			private string originalVersion;

			private string originalBuyType;

			private long? safePointExpireDate;

			private int? specialCount;

			public long? ExpireDateTimestamp
			{
				get
				{
					return expireDateTimestamp;
				}
				set	
				{
					expireDateTimestamp = value;
				}
			}

			public long? PurchaseDate
			{
				get
				{
					return purchaseDate;
				}
				set	
				{
					purchaseDate = value;
				}
			}

			public string BuyVersion
			{
				get
				{
					return buyVersion;
				}
				set	
				{
					buyVersion = value;
				}
			}

			public int? SafePointSurplusDays
			{
				get
				{
					return safePointSurplusDays;
				}
				set	
				{
					safePointSurplusDays = value;
				}
			}

			public int? SafePointdailyCost
			{
				get
				{
					return safePointdailyCost;
				}
				set	
				{
					safePointdailyCost = value;
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

			public int? TotalMachineNum
			{
				get
				{
					return totalMachineNum;
				}
				set	
				{
					totalMachineNum = value;
				}
			}

			public bool? CanApplyTrial
			{
				get
				{
					return canApplyTrial;
				}
				set	
				{
					canApplyTrial = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public int? UseCapacity
			{
				get
				{
					return useCapacity;
				}
				set	
				{
					useCapacity = value;
				}
			}

			public bool? CanAccessHidden
			{
				get
				{
					return canAccessHidden;
				}
				set	
				{
					canAccessHidden = value;
				}
			}

			public bool? BuyStatus
			{
				get
				{
					return buyStatus;
				}
				set	
				{
					buyStatus = value;
				}
			}

			public string BuyType
			{
				get
				{
					return buyType;
				}
				set	
				{
					buyType = value;
				}
			}

			public long? ExpireDate
			{
				get
				{
					return expireDate;
				}
				set	
				{
					expireDate = value;
				}
			}

			public int? SafePointCapacity
			{
				get
				{
					return safePointCapacity;
				}
				set	
				{
					safePointCapacity = value;
				}
			}

			public bool? NeedFeedBack
			{
				get
				{
					return needFeedBack;
				}
				set	
				{
					needFeedBack = value;
				}
			}

			public string SafePointBuyVersion
			{
				get
				{
					return safePointBuyVersion;
				}
				set	
				{
					safePointBuyVersion = value;
				}
			}

			public string OriginalVersion
			{
				get
				{
					return originalVersion;
				}
				set	
				{
					originalVersion = value;
				}
			}

			public string OriginalBuyType
			{
				get
				{
					return originalBuyType;
				}
				set	
				{
					originalBuyType = value;
				}
			}

			public long? SafePointExpireDate
			{
				get
				{
					return safePointExpireDate;
				}
				set	
				{
					safePointExpireDate = value;
				}
			}

			public int? SpecialCount
			{
				get
				{
					return specialCount;
				}
				set	
				{
					specialCount = value;
				}
			}
		}
	}
}
