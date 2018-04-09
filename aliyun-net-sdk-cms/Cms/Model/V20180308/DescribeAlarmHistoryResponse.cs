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

namespace Aliyun.Acs.Cms.Model.V20180308
{
	public class DescribeAlarmHistoryResponse : AcsResponse
	{

		private bool? success;

		private string code;

		private string message;

		private string total;

		private string requestId;

		private List<DescribeAlarmHistory_AlarmHistory> alarmHistoryList;

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

		public string Total
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

		public List<DescribeAlarmHistory_AlarmHistory> AlarmHistoryList
		{
			get
			{
				return alarmHistoryList;
			}
			set	
			{
				alarmHistoryList = value;
			}
		}

		public class DescribeAlarmHistory_AlarmHistory
		{

			private string id;

			private string alertName;

			private string groupId;

			private string _namespace;

			private string metricName;

			private string dimensions;

			private string expression;

			private int? evaluationCount;

			private string _value;

			private long? alertTime;

			private long? lastTime;

			private string level;

			private string preLevel;

			private string ruleName;

			private string state;

			private int? status;

			private string userId;

			private string webhooks;

			private List<string> contactGroups;

			private List<string> contacts;

			private List<string> contactALIIMs;

			private List<string> contactSmses;

			private List<string> contactMails;

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

			public string AlertName
			{
				get
				{
					return alertName;
				}
				set	
				{
					alertName = value;
				}
			}

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
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

			public string Expression
			{
				get
				{
					return expression;
				}
				set	
				{
					expression = value;
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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}

			public long? AlertTime
			{
				get
				{
					return alertTime;
				}
				set	
				{
					alertTime = value;
				}
			}

			public long? LastTime
			{
				get
				{
					return lastTime;
				}
				set	
				{
					lastTime = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public string PreLevel
			{
				get
				{
					return preLevel;
				}
				set	
				{
					preLevel = value;
				}
			}

			public string RuleName
			{
				get
				{
					return ruleName;
				}
				set	
				{
					ruleName = value;
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

			public int? Status
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

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string Webhooks
			{
				get
				{
					return webhooks;
				}
				set	
				{
					webhooks = value;
				}
			}

			public List<string> ContactGroups
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

			public List<string> Contacts
			{
				get
				{
					return contacts;
				}
				set	
				{
					contacts = value;
				}
			}

			public List<string> ContactALIIMs
			{
				get
				{
					return contactALIIMs;
				}
				set	
				{
					contactALIIMs = value;
				}
			}

			public List<string> ContactSmses
			{
				get
				{
					return contactSmses;
				}
				set	
				{
					contactSmses = value;
				}
			}

			public List<string> ContactMails
			{
				get
				{
					return contactMails;
				}
				set	
				{
					contactMails = value;
				}
			}
		}
	}
}