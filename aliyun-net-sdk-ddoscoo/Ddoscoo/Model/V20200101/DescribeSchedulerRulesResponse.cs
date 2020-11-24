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
	public class DescribeSchedulerRulesResponse : AcsResponse
	{

		private string requestId;

		private string totalCount;

		private List<DescribeSchedulerRules_SchedulerRule> schedulerRules;

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

		public string TotalCount
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

		public List<DescribeSchedulerRules_SchedulerRule> SchedulerRules
		{
			get
			{
				return schedulerRules;
			}
			set	
			{
				schedulerRules = value;
			}
		}

		public class DescribeSchedulerRules_SchedulerRule
		{

			private string ruleName;

			private string cname;

			private string ruleType;

			private List<DescribeSchedulerRules_Rule> rules;

			private DescribeSchedulerRules_Param param;

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

			public string Cname
			{
				get
				{
					return cname;
				}
				set	
				{
					cname = value;
				}
			}

			public string RuleType
			{
				get
				{
					return ruleType;
				}
				set	
				{
					ruleType = value;
				}
			}

			public List<DescribeSchedulerRules_Rule> Rules
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

			public DescribeSchedulerRules_Param Param
			{
				get
				{
					return param;
				}
				set	
				{
					param = value;
				}
			}

			public class DescribeSchedulerRules_Rule
			{

				private string type;

				private string _value;

				private int? valueType;

				private int? priority;

				private int? status;

				private string regionId;

				private int? restoreDelay;

				public string Type
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

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public int? ValueType
				{
					get
					{
						return valueType;
					}
					set	
					{
						valueType = value;
					}
				}

				public int? Priority
				{
					get
					{
						return priority;
					}
					set	
					{
						priority = value;
					}
				}

				public int? Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string RegionId
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

				public int? RestoreDelay
				{
					get
					{
						return restoreDelay;
					}
					set	
					{
						restoreDelay = value;
					}
				}
			}

			public class DescribeSchedulerRules_Param
			{

				private string paramType;

				private DescribeSchedulerRules_ParamData paramData;

				public string ParamType
				{
					get
					{
						return paramType;
					}
					set	
					{
						paramType = value;
					}
				}

				public DescribeSchedulerRules_ParamData ParamData
				{
					get
					{
						return paramData;
					}
					set	
					{
						paramData = value;
					}
				}

				public class DescribeSchedulerRules_ParamData
				{

					private string cloudInstanceId;

					public string CloudInstanceId
					{
						get
						{
							return cloudInstanceId;
						}
						set	
						{
							cloudInstanceId = value;
						}
					}
				}
			}
		}
	}
}
