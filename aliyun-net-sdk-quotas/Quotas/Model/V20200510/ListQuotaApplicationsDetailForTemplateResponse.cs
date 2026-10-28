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

		private int? totalCount;

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListQuotaApplicationsDetailForTemplate_QuotaBatchApplicationDetailVos> quotaApplications;

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

			private string status;

			private string applyTime;

			private string quotaDescription;

			private string batchQuotaApplicationId;

			private string effectiveTime;

			private string productCode;

			private string auditReason;

			private string quotaUnit;

			private double? approveValue;

			private string reason;

			private string envLanguage;

			private string quotaActionCode;

			private string quotaName;

			private string quotaArn;

			private string aliyunUid;

			private string quotaCategory;

			private int? noticeType;

			private string quotaDimension;

			private string applicationId;

			private double? desireValue;

			private string expireTime;

			private ListQuotaApplicationsDetailForTemplate_Period period;

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
