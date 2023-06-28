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
	public class DescribeTenantSecurityConfigsResponse : AcsResponse
	{

		private string requestId;

		private DescribeTenantSecurityConfigs_Configs configs;

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

		[JsonProperty(PropertyName = "Configs")]
		public DescribeTenantSecurityConfigs_Configs Configs
		{
			get
			{
				return configs;
			}
			set	
			{
				configs = value;
			}
		}

		public class DescribeTenantSecurityConfigs_Configs
		{

			private int? totalCheckCount;

			private int? totalRiskCount;

			private List<DescribeTenantSecurityConfigs_TenantSecurityConfigsItem> tenantSecurityConfigs;

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

			[JsonProperty(PropertyName = "TenantSecurityConfigs")]
			public List<DescribeTenantSecurityConfigs_TenantSecurityConfigsItem> TenantSecurityConfigs
			{
				get
				{
					return tenantSecurityConfigs;
				}
				set	
				{
					tenantSecurityConfigs = value;
				}
			}

			public class DescribeTenantSecurityConfigs_TenantSecurityConfigsItem
			{

				private string tenantId;

				private string tenantName;

				private int? riskCount;

				private List<DescribeTenantSecurityConfigs_SecurityConfigsItem> securityConfigs;

				[JsonProperty(PropertyName = "TenantId")]
				public string TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
					}
				}

				[JsonProperty(PropertyName = "TenantName")]
				public string TenantName
				{
					get
					{
						return tenantName;
					}
					set	
					{
						tenantName = value;
					}
				}

				[JsonProperty(PropertyName = "RiskCount")]
				public int? RiskCount
				{
					get
					{
						return riskCount;
					}
					set	
					{
						riskCount = value;
					}
				}

				[JsonProperty(PropertyName = "SecurityConfigs")]
				public List<DescribeTenantSecurityConfigs_SecurityConfigsItem> SecurityConfigs
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

				public class DescribeTenantSecurityConfigs_SecurityConfigsItem
				{

					private string configGroup;

					private string configName;

					private bool? risk;

					private string riskDescription;

					private string configDescription;

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
}
