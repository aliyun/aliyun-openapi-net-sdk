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
	public class DescribeWebAreaBlockConfigsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeWebAreaBlockConfigs_AreaBlockConfig> areaBlockConfigs;

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

		public List<DescribeWebAreaBlockConfigs_AreaBlockConfig> AreaBlockConfigs
		{
			get
			{
				return areaBlockConfigs;
			}
			set	
			{
				areaBlockConfigs = value;
			}
		}

		public class DescribeWebAreaBlockConfigs_AreaBlockConfig
		{

			private string domain;

			private List<DescribeWebAreaBlockConfigs_Region> regionList;

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public List<DescribeWebAreaBlockConfigs_Region> RegionList
			{
				get
				{
					return regionList;
				}
				set	
				{
					regionList = value;
				}
			}

			public class DescribeWebAreaBlockConfigs_Region
			{

				private int? block;

				private string region;

				public int? Block
				{
					get
					{
						return block;
					}
					set	
					{
						block = value;
					}
				}

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}
			}
		}
	}
}
