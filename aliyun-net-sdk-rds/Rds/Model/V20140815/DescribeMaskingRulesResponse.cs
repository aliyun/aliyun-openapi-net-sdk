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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeMaskingRulesResponse : AcsResponse
	{

		private string requestId;

		private DescribeMaskingRules_Data data;

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

		[JsonProperty(PropertyName = "Data")]
		public DescribeMaskingRules_Data Data
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

		public class DescribeMaskingRules_Data
		{

			private List<DescribeMaskingRules_EncDBInfo> rules;

			[JsonProperty(PropertyName = "Rules")]
			public List<DescribeMaskingRules_EncDBInfo> Rules
			{
				get
				{
					return rules;
				}
				set	
				{
					rules = value;
				}
			}

			public class DescribeMaskingRules_EncDBInfo
			{

				private string ruleName;

				private string enabled;

				private string defaultAlgo;

				private string maskingAlgo;

				private DescribeMaskingRules_RuleConfig ruleConfig;

				[JsonProperty(PropertyName = "RuleName")]
				public string RuleName
				{
					get
					{
						return ruleName;
					}
					set	
					{
						ruleName = value;
					}
				}

				[JsonProperty(PropertyName = "Enabled")]
				public string Enabled
				{
					get
					{
						return enabled;
					}
					set	
					{
						enabled = value;
					}
				}

				[JsonProperty(PropertyName = "DefaultAlgo")]
				public string DefaultAlgo
				{
					get
					{
						return defaultAlgo;
					}
					set	
					{
						defaultAlgo = value;
					}
				}

				[JsonProperty(PropertyName = "MaskingAlgo")]
				public string MaskingAlgo
				{
					get
					{
						return maskingAlgo;
					}
					set	
					{
						maskingAlgo = value;
					}
				}

				[JsonProperty(PropertyName = "RuleConfig")]
				public DescribeMaskingRules_RuleConfig RuleConfig
				{
					get
					{
						return ruleConfig;
					}
					set	
					{
						ruleConfig = value;
					}
				}

				public class DescribeMaskingRules_RuleConfig
				{

					private List<string> databases;

					private List<string> tables;

					private List<string> columns;

					[JsonProperty(PropertyName = "Databases")]
					public List<string> Databases
					{
						get
						{
							return databases;
						}
						set	
						{
							databases = value;
						}
					}

					[JsonProperty(PropertyName = "Tables")]
					public List<string> Tables
					{
						get
						{
							return tables;
						}
						set	
						{
							tables = value;
						}
					}

					[JsonProperty(PropertyName = "Columns")]
					public List<string> Columns
					{
						get
						{
							return columns;
						}
						set	
						{
							columns = value;
						}
					}
				}
			}
		}
	}
}
