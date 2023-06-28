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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeInstanceSecurityConfigsResponse : AcsResponse
	{

		private string requestId;

		private DescribeInstanceSecurityConfigs_InstanceSecurityConfigs instanceSecurityConfigs;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "InstanceSecurityConfigs")]
		public DescribeInstanceSecurityConfigs_InstanceSecurityConfigs InstanceSecurityConfigs
		{
			get
			{
				return instanceSecurityConfigs;
			}
			set	
			{
				instanceSecurityConfigs = value;
			}
		}

		public class DescribeInstanceSecurityConfigs_InstanceSecurityConfigs
		{

			private int? totalCheckCount;

			private int? totalRiskCount;

			private List<DescribeInstanceSecurityConfigs_SecurityConfigsItem> securityConfigs;

			[JsonProperty(PropertyName = "TotalCheckCount")]
			public int? TotalCheckCount
			{
				get
				{
					return totalCheckCount;
				}
				set	
				{
					totalCheckCount = value;
				}
			}

			[JsonProperty(PropertyName = "TotalRiskCount")]
			public int? TotalRiskCount
			{
				get
				{
					return totalRiskCount;
				}
				set	
				{
					totalRiskCount = value;
				}
			}

			[JsonProperty(PropertyName = "SecurityConfigs")]
			public List<DescribeInstanceSecurityConfigs_SecurityConfigsItem> SecurityConfigs
			{
				get
				{
					return securityConfigs;
				}
				set	
				{
					securityConfigs = value;
				}
			}

			public class DescribeInstanceSecurityConfigs_SecurityConfigsItem
			{

				private string configName;

				private bool? risk;

				private string riskDescription;

				private string configGroup;

				private string configDescription;

				[JsonProperty(PropertyName = "ConfigName")]
				public string ConfigName
				{
					get
					{
						return configName;
					}
					set	
					{
						configName = value;
					}
				}

				[JsonProperty(PropertyName = "Risk")]
				public bool? Risk
				{
					get
					{
						return risk;
					}
					set	
					{
						risk = value;
					}
				}

				[JsonProperty(PropertyName = "RiskDescription")]
				public string RiskDescription
				{
					get
					{
						return riskDescription;
					}
					set	
					{
						riskDescription = value;
					}
				}

				[JsonProperty(PropertyName = "ConfigGroup")]
				public string ConfigGroup
				{
					get
					{
						return configGroup;
					}
					set	
					{
						configGroup = value;
					}
				}

				[JsonProperty(PropertyName = "ConfigDescription")]
				public string ConfigDescription
				{
					get
					{
						return configDescription;
					}
					set	
					{
						configDescription = value;
					}
				}
			}
		}
	}
}
