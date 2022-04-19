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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeSuspEventsResponse : AcsResponse
	{

		private int? currentPage;

		private int? pageSize;

		private string requestId;

		private int? totalCount;

		private int? count;

		private List<DescribeSuspEvents_WarningSummary> suspEvents;

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public List<DescribeSuspEvents_WarningSummary> SuspEvents
		{
			get
			{
				return suspEvents;
			}
			set	
			{
				suspEvents = value;
			}
		}

		public class DescribeSuspEvents_WarningSummary
		{

			private string stages;

			private string internetIp;

			private string k8sClusterName;

			private string containerImageId;

			private long? lastTimeStamp;

			private string occurrenceTime;

			private string alarmUniqueInfo;

			private string desc;

			private bool? canCancelFault;

			private string alarmEventNameDisplay;

			private string appName;

			private string securityEventIds;

			private string k8sClusterId;

			private string containerImageName;

			private string markMisRules;

			private bool? canBeDealOnLine;

			private bool? containHwMode;

			private string k8sNodeId;

			private string instanceName;

			private int? eventStatus;

			private string saleVersion;

			private string operateErrorCode;

			private string name;

			private bool? hasTraceInfo;

			private string dataSource;

			private long? operateTime;

			private string eventSubType;

			private bool? advanced;

			private long? occurrenceTimeStamp;

			private string instanceId;

			private string alarmEventTypeDisplay;

			private string intranetIp;

			private string lastTime;

			private string operateMsg;

			private string uuid;

			private string k8sPodName;

			private string containerId;

			private string alarmEventType;

			private string k8sNamespace;

			private bool? autoBreaking;

			private string k8sNodeName;

			private string alarmEventName;

			private string uniqueInfo;

			private string maliciousRuleStatus;

			private string level;

			private long? id;

			private List<DescribeSuspEvents_TacticItem> tacticItems;

			private List<DescribeSuspEvents_QuaraFile> details;

			private List<DescribeSuspEvents_EventNote> eventNotes;

			public string Stages
			{
				get
				{
					return stages;
				}
				set	
				{
					stages = value;
				}
			}

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

			public string K8sClusterName
			{
				get
				{
					return k8sClusterName;
				}
				set	
				{
					k8sClusterName = value;
				}
			}

			public string ContainerImageId
			{
				get
				{
					return containerImageId;
				}
				set	
				{
					containerImageId = value;
				}
			}

			public long? LastTimeStamp
			{
				get
				{
					return lastTimeStamp;
				}
				set	
				{
					lastTimeStamp = value;
				}
			}

			public string OccurrenceTime
			{
				get
				{
					return occurrenceTime;
				}
				set	
				{
					occurrenceTime = value;
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

			public string Desc
			{
				get
				{
					return desc;
				}
				set	
				{
					desc = value;
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

			public string AlarmEventNameDisplay
			{
				get
				{
					return alarmEventNameDisplay;
				}
				set	
				{
					alarmEventNameDisplay = value;
				}
			}

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public string SecurityEventIds
			{
				get
				{
					return securityEventIds;
				}
				set	
				{
					securityEventIds = value;
				}
			}

			public string K8sClusterId
			{
				get
				{
					return k8sClusterId;
				}
				set	
				{
					k8sClusterId = value;
				}
			}

			public string ContainerImageName
			{
				get
				{
					return containerImageName;
				}
				set	
				{
					containerImageName = value;
				}
			}

			public string MarkMisRules
			{
				get
				{
					return markMisRules;
				}
				set	
				{
					markMisRules = value;
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

			public bool? ContainHwMode
			{
				get
				{
					return containHwMode;
				}
				set	
				{
					containHwMode = value;
				}
			}

			public string K8sNodeId
			{
				get
				{
					return k8sNodeId;
				}
				set	
				{
					k8sNodeId = value;
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

			public int? EventStatus
			{
				get
				{
					return eventStatus;
				}
				set	
				{
					eventStatus = value;
				}
			}

			public string SaleVersion
			{
				get
				{
					return saleVersion;
				}
				set	
				{
					saleVersion = value;
				}
			}

			public string OperateErrorCode
			{
				get
				{
					return operateErrorCode;
				}
				set	
				{
					operateErrorCode = value;
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

			public long? OperateTime
			{
				get
				{
					return operateTime;
				}
				set	
				{
					operateTime = value;
				}
			}

			public string EventSubType
			{
				get
				{
					return eventSubType;
				}
				set	
				{
					eventSubType = value;
				}
			}

			public bool? Advanced
			{
				get
				{
					return advanced;
				}
				set	
				{
					advanced = value;
				}
			}

			public long? OccurrenceTimeStamp
			{
				get
				{
					return occurrenceTimeStamp;
				}
				set	
				{
					occurrenceTimeStamp = value;
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

			public string AlarmEventTypeDisplay
			{
				get
				{
					return alarmEventTypeDisplay;
				}
				set	
				{
					alarmEventTypeDisplay = value;
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

			public string LastTime
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

			public string OperateMsg
			{
				get
				{
					return operateMsg;
				}
				set	
				{
					operateMsg = value;
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

			public string K8sPodName
			{
				get
				{
					return k8sPodName;
				}
				set	
				{
					k8sPodName = value;
				}
			}

			public string ContainerId
			{
				get
				{
					return containerId;
				}
				set	
				{
					containerId = value;
				}
			}

			public string AlarmEventType
			{
				get
				{
					return alarmEventType;
				}
				set	
				{
					alarmEventType = value;
				}
			}

			public string K8sNamespace
			{
				get
				{
					return k8sNamespace;
				}
				set	
				{
					k8sNamespace = value;
				}
			}

			public bool? AutoBreaking
			{
				get
				{
					return autoBreaking;
				}
				set	
				{
					autoBreaking = value;
				}
			}

			public string K8sNodeName
			{
				get
				{
					return k8sNodeName;
				}
				set	
				{
					k8sNodeName = value;
				}
			}

			public string AlarmEventName
			{
				get
				{
					return alarmEventName;
				}
				set	
				{
					alarmEventName = value;
				}
			}

			public string UniqueInfo
			{
				get
				{
					return uniqueInfo;
				}
				set	
				{
					uniqueInfo = value;
				}
			}

			public string MaliciousRuleStatus
			{
				get
				{
					return maliciousRuleStatus;
				}
				set	
				{
					maliciousRuleStatus = value;
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

			public long? Id
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

			public List<DescribeSuspEvents_TacticItem> TacticItems
			{
				get
				{
					return tacticItems;
				}
				set	
				{
					tacticItems = value;
				}
			}

			public List<DescribeSuspEvents_QuaraFile> Details
			{
				get
				{
					return details;
				}
				set	
				{
					details = value;
				}
			}

			public List<DescribeSuspEvents_EventNote> EventNotes
			{
				get
				{
					return eventNotes;
				}
				set	
				{
					eventNotes = value;
				}
			}

			public class DescribeSuspEvents_TacticItem
			{

				private string tacticId;

				private string tacticDisplayName;

				public string TacticId
				{
					get
					{
						return tacticId;
					}
					set	
					{
						tacticId = value;
					}
				}

				public string TacticDisplayName
				{
					get
					{
						return tacticDisplayName;
					}
					set	
					{
						tacticDisplayName = value;
					}
				}
			}

			public class DescribeSuspEvents_QuaraFile
			{

				private string type;

				private string _value;

				private string name;

				private string nameDisplay;

				private string infoType;

				private string valueDisplay;

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

				public string NameDisplay
				{
					get
					{
						return nameDisplay;
					}
					set	
					{
						nameDisplay = value;
					}
				}

				public string InfoType
				{
					get
					{
						return infoType;
					}
					set	
					{
						infoType = value;
					}
				}

				public string ValueDisplay
				{
					get
					{
						return valueDisplay;
					}
					set	
					{
						valueDisplay = value;
					}
				}
			}

			public class DescribeSuspEvents_EventNote
			{

				private string note;

				private long? noteId;

				private string noteTime;

				public string Note
				{
					get
					{
						return note;
					}
					set	
					{
						note = value;
					}
				}

				public long? NoteId
				{
					get
					{
						return noteId;
					}
					set	
					{
						noteId = value;
					}
				}

				public string NoteTime
				{
					get
					{
						return noteTime;
					}
					set	
					{
						noteTime = value;
					}
				}
			}
		}
	}
}
