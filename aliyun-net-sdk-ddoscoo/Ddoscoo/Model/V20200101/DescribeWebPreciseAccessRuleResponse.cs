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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeWebPreciseAccessRuleResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeWebPreciseAccessRule_PreciseAccessConfig> preciseAccessConfigList;

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

		public List<DescribeWebPreciseAccessRule_PreciseAccessConfig> PreciseAccessConfigList
		{
			get
			{
				return preciseAccessConfigList;
			}
			set	
			{
				preciseAccessConfigList = value;
			}
		}

		public class DescribeWebPreciseAccessRule_PreciseAccessConfig
		{

			private string domain;

			private List<DescribeWebPreciseAccessRule_Rule> ruleList;

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

			public List<DescribeWebPreciseAccessRule_Rule> RuleList
			{
				get
				{
					return ruleList;
				}
				set	
				{
					ruleList = value;
				}
			}

			public class DescribeWebPreciseAccessRule_Rule
			{

				private string action;

				private string owner;

				private long? expires;

				private string name;

				private List<DescribeWebPreciseAccessRule_Condition> conditionList;

				public string Action
				{
					get
					{
						return action;
					}
					set	
					{
						action = value;
					}
				}

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
					}
				}

				public long? Expires
				{
					get
					{
						return expires;
					}
					set	
					{
						expires = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public List<DescribeWebPreciseAccessRule_Condition> ConditionList
				{
					get
					{
						return conditionList;
					}
					set	
					{
						conditionList = value;
					}
				}

				public class DescribeWebPreciseAccessRule_Condition
				{

					private string matchMethod;

					private string field;

					private string content;

					private string headerName;

					public string MatchMethod
					{
						get
						{
							return matchMethod;
						}
						set	
						{
							matchMethod = value;
						}
					}

					public string Field
					{
						get
						{
							return field;
						}
						set	
						{
							field = value;
						}
					}

					public string Content
					{
						get
						{
							return content;
						}
						set	
						{
							content = value;
						}
					}

					public string HeaderName
					{
						get
						{
							return headerName;
						}
						set	
						{
							headerName = value;
						}
					}
				}
			}
		}
	}
}
