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
	public class GetProductQuotaResponse : AcsResponse
	{

		private string requestId;

		private GetProductQuota_Quota quota;

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

		public GetProductQuota_Quota Quota
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

		public class GetProductQuota_Quota
		{

			private string quotaDescription;

			private bool? consumable;

			private string unadjustableDetail;

			private string effectiveTime;

			private string productCode;

			private float? totalUsage;

			private string quotaType;

			private string dimensions;

			private bool? globalQuota;

			private string quotaUnit;

			private bool? adjustable;

			private string quotaActionCode;

			private string quotaName;

			private string quotaArn;

			private string applyReasonTips;

			private float? totalQuota;

			private string quotaCategory;

			private string expireTime;

			private string applicableType;

			private List<GetProductQuota_QuotaItemsItem> quotaItems;

			private List<string> supportedRange;

			private List<string> applicableRange;

			private GetProductQuota_UsageMetric usageMetric;

			private GetProductQuota_Period period;

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

			public bool? GlobalQuota
			{
				get
				{
					return globalQuota;
				}
				set	
				{
					globalQuota = value;
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

			public List<GetProductQuota_QuotaItemsItem> QuotaItems
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

			public GetProductQuota_UsageMetric UsageMetric
			{
				get
				{
					return usageMetric;
				}
				set	
				{
					usageMetric = value;
				}
			}

			public GetProductQuota_Period Period
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

			public class GetProductQuota_QuotaItemsItem
			{

				private string type;

				private string usage;

				private string quota;

				private string quotaUnit;

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
			}

			public class GetProductQuota_UsageMetric
			{

				private string metricName;

				private string metricDimensions;

				private string metricNamespace;

				public string MetricName
				{
					get
					{
						return metricName;
					}
					set	
					{
						metricName = value;
					}
				}

				public string MetricDimensions
				{
					get
					{
						return metricDimensions;
					}
					set	
					{
						metricDimensions = value;
					}
				}

				public string MetricNamespace
				{
					get
					{
						return metricNamespace;
					}
					set	
					{
						metricNamespace = value;
					}
				}
			}

			public class GetProductQuota_Period
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
