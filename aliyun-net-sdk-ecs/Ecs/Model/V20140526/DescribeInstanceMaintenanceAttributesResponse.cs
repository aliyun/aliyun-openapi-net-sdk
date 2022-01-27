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
	public class DescribeInstanceMaintenanceAttributesResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeInstanceMaintenanceAttributes_MaintenanceAttribute> maintenanceAttributes;

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

		public List<DescribeInstanceMaintenanceAttributes_MaintenanceAttribute> MaintenanceAttributes
		{
			get
			{
				return maintenanceAttributes;
			}
			set	
			{
				maintenanceAttributes = value;
			}
		}

		public class DescribeInstanceMaintenanceAttributes_MaintenanceAttribute
		{

			private bool? notifyOnMaintenance;

			private string instanceId;

			private List<DescribeInstanceMaintenanceAttributes_MaintenanceWindow> maintenanceWindows;

			private DescribeInstanceMaintenanceAttributes_ActionOnMaintenance actionOnMaintenance;

			public bool? NotifyOnMaintenance
			{
				get
				{
					return notifyOnMaintenance;
				}
				set	
				{
					notifyOnMaintenance = value;
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

			public List<DescribeInstanceMaintenanceAttributes_MaintenanceWindow> MaintenanceWindows
			{
				get
				{
					return maintenanceWindows;
				}
				set	
				{
					maintenanceWindows = value;
				}
			}

			public DescribeInstanceMaintenanceAttributes_ActionOnMaintenance ActionOnMaintenance
			{
				get
				{
					return actionOnMaintenance;
				}
				set	
				{
					actionOnMaintenance = value;
				}
			}

			public class DescribeInstanceMaintenanceAttributes_MaintenanceWindow
			{

				private string endTime;

				private string startTime;

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
			}

			public class DescribeInstanceMaintenanceAttributes_ActionOnMaintenance
			{

				private string defaultValue;

				private string _value;

				private List<string> supportedValues;

				public string DefaultValue
				{
					get
					{
						return defaultValue;
					}
					set	
					{
						defaultValue = value;
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

				public List<string> SupportedValues
				{
					get
					{
						return supportedValues;
					}
					set	
					{
						supportedValues = value;
					}
				}
			}
		}
	}
}
