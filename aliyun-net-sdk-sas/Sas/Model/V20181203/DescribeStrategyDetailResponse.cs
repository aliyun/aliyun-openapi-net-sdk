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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeStrategyDetailResponse : AcsResponse
	{

		private string requestId;

		private DescribeStrategyDetail_Strategy strategy;

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

		public DescribeStrategyDetail_Strategy Strategy
		{
			get
			{
				return strategy;
			}
			set	
			{
				strategy = value;
			}
		}

		public class DescribeStrategyDetail_Strategy
		{

			private int? type;

			private int? cycleDays;

			private string name;

			private int? id;

			private int? cycleStartTime;

			private List<DescribeStrategyDetail_RiskTypeWhiteListQueryResult> riskTypeWhiteListQueryResultList;

			public int? Type
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

			public int? CycleDays
			{
				get
				{
					return cycleDays;
				}
				set	
				{
					cycleDays = value;
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

			public int? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public int? CycleStartTime
			{
				get
				{
					return cycleStartTime;
				}
				set	
				{
					cycleStartTime = value;
				}
			}

			public List<DescribeStrategyDetail_RiskTypeWhiteListQueryResult> RiskTypeWhiteListQueryResultList
			{
				get
				{
					return riskTypeWhiteListQueryResultList;
				}
				set	
				{
					riskTypeWhiteListQueryResultList = value;
				}
			}

			public class DescribeStrategyDetail_RiskTypeWhiteListQueryResult
			{

				private string typeName;

				private string alias;

				private bool? on;

				private List<DescribeStrategyDetail_SubType> subTypes;

				public string TypeName
				{
					get
					{
						return typeName;
					}
					set	
					{
						typeName = value;
					}
				}

				public string Alias
				{
					get
					{
						return alias;
					}
					set	
					{
						alias = value;
					}
				}

				public bool? On
				{
					get
					{
						return on;
					}
					set	
					{
						on = value;
					}
				}

				public List<DescribeStrategyDetail_SubType> SubTypes
				{
					get
					{
						return subTypes;
					}
					set	
					{
						subTypes = value;
					}
				}

				public class DescribeStrategyDetail_SubType
				{

					private string typeName;

					private string alias;

					private bool? on;

					private List<DescribeStrategyDetail_CheckDetail> checkDetails;

					public string TypeName
					{
						get
						{
							return typeName;
						}
						set	
						{
							typeName = value;
						}
					}

					public string Alias
					{
						get
						{
							return alias;
						}
						set	
						{
							alias = value;
						}
					}

					public bool? On
					{
						get
						{
							return on;
						}
						set	
						{
							on = value;
						}
					}

					public List<DescribeStrategyDetail_CheckDetail> CheckDetails
					{
						get
						{
							return checkDetails;
						}
						set	
						{
							checkDetails = value;
						}
					}

					public class DescribeStrategyDetail_CheckDetail
					{

						private long? checkId;

						private string checkItem;

						private string checkDesc;

						private List<DescribeStrategyDetail_Rule> rules;

						public long? CheckId
						{
							get
							{
								return checkId;
							}
							set	
							{
								checkId = value;
							}
						}

						public string CheckItem
						{
							get
							{
								return checkItem;
							}
							set	
							{
								checkItem = value;
							}
						}

						public string CheckDesc
						{
							get
							{
								return checkDesc;
							}
							set	
							{
								checkDesc = value;
							}
						}

						public List<DescribeStrategyDetail_Rule> Rules
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

						public class DescribeStrategyDetail_Rule
						{

							private int? optional;

							private string ruleDesc;

							private int? defaultValue;

							private string ruleId;

							private List<DescribeStrategyDetail_Param> paramList;

							public int? Optional
							{
								get
								{
									return optional;
								}
								set	
								{
									optional = value;
								}
							}

							public string RuleDesc
							{
								get
								{
									return ruleDesc;
								}
								set	
								{
									ruleDesc = value;
								}
							}

							public int? DefaultValue
							{
								get
								{
									return defaultValue;
								}
								set	
								{
									defaultValue = value;
								}
							}

							public string RuleId
							{
								get
								{
									return ruleId;
								}
								set	
								{
									ruleId = value;
								}
							}

							public List<DescribeStrategyDetail_Param> ParamList
							{
								get
								{
									return paramList;
								}
								set	
								{
									paramList = value;
								}
							}

							public class DescribeStrategyDetail_Param
							{

								private string paramDefaultValue;

								private string _value;

								private string paramName;

								private int? maxValue;

								private int? paramType;

								private string paramDesc;

								private int? minValue;

								private string enumValue;

								public string ParamDefaultValue
								{
									get
									{
										return paramDefaultValue;
									}
									set	
									{
										paramDefaultValue = value;
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

								public string ParamName
								{
									get
									{
										return paramName;
									}
									set	
									{
										paramName = value;
									}
								}

								public int? MaxValue
								{
									get
									{
										return maxValue;
									}
									set	
									{
										maxValue = value;
									}
								}

								public int? ParamType
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

								public string ParamDesc
								{
									get
									{
										return paramDesc;
									}
									set	
									{
										paramDesc = value;
									}
								}

								public int? MinValue
								{
									get
									{
										return minValue;
									}
									set	
									{
										minValue = value;
									}
								}

								public string EnumValue
								{
									get
									{
										return enumValue;
									}
									set	
									{
										enumValue = value;
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
