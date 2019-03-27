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

namespace Aliyun.Acs.Drds.Model.V20171016
{
	public class DescribeRegionsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeRegions_DrdsRegion> drdsRegions;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<DescribeRegions_DrdsRegion> DrdsRegions
		{
			get
			{
				return drdsRegions;
			}
			set	
			{
				drdsRegions = value;
			}
		}

		public class DescribeRegions_DrdsRegion
		{

			private string regionId;

			private string regionName;

			private string zoneId;

			private string zoneName;

			private List<DescribeRegions_InstanceSeries> instanceSeriesList;

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

			public string RegionName
			{
				get
				{
					return regionName;
				}
				set	
				{
					regionName = value;
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

			public string ZoneName
			{
				get
				{
					return zoneName;
				}
				set	
				{
					zoneName = value;
				}
			}

			public List<DescribeRegions_InstanceSeries> InstanceSeriesList
			{
				get
				{
					return instanceSeriesList;
				}
				set	
				{
					instanceSeriesList = value;
				}
			}

			public class DescribeRegions_InstanceSeries
			{

				private string seriesId;

				private string seriesName;

				private List<DescribeRegions_Spec> specList;

				public string SeriesId
				{
					get
					{
						return seriesId;
					}
					set	
					{
						seriesId = value;
					}
				}

				public string SeriesName
				{
					get
					{
						return seriesName;
					}
					set	
					{
						seriesName = value;
					}
				}

				public List<DescribeRegions_Spec> SpecList
				{
					get
					{
						return specList;
					}
					set	
					{
						specList = value;
					}
				}

				public class DescribeRegions_Spec
				{

					private string specId;

					private string specName;

					public string SpecId
					{
						get
						{
							return specId;
						}
						set	
						{
							specId = value;
						}
					}

					public string SpecName
					{
						get
						{
							return specName;
						}
						set	
						{
							specName = value;
						}
					}
				}
			}
		}
	}
}
