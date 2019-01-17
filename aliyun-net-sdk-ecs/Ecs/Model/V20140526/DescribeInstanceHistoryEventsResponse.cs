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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeInstanceHistoryEventsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeInstanceHistoryEvents_InstanceSystemEventType> instanceSystemEventSet;

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

		public List<DescribeInstanceHistoryEvents_InstanceSystemEventType> InstanceSystemEventSet
		{
			get
			{
				return instanceSystemEventSet;
			}
			set	
			{
				instanceSystemEventSet = value;
			}
		}

		public class DescribeInstanceHistoryEvents_InstanceSystemEventType
		{

			private string instanceId;

			private string eventId;

			private string eventPublishTime;

			private string notBefore;

			private string eventFinishTime;

			private DescribeInstanceHistoryEvents_EventType eventType;

			private DescribeInstanceHistoryEvents_EventCycleStatus eventCycleStatus;

			private DescribeInstanceHistoryEvents_ExtendedAttribute extendedAttribute;

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

			public string EventPublishTime
			{
				get
				{
					return eventPublishTime;
				}
				set	
				{
					eventPublishTime = value;
				}
			}

			public string NotBefore
			{
				get
				{
					return notBefore;
				}
				set	
				{
					notBefore = value;
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

			public DescribeInstanceHistoryEvents_EventType EventType
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

			public DescribeInstanceHistoryEvents_EventCycleStatus EventCycleStatus
			{
				get
				{
					return eventCycleStatus;
				}
				set	
				{
					eventCycleStatus = value;
				}
			}

			public DescribeInstanceHistoryEvents_ExtendedAttribute ExtendedAttribute
			{
				get
				{
					return extendedAttribute;
				}
				set	
				{
					extendedAttribute = value;
				}
			}

			public class DescribeInstanceHistoryEvents_EventType
			{

				private int? code;

				private string name;

				public int? Code
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
			}

			public class DescribeInstanceHistoryEvents_EventCycleStatus
			{

				private int? code;

				private string name;

				public int? Code
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
			}

			public class DescribeInstanceHistoryEvents_ExtendedAttribute
			{

				private string diskId;

				private string device;

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

				public string Device
				{
					get
					{
						return device;
					}
					set	
					{
						device = value;
					}
				}
			}
		}
	}
}