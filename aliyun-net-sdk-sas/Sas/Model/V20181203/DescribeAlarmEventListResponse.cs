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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeAlarmEventListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAlarmEventList_SuspEventsItem> suspEvents;

		private DescribeAlarmEventList_PageInfo pageInfo;

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

		public List<DescribeAlarmEventList_SuspEventsItem> SuspEvents
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

		public DescribeAlarmEventList_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeAlarmEventList_SuspEventsItem
		{

			private bool? dealed;

			private string stages;

			private string internetIp;

			private int? suspiciousEventCount;

			private string k8sClusterName;

			private string containerImageId;

			private long? gmtModified;

			private string alarmEventNameOriginal;

			private string alarmUniqueInfo;

			private bool? canCancelFault;

			private string appName;

			private string securityEventIds;

			private string k8sClusterId;

			private string containerImageName;

			private bool? canBeDealOnLine;

			private string description;

			private bool? containHwMode;

			private string k8sNodeId;

			private string instanceName;

			private string saleVersion;

			private string operateErrorCode;

			private string solution;

			private bool? hasTraceInfo;

			private string dataSource;

			private long? operateTime;

			private string instanceId;

			private string intranetIp;

			private long? endTime;

			private string uuid;

			private long? startTime;

			private string k8sPodName;

			private string containerId;

			private string alarmEventType;

			private string k8sNamespace;

			private string k8sNodeName;

			private string alarmEventName;

			private string level;

			private List<DescribeAlarmEventList_TacticItem> tacticItems;

			public bool? Dealed
			{
				get
				{
					return dealed;
				}
				set	
				{
					dealed = value;
				}
			}

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

			public int? SuspiciousEventCount
			{
				get
				{
					return suspiciousEventCount;
				}
				set	
				{
					suspiciousEventCount = value;
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

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string AlarmEventNameOriginal
			{
				get
				{
					return alarmEventNameOriginal;
				}
				set	
				{
					alarmEventNameOriginal = value;
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

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			public List<DescribeAlarmEventList_TacticItem> TacticItems
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

			public class DescribeAlarmEventList_TacticItem
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
		}

		public class DescribeAlarmEventList_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalCount;

			private int? count;

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
		}
	}
}
