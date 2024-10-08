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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.ResourceCenter.Model.V20221201
{
	public class ListFiltersResponse : AcsResponse
	{

		private string requestId;

		private string defaultFilterName;

		private List<ListFilters_Filter> filters;

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

		public string DefaultFilterName
		{
			get
			{
				return defaultFilterName;
			}
			set	
			{
				defaultFilterName = value;
			}
		}

		public List<ListFilters_Filter> Filters
		{
			get
			{
				return filters;
			}
			set	
			{
				filters = value;
			}
		}

		public class ListFilters_Filter
		{

			private string filterName;

			private string filterConfiguration;

			public string FilterName
			{
				get
				{
					return filterName;
				}
				set	
				{
					filterName = value;
				}
			}

			public string FilterConfiguration
			{
				get
				{
					return filterConfiguration;
				}
				set	
				{
					filterConfiguration = value;
				}
			}
		}
	}
}
