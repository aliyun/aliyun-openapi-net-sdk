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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeHALogsResponse : AcsResponse
	{

		private int? totalRecords;

		private int? itemsNumbers;

		private int? pageNumber;

		private string dBInstanceName;

		private string dBInstanceType;

		private int? haStatus;

		private string requestId;

		private int? pageSize;

		private List<DescribeHALogs_HaSwitchLogItem> haLogItems;

		private List<DescribeHALogs_SwitchListItem> switchListItems;

		private List<DescribeHALogs_SwitchLogItem3> switchLogItems;

		public int? TotalRecords
		{
			get
			{
				return totalRecords;
			}
			set	
			{
				totalRecords = value;
			}
		}

		public int? ItemsNumbers
		{
			get
			{
				return itemsNumbers;
			}
			set	
			{
				itemsNumbers = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
			}
		}

		public string DBInstanceType
		{
			get
			{
				return dBInstanceType;
			}
			set	
			{
				dBInstanceType = value;
			}
		}

		public int? HaStatus
		{
			get
			{
				return haStatus;
			}
			set	
			{
				haStatus = value;
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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeHALogs_HaSwitchLogItem> HaLogItems
		{
			get
			{
				return haLogItems;
			}
			set	
			{
				haLogItems = value;
			}
		}

		public List<DescribeHALogs_SwitchListItem> SwitchListItems
		{
			get
			{
				return switchListItems;
			}
			set	
			{
				switchListItems = value;
			}
		}

		public List<DescribeHALogs_SwitchLogItem3> SwitchLogItems
		{
			get
			{
				return switchLogItems;
			}
			set	
			{
				switchLogItems = value;
			}
		}

		public class DescribeHALogs_HaSwitchLogItem
		{

			private string switchId;

			private string fromDBType;

			private string switchCauseCode;

			private string switchCauseDetail;

			private string switchStartTime;

			private string switchFinishTime;

			private long? totalSessions;

			private long? affectedSessions;

			private long? switchType;

			public string SwitchId
			{
				get
				{
					return switchId;
				}
				set	
				{
					switchId = value;
				}
			}

			public string FromDBType
			{
				get
				{
					return fromDBType;
				}
				set	
				{
					fromDBType = value;
				}
			}

			public string SwitchCauseCode
			{
				get
				{
					return switchCauseCode;
				}
				set	
				{
					switchCauseCode = value;
				}
			}

			public string SwitchCauseDetail
			{
				get
				{
					return switchCauseDetail;
				}
				set	
				{
					switchCauseDetail = value;
				}
			}

			public string SwitchStartTime
			{
				get
				{
					return switchStartTime;
				}
				set	
				{
					switchStartTime = value;
				}
			}

			public string SwitchFinishTime
			{
				get
				{
					return switchFinishTime;
				}
				set	
				{
					switchFinishTime = value;
				}
			}

			public long? TotalSessions
			{
				get
				{
					return totalSessions;
				}
				set	
				{
					totalSessions = value;
				}
			}

			public long? AffectedSessions
			{
				get
				{
					return affectedSessions;
				}
				set	
				{
					affectedSessions = value;
				}
			}

			public long? SwitchType
			{
				get
				{
					return switchType;
				}
				set	
				{
					switchType = value;
				}
			}
		}

		public class DescribeHALogs_SwitchListItem
		{

			private string simulateListId;

			private string simulateMode;

			private string simulateStatus;

			private string startTime;

			private string endTime;

			private string eventStartTime;

			private string eventFinishTime;

			private string simulateTaskId;

			private string preferredSimulateStartTime;

			private string plannedEscapeMode;

			private string plannedEscapeTime;

			private string faultInjectionType;

			private List<DescribeHALogs_SwitchLogItem> switchLogItems1;

			private List<DescribeHALogs_SwitchStepItem> switchStepItems;

			private List<string> dBNodeCrashList;

			public string SimulateListId
			{
				get
				{
					return simulateListId;
				}
				set	
				{
					simulateListId = value;
				}
			}

			public string SimulateMode
			{
				get
				{
					return simulateMode;
				}
				set	
				{
					simulateMode = value;
				}
			}

			public string SimulateStatus
			{
				get
				{
					return simulateStatus;
				}
				set	
				{
					simulateStatus = value;
				}
			}

			public string StartTime
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

			public string EndTime
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

			public string EventStartTime
			{
				get
				{
					return eventStartTime;
				}
				set	
				{
					eventStartTime = value;
				}
			}

			public string EventFinishTime
			{
				get
				{
					return eventFinishTime;
				}
				set	
				{
					eventFinishTime = value;
				}
			}

			public string SimulateTaskId
			{
				get
				{
					return simulateTaskId;
				}
				set	
				{
					simulateTaskId = value;
				}
			}

			public string PreferredSimulateStartTime
			{
				get
				{
					return preferredSimulateStartTime;
				}
				set	
				{
					preferredSimulateStartTime = value;
				}
			}

			public string PlannedEscapeMode
			{
				get
				{
					return plannedEscapeMode;
				}
				set	
				{
					plannedEscapeMode = value;
				}
			}

			public string PlannedEscapeTime
			{
				get
				{
					return plannedEscapeTime;
				}
				set	
				{
					plannedEscapeTime = value;
				}
			}

			public string FaultInjectionType
			{
				get
				{
					return faultInjectionType;
				}
				set	
				{
					faultInjectionType = value;
				}
			}

			public List<DescribeHALogs_SwitchLogItem> SwitchLogItems1
			{
				get
				{
					return switchLogItems1;
				}
				set	
				{
					switchLogItems1 = value;
				}
			}

			public List<DescribeHALogs_SwitchStepItem> SwitchStepItems
			{
				get
				{
					return switchStepItems;
				}
				set	
				{
					switchStepItems = value;
				}
			}

			public List<string> DBNodeCrashList
			{
				get
				{
					return dBNodeCrashList;
				}
				set	
				{
					dBNodeCrashList = value;
				}
			}

			public class DescribeHALogs_SwitchLogItem
			{

				private string simulateListId;

				private string simulateLogId;

				private string dBInstanceId;

				private string srcIpPort;

				private string srcDbType;

				private string dstIpPort;

				private string dstDbType;

				private string simulateStatus;

				private string eventStartTime;

				private string eventFinishTime;

				private List<DescribeHALogs_SwitchDetailItem> switchStepItems2;

				public string SimulateListId
				{
					get
					{
						return simulateListId;
					}
					set	
					{
						simulateListId = value;
					}
				}

				public string SimulateLogId
				{
					get
					{
						return simulateLogId;
					}
					set	
					{
						simulateLogId = value;
					}
				}

				public string DBInstanceId
				{
					get
					{
						return dBInstanceId;
					}
					set	
					{
						dBInstanceId = value;
					}
				}

				public string SrcIpPort
				{
					get
					{
						return srcIpPort;
					}
					set	
					{
						srcIpPort = value;
					}
				}

				public string SrcDbType
				{
					get
					{
						return srcDbType;
					}
					set	
					{
						srcDbType = value;
					}
				}

				public string DstIpPort
				{
					get
					{
						return dstIpPort;
					}
					set	
					{
						dstIpPort = value;
					}
				}

				public string DstDbType
				{
					get
					{
						return dstDbType;
					}
					set	
					{
						dstDbType = value;
					}
				}

				public string SimulateStatus
				{
					get
					{
						return simulateStatus;
					}
					set	
					{
						simulateStatus = value;
					}
				}

				public string EventStartTime
				{
					get
					{
						return eventStartTime;
					}
					set	
					{
						eventStartTime = value;
					}
				}

				public string EventFinishTime
				{
					get
					{
						return eventFinishTime;
					}
					set	
					{
						eventFinishTime = value;
					}
				}

				public List<DescribeHALogs_SwitchDetailItem> SwitchStepItems2
				{
					get
					{
						return switchStepItems2;
					}
					set	
					{
						switchStepItems2 = value;
					}
				}

				public class DescribeHALogs_SwitchDetailItem
				{

					private string stepName;

					private string startTime;

					private string simulatePhase;

					private string endTime;

					private string timeCost;

					private string isSuccess;

					public string StepName
					{
						get
						{
							return stepName;
						}
						set	
						{
							stepName = value;
						}
					}

					public string StartTime
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

					public string SimulatePhase
					{
						get
						{
							return simulatePhase;
						}
						set	
						{
							simulatePhase = value;
						}
					}

					public string EndTime
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

					public string TimeCost
					{
						get
						{
							return timeCost;
						}
						set	
						{
							timeCost = value;
						}
					}

					public string IsSuccess
					{
						get
						{
							return isSuccess;
						}
						set	
						{
							isSuccess = value;
						}
					}
				}
			}

			public class DescribeHALogs_SwitchStepItem
			{

				private string simulatePhase;

				private string stepName;

				private string startTime;

				private string endTime;

				private string timeCost;

				private string isSuccess;

				private string dBNodeId;

				public string SimulatePhase
				{
					get
					{
						return simulatePhase;
					}
					set	
					{
						simulatePhase = value;
					}
				}

				public string StepName
				{
					get
					{
						return stepName;
					}
					set	
					{
						stepName = value;
					}
				}

				public string StartTime
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

				public string EndTime
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

				public string TimeCost
				{
					get
					{
						return timeCost;
					}
					set	
					{
						timeCost = value;
					}
				}

				public string IsSuccess
				{
					get
					{
						return isSuccess;
					}
					set	
					{
						isSuccess = value;
					}
				}

				public string DBNodeId
				{
					get
					{
						return dBNodeId;
					}
					set	
					{
						dBNodeId = value;
					}
				}
			}
		}

		public class DescribeHALogs_SwitchLogItem3
		{

			private string simulateListId;

			private string simulatecode;

			private string dBInstanceId;

			private string srcIpPort;

			private string srcDbType;

			private string dstIpPort;

			private string dstDbType;

			private string simulateStatus;

			private string eventStartTime;

			private string eventFinishTime;

			private List<DescribeHALogs_SwitchStepItem5> switchStepItems4;

			public string SimulateListId
			{
				get
				{
					return simulateListId;
				}
				set	
				{
					simulateListId = value;
				}
			}

			public string Simulatecode
			{
				get
				{
					return simulatecode;
				}
				set	
				{
					simulatecode = value;
				}
			}

			public string DBInstanceId
			{
				get
				{
					return dBInstanceId;
				}
				set	
				{
					dBInstanceId = value;
				}
			}

			public string SrcIpPort
			{
				get
				{
					return srcIpPort;
				}
				set	
				{
					srcIpPort = value;
				}
			}

			public string SrcDbType
			{
				get
				{
					return srcDbType;
				}
				set	
				{
					srcDbType = value;
				}
			}

			public string DstIpPort
			{
				get
				{
					return dstIpPort;
				}
				set	
				{
					dstIpPort = value;
				}
			}

			public string DstDbType
			{
				get
				{
					return dstDbType;
				}
				set	
				{
					dstDbType = value;
				}
			}

			public string SimulateStatus
			{
				get
				{
					return simulateStatus;
				}
				set	
				{
					simulateStatus = value;
				}
			}

			public string EventStartTime
			{
				get
				{
					return eventStartTime;
				}
				set	
				{
					eventStartTime = value;
				}
			}

			public string EventFinishTime
			{
				get
				{
					return eventFinishTime;
				}
				set	
				{
					eventFinishTime = value;
				}
			}

			public List<DescribeHALogs_SwitchStepItem5> SwitchStepItems4
			{
				get
				{
					return switchStepItems4;
				}
				set	
				{
					switchStepItems4 = value;
				}
			}

			public class DescribeHALogs_SwitchStepItem5
			{

				private string stepName;

				private string stepMsg;

				private string startTime;

				private string endTime;

				private string timeCost;

				private string isSuccess;

				private string simulatePhase;

				private string dBNodeId;

				public string StepName
				{
					get
					{
						return stepName;
					}
					set	
					{
						stepName = value;
					}
				}

				public string StepMsg
				{
					get
					{
						return stepMsg;
					}
					set	
					{
						stepMsg = value;
					}
				}

				public string StartTime
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

				public string EndTime
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

				public string TimeCost
				{
					get
					{
						return timeCost;
					}
					set	
					{
						timeCost = value;
					}
				}

				public string IsSuccess
				{
					get
					{
						return isSuccess;
					}
					set	
					{
						isSuccess = value;
					}
				}

				public string SimulatePhase
				{
					get
					{
						return simulatePhase;
					}
					set	
					{
						simulatePhase = value;
					}
				}

				public string DBNodeId
				{
					get
					{
						return dBNodeId;
					}
					set	
					{
						dBNodeId = value;
					}
				}
			}
		}
	}
}
