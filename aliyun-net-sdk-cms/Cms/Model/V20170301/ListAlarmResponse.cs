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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20170301
{
	public class ListAlarmResponse : AcsResponse
	{

		private bool? success;

		private string code;

		private string message;

		private int? nextToken;

		private int? total;

		private string requestId;

		private List<ListAlarm_Alarm> alarmList;

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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

		public int? NextToken
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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
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

		public List<ListAlarm_Alarm> AlarmList
		{
			get
			{
				return alarmList;
			}
			set	
			{
				alarmList = value;
			}
		}

		public class ListAlarm_Alarm
		{

			private string id;

			private string name;

			private string _namespace;

			private string metricName;

			private string dimensions;

			private int? period;

			private string statistics;

			private string comparisonOperator;

			private string threshold;

			private int? evaluationCount;

			private int? startTime;

			private int? endTime;

			private int? silenceTime;

			private int? notifyType;

			private bool? enable;

			private string state;

			private string contactGroups;

			private string webhook;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string _Namespace
			{
				get
				{
					return _namespace;
				}
				set	
				{
					_namespace = value;
				}
			}

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

			public int? Period
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

			public string Statistics
			{
				get
				{
					return statistics;
				}
				set	
				{
					statistics = value;
				}
			}

			public string ComparisonOperator
			{
				get
				{
					return comparisonOperator;
				}
				set	
				{
					comparisonOperator = value;
				}
			}

			public string Threshold
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

			public int? EvaluationCount
			{
				get
				{
					return evaluationCount;
				}
				set	
				{
					evaluationCount = value;
				}
			}

			public int? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public int? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public int? SilenceTime
			{
				get
				{
					return silenceTime;
				}
				set	
				{
					silenceTime = value;
				}
			}

			public int? NotifyType
			{
				get
				{
					return notifyType;
				}
				set	
				{
					notifyType = value;
				}
			}

			public bool? Enable
			{
				get
				{
					return enable;
				}
				set	
				{
					enable = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string ContactGroups
			{
				get
				{
					return contactGroups;
				}
				set	
				{
					contactGroups = value;
				}
			}

			public string Webhook
			{
				get
				{
					return webhook;
				}
				set	
				{
					webhook = value;
				}
			}
		}
	}
}