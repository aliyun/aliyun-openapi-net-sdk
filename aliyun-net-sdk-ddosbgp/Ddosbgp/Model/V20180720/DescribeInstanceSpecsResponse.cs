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

namespace Aliyun.Acs.ddosbgp.Model.V20180720
{
	public class DescribeInstanceSpecsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstanceSpecs_InstanceSpec> instanceSpecs;

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

		public List<DescribeInstanceSpecs_InstanceSpec> InstanceSpecs
		{
			get
			{
				return instanceSpecs;
			}
			set	
			{
				instanceSpecs = value;
			}
		}

		public class DescribeInstanceSpecs_InstanceSpec
		{

			private int? isFullDefenseMode;

			private string region;

			private int? availableDefenseTimes;

			private int? totalDefenseTimes;

			private string availableDeleteBlackholeCount;

			private string instanceId;

			private DescribeInstanceSpecs_PackConfig packConfig;

			public int? IsFullDefenseMode
			{
				get
				{
					return isFullDefenseMode;
				}
				set	
				{
					isFullDefenseMode = value;
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

			public int? AvailableDefenseTimes
			{
				get
				{
					return availableDefenseTimes;
				}
				set	
				{
					availableDefenseTimes = value;
				}
			}

			public int? TotalDefenseTimes
			{
				get
				{
					return totalDefenseTimes;
				}
				set	
				{
					totalDefenseTimes = value;
				}
			}

			public string AvailableDeleteBlackholeCount
			{
				get
				{
					return availableDeleteBlackholeCount;
				}
				set	
				{
					availableDeleteBlackholeCount = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public DescribeInstanceSpecs_PackConfig PackConfig
			{
				get
				{
					return packConfig;
				}
				set	
				{
					packConfig = value;
				}
			}

			public class DescribeInstanceSpecs_PackConfig
			{

				private int? packBasicThre;

				private int? bindIpCount;

				private int? packAdvThre;

				private int? normalBandwidth;

				private int? ipBasicThre;

				private int? ipAdvanceThre;

				private int? ipSpec;

				private long? bandwidth;

				public int? PackBasicThre
				{
					get
					{
						return packBasicThre;
					}
					set	
					{
						packBasicThre = value;
					}
				}

				public int? BindIpCount
				{
					get
					{
						return bindIpCount;
					}
					set	
					{
						bindIpCount = value;
					}
				}

				public int? PackAdvThre
				{
					get
					{
						return packAdvThre;
					}
					set	
					{
						packAdvThre = value;
					}
				}

				public int? NormalBandwidth
				{
					get
					{
						return normalBandwidth;
					}
					set	
					{
						normalBandwidth = value;
					}
				}

				public int? IpBasicThre
				{
					get
					{
						return ipBasicThre;
					}
					set	
					{
						ipBasicThre = value;
					}
				}

				public int? IpAdvanceThre
				{
					get
					{
						return ipAdvanceThre;
					}
					set	
					{
						ipAdvanceThre = value;
					}
				}

				public int? IpSpec
				{
					get
					{
						return ipSpec;
					}
					set	
					{
						ipSpec = value;
					}
				}

				public long? Bandwidth
				{
					get
					{
						return bandwidth;
					}
					set	
					{
						bandwidth = value;
					}
				}
			}
		}
	}
}
