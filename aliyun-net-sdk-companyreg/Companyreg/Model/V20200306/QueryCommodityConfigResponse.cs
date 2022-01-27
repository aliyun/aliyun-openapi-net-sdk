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

namespace Aliyun.Acs.companyreg.Model.V20200306
{
	public class QueryCommodityConfigResponse : AcsResponse
	{

		private string requestId;

		private QueryCommodityConfig_Data data;

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

		public QueryCommodityConfig_Data Data
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

		public class QueryCommodityConfig_Data
		{

			private string productLine;

			private string commodityCode;

			private string description;

			private string startingPrice;

			private int? type;

			private string iconUrl;

			private string protocolUrl;

			private List<QueryCommodityConfig_CommodityModulesItem> commodityModules;

			public string ProductLine
			{
				get
				{
					return productLine;
				}
				set	
				{
					productLine = value;
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

			public string StartingPrice
			{
				get
				{
					return startingPrice;
				}
				set	
				{
					startingPrice = value;
				}
			}

			public int? Type
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

			public string IconUrl
			{
				get
				{
					return iconUrl;
				}
				set	
				{
					iconUrl = value;
				}
			}

			public string ProtocolUrl
			{
				get
				{
					return protocolUrl;
				}
				set	
				{
					protocolUrl = value;
				}
			}

			public List<QueryCommodityConfig_CommodityModulesItem> CommodityModules
			{
				get
				{
					return commodityModules;
				}
				set	
				{
					commodityModules = value;
				}
			}

			public class QueryCommodityConfig_CommodityModulesItem
			{

				private string moduleCode;

				private string moduleName;

				private string moduleDescription;

				private string moduleType;

				private string moduleTip;

				private string lxModuleCode;

				private string moduleValue;

				private string moduleUrl;

				private int? sortNumber;

				public string ModuleCode
				{
					get
					{
						return moduleCode;
					}
					set	
					{
						moduleCode = value;
					}
				}

				public string ModuleName
				{
					get
					{
						return moduleName;
					}
					set	
					{
						moduleName = value;
					}
				}

				public string ModuleDescription
				{
					get
					{
						return moduleDescription;
					}
					set	
					{
						moduleDescription = value;
					}
				}

				public string ModuleType
				{
					get
					{
						return moduleType;
					}
					set	
					{
						moduleType = value;
					}
				}

				public string ModuleTip
				{
					get
					{
						return moduleTip;
					}
					set	
					{
						moduleTip = value;
					}
				}

				public string LxModuleCode
				{
					get
					{
						return lxModuleCode;
					}
					set	
					{
						lxModuleCode = value;
					}
				}

				public string ModuleValue
				{
					get
					{
						return moduleValue;
					}
					set	
					{
						moduleValue = value;
					}
				}

				public string ModuleUrl
				{
					get
					{
						return moduleUrl;
					}
					set	
					{
						moduleUrl = value;
					}
				}

				public int? SortNumber
				{
					get
					{
						return sortNumber;
					}
					set	
					{
						sortNumber = value;
					}
				}
			}
		}
	}
}
