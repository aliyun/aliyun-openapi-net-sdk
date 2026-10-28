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
	public class ListQuotaUtilizationReportResponse : AcsResponse
	{

		private string status;

		private int? totalCount;

		private string message;

		private string nextToken;

		private string requestId;

		private string generatedAt;

		private string errorMsg;

		private string errorCode;

		private bool? success;

		private List<ListQuotaUtilizationReport_QuotasItem> quotas;

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public string GeneratedAt
		{
			get
			{
				return generatedAt;
			}
			set	
			{
				generatedAt = value;
			}
		}

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<ListQuotaUtilizationReport_QuotasItem> Quotas
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

		public class ListQuotaUtilizationReport_QuotasItem
		{

			private string quotaDescription;

			private bool? consumable;

			private string unadjustableDetail;

			private string productCode;

			private double? totalUsage;

			private string dimensions;

			private string utilizationStatus;

			private bool? adjustable;

			private string quotaActionCode;

			private string quotaName;

			private double? utilization;

			private string quotaArn;

			private double? totalQuota;

			private string quotaCategory;

			private ListQuotaUtilizationReport_UsageMetric usageMetric;

			private ListQuotaUtilizationReport_FlowControlAlgo flowControlAlgo;

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

			public double? TotalUsage
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

			public string UtilizationStatus
			{
				get
				{
					return utilizationStatus;
				}
				set	
				{
					utilizationStatus = value;
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

			public double? Utilization
			{
				get
				{
					return utilization;
				}
				set	
				{
					utilization = value;
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

			public double? TotalQuota
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

			public ListQuotaUtilizationReport_UsageMetric UsageMetric
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

			public ListQuotaUtilizationReport_FlowControlAlgo FlowControlAlgo
			{
				get
				{
					return flowControlAlgo;
				}
				set	
				{
					flowControlAlgo = value;
				}
			}

			public class ListQuotaUtilizationReport_UsageMetric
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

			public class ListQuotaUtilizationReport_FlowControlAlgo
			{

				private double? totalQuota;

				private string algoType;

				private int? tokensPerRefill;

				private int? refillInterval;

				private ListQuotaUtilizationReport_Period period;

				public double? TotalQuota
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

				public string AlgoType
				{
					get
					{
						return algoType;
					}
					set	
					{
						algoType = value;
					}
				}

				public int? TokensPerRefill
				{
					get
					{
						return tokensPerRefill;
					}
					set	
					{
						tokensPerRefill = value;
					}
				}

				public int? RefillInterval
				{
					get
					{
						return refillInterval;
					}
					set	
					{
						refillInterval = value;
					}
				}

				public ListQuotaUtilizationReport_Period Period
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

				public class ListQuotaUtilizationReport_Period
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
}
