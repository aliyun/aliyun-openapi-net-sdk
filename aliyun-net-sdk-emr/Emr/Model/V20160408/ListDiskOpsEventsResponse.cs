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
	public class ListDiskOpsEventsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<ListDiskOpsEvents_DiskOpsEventInfo> eventList;

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

		public List<ListDiskOpsEvents_DiskOpsEventInfo> EventList
		{
			get
			{
				return eventList;
			}
			set	
			{
				eventList = value;
			}
		}

		public class ListDiskOpsEvents_DiskOpsEventInfo
		{

			private string regionId;

			private string userId;

			private string clusterBizId;

			private string clusterName;

			private string instanceId;

			private string instanceName;

			private string instanceStatus;

			private string privateIp;

			private string diskId;

			private string diskDevice;

			private string diskMountPoint;

			private string eventId;

			private string eventType;

			private long? eventTriggerTime;

			private string currentActivity;

			private string currentActivityState;

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
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

			public string ClusterBizId
			{
				get
				{
					return clusterBizId;
				}
				set	
				{
					clusterBizId = value;
				}
			}

			public string ClusterName
			{
				get
				{
					return clusterName;
				}
				set	
				{
					clusterName = value;
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

			public string InstanceStatus
			{
				get
				{
					return instanceStatus;
				}
				set	
				{
					instanceStatus = value;
				}
			}

			public string PrivateIp
			{
				get
				{
					return privateIp;
				}
				set	
				{
					privateIp = value;
				}
			}

			public string DiskId
			{
				get
				{
					return diskId;
				}
				set	
				{
					diskId = value;
				}
			}

			public string DiskDevice
			{
				get
				{
					return diskDevice;
				}
				set	
				{
					diskDevice = value;
				}
			}

			public string DiskMountPoint
			{
				get
				{
					return diskMountPoint;
				}
				set	
				{
					diskMountPoint = value;
				}
			}

			public string EventId
			{
				get
				{
					return eventId;
				}
				set	
				{
					eventId = value;
				}
			}

			public string EventType
			{
				get
				{
					return eventType;
				}
				set	
				{
					eventType = value;
				}
			}

			public long? EventTriggerTime
			{
				get
				{
					return eventTriggerTime;
				}
				set	
				{
					eventTriggerTime = value;
				}
			}

			public string CurrentActivity
			{
				get
				{
					return currentActivity;
				}
				set	
				{
					currentActivity = value;
				}
			}

			public string CurrentActivityState
			{
				get
				{
					return currentActivityState;
				}
				set	
				{
					currentActivityState = value;
				}
			}
		}
	}
}
