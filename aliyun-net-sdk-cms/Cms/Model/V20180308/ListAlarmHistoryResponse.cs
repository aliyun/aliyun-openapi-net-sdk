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

namespace Aliyun.Acs.Cms.Model.V20180308
{
	public class ListAlarmHistoryResponse : AcsResponse
	{

		private bool? success;

		private string code;

		private string message;

		private string cursor;

		private string requestId;

		private List<ListAlarmHistory_AlarmHistory> alarmHistoryList;

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

		public string Cursor
		{
			get
			{
				return cursor;
			}
			set	
			{
				cursor = value;
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

		public List<ListAlarmHistory_AlarmHistory> AlarmHistoryList
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

		public class ListAlarmHistory_AlarmHistory
		{

			private string id;

			private string name;

			private string _namespace;

			private string metricName;

			private string dimension;

			private int? evaluationCount;

			private string _value;

			private long? alarmTime;

			private long? lastTime;

			private string state;

			private int? status;

			private string contactGroups;

			private string instanceName;

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

			public long? AlarmTime
			{
				get
				{
					return alarmTime;
				}
				set	
				{
					alarmTime = value;
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

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}
		}
	}
}
