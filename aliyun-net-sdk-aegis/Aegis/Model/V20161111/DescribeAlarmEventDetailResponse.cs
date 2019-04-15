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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeAlarmEventDetailResponse : AcsResponse
	{

		private string requestId;

		private DescribeAlarmEventDetail_Data data;

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

		public DescribeAlarmEventDetail_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeAlarmEventDetail_Data
		{

			private string internetIp;

			private string level;

			private string instanceName;

			private string alarmEventAliasName;

			private string type;

			private string uuid;

			private string solution;

			private long? startTime;

			private long? endTime;

			private string alarmEventDesc;

			private string intranetIp;

			private bool? canBeDealOnLine;

			private string alarmUniqueInfo;

			private string dataSource;

			private bool? canCancelFault;

			private bool? hasTraceInfo;

			private List<DescribeAlarmEventDetail_CauseDetail> causeDetails;

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
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

			public string AlarmEventAliasName
			{
				get
				{
					return alarmEventAliasName;
				}
				set	
				{
					alarmEventAliasName = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string Solution
			{
				get
				{
					return solution;
				}
				set	
				{
					solution = value;
				}
			}

			public long? StartTime
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

			public long? EndTime
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

			public string AlarmEventDesc
			{
				get
				{
					return alarmEventDesc;
				}
				set	
				{
					alarmEventDesc = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public bool? CanBeDealOnLine
			{
				get
				{
					return canBeDealOnLine;
				}
				set	
				{
					canBeDealOnLine = value;
				}
			}

			public string AlarmUniqueInfo
			{
				get
				{
					return alarmUniqueInfo;
				}
				set	
				{
					alarmUniqueInfo = value;
				}
			}

			public string DataSource
			{
				get
				{
					return dataSource;
				}
				set	
				{
					dataSource = value;
				}
			}

			public bool? CanCancelFault
			{
				get
				{
					return canCancelFault;
				}
				set	
				{
					canCancelFault = value;
				}
			}

			public bool? HasTraceInfo
			{
				get
				{
					return hasTraceInfo;
				}
				set	
				{
					hasTraceInfo = value;
				}
			}

			public List<DescribeAlarmEventDetail_CauseDetail> CauseDetails
			{
				get
				{
					return causeDetails;
				}
				set	
				{
					causeDetails = value;
				}
			}

			public class DescribeAlarmEventDetail_CauseDetail
			{

				private string key;

				private List<DescribeAlarmEventDetail_ValueItem> _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public List<DescribeAlarmEventDetail_ValueItem> _Value
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

				public class DescribeAlarmEventDetail_ValueItem
				{

					private string name;

					private string type;

					private string _value;

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

					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
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
				}
			}
		}
	}
}
