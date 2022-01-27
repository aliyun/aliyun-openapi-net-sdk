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
	public class ListAlarmHistoriesResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private int? totalCount;

		private List<ListAlarmHistories_AlarmHistory> alarmHistories;

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

		public List<ListAlarmHistories_AlarmHistory> AlarmHistories
		{
			get
			{
				return alarmHistories;
			}
			set	
			{
				alarmHistories = value;
			}
		}

		public class ListAlarmHistories_AlarmHistory
		{

			private string alarmName;

			private float? quotaUsage;

			private string productCode;

			private string createTime;

			private string notifyTarget;

			private float? threshold;

			private float? thresholdPercent;

			private string quotaActionCode;

			private List<string> notifyChannels;

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
