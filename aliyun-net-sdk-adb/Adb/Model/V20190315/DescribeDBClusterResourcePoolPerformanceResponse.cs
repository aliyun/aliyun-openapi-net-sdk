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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeDBClusterResourcePoolPerformanceResponse : AcsResponse
	{

		private string requestId;

		private string dBClusterId;

		private string startTime;

		private string endTime;

		private List<DescribeDBClusterResourcePoolPerformance_PerformanceItem> performances;

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

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
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

		public List<DescribeDBClusterResourcePoolPerformance_PerformanceItem> Performances
		{
			get
			{
				return performances;
			}
			set	
			{
				performances = value;
			}
		}

		public class DescribeDBClusterResourcePoolPerformance_PerformanceItem
		{

			private string key;

			private string unit;

			private List<DescribeDBClusterResourcePoolPerformance_ResourcePoolPerformancesItem> resourcePoolPerformances;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
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

			public List<DescribeDBClusterResourcePoolPerformance_ResourcePoolPerformancesItem> ResourcePoolPerformances
			{
				get
				{
					return resourcePoolPerformances;
				}
				set	
				{
					resourcePoolPerformances = value;
				}
			}

			public class DescribeDBClusterResourcePoolPerformance_ResourcePoolPerformancesItem
			{

				private string resourcePoolName;

				private List<DescribeDBClusterResourcePoolPerformance_ResourcePoolSeriesItem> resourcePoolSeries;

				public string ResourcePoolName
				{
					get
					{
						return resourcePoolName;
					}
					set	
					{
						resourcePoolName = value;
					}
				}

				public List<DescribeDBClusterResourcePoolPerformance_ResourcePoolSeriesItem> ResourcePoolSeries
				{
					get
					{
						return resourcePoolSeries;
					}
					set	
					{
						resourcePoolSeries = value;
					}
				}

				public class DescribeDBClusterResourcePoolPerformance_ResourcePoolSeriesItem
				{

					private string name;

					private List<string> values;

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

					public List<string> Values
					{
						get
						{
							return values;
						}
						set	
						{
							values = value;
						}
					}
				}
			}
		}
	}
}
