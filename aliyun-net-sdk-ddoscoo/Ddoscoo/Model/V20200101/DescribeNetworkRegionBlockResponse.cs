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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeNetworkRegionBlockResponse : AcsResponse
	{

		private string requestId;

		private DescribeNetworkRegionBlock_Config config;

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

		public DescribeNetworkRegionBlock_Config Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
			}
		}

		public class DescribeNetworkRegionBlock_Config
		{

			private string regionBlockSwitch;

			private List<string> countries;

			private List<string> provinces;

			public string RegionBlockSwitch
			{
				get
				{
					return regionBlockSwitch;
				}
				set	
				{
					regionBlockSwitch = value;
				}
			}

			public List<string> Countries
			{
				get
				{
					return countries;
				}
				set	
				{
					countries = value;
				}
			}

			public List<string> Provinces
			{
				get
				{
					return provinces;
				}
				set	
				{
					provinces = value;
				}
			}
		}
	}
}
