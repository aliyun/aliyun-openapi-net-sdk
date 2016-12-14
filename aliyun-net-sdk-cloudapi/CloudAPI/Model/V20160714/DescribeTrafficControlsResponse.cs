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

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeTrafficControlsResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<TrafficControl> trafficControls;

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

		public List<TrafficControl> TrafficControls
		{
			get
			{
				return trafficControls;
			}
			set	
			{
				trafficControls = value;
			}
		}

		public class TrafficControl{

			private string trafficControlId;

			private string trafficControlName;

			private string description;

			private string trafficControlUnit;

			private int? apiDefault;

			private int? userDefault;

			private int? appDefault;

			private string createdTime;

			private string modifiedTime;

			private List<SpecialPolicy> specialPolicies;

			public string TrafficControlId
			{
				get
				{
					return trafficControlId;
				}
				set	
				{
					trafficControlId = value;
				}
			}

			public string TrafficControlName
			{
				get
				{
					return trafficControlName;
				}
				set	
				{
					trafficControlName = value;
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

			public string TrafficControlUnit
			{
				get
				{
					return trafficControlUnit;
				}
				set	
				{
					trafficControlUnit = value;
				}
			}

			public int? ApiDefault
			{
				get
				{
					return apiDefault;
				}
				set	
				{
					apiDefault = value;
				}
			}

			public int? UserDefault
			{
				get
				{
					return userDefault;
				}
				set	
				{
					userDefault = value;
				}
			}

			public int? AppDefault
			{
				get
				{
					return appDefault;
				}
				set	
				{
					appDefault = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			public List<SpecialPolicy> SpecialPolicies
			{
				get
				{
					return specialPolicies;
				}
				set	
				{
					specialPolicies = value;
				}
			}

			public class SpecialPolicy{

				private string specialType;

				private List<Special> specials;

				public string SpecialType
				{
					get
					{
						return specialType;
					}
					set	
					{
						specialType = value;
					}
				}

				public List<Special> Specials
				{
					get
					{
						return specials;
					}
					set	
					{
						specials = value;
					}
				}

				public class Special{

					private string specialKey;

					private int? trafficValue;

					public string SpecialKey
					{
						get
						{
							return specialKey;
						}
						set	
						{
							specialKey = value;
						}
					}

					public int? TrafficValue
					{
						get
						{
							return trafficValue;
						}
						set	
						{
							trafficValue = value;
						}
					}
				}
			}
		}
	}
}