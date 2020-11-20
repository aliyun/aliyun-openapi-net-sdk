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
	public class DescribeDcdnUserBillHistoryResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDcdnUserBillHistory_BillHistoryDataItem> billHistoryData;

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

		public List<DescribeDcdnUserBillHistory_BillHistoryDataItem> BillHistoryData
		{
			get
			{
				return billHistoryData;
			}
			set	
			{
				billHistoryData = value;
			}
		}

		public class DescribeDcdnUserBillHistory_BillHistoryDataItem
		{

			private string dimension;

			private string billType;

			private string billTime;

			private List<DescribeDcdnUserBillHistory_BillingDataItem> billingData;

			public string Dimension
			{
				get
				{
					return dimension;
				}
				set	
				{
					dimension = value;
				}
			}

			public string BillType
			{
				get
				{
					return billType;
				}
				set	
				{
					billType = value;
				}
			}

			public string BillTime
			{
				get
				{
					return billTime;
				}
				set	
				{
					billTime = value;
				}
			}

			public List<DescribeDcdnUserBillHistory_BillingDataItem> BillingData
			{
				get
				{
					return billingData;
				}
				set	
				{
					billingData = value;
				}
			}

			public class DescribeDcdnUserBillHistory_BillingDataItem
			{

				private string chargeType;

				private string cdnRegion;

				private float? bandwidth;

				private float? flow;

				private float? count;

				public string ChargeType
				{
					get
					{
						return chargeType;
					}
					set	
					{
						chargeType = value;
					}
				}

				public string CdnRegion
				{
					get
					{
						return cdnRegion;
					}
					set	
					{
						cdnRegion = value;
					}
				}

				public float? Bandwidth
				{
					get
					{
						return bandwidth;
					}
					set	
					{
						bandwidth = value;
					}
				}

				public float? Flow
				{
					get
					{
						return flow;
					}
					set	
					{
						flow = value;
					}
				}

				public float? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}
			}
		}
	}
}
