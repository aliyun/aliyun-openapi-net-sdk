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
	public class DescribeZonesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeZones_Zone> zones;

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

		public List<DescribeZones_Zone> Zones
		{
			get
			{
				return zones;
			}
			set	
			{
				zones = value;
			}
		}

		public class DescribeZones_Zone
		{

			private string zoneId;

			private string localName;

			private List<DescribeZones_ResourcesInfo> availableResources;

			private List<string> availableResourceCreation;

			private List<string> availableDiskCategories;

			private List<string> availableInstanceTypes;

			private List<string> availableVolumeCategories;

			private List<string> availableDedicatedHostTypes;

			private List<string> dedicatedHostGenerations;

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string LocalName
			{
				get
				{
					return localName;
				}
				set	
				{
					localName = value;
				}
			}

			public List<DescribeZones_ResourcesInfo> AvailableResources
			{
				get
				{
					return availableResources;
				}
				set	
				{
					availableResources = value;
				}
			}

			public List<string> AvailableResourceCreation
			{
				get
				{
					return availableResourceCreation;
				}
				set	
				{
					availableResourceCreation = value;
				}
			}

			public List<string> AvailableDiskCategories
			{
				get
				{
					return availableDiskCategories;
				}
				set	
				{
					availableDiskCategories = value;
				}
			}

			public List<string> AvailableInstanceTypes
			{
				get
				{
					return availableInstanceTypes;
				}
				set	
				{
					availableInstanceTypes = value;
				}
			}

			public List<string> AvailableVolumeCategories
			{
				get
				{
					return availableVolumeCategories;
				}
				set	
				{
					availableVolumeCategories = value;
				}
			}

			public List<string> AvailableDedicatedHostTypes
			{
				get
				{
					return availableDedicatedHostTypes;
				}
				set	
				{
					availableDedicatedHostTypes = value;
				}
			}

			public List<string> DedicatedHostGenerations
			{
				get
				{
					return dedicatedHostGenerations;
				}
				set	
				{
					dedicatedHostGenerations = value;
				}
			}

			public class DescribeZones_ResourcesInfo
			{

				private bool? ioOptimized;

				private List<string> systemDiskCategories;

				private List<string> dataDiskCategories;

				private List<string> networkTypes;

				private List<string> instanceTypes;

				private List<string> instanceTypeFamilies;

				private List<string> instanceGenerations;

				public bool? IoOptimized
				{
					get
					{
						return ioOptimized;
					}
					set	
					{
						ioOptimized = value;
					}
				}

				public List<string> SystemDiskCategories
				{
					get
					{
						return systemDiskCategories;
					}
					set	
					{
						systemDiskCategories = value;
					}
				}

				public List<string> DataDiskCategories
				{
					get
					{
						return dataDiskCategories;
					}
					set	
					{
						dataDiskCategories = value;
					}
				}

				public List<string> NetworkTypes
				{
					get
					{
						return networkTypes;
					}
					set	
					{
						networkTypes = value;
					}
				}

				public List<string> InstanceTypes
				{
					get
					{
						return instanceTypes;
					}
					set	
					{
						instanceTypes = value;
					}
				}

				public List<string> InstanceTypeFamilies
				{
					get
					{
						return instanceTypeFamilies;
					}
					set	
					{
						instanceTypeFamilies = value;
					}
				}

				public List<string> InstanceGenerations
				{
					get
					{
						return instanceGenerations;
					}
					set	
					{
						instanceGenerations = value;
					}
				}
			}
		}
	}
}
