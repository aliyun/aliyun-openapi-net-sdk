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
	public class GetQuotaAlarmResponse : AcsResponse
	{

		private string requestId;

		private GetQuotaAlarm_QuotaAlarm quotaAlarm;

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

		public GetQuotaAlarm_QuotaAlarm QuotaAlarm
		{
			get
			{
				return quotaAlarm;
			}
			set	
			{
				quotaAlarm = value;
			}
		}

		public class GetQuotaAlarm_QuotaAlarm
		{

			private string alarmId;

			private string quotaActionCode;

			private float? quotaValue;

			private float? thresholdPercent;

			private string alarmName;

			private string productCode;

			private string notifyTarget;

			private string createTime;

			private string quotaDimension;

			private float? quotaUsage;

			private float? threshold;

			private string thresholdType;

			private List<string> notifyChannels;

			public string AlarmId
			{
				get
				{
					return alarmId;
				}
				set	
				{
					alarmId = value;
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

			public float? QuotaValue
			{
				get
				{
					return quotaValue;
				}
				set	
				{
					quotaValue = value;
				}
			}

			public float? ThresholdPercent
			{
				get
				{
					return thresholdPercent;
				}
				set	
				{
					thresholdPercent = value;
				}
			}

			public string AlarmName
			{
				get
				{
					return alarmName;
				}
				set	
				{
					alarmName = value;
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

			public string NotifyTarget
			{
				get
				{
					return notifyTarget;
				}
				set	
				{
					notifyTarget = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
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

			public float? QuotaUsage
			{
				get
				{
					return quotaUsage;
				}
				set	
				{
					quotaUsage = value;
				}
			}

			public float? Threshold
			{
				get
				{
					return threshold;
				}
				set	
				{
					threshold = value;
				}
			}

			public string ThresholdType
			{
				get
				{
					return thresholdType;
				}
				set	
				{
					thresholdType = value;
				}
			}

			public List<string> NotifyChannels
			{
				get
				{
					return notifyChannels;
				}
				set	
				{
					notifyChannels = value;
				}
			}
		}
	}
}
