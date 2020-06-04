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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeInstancesFullStatusResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeInstancesFullStatus_InstanceFullStatusType> instanceFullStatusSet;

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

		public List<DescribeInstancesFullStatus_InstanceFullStatusType> InstanceFullStatusSet
		{
			get
			{
				return instanceFullStatusSet;
			}
			set	
			{
				instanceFullStatusSet = value;
			}
		}

		public class DescribeInstancesFullStatus_InstanceFullStatusType
		{

			private string instanceId;

			private List<DescribeInstancesFullStatus_ScheduledSystemEventType> scheduledSystemEventSet;

			private DescribeInstancesFullStatus_Status status;

			private DescribeInstancesFullStatus_HealthStatus healthStatus;

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

			public List<DescribeInstancesFullStatus_ScheduledSystemEventType> ScheduledSystemEventSet
			{
				get
				{
					return scheduledSystemEventSet;
				}
				set	
				{
					scheduledSystemEventSet = value;
				}
			}

			public DescribeInstancesFullStatus_Status Status
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

			public DescribeInstancesFullStatus_HealthStatus HealthStatus
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

			public class DescribeInstancesFullStatus_ScheduledSystemEventType
			{

				private string eventId;

				private string eventPublishTime;

				private string notBefore;

				private string reason;

				private string impactLevel;

				private DescribeInstancesFullStatus_EventCycleStatus eventCycleStatus;

				private DescribeInstancesFullStatus_EventType eventType;

				private DescribeInstancesFullStatus_ExtendedAttribute extendedAttribute;

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

				public string Reason
				{
					get
					{
						return reason;
					}
					set	
					{
						reason = value;
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

				public DescribeInstancesFullStatus_EventCycleStatus EventCycleStatus
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

				public DescribeInstancesFullStatus_EventType EventType
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

				public DescribeInstancesFullStatus_ExtendedAttribute ExtendedAttribute
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

				public class DescribeInstancesFullStatus_EventCycleStatus
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

				public class DescribeInstancesFullStatus_EventType
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

				public class DescribeInstancesFullStatus_ExtendedAttribute
				{

					private string diskId;

					private string device;

					private List<DescribeInstancesFullStatus_InactiveDisk> inactiveDisks;

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

					public List<DescribeInstancesFullStatus_InactiveDisk> InactiveDisks
					{
						get
						{
							return inactiveDisks;
						}
						set	
						{
							inactiveDisks = value;
						}
					}

					public class DescribeInstancesFullStatus_InactiveDisk
					{

						private string creationTime;

						private string releaseTime;

						private string deviceType;

						private string deviceCategory;

						private string deviceSize;

						public string CreationTime
						{
							get
							{
								return creationTime;
							}
							set	
							{
								creationTime = value;
							}
						}

						public string ReleaseTime
						{
							get
							{
								return releaseTime;
							}
							set	
							{
								releaseTime = value;
							}
						}

						public string DeviceType
						{
							get
							{
								return deviceType;
							}
							set	
							{
								deviceType = value;
							}
						}

						public string DeviceCategory
						{
							get
							{
								return deviceCategory;
							}
							set	
							{
								deviceCategory = value;
							}
						}

						public string DeviceSize
						{
							get
							{
								return deviceSize;
							}
							set	
							{
								deviceSize = value;
							}
						}
					}
				}
			}

			public class DescribeInstancesFullStatus_Status
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

			public class DescribeInstancesFullStatus_HealthStatus
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
		}
	}
}
