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
	public class CreateQuotaApplicationResponse : AcsResponse
	{

		private string status;

		private string applyTime;

		private string quotaDescription;

		private string requestId;

		private string effectiveTime;

		private string productCode;

		private string quotaUnit;

		private string auditReason;

		private string dimension;

		private float? approveValue;

		private string reason;

		private string quotaActionCode;

		private string quotaName;

		private string quotaArn;

		private long? noticeType;

		private string expireTime;

		private string applicationId;

		private int? desireValue;

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

		public long? NoticeType
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

		public int? DesireValue
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
	}
}
