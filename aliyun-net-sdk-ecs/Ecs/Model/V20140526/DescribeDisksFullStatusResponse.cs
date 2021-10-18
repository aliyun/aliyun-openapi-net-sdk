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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeDisksFullStatusResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeDisksFullStatus_DiskFullStatusType> diskFullStatusSet;

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

		public List<DescribeDisksFullStatus_DiskFullStatusType> DiskFullStatusSet
		{
			get
			{
				return diskFullStatusSet;
			}
			set	
			{
				diskFullStatusSet = value;
			}
		}

		public class DescribeDisksFullStatus_DiskFullStatusType
		{

			private string diskId;

			private string instanceId;

			private string device;

			private List<DescribeDisksFullStatus_DiskEventType> diskEventSet;

			private DescribeDisksFullStatus_Status status;

			private DescribeDisksFullStatus_HealthStatus healthStatus;

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

			public List<DescribeDisksFullStatus_DiskEventType> DiskEventSet
			{
				get
				{
					return diskEventSet;
				}
				set	
				{
					diskEventSet = value;
				}
			}

			public DescribeDisksFullStatus_Status Status
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

			public DescribeDisksFullStatus_HealthStatus HealthStatus
			{
				get
				{
					return healthStatus;
				}
				set	
				{
					healthStatus = value;
				}
			}

			public class DescribeDisksFullStatus_DiskEventType
			{

				private string eventId;

				private string eventEndTime;

				private string eventTime;

				private string impactLevel;

				private DescribeDisksFullStatus_EventType eventType;

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

				public string EventEndTime
				{
					get
					{
						return eventEndTime;
					}
					set	
					{
						eventEndTime = value;
					}
				}

				public string EventTime
				{
					get
					{
						return eventTime;
					}
					set	
					{
						eventTime = value;
					}
				}

				public string ImpactLevel
				{
					get
					{
						return impactLevel;
					}
					set	
					{
						impactLevel = value;
					}
				}

				public DescribeDisksFullStatus_EventType EventType
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

				public class DescribeDisksFullStatus_EventType
				{

					private string name;

					private int? code;

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
				}
			}

			public class DescribeDisksFullStatus_Status
			{

				private string name;

				private int? code;

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
			}

			public class DescribeDisksFullStatus_HealthStatus
			{

				private string name;

				private int? code;

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
			}
		}
	}
}
