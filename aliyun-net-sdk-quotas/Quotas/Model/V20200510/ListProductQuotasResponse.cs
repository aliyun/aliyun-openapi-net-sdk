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

namespace Aliyun.Acs.quotas.Model.V20200510
{
	public class ListProductQuotasResponse : AcsResponse
	{

		private int? totalCount;

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListProductQuotas_QuotasItem> quotas;

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public List<ListProductQuotas_QuotasItem> Quotas
		{
			get
			{
				return quotas;
			}
			set	
			{
				quotas = value;
			}
		}

		public class ListProductQuotas_QuotasItem
		{

			private string quotaUnit;

			private string quotaActionCode;

			private float? totalUsage;

			private string quotaType;

			private string quotaDescription;

			private string quotaArn;

			private string applicableType;

			private string dimensions;

			private bool? adjustable;

			private string quotaName;

			private string unadjustableDetail;

			private bool? consumable;

			private float? totalQuota;

			private string productCode;

			private string effectiveTime;

			private string expireTime;

			private string quotaCategory;

			private string applyReasonTips;

			private List<ListProductQuotas_QuotaItemsItem> quotaItems;

			private List<string> applicableRange;

			private List<string> supportedRange;

			private ListProductQuotas_Period period;

			public string QuotaUnit
			{
				get
				{
					return quotaUnit;
				}
				set	
				{
					quotaUnit = value;
				}
			}

			public string QuotaActionCode
			{
				get
				{
					return quotaActionCode;
				}
				set	
				{
					quotaActionCode = value;
				}
			}

			public float? TotalUsage
			{
				get
				{
					return totalUsage;
				}
				set	
				{
					totalUsage = value;
				}
			}

			public string QuotaType
			{
				get
				{
					return quotaType;
				}
				set	
				{
					quotaType = value;
				}
			}

			public string QuotaDescription
			{
				get
				{
					return quotaDescription;
				}
				set	
				{
					quotaDescription = value;
				}
			}

			public string QuotaArn
			{
				get
				{
					return quotaArn;
				}
				set	
				{
					quotaArn = value;
				}
			}

			public string ApplicableType
			{
				get
				{
					return applicableType;
				}
				set	
				{
					applicableType = value;
				}
			}

			public string Dimensions
			{
				get
				{
					return dimensions;
				}
				set	
				{
					dimensions = value;
				}
			}

			public bool? Adjustable
			{
				get
				{
					return adjustable;
				}
				set	
				{
					adjustable = value;
				}
			}

			public string QuotaName
			{
				get
				{
					return quotaName;
				}
				set	
				{
					quotaName = value;
				}
			}

			public string UnadjustableDetail
			{
				get
				{
					return unadjustableDetail;
				}
				set	
				{
					unadjustableDetail = value;
				}
			}

			public bool? Consumable
			{
				get
				{
					return consumable;
				}
				set	
				{
					consumable = value;
				}
			}

			public float? TotalQuota
			{
				get
				{
					return totalQuota;
				}
				set	
				{
					totalQuota = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string EffectiveTime
			{
				get
				{
					return effectiveTime;
				}
				set	
				{
					effectiveTime = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public string QuotaCategory
			{
				get
				{
					return quotaCategory;
				}
				set	
				{
					quotaCategory = value;
				}
			}

			public string ApplyReasonTips
			{
				get
				{
					return applyReasonTips;
				}
				set	
				{
					applyReasonTips = value;
				}
			}

			public List<ListProductQuotas_QuotaItemsItem> QuotaItems
			{
				get
				{
					return quotaItems;
				}
				set	
				{
					quotaItems = value;
				}
			}

			public List<string> ApplicableRange
			{
				get
				{
					return applicableRange;
				}
				set	
				{
					applicableRange = value;
				}
			}

			public List<string> SupportedRange
			{
				get
				{
					return supportedRange;
				}
				set	
				{
					supportedRange = value;
				}
			}

			public ListProductQuotas_Period Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public class ListProductQuotas_QuotaItemsItem
			{

				private string type;

				private string quota;

				private string quotaUnit;

				private string usage;

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string Quota
				{
					get
					{
						return quota;
					}
					set	
					{
						quota = value;
					}
				}

				public string QuotaUnit
				{
					get
					{
						return quotaUnit;
					}
					set	
					{
						quotaUnit = value;
					}
				}

				public string Usage
				{
					get
					{
						return usage;
					}
					set	
					{
						usage = value;
					}
				}
			}

			public class ListProductQuotas_Period
			{

				private int? periodValue;

				private string periodUnit;

				public int? PeriodValue
				{
					get
					{
						return periodValue;
					}
					set	
					{
						periodValue = value;
					}
				}

				public string PeriodUnit
				{
					get
					{
						return periodUnit;
					}
					set	
					{
						periodUnit = value;
					}
				}
			}
		}
	}
}
