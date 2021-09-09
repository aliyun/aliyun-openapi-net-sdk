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

namespace Aliyun.Acs.companyreg.Model.V20190508
{
	public class QueryBookkeepingCommoditiesResponse : AcsResponse
	{

		private string requestId;

		private List<QueryBookkeepingCommodities_BookkeepingCommodity> data;

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

		public List<QueryBookkeepingCommodities_BookkeepingCommodity> Data
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

		public class QueryBookkeepingCommodities_BookkeepingCommodity
		{

			private string topOrgCode;

			private string commodityCode;

			private string commodityName;

			private string specCode;

			private string packageVersionCode;

			private string packageVersionValue;

			private string packageVersionName;

			private string cityModuleCode;

			private string cityModuleValue;

			private string cityModuleName;

			private string ordTimeCode;

			private string ordTimeValue;

			private string ordTimeName;

			private string topOrgName;

			private string serviceModuleCode;

			private string serviceModuleValue;

			private string serviceModuleName;

			private string areaType;

			public string TopOrgCode
			{
				get
				{
					return topOrgCode;
				}
				set	
				{
					topOrgCode = value;
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

			public string CommodityName
			{
				get
				{
					return commodityName;
				}
				set	
				{
					commodityName = value;
				}
			}

			public string SpecCode
			{
				get
				{
					return specCode;
				}
				set	
				{
					specCode = value;
				}
			}

			public string PackageVersionCode
			{
				get
				{
					return packageVersionCode;
				}
				set	
				{
					packageVersionCode = value;
				}
			}

			public string PackageVersionValue
			{
				get
				{
					return packageVersionValue;
				}
				set	
				{
					packageVersionValue = value;
				}
			}

			public string PackageVersionName
			{
				get
				{
					return packageVersionName;
				}
				set	
				{
					packageVersionName = value;
				}
			}

			public string CityModuleCode
			{
				get
				{
					return cityModuleCode;
				}
				set	
				{
					cityModuleCode = value;
				}
			}

			public string CityModuleValue
			{
				get
				{
					return cityModuleValue;
				}
				set	
				{
					cityModuleValue = value;
				}
			}

			public string CityModuleName
			{
				get
				{
					return cityModuleName;
				}
				set	
				{
					cityModuleName = value;
				}
			}

			public string OrdTimeCode
			{
				get
				{
					return ordTimeCode;
				}
				set	
				{
					ordTimeCode = value;
				}
			}

			public string OrdTimeValue
			{
				get
				{
					return ordTimeValue;
				}
				set	
				{
					ordTimeValue = value;
				}
			}

			public string OrdTimeName
			{
				get
				{
					return ordTimeName;
				}
				set	
				{
					ordTimeName = value;
				}
			}

			public string TopOrgName
			{
				get
				{
					return topOrgName;
				}
				set	
				{
					topOrgName = value;
				}
			}

			public string ServiceModuleCode
			{
				get
				{
					return serviceModuleCode;
				}
				set	
				{
					serviceModuleCode = value;
				}
			}

			public string ServiceModuleValue
			{
				get
				{
					return serviceModuleValue;
				}
				set	
				{
					serviceModuleValue = value;
				}
			}

			public string ServiceModuleName
			{
				get
				{
					return serviceModuleName;
				}
				set	
				{
					serviceModuleName = value;
				}
			}

			public string AreaType
			{
				get
				{
					return areaType;
				}
				set	
				{
					areaType = value;
				}
			}
		}
	}
}
