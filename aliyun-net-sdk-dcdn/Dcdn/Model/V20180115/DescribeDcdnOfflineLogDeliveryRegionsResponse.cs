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

namespace Aliyun.Acs.dcdn.Model.V20180115
{
	public class DescribeDcdnOfflineLogDeliveryRegionsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDcdnOfflineLogDeliveryRegions_Area> areas;

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

		public List<DescribeDcdnOfflineLogDeliveryRegions_Area> Areas
		{
			get
			{
				return areas;
			}
			set	
			{
				areas = value;
			}
		}

		public class DescribeDcdnOfflineLogDeliveryRegions_Area
		{

			private string areaId;

			private string areaName;

			private List<DescribeDcdnOfflineLogDeliveryRegions_RegionInfo> regionInfos;

			public string AreaId
			{
				get
				{
					return areaId;
				}
				set	
				{
					areaId = value;
				}
			}

			public string AreaName
			{
				get
				{
					return areaName;
				}
				set	
				{
					areaName = value;
				}
			}

			public List<DescribeDcdnOfflineLogDeliveryRegions_RegionInfo> RegionInfos
			{
				get
				{
					return regionInfos;
				}
				set	
				{
					regionInfos = value;
				}
			}

			public class DescribeDcdnOfflineLogDeliveryRegions_RegionInfo
			{

				private string regionId;

				private string regionName;

				private string isOverseas;

				private string ossEndpoint;

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

				public string IsOverseas
				{
					get
					{
						return isOverseas;
					}
					set	
					{
						isOverseas = value;
					}
				}

				public string OssEndpoint
				{
					get
					{
						return ossEndpoint;
					}
					set	
					{
						ossEndpoint = value;
					}
				}
			}
		}
	}
}
