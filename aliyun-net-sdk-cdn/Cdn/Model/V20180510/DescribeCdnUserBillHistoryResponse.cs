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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeCdnUserBillHistoryResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeCdnUserBillHistory_BillHistoryDataItem> billHistoryData;

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

		public List<DescribeCdnUserBillHistory_BillHistoryDataItem> BillHistoryData
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

		public class DescribeCdnUserBillHistory_BillHistoryDataItem
		{

			private string dimension;

			private string billType;

			private string billTime;

			private List<DescribeCdnUserBillHistory_BillingDataItem> billingData;

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

			public List<DescribeCdnUserBillHistory_BillingDataItem> BillingData
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

			public class DescribeCdnUserBillHistory_BillingDataItem
			{

				private float? flow;

				private float? bandwidth;

				private float? count;

				private string cdnRegion;

				private string chargeType;

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
			}
		}
	}
}
