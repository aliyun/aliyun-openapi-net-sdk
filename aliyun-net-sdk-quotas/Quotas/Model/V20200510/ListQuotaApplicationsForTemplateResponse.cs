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
	public class ListQuotaApplicationsForTemplateResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? totalCount;

		private int? maxResults;

		private List<ListQuotaApplicationsForTemplate_QuotaBatchApplicationsItem> quotaBatchApplications;

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

		public List<ListQuotaApplicationsForTemplate_QuotaBatchApplicationsItem> QuotaBatchApplications
		{
			get
			{
				return quotaBatchApplications;
			}
			set	
			{
				quotaBatchApplications = value;
			}
		}

		public class ListQuotaApplicationsForTemplate_QuotaBatchApplicationsItem
		{

			private string productCode;

			private string quotaActionCode;

			private string batchQuotaApplicationId;

			private string effectiveTime;

			private string expireTime;

			private string applyTime;

			private double? desireValue;

			private string quotaCategory;

			private string dimensions;

			private string reason;

			private List<ListQuotaApplicationsForTemplate_AuditStatusVo> auditStatusVos;

			private List<string> aliyunUids;

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

			public List<ListQuotaApplicationsForTemplate_AuditStatusVo> AuditStatusVos
			{
				get
				{
					return auditStatusVos;
				}
				set	
				{
					auditStatusVos = value;
				}
			}

			public List<string> AliyunUids
			{
				get
				{
					return aliyunUids;
				}
				set	
				{
					aliyunUids = value;
				}
			}

			public class ListQuotaApplicationsForTemplate_AuditStatusVo
			{

				private string status;

				private int? count;

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

				public int? Count
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
