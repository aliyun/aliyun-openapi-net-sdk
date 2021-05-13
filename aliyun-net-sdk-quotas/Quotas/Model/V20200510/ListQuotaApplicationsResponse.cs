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

namespace Aliyun.Acs.quotas.Model.V20200510
{
	public class ListQuotaApplicationsResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private List<ListQuotaApplications_QuotaApplicationsItem> quotaApplications;

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

		public List<ListQuotaApplications_QuotaApplicationsItem> QuotaApplications
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

		public class ListQuotaApplications_QuotaApplicationsItem
		{

			private string status;

			private string applyTime;

			private string comment;

			private string quotaDescription;

			private string productCode;

			private string effectiveTime;

			private string auditReason;

			private string quotaUnit;

			private string dimension;

			private float? approveValue;

			private string reason;

			private string quotaActionCode;

			private string quotaName;

			private string quotaArn;

			private int? noticeType;

			private string applicationId;

			private float? desireValue;

			private string expireTime;

			private ListQuotaApplications_Period period;

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

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
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

			public float? ApproveValue
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

			public float? DesireValue
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

			public ListQuotaApplications_Period Period
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

			public class ListQuotaApplications_Period
			{

				private long? periodValue;

				private string periodUnit;

				public long? PeriodValue
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
