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
	public class DescribePluginsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribePlugins_PluginAttribute> plugins;

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

		public List<DescribePlugins_PluginAttribute> Plugins
		{
			get
			{
				return plugins;
			}
			set	
			{
				plugins = value;
			}
		}

		public class DescribePlugins_PluginAttribute
		{

			private string pluginId;

			private string pluginType;

			private string pluginName;

			private string pluginData;

			private int? regionId;

			private int? description;

			private string createdTime;

			private string modifiedTime;

			public string PluginId
			{
				get
				{
					return pluginId;
				}
				set	
				{
					pluginId = value;
				}
			}

			public string PluginType
			{
				get
				{
					return pluginType;
				}
				set	
				{
					pluginType = value;
				}
			}

			public string PluginName
			{
				get
				{
					return pluginName;
				}
				set	
				{
					pluginName = value;
				}
			}

			public string PluginData
			{
				get
				{
					return pluginData;
				}
				set	
				{
					pluginData = value;
				}
			}

			public int? RegionId
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

			public int? Description
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
		}
	}
}