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
	public class DescribeRiskTypeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRiskType_RiskType> riskTypes;

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

		public List<DescribeRiskType_RiskType> RiskTypes
		{
			get
			{
				return riskTypes;
			}
			set	
			{
				riskTypes = value;
			}
		}

		public class DescribeRiskType_RiskType
		{

			private string typeName;

			private string alias;

			private List<DescribeRiskType_SubType> subTypes;

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

			public List<DescribeRiskType_SubType> SubTypes
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

			public class DescribeRiskType_SubType
			{

				private string typeName;

				private string alias;

				private List<DescribeRiskType_CheckDetail> checkDetails;

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

				public List<DescribeRiskType_CheckDetail> CheckDetails
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

				public class DescribeRiskType_CheckDetail
				{

					private long? checkId;

					private string checkItem;

					private string checkDesc;

					private List<DescribeRiskType_Rule> rules;

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

					public List<DescribeRiskType_Rule> Rules
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

					public class DescribeRiskType_Rule
					{

						private int? optional;

						private string ruleDesc;

						private int? defaultValue;

						private string ruleId;

						private List<DescribeRiskType_Param> paramList;

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

						public List<DescribeRiskType_Param> ParamList
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

						public class DescribeRiskType_Param
						{

							private string paramDefaultValue;

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
