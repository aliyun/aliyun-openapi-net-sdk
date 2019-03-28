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
	public class DescribeAvailableResourceResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAvailableResource_AvailableZone> availableZones;

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

		public List<DescribeAvailableResource_AvailableZone> AvailableZones
		{
			get
			{
				return availableZones;
			}
			set	
			{
				availableZones = value;
			}
		}

		public class DescribeAvailableResource_AvailableZone
		{

			private string regionId;

			private string zoneId;

			private string status;

			private string statusCategory;

			private List<DescribeAvailableResource_AvailableResource> availableResources;

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

			public string Status
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

			public string StatusCategory
			{
				get
				{
					return statusCategory;
				}
				set	
				{
					statusCategory = value;
				}
			}

			public List<DescribeAvailableResource_AvailableResource> AvailableResources
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

			public class DescribeAvailableResource_AvailableResource
			{

				private string type;

				private List<DescribeAvailableResource_SupportedResource> supportedResources;

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

				public List<DescribeAvailableResource_SupportedResource> SupportedResources
				{
					get
					{
						return supportedResources;
					}
					set	
					{
						supportedResources = value;
					}
				}

				public class DescribeAvailableResource_SupportedResource
				{

					private string _value;

					private string status;

					private string statusCategory;

					private int? min;

					private int? max;

					private string unit;

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

					public string Status
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

					public string StatusCategory
					{
						get
						{
							return statusCategory;
						}
						set	
						{
							statusCategory = value;
						}
					}

					public int? Min
					{
						get
						{
							return min;
						}
						set	
						{
							min = value;
						}
					}

					public int? Max
					{
						get
						{
							return max;
						}
						set	
						{
							max = value;
						}
					}

					public string Unit
					{
						get
						{
							return unit;
						}
						set	
						{
							unit = value;
						}
					}
				}
			}
		}
	}
}
