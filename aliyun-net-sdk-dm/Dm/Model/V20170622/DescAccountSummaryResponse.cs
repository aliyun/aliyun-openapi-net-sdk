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

namespace Aliyun.Acs.Dm.Model.V20170622
{
	public class DescAccountSummaryResponse : AcsResponse
	{

		private string requestId;

		private int? userStatus;

		private int? quotaLevel;

		private int? maxQuotaLevel;

		private int? dailyQuota;

		private int? monthQuota;

		private int? tags;

		private int? domains;

		private int? mailAddresses;

		private int? receivers;

		private int? templates;

		private int? dayuStatus;

		private int? smsTemplates;

		private int? smsRecord;

		private int? smsSign;

		private int? enableTimes;

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

		public int? UserStatus
		{
			get
			{
				return userStatus;
			}
			set	
			{
				userStatus = value;
			}
		}

		public int? QuotaLevel
		{
			get
			{
				return quotaLevel;
			}
			set	
			{
				quotaLevel = value;
			}
		}

		public int? MaxQuotaLevel
		{
			get
			{
				return maxQuotaLevel;
			}
			set	
			{
				maxQuotaLevel = value;
			}
		}

		public int? DailyQuota
		{
			get
			{
				return dailyQuota;
			}
			set	
			{
				dailyQuota = value;
			}
		}

		public int? MonthQuota
		{
			get
			{
				return monthQuota;
			}
			set	
			{
				monthQuota = value;
			}
		}

		public int? Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public int? Domains
		{
			get
			{
				return domains;
			}
			set	
			{
				domains = value;
			}
		}

		public int? MailAddresses
		{
			get
			{
				return mailAddresses;
			}
			set	
			{
				mailAddresses = value;
			}
		}

		public int? Receivers
		{
			get
			{
				return receivers;
			}
			set	
			{
				receivers = value;
			}
		}

		public int? Templates
		{
			get
			{
				return templates;
			}
			set	
			{
				templates = value;
			}
		}

		public int? DayuStatus
		{
			get
			{
				return dayuStatus;
			}
			set	
			{
				dayuStatus = value;
			}
		}

		public int? SmsTemplates
		{
			get
			{
				return smsTemplates;
			}
			set	
			{
				smsTemplates = value;
			}
		}

		public int? SmsRecord
		{
			get
			{
				return smsRecord;
			}
			set	
			{
				smsRecord = value;
			}
		}

		public int? SmsSign
		{
			get
			{
				return smsSign;
			}
			set	
			{
				smsSign = value;
			}
		}

		public int? EnableTimes
		{
			get
			{
				return enableTimes;
			}
			set	
			{
				enableTimes = value;
			}
		}
	}
}
