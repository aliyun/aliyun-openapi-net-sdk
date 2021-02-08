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
	public class DescribeRecommendInstanceTypeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRecommendInstanceType_RecommendInstanceType> data;

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

		public List<DescribeRecommendInstanceType_RecommendInstanceType> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeRecommendInstanceType_RecommendInstanceType
		{

			private string regionId;

			private string commodityCode;

			private string scene;

			private string instanceChargeType;

			private string spotStrategy;

			private int? priority;

			private string zoneId;

			private string networkType;

			private List<DescribeRecommendInstanceType_Zone> zones;

			private DescribeRecommendInstanceType_InstanceType instanceType;

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

			public string CommodityCode
			{
				get
				{
					return commodityCode;
				}
				set	
				{
					commodityCode = value;
				}
			}

			public string Scene
			{
				get
				{
					return scene;
				}
				set	
				{
					scene = value;
				}
			}

			public string InstanceChargeType
			{
				get
				{
					return instanceChargeType;
				}
				set	
				{
					instanceChargeType = value;
				}
			}

			public string SpotStrategy
			{
				get
				{
					return spotStrategy;
				}
				set	
				{
					spotStrategy = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
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

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public List<DescribeRecommendInstanceType_Zone> Zones
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

			public DescribeRecommendInstanceType_InstanceType InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public class DescribeRecommendInstanceType_Zone
			{

				private string zoneNo;

				private List<string> networkTypes;

				public string ZoneNo
				{
					get
					{
						return zoneNo;
					}
					set	
					{
						zoneNo = value;
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
			}

			public class DescribeRecommendInstanceType_InstanceType
			{

				private string generation;

				private string instanceTypeFamily;

				private string instanceType;

				private string supportIoOptimized;

				private int? cores;

				private int? memory;

				public string Generation
				{
					get
					{
						return generation;
					}
					set	
					{
						generation = value;
					}
				}

				public string InstanceTypeFamily
				{
					get
					{
						return instanceTypeFamily;
					}
					set	
					{
						instanceTypeFamily = value;
					}
				}

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}

				public string SupportIoOptimized
				{
					get
					{
						return supportIoOptimized;
					}
					set	
					{
						supportIoOptimized = value;
					}
				}

				public int? Cores
				{
					get
					{
						return cores;
					}
					set	
					{
						cores = value;
					}
				}

				public int? Memory
				{
					get
					{
						return memory;
					}
					set	
					{
						memory = value;
					}
				}
			}
		}
	}
}
