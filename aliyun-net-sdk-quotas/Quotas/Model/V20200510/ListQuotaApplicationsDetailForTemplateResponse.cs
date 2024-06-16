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
	public class ListQuotaApplicationsDetailForTemplateResponse : AcsResponse
	{

		private string nextToken;

		private int? totalCount;

		private int? maxResults;

		private string requestId;

		private List<ListQuotaApplicationsDetailForTemplate_QuotaBatchApplicationDetailVos> quotaApplications;

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

		public List<ListQuotaApplicationsDetailForTemplate_QuotaBatchApplicationDetailVos> QuotaApplications
		{
			get
			{
				return quotaApplications;
			}
			set	
			{
				quotaApplications = value;
			}
		}

		public class ListQuotaApplicationsDetailForTemplate_QuotaBatchApplicationDetailVos
		{

			private string batchQuotaApplicationId;

			private string productCode;

			private string quotaActionCode;

			private string quotaName;

			private string quotaDescription;

			private string quotaUnit;

			private string quotaArn;

			private string quotaDimension;

			private string applicationId;

			private double? desireValue;

			private string reason;

			private string status;

			private double? approveValue;

			private string effectiveTime;

			private string expireTime;

			private string applyTime;

			private string auditReason;

			private int? noticeType;

			private string aliyunUid;

			private string quotaCategory;

			private string envLanguage;

			private ListQuotaApplicationsDetailForTemplate_Period period;

			public string BatchQuotaApplicationId
			{
				get
				{
					return batchQuotaApplicationId;
				}
				set	
				{
					batchQuotaApplicationId = value;
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

			public string QuotaDimension
			{
				get
				{
					return quotaDimension;
				}
				set	
				{
					quotaDimension = value;
				}
			}

			public string ApplicationId
			{
				get
				{
					return applicationId;
				}
				set	
				{
					applicationId = value;
				}
			}

			public double? DesireValue
			{
				get
				{
					return desireValue;
				}
				set	
				{
					desireValue = value;
				}
			}

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}

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

			public double? ApproveValue
			{
				get
				{
					return approveValue;
				}
				set	
				{
					approveValue = value;
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

			public string ApplyTime
			{
				get
				{
					return applyTime;
				}
				set	
				{
					applyTime = value;
				}
			}

			public string AuditReason
			{
				get
				{
					return auditReason;
				}
				set	
				{
					auditReason = value;
				}
			}

			public int? NoticeType
			{
				get
				{
					return noticeType;
				}
				set	
				{
					noticeType = value;
				}
			}

			public string AliyunUid
			{
				get
				{
					return aliyunUid;
				}
				set	
				{
					aliyunUid = value;
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

			public string EnvLanguage
			{
				get
				{
					return envLanguage;
				}
				set	
				{
					envLanguage = value;
				}
			}

			public ListQuotaApplicationsDetailForTemplate_Period Period
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

			public class ListQuotaApplicationsDetailForTemplate_Period
			{

				private string periodUnit;

				private int? periodValue;

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
			}
		}
	}
}
