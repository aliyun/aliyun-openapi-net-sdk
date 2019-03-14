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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class QueryAlarmHistoryResponse : AcsResponse
	{

		private string requestId;

		private string total;

		private string cursor;

		private List<QueryAlarmHistory_EmrAlarmHistory> alarmHistoryList;

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

		public List<QueryAlarmHistory_EmrAlarmHistory> AlarmHistoryList
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

		public class QueryAlarmHistory_EmrAlarmHistory
		{

			private string clusterId;

			private string role;

			private string instanceId;

			private string name;

			private string metricName;

			private long? alarmTime;

			private long? lastTime;

			private string state;

			private int? status;

			private string contactGroups;

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
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
		}
	}
}
